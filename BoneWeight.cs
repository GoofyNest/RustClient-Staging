public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 3443
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Weight0; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Weight1; // 0x4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Weight2; // 0x8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Weight3; // 0xC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_BoneIndex0; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_BoneIndex1; // 0x14
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_BoneIndex2; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x13A310 Offset: 0x139710 VA: 0x18013A310
	public float get_weight0() { }

	// RVA: 0x212330 Offset: 0x211730 VA: 0x180212330
	public float get_weight1() { }

	// RVA: 0x212340 Offset: 0x211740 VA: 0x180212340
	public float get_weight2() { }

	// RVA: 0x212350 Offset: 0x211750 VA: 0x180212350
	public float get_weight3() { }

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0
	public int get_boneIndex0() { }

	// RVA: 0x212300 Offset: 0x211700 VA: 0x180212300
	public int get_boneIndex1() { }

	// RVA: 0x212310 Offset: 0x211710 VA: 0x180212310
	public int get_boneIndex2() { }

	// RVA: 0x212320 Offset: 0x211720 VA: 0x180212320
	public int get_boneIndex3() { }

	// RVA: 0x2121E0 Offset: 0x2115E0 VA: 0x1802121E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212110 Offset: 0x211510 VA: 0x180212110 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2121B0 Offset: 0x2115B0 VA: 0x1802121B0 Slot: 4
	public bool Equals(BoneWeight other) { }

}

