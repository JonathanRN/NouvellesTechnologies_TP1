using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
	[SerializeField] private Text text;

	private CharacterInfo characterInfo;

	private void Awake()
	{
		characterInfo = GameObject.FindWithTag("GameController").GetComponent<CharacterInfo>();
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
		string title = text.text;

		text.text = characterInfo.GetName() + ", the " + characterInfo.GetRace() + " " + characterInfo.GetClass();
	}
}
