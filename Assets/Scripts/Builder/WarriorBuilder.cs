using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBuilder : CharacterBuilder
{

    private Character character;
    
    public WarriorBuilder()
    {
        character = new Character();
    }

    public override Character Build()
    {
        return character;
    }

    public override CharacterBuilder SetName(string name)
    {
        character.Name = name;
        return this;
    }
}
