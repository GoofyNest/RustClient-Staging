public sealed class SystemInfo // TypeDefIndex: 3556
{	public static BatteryStatus batteryStatus { get; }
	public static string operatingSystem { get; }
	public static OperatingSystemFamily operatingSystemFamily { get; }
	public static string processorType { get; }
	public static int processorFrequency { get; }
	public static int processorCount { get; }
	public static int systemMemorySize { get; }
	public static string deviceUniqueIdentifier { get; }
	public static string deviceName { get; }
	public static string deviceModel { get; }
	public static DeviceType deviceType { get; }
	public static int graphicsMemorySize { get; }
	public static string graphicsDeviceName { get; }
	public static string graphicsDeviceVendor { get; }
	public static GraphicsDeviceType graphicsDeviceType { get; }
	public static bool graphicsUVStartsAtTop { get; }
	public static string graphicsDeviceVersion { get; }
	public static int graphicsShaderLevel { get; }
	public static bool graphicsMultiThreaded { get; }
	[ObsoleteAttribute] // RVA: 0xCD5F0 Offset: 0xCC9F0 VA: 0x1800CD5F0
	public static bool supportsRenderTextures { get; }
	public static bool supportsMotionVectors { get; }
	[ObsoleteAttribute] // RVA: 0xCD6E0 Offset: 0xCCAE0 VA: 0x1800CD6E0
	public static bool supportsImageEffects { get; }
	public static bool supports3DTextures { get; }
	public static bool supports3DRenderTextures { get; }
	public static CopyTextureSupport copyTextureSupport { get; }
	public static bool supportsComputeShaders { get; }
	public static bool supportsInstancing { get; }
	public static int supportedRenderTargetCount { get; }
	public static int supportedRandomWriteTargetCount { get; }
	public static bool usesReversedZBuffer { get; }
	public static bool supportsAsyncGPUReadback { get; }
	public static bool supportsMipStreaming { get; }


	public static BatteryStatus get_batteryStatus() { }

	public static string get_operatingSystem() { }

	public static OperatingSystemFamily get_operatingSystemFamily() { }

	public static string get_processorType() { }

	public static int get_processorFrequency() { }

	public static int get_processorCount() { }

	public static int get_systemMemorySize() { }

	public static string get_deviceUniqueIdentifier() { }

	public static string get_deviceName() { }

	public static string get_deviceModel() { }

	public static DeviceType get_deviceType() { }

	public static int get_graphicsMemorySize() { }

	public static string get_graphicsDeviceName() { }

	public static string get_graphicsDeviceVendor() { }

	public static GraphicsDeviceType get_graphicsDeviceType() { }

	public static bool get_graphicsUVStartsAtTop() { }

	public static string get_graphicsDeviceVersion() { }

	public static int get_graphicsShaderLevel() { }

	public static bool get_graphicsMultiThreaded() { }

	public static bool get_supportsRenderTextures() { }

	public static bool get_supportsMotionVectors() { }

	public static bool get_supportsImageEffects() { }

	public static bool get_supports3DTextures() { }

	public static bool get_supports3DRenderTextures() { }

	public static CopyTextureSupport get_copyTextureSupport() { }

	public static bool get_supportsComputeShaders() { }

	public static bool get_supportsInstancing() { }

	public static int get_supportedRenderTargetCount() { }

	public static int get_supportedRandomWriteTargetCount() { }

	public static bool get_usesReversedZBuffer() { }

	private static bool IsValidEnumValue(Enum value) { }

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	public static bool SupportsTextureFormat(TextureFormat format) { }

	public static bool get_supportsAsyncGPUReadback() { }

	public static bool get_supportsMipStreaming() { }

	[FreeFunctionAttribute] // RVA: 0xCAD20 Offset: 0xCA120 VA: 0x1800CAD20
	private static BatteryStatus GetBatteryStatus() { }

	[FreeFunctionAttribute] // RVA: 0xCADA0 Offset: 0xCA1A0 VA: 0x1800CADA0
	private static string GetOperatingSystem() { }

	[FreeFunctionAttribute] // RVA: 0xCAF60 Offset: 0xCA360 VA: 0x1800CAF60
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunctionAttribute] // RVA: 0xCB040 Offset: 0xCA440 VA: 0x1800CB040
	private static string GetProcessorType() { }

	[FreeFunctionAttribute] // RVA: 0xCB100 Offset: 0xCA500 VA: 0x1800CB100
	private static int GetProcessorFrequencyMHz() { }

	[FreeFunctionAttribute] // RVA: 0xCB150 Offset: 0xCA550 VA: 0x1800CB150
	private static int GetProcessorCount() { }

	[FreeFunctionAttribute] // RVA: 0xCB1F0 Offset: 0xCA5F0 VA: 0x1800CB1F0
	private static int GetPhysicalMemoryMB() { }

	[FreeFunctionAttribute] // RVA: 0xCB240 Offset: 0xCA640 VA: 0x1800CB240
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunctionAttribute] // RVA: 0xCB380 Offset: 0xCA780 VA: 0x1800CB380
	private static string GetDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCB460 Offset: 0xCA860 VA: 0x1800CB460
	private static string GetDeviceModel() { }

	[FreeFunctionAttribute] // RVA: 0xCB530 Offset: 0xCA930 VA: 0x1800CB530
	private static DeviceType GetDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCB640 Offset: 0xCAA40 VA: 0x1800CB640
	private static int GetGraphicsMemorySize() { }

	[FreeFunctionAttribute] // RVA: 0xCB7E0 Offset: 0xCABE0 VA: 0x1800CB7E0
	private static string GetGraphicsDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCBAD0 Offset: 0xCAED0 VA: 0x1800CBAD0
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunctionAttribute] // RVA: 0xCBCC0 Offset: 0xCB0C0 VA: 0x1800CBCC0
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCBE50 Offset: 0xCB250 VA: 0x1800CBE50
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunctionAttribute] // RVA: 0xCBF50 Offset: 0xCB350 VA: 0x1800CBF50
	private static string GetGraphicsDeviceVersion() { }

	[FreeFunctionAttribute] // RVA: 0xCBFF0 Offset: 0xCB3F0 VA: 0x1800CBFF0
	private static int GetGraphicsShaderLevel() { }

	[FreeFunctionAttribute] // RVA: 0xCC0C0 Offset: 0xCB4C0 VA: 0x1800CC0C0
	private static bool GetGraphicsMultiThreaded() { }

	[FreeFunctionAttribute] // RVA: 0xCC2E0 Offset: 0xCB6E0 VA: 0x1800CC2E0
	private static bool SupportsMotionVectors() { }

	[FreeFunctionAttribute] // RVA: 0xCC3A0 Offset: 0xCB7A0 VA: 0x1800CC3A0
	private static bool Supports3DTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC510 Offset: 0xCB910 VA: 0x1800CC510
	private static bool Supports3DRenderTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC650 Offset: 0xCBA50 VA: 0x1800CC650
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunctionAttribute] // RVA: 0xCC8A0 Offset: 0xCBCA0 VA: 0x1800CC8A0
	private static bool SupportsComputeShaders() { }

	[FreeFunctionAttribute] // RVA: 0xCC9C0 Offset: 0xCBDC0 VA: 0x1800CC9C0
	private static bool SupportsInstancing() { }

	[FreeFunctionAttribute] // RVA: 0xCCB50 Offset: 0xCBF50 VA: 0x1800CCB50
	private static int SupportedRenderTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCCD00 Offset: 0xCC100 VA: 0x1800CCD00
	private static int SupportedRandomWriteTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCCE30 Offset: 0xCC230 VA: 0x1800CCE30
	private static bool UsesReversedZBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xCCF40 Offset: 0xCC340 VA: 0x1800CCF40
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCCFA0 Offset: 0xCC3A0 VA: 0x1800CCFA0
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCD0E0 Offset: 0xCC4E0 VA: 0x1800CD0E0
	private static bool SupportsAsyncGPUReadback() { }

	[FreeFunctionAttribute] // RVA: 0xCD160 Offset: 0xCC560 VA: 0x1800CD160
	private static bool SupportsMipStreaming() { }

	[FreeFunctionAttribute] // RVA: 0xCD340 Offset: 0xCC740 VA: 0x1800CD340
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD3B0 Offset: 0xCC7B0 VA: 0x1800CD3B0
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD4F0 Offset: 0xCC8F0 VA: 0x1800CD4F0
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

}

