public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 1060
{	// Fields
	private string[] m_members; // 0x10
	private object[] m_data; // 0x18
	private Type[] m_types; // 0x20
	private int m_numItems; // 0x28
	private int m_currItem; // 0x2C
	private bool m_current; // 0x30

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SerializationEntry Current { get; }
	public string Name { get; }
	public object Value { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x12A7B90 Offset: 0x12A6190 VA: 0x1812A7B90
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x12A79F0 Offset: 0x12A5FF0 VA: 0x1812A79F0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x12A7A20 Offset: 0x12A6020 VA: 0x1812A7A20 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12A7C10 Offset: 0x12A6210 VA: 0x1812A7C10
	public SerializationEntry get_Current() { }

	// RVA: 0x12A7A10 Offset: 0x12A6010 VA: 0x1812A7A10 Slot: 6
	public void Reset() { }

	// RVA: 0x12A7D60 Offset: 0x12A6360 VA: 0x1812A7D60
	public string get_Name() { }

	// RVA: 0x12A7EC0 Offset: 0x12A64C0 VA: 0x1812A7EC0
	public object get_Value() { }

	// RVA: 0x12A7E10 Offset: 0x12A6410 VA: 0x1812A7E10
	public Type get_ObjectType() { }

}

