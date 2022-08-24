public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 4110
{	[NativeNameAttribute] // RVA: 0x85BA0 Offset: 0x84FA0 VA: 0x180085BA0
	[SerializeField] // RVA: 0x85BA0 Offset: 0x84FA0 VA: 0x180085BA0
	private int m_X; // 0x0
	[SerializeField] // RVA: 0x85CA0 Offset: 0x850A0 VA: 0x180085CA0
	[NativeNameAttribute] // RVA: 0x85CA0 Offset: 0x850A0 VA: 0x180085CA0
	private int m_Y; // 0x4
	[NativeNameAttribute] // RVA: 0x85D90 Offset: 0x85190 VA: 0x180085D90
	[SerializeField] // RVA: 0x85D90 Offset: 0x85190 VA: 0x180085D90
	private int m_Width; // 0x8
	[SerializeField] // RVA: 0x85EB0 Offset: 0x852B0 VA: 0x180085EB0
	[NativeNameAttribute] // RVA: 0x85EB0 Offset: 0x852B0 VA: 0x180085EB0
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

