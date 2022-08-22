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

	// RVA: 0x19B29E0 Offset: 0x19B0FE0 VA: 0x1819B29E0 Slot: 5
	public override int get_width() { }

	// RVA: 0x19B2CF0 Offset: 0x19B12F0 VA: 0x1819B2CF0 Slot: 6
	public override void set_width(int value) { }

	// RVA: 0x19B2920 Offset: 0x19B0F20 VA: 0x1819B2920 Slot: 7
	public override int get_height() { }

	// RVA: 0x19B2C20 Offset: 0x19B1220 VA: 0x1819B2C20 Slot: 8
	public override void set_height(int value) { }

	// RVA: 0x19B2820 Offset: 0x19B0E20 VA: 0x1819B2820 Slot: 9
	public override TextureDimension get_dimension() { }

	// RVA: 0x19B2B50 Offset: 0x19B1150 VA: 0x1819B2B50 Slot: 10
	public override void set_dimension(TextureDimension value) { }

	// RVA: 0x19B28E0 Offset: 0x19B0EE0 VA: 0x1819B28E0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19B2BE0 Offset: 0x19B11E0 VA: 0x1819B2BE0
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x19B2C60 Offset: 0x19B1260 VA: 0x1819B2C60
	public void set_useMipMap(bool value) { }

	// RVA: 0x19B2960 Offset: 0x19B0F60 VA: 0x1819B2960
	public bool get_sRGB() { }

	// RVA: 0x19B28A0 Offset: 0x19B0EA0 VA: 0x1819B28A0
	public RenderTextureFormat get_format() { }

	// RVA: 0x19B2A20 Offset: 0x19B1020 VA: 0x1819B2A20
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x19B29A0 Offset: 0x19B0FA0 VA: 0x1819B29A0
	public int get_volumeDepth() { }

	// RVA: 0x19B2CB0 Offset: 0x19B12B0 VA: 0x1819B2CB0
	public void set_volumeDepth(int value) { }

	// RVA: 0x19B2860 Offset: 0x19B0E60 VA: 0x1819B2860
	public bool get_enableRandomWrite() { }

	// RVA: 0x19B2B90 Offset: 0x19B1190 VA: 0x1819B2B90
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void set_isPowerOfTwo(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xA3400 Offset: 0xA2800 VA: 0x1800A3400
	// RVA: 0x19B0F90 Offset: 0x19AF590 VA: 0x1819B0F90
	private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] // RVA: 0xA3480 Offset: 0xA2880 VA: 0x1800A3480
	// RVA: 0x19B1870 Offset: 0x19AFE70 VA: 0x1819B1870
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x19B0F90 Offset: 0x19AF590 VA: 0x1819B0F90
	public static RenderTexture get_active() { }

	// RVA: 0x19B1870 Offset: 0x19AFE70 VA: 0x1819B1870
	public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] // RVA: 0xA3500 Offset: 0xA2900 VA: 0x1800A3500
	// RVA: 0x19B1010 Offset: 0x19AF610 VA: 0x1819B1010
	private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xA35A0 Offset: 0xA29A0 VA: 0x1800A35A0
	// RVA: 0x19B1210 Offset: 0x19AF810 VA: 0x1819B1210
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x19B2690 Offset: 0x19B0C90 VA: 0x1819B2690
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x19B26F0 Offset: 0x19B0CF0 VA: 0x1819B26F0
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x19B0F30 Offset: 0x19AF530 VA: 0x1819B0F30
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x19B17B0 Offset: 0x19AFDB0 VA: 0x1819B17B0
	public void MarkRestoreExpected() { }

	// RVA: 0x19B0EF0 Offset: 0x19AF4F0 VA: 0x1819B0EF0
	public void DiscardContents() { }

	// RVA: 0x19B0EB0 Offset: 0x19AF4B0 VA: 0x1819B0EB0
	public bool Create() { }

	// RVA: 0x19B1830 Offset: 0x19AFE30 VA: 0x1819B1830
	public void Release() { }

	// RVA: 0x19B1770 Offset: 0x19AFD70 VA: 0x1819B1770
	public bool IsCreated() { }

	// RVA: 0x19B1950 Offset: 0x19AFF50 VA: 0x1819B1950
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunctionAttribute] // RVA: 0xA3640 Offset: 0xA2A40 VA: 0x1800A3640
	// RVA: 0x19B1730 Offset: 0x19AFD30 VA: 0x1819B1730
	private static void Internal_Create(RenderTexture rt) { }

	[NativeNameAttribute] // RVA: 0xA37B0 Offset: 0xA2BB0 VA: 0x1800A37B0
	// RVA: 0x19B1900 Offset: 0x19AFF00 VA: 0x1819B1900
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] // RVA: 0xA3810 Offset: 0xA2C10 VA: 0x1800A3810
	// RVA: 0x19B12B0 Offset: 0x19AF8B0 VA: 0x1819B12B0
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] // RVA: 0xA38F0 Offset: 0xA2CF0 VA: 0x1800A38F0
	// RVA: 0x19B14E0 Offset: 0x19AFAE0 VA: 0x1819B14E0
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0xA3990 Offset: 0xA2D90 VA: 0x1800A3990
	// RVA: 0x19B17F0 Offset: 0x19AFDF0 VA: 0x1819B17F0
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] // RVA: 0xA39F0 Offset: 0xA2DF0 VA: 0x1800A39F0
	// RVA: 0x19B2750 Offset: 0x19B0D50 VA: 0x1819B2750
	public int get_depth() { }

	[FreeFunctionAttribute] // RVA: 0xA3B20 Offset: 0xA2F20 VA: 0x1800A3B20
	// RVA: 0x19B2A70 Offset: 0x19B1070 VA: 0x1819B2A70
	public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B2600 Offset: 0x19B0C00 VA: 0x1819B2600
	protected internal void .ctor() { }

	// RVA: 0x19B24C0 Offset: 0x19B0AC0 VA: 0x1819B24C0
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x19B1F70 Offset: 0x19B0570 VA: 0x1819B1F70
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x19B23D0 Offset: 0x19B09D0 VA: 0x1819B23D0
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x19B21A0 Offset: 0x19B07A0 VA: 0x1819B21A0
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x19B1C50 Offset: 0x19B0250 VA: 0x1819B1C50
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x19B1F10 Offset: 0x19B0510 VA: 0x1819B1F10
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B1BF0 Offset: 0x19B01F0 VA: 0x1819B1BF0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B2370 Offset: 0x19B0970 VA: 0x1819B2370
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B2450 Offset: 0x19B0A50 VA: 0x1819B2450
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x19B2790 Offset: 0x19B0D90 VA: 0x1819B2790
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x19B2AB0 Offset: 0x19B10B0 VA: 0x1819B2AB0
	public void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0x19B19A0 Offset: 0x19AFFA0 VA: 0x1819B19A0
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x19B1060 Offset: 0x19AF660 VA: 0x1819B1060
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x19B16A0 Offset: 0x19AFCA0 VA: 0x1819B16A0
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x19B1310 Offset: 0x19AF910 VA: 0x1819B1310
	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B15D0 Offset: 0x19AFBD0 VA: 0x1819B15D0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B1640 Offset: 0x19AFC40 VA: 0x1819B1640
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B1570 Offset: 0x19AFB70 VA: 0x1819B1570
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B1520 Offset: 0x19AFB20 VA: 0x1819B1520
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x19B0FC0 Offset: 0x19AF5C0 VA: 0x1819B0FC0
	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x19B11C0 Offset: 0x19AF7C0 VA: 0x1819B11C0
	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x19B18B0 Offset: 0x19AFEB0 VA: 0x1819B18B0
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x19B1260 Offset: 0x19AF860 VA: 0x1819B1260
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x19B14A0 Offset: 0x19AFAA0 VA: 0x1819B14A0
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

}

