using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
	public GameObject shopMenu;

	void Start()
	{
		shopMenu.SetActive(false);
	}

	void Update()
	{

	}

	public void OpenMenu()
	{
		shopMenu.SetActive(true);
		Time.timeScale = 0f;
	}

	public void CloseMenu()
	{
		shopMenu.SetActive(false);
		Time.timeScale = 1f;
	}
}
