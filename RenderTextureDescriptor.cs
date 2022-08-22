public struct RenderTextureDescriptor // TypeDefIndex: 3451
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private int <width>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <height>k__BackingField; // 0x4
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <msaaSamples>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private int <volumeDepth>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	private int _depthBufferBits; // 0x1C
	private static int[] depthFormatBits; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private TextureDimension <dimension>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x30

	// Properties
	public int width { get; set; }
	public int height { get; set; }
	public int msaaSamples { get; set; }
	public int volumeDepth { get; set; }
	public int mipCount { set; }
	public GraphicsFormat graphicsFormat { get; set; }
	public RenderTextureFormat colorFormat { get; set; }
	public bool sRGB { get; set; }
	public int depthBufferBits { get; set; }
	public TextureDimension dimension { get; set; }
	public ShadowSamplingMode shadowSamplingMode { get; set; }
	public VRTextureUsage vrUsage { get; set; }
	public RenderTextureMemoryless memoryless { get; set; }
	public bool useMipMap { get; set; }
	public bool autoGenerateMips { get; set; }
	public bool enableRandomWrite { get; set; }
	internal bool createdFromScript { set; }
	public bool useDynamicScale { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B600 Offset: 0x14AA00 VA: 0x18014B600
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DC50 Offset: 0x19D050 VA: 0x18019DC50
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	public int get_msaaSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DC40 Offset: 0x19D040 VA: 0x18019DC40
	public void set_msaaSamples(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1AE130 Offset: 0x1AD530 VA: 0x1801AE130
	public int get_volumeDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21DDF0 Offset: 0x21D1F0 VA: 0x18021DDF0
	public void set_volumeDepth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x120460 Offset: 0x11F860 VA: 0x180120460
	public void set_mipCount(int value) { }

	// RVA: 0x211730 Offset: 0x210B30 VA: 0x180211730
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x21DD00 Offset: 0x21D100 VA: 0x18021DD00
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x21DBA0 Offset: 0x21CFA0 VA: 0x18021DBA0
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x21DC10 Offset: 0x21D010 VA: 0x18021DC10
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x21DBD0 Offset: 0x21CFD0 VA: 0x18021DBD0
	public bool get_sRGB() { }

	// RVA: 0x21DD40 Offset: 0x21D140 VA: 0x18021DD40
	public void set_sRGB(bool value) { }

	// RVA: 0x21DBB0 Offset: 0x21CFB0 VA: 0x18021DBB0
	public int get_depthBufferBits() { }

	// RVA: 0x21DCC0 Offset: 0x21D0C0 VA: 0x18021DCC0
	public void set_depthBufferBits(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12BFE0 Offset: 0x12B3E0 VA: 0x18012BFE0
	public TextureDimension get_dimension() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1EF4E0 Offset: 0x1EE8E0 VA: 0x1801EF4E0
	public void set_dimension(TextureDimension value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1E5040 Offset: 0x1E4440 VA: 0x1801E5040
	public ShadowSamplingMode get_shadowSamplingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21DDA0 Offset: 0x21D1A0 VA: 0x18021DDA0
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3ED0 Offset: 0xF32D0 VA: 0x1800F3ED0
	public VRTextureUsage get_vrUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3F00 Offset: 0xF3300 VA: 0x1800F3F00
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D16B0 Offset: 0x1D0AB0 VA: 0x1801D16B0
	public RenderTextureMemoryless get_memoryless() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8D10 Offset: 0x1D8110 VA: 0x1801D8D10
	public void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x21DA60 Offset: 0x21CE60 VA: 0x18021DA60
	public void .ctor(int width, int height) { }

	// RVA: 0x21D9D0 Offset: 0x21CDD0 VA: 0x18021D9D0
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x21DB80 Offset: 0x21CF80 VA: 0x18021DB80
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x21D9C0 Offset: 0x21CDC0 VA: 0x18021D9C0
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	// RVA: 0x21D9A0 Offset: 0x21CDA0 VA: 0x18021D9A0
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x21DBE0 Offset: 0x21CFE0 VA: 0x18021DBE0
	public bool get_useMipMap() { }

	// RVA: 0x21DDD0 Offset: 0x21D1D0 VA: 0x18021DDD0
	public void set_useMipMap(bool value) { }

	// RVA: 0x21DB90 Offset: 0x21CF90 VA: 0x18021DB90
	public bool get_autoGenerateMips() { }

	// RVA: 0x21DBF0 Offset: 0x21CFF0 VA: 0x18021DBF0
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x21DBC0 Offset: 0x21CFC0 VA: 0x18021DBC0
	public bool get_enableRandomWrite() { }

	// RVA: 0x21DCE0 Offset: 0x21D0E0 VA: 0x18021DCE0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x21DCA0 Offset: 0x21D0A0 VA: 0x18021DCA0
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x21DDB0 Offset: 0x21D1B0 VA: 0x18021DDB0
	public void set_useDynamicScale(bool value) { }

	// RVA: 0x199DFA0 Offset: 0x199C5A0 VA: 0x18199DFA0
	private static void .cctor() { }

}

