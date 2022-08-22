public static class KeyCombos // TypeDefIndex: 8230
{	// Methods

	// RVA: 0x106F790 Offset: 0x106DD90 VA: 0x18106F790
	public static bool TryParse(ref string name, out List<KeyCode> keys) { }

	// RVA: 0x106F650 Offset: 0x106DC50 VA: 0x18106F650
	public static void RegisterButton(string name, List<KeyCode> keys) { }

	// RVA: 0x106F610 Offset: 0x106DC10 VA: 0x18106F610
	private static bool IsFunctionKey(KeyCode keyCode) { }

	// RVA: 0x106F630 Offset: 0x106DC30 VA: 0x18106F630
	private static bool IsMouseButton(KeyCode keyCode) { }

}

private sealed class KeyCombos.<>c // TypeDefIndex: 8231
{	// Fields
	public static readonly KeyCombos.<>c <>9; // 0x0
	public static Func<KeyCode, string> <>9__0_0; // 0x8
	public static Func<string, string> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x107B310 Offset: 0x1079910 VA: 0x18107B310
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x107ADF0 Offset: 0x10793F0 VA: 0x18107ADF0
	internal string <TryParse>b__0_0(KeyCode k) { }

	// RVA: 0x107AE80 Offset: 0x1079480 VA: 0x18107AE80
	internal string <TryParse>b__0_1(string s) { }

}

private sealed class KeyCombos.<>c__DisplayClass1_0 // TypeDefIndex: 8232
{	// Fields
	public List<KeyCode> keys; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x107AF30 Offset: 0x1079530 VA: 0x18107AF30
	internal bool <RegisterButton>b__0() { }

}

