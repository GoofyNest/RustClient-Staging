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
	[ObsoleteAttribute] // RVA: 0xCD510 Offset: 0xCC910 VA: 0x1800CD510
	public static bool supportsRenderTextures { get; }
	public static bool supportsMotionVectors { get; }
	[ObsoleteAttribute] // RVA: 0xCD640 Offset: 0xCCA40 VA: 0x1800CD640
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

	[FreeFunctionAttribute] // RVA: 0xCAC90 Offset: 0xCA090 VA: 0x1800CAC90
	private static BatteryStatus GetBatteryStatus() { }

	[FreeFunctionAttribute] // RVA: 0xCAD50 Offset: 0xCA150 VA: 0x1800CAD50
	private static string GetOperatingSystem() { }

	[FreeFunctionAttribute] // RVA: 0xCAEC0 Offset: 0xCA2C0 VA: 0x1800CAEC0
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunctionAttribute] // RVA: 0xCAF60 Offset: 0xCA360 VA: 0x1800CAF60
	private static string GetProcessorType() { }

	[FreeFunctionAttribute] // RVA: 0xCAFD0 Offset: 0xCA3D0 VA: 0x1800CAFD0
	private static int GetProcessorFrequencyMHz() { }

	[FreeFunctionAttribute] // RVA: 0xCB020 Offset: 0xCA420 VA: 0x1800CB020
	private static int GetProcessorCount() { }

	[FreeFunctionAttribute] // RVA: 0xCB0C0 Offset: 0xCA4C0 VA: 0x1800CB0C0
	private static int GetPhysicalMemoryMB() { }

	[FreeFunctionAttribute] // RVA: 0xCB140 Offset: 0xCA540 VA: 0x1800CB140
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunctionAttribute] // RVA: 0xCB250 Offset: 0xCA650 VA: 0x1800CB250
	private static string GetDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCB360 Offset: 0xCA760 VA: 0x1800CB360
	private static string GetDeviceModel() { }

	[FreeFunctionAttribute] // RVA: 0xCB460 Offset: 0xCA860 VA: 0x1800CB460
	private static DeviceType GetDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCB5A0 Offset: 0xCA9A0 VA: 0x1800CB5A0
	private static int GetGraphicsMemorySize() { }

	[FreeFunctionAttribute] // RVA: 0xCB770 Offset: 0xCAB70 VA: 0x1800CB770
	private static string GetGraphicsDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCBA50 Offset: 0xCAE50 VA: 0x1800CBA50
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunctionAttribute] // RVA: 0xCBC30 Offset: 0xCB030 VA: 0x1800CBC30
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCBD70 Offset: 0xCB170 VA: 0x1800CBD70
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunctionAttribute] // RVA: 0xCBE50 Offset: 0xCB250 VA: 0x1800CBE50
	private static string GetGraphicsDeviceVersion() { }

	[FreeFunctionAttribute] // RVA: 0xCBF30 Offset: 0xCB330 VA: 0x1800CBF30
	private static int GetGraphicsShaderLevel() { }

	[FreeFunctionAttribute] // RVA: 0xCC020 Offset: 0xCB420 VA: 0x1800CC020
	private static bool GetGraphicsMultiThreaded() { }

	[FreeFunctionAttribute] // RVA: 0xCC1E0 Offset: 0xCB5E0 VA: 0x1800CC1E0
	private static bool SupportsMotionVectors() { }

	[FreeFunctionAttribute] // RVA: 0xCC320 Offset: 0xCB720 VA: 0x1800CC320
	private static bool Supports3DTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC4B0 Offset: 0xCB8B0 VA: 0x1800CC4B0
	private static bool Supports3DRenderTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC5D0 Offset: 0xCB9D0 VA: 0x1800CC5D0
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunctionAttribute] // RVA: 0xCC7F0 Offset: 0xCBBF0 VA: 0x1800CC7F0
	private static bool SupportsComputeShaders() { }

	[FreeFunctionAttribute] // RVA: 0xCC8D0 Offset: 0xCBCD0 VA: 0x1800CC8D0
	private static bool SupportsInstancing() { }

	[FreeFunctionAttribute] // RVA: 0xCCA60 Offset: 0xCBE60 VA: 0x1800CCA60
	private static int SupportedRenderTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCCC10 Offset: 0xCC010 VA: 0x1800CCC10
	private static int SupportedRandomWriteTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCCD00 Offset: 0xCC100 VA: 0x1800CCD00
	private static bool UsesReversedZBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xCCE90 Offset: 0xCC290 VA: 0x1800CCE90
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCCF40 Offset: 0xCC340 VA: 0x1800CCF40
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCD000 Offset: 0xCC400 VA: 0x1800CD000
	private static bool SupportsAsyncGPUReadback() { }

	[FreeFunctionAttribute] // RVA: 0xCD050 Offset: 0xCC450 VA: 0x1800CD050
	private static bool SupportsMipStreaming() { }

	[FreeFunctionAttribute] // RVA: 0xCD210 Offset: 0xCC610 VA: 0x1800CD210
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD2D0 Offset: 0xCC6D0 VA: 0x1800CD2D0
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD460 Offset: 0xCC860 VA: 0x1800CD460
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

}

