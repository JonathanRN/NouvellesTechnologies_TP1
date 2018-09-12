using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorController : MonoBehaviour
{
	private Armor armor;
	private SpriteRenderer armorRenderer;
	private Sprite armorSprite;
	
	// Use this for initialization
	void Awake ()
	{
		armorRenderer = transform.parent.GetComponentInChildren<SpriteRenderer>();
		armorSprite = Resources.Load<Sprite>("Sprites/fullplateArmor");
		armorRenderer.sprite = armorSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
