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
	// RVA: 0x14B7E0 Offset: 0x14ABE0 VA: 0x18014B7E0
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DF60 Offset: 0x19D360 VA: 0x18019DF60
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10
	public int get_msaaSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DF50 Offset: 0x19D350 VA: 0x18019DF50
	public void set_msaaSamples(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1AE430 Offset: 0x1AD830 VA: 0x1801AE430
	public int get_volumeDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x222870 Offset: 0x221C70 VA: 0x180222870
	public void set_volumeDepth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x120460 Offset: 0x11F860 VA: 0x180120460
	public void set_mipCount(int value) { }

	// RVA: 0x212300 Offset: 0x211700 VA: 0x180212300
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x222780 Offset: 0x221B80 VA: 0x180222780
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x222620 Offset: 0x221A20 VA: 0x180222620
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x222690 Offset: 0x221A90 VA: 0x180222690
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x222650 Offset: 0x221A50 VA: 0x180222650
	public bool get_sRGB() { }

	// RVA: 0x2227C0 Offset: 0x221BC0 VA: 0x1802227C0
	public void set_sRGB(bool value) { }

	// RVA: 0x222630 Offset: 0x221A30 VA: 0x180222630
	public int get_depthBufferBits() { }

	// RVA: 0x222740 Offset: 0x221B40 VA: 0x180222740
	public void set_depthBufferBits(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12C1C0 Offset: 0x12B5C0 VA: 0x18012C1C0
	public TextureDimension get_dimension() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1EF0C0 Offset: 0x1EE4C0 VA: 0x1801EF0C0
	public void set_dimension(TextureDimension value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1E4C20 Offset: 0x1E4020 VA: 0x1801E4C20
	public ShadowSamplingMode get_shadowSamplingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x222820 Offset: 0x221C20 VA: 0x180222820
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3ED0 Offset: 0xF32D0 VA: 0x1800F3ED0
	public VRTextureUsage get_vrUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3F00 Offset: 0xF3300 VA: 0x1800F3F00
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D1040 Offset: 0x1D0440 VA: 0x1801D1040
	public RenderTextureMemoryless get_memoryless() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D86A0 Offset: 0x1D7AA0 VA: 0x1801D86A0
	public void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x2224E0 Offset: 0x2218E0 VA: 0x1802224E0
	public void .ctor(int width, int height) { }

	// RVA: 0x222450 Offset: 0x221850 VA: 0x180222450
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x222600 Offset: 0x221A00 VA: 0x180222600
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x222440 Offset: 0x221840 VA: 0x180222440
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	// RVA: 0x222420 Offset: 0x221820 VA: 0x180222420
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x222660 Offset: 0x221A60 VA: 0x180222660
	public bool get_useMipMap() { }

	// RVA: 0x222850 Offset: 0x221C50 VA: 0x180222850
	public void set_useMipMap(bool value) { }

	// RVA: 0x222610 Offset: 0x221A10 VA: 0x180222610
	public bool get_autoGenerateMips() { }

	// RVA: 0x222670 Offset: 0x221A70 VA: 0x180222670
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x222640 Offset: 0x221A40 VA: 0x180222640
	public bool get_enableRandomWrite() { }

	// RVA: 0x222760 Offset: 0x221B60 VA: 0x180222760
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x222720 Offset: 0x221B20 VA: 0x180222720
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x222830 Offset: 0x221C30 VA: 0x180222830
	public void set_useDynamicScale(bool value) { }

	// RVA: 0x19B0BA0 Offset: 0x19AF1A0 VA: 0x1819B0BA0
	private static void .cctor() { }

}

