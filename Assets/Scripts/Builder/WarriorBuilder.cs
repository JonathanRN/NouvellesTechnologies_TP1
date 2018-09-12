using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBuilder : CharacterBuilder
{
    private GameObject characterObject;
    
    private Character character;
    
    public WarriorBuilder()
    {
        character = new Character();
    }

    public override Character Build()
    {
        character.Class = Classes.Warrior;
        character.Weapon = new Weapon("Basic Axe",WeaponType.Axe,5,100);
        character.Armor = new Armor("Basic Plate Armor",ArmorType.Plate,5,100) ;
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
