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

	// RVA: 0x218310 Offset: 0x217710 VA: 0x180218310
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x1178E0 Offset: 0x116CE0 VA: 0x1801178E0
	public void .ctor(Rect source) { }

	// RVA: 0x18249F0 Offset: 0x1822FF0 VA: 0x1818249F0
	public static Rect get_zero() { }

	// RVA: 0x1900920 Offset: 0x18FEF20 VA: 0x181900920
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x13A310 Offset: 0x139710 VA: 0x18013A310
	public float get_x() { }

	// RVA: 0xF2390 Offset: 0xF1790 VA: 0x1800F2390
	public void set_x(float value) { }

	// RVA: 0x212330 Offset: 0x211730 VA: 0x180212330
	public float get_y() { }

	// RVA: 0x117920 Offset: 0x116D20 VA: 0x180117920
	public void set_y(float value) { }

	// RVA: 0x2183E0 Offset: 0x2177E0 VA: 0x1802183E0
	public Vector2 get_position() { }

	// RVA: 0x204B30 Offset: 0x203F30 VA: 0x180204B30
	public void set_position(Vector2 value) { }

	// RVA: 0x218350 Offset: 0x217750 VA: 0x180218350
	public Vector2 get_center() { }

	// RVA: 0x218460 Offset: 0x217860 VA: 0x180218460
	public void set_center(Vector2 value) { }

	// RVA: 0x2183E0 Offset: 0x2177E0 VA: 0x1802183E0
	public Vector2 get_min() { }

	// RVA: 0x2184D0 Offset: 0x2178D0 VA: 0x1802184D0
	public void set_min(Vector2 value) { }

	// RVA: 0x2183A0 Offset: 0x2177A0 VA: 0x1802183A0
	public Vector2 get_max() { }

	// RVA: 0x2184A0 Offset: 0x2178A0 VA: 0x1802184A0
	public void set_max(Vector2 value) { }

	// RVA: 0x212340 Offset: 0x211740 VA: 0x180212340
	public float get_width() { }

	// RVA: 0x117140 Offset: 0x116540 VA: 0x180117140
	public void set_width(float value) { }

	// RVA: 0x212350 Offset: 0x211750 VA: 0x180212350
	public float get_height() { }

	// RVA: 0x117150 Offset: 0x116550 VA: 0x180117150
	public void set_height(float value) { }

	// RVA: 0x218410 Offset: 0x217810 VA: 0x180218410
	public Vector2 get_size() { }

	// RVA: 0x218520 Offset: 0x217920 VA: 0x180218520
	public void set_size(Vector2 value) { }

	// RVA: 0x13A310 Offset: 0x139710 VA: 0x18013A310
	public float get_xMin() { }

	// RVA: 0x218550 Offset: 0x217950 VA: 0x180218550
	public void set_xMin(float value) { }

	// RVA: 0x212330 Offset: 0x211730 VA: 0x180212330
	public float get_yMin() { }

	// RVA: 0x218580 Offset: 0x217980 VA: 0x180218580
	public void set_yMin(float value) { }

	// RVA: 0x218440 Offset: 0x217840 VA: 0x180218440
	public float get_xMax() { }

	// RVA: 0x218540 Offset: 0x217940 VA: 0x180218540
	public void set_xMax(float value) { }

	// RVA: 0x218450 Offset: 0x217850 VA: 0x180218450
	public float get_yMax() { }

	// RVA: 0x218570 Offset: 0x217970 VA: 0x180218570
	public void set_yMax(float value) { }

	// RVA: 0x217E90 Offset: 0x217290 VA: 0x180217E90
	public bool Contains(Vector2 point) { }

	// RVA: 0x217E40 Offset: 0x217240 VA: 0x180217E40
	public bool Contains(Vector3 point) { }

	// RVA: 0x1900950 Offset: 0x18FEF50 VA: 0x181900950
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x218120 Offset: 0x217520 VA: 0x180218120
	public bool Overlaps(Rect other) { }

	// RVA: 0x218180 Offset: 0x217580 VA: 0x180218180
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x1900F10 Offset: 0x18FF510 VA: 0x181900F10
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x1900ED0 Offset: 0x18FF4D0 VA: 0x181900ED0
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x218080 Offset: 0x217480 VA: 0x180218080 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x217ED0 Offset: 0x2172D0 VA: 0x180217ED0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x217FE0 Offset: 0x2173E0 VA: 0x180217FE0 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x218300 Offset: 0x217700 VA: 0x180218300 Slot: 3
	public override string ToString() { }

}

