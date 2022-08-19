public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 4110
{	// Fields
	[NativeNameAttribute] // RVA: 0x85990 Offset: 0x84D90 VA: 0x180085990
	[SerializeField] // RVA: 0x85990 Offset: 0x84D90 VA: 0x180085990
	private int m_X; // 0x0
	[SerializeField] // RVA: 0x85AE0 Offset: 0x84EE0 VA: 0x180085AE0
	[NativeNameAttribute] // RVA: 0x85AE0 Offset: 0x84EE0 VA: 0x180085AE0
	private int m_Y; // 0x4
	[NativeNameAttribute] // RVA: 0x85BD0 Offset: 0x84FD0 VA: 0x180085BD0
	[SerializeField] // RVA: 0x85BD0 Offset: 0x84FD0 VA: 0x180085BD0
	private int m_Width; // 0x8
	[SerializeField] // RVA: 0x85CD0 Offset: 0x850D0 VA: 0x180085CD0
	[NativeNameAttribute] // RVA: 0x85CD0 Offset: 0x850D0 VA: 0x180085CD0
	private int m_Height; // 0xC
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_x() { }

	// RVA: 0x13A380 Offset: 0x139780 VA: 0x18013A380
	public int get_y() { }

	// RVA: 0x13ACA0 Offset: 0x13A0A0 VA: 0x18013ACA0
	public int get_width() { }

	// RVA: 0x221DE0 Offset: 0x2211E0 VA: 0x180221DE0
	public int get_height() { }

	// RVA: 0x22F0DD0 Offset: 0x22EF3D0 VA: 0x1822F0DD0
	public static GlyphRect get_zero() { }

	// RVA: 0x223630 Offset: 0x222A30 VA: 0x180223630
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x23DEB0 Offset: 0x23D2B0 VA: 0x18023DEB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23DDB0 Offset: 0x23D1B0 VA: 0x18023DDB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23DE20 Offset: 0x23D220 VA: 0x18023DE20 Slot: 4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x22F0D80 Offset: 0x22EF380 VA: 0x1822F0D80
	private static void .cctor() { }

}

