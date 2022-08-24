internal struct GlyphAdjustmentRecord // TypeDefIndex: 4114
{	[NativeNameAttribute] // RVA: 0x89100 Offset: 0x88500 VA: 0x180089100
	[SerializeField] // RVA: 0x89100 Offset: 0x88500 VA: 0x180089100
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x89190 Offset: 0x88590 VA: 0x180089190
	[NativeNameAttribute] // RVA: 0x89190 Offset: 0x88590 VA: 0x180089190
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }


	public uint get_glyphIndex() { }

	public GlyphValueRecord get_glyphValueRecord() { }

}

