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

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_index() { }

	// RVA: 0x2133C0 Offset: 0x2127C0 VA: 0x1802133C0
	public int get_currentDistance() { }

	// RVA: 0x2133D0 Offset: 0x2127D0 VA: 0x1802133D0
	public int get_previousDistance() { }

}

