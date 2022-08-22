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

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0
	public int get_x() { }

	// RVA: 0x13A300 Offset: 0x139700 VA: 0x18013A300
	public int get_y() { }

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	public void .ctor(int x, int y) { }

	// RVA: 0x235810 Offset: 0x234C10 VA: 0x180235810 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2357C0 Offset: 0x234BC0 VA: 0x1802357C0 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x2358D0 Offset: 0x234CD0 VA: 0x1802358D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x235920 Offset: 0x234D20 VA: 0x180235920 Slot: 3
	public override string ToString() { }

	// RVA: 0x2181780 Offset: 0x217FD80 VA: 0x182181780
	private static void .cctor() { }

}

