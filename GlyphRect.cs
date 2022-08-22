public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 4110
{	[NativeNameAttribute] // RVA: 0x85A80 Offset: 0x84E80 VA: 0x180085A80
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

	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }


	public int get_x() { }

	public int get_y() { }

	public int get_width() { }

	public int get_height() { }

	public static GlyphRect get_zero() { }

	public void .ctor(int x, int y, int width, int height) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(GlyphRect other) { }

	private static void .cctor() { }

}

