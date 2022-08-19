public struct Keyframe // TypeDefIndex: 3351
{	// Fields
	private float m_Time; // 0x0
	private float m_Value; // 0x4
	private float m_InTangent; // 0x8
	private float m_OutTangent; // 0xC
	private int m_WeightedMode; // 0x10
	private float m_InWeight; // 0x14
	private float m_OutWeight; // 0x18

	// Properties
	public float time { get; set; }
	public float value { get; }
	public float inTangent { set; }
	public float outTangent { set; }

	// Methods

	// RVA: 0x215B20 Offset: 0x214F20 VA: 0x180215B20
	public void .ctor(float time, float value) { }

	// RVA: 0x215B40 Offset: 0x214F40 VA: 0x180215B40
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x13A390 Offset: 0x139790 VA: 0x18013A390
	public float get_time() { }

	// RVA: 0xF2410 Offset: 0xF1810 VA: 0x1800F2410
	public void set_time(float value) { }

	// RVA: 0x2123B0 Offset: 0x2117B0 VA: 0x1802123B0
	public float get_value() { }

	// RVA: 0x1171C0 Offset: 0x1165C0 VA: 0x1801171C0
	public void set_inTangent(float value) { }

	// RVA: 0x1171D0 Offset: 0x1165D0 VA: 0x1801171D0
	public void set_outTangent(float value) { }

}

