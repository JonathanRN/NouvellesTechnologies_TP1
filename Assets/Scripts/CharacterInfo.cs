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
	
	private Classes characterClass;
	private Races characterRace;

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
	
	private void Awake()
	{
		buildButton.onClick.AddListener(delegate { OnButtonBuildClick(); });
	}

	private void OnButtonBuildClick()
	{
		Debug.Log("Button build clicked!");
		Debug.Log(GetName());
		Debug.Log(GetClass().ToString());
		Debug.Log(GetRace().ToString());
	}
}
