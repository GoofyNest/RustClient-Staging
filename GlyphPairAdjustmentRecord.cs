internal struct GlyphPairAdjustmentRecord // TypeDefIndex: 4115
{	[NativeNameAttribute] // RVA: 0x893C0 Offset: 0x887C0 VA: 0x1800893C0
	[SerializeField] // RVA: 0x893C0 Offset: 0x887C0 VA: 0x1800893C0
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[NativeNameAttribute] // RVA: 0x894E0 Offset: 0x888E0 VA: 0x1800894E0
	[SerializeField] // RVA: 0x894E0 Offset: 0x888E0 VA: 0x1800894E0
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14

	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }


	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

}

