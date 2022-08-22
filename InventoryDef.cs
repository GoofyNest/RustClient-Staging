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

	// RVA: 0xDE1A50 Offset: 0xDE0050 VA: 0x180DE1A50
	public void .ctor(InventoryDefId defId) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Id() { }

	// RVA: 0xDE1DF0 Offset: 0xDE03F0 VA: 0x180DE1DF0
	public string get_Name() { }

	// RVA: 0xDE1A80 Offset: 0xDE0080 VA: 0x180DE1A80
	public string get_Description() { }

	// RVA: 0xDE1B40 Offset: 0xDE0140 VA: 0x180DE1B40
	public string get_IconUrl() { }

	// RVA: 0xDE1B00 Offset: 0xDE0100 VA: 0x180DE1B00
	public string get_IconUrlLarge() { }

	// RVA: 0xDE1E30 Offset: 0xDE0430 VA: 0x180DE1E30
	public string get_PriceCategory() { }

	// RVA: 0xDE1E70 Offset: 0xDE0470 VA: 0x180DE1E70
	public string get_Type() { }

	// RVA: 0xDE1B80 Offset: 0xDE0180 VA: 0x180DE1B80
	public bool get_IsGenerator() { }

	// RVA: 0xDE1AC0 Offset: 0xDE00C0 VA: 0x180DE1AC0
	public string get_ExchangeSchema() { }

	// RVA: 0xDE1890 Offset: 0xDDFE90 VA: 0x180DE1890
	public InventoryRecipe[] GetRecipes() { }

	// RVA: 0xDE1D50 Offset: 0xDE0350 VA: 0x180DE1D50
	public bool get_Marketable() { }

	// RVA: 0xDE1440 Offset: 0xDDFA40 VA: 0x180DE1440
	public string GetProperty(string name) { }

	// RVA: 0xDE13B0 Offset: 0xDDF9B0 VA: 0x180DE13B0
	public bool GetBoolProperty(string name) { }

	// RVA: -1 Offset: -1
	public T GetProperty<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE660 Offset: 0x5CCC60 VA: 0x1805CE660
	|-InventoryDef.GetProperty<string>
	|-InventoryDef.GetProperty<object>
	|
	|-RVA: 0x5CE790 Offset: 0x5CCD90 VA: 0x1805CE790
	|-InventoryDef.GetProperty<ulong>
	*/

	// RVA: 0xDE1CE0 Offset: 0xDE02E0 VA: 0x180DE1CE0
	public int get_LocalPrice() { }

	// RVA: 0xDE1BF0 Offset: 0xDE01F0 VA: 0x180DE1BF0
	public string get_LocalPriceFormatted() { }

	// RVA: 0xDE1580 Offset: 0xDDFB80 VA: 0x180DE1580
	public InventoryRecipe[] GetRecipesContainingThis() { }

	// RVA: 0xDE1EB0 Offset: 0xDE04B0 VA: 0x180DE1EB0
	public static bool op_Equality(InventoryDef a, InventoryDef b) { }

	// RVA: 0xDE1F20 Offset: 0xDE0520 VA: 0x180DE1F20
	public static bool op_Inequality(InventoryDef a, InventoryDef b) { }

	// RVA: 0xDE12A0 Offset: 0xDDF8A0 VA: 0x180DE12A0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0xDE1420 Offset: 0xDDFA20 VA: 0x180DE1420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xDE1360 Offset: 0xDDF960 VA: 0x180DE1360 Slot: 4
	public bool Equals(InventoryDef p) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE1A10 Offset: 0xDE0010 VA: 0x180DE1A10
	private InventoryRecipe <GetRecipes>b__21_0(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE19F0 Offset: 0xDDFFF0 VA: 0x180DE19F0
	private bool <GetRecipesContainingThis>b__44_3(InventoryRecipe x) { }

}

private sealed class InventoryDef.<>c // TypeDefIndex: 5240
{	// Fields
	public static readonly InventoryDef.<>c <>9; // 0x0
	public static Func<InventoryDef, InventoryRecipe[]> <>9__44_0; // 0x8
	public static Func<InventoryRecipe[], bool> <>9__44_1; // 0x10
	public static Func<InventoryRecipe[], IEnumerable<InventoryRecipe>> <>9__44_2; // 0x18

	// Methods

	// RVA: 0xDF1170 Offset: 0xDEF770 VA: 0x180DF1170
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0110 Offset: 0xDEE710 VA: 0x180DF0110
	internal InventoryRecipe[] <GetRecipesContainingThis>b__44_0(InventoryDef x) { }

	// RVA: 0xDF0280 Offset: 0xDEE880 VA: 0x180DF0280
	internal bool <GetRecipesContainingThis>b__44_1(InventoryRecipe[] x) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	internal IEnumerable<InventoryRecipe> <GetRecipesContainingThis>b__44_2(InventoryRecipe[] x) { }

}

