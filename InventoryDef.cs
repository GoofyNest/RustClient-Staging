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

	// RVA: 0xDE0CE0 Offset: 0xDDF2E0 VA: 0x180DE0CE0
	public void .ctor(InventoryDefId defId) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Id() { }

	// RVA: 0xDE1080 Offset: 0xDDF680 VA: 0x180DE1080
	public string get_Name() { }

	// RVA: 0xDE0D10 Offset: 0xDDF310 VA: 0x180DE0D10
	public string get_Description() { }

	// RVA: 0xDE0DD0 Offset: 0xDDF3D0 VA: 0x180DE0DD0
	public string get_IconUrl() { }

	// RVA: 0xDE0D90 Offset: 0xDDF390 VA: 0x180DE0D90
	public string get_IconUrlLarge() { }

	// RVA: 0xDE10C0 Offset: 0xDDF6C0 VA: 0x180DE10C0
	public string get_PriceCategory() { }

	// RVA: 0xDE1100 Offset: 0xDDF700 VA: 0x180DE1100
	public string get_Type() { }

	// RVA: 0xDE0E10 Offset: 0xDDF410 VA: 0x180DE0E10
	public bool get_IsGenerator() { }

	// RVA: 0xDE0D50 Offset: 0xDDF350 VA: 0x180DE0D50
	public string get_ExchangeSchema() { }

	// RVA: 0xDE0B20 Offset: 0xDDF120 VA: 0x180DE0B20
	public InventoryRecipe[] GetRecipes() { }

	// RVA: 0xDE0FE0 Offset: 0xDDF5E0 VA: 0x180DE0FE0
	public bool get_Marketable() { }

	// RVA: 0xDE06D0 Offset: 0xDDECD0 VA: 0x180DE06D0
	public string GetProperty(string name) { }

	// RVA: 0xDE0640 Offset: 0xDDEC40 VA: 0x180DE0640
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

	// RVA: 0xDE0F70 Offset: 0xDDF570 VA: 0x180DE0F70
	public int get_LocalPrice() { }

	// RVA: 0xDE0E80 Offset: 0xDDF480 VA: 0x180DE0E80
	public string get_LocalPriceFormatted() { }

	// RVA: 0xDE0810 Offset: 0xDDEE10 VA: 0x180DE0810
	public InventoryRecipe[] GetRecipesContainingThis() { }

	// RVA: 0xDE1140 Offset: 0xDDF740 VA: 0x180DE1140
	public static bool op_Equality(InventoryDef a, InventoryDef b) { }

	// RVA: 0xDE11B0 Offset: 0xDDF7B0 VA: 0x180DE11B0
	public static bool op_Inequality(InventoryDef a, InventoryDef b) { }

	// RVA: 0xDE0530 Offset: 0xDDEB30 VA: 0x180DE0530 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0xDE06B0 Offset: 0xDDECB0 VA: 0x180DE06B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xDE05F0 Offset: 0xDDEBF0 VA: 0x180DE05F0 Slot: 4
	public bool Equals(InventoryDef p) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xDE0CA0 Offset: 0xDDF2A0 VA: 0x180DE0CA0
	private InventoryRecipe <GetRecipes>b__21_0(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xDE0C80 Offset: 0xDDF280 VA: 0x180DE0C80
	private bool <GetRecipesContainingThis>b__44_3(InventoryRecipe x) { }

}

private sealed class InventoryDef.<>c // TypeDefIndex: 5240
{	// Fields
	public static readonly InventoryDef.<>c <>9; // 0x0
	public static Func<InventoryDef, InventoryRecipe[]> <>9__44_0; // 0x8
	public static Func<InventoryRecipe[], bool> <>9__44_1; // 0x10
	public static Func<InventoryRecipe[], IEnumerable<InventoryRecipe>> <>9__44_2; // 0x18

	// Methods

	// RVA: 0xDF0400 Offset: 0xDEEA00 VA: 0x180DF0400
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF3A0 Offset: 0xDED9A0 VA: 0x180DEF3A0
	internal InventoryRecipe[] <GetRecipesContainingThis>b__44_0(InventoryDef x) { }

	// RVA: 0xDEF510 Offset: 0xDEDB10 VA: 0x180DEF510
	internal bool <GetRecipesContainingThis>b__44_1(InventoryRecipe[] x) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	internal IEnumerable<InventoryRecipe> <GetRecipesContainingThis>b__44_2(InventoryRecipe[] x) { }

}

