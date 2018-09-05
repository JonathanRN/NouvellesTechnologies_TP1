using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon  {

	public string Name { get; set; }
	public WeaponType WeaponType { get; set; }
	public float Damage { get; set; }
	public float Durability { get; set; }

	public Weapon(string name, WeaponType weaponType, float damage, float durability)
	{
		Name = name;
		WeaponType = weaponType;
		Damage = damage;
		Durability = durability;
	}
}
