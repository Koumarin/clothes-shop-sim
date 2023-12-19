using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopItem : MonoBehaviour
{
	[SerializeField]
	private string item_name;
	[SerializeField]
	private int price;
	[SerializeField]
	private TMP_Text name_text;
	[SerializeField]
	private TMP_Text price_text;

	void Start()
	{
		name_text.text  = item_name;
		price_text.text = "$" + price.ToString();
	}

	public void OnPurchase()
	{
		Debug.Log(price.ToString() + " deducted.");
	}
}
