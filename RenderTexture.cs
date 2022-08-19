public class RenderTexture : Texture // TypeDefIndex: 3450
{	// Properties
	public override int width { get; set; }
	public override int height { get; set; }
	public override TextureDimension dimension { get; set; }
	[NativePropertyAttribute] // RVA: 0xA45F0 Offset: 0xA39F0 VA: 0x1800A45F0
	public GraphicsFormat graphicsFormat { get; set; }
	[NativePropertyAttribute] // RVA: 0xA47D0 Offset: 0xA3BD0 VA: 0x1800A47D0
	public bool useMipMap { set; }
	[NativePropertyAttribute] // RVA: 0xA4890 Offset: 0xA3C90 VA: 0x1800A4890
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

	// RVA: 0x19B2A20 Offset: 0x19B1020 VA: 0x1819B2A20 Slot: 5
	public override int get_width() { }

	// RVA: 0x19B2D30 Offset: 0x19B1330 VA: 0x1819B2D30 Slot: 6
	public override void set_width(int value) { }

	// RVA: 0x19B2960 Offset: 0x19B0F60 VA: 0x1819B2960 Slot: 7
	public override int get_height() { }

	// RVA: 0x19B2C60 Offset: 0x19B1260 VA: 0x1819B2C60 Slot: 8
	public override void set_height(int value) { }

	// RVA: 0x19B2860 Offset: 0x19B0E60 VA: 0x1819B2860 Slot: 9
	public override TextureDimension get_dimension() { }

	// RVA: 0x19B2B90 Offset: 0x19B1190 VA: 0x1819B2B90 Slot: 10
	public override void set_dimension(TextureDimension value) { }

	// RVA: 0x19B2920 Offset: 0x19B0F20 VA: 0x1819B2920
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19B2C20 Offset: 0x19B1220 VA: 0x1819B2C20
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x19B2CA0 Offset: 0x19B12A0 VA: 0x1819B2CA0
	public void set_useMipMap(bool value) { }

	// RVA: 0x19B29A0 Offset: 0x19B0FA0 VA: 0x1819B29A0
	public bool get_sRGB() { }

	// RVA: 0x19B28E0 Offset: 0x19B0EE0 VA: 0x1819B28E0
	public RenderTextureFormat get_format() { }

	// RVA: 0x19B2A60 Offset: 0x19B1060 VA: 0x1819B2A60
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x19B29E0 Offset: 0x19B0FE0 VA: 0x1819B29E0
	public int get_volumeDepth() { }

	// RVA: 0x19B2CF0 Offset: 0x19B12F0 VA: 0x1819B2CF0
	public void set_volumeDepth(int value) { }

	// RVA: 0x19B28A0 Offset: 0x19B0EA0 VA: 0x1819B28A0
	public bool get_enableRandomWrite() { }

	// RVA: 0x19B2BD0 Offset: 0x19B11D0 VA: 0x1819B2BD0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void set_isPowerOfTwo(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xA3370 Offset: 0xA2770 VA: 0x1800A3370
	// RVA: 0x19B0FD0 Offset: 0x19AF5D0 VA: 0x1819B0FD0
	private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] // RVA: 0xA33F0 Offset: 0xA27F0 VA: 0x1800A33F0
	// RVA: 0x19B18B0 Offset: 0x19AFEB0 VA: 0x1819B18B0
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x19B0FD0 Offset: 0x19AF5D0 VA: 0x1819B0FD0
	public static RenderTexture get_active() { }

	// RVA: 0x19B18B0 Offset: 0x19AFEB0 VA: 0x1819B18B0
	public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] // RVA: 0xA3470 Offset: 0xA2870 VA: 0x1800A3470
	// RVA: 0x19B1050 Offset: 0x19AF650 VA: 0x1819B1050
	private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xA3510 Offset: 0xA2910 VA: 0x1800A3510
	// RVA: 0x19B1250 Offset: 0x19AF850 VA: 0x1819B1250
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x19B26D0 Offset: 0x19B0CD0 VA: 0x1819B26D0
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x19B2730 Offset: 0x19B0D30 VA: 0x1819B2730
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x19B0F70 Offset: 0x19AF570 VA: 0x1819B0F70
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x19B17F0 Offset: 0x19AFDF0 VA: 0x1819B17F0
	public void MarkRestoreExpected() { }

	// RVA: 0x19B0F30 Offset: 0x19AF530 VA: 0x1819B0F30
	public void DiscardContents() { }

	// RVA: 0x19B0EF0 Offset: 0x19AF4F0 VA: 0x1819B0EF0
	public bool Create() { }

	// RVA: 0x19B1870 Offset: 0x19AFE70 VA: 0x1819B1870
	public void Release() { }

	// RVA: 0x19B17B0 Offset: 0x19AFDB0 VA: 0x1819B17B0
	public bool IsCreated() { }

	// RVA: 0x19B1990 Offset: 0x19AFF90 VA: 0x1819B1990
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunctionAttribute] // RVA: 0xA35B0 Offset: 0xA29B0 VA: 0x1800A35B0
	// RVA: 0x19B1770 Offset: 0x19AFD70 VA: 0x1819B1770
	private static void Internal_Create(RenderTexture rt) { }

	[NativeNameAttribute] // RVA: 0xA36D0 Offset: 0xA2AD0 VA: 0x1800A36D0
	// RVA: 0x19B1940 Offset: 0x19AFF40 VA: 0x1819B1940
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] // RVA: 0xA3780 Offset: 0xA2B80 VA: 0x1800A3780
	// RVA: 0x19B12F0 Offset: 0x19AF8F0 VA: 0x1819B12F0
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] // RVA: 0xA3860 Offset: 0xA2C60 VA: 0x1800A3860
	// RVA: 0x19B1520 Offset: 0x19AFB20 VA: 0x1819B1520
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0xA38B0 Offset: 0xA2CB0 VA: 0x1800A38B0
	// RVA: 0x19B1830 Offset: 0x19AFE30 VA: 0x1819B1830
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] // RVA: 0xA3960 Offset: 0xA2D60 VA: 0x1800A3960
	// RVA: 0x19B2790 Offset: 0x19B0D90 VA: 0x1819B2790
	public int get_depth() { }

	[FreeFunctionAttribute] // RVA: 0xA3A90 Offset: 0xA2E90 VA: 0x1800A3A90
	// RVA: 0x19B2AB0 Offset: 0x19B10B0 VA: 0x1819B2AB0
	public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B2640 Offset: 0x19B0C40 VA: 0x1819B2640
	protected internal void .ctor() { }

	// RVA: 0x19B2500 Offset: 0x19B0B00 VA: 0x1819B2500
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x19B1FB0 Offset: 0x19B05B0 VA: 0x1819B1FB0
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x19B2410 Offset: 0x19B0A10 VA: 0x1819B2410
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x19B21E0 Offset: 0x19B07E0 VA: 0x1819B21E0
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x19B1C90 Offset: 0x19B0290 VA: 0x1819B1C90
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x19B1F50 Offset: 0x19B0550 VA: 0x1819B1F50
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B1C30 Offset: 0x19B0230 VA: 0x1819B1C30
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B23B0 Offset: 0x19B09B0 VA: 0x1819B23B0
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B2490 Offset: 0x19B0A90 VA: 0x1819B2490
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x19B27D0 Offset: 0x19B0DD0 VA: 0x1819B27D0
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x19B2AF0 Offset: 0x19B10F0 VA: 0x1819B2AF0
	public void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0x19B19E0 Offset: 0x19AFFE0 VA: 0x1819B19E0
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x19B10A0 Offset: 0x19AF6A0 VA: 0x1819B10A0
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x19B16E0 Offset: 0x19AFCE0 VA: 0x1819B16E0
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x19B1350 Offset: 0x19AF950 VA: 0x1819B1350
	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B1610 Offset: 0x19AFC10 VA: 0x1819B1610
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B1680 Offset: 0x19AFC80 VA: 0x1819B1680
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B15B0 Offset: 0x19AFBB0 VA: 0x1819B15B0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B1560 Offset: 0x19AFB60 VA: 0x1819B1560
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x19B1000 Offset: 0x19AF600 VA: 0x1819B1000
	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x19B1200 Offset: 0x19AF800 VA: 0x1819B1200
	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x19B18F0 Offset: 0x19AFEF0 VA: 0x1819B18F0
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x19B12A0 Offset: 0x19AF8A0 VA: 0x1819B12A0
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x19B14E0 Offset: 0x19AFAE0 VA: 0x1819B14E0
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

}

