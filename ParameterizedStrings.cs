internal static class ParameterizedStrings // TypeDefIndex: 394
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static ParameterizedStrings.LowLevelStack _cachedStack; // 0x80000000

	// Methods

	// RVA: 0x1685230 Offset: 0x1683830 VA: 0x181685230
	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	// RVA: 0x1684630 Offset: 0x1682C30 VA: 0x181684630
	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	// RVA: 0x1458D40 Offset: 0x1457340 VA: 0x181458D40
	private static bool AsBool(int i) { }

	// RVA: 0x145B160 Offset: 0x1459760 VA: 0x18145B160
	private static int AsInt(bool b) { }

	// RVA: 0x16856F0 Offset: 0x1683CF0 VA: 0x1816856F0
	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x16858A0 Offset: 0x1683EA0 VA: 0x1816858A0
	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	// RVA: 0x16857E0 Offset: 0x1683DE0 VA: 0x1816857E0
	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	// RVA: 0x1685380 Offset: 0x1683980 VA: 0x181685380
	private static string FormatPrintF(string format, object arg) { }

	// RVA: 0x1685600 Offset: 0x1683C00 VA: 0x181685600
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

	// RVA: 0x215240 Offset: 0x214640 VA: 0x180215240
	public void .ctor(int value) { }

	// RVA: 0xFCAE0 Offset: 0xFBEE0 VA: 0x1800FCAE0
	private void .ctor(int intValue, string stringValue) { }

	// RVA: 0x18C9BB0 Offset: 0x18C81B0 VA: 0x1818C9BB0
	public static ParameterizedStrings.FormatParam op_Implicit(int value) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public int get_Int32() { }

	// RVA: 0x2152B0 Offset: 0x2146B0 VA: 0x1802152B0
	public string get_String() { }

	// RVA: 0x215260 Offset: 0x214660 VA: 0x180215260
	public object get_Object() { }

}

private sealed class ParameterizedStrings.LowLevelStack // TypeDefIndex: 396
{	// Fields
	private ParameterizedStrings.FormatParam[] _arr; // 0x10
	private int _count; // 0x18

	// Methods

	// RVA: 0x18CA6F0 Offset: 0x18C8CF0 VA: 0x1818CA6F0
	public void .ctor() { }

	// RVA: 0x18CA540 Offset: 0x18C8B40 VA: 0x1818CA540
	public ParameterizedStrings.FormatParam Pop() { }

	// RVA: 0x18CA5F0 Offset: 0x18C8BF0 VA: 0x1818CA5F0
	public void Push(ParameterizedStrings.FormatParam item) { }

	// RVA: 0x18CA510 Offset: 0x18C8B10 VA: 0x1818CA510
	public void Clear() { }

}

