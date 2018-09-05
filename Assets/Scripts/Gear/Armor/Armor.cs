using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor
{
    public string Name { get; set; }
    public ArmorType ArmorType { get; set; }
    public float ArmorValue { get; set; }
    public float Durability { get; set; }

    public Armor(string name, ArmorType armorType, float armorValue, float durability)
    {
        Name = name;
        ArmorType = armorType;
        ArmorValue = armorValue;
        Durability = durability;
    }
}
