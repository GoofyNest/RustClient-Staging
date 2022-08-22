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

	// RVA: 0x215AA0 Offset: 0x214EA0 VA: 0x180215AA0
	public void .ctor(float time, float value) { }

	// RVA: 0x215AC0 Offset: 0x214EC0 VA: 0x180215AC0
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x13A310 Offset: 0x139710 VA: 0x18013A310
	public float get_time() { }

	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390
	public void set_time(float value) { }

	// RVA: 0x212330 Offset: 0x211730 VA: 0x180212330
	public float get_value() { }

	// RVA: 0x117140 Offset: 0x116540 VA: 0x180117140
	public void set_inTangent(float value) { }

	// RVA: 0x117150 Offset: 0x116550 VA: 0x180117150
	public void set_outTangent(float value) { }

}

