using UnityEngine;

public enum Races   {

	None,
	Human,
	Gnome,
	Elf,
	Orc,
	Undead
}

public static class RaceColor
{
	public static Color None = new Color(255/255.0f, 255/255.0f, 255/255.0f);
	public static Color Orc = new Color(1/255.0f, 108/255.0f, 0/255.0f);
	public static Color Human = new Color(255/255.0f, 207/255.0f, 165/255.0f);
	public static Color Gnome = new Color(255/255.0f, 207/255.0f, 165/255.0f);
	public static Color Elf = new Color(72/255.0f, 0/255.0f, 87/255.0f);
	public static Color Undead = new Color(193/255.0f, 193/255.0f, 193/255.0f);
}
