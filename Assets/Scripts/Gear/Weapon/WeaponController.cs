using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
	[SerializeField] private string spritesPath = "Sprites/" ;
	
	private SpriteRenderer weaponRenderer;
	private Sprite weaponSprite;
	private CharacterInfo characterInfo;
	
	private void Awake ()
	{
		weaponRenderer = transform.parent.GetComponentInChildren<SpriteRenderer>();
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
		weaponSprite = Resources.Load<Sprite>(spritesPath + characterInfo.Character.Weapon.WeaponType);
		weaponRenderer.sprite = weaponSprite;
	}

}
