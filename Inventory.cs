public class Inventory : ConsoleSystem // TypeDefIndex: 11942
{	private static float _quickCraftDelay; // 0x1E96C

	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static float quickcraftdelay { get; set; }


	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static void defs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	[ServerVar] // RVA: 0x93230 Offset: 0x92630 VA: 0x180093230
	public static void reloaddefs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void toggle() { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void examineheld() { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void togglecrafting() { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void ResetCraftCounts() { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static void ListCraftCounts() { }

	public static float get_quickcraftdelay() { }

	public static void set_quickcraftdelay(float value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Inventory.<>c // TypeDefIndex: 11943
{	public static readonly Inventory.<>c <>9; // 0x0
	public static Func<InventoryDef, string> <>9__0_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <defs>b__0_0(InventoryDef x) { }

}

