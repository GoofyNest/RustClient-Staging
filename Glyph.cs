public class Glyph // TypeDefIndex: 4112
{	// Fields
	[NativeNameAttribute] // RVA: 0x86700 Offset: 0x85B00 VA: 0x180086700
	[SerializeField] // RVA: 0x86700 Offset: 0x85B00 VA: 0x180086700
	private uint m_Index; // 0x10
	[SerializeField] // RVA: 0x87B40 Offset: 0x86F40 VA: 0x180087B40
	[NativeNameAttribute] // RVA: 0x87B40 Offset: 0x86F40 VA: 0x180087B40
	private GlyphMetrics m_Metrics; // 0x14
	[SerializeField] // RVA: 0x87E20 Offset: 0x87220 VA: 0x180087E20
	[NativeNameAttribute] // RVA: 0x87E20 Offset: 0x87220 VA: 0x180087E20
	private GlyphRect m_GlyphRect; // 0x28
	[NativeNameAttribute] // RVA: 0x88150 Offset: 0x87550 VA: 0x180088150
	[SerializeField] // RVA: 0x88150 Offset: 0x87550 VA: 0x180088150
	private float m_Scale; // 0x38
	[NativeNameAttribute] // RVA: 0x88200 Offset: 0x87600 VA: 0x180088200
	[SerializeField] // RVA: 0x88200 Offset: 0x87600 VA: 0x180088200
	private int m_AtlasIndex; // 0x3C

	// Properties
	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x1816DA0 Offset: 0x18153A0 VA: 0x181816DA0
	public uint get_index() { }

	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	public void set_index(uint value) { }

	// RVA: 0x22F1520 Offset: 0x22EFB20 VA: 0x1822F1520
	public GlyphMetrics get_metrics() { }

	// RVA: 0x22F18B0 Offset: 0x22EFEB0 VA: 0x1822F18B0
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x1A63160 Offset: 0x1A61760 VA: 0x181A63160
	public GlyphRect get_glyphRect() { }

	// RVA: 0x10872F0 Offset: 0x10858F0 VA: 0x1810872F0
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x22EF060 Offset: 0x22ED660 VA: 0x1822EF060
	public float get_scale() { }

	// RVA: 0x10B8BF0 Offset: 0x10B71F0 VA: 0x1810B8BF0
	public void set_scale(float value) { }

	// RVA: 0x22F18A0 Offset: 0x22EFEA0 VA: 0x1822F18A0
	public int get_atlasIndex() { }

	// RVA: 0x8C1690 Offset: 0x8BFC90 VA: 0x1808C1690
	public void set_atlasIndex(int value) { }

	// RVA: 0x22F17D0 Offset: 0x22EFDD0 VA: 0x1822F17D0
	public void .ctor() { }

	// RVA: 0x22F1810 Offset: 0x22EFE10 VA: 0x1822F1810
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F1760 Offset: 0x22EFD60 VA: 0x1822F1760
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

}

