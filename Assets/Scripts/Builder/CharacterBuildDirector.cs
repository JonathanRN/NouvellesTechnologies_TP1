using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBuildDirector  {

	private CharacterBuilder builder;

	public CharacterBuildDirector(CharacterBuilder builder) {
		this.builder = builder;
	}

	public Character construct() {
		return builder.SetName("NanNNiiii")
			.Build();
	}

}
