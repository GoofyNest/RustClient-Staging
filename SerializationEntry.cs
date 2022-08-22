public struct SerializationEntry // TypeDefIndex: 1059
{	// Fields
	private Type m_type; // 0x0
	private object m_value; // 0x8
	private string m_name; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public object get_Value() { }

	// RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	public string get_Name() { }

	// RVA: 0x1DFB70 Offset: 0x1DEF70 VA: 0x1801DFB70
	internal void .ctor(string entryName, object entryValue, Type entryType) { }

}

