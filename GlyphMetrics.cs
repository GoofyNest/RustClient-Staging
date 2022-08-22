public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 4111
{	// Fields
	[NativeNameAttribute] // RVA: 0x85C40 Offset: 0x85040 VA: 0x180085C40
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

	// Properties
	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }

	// Methods

	// RVA: 0x13A310 Offset: 0x139710 VA: 0x18013A310
	public float get_width() { }

	// RVA: 0x212330 Offset: 0x211730 VA: 0x180212330
	public float get_height() { }

	// RVA: 0x212340 Offset: 0x211740 VA: 0x180212340
	public float get_horizontalBearingX() { }

	// RVA: 0x212350 Offset: 0x211750 VA: 0x180212350
	public float get_horizontalBearingY() { }

	// RVA: 0x23DCE0 Offset: 0x23D0E0 VA: 0x18023DCE0
	public float get_horizontalAdvance() { }

	// RVA: 0x23DCB0 Offset: 0x23D0B0 VA: 0x18023DCB0
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x23DC50 Offset: 0x23D050 VA: 0x18023DC50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23DBE0 Offset: 0x23CFE0 VA: 0x18023DBE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23DB40 Offset: 0x23CF40 VA: 0x18023DB40 Slot: 4
	public bool Equals(GlyphMetrics other) { }

}

