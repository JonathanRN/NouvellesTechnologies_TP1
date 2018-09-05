using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor
{
    public string WeaponName { get; set; }
    public ArmorType ArmorType { get; set; }
    public float ArmorValue { get; set; }
    public float Durability { get; set; }

    public Armor(string weaponName, ArmorType armorType, float armorValue, float durability)
    {
        WeaponName = weaponName;
        ArmorType = armorType;
        ArmorValue = armorValue;
        Durability = durability;
    }
}
