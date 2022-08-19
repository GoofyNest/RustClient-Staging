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

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_x() { }

	// RVA: 0x13A380 Offset: 0x139780 VA: 0x18013A380
	public int get_y() { }

	// RVA: 0x13ACA0 Offset: 0x13A0A0 VA: 0x18013ACA0
	public int get_z() { }

	// RVA: 0x20BEE0 Offset: 0x20B2E0 VA: 0x18020BEE0
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x2182B20 Offset: 0x2181120 VA: 0x182182B20
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x235F00 Offset: 0x235300 VA: 0x180235F00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x236020 Offset: 0x235420 VA: 0x180236020 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x2360C0 Offset: 0x2354C0 VA: 0x1802360C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x236140 Offset: 0x235540 VA: 0x180236140 Slot: 3
	public override string ToString() { }

	// RVA: 0x2182A00 Offset: 0x2181000 VA: 0x182182A00
	private static void .cctor() { }

}

