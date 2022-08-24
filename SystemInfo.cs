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
	[ObsoleteAttribute] // RVA: 0xCD6C0 Offset: 0xCCAC0 VA: 0x1800CD6C0
	public static bool supportsRenderTextures { get; }
	public static bool supportsMotionVectors { get; }
	[ObsoleteAttribute] // RVA: 0xCD7C0 Offset: 0xCCBC0 VA: 0x1800CD7C0
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

	[FreeFunctionAttribute] // RVA: 0xCADD0 Offset: 0xCA1D0 VA: 0x1800CADD0
	private static string GetOperatingSystem() { }

	[FreeFunctionAttribute] // RVA: 0xCAEF0 Offset: 0xCA2F0 VA: 0x1800CAEF0
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunctionAttribute] // RVA: 0xCAF90 Offset: 0xCA390 VA: 0x1800CAF90
	private static string GetProcessorType() { }

	[FreeFunctionAttribute] // RVA: 0xCB030 Offset: 0xCA430 VA: 0x1800CB030
	private static int GetProcessorFrequencyMHz() { }

	[FreeFunctionAttribute] // RVA: 0xCB0B0 Offset: 0xCA4B0 VA: 0x1800CB0B0
	private static int GetProcessorCount() { }

	[FreeFunctionAttribute] // RVA: 0xCB1B0 Offset: 0xCA5B0 VA: 0x1800CB1B0
	private static int GetPhysicalMemoryMB() { }

	[FreeFunctionAttribute] // RVA: 0xCB260 Offset: 0xCA660 VA: 0x1800CB260
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunctionAttribute] // RVA: 0xCB3C0 Offset: 0xCA7C0 VA: 0x1800CB3C0
	private static string GetDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCB4F0 Offset: 0xCA8F0 VA: 0x1800CB4F0
	private static string GetDeviceModel() { }

	[FreeFunctionAttribute] // RVA: 0xCB5F0 Offset: 0xCA9F0 VA: 0x1800CB5F0
	private static DeviceType GetDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCB700 Offset: 0xCAB00 VA: 0x1800CB700
	private static int GetGraphicsMemorySize() { }

	[FreeFunctionAttribute] // RVA: 0xCB900 Offset: 0xCAD00 VA: 0x1800CB900
	private static string GetGraphicsDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCBB90 Offset: 0xCAF90 VA: 0x1800CBB90
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunctionAttribute] // RVA: 0xCBD50 Offset: 0xCB150 VA: 0x1800CBD50
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCBF10 Offset: 0xCB310 VA: 0x1800CBF10
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunctionAttribute] // RVA: 0xCC040 Offset: 0xCB440 VA: 0x1800CC040
	private static string GetGraphicsDeviceVersion() { }

	[FreeFunctionAttribute] // RVA: 0xCC110 Offset: 0xCB510 VA: 0x1800CC110
	private static int GetGraphicsShaderLevel() { }

	[FreeFunctionAttribute] // RVA: 0xCC1D0 Offset: 0xCB5D0 VA: 0x1800CC1D0
	private static bool GetGraphicsMultiThreaded() { }

	[FreeFunctionAttribute] // RVA: 0xCC380 Offset: 0xCB780 VA: 0x1800CC380
	private static bool SupportsMotionVectors() { }

	[FreeFunctionAttribute] // RVA: 0xCC480 Offset: 0xCB880 VA: 0x1800CC480
	private static bool Supports3DTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC5C0 Offset: 0xCB9C0 VA: 0x1800CC5C0
	private static bool Supports3DRenderTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC680 Offset: 0xCBA80 VA: 0x1800CC680
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunctionAttribute] // RVA: 0xCC8D0 Offset: 0xCBCD0 VA: 0x1800CC8D0
	private static bool SupportsComputeShaders() { }

	[FreeFunctionAttribute] // RVA: 0xCC9E0 Offset: 0xCBDE0 VA: 0x1800CC9E0
	private static bool SupportsInstancing() { }

	[FreeFunctionAttribute] // RVA: 0xCCB70 Offset: 0xCBF70 VA: 0x1800CCB70
	private static int SupportedRenderTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCCD00 Offset: 0xCC100 VA: 0x1800CCD00
	private static int SupportedRandomWriteTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCCDF0 Offset: 0xCC1F0 VA: 0x1800CCDF0
	private static bool UsesReversedZBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xCCF50 Offset: 0xCC350 VA: 0x1800CCF50
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCD000 Offset: 0xCC400 VA: 0x1800CD000
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCD120 Offset: 0xCC520 VA: 0x1800CD120
	private static bool SupportsAsyncGPUReadback() { }

	[FreeFunctionAttribute] // RVA: 0xCD180 Offset: 0xCC580 VA: 0x1800CD180
	private static bool SupportsMipStreaming() { }

	[FreeFunctionAttribute] // RVA: 0xCD3C0 Offset: 0xCC7C0 VA: 0x1800CD3C0
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD480 Offset: 0xCC880 VA: 0x1800CD480
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD5C0 Offset: 0xCC9C0 VA: 0x1800CD5C0
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

}

