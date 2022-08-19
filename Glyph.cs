public class Glyph // TypeDefIndex: 4112
{	// Fields
	[NativeNameAttribute] // RVA: 0x86600 Offset: 0x85A00 VA: 0x180086600
	[SerializeField] // RVA: 0x86600 Offset: 0x85A00 VA: 0x180086600
	private uint m_Index; // 0x10
	[SerializeField] // RVA: 0x87B10 Offset: 0x86F10 VA: 0x180087B10
	[NativeNameAttribute] // RVA: 0x87B10 Offset: 0x86F10 VA: 0x180087B10
	private GlyphMetrics m_Metrics; // 0x14
	[SerializeField] // RVA: 0x87DB0 Offset: 0x871B0 VA: 0x180087DB0
	[NativeNameAttribute] // RVA: 0x87DB0 Offset: 0x871B0 VA: 0x180087DB0
	private GlyphRect m_GlyphRect; // 0x28
	[NativeNameAttribute] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	[SerializeField] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	private float m_Scale; // 0x38
	[NativeNameAttribute] // RVA: 0x88190 Offset: 0x87590 VA: 0x180088190
	[SerializeField] // RVA: 0x88190 Offset: 0x87590 VA: 0x180088190
	private int m_AtlasIndex; // 0x3C

	// Properties
	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x18296E0 Offset: 0x1827CE0 VA: 0x1818296E0
	public uint get_index() { }

	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_index(uint value) { }

	// RVA: 0x22F0C00 Offset: 0x22EF200 VA: 0x1822F0C00
	public GlyphMetrics get_metrics() { }

	// RVA: 0x22F0F90 Offset: 0x22EF590 VA: 0x1822F0F90
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x1A769B0 Offset: 0x1A74FB0 VA: 0x181A769B0
	public GlyphRect get_glyphRect() { }

	// RVA: 0x10865C0 Offset: 0x1084BC0 VA: 0x1810865C0
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x22EE740 Offset: 0x22ECD40 VA: 0x1822EE740
	public float get_scale() { }

	// RVA: 0x10B7EC0 Offset: 0x10B64C0 VA: 0x1810B7EC0
	public void set_scale(float value) { }

	// RVA: 0x22F0F80 Offset: 0x22EF580 VA: 0x1822F0F80
	public int get_atlasIndex() { }

	// RVA: 0x8C1070 Offset: 0x8BF670 VA: 0x1808C1070
	public void set_atlasIndex(int value) { }

	// RVA: 0x22F0EB0 Offset: 0x22EF4B0 VA: 0x1822F0EB0
	public void .ctor() { }

	// RVA: 0x22F0EF0 Offset: 0x22EF4F0 VA: 0x1822F0EF0
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22F0E40 Offset: 0x22EF440 VA: 0x1822F0E40
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

}

