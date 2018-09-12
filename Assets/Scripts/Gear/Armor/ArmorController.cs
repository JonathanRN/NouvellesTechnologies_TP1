using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorController : MonoBehaviour
{
	[SerializeField] private string spritesPath = "Sprites/" ;
	
	private Armor armor;
	private SpriteRenderer armorRenderer;
	private Sprite armorSprite;
	private CharacterInfo characterInfo;
	
	// Use this for initialization
	void Awake ()
	{
		armorRenderer = transform.parent.GetComponentInChildren<SpriteRenderer>();
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
		armor = characterInfo.Character.Armor;
		armorSprite = Resources.Load<Sprite>(spritesPath + characterInfo.Character.Armor.ArmorType);
		armorRenderer.sprite = armorSprite;
	}
}
