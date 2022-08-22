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

	// RVA: 0x19B2CA0 Offset: 0x19B12A0 VA: 0x1819B2CA0 Slot: 5
	public override int get_width() { }

	// RVA: 0x19B2FB0 Offset: 0x19B15B0 VA: 0x1819B2FB0 Slot: 6
	public override void set_width(int value) { }

	// RVA: 0x19B2BE0 Offset: 0x19B11E0 VA: 0x1819B2BE0 Slot: 7
	public override int get_height() { }

	// RVA: 0x19B2EE0 Offset: 0x19B14E0 VA: 0x1819B2EE0 Slot: 8
	public override void set_height(int value) { }

	// RVA: 0x19B2AE0 Offset: 0x19B10E0 VA: 0x1819B2AE0 Slot: 9
	public override TextureDimension get_dimension() { }

	// RVA: 0x19B2E10 Offset: 0x19B1410 VA: 0x1819B2E10 Slot: 10
	public override void set_dimension(TextureDimension value) { }

	// RVA: 0x19B2BA0 Offset: 0x19B11A0 VA: 0x1819B2BA0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19B2EA0 Offset: 0x19B14A0 VA: 0x1819B2EA0
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x19B2F20 Offset: 0x19B1520 VA: 0x1819B2F20
	public void set_useMipMap(bool value) { }

	// RVA: 0x19B2C20 Offset: 0x19B1220 VA: 0x1819B2C20
	public bool get_sRGB() { }

	// RVA: 0x19B2B60 Offset: 0x19B1160 VA: 0x1819B2B60
	public RenderTextureFormat get_format() { }

	// RVA: 0x19B2CE0 Offset: 0x19B12E0 VA: 0x1819B2CE0
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x19B2C60 Offset: 0x19B1260 VA: 0x1819B2C60
	public int get_volumeDepth() { }

	// RVA: 0x19B2F70 Offset: 0x19B1570 VA: 0x1819B2F70
	public void set_volumeDepth(int value) { }

	// RVA: 0x19B2B20 Offset: 0x19B1120 VA: 0x1819B2B20
	public bool get_enableRandomWrite() { }

	// RVA: 0x19B2E50 Offset: 0x19B1450 VA: 0x1819B2E50
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void set_isPowerOfTwo(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xA3400 Offset: 0xA2800 VA: 0x1800A3400
	// RVA: 0x19B1250 Offset: 0x19AF850 VA: 0x1819B1250
	private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] // RVA: 0xA3480 Offset: 0xA2880 VA: 0x1800A3480
	// RVA: 0x19B1B30 Offset: 0x19B0130 VA: 0x1819B1B30
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x19B1250 Offset: 0x19AF850 VA: 0x1819B1250
	public static RenderTexture get_active() { }

	// RVA: 0x19B1B30 Offset: 0x19B0130 VA: 0x1819B1B30
	public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] // RVA: 0xA3500 Offset: 0xA2900 VA: 0x1800A3500
	// RVA: 0x19B12D0 Offset: 0x19AF8D0 VA: 0x1819B12D0
	private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xA35A0 Offset: 0xA29A0 VA: 0x1800A35A0
	// RVA: 0x19B14D0 Offset: 0x19AFAD0 VA: 0x1819B14D0
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x19B2950 Offset: 0x19B0F50 VA: 0x1819B2950
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x19B29B0 Offset: 0x19B0FB0 VA: 0x1819B29B0
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x19B11F0 Offset: 0x19AF7F0 VA: 0x1819B11F0
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x19B1A70 Offset: 0x19B0070 VA: 0x1819B1A70
	public void MarkRestoreExpected() { }

	// RVA: 0x19B11B0 Offset: 0x19AF7B0 VA: 0x1819B11B0
	public void DiscardContents() { }

	// RVA: 0x19B1170 Offset: 0x19AF770 VA: 0x1819B1170
	public bool Create() { }

	// RVA: 0x19B1AF0 Offset: 0x19B00F0 VA: 0x1819B1AF0
	public void Release() { }

	// RVA: 0x19B1A30 Offset: 0x19B0030 VA: 0x1819B1A30
	public bool IsCreated() { }

	// RVA: 0x19B1C10 Offset: 0x19B0210 VA: 0x1819B1C10
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunctionAttribute] // RVA: 0xA3640 Offset: 0xA2A40 VA: 0x1800A3640
	// RVA: 0x19B19F0 Offset: 0x19AFFF0 VA: 0x1819B19F0
	private static void Internal_Create(RenderTexture rt) { }

	[NativeNameAttribute] // RVA: 0xA37B0 Offset: 0xA2BB0 VA: 0x1800A37B0
	// RVA: 0x19B1BC0 Offset: 0x19B01C0 VA: 0x1819B1BC0
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] // RVA: 0xA3810 Offset: 0xA2C10 VA: 0x1800A3810
	// RVA: 0x19B1570 Offset: 0x19AFB70 VA: 0x1819B1570
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] // RVA: 0xA38F0 Offset: 0xA2CF0 VA: 0x1800A38F0
	// RVA: 0x19B17A0 Offset: 0x19AFDA0 VA: 0x1819B17A0
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0xA3990 Offset: 0xA2D90 VA: 0x1800A3990
	// RVA: 0x19B1AB0 Offset: 0x19B00B0 VA: 0x1819B1AB0
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] // RVA: 0xA39F0 Offset: 0xA2DF0 VA: 0x1800A39F0
	// RVA: 0x19B2A10 Offset: 0x19B1010 VA: 0x1819B2A10
	public int get_depth() { }

	[FreeFunctionAttribute] // RVA: 0xA3B20 Offset: 0xA2F20 VA: 0x1800A3B20
	// RVA: 0x19B2D30 Offset: 0x19B1330 VA: 0x1819B2D30
	public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B28C0 Offset: 0x19B0EC0 VA: 0x1819B28C0
	protected internal void .ctor() { }

	// RVA: 0x19B2780 Offset: 0x19B0D80 VA: 0x1819B2780
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x19B2230 Offset: 0x19B0830 VA: 0x1819B2230
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x19B2690 Offset: 0x19B0C90 VA: 0x1819B2690
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x19B2460 Offset: 0x19B0A60 VA: 0x1819B2460
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x19B1F10 Offset: 0x19B0510 VA: 0x1819B1F10
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x19B21D0 Offset: 0x19B07D0 VA: 0x1819B21D0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B1EB0 Offset: 0x19B04B0 VA: 0x1819B1EB0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B2630 Offset: 0x19B0C30 VA: 0x1819B2630
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B2710 Offset: 0x19B0D10 VA: 0x1819B2710
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x19B2A50 Offset: 0x19B1050 VA: 0x1819B2A50
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x19B2D70 Offset: 0x19B1370 VA: 0x1819B2D70
	public void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0x19B1C60 Offset: 0x19B0260 VA: 0x1819B1C60
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x19B1320 Offset: 0x19AF920 VA: 0x1819B1320
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x19B1960 Offset: 0x19AFF60 VA: 0x1819B1960
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x19B15D0 Offset: 0x19AFBD0 VA: 0x1819B15D0
	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B1890 Offset: 0x19AFE90 VA: 0x1819B1890
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B1900 Offset: 0x19AFF00 VA: 0x1819B1900
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B1830 Offset: 0x19AFE30 VA: 0x1819B1830
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B17E0 Offset: 0x19AFDE0 VA: 0x1819B17E0
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x19B1280 Offset: 0x19AF880 VA: 0x1819B1280
	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x19B1480 Offset: 0x19AFA80 VA: 0x1819B1480
	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x19B1B70 Offset: 0x19B0170 VA: 0x1819B1B70
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x19B1520 Offset: 0x19AFB20 VA: 0x1819B1520
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x19B1760 Offset: 0x19AFD60 VA: 0x1819B1760
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

}

