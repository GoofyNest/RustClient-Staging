public struct RenderTextureDescriptor // TypeDefIndex: 3451
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private int <width>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private int <height>k__BackingField; // 0x4
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private int <msaaSamples>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private int <volumeDepth>k__BackingField; // 0xC
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	private int _depthBufferBits; // 0x1C
	private static int[] depthFormatBits; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private TextureDimension <dimension>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B860 Offset: 0x14AC60 VA: 0x18014B860
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19DFE0 Offset: 0x19D3E0 VA: 0x18019DFE0
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public int get_msaaSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19DFD0 Offset: 0x19D3D0 VA: 0x18019DFD0
	public void set_msaaSamples(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1AE4B0 Offset: 0x1AD8B0 VA: 0x1801AE4B0
	public int get_volumeDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2228F0 Offset: 0x221CF0 VA: 0x1802228F0
	public void set_volumeDepth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1204E0 Offset: 0x11F8E0 VA: 0x1801204E0
	public void set_mipCount(int value) { }

	// RVA: 0x212380 Offset: 0x211780 VA: 0x180212380
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x222800 Offset: 0x221C00 VA: 0x180222800
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x2226A0 Offset: 0x221AA0 VA: 0x1802226A0
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x222710 Offset: 0x221B10 VA: 0x180222710
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x2226D0 Offset: 0x221AD0 VA: 0x1802226D0
	public bool get_sRGB() { }

	// RVA: 0x222840 Offset: 0x221C40 VA: 0x180222840
	public void set_sRGB(bool value) { }

	// RVA: 0x2226B0 Offset: 0x221AB0 VA: 0x1802226B0
	public int get_depthBufferBits() { }

	// RVA: 0x2227C0 Offset: 0x221BC0 VA: 0x1802227C0
	public void set_depthBufferBits(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x12C240 Offset: 0x12B640 VA: 0x18012C240
	public TextureDimension get_dimension() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1EF140 Offset: 0x1EE540 VA: 0x1801EF140
	public void set_dimension(TextureDimension value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1E4CA0 Offset: 0x1E40A0 VA: 0x1801E4CA0
	public ShadowSamplingMode get_shadowSamplingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2228A0 Offset: 0x221CA0 VA: 0x1802228A0
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F50 Offset: 0xF3350 VA: 0x1800F3F50
	public VRTextureUsage get_vrUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F80 Offset: 0xF3380 VA: 0x1800F3F80
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D10C0 Offset: 0x1D04C0 VA: 0x1801D10C0
	public RenderTextureMemoryless get_memoryless() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8720 Offset: 0x1D7B20 VA: 0x1801D8720
	public void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x222560 Offset: 0x221960 VA: 0x180222560
	public void .ctor(int width, int height) { }

	// RVA: 0x2224D0 Offset: 0x2218D0 VA: 0x1802224D0
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x222680 Offset: 0x221A80 VA: 0x180222680
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x2224C0 Offset: 0x2218C0 VA: 0x1802224C0
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	// RVA: 0x2224A0 Offset: 0x2218A0 VA: 0x1802224A0
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x2226E0 Offset: 0x221AE0 VA: 0x1802226E0
	public bool get_useMipMap() { }

	// RVA: 0x2228D0 Offset: 0x221CD0 VA: 0x1802228D0
	public void set_useMipMap(bool value) { }

	// RVA: 0x222690 Offset: 0x221A90 VA: 0x180222690
	public bool get_autoGenerateMips() { }

	// RVA: 0x2226F0 Offset: 0x221AF0 VA: 0x1802226F0
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x2226C0 Offset: 0x221AC0 VA: 0x1802226C0
	public bool get_enableRandomWrite() { }

	// RVA: 0x2227E0 Offset: 0x221BE0 VA: 0x1802227E0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x2227A0 Offset: 0x221BA0 VA: 0x1802227A0
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x2228B0 Offset: 0x221CB0 VA: 0x1802228B0
	public void set_useDynamicScale(bool value) { }

	// RVA: 0x19B0920 Offset: 0x19AEF20 VA: 0x1819B0920
	private static void .cctor() { }

}

