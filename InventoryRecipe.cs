public struct InventoryRecipe : IEquatable<InventoryRecipe> // TypeDefIndex: 5246
{	// Fields
	public InventoryDef Result; // 0x0
	public InventoryRecipe.Ingredient[] Ingredients; // 0x8
	public string Source; // 0x10

	// Methods

	// RVA: 0xDE2A80 Offset: 0xDE1080 VA: 0x180DE2A80
	internal static InventoryRecipe FromString(string part, InventoryDef Result) { }

	// RVA: 0x122C70 Offset: 0x122070 VA: 0x180122C70
	internal bool ContainsIngredient(InventoryDef inventoryDef) { }

	// RVA: 0x122CF0 Offset: 0x1220F0 VA: 0x180122CF0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x122DA0 Offset: 0x1221A0 VA: 0x180122DA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122C80 Offset: 0x122080 VA: 0x180122C80 Slot: 4
	public bool Equals(InventoryRecipe p) { }

}

public struct InventoryRecipe.Ingredient // TypeDefIndex: 5247
{	// Fields
	public int DefinitionId; // 0x0
	public InventoryDef Definition; // 0x8
	public int Count; // 0x10

	// Methods

	// RVA: 0xDE10C0 Offset: 0xDDF6C0 VA: 0x180DE10C0
	internal static InventoryRecipe.Ingredient FromString(string part) { }

}

private sealed class InventoryRecipe.<>c // TypeDefIndex: 5248
{	// Fields
	public static readonly InventoryRecipe.<>c <>9; // 0x0
	public static Func<string, InventoryRecipe.Ingredient> <>9__4_0; // 0x8
	public static Func<InventoryRecipe.Ingredient, bool> <>9__4_1; // 0x10

	// Methods

	// RVA: 0xDF1110 Offset: 0xDEF710 VA: 0x180DF1110
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0000 Offset: 0xDEE600 VA: 0x180DF0000
	internal InventoryRecipe.Ingredient <FromString>b__4_0(string x) { }

	// RVA: 0xDF0040 Offset: 0xDEE640 VA: 0x180DF0040
	internal bool <FromString>b__4_1(InventoryRecipe.Ingredient x) { }

}

private sealed class InventoryRecipe.<>c__DisplayClass5_0 // TypeDefIndex: 5249
{	// Fields
	public InventoryDef inventoryDef; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0FD0 Offset: 0xDEF5D0 VA: 0x180DF0FD0
	internal bool <ContainsIngredient>b__0(InventoryRecipe.Ingredient x) { }

}

