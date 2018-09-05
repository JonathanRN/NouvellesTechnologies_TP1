using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageBuilder : CharacterBuilder {

	private Character character;
    
	public MageBuilder()
	{
		character = new Character();
	}

	public override Character Build()
	{
		character.Class = Classes.Mage;
		character.Weapon = new Weapon("Basic Scepter",WeaponType.Scepter,4,100);
		character.Armor = new Armor("Basic Cloth Armor",ArmorType.Cloth,3,100) ;
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
