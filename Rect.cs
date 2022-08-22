public struct Rect : IEquatable<Rect> // TypeDefIndex: 3376
{	// Fields
	[NativeNameAttribute] // RVA: 0x7F710 Offset: 0x7EB10 VA: 0x18007F710
	private float m_XMin; // 0x0
	[NativeNameAttribute] // RVA: 0x7F820 Offset: 0x7EC20 VA: 0x18007F820
	private float m_YMin; // 0x4
	[NativeNameAttribute] // RVA: 0x7F8D0 Offset: 0x7ECD0 VA: 0x18007F8D0
	private float m_Width; // 0x8
	[NativeNameAttribute] // RVA: 0x7FA00 Offset: 0x7EE00 VA: 0x18007FA00
	private float m_Height; // 0xC

	// Properties
	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 position { get; set; }
	public Vector2 center { get; set; }
	public Vector2 min { get; set; }
	public Vector2 max { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public Vector2 size { get; set; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0xF2AC0 Offset: 0xF1EC0 VA: 0x1800F2AC0
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x2189E0 Offset: 0x217DE0 VA: 0x1802189E0
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x1178E0 Offset: 0x116CE0 VA: 0x1801178E0
	public void .ctor(Rect source) { }

	// RVA: 0x1811E30 Offset: 0x1810430 VA: 0x181811E30
	public static Rect get_zero() { }

	// RVA: 0x1900040 Offset: 0x18FE640 VA: 0x181900040
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x13A130 Offset: 0x139530 VA: 0x18013A130
	public float get_x() { }

	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390
	public void set_x(float value) { }

	// RVA: 0x211760 Offset: 0x210B60 VA: 0x180211760
	public float get_y() { }

	// RVA: 0x117920 Offset: 0x116D20 VA: 0x180117920
	public void set_y(float value) { }

	// RVA: 0x218AB0 Offset: 0x217EB0 VA: 0x180218AB0
	public Vector2 get_position() { }

	// RVA: 0x204760 Offset: 0x203B60 VA: 0x180204760
	public void set_position(Vector2 value) { }

	// RVA: 0x218A20 Offset: 0x217E20 VA: 0x180218A20
	public Vector2 get_center() { }

	// RVA: 0x218B30 Offset: 0x217F30 VA: 0x180218B30
	public void set_center(Vector2 value) { }

	// RVA: 0x218AB0 Offset: 0x217EB0 VA: 0x180218AB0
	public Vector2 get_min() { }

	// RVA: 0x218BA0 Offset: 0x217FA0 VA: 0x180218BA0
	public void set_min(Vector2 value) { }

	// RVA: 0x218A70 Offset: 0x217E70 VA: 0x180218A70
	public Vector2 get_max() { }

	// RVA: 0x218B70 Offset: 0x217F70 VA: 0x180218B70
	public void set_max(Vector2 value) { }

	// RVA: 0x211770 Offset: 0x210B70 VA: 0x180211770
	public float get_width() { }

	// RVA: 0x117140 Offset: 0x116540 VA: 0x180117140
	public void set_width(float value) { }

	// RVA: 0x211780 Offset: 0x210B80 VA: 0x180211780
	public float get_height() { }

	// RVA: 0x117150 Offset: 0x116550 VA: 0x180117150
	public void set_height(float value) { }

	// RVA: 0x218AE0 Offset: 0x217EE0 VA: 0x180218AE0
	public Vector2 get_size() { }

	// RVA: 0x218BF0 Offset: 0x217FF0 VA: 0x180218BF0
	public void set_size(Vector2 value) { }

	// RVA: 0x13A130 Offset: 0x139530 VA: 0x18013A130
	public float get_xMin() { }

	// RVA: 0x218C20 Offset: 0x218020 VA: 0x180218C20
	public void set_xMin(float value) { }

	// RVA: 0x211760 Offset: 0x210B60 VA: 0x180211760
	public float get_yMin() { }

	// RVA: 0x218C50 Offset: 0x218050 VA: 0x180218C50
	public void set_yMin(float value) { }

	// RVA: 0x218B10 Offset: 0x217F10 VA: 0x180218B10
	public float get_xMax() { }

	// RVA: 0x218C10 Offset: 0x218010 VA: 0x180218C10
	public void set_xMax(float value) { }

	// RVA: 0x218B20 Offset: 0x217F20 VA: 0x180218B20
	public float get_yMax() { }

	// RVA: 0x218C40 Offset: 0x218040 VA: 0x180218C40
	public void set_yMax(float value) { }

	// RVA: 0x218560 Offset: 0x217960 VA: 0x180218560
	public bool Contains(Vector2 point) { }

	// RVA: 0x218510 Offset: 0x217910 VA: 0x180218510
	public bool Contains(Vector3 point) { }

	// RVA: 0x1900070 Offset: 0x18FE670 VA: 0x181900070
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x2187F0 Offset: 0x217BF0 VA: 0x1802187F0
	public bool Overlaps(Rect other) { }

	// RVA: 0x218850 Offset: 0x217C50 VA: 0x180218850
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x1900630 Offset: 0x18FEC30 VA: 0x181900630
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x19005F0 Offset: 0x18FEBF0 VA: 0x1819005F0
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x218750 Offset: 0x217B50 VA: 0x180218750 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2185A0 Offset: 0x2179A0 VA: 0x1802185A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2186B0 Offset: 0x217AB0 VA: 0x1802186B0 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x2189D0 Offset: 0x217DD0 VA: 0x1802189D0 Slot: 3
	public override string ToString() { }

}

