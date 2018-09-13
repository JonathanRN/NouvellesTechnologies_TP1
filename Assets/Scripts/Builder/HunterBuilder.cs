using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterBuilder : CharacterBuilder 
{
	private Character character;
    
	public HunterBuilder()
	{
		character = new Character();
	}

	public override Character Build()
	{
		character.Class = Classes.Hunter;
		character.Weapon = new Weapon("Basic Bow",WeaponType.Bow,2,100);
		character.Armor = new Armor("Basic Mail Armor",ArmorType.Mail,3,100) ;
		return character;
	}

	public override CharacterBuilder SetName(string name)
	{
		character.Name = name;
		return this;
	}

	public override CharacterBuilder SetRace(Races race)
	{
		character.Race = race;
		return this;
	}
}