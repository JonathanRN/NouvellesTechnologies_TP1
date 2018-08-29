using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class CharacterBuilder
{
   public abstract Character Build();

   public abstract CharacterBuilder SetName(string name);

}
