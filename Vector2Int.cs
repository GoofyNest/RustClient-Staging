public struct Vector2Int : IEquatable<Vector2Int> // TypeDefIndex: 3471
{	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public int x { get; }
	public int y { get; }

	// Methods

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_x() { }

	// RVA: 0x13A380 Offset: 0x139780 VA: 0x18013A380
	public int get_y() { }

	// RVA: 0xF8950 Offset: 0xF7D50 VA: 0x1800F8950
	public void .ctor(int x, int y) { }

	// RVA: 0x235890 Offset: 0x234C90 VA: 0x180235890 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x235840 Offset: 0x234C40 VA: 0x180235840 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x235950 Offset: 0x234D50 VA: 0x180235950 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2359A0 Offset: 0x234DA0 VA: 0x1802359A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2181940 Offset: 0x217FF40 VA: 0x182181940
	private static void .cctor() { }

}

