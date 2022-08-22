public struct Vector3Int : IEquatable<Vector3Int> // TypeDefIndex: 3472
{	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C

	// Properties
	public int x { get; }
	public int y { get; }
	public int z { get; }

	// Methods

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0
	public int get_x() { }

	// RVA: 0x13A120 Offset: 0x139520 VA: 0x18013A120
	public int get_y() { }

	// RVA: 0x13AA40 Offset: 0x139E40 VA: 0x18013AA40
	public int get_z() { }

	// RVA: 0x20BA90 Offset: 0x20AE90 VA: 0x18020BA90
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x2183440 Offset: 0x2181A40 VA: 0x182183440
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x235E80 Offset: 0x235280 VA: 0x180235E80 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x235FA0 Offset: 0x2353A0 VA: 0x180235FA0 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x236040 Offset: 0x235440 VA: 0x180236040 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2360C0 Offset: 0x2354C0 VA: 0x1802360C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2183320 Offset: 0x2181920 VA: 0x182183320
	private static void .cctor() { }

}

