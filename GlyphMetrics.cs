public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 4111
{	[NativeNameAttribute] // RVA: 0x85C70 Offset: 0x85070 VA: 0x180085C70
	[SerializeField] // RVA: 0x85C70 Offset: 0x85070 VA: 0x180085C70
	private float m_Width; // 0x0
	[NativeNameAttribute] // RVA: 0x86010 Offset: 0x85410 VA: 0x180086010
	[SerializeField] // RVA: 0x86010 Offset: 0x85410 VA: 0x180086010
	private float m_Height; // 0x4
	[SerializeField] // RVA: 0x86280 Offset: 0x85680 VA: 0x180086280
	[NativeNameAttribute] // RVA: 0x86280 Offset: 0x85680 VA: 0x180086280
	private float m_HorizontalBearingX; // 0x8
	[SerializeField] // RVA: 0x86370 Offset: 0x85770 VA: 0x180086370
	[NativeNameAttribute] // RVA: 0x86370 Offset: 0x85770 VA: 0x180086370
	private float m_HorizontalBearingY; // 0xC
	[NativeNameAttribute] // RVA: 0x86520 Offset: 0x85920 VA: 0x180086520
	[SerializeField] // RVA: 0x86520 Offset: 0x85920 VA: 0x180086520
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

