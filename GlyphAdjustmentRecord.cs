internal struct GlyphAdjustmentRecord // TypeDefIndex: 4114
{	// Fields
	[NativeNameAttribute] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	[SerializeField] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x890D0 Offset: 0x884D0 VA: 0x1800890D0
	[NativeNameAttribute] // RVA: 0x890D0 Offset: 0x884D0 VA: 0x1800890D0
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0
	public uint get_glyphIndex() { }

	// RVA: 0x23DAF0 Offset: 0x23CEF0 VA: 0x18023DAF0
	public GlyphValueRecord get_glyphValueRecord() { }

}

