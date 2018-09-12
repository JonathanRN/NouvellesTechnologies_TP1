using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
	private Weapon weapon;
	private SpriteRenderer weaponRenderer;
	private Sprite weaponSprite;
	private CharacterInfo characterInfo;
	
	// Use this for initialization
	void Awake ()
	{
		weaponRenderer = transform.parent.GetComponentInChildren<SpriteRenderer>();
		weaponSprite = Resources.Load<Sprite>("Sprites/axe");
		weaponRenderer.sprite = weaponSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
