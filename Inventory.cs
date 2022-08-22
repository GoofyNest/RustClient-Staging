public class Inventory : ConsoleSystem // TypeDefIndex: 11938
{	// Fields
	private static float _quickCraftDelay; // 0x20460

	// Properties
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float quickcraftdelay { get; set; }

	// Methods

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x3646C0 Offset: 0x362CC0 VA: 0x1803646C0
	public static void defs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x364A70 Offset: 0x363070 VA: 0x180364A70
	public static void reloaddefs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x364B30 Offset: 0x363130 VA: 0x180364B30
	public static void toggle() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x3648C0 Offset: 0x362EC0 VA: 0x1803648C0
	public static void examineheld() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x364B90 Offset: 0x363190 VA: 0x180364B90
	public static void togglecrafting() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x3645A0 Offset: 0x362BA0 VA: 0x1803645A0
	public static void ResetCraftCounts() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x364520 Offset: 0x362B20 VA: 0x180364520
	public static void ListCraftCounts() { }

	// RVA: 0x364A10 Offset: 0x363010 VA: 0x180364A10
	public static float get_quickcraftdelay() { }

	// RVA: 0x364A80 Offset: 0x363080 VA: 0x180364A80
	public static void set_quickcraftdelay(float value) { }

	// RVA: 0x364660 Offset: 0x362C60 VA: 0x180364660
	public void .ctor() { }

	// RVA: 0x364620 Offset: 0x362C20 VA: 0x180364620
	private static void .cctor() { }

}

private sealed class Inventory.<>c // TypeDefIndex: 11939
{	// Fields
	public static readonly Inventory.<>c <>9; // 0x0
	public static Func<InventoryDef, string> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x36D620 Offset: 0x36BC20 VA: 0x18036D620
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x36D460 Offset: 0x36BA60 VA: 0x18036D460
	internal string <defs>b__0_0(InventoryDef x) { }

}

