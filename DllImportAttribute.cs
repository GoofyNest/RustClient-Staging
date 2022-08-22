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

	// RVA: 0xFE6AF0 Offset: 0xFE50F0 VA: 0x180FE6AF0
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0xFE6DB0 Offset: 0xFE53B0 VA: 0x180FE6DB0
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0xFE6DE0 Offset: 0xFE53E0 VA: 0x180FE6DE0
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string dllName) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Value() { }

}

