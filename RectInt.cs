public struct RectInt : IEquatable<RectInt> // TypeDefIndex: 3377
{	// Fields
	private int m_XMin; // 0x0
	private int m_YMin; // 0x4
	private int m_Width; // 0x8
	private int m_Height; // 0xC

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public int xMin { get; set; }
	public int yMin { get; set; }
	public int xMax { get; set; }
	public int yMax { get; set; }

	// Methods

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0
	public int get_x() { }

	// RVA: 0x13A120 Offset: 0x139520 VA: 0x18013A120
	public int get_y() { }

	// RVA: 0x13AA40 Offset: 0x139E40 VA: 0x18013AA40
	public int get_width() { }

	// RVA: 0x21D2E0 Offset: 0x21C6E0 VA: 0x18021D2E0
	public int get_height() { }

	// RVA: 0x21D360 Offset: 0x21C760 VA: 0x18021D360
	public int get_xMin() { }

	// RVA: 0x21D4C0 Offset: 0x21C8C0 VA: 0x18021D4C0
	public void set_xMin(int value) { }

	// RVA: 0x21D440 Offset: 0x21C840 VA: 0x18021D440
	public int get_yMin() { }

	// RVA: 0x21D560 Offset: 0x21C960 VA: 0x18021D560
	public void set_yMin(int value) { }

	// RVA: 0x21D2F0 Offset: 0x21C6F0 VA: 0x18021D2F0
	public int get_xMax() { }

	// RVA: 0x21D4B0 Offset: 0x21C8B0 VA: 0x18021D4B0
	public void set_xMax(int value) { }

	// RVA: 0x21D3D0 Offset: 0x21C7D0 VA: 0x18021D3D0
	public int get_yMax() { }

	// RVA: 0x21D550 Offset: 0x21C950 VA: 0x18021D550
	public void set_yMax(int value) { }

	// RVA: 0x21D2D0 Offset: 0x21C6D0 VA: 0x18021D2D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21D280 Offset: 0x21C680 VA: 0x18021D280 Slot: 4
	public bool Equals(RectInt other) { }

}

