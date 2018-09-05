using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBuildDirector  {

	private CharacterBuilder builder;
	private CharacterInfo characterInfo;

	public CharacterBuildDirector(CharacterInfo characterInfo)
	{
		this.characterInfo = characterInfo;
	}

	public Character construct()
	{
		builder = characterInfo.GetClassBuilder();
		return builder.SetName(characterInfo.GetName())
					  .SetRace(characterInfo.GetRace())
					  .Build();
	}

}
