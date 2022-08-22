internal static class ParameterizedStrings // TypeDefIndex: 394
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static ParameterizedStrings.LowLevelStack _cachedStack; // 0x80000000

	// Methods

	// RVA: 0x1682E20 Offset: 0x1681420 VA: 0x181682E20
	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	// RVA: 0x1682220 Offset: 0x1680820 VA: 0x181682220
	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	// RVA: 0x1457E10 Offset: 0x1456410 VA: 0x181457E10
	private static bool AsBool(int i) { }

	// RVA: 0x145A230 Offset: 0x1458830 VA: 0x18145A230
	private static int AsInt(bool b) { }

	// RVA: 0x16832E0 Offset: 0x16818E0 VA: 0x1816832E0
	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x1683490 Offset: 0x1681A90 VA: 0x181683490
	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	// RVA: 0x16833D0 Offset: 0x16819D0 VA: 0x1816833D0
	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	// RVA: 0x1682F70 Offset: 0x1681570 VA: 0x181682F70
	private static string FormatPrintF(string format, object arg) { }

	// RVA: 0x16831F0 Offset: 0x16817F0 VA: 0x1816831F0
	private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars, out int index) { }

}

public struct ParameterizedStrings.FormatParam // TypeDefIndex: 395
{	// Fields
	private readonly int _int32; // 0x0
	private readonly string _string; // 0x8

	// Properties
	public int Int32 { get; }
	public string String { get; }
	public object Object { get; }

	// Methods

	// RVA: 0x215910 Offset: 0x214D10 VA: 0x180215910
	public void .ctor(int value) { }

	// RVA: 0xFCAE0 Offset: 0xFBEE0 VA: 0x1800FCAE0
	private void .ctor(int intValue, string stringValue) { }

	// RVA: 0x18C92D0 Offset: 0x18C78D0 VA: 0x1818C92D0
	public static ParameterizedStrings.FormatParam op_Implicit(int value) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public int get_Int32() { }

	// RVA: 0x215980 Offset: 0x214D80 VA: 0x180215980
	public string get_String() { }

	// RVA: 0x215930 Offset: 0x214D30 VA: 0x180215930
	public object get_Object() { }

}

private sealed class ParameterizedStrings.LowLevelStack // TypeDefIndex: 396
{	// Fields
	private ParameterizedStrings.FormatParam[] _arr; // 0x10
	private int _count; // 0x18

	// Methods

	// RVA: 0x18C9E10 Offset: 0x18C8410 VA: 0x1818C9E10
	public void .ctor() { }

	// RVA: 0x18C9C60 Offset: 0x18C8260 VA: 0x1818C9C60
	public ParameterizedStrings.FormatParam Pop() { }

	// RVA: 0x18C9D10 Offset: 0x18C8310 VA: 0x1818C9D10
	public void Push(ParameterizedStrings.FormatParam item) { }

	// RVA: 0x18C9C30 Offset: 0x18C8230 VA: 0x1818C9C30
	public void Clear() { }

}

