internal struct GlyphAdjustmentRecord // TypeDefIndex: 4114
{	[NativeNameAttribute] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	[SerializeField] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x890D0 Offset: 0x884D0 VA: 0x1800890D0
	[NativeNameAttribute] // RVA: 0x890D0 Offset: 0x884D0 VA: 0x1800890D0
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }


	public uint get_glyphIndex() { }

	public GlyphValueRecord get_glyphValueRecord() { }

}

