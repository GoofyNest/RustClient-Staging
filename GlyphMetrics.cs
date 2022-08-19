public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 4111
{	// Fields
	[NativeNameAttribute] // RVA: 0x85BD0 Offset: 0x84FD0 VA: 0x180085BD0
	[SerializeField] // RVA: 0x85BD0 Offset: 0x84FD0 VA: 0x180085BD0
	private float m_Width; // 0x0
	[NativeNameAttribute] // RVA: 0x85F40 Offset: 0x85340 VA: 0x180085F40
	[SerializeField] // RVA: 0x85F40 Offset: 0x85340 VA: 0x180085F40
	private float m_Height; // 0x4
	[SerializeField] // RVA: 0x86150 Offset: 0x85550 VA: 0x180086150
	[NativeNameAttribute] // RVA: 0x86150 Offset: 0x85550 VA: 0x180086150
	private float m_HorizontalBearingX; // 0x8
	[SerializeField] // RVA: 0x86230 Offset: 0x85630 VA: 0x180086230
	[NativeNameAttribute] // RVA: 0x86230 Offset: 0x85630 VA: 0x180086230
	private float m_HorizontalBearingY; // 0xC
	[NativeNameAttribute] // RVA: 0x863A0 Offset: 0x857A0 VA: 0x1800863A0
	[SerializeField] // RVA: 0x863A0 Offset: 0x857A0 VA: 0x1800863A0
	private float m_HorizontalAdvance; // 0x10

	// Properties
	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }

	// Methods

	// RVA: 0x13A390 Offset: 0x139790 VA: 0x18013A390
	public float get_width() { }

	// RVA: 0x2123B0 Offset: 0x2117B0 VA: 0x1802123B0
	public float get_height() { }

	// RVA: 0x2123C0 Offset: 0x2117C0 VA: 0x1802123C0
	public float get_horizontalBearingX() { }

	// RVA: 0x2123D0 Offset: 0x2117D0 VA: 0x1802123D0
	public float get_horizontalBearingY() { }

	// RVA: 0x23DD60 Offset: 0x23D160 VA: 0x18023DD60
	public float get_horizontalAdvance() { }

	// RVA: 0x23DD30 Offset: 0x23D130 VA: 0x18023DD30
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x23DCD0 Offset: 0x23D0D0 VA: 0x18023DCD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23DC60 Offset: 0x23D060 VA: 0x18023DC60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23DBC0 Offset: 0x23CFC0 VA: 0x18023DBC0 Slot: 4
	public bool Equals(GlyphMetrics other) { }

}

