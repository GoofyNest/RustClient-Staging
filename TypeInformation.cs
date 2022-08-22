internal sealed class TypeInformation // TypeDefIndex: 1111
{	// Fields
	private string fullTypeName; // 0x10
	private string assemblyString; // 0x18
	private bool hasTypeForwardedFrom; // 0x20

	// Properties
	internal string FullTypeName { get; }
	internal string AssemblyString { get; }
	internal bool HasTypeForwardedFrom { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal string get_FullTypeName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_AssemblyString() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	internal bool get_HasTypeForwardedFrom() { }

	// RVA: 0xFFCAB0 Offset: 0xFFB0B0 VA: 0x180FFCAB0
	internal void .ctor(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

}

internal class TypeInformation // TypeDefIndex: 5941
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x18

	// Properties
	public Type Type { get; set; }
	public PrimitiveTypeCode TypeCode { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Type(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

