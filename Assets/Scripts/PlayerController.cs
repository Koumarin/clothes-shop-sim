using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private int walkSpeed;

	private Rigidbody2D body;

	private Vector2 direction;

	void Start()
	{
		body = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		body.velocity = direction * Time.deltaTime * walkSpeed;
	}

	public void OnMove(InputAction.CallbackContext context)
	{
		direction = context.ReadValue<Vector2>();
	}
}
