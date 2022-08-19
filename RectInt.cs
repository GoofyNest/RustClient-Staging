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

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_x() { }

	// RVA: 0x13A380 Offset: 0x139780 VA: 0x18013A380
	public int get_y() { }

	// RVA: 0x13ACA0 Offset: 0x13A0A0 VA: 0x18013ACA0
	public int get_width() { }

	// RVA: 0x221DE0 Offset: 0x2211E0 VA: 0x180221DE0
	public int get_height() { }

	// RVA: 0x221E60 Offset: 0x221260 VA: 0x180221E60
	public int get_xMin() { }

	// RVA: 0x221FC0 Offset: 0x2213C0 VA: 0x180221FC0
	public void set_xMin(int value) { }

	// RVA: 0x221F40 Offset: 0x221340 VA: 0x180221F40
	public int get_yMin() { }

	// RVA: 0x222060 Offset: 0x221460 VA: 0x180222060
	public void set_yMin(int value) { }

	// RVA: 0x221DF0 Offset: 0x2211F0 VA: 0x180221DF0
	public int get_xMax() { }

	// RVA: 0x221FB0 Offset: 0x2213B0 VA: 0x180221FB0
	public void set_xMax(int value) { }

	// RVA: 0x221ED0 Offset: 0x2212D0 VA: 0x180221ED0
	public int get_yMax() { }

	// RVA: 0x222050 Offset: 0x221450 VA: 0x180222050
	public void set_yMax(int value) { }

	// RVA: 0x221DD0 Offset: 0x2211D0 VA: 0x180221DD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x221D80 Offset: 0x221180 VA: 0x180221D80 Slot: 4
	public bool Equals(RectInt other) { }

}

