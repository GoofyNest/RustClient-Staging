public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 4110
{	// Fields
	[NativeNameAttribute] // RVA: 0x85A80 Offset: 0x84E80 VA: 0x180085A80
	[SerializeField] // RVA: 0x85A80 Offset: 0x84E80 VA: 0x180085A80
	private int m_X; // 0x0
	[SerializeField] // RVA: 0x85B50 Offset: 0x84F50 VA: 0x180085B50
	[NativeNameAttribute] // RVA: 0x85B50 Offset: 0x84F50 VA: 0x180085B50
	private int m_Y; // 0x4
	[NativeNameAttribute] // RVA: 0x85C40 Offset: 0x85040 VA: 0x180085C40
	[SerializeField] // RVA: 0x85C40 Offset: 0x85040 VA: 0x180085C40
	private int m_Width; // 0x8
	[SerializeField] // RVA: 0x85D60 Offset: 0x85160 VA: 0x180085D60
	[NativeNameAttribute] // RVA: 0x85D60 Offset: 0x85160 VA: 0x180085D60
	private int m_Height; // 0xC
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0
	public int get_x() { }

	// RVA: 0x13A120 Offset: 0x139520 VA: 0x18013A120
	public int get_y() { }

	// RVA: 0x13AA40 Offset: 0x139E40 VA: 0x18013AA40
	public int get_width() { }

	// RVA: 0x21D2E0 Offset: 0x21C6E0 VA: 0x18021D2E0
	public int get_height() { }

	// RVA: 0x22F16F0 Offset: 0x22EFCF0 VA: 0x1822F16F0
	public static GlyphRect get_zero() { }

	// RVA: 0x21EB30 Offset: 0x21DF30 VA: 0x18021EB30
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x23DE30 Offset: 0x23D230 VA: 0x18023DE30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23DD30 Offset: 0x23D130 VA: 0x18023DD30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23DDA0 Offset: 0x23D1A0 VA: 0x18023DDA0 Slot: 4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x22F16A0 Offset: 0x22EFCA0 VA: 0x1822F16A0
	private static void .cctor() { }

}

