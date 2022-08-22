public sealed class TypeConverterAttribute : Attribute // TypeDefIndex: 2754
{	// Fields
	private string typeName; // 0x10
	public static readonly TypeConverterAttribute Default; // 0x0

	// Properties
	public string ConverterTypeName { get; }

	// Methods

	// RVA: 0x1738B80 Offset: 0x1737180 VA: 0x181738B80
	public void .ctor() { }

	// RVA: 0x1738AA0 Offset: 0x17370A0 VA: 0x181738AA0
	public void .ctor(Type type) { }

	// RVA: 0x1738AF0 Offset: 0x17370F0 VA: 0x181738AF0
	public void .ctor(string typeName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ConverterTypeName() { }

	// RVA: 0x17389A0 Offset: 0x1736FA0 VA: 0x1817389A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2260 Offset: 0xDE0860 VA: 0x180DE2260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1738A10 Offset: 0x1737010 VA: 0x181738A10
	private static void .cctor() { }

}

