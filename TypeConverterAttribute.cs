public sealed class TypeConverterAttribute : Attribute // TypeDefIndex: 2754
{	// Fields
	private string typeName; // 0x10
	public static readonly TypeConverterAttribute Default; // 0x0

	// Properties
	public string ConverterTypeName { get; }

	// Methods

	// RVA: 0x17388C0 Offset: 0x1736EC0 VA: 0x1817388C0
	public void .ctor() { }

	// RVA: 0x17387E0 Offset: 0x1736DE0 VA: 0x1817387E0
	public void .ctor(Type type) { }

	// RVA: 0x1738830 Offset: 0x1736E30 VA: 0x181738830
	public void .ctor(string typeName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ConverterTypeName() { }

	// RVA: 0x17386E0 Offset: 0x1736CE0 VA: 0x1817386E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE1FA0 Offset: 0xDE05A0 VA: 0x180DE1FA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1738750 Offset: 0x1736D50 VA: 0x181738750
	private static void .cctor() { }

}

