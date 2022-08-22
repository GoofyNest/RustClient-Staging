public class InventoryDef : IEquatable<InventoryDef> // TypeDefIndex: 5239
{	// Fields
	internal InventoryDefId _id; // 0x10
	internal Dictionary<string, string> _properties; // 0x18
	private InventoryRecipe[] _recContaining; // 0x20

	// Properties
	public int Id { get; }
	public string Name { get; }
	public string Description { get; }
	public string IconUrl { get; }
	public string IconUrlLarge { get; }
	public string PriceCategory { get; }
	public string Type { get; }
	public bool IsGenerator { get; }
	public string ExchangeSchema { get; }
	public bool Marketable { get; }
	public int LocalPrice { get; }
	public string LocalPriceFormatted { get; }

	// Methods

	// RVA: 0xDE0FA0 Offset: 0xDDF5A0 VA: 0x180DE0FA0
	public void .ctor(InventoryDefId defId) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Id() { }

	// RVA: 0xDE1340 Offset: 0xDDF940 VA: 0x180DE1340
	public string get_Name() { }

	// RVA: 0xDE0FD0 Offset: 0xDDF5D0 VA: 0x180DE0FD0
	public string get_Description() { }

	// RVA: 0xDE1090 Offset: 0xDDF690 VA: 0x180DE1090
	public string get_IconUrl() { }

	// RVA: 0xDE1050 Offset: 0xDDF650 VA: 0x180DE1050
	public string get_IconUrlLarge() { }

	// RVA: 0xDE1380 Offset: 0xDDF980 VA: 0x180DE1380
	public string get_PriceCategory() { }

	// RVA: 0xDE13C0 Offset: 0xDDF9C0 VA: 0x180DE13C0
	public string get_Type() { }

	// RVA: 0xDE10D0 Offset: 0xDDF6D0 VA: 0x180DE10D0
	public bool get_IsGenerator() { }

	// RVA: 0xDE1010 Offset: 0xDDF610 VA: 0x180DE1010
	public string get_ExchangeSchema() { }

	// RVA: 0xDE0DE0 Offset: 0xDDF3E0 VA: 0x180DE0DE0
	public InventoryRecipe[] GetRecipes() { }

	// RVA: 0xDE12A0 Offset: 0xDDF8A0 VA: 0x180DE12A0
	public bool get_Marketable() { }

	// RVA: 0xDE0990 Offset: 0xDDEF90 VA: 0x180DE0990
	public string GetProperty(string name) { }

	// RVA: 0xDE0900 Offset: 0xDDEF00 VA: 0x180DE0900
	public bool GetBoolProperty(string name) { }

	// RVA: -1 Offset: -1
	public T GetProperty<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE6D0 Offset: 0x5CCCD0 VA: 0x1805CE6D0
	|-InventoryDef.GetProperty<string>
	|-InventoryDef.GetProperty<object>
	|
	|-RVA: 0x5CE800 Offset: 0x5CCE00 VA: 0x1805CE800
	|-InventoryDef.GetProperty<ulong>
	*/

	// RVA: 0xDE1230 Offset: 0xDDF830 VA: 0x180DE1230
	public int get_LocalPrice() { }

	// RVA: 0xDE1140 Offset: 0xDDF740 VA: 0x180DE1140
	public string get_LocalPriceFormatted() { }

	// RVA: 0xDE0AD0 Offset: 0xDDF0D0 VA: 0x180DE0AD0
	public InventoryRecipe[] GetRecipesContainingThis() { }

	// RVA: 0xDE1400 Offset: 0xDDFA00 VA: 0x180DE1400
	public static bool op_Equality(InventoryDef a, InventoryDef b) { }

	// RVA: 0xDE1470 Offset: 0xDDFA70 VA: 0x180DE1470
	public static bool op_Inequality(InventoryDef a, InventoryDef b) { }

	// RVA: 0xDE07F0 Offset: 0xDDEDF0 VA: 0x180DE07F0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0xDE0970 Offset: 0xDDEF70 VA: 0x180DE0970 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xDE08B0 Offset: 0xDDEEB0 VA: 0x180DE08B0 Slot: 4
	public bool Equals(InventoryDef p) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE0F60 Offset: 0xDDF560 VA: 0x180DE0F60
	private InventoryRecipe <GetRecipes>b__21_0(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE0F40 Offset: 0xDDF540 VA: 0x180DE0F40
	private bool <GetRecipesContainingThis>b__44_3(InventoryRecipe x) { }

}

private sealed class InventoryDef.<>c // TypeDefIndex: 5240
{	// Fields
	public static readonly InventoryDef.<>c <>9; // 0x0
	public static Func<InventoryDef, InventoryRecipe[]> <>9__44_0; // 0x8
	public static Func<InventoryRecipe[], bool> <>9__44_1; // 0x10
	public static Func<InventoryRecipe[], IEnumerable<InventoryRecipe>> <>9__44_2; // 0x18

	// Methods

	// RVA: 0xDF06C0 Offset: 0xDEECC0 VA: 0x180DF06C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF660 Offset: 0xDEDC60 VA: 0x180DEF660
	internal InventoryRecipe[] <GetRecipesContainingThis>b__44_0(InventoryDef x) { }

	// RVA: 0xDEF7D0 Offset: 0xDEDDD0 VA: 0x180DEF7D0
	internal bool <GetRecipesContainingThis>b__44_1(InventoryRecipe[] x) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
	internal IEnumerable<InventoryRecipe> <GetRecipesContainingThis>b__44_2(InventoryRecipe[] x) { }

}

