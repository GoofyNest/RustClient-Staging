public class Inventory : ConsoleSystem // TypeDefIndex: 11938
{	private static float _quickCraftDelay; // 0x2B104D4

	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float quickcraftdelay { get; set; }


	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static void defs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static void reloaddefs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void toggle() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void examineheld() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void togglecrafting() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void ResetCraftCounts() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void ListCraftCounts() { }

	public static float get_quickcraftdelay() { }

	public static void set_quickcraftdelay(float value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Inventory.<>c // TypeDefIndex: 11939
{	public static readonly Inventory.<>c <>9; // 0x0
	public static Func<InventoryDef, string> <>9__0_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <defs>b__0_0(InventoryDef x) { }

}

