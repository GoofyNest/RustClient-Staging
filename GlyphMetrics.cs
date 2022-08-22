public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 4111
{	[NativeNameAttribute] // RVA: 0x85C40 Offset: 0x85040 VA: 0x180085C40
	[SerializeField] // RVA: 0x85C40 Offset: 0x85040 VA: 0x180085C40
	private float m_Width; // 0x0
	[NativeNameAttribute] // RVA: 0x85FA0 Offset: 0x853A0 VA: 0x180085FA0
	[SerializeField] // RVA: 0x85FA0 Offset: 0x853A0 VA: 0x180085FA0
	private float m_Height; // 0x4
	[SerializeField] // RVA: 0x86230 Offset: 0x85630 VA: 0x180086230
	[NativeNameAttribute] // RVA: 0x86230 Offset: 0x85630 VA: 0x180086230
	private float m_HorizontalBearingX; // 0x8
	[SerializeField] // RVA: 0x862A0 Offset: 0x856A0 VA: 0x1800862A0
	[NativeNameAttribute] // RVA: 0x862A0 Offset: 0x856A0 VA: 0x1800862A0
	private float m_HorizontalBearingY; // 0xC
	[NativeNameAttribute] // RVA: 0x86410 Offset: 0x85810 VA: 0x180086410
	[SerializeField] // RVA: 0x86410 Offset: 0x85810 VA: 0x180086410
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

