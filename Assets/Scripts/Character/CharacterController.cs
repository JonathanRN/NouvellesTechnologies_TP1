using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	private CharacterInfo characterInfo;
	private SpriteRenderer characterRenderer;

	private void Awake()
	{
		characterInfo = GameObject.FindWithTag("GameController").GetComponent<CharacterInfo>();
		characterRenderer = GetComponent<SpriteRenderer>();
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
		SetCharacterRaceColor();
	}

	private void SetCharacterRaceColor()
	{
		var race = characterInfo.GetRace();

		switch (race)
		{
			case Races.None:
				characterRenderer.color = RaceColor.None;
				break;
			case Races.Human:
				characterRenderer.color = RaceColor.Human;
				break;
			case Races.Gnome:
				characterRenderer.color = RaceColor.Gnome;
				break;
			case Races.Elf:
				characterRenderer.color = RaceColor.Elf;
				break;
			case Races.Orc:
				characterRenderer.color = RaceColor.Orc;
				break;
			case Races.Undead:
				characterRenderer.color = RaceColor.Undead;
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}
