public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 3443
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_Weight0; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_Weight1; // 0x4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_Weight2; // 0x8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_Weight3; // 0xC
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_BoneIndex0; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_BoneIndex1; // 0x14
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_BoneIndex2; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_BoneIndex3; // 0x1C

	// Properties
	public float weight0 { get; }
	public float weight1 { get; }
	public float weight2 { get; }
	public float weight3 { get; }
	public int boneIndex0 { get; }
	public int boneIndex1 { get; }
	public int boneIndex2 { get; }
	public int boneIndex3 { get; }

	// Methods

	// RVA: 0x13A390 Offset: 0x139790 VA: 0x18013A390
	public float get_weight0() { }

	// RVA: 0x2123B0 Offset: 0x2117B0 VA: 0x1802123B0
	public float get_weight1() { }

	// RVA: 0x2123C0 Offset: 0x2117C0 VA: 0x1802123C0
	public float get_weight2() { }

	// RVA: 0x2123D0 Offset: 0x2117D0 VA: 0x1802123D0
	public float get_weight3() { }

	// RVA: 0x212370 Offset: 0x211770 VA: 0x180212370
	public int get_boneIndex0() { }

	// RVA: 0x212380 Offset: 0x211780 VA: 0x180212380
	public int get_boneIndex1() { }

	// RVA: 0x212390 Offset: 0x211790 VA: 0x180212390
	public int get_boneIndex2() { }

	// RVA: 0x2123A0 Offset: 0x2117A0 VA: 0x1802123A0
	public int get_boneIndex3() { }

	// RVA: 0x212260 Offset: 0x211660 VA: 0x180212260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212190 Offset: 0x211590 VA: 0x180212190 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212230 Offset: 0x211630 VA: 0x180212230 Slot: 4
	public bool Equals(BoneWeight other) { }

}

