internal class TypeIdentifiers // TypeDefIndex: 409
{	// Methods

	// RVA: 0x213DE30 Offset: 0x213C430 VA: 0x18213DE30
	internal static TypeIdentifier FromDisplay(string displayName) { }

}

private class TypeIdentifiers.Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName> // TypeDefIndex: 410
{	// Fields
	private string displayName; // 0x10
	private string internal_name; // 0x18

	// Properties
	public override string DisplayName { get; }
	public string InternalName { get; }

	// Methods

	// RVA: 0x13C7FC0 Offset: 0x13C65C0 VA: 0x1813C7FC0
	internal void .ctor(string displayName) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public override string get_DisplayName() { }

	// RVA: 0x213DAC0 Offset: 0x213C0C0 VA: 0x18213DAC0 Slot: 7
	public string get_InternalName() { }

	// RVA: 0x213D9E0 Offset: 0x213BFE0 VA: 0x18213D9E0
	private string GetInternalName() { }

}

