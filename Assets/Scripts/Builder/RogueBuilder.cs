using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueBuilder : CharacterBuilder {

	private Character character;
    
	public RogueBuilder()
	{
		character = new Character();
	}

	public override Character Build()
	{
		character.Class = Classes.Rogue;
		character.Weapon = new Weapon("Basic Dagger",WeaponType.Dagger,4,100);
		character.Armor = new Armor("Basic Leather Armor",ArmorType.Leather,3,100) ;
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
