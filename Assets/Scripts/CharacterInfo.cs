using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfo : MonoBehaviour
{
	[SerializeField] private Text name;
	[SerializeField] private Text classText;
	[SerializeField] private Text raceText;
	[SerializeField] private Button buildButton;

	private string characterClassValue;
	private string characterRaceValue;
	private CharacterBuildDirector characterBuildDirector;
	
	private Classes characterClass;
	private Races characterRace;
	
	public Character Character { get; set; }

	private void Awake()
	{
		buildButton.onClick.AddListener(delegate { OnButtonBuildClick(); });
		characterBuildDirector = new CharacterBuildDirector(this);
	}
	
	public string GetName()
	{
		return name.text;
	}

	public Classes GetClass()
	{
		return Enum.TryParse(classText.text, out characterClass) ? characterClass : Classes.None;
	}
	
	public Races GetRace()
	{
		return Enum.TryParse(raceText.text, out characterRace) ? characterRace : Races.None;
	}

	private void OnButtonBuildClick()
	{
		Character = characterBuildDirector.construct();
	}
	
	public CharacterBuilder GetClassBuilder()
	{
		var currentClass = GetClass();

		switch (currentClass)
		{
			case Classes.Mage:
				return new MageBuilder();
			case Classes.Hunter:
				return new HunterBuilder();
			case Classes.Warrior:
				return new WarriorBuilder();
			case Classes.Rogue:
				return new RogueBuilder();
			case Classes.None:
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}

		return null;
	}
}
