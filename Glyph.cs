public class Glyph // TypeDefIndex: 4112
{	[NativeNameAttribute] // RVA: 0x867D0 Offset: 0x85BD0 VA: 0x1800867D0
	[SerializeField] // RVA: 0x867D0 Offset: 0x85BD0 VA: 0x1800867D0
	private uint m_Index; // 0x10
	[SerializeField] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	[NativeNameAttribute] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	private GlyphMetrics m_Metrics; // 0x14
	[SerializeField] // RVA: 0x87EF0 Offset: 0x872F0 VA: 0x180087EF0
	[NativeNameAttribute] // RVA: 0x87EF0 Offset: 0x872F0 VA: 0x180087EF0
	private GlyphRect m_GlyphRect; // 0x28
	[NativeNameAttribute] // RVA: 0x88260 Offset: 0x87660 VA: 0x180088260
	[SerializeField] // RVA: 0x88260 Offset: 0x87660 VA: 0x180088260
	private float m_Scale; // 0x38
	[NativeNameAttribute] // RVA: 0x88320 Offset: 0x87720 VA: 0x180088320
	[SerializeField] // RVA: 0x88320 Offset: 0x87720 VA: 0x180088320
	private int m_AtlasIndex; // 0x3C

	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }


	public uint get_index() { }

	public void set_index(uint value) { }

	public GlyphMetrics get_metrics() { }

	public void set_metrics(GlyphMetrics value) { }

	public GlyphRect get_glyphRect() { }

	public void set_glyphRect(GlyphRect value) { }

	public float get_scale() { }

	public void set_scale(float value) { }

	public int get_atlasIndex() { }

	public void set_atlasIndex(int value) { }

	public void .ctor() { }

	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

}

