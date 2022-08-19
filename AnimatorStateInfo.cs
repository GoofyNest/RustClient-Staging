public struct AnimatorStateInfo // TypeDefIndex: 4485
{	// Fields
	private int m_Name; // 0x0
	private int m_Path; // 0x4
	private int m_FullPath; // 0x8
	private float m_NormalizedTime; // 0xC
	private float m_Length; // 0x10
	private float m_Speed; // 0x14
	private float m_SpeedMultiplier; // 0x18
	private int m_Tag; // 0x1C
	private int m_Loop; // 0x20

	// Properties
	public int shortNameHash { get; }
	public float normalizedTime { get; }
	public float speed { get; }

	// Methods

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_shortNameHash() { }

	// RVA: 0x2123D0 Offset: 0x2117D0 VA: 0x1802123D0
	public float get_normalizedTime() { }

	// RVA: 0x23D220 Offset: 0x23C620 VA: 0x18023D220
	public float get_speed() { }

}

