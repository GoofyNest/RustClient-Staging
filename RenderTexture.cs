public class RenderTexture : Texture // TypeDefIndex: 3450
{	// Properties
	public override int width { get; set; }
	public override int height { get; set; }
	public override TextureDimension dimension { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4680 Offset: 0xA3A80 VA: 0x1800A4680
	public GraphicsFormat graphicsFormat { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4860 Offset: 0xA3C60 VA: 0x1800A4860
	public bool useMipMap { set; }
	[NativePropertyAttribute] // RVA: 0xA4920 Offset: 0xA3D20 VA: 0x1800A4920
	public bool sRGB { get; }
	public RenderTextureFormat format { get; }
	public bool autoGenerateMips { set; }
	public int volumeDepth { get; set; }
	public bool enableRandomWrite { get; set; }
	public bool isPowerOfTwo { set; }
	public static RenderTexture active { get; set; }
	public RenderBuffer colorBuffer { get; }
	public RenderBuffer depthBuffer { get; }
	public int depth { get; set; }
	public RenderTextureDescriptor descriptor { get; set; }

	// Methods

	// RVA: 0x19A00A0 Offset: 0x199E6A0 VA: 0x1819A00A0 Slot: 5
	public override int get_width() { }

	// RVA: 0x19A03B0 Offset: 0x199E9B0 VA: 0x1819A03B0 Slot: 6
	public override void set_width(int value) { }

	// RVA: 0x199FFE0 Offset: 0x199E5E0 VA: 0x18199FFE0 Slot: 7
	public override int get_height() { }

	// RVA: 0x19A02E0 Offset: 0x199E8E0 VA: 0x1819A02E0 Slot: 8
	public override void set_height(int value) { }

	// RVA: 0x199FEE0 Offset: 0x199E4E0 VA: 0x18199FEE0 Slot: 9
	public override TextureDimension get_dimension() { }

	// RVA: 0x19A0210 Offset: 0x199E810 VA: 0x1819A0210 Slot: 10
	public override void set_dimension(TextureDimension value) { }

	// RVA: 0x199FFA0 Offset: 0x199E5A0 VA: 0x18199FFA0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19A02A0 Offset: 0x199E8A0 VA: 0x1819A02A0
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x19A0320 Offset: 0x199E920 VA: 0x1819A0320
	public void set_useMipMap(bool value) { }

	// RVA: 0x19A0020 Offset: 0x199E620 VA: 0x1819A0020
	public bool get_sRGB() { }

	// RVA: 0x199FF60 Offset: 0x199E560 VA: 0x18199FF60
	public RenderTextureFormat get_format() { }

	// RVA: 0x19A00E0 Offset: 0x199E6E0 VA: 0x1819A00E0
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x19A0060 Offset: 0x199E660 VA: 0x1819A0060
	public int get_volumeDepth() { }

	// RVA: 0x19A0370 Offset: 0x199E970 VA: 0x1819A0370
	public void set_volumeDepth(int value) { }

	// RVA: 0x199FF20 Offset: 0x199E520 VA: 0x18199FF20
	public bool get_enableRandomWrite() { }

	// RVA: 0x19A0250 Offset: 0x199E850 VA: 0x1819A0250
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void set_isPowerOfTwo(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xA3400 Offset: 0xA2800 VA: 0x1800A3400
	// RVA: 0x199E650 Offset: 0x199CC50 VA: 0x18199E650
	private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] // RVA: 0xA3480 Offset: 0xA2880 VA: 0x1800A3480
	// RVA: 0x199EF30 Offset: 0x199D530 VA: 0x18199EF30
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x199E650 Offset: 0x199CC50 VA: 0x18199E650
	public static RenderTexture get_active() { }

	// RVA: 0x199EF30 Offset: 0x199D530 VA: 0x18199EF30
	public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] // RVA: 0xA3500 Offset: 0xA2900 VA: 0x1800A3500
	// RVA: 0x199E6D0 Offset: 0x199CCD0 VA: 0x18199E6D0
	private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xA35A0 Offset: 0xA29A0 VA: 0x1800A35A0
	// RVA: 0x199E8D0 Offset: 0x199CED0 VA: 0x18199E8D0
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x199FD50 Offset: 0x199E350 VA: 0x18199FD50
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x199FDB0 Offset: 0x199E3B0 VA: 0x18199FDB0
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x199E5F0 Offset: 0x199CBF0 VA: 0x18199E5F0
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x199EE70 Offset: 0x199D470 VA: 0x18199EE70
	public void MarkRestoreExpected() { }

	// RVA: 0x199E5B0 Offset: 0x199CBB0 VA: 0x18199E5B0
	public void DiscardContents() { }

	// RVA: 0x199E570 Offset: 0x199CB70 VA: 0x18199E570
	public bool Create() { }

	// RVA: 0x199EEF0 Offset: 0x199D4F0 VA: 0x18199EEF0
	public void Release() { }

	// RVA: 0x199EE30 Offset: 0x199D430 VA: 0x18199EE30
	public bool IsCreated() { }

	// RVA: 0x199F010 Offset: 0x199D610 VA: 0x18199F010
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunctionAttribute] // RVA: 0xA3640 Offset: 0xA2A40 VA: 0x1800A3640
	// RVA: 0x199EDF0 Offset: 0x199D3F0 VA: 0x18199EDF0
	private static void Internal_Create(RenderTexture rt) { }

	[NativeNameAttribute] // RVA: 0xA37B0 Offset: 0xA2BB0 VA: 0x1800A37B0
	// RVA: 0x199EFC0 Offset: 0x199D5C0 VA: 0x18199EFC0
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] // RVA: 0xA3810 Offset: 0xA2C10 VA: 0x1800A3810
	// RVA: 0x199E970 Offset: 0x199CF70 VA: 0x18199E970
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] // RVA: 0xA38F0 Offset: 0xA2CF0 VA: 0x1800A38F0
	// RVA: 0x199EBA0 Offset: 0x199D1A0 VA: 0x18199EBA0
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0xA3990 Offset: 0xA2D90 VA: 0x1800A3990
	// RVA: 0x199EEB0 Offset: 0x199D4B0 VA: 0x18199EEB0
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] // RVA: 0xA39F0 Offset: 0xA2DF0 VA: 0x1800A39F0
	// RVA: 0x199FE10 Offset: 0x199E410 VA: 0x18199FE10
	public int get_depth() { }

	[FreeFunctionAttribute] // RVA: 0xA3B20 Offset: 0xA2F20 VA: 0x1800A3B20
	// RVA: 0x19A0130 Offset: 0x199E730 VA: 0x1819A0130
	public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199FCC0 Offset: 0x199E2C0 VA: 0x18199FCC0
	protected internal void .ctor() { }

	// RVA: 0x199FB80 Offset: 0x199E180 VA: 0x18199FB80
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x199F630 Offset: 0x199DC30 VA: 0x18199F630
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x199FA90 Offset: 0x199E090 VA: 0x18199FA90
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x199F860 Offset: 0x199DE60 VA: 0x18199F860
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x199F310 Offset: 0x199D910 VA: 0x18199F310
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x199F5D0 Offset: 0x199DBD0 VA: 0x18199F5D0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199F2B0 Offset: 0x199D8B0 VA: 0x18199F2B0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199FA30 Offset: 0x199E030 VA: 0x18199FA30
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199FB10 Offset: 0x199E110 VA: 0x18199FB10
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x199FE50 Offset: 0x199E450 VA: 0x18199FE50
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x19A0170 Offset: 0x199E770 VA: 0x1819A0170
	public void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0x199F060 Offset: 0x199D660 VA: 0x18199F060
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x199E720 Offset: 0x199CD20 VA: 0x18199E720
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x199ED60 Offset: 0x199D360 VA: 0x18199ED60
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x199E9D0 Offset: 0x199CFD0 VA: 0x18199E9D0
	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199EC90 Offset: 0x199D290 VA: 0x18199EC90
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199ED00 Offset: 0x199D300 VA: 0x18199ED00
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199EC30 Offset: 0x199D230 VA: 0x18199EC30
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199EBE0 Offset: 0x199D1E0 VA: 0x18199EBE0
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x199E680 Offset: 0x199CC80 VA: 0x18199E680
	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x199E880 Offset: 0x199CE80 VA: 0x18199E880
	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x199EF70 Offset: 0x199D570 VA: 0x18199EF70
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x199E920 Offset: 0x199CF20 VA: 0x18199E920
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x199EB60 Offset: 0x199D160 VA: 0x18199EB60
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

}

