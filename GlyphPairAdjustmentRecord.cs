internal struct GlyphPairAdjustmentRecord // TypeDefIndex: 4115
{	[NativeNameAttribute] // RVA: 0x892E0 Offset: 0x886E0 VA: 0x1800892E0
	[SerializeField] // RVA: 0x892E0 Offset: 0x886E0 VA: 0x1800892E0
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[NativeNameAttribute] // RVA: 0x893D0 Offset: 0x887D0 VA: 0x1800893D0
	[SerializeField] // RVA: 0x893D0 Offset: 0x887D0 VA: 0x1800893D0
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14

	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }


	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

}

