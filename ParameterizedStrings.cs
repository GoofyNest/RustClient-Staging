internal static class ParameterizedStrings // TypeDefIndex: 394
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static ParameterizedStrings.LowLevelStack _cachedStack; // 0x80000000

	// Methods

	// RVA: 0x1684F70 Offset: 0x1683570 VA: 0x181684F70
	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	// RVA: 0x1684370 Offset: 0x1682970 VA: 0x181684370
	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	// RVA: 0x1458A80 Offset: 0x1457080 VA: 0x181458A80
	private static bool AsBool(int i) { }

	// RVA: 0x145AEA0 Offset: 0x14594A0 VA: 0x18145AEA0
	private static int AsInt(bool b) { }

	// RVA: 0x1685430 Offset: 0x1683A30 VA: 0x181685430
	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x16855E0 Offset: 0x1683BE0 VA: 0x1816855E0
	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	// RVA: 0x1685520 Offset: 0x1683B20 VA: 0x181685520
	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	// RVA: 0x16850C0 Offset: 0x16836C0 VA: 0x1816850C0
	private static string FormatPrintF(string format, object arg) { }

	// RVA: 0x1685340 Offset: 0x1683940 VA: 0x181685340
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

	// RVA: 0x18C98F0 Offset: 0x18C7EF0 VA: 0x1818C98F0
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

	// RVA: 0x18CA430 Offset: 0x18C8A30 VA: 0x1818CA430
	public void .ctor() { }

	// RVA: 0x18CA280 Offset: 0x18C8880 VA: 0x1818CA280
	public ParameterizedStrings.FormatParam Pop() { }

	// RVA: 0x18CA330 Offset: 0x18C8930 VA: 0x1818CA330
	public void Push(ParameterizedStrings.FormatParam item) { }

	// RVA: 0x18CA250 Offset: 0x18C8850 VA: 0x1818CA250
	public void Clear() { }

}

