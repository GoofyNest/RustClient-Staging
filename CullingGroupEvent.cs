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

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0
	public int get_index() { }

	// RVA: 0x213340 Offset: 0x212740 VA: 0x180213340
	public int get_currentDistance() { }

	// RVA: 0x213350 Offset: 0x212750 VA: 0x180213350
	public int get_previousDistance() { }

}

