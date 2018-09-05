using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
	private Weapon weapon;
	private SpriteRenderer weaponRenderer;
	private Sprite weaponSprite;
	
	// Use this for initialization
	void Awake ()
	{
		weaponRenderer = transform.parent.GetComponentInChildren<SpriteRenderer>();
		weaponSprite = Resources.Load("Sprites/axe") as Sprite;
		Debug.Log(Resources.Load("Sprites/axe") as Sprite);
		weaponRenderer.sprite = weaponSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
