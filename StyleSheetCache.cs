internal static class StyleSheetCache // TypeDefIndex: 4723
{	// Fields
	private static StyleSheetCache.SheetHandleKeyComparer s_Comparer; // 0x0
	private static Dictionary<StyleSheetCache.SheetHandleKey, int> s_EnumToIntCache; // 0x8
	private static Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyID[]> s_RulePropertyIDsCache; // 0x10
	private static Dictionary<string, StylePropertyID> s_NameToIDCache; // 0x18
	private static StyleValue[] s_InitialStyleValues; // 0x20
	private static Dictionary<string, string> s_DeprecatedNames; // 0x28

	// Methods

	// RVA: 0xEBAC40 Offset: 0xEB9240 VA: 0x180EBAC40
	private static void .cctor() { }

	// RVA: 0xEBAB50 Offset: 0xEB9150 VA: 0x180EBAB50
	internal static StyleValue GetInitialValue(StylePropertyID propertyId) { }

}

private struct StyleSheetCache.SheetHandleKey // TypeDefIndex: 4724
{	// Fields
	public readonly int sheetInstanceID; // 0x0
	public readonly int index; // 0x4

}

private class StyleSheetCache.SheetHandleKeyComparer : IEqualityComparer<StyleSheetCache.SheetHandleKey> // TypeDefIndex: 4725
{	// Methods

	// RVA: 0xEBA770 Offset: 0xEB8D70 VA: 0x180EBA770 Slot: 4
	public bool Equals(StyleSheetCache.SheetHandleKey x, StyleSheetCache.SheetHandleKey y) { }

	// RVA: 0xEBA790 Offset: 0xEB8D90 VA: 0x180EBA790 Slot: 5
	public int GetHashCode(StyleSheetCache.SheetHandleKey key) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

