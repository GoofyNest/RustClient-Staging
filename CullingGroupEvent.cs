public struct CullingGroupEvent // TypeDefIndex: 3365
{	// Fields
	private int m_Index; // 0x0
	private byte m_PrevState; // 0x4
	private byte m_ThisState; // 0x5

	// Properties
	public int index { get; }
	public int currentDistance { get; }
	public int previousDistance { get; }

	// Methods

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0
	public int get_index() { }

	// RVA: 0x212770 Offset: 0x211B70 VA: 0x180212770
	public int get_currentDistance() { }

	// RVA: 0x212780 Offset: 0x211B80 VA: 0x180212780
	public int get_previousDistance() { }

}

