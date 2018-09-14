using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorStats : MonoBehaviour {

	private Text text;

	private CharacterInfo characterInfo;

	private void Awake()
	{
		characterInfo = GameObject.FindWithTag("GameController").GetComponent<CharacterInfo>();
		text = GetComponent<Text>();
	}

	private void OnEnable()
	{
		characterInfo.OnBuild += OnBuild;
	}

	private void OnDisable()
	{
		characterInfo.OnBuild -= OnBuild;
	}

	private void OnBuild()
	{
		var armor = characterInfo.Character.Armor;
		
		text.text = String.Format("Name: {0}\nType: {1}\nValue: {2}\nDurability: {3}",
			armor.Name,
			armor.ArmorType.ToString(),
			armor.ArmorValue.ToString(),
			armor.Durability.ToString());
	}
}
