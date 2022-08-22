public static class KeyCombos // TypeDefIndex: 8230
{	// Methods

	// RVA: 0x106ED20 Offset: 0x106D320 VA: 0x18106ED20
	public static bool TryParse(ref string name, out List<KeyCode> keys) { }

	// RVA: 0x106EBE0 Offset: 0x106D1E0 VA: 0x18106EBE0
	public static void RegisterButton(string name, List<KeyCode> keys) { }

	// RVA: 0x106EBA0 Offset: 0x106D1A0 VA: 0x18106EBA0
	private static bool IsFunctionKey(KeyCode keyCode) { }

	// RVA: 0x106EBC0 Offset: 0x106D1C0 VA: 0x18106EBC0
	private static bool IsMouseButton(KeyCode keyCode) { }

}

private sealed class KeyCombos.<>c // TypeDefIndex: 8231
{	// Fields
	public static readonly KeyCombos.<>c <>9; // 0x0
	public static Func<KeyCode, string> <>9__0_0; // 0x8
	public static Func<string, string> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x107A8A0 Offset: 0x1078EA0 VA: 0x18107A8A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x107A380 Offset: 0x1078980 VA: 0x18107A380
	internal string <TryParse>b__0_0(KeyCode k) { }

	// RVA: 0x107A410 Offset: 0x1078A10 VA: 0x18107A410
	internal string <TryParse>b__0_1(string s) { }

}

private sealed class KeyCombos.<>c__DisplayClass1_0 // TypeDefIndex: 8232
{	// Fields
	public List<KeyCode> keys; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x107A4C0 Offset: 0x1078AC0 VA: 0x18107A4C0
	internal bool <RegisterButton>b__0() { }

}

