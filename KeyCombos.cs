public static class KeyCombos // TypeDefIndex: 8230
{	// Methods

	// RVA: 0x106EA60 Offset: 0x106D060 VA: 0x18106EA60
	public static bool TryParse(ref string name, out List<KeyCode> keys) { }

	// RVA: 0x106E920 Offset: 0x106CF20 VA: 0x18106E920
	public static void RegisterButton(string name, List<KeyCode> keys) { }

	// RVA: 0x106E8E0 Offset: 0x106CEE0 VA: 0x18106E8E0
	private static bool IsFunctionKey(KeyCode keyCode) { }

	// RVA: 0x106E900 Offset: 0x106CF00 VA: 0x18106E900
	private static bool IsMouseButton(KeyCode keyCode) { }

}

private sealed class KeyCombos.<>c // TypeDefIndex: 8231
{	// Fields
	public static readonly KeyCombos.<>c <>9; // 0x0
	public static Func<KeyCode, string> <>9__0_0; // 0x8
	public static Func<string, string> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x107A5E0 Offset: 0x1078BE0 VA: 0x18107A5E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x107A0C0 Offset: 0x10786C0 VA: 0x18107A0C0
	internal string <TryParse>b__0_0(KeyCode k) { }

	// RVA: 0x107A150 Offset: 0x1078750 VA: 0x18107A150
	internal string <TryParse>b__0_1(string s) { }

}

private sealed class KeyCombos.<>c__DisplayClass1_0 // TypeDefIndex: 8232
{	// Fields
	public List<KeyCode> keys; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x107A200 Offset: 0x1078800 VA: 0x18107A200
	internal bool <RegisterButton>b__0() { }

}

