public class Glyph // TypeDefIndex: 4112
{	[NativeNameAttribute] // RVA: 0x86700 Offset: 0x85B00 VA: 0x180086700
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

