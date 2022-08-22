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

	// RVA: 0x12A74F0 Offset: 0x12A5AF0 VA: 0x1812A74F0
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x12A7350 Offset: 0x12A5950 VA: 0x1812A7350 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x12A7380 Offset: 0x12A5980 VA: 0x1812A7380 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12A7570 Offset: 0x12A5B70 VA: 0x1812A7570
	public SerializationEntry get_Current() { }

	// RVA: 0x12A7370 Offset: 0x12A5970 VA: 0x1812A7370 Slot: 6
	public void Reset() { }

	// RVA: 0x12A76C0 Offset: 0x12A5CC0 VA: 0x1812A76C0
	public string get_Name() { }

	// RVA: 0x12A7820 Offset: 0x12A5E20 VA: 0x1812A7820
	public object get_Value() { }

	// RVA: 0x12A7770 Offset: 0x12A5D70 VA: 0x1812A7770
	public Type get_ObjectType() { }

}

