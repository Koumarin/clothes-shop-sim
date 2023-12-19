using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyText : MonoBehaviour
{
	[SerializeField]
	private TMP_Text text;

	private int money = 1000;

	void Start()
	{
		text.text = ToMoney(money);
	}

	public void OnMoneyChanged(int amount)
	{
		money     = amount;
		text.text = ToMoney(money);
	}

	private string ToMoney(int amount)
	{
		return "$" + amount.ToString();
	}
}
