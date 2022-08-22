public class ProductHeaderValue : ICloneable // TypeDefIndex: 5801
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Version>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Version { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Version(string value) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1094390 Offset: 0x1092990 VA: 0x181094390 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1094450 Offset: 0x1092A50 VA: 0x181094450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1094760 Offset: 0x1092D60 VA: 0x181094760
	internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result) { }

	// RVA: 0x1094520 Offset: 0x1092B20 VA: 0x181094520
	private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t) { }

	// RVA: 0x10944D0 Offset: 0x1092AD0 VA: 0x1810944D0 Slot: 3
	public override string ToString() { }

}

