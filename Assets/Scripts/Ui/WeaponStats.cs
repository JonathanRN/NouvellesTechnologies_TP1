using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponStats : MonoBehaviour
{
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
		var weapon = characterInfo.Character.Weapon;
		
		text.text = String.Format("Name: {0}\nType: {1}\nDamage: {2}\nDurability: {3}",
			weapon.Name,
			weapon.WeaponType.ToString(),
			weapon.Damage.ToString(),
			weapon.Durability.ToString());
	}
}