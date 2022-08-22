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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_Version(string value) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1094E00 Offset: 0x1093400 VA: 0x181094E00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1094EC0 Offset: 0x10934C0 VA: 0x181094EC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10951D0 Offset: 0x10937D0 VA: 0x1810951D0
	internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result) { }

	// RVA: 0x1094F90 Offset: 0x1093590 VA: 0x181094F90
	private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1094F40 Offset: 0x1093540 VA: 0x181094F40 Slot: 3
	public override string ToString() { }

}

