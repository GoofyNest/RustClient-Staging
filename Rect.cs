public struct Rect : IEquatable<Rect> // TypeDefIndex: 3376
{	// Fields
	[NativeNameAttribute] // RVA: 0x7F640 Offset: 0x7EA40 VA: 0x18007F640
	private float m_XMin; // 0x0
	[NativeNameAttribute] // RVA: 0x7F750 Offset: 0x7EB50 VA: 0x18007F750
	private float m_YMin; // 0x4
	[NativeNameAttribute] // RVA: 0x7F800 Offset: 0x7EC00 VA: 0x18007F800
	private float m_Width; // 0x8
	[NativeNameAttribute] // RVA: 0x7F930 Offset: 0x7ED30 VA: 0x18007F930
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

	// RVA: 0xF2B40 Offset: 0xF1F40 VA: 0x1800F2B40
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x218390 Offset: 0x217790 VA: 0x180218390
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x117960 Offset: 0x116D60 VA: 0x180117960
	public void .ctor(Rect source) { }

	// RVA: 0x1824730 Offset: 0x1822D30 VA: 0x181824730
	public static Rect get_zero() { }

	// RVA: 0x19006A0 Offset: 0x18FECA0 VA: 0x1819006A0
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x13A390 Offset: 0x139790 VA: 0x18013A390
	public float get_x() { }

	// RVA: 0xF2410 Offset: 0xF1810 VA: 0x1800F2410
	public void set_x(float value) { }

	// RVA: 0x2123B0 Offset: 0x2117B0 VA: 0x1802123B0
	public float get_y() { }

	// RVA: 0x1179A0 Offset: 0x116DA0 VA: 0x1801179A0
	public void set_y(float value) { }

	// RVA: 0x218460 Offset: 0x217860 VA: 0x180218460
	public Vector2 get_position() { }

	// RVA: 0x204BB0 Offset: 0x203FB0 VA: 0x180204BB0
	public void set_position(Vector2 value) { }

	// RVA: 0x2183D0 Offset: 0x2177D0 VA: 0x1802183D0
	public Vector2 get_center() { }

	// RVA: 0x2184E0 Offset: 0x2178E0 VA: 0x1802184E0
	public void set_center(Vector2 value) { }

	// RVA: 0x218460 Offset: 0x217860 VA: 0x180218460
	public Vector2 get_min() { }

	// RVA: 0x218550 Offset: 0x217950 VA: 0x180218550
	public void set_min(Vector2 value) { }

	// RVA: 0x218420 Offset: 0x217820 VA: 0x180218420
	public Vector2 get_max() { }

	// RVA: 0x218520 Offset: 0x217920 VA: 0x180218520
	public void set_max(Vector2 value) { }

	// RVA: 0x2123C0 Offset: 0x2117C0 VA: 0x1802123C0
	public float get_width() { }

	// RVA: 0x1171C0 Offset: 0x1165C0 VA: 0x1801171C0
	public void set_width(float value) { }

	// RVA: 0x2123D0 Offset: 0x2117D0 VA: 0x1802123D0
	public float get_height() { }

	// RVA: 0x1171D0 Offset: 0x1165D0 VA: 0x1801171D0
	public void set_height(float value) { }

	// RVA: 0x218490 Offset: 0x217890 VA: 0x180218490
	public Vector2 get_size() { }

	// RVA: 0x2185A0 Offset: 0x2179A0 VA: 0x1802185A0
	public void set_size(Vector2 value) { }

	// RVA: 0x13A390 Offset: 0x139790 VA: 0x18013A390
	public float get_xMin() { }

	// RVA: 0x2185D0 Offset: 0x2179D0 VA: 0x1802185D0
	public void set_xMin(float value) { }

	// RVA: 0x2123B0 Offset: 0x2117B0 VA: 0x1802123B0
	public float get_yMin() { }

	// RVA: 0x218600 Offset: 0x217A00 VA: 0x180218600
	public void set_yMin(float value) { }

	// RVA: 0x2184C0 Offset: 0x2178C0 VA: 0x1802184C0
	public float get_xMax() { }

	// RVA: 0x2185C0 Offset: 0x2179C0 VA: 0x1802185C0
	public void set_xMax(float value) { }

	// RVA: 0x2184D0 Offset: 0x2178D0 VA: 0x1802184D0
	public float get_yMax() { }

	// RVA: 0x2185F0 Offset: 0x2179F0 VA: 0x1802185F0
	public void set_yMax(float value) { }

	// RVA: 0x217F10 Offset: 0x217310 VA: 0x180217F10
	public bool Contains(Vector2 point) { }

	// RVA: 0x217EC0 Offset: 0x2172C0 VA: 0x180217EC0
	public bool Contains(Vector3 point) { }

	// RVA: 0x19006D0 Offset: 0x18FECD0 VA: 0x1819006D0
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x2181A0 Offset: 0x2175A0 VA: 0x1802181A0
	public bool Overlaps(Rect other) { }

	// RVA: 0x218200 Offset: 0x217600 VA: 0x180218200
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x1900C90 Offset: 0x18FF290 VA: 0x181900C90
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x1900C50 Offset: 0x18FF250 VA: 0x181900C50
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x218100 Offset: 0x217500 VA: 0x180218100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x217F50 Offset: 0x217350 VA: 0x180217F50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x218060 Offset: 0x217460 VA: 0x180218060 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x218380 Offset: 0x217780 VA: 0x180218380 Slot: 3
	public override string ToString() { }

}

