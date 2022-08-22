internal struct GlyphPairAdjustmentRecord // TypeDefIndex: 4115
{	// Fields
	[NativeNameAttribute] // RVA: 0x892E0 Offset: 0x886E0 VA: 0x1800892E0
	[SerializeField] // RVA: 0x892E0 Offset: 0x886E0 VA: 0x1800892E0
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[NativeNameAttribute] // RVA: 0x893D0 Offset: 0x887D0 VA: 0x1800893D0
	[SerializeField] // RVA: 0x893D0 Offset: 0x887D0 VA: 0x1800893D0
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14

	// Properties
	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }

	// Methods

	// RVA: 0x23DCF0 Offset: 0x23D0F0 VA: 0x18023DCF0
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x23DD10 Offset: 0x23D110 VA: 0x18023DD10
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

}

