internal static class ParameterizedStrings // TypeDefIndex: 394
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x2152C0 Offset: 0x2146C0 VA: 0x1802152C0
	public void .ctor(int value) { }

	// RVA: 0xFCB60 Offset: 0xFBF60 VA: 0x1800FCB60
	private void .ctor(int intValue, string stringValue) { }

	// RVA: 0x18C9930 Offset: 0x18C7F30 VA: 0x1818C9930
	public static ParameterizedStrings.FormatParam op_Implicit(int value) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public int get_Int32() { }

	// RVA: 0x215330 Offset: 0x214730 VA: 0x180215330
	public string get_String() { }

	// RVA: 0x2152E0 Offset: 0x2146E0 VA: 0x1802152E0
	public object get_Object() { }

}

private sealed class ParameterizedStrings.LowLevelStack // TypeDefIndex: 396
{	// Fields
	private ParameterizedStrings.FormatParam[] _arr; // 0x10
	private int _count; // 0x18

	// Methods

	// RVA: 0x18CA470 Offset: 0x18C8A70 VA: 0x1818CA470
	public void .ctor() { }

	// RVA: 0x18CA2C0 Offset: 0x18C88C0 VA: 0x1818CA2C0
	public ParameterizedStrings.FormatParam Pop() { }

	// RVA: 0x18CA370 Offset: 0x18C8970 VA: 0x1818CA370
	public void Push(ParameterizedStrings.FormatParam item) { }

	// RVA: 0x18CA290 Offset: 0x18C8890 VA: 0x1818CA290
	public void Clear() { }

}

