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
	public static Color None = new Color(255, 255, 255);
	public static Color Orc = new Color(1, 108, 0);
	public static Color Human = new Color(255, 207, 165);
	public static Color Gnome = new Color(255, 207, 165);
	public static Color Elf = new Color(72, 0, 87);
	public static Color Undead = new Color(193, 193, 193);
}
