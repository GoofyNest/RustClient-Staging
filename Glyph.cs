public class Glyph // TypeDefIndex: 4112
{	[NativeNameAttribute] // RVA: 0x867C0 Offset: 0x85BC0 VA: 0x1800867C0
	[SerializeField] // RVA: 0x867C0 Offset: 0x85BC0 VA: 0x1800867C0
	private uint m_Index; // 0x10
	[SerializeField] // RVA: 0x87C00 Offset: 0x87000 VA: 0x180087C00
	[NativeNameAttribute] // RVA: 0x87C00 Offset: 0x87000 VA: 0x180087C00
	private GlyphMetrics m_Metrics; // 0x14
	[SerializeField] // RVA: 0x87EB0 Offset: 0x872B0 VA: 0x180087EB0
	[NativeNameAttribute] // RVA: 0x87EB0 Offset: 0x872B0 VA: 0x180087EB0
	private GlyphRect m_GlyphRect; // 0x28
	[NativeNameAttribute] // RVA: 0x881E0 Offset: 0x875E0 VA: 0x1800881E0
	[SerializeField] // RVA: 0x881E0 Offset: 0x875E0 VA: 0x1800881E0
	private float m_Scale; // 0x38
	[NativeNameAttribute] // RVA: 0x88260 Offset: 0x87660 VA: 0x180088260
	[SerializeField] // RVA: 0x88260 Offset: 0x87660 VA: 0x180088260
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

