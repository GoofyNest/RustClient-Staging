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

	// RVA: 0x12A7230 Offset: 0x12A5830 VA: 0x1812A7230
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x12A7090 Offset: 0x12A5690 VA: 0x1812A7090 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x12A70C0 Offset: 0x12A56C0 VA: 0x1812A70C0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12A72B0 Offset: 0x12A58B0 VA: 0x1812A72B0
	public SerializationEntry get_Current() { }

	// RVA: 0x12A70B0 Offset: 0x12A56B0 VA: 0x1812A70B0 Slot: 6
	public void Reset() { }

	// RVA: 0x12A7400 Offset: 0x12A5A00 VA: 0x1812A7400
	public string get_Name() { }

	// RVA: 0x12A7560 Offset: 0x12A5B60 VA: 0x1812A7560
	public object get_Value() { }

	// RVA: 0x12A74B0 Offset: 0x12A5AB0 VA: 0x1812A74B0
	public Type get_ObjectType() { }

}

