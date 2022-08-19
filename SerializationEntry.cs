public struct SerializationEntry // TypeDefIndex: 1059
{	// Fields
	private Type m_type; // 0x0
	private object m_value; // 0x8
	private string m_name; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	public object get_Value() { }

	// RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
	public string get_Name() { }

	// RVA: 0x1DFBF0 Offset: 0x1DEFF0 VA: 0x1801DFBF0
	internal void .ctor(string entryName, object entryValue, Type entryType) { }

}

