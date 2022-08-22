internal sealed class TypeInformation // TypeDefIndex: 1111
{	private string fullTypeName; // 0x10
	private string assemblyString; // 0x18
	private bool hasTypeForwardedFrom; // 0x20

	internal string FullTypeName { get; }
	internal string AssemblyString { get; }
	internal bool HasTypeForwardedFrom { get; }


	internal string get_FullTypeName() { }

	internal string get_AssemblyString() { }

	internal bool get_HasTypeForwardedFrom() { }

	internal void .ctor(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

}

internal class TypeInformation // TypeDefIndex: 5941
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x18

	public Type Type { get; set; }
	public PrimitiveTypeCode TypeCode { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Type(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_TypeCode(PrimitiveTypeCode value) { }

	public void .ctor() { }

}

