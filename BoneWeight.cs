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

	// RVA: 0x13A130 Offset: 0x139530 VA: 0x18013A130
	public float get_weight0() { }

	// RVA: 0x211760 Offset: 0x210B60 VA: 0x180211760
	public float get_weight1() { }

	// RVA: 0x211770 Offset: 0x210B70 VA: 0x180211770
	public float get_weight2() { }

	// RVA: 0x211780 Offset: 0x210B80 VA: 0x180211780
	public float get_weight3() { }

	// RVA: 0x211720 Offset: 0x210B20 VA: 0x180211720
	public int get_boneIndex0() { }

	// RVA: 0x211730 Offset: 0x210B30 VA: 0x180211730
	public int get_boneIndex1() { }

	// RVA: 0x211740 Offset: 0x210B40 VA: 0x180211740
	public int get_boneIndex2() { }

	// RVA: 0x211750 Offset: 0x210B50 VA: 0x180211750
	public int get_boneIndex3() { }

	// RVA: 0x211610 Offset: 0x210A10 VA: 0x180211610 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211540 Offset: 0x210940 VA: 0x180211540 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2115E0 Offset: 0x2109E0 VA: 0x1802115E0 Slot: 4
	public bool Equals(BoneWeight other) { }

}

