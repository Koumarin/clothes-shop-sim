using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private float walkSpeed;
	[SerializeField]
	private float acceleration;

	private Rigidbody2D body;

	private Vector2 direction;

	void Start()
	{
		body = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		var finalVelocity = direction * walkSpeed;

		body.velocity = Vector2.Lerp(body.velocity,
		                             finalVelocity,
		                             acceleration);
	}

	public void OnMove(InputAction.CallbackContext context)
	{
		direction = context.ReadValue<Vector2>();
	}
}
