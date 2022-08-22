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

	// RVA: 0x18296A0 Offset: 0x1827CA0 VA: 0x1818296A0
	public uint get_index() { }

	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_index(uint value) { }

	// RVA: 0x22F0A40 Offset: 0x22EF040 VA: 0x1822F0A40
	public GlyphMetrics get_metrics() { }

	// RVA: 0x22F0DD0 Offset: 0x22EF3D0 VA: 0x1822F0DD0
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x1A76970 Offset: 0x1A74F70 VA: 0x181A76970
	public GlyphRect get_glyphRect() { }

	// RVA: 0x10865C0 Offset: 0x1084BC0 VA: 0x1810865C0
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x22EE580 Offset: 0x22ECB80 VA: 0x1822EE580
	public float get_scale() { }

	// RVA: 0x10B7EC0 Offset: 0x10B64C0 VA: 0x1810B7EC0
	public void set_scale(float value) { }

	// RVA: 0x22F0DC0 Offset: 0x22EF3C0 VA: 0x1822F0DC0
	public int get_atlasIndex() { }

	// RVA: 0x8C1070 Offset: 0x8BF670 VA: 0x1808C1070
	public void set_atlasIndex(int value) { }

	// RVA: 0x22F0CF0 Offset: 0x22EF2F0 VA: 0x1822F0CF0
	public void .ctor() { }

	// RVA: 0x22F0D30 Offset: 0x22EF330 VA: 0x1822F0D30
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F0C80 Offset: 0x22EF280 VA: 0x1822F0C80
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

}

