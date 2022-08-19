public struct Touch // TypeDefIndex: 4073
{	// Fields
	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	// Properties
	public int fingerId { get; }
	public Vector2 position { get; }
	public TouchPhase phase { get; }
	public TouchType type { get; }

	// Methods

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_fingerId() { }

	// RVA: 0x240B50 Offset: 0x23FF50 VA: 0x180240B50
	public Vector2 get_position() { }

	// RVA: 0x240B40 Offset: 0x23FF40 VA: 0x180240B40
	public TouchPhase get_phase() { }

	// RVA: 0x240B70 Offset: 0x23FF70 VA: 0x180240B70
	public TouchType get_type() { }

}

