public struct InventoryRecipe : IEquatable<InventoryRecipe> // TypeDefIndex: 5246
{	// Fields
	public InventoryDef Result; // 0x0
	public InventoryRecipe.Ingredient[] Ingredients; // 0x8
	public string Source; // 0x10

	// Methods

	// RVA: 0xDE1FD0 Offset: 0xDE05D0 VA: 0x180DE1FD0
	internal static InventoryRecipe FromString(string part, InventoryDef Result) { }

	// RVA: 0x122E50 Offset: 0x122250 VA: 0x180122E50
	internal bool ContainsIngredient(InventoryDef inventoryDef) { }

	// RVA: 0x122ED0 Offset: 0x1222D0 VA: 0x180122ED0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x122F80 Offset: 0x122380 VA: 0x180122F80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122E60 Offset: 0x122260 VA: 0x180122E60 Slot: 4
	public bool Equals(InventoryRecipe p) { }

}

public struct InventoryRecipe.Ingredient // TypeDefIndex: 5247
{	// Fields
	public int DefinitionId; // 0x0
	public InventoryDef Definition; // 0x8
	public int Count; // 0x10

	// Methods

	// RVA: 0xDE0610 Offset: 0xDDEC10 VA: 0x180DE0610
	internal static InventoryRecipe.Ingredient FromString(string part) { }

}

private sealed class InventoryRecipe.<>c // TypeDefIndex: 5248
{	// Fields
	public static readonly InventoryRecipe.<>c <>9; // 0x0
	public static Func<string, InventoryRecipe.Ingredient> <>9__4_0; // 0x8
	public static Func<InventoryRecipe.Ingredient, bool> <>9__4_1; // 0x10

	// Methods

	// RVA: 0xDF0660 Offset: 0xDEEC60 VA: 0x180DF0660
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF550 Offset: 0xDEDB50 VA: 0x180DEF550
	internal InventoryRecipe.Ingredient <FromString>b__4_0(string x) { }

	// RVA: 0xDEF590 Offset: 0xDEDB90 VA: 0x180DEF590
	internal bool <FromString>b__4_1(InventoryRecipe.Ingredient x) { }

}

private sealed class InventoryRecipe.<>c__DisplayClass5_0 // TypeDefIndex: 5249
{	// Fields
	public InventoryDef inventoryDef; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0520 Offset: 0xDEEB20 VA: 0x180DF0520
	internal bool <ContainsIngredient>b__0(InventoryRecipe.Ingredient x) { }

}

