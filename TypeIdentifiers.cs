internal class TypeIdentifiers // TypeDefIndex: 409
{	// Methods

	// RVA: 0x213D350 Offset: 0x213B950 VA: 0x18213D350
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

	// RVA: 0x213CFE0 Offset: 0x213B5E0 VA: 0x18213CFE0 Slot: 7
	public string get_InternalName() { }

	// RVA: 0x213CF00 Offset: 0x213B500 VA: 0x18213CF00
	private string GetInternalName() { }

}

