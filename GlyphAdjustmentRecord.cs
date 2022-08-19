internal struct GlyphAdjustmentRecord // TypeDefIndex: 4114
{	// Fields
	[NativeNameAttribute] // RVA: 0x88FD0 Offset: 0x883D0 VA: 0x180088FD0
	[SerializeField] // RVA: 0x88FD0 Offset: 0x883D0 VA: 0x180088FD0
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x890A0 Offset: 0x884A0 VA: 0x1800890A0
	[NativeNameAttribute] // RVA: 0x890A0 Offset: 0x884A0 VA: 0x1800890A0
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public uint get_glyphIndex() { }

	// RVA: 0x23DB70 Offset: 0x23CF70 VA: 0x18023DB70
	public GlyphValueRecord get_glyphValueRecord() { }

}

