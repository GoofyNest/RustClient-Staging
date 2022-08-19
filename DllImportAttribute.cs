public sealed class DllImportAttribute : Attribute // TypeDefIndex: 1338
{	// Fields
	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0xFE5D90 Offset: 0xFE4390 VA: 0x180FE5D90
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0xFE6050 Offset: 0xFE4650 VA: 0x180FE6050
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0xFE6080 Offset: 0xFE4680 VA: 0x180FE6080
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string dllName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Value() { }

}

