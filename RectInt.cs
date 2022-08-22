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

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0
	public int get_x() { }

	// RVA: 0x13A300 Offset: 0x139700 VA: 0x18013A300
	public int get_y() { }

	// RVA: 0x13AC20 Offset: 0x13A020 VA: 0x18013AC20
	public int get_width() { }

	// RVA: 0x221D60 Offset: 0x221160 VA: 0x180221D60
	public int get_height() { }

	// RVA: 0x221DE0 Offset: 0x2211E0 VA: 0x180221DE0
	public int get_xMin() { }

	// RVA: 0x221F40 Offset: 0x221340 VA: 0x180221F40
	public void set_xMin(int value) { }

	// RVA: 0x221EC0 Offset: 0x2212C0 VA: 0x180221EC0
	public int get_yMin() { }

	// RVA: 0x221FE0 Offset: 0x2213E0 VA: 0x180221FE0
	public void set_yMin(int value) { }

	// RVA: 0x221D70 Offset: 0x221170 VA: 0x180221D70
	public int get_xMax() { }

	// RVA: 0x221F30 Offset: 0x221330 VA: 0x180221F30
	public void set_xMax(int value) { }

	// RVA: 0x221E50 Offset: 0x221250 VA: 0x180221E50
	public int get_yMax() { }

	// RVA: 0x221FD0 Offset: 0x2213D0 VA: 0x180221FD0
	public void set_yMax(int value) { }

	// RVA: 0x221D50 Offset: 0x221150 VA: 0x180221D50 Slot: 3
	public override string ToString() { }

	// RVA: 0x221D00 Offset: 0x221100 VA: 0x180221D00 Slot: 4
	public bool Equals(RectInt other) { }

}

