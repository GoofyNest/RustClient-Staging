internal struct GlyphAdjustmentRecord // TypeDefIndex: 4114
{	[NativeNameAttribute] // RVA: 0x890C0 Offset: 0x884C0 VA: 0x1800890C0
	[SerializeField] // RVA: 0x890C0 Offset: 0x884C0 VA: 0x1800890C0
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x89220 Offset: 0x88620 VA: 0x180089220
	[NativeNameAttribute] // RVA: 0x89220 Offset: 0x88620 VA: 0x180089220
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }


	public uint get_glyphIndex() { }

	public GlyphValueRecord get_glyphValueRecord() { }

}

