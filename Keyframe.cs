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

	// RVA: 0x216170 Offset: 0x215570 VA: 0x180216170
	public void .ctor(float time, float value) { }

	// RVA: 0x216190 Offset: 0x215590 VA: 0x180216190
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x13A130 Offset: 0x139530 VA: 0x18013A130
	public float get_time() { }

	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390
	public void set_time(float value) { }

	// RVA: 0x211760 Offset: 0x210B60 VA: 0x180211760
	public float get_value() { }

	// RVA: 0x117140 Offset: 0x116540 VA: 0x180117140
	public void set_inTangent(float value) { }

	// RVA: 0x117150 Offset: 0x116550 VA: 0x180117150
	public void set_outTangent(float value) { }

}

