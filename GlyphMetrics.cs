public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 4111
{	[NativeNameAttribute] // RVA: 0x85D90 Offset: 0x85190 VA: 0x180085D90
	[SerializeField] // RVA: 0x85D90 Offset: 0x85190 VA: 0x180085D90
	private float m_Width; // 0x0
	[NativeNameAttribute] // RVA: 0x860F0 Offset: 0x854F0 VA: 0x1800860F0
	[SerializeField] // RVA: 0x860F0 Offset: 0x854F0 VA: 0x1800860F0
	private float m_Height; // 0x4
	[SerializeField] // RVA: 0x86320 Offset: 0x85720 VA: 0x180086320
	[NativeNameAttribute] // RVA: 0x86320 Offset: 0x85720 VA: 0x180086320
	private float m_HorizontalBearingX; // 0x8
	[SerializeField] // RVA: 0x863C0 Offset: 0x857C0 VA: 0x1800863C0
	[NativeNameAttribute] // RVA: 0x863C0 Offset: 0x857C0 VA: 0x1800863C0
	private float m_HorizontalBearingY; // 0xC
	[NativeNameAttribute] // RVA: 0x86560 Offset: 0x85960 VA: 0x180086560
	[SerializeField] // RVA: 0x86560 Offset: 0x85960 VA: 0x180086560
	private float m_HorizontalAdvance; // 0x10

	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }


	public float get_width() { }

	public float get_height() { }

	public float get_horizontalBearingX() { }

	public float get_horizontalBearingY() { }

	public float get_horizontalAdvance() { }

	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(GlyphMetrics other) { }

}

