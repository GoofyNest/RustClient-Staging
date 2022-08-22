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

	// RVA: 0x1829960 Offset: 0x1827F60 VA: 0x181829960
	public uint get_index() { }

	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_index(uint value) { }

	// RVA: 0x22F0D00 Offset: 0x22EF300 VA: 0x1822F0D00
	public GlyphMetrics get_metrics() { }

	// RVA: 0x22F1090 Offset: 0x22EF690 VA: 0x1822F1090
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x1A76C30 Offset: 0x1A75230 VA: 0x181A76C30
	public GlyphRect get_glyphRect() { }

	// RVA: 0x1086880 Offset: 0x1084E80 VA: 0x181086880
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x22EE840 Offset: 0x22ECE40 VA: 0x1822EE840
	public float get_scale() { }

	// RVA: 0x10B8180 Offset: 0x10B6780 VA: 0x1810B8180
	public void set_scale(float value) { }

	// RVA: 0x22F1080 Offset: 0x22EF680 VA: 0x1822F1080
	public int get_atlasIndex() { }

	// RVA: 0x8C1180 Offset: 0x8BF780 VA: 0x1808C1180
	public void set_atlasIndex(int value) { }

	// RVA: 0x22F0FB0 Offset: 0x22EF5B0 VA: 0x1822F0FB0
	public void .ctor() { }

	// RVA: 0x22F0FF0 Offset: 0x22EF5F0 VA: 0x1822F0FF0
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F0F40 Offset: 0x22EF540 VA: 0x1822F0F40
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

}

