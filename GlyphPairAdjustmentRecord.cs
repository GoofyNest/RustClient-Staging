internal struct GlyphPairAdjustmentRecord // TypeDefIndex: 4115
{	// Fields
	[NativeNameAttribute] // RVA: 0x89270 Offset: 0x88670 VA: 0x180089270
	[SerializeField] // RVA: 0x89270 Offset: 0x88670 VA: 0x180089270
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[NativeNameAttribute] // RVA: 0x89360 Offset: 0x88760 VA: 0x180089360
	[SerializeField] // RVA: 0x89360 Offset: 0x88760 VA: 0x180089360
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14

	// Properties
	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }

	// Methods

	// RVA: 0x23DD70 Offset: 0x23D170 VA: 0x18023DD70
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x23DD90 Offset: 0x23D190 VA: 0x18023DD90
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

}

