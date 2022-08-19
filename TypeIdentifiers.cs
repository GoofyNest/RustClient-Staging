internal class TypeIdentifiers // TypeDefIndex: 409
{	// Methods

	// RVA: 0x213D510 Offset: 0x213BB10 VA: 0x18213D510
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

	// RVA: 0x13C8C00 Offset: 0x13C7200 VA: 0x1813C8C00
	internal void .ctor(string displayName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public override string get_DisplayName() { }

	// RVA: 0x213D1A0 Offset: 0x213B7A0 VA: 0x18213D1A0 Slot: 7
	public string get_InternalName() { }

	// RVA: 0x213D0C0 Offset: 0x213B6C0 VA: 0x18213D0C0
	private string GetInternalName() { }

}

