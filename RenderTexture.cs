public class RenderTexture : Texture // TypeDefIndex: 3450
{	public override int width { get; set; }
	public override int height { get; set; }
	public override TextureDimension dimension { get; set; }
	[NativePropertyAttribute] // RVA: 0xA47A0 Offset: 0xA3BA0 VA: 0x1800A47A0
	public GraphicsFormat graphicsFormat { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4910 Offset: 0xA3D10 VA: 0x1800A4910
	public bool useMipMap { set; }
	[NativePropertyAttribute] // RVA: 0xA49D0 Offset: 0xA3DD0 VA: 0x1800A49D0
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


	public override int get_width() { }

	public override void set_width(int value) { }

	public override int get_height() { }

	public override void set_height(int value) { }

	public override TextureDimension get_dimension() { }

	public override void set_dimension(TextureDimension value) { }

	public GraphicsFormat get_graphicsFormat() { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public void set_useMipMap(bool value) { }

	public bool get_sRGB() { }

	public RenderTextureFormat get_format() { }

	public void set_autoGenerateMips(bool value) { }

	public int get_volumeDepth() { }

	public void set_volumeDepth(int value) { }

	public bool get_enableRandomWrite() { }

	public void set_enableRandomWrite(bool value) { }

	public void set_isPowerOfTwo(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xA3430 Offset: 0xA2830 VA: 0x1800A3430
	private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] // RVA: 0xA34B0 Offset: 0xA28B0 VA: 0x1800A34B0
	private static void SetActive(RenderTexture rt) { }

	public static RenderTexture get_active() { }

	public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] // RVA: 0xA3530 Offset: 0xA2930 VA: 0x1800A3530
	private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xA35D0 Offset: 0xA29D0 VA: 0x1800A35D0
	private RenderBuffer GetDepthBuffer() { }

	public RenderBuffer get_colorBuffer() { }

	public RenderBuffer get_depthBuffer() { }

	public void DiscardContents(bool discardColor, bool discardDepth) { }

	public void MarkRestoreExpected() { }

	public void DiscardContents() { }

	public bool Create() { }

	public void Release() { }

	public bool IsCreated() { }

	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunctionAttribute] // RVA: 0xA36B0 Offset: 0xA2AB0 VA: 0x1800A36B0
	private static void Internal_Create(RenderTexture rt) { }

	[NativeNameAttribute] // RVA: 0xA3870 Offset: 0xA2C70 VA: 0x1800A3870
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] // RVA: 0xA3940 Offset: 0xA2D40 VA: 0x1800A3940
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] // RVA: 0xA3AC0 Offset: 0xA2EC0 VA: 0x1800A3AC0
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0xA3BC0 Offset: 0xA2FC0 VA: 0x1800A3BC0
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] // RVA: 0xA3C80 Offset: 0xA3080 VA: 0x1800A3C80
	public int get_depth() { }

	[FreeFunctionAttribute] // RVA: 0xA3D70 Offset: 0xA3170 VA: 0x1800A3D70
	public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected internal void .ctor() { }

	public void .ctor(RenderTextureDescriptor desc) { }

	public void .ctor(RenderTexture textureToCopy) { }

	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	public RenderTextureDescriptor get_descriptor() { }

	public void set_descriptor(RenderTextureDescriptor value) { }

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static RenderTexture GetTemporary(int width, int height) { }

	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

}

