public sealed class SystemInfo // TypeDefIndex: 3556
{	// Properties
	public static BatteryStatus batteryStatus { get; }
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

	// Methods

	// RVA: 0x19B9D80 Offset: 0x19B8380 VA: 0x1819B9D80
	public static BatteryStatus get_batteryStatus() { }

	// RVA: 0x19BA0D0 Offset: 0x19B86D0 VA: 0x1819BA0D0
	public static string get_operatingSystem() { }

	// RVA: 0x19BA0A0 Offset: 0x19B86A0 VA: 0x1819BA0A0
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x19BA190 Offset: 0x19B8790 VA: 0x1819BA190
	public static string get_processorType() { }

	// RVA: 0x19BA160 Offset: 0x19B8760 VA: 0x1819BA160
	public static int get_processorFrequency() { }

	// RVA: 0x19BA130 Offset: 0x19B8730 VA: 0x1819BA130
	public static int get_processorCount() { }

	// RVA: 0x19BA100 Offset: 0x19B8700 VA: 0x1819BA100
	public static int get_systemMemorySize() { }

	// RVA: 0x19B9EB0 Offset: 0x19B84B0 VA: 0x1819B9EB0
	public static string get_deviceUniqueIdentifier() { }

	// RVA: 0x19B9E50 Offset: 0x19B8450 VA: 0x1819B9E50
	public static string get_deviceName() { }

	// RVA: 0x19B9E20 Offset: 0x19B8420 VA: 0x1819B9E20
	public static string get_deviceModel() { }

	// RVA: 0x19B9E80 Offset: 0x19B8480 VA: 0x1819B9E80
	public static DeviceType get_deviceType() { }

	// RVA: 0x19B9FE0 Offset: 0x19B85E0 VA: 0x1819B9FE0
	public static int get_graphicsMemorySize() { }

	// RVA: 0x19B9EE0 Offset: 0x19B84E0 VA: 0x1819B9EE0
	public static string get_graphicsDeviceName() { }

	// RVA: 0x19B9F40 Offset: 0x19B8540 VA: 0x1819B9F40
	public static string get_graphicsDeviceVendor() { }

	// RVA: 0x19B9F10 Offset: 0x19B8510 VA: 0x1819B9F10
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	// RVA: 0x19BA070 Offset: 0x19B8670 VA: 0x1819BA070
	public static bool get_graphicsUVStartsAtTop() { }

	// RVA: 0x19B9F70 Offset: 0x19B8570 VA: 0x1819B9F70
	public static string get_graphicsDeviceVersion() { }

	// RVA: 0x19BA040 Offset: 0x19B8640 VA: 0x1819BA040
	public static int get_graphicsShaderLevel() { }

	// RVA: 0x19BA010 Offset: 0x19B8610 VA: 0x1819BA010
	public static bool get_graphicsMultiThreaded() { }

	// RVA: 0xBFA230 Offset: 0xBF8830 VA: 0x180BFA230
	public static bool get_supportsRenderTextures() { }

	// RVA: 0x19BA440 Offset: 0x19B8A40 VA: 0x1819BA440
	public static bool get_supportsMotionVectors() { }

	// RVA: 0xBFA230 Offset: 0xBF8830 VA: 0x180BFA230
	public static bool get_supportsImageEffects() { }

	// RVA: 0x19BA350 Offset: 0x19B8950 VA: 0x1819BA350
	public static bool get_supports3DTextures() { }

	// RVA: 0x19BA320 Offset: 0x19B8920 VA: 0x1819BA320
	public static bool get_supports3DRenderTextures() { }

	// RVA: 0x19B9DF0 Offset: 0x19B83F0 VA: 0x1819B9DF0
	public static CopyTextureSupport get_copyTextureSupport() { }

	// RVA: 0x19BA3B0 Offset: 0x19B89B0 VA: 0x1819BA3B0
	public static bool get_supportsComputeShaders() { }

	// RVA: 0x19BA3E0 Offset: 0x19B89E0 VA: 0x1819BA3E0
	public static bool get_supportsInstancing() { }

	// RVA: 0x19BA2F0 Offset: 0x19B88F0 VA: 0x1819BA2F0
	public static int get_supportedRenderTargetCount() { }

	// RVA: 0x19BA2C0 Offset: 0x19B88C0 VA: 0x1819BA2C0
	public static int get_supportedRandomWriteTargetCount() { }

	// RVA: 0x19BA6D0 Offset: 0x19B8CD0 VA: 0x1819BA6D0
	public static bool get_usesReversedZBuffer() { }

	// RVA: 0x19BA240 Offset: 0x19B8840 VA: 0x1819BA240
	private static bool IsValidEnumValue(Enum value) { }

	// RVA: 0x19BA470 Offset: 0x19B8A70 VA: 0x1819BA470
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x19BA5C0 Offset: 0x19B8BC0 VA: 0x1819BA5C0
	public static bool SupportsTextureFormat(TextureFormat format) { }

	// RVA: 0x19BA380 Offset: 0x19B8980 VA: 0x1819BA380
	public static bool get_supportsAsyncGPUReadback() { }

	// RVA: 0x19BA410 Offset: 0x19B8A10 VA: 0x1819BA410
	public static bool get_supportsMipStreaming() { }

	[FreeFunctionAttribute] // RVA: 0xCAC90 Offset: 0xCA090 VA: 0x1800CAC90
	// RVA: 0x19B9D80 Offset: 0x19B8380 VA: 0x1819B9D80
	private static BatteryStatus GetBatteryStatus() { }

	[FreeFunctionAttribute] // RVA: 0xCAD50 Offset: 0xCA150 VA: 0x1800CAD50
	// RVA: 0x19BA0D0 Offset: 0x19B86D0 VA: 0x1819BA0D0
	private static string GetOperatingSystem() { }

	[FreeFunctionAttribute] // RVA: 0xCAEC0 Offset: 0xCA2C0 VA: 0x1800CAEC0
	// RVA: 0x19BA0A0 Offset: 0x19B86A0 VA: 0x1819BA0A0
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunctionAttribute] // RVA: 0xCAF60 Offset: 0xCA360 VA: 0x1800CAF60
	// RVA: 0x19BA190 Offset: 0x19B8790 VA: 0x1819BA190
	private static string GetProcessorType() { }

	[FreeFunctionAttribute] // RVA: 0xCAFD0 Offset: 0xCA3D0 VA: 0x1800CAFD0
	// RVA: 0x19BA160 Offset: 0x19B8760 VA: 0x1819BA160
	private static int GetProcessorFrequencyMHz() { }

	[FreeFunctionAttribute] // RVA: 0xCB020 Offset: 0xCA420 VA: 0x1800CB020
	// RVA: 0x19BA130 Offset: 0x19B8730 VA: 0x1819BA130
	private static int GetProcessorCount() { }

	[FreeFunctionAttribute] // RVA: 0xCB0C0 Offset: 0xCA4C0 VA: 0x1800CB0C0
	// RVA: 0x19BA100 Offset: 0x19B8700 VA: 0x1819BA100
	private static int GetPhysicalMemoryMB() { }

	[FreeFunctionAttribute] // RVA: 0xCB140 Offset: 0xCA540 VA: 0x1800CB140
	// RVA: 0x19B9EB0 Offset: 0x19B84B0 VA: 0x1819B9EB0
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunctionAttribute] // RVA: 0xCB250 Offset: 0xCA650 VA: 0x1800CB250
	// RVA: 0x19B9E50 Offset: 0x19B8450 VA: 0x1819B9E50
	private static string GetDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCB360 Offset: 0xCA760 VA: 0x1800CB360
	// RVA: 0x19B9E20 Offset: 0x19B8420 VA: 0x1819B9E20
	private static string GetDeviceModel() { }

	[FreeFunctionAttribute] // RVA: 0xCB460 Offset: 0xCA860 VA: 0x1800CB460
	// RVA: 0x19B9E80 Offset: 0x19B8480 VA: 0x1819B9E80
	private static DeviceType GetDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCB5A0 Offset: 0xCA9A0 VA: 0x1800CB5A0
	// RVA: 0x19B9FE0 Offset: 0x19B85E0 VA: 0x1819B9FE0
	private static int GetGraphicsMemorySize() { }

	[FreeFunctionAttribute] // RVA: 0xCB770 Offset: 0xCAB70 VA: 0x1800CB770
	// RVA: 0x19B9EE0 Offset: 0x19B84E0 VA: 0x1819B9EE0
	private static string GetGraphicsDeviceName() { }

	[FreeFunctionAttribute] // RVA: 0xCBA50 Offset: 0xCAE50 VA: 0x1800CBA50
	// RVA: 0x19B9F40 Offset: 0x19B8540 VA: 0x1819B9F40
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunctionAttribute] // RVA: 0xCBC30 Offset: 0xCB030 VA: 0x1800CBC30
	// RVA: 0x19B9F10 Offset: 0x19B8510 VA: 0x1819B9F10
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0xCBD70 Offset: 0xCB170 VA: 0x1800CBD70
	// RVA: 0x19BA070 Offset: 0x19B8670 VA: 0x1819BA070
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunctionAttribute] // RVA: 0xCBE50 Offset: 0xCB250 VA: 0x1800CBE50
	// RVA: 0x19B9F70 Offset: 0x19B8570 VA: 0x1819B9F70
	private static string GetGraphicsDeviceVersion() { }

	[FreeFunctionAttribute] // RVA: 0xCBF30 Offset: 0xCB330 VA: 0x1800CBF30
	// RVA: 0x19BA040 Offset: 0x19B8640 VA: 0x1819BA040
	private static int GetGraphicsShaderLevel() { }

	[FreeFunctionAttribute] // RVA: 0xCC020 Offset: 0xCB420 VA: 0x1800CC020
	// RVA: 0x19BA010 Offset: 0x19B8610 VA: 0x1819BA010
	private static bool GetGraphicsMultiThreaded() { }

	[FreeFunctionAttribute] // RVA: 0xCC1E0 Offset: 0xCB5E0 VA: 0x1800CC1E0
	// RVA: 0x19BA440 Offset: 0x19B8A40 VA: 0x1819BA440
	private static bool SupportsMotionVectors() { }

	[FreeFunctionAttribute] // RVA: 0xCC320 Offset: 0xCB720 VA: 0x1800CC320
	// RVA: 0x19BA350 Offset: 0x19B8950 VA: 0x1819BA350
	private static bool Supports3DTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC4B0 Offset: 0xCB8B0 VA: 0x1800CC4B0
	// RVA: 0x19BA320 Offset: 0x19B8920 VA: 0x1819BA320
	private static bool Supports3DRenderTextures() { }

	[FreeFunctionAttribute] // RVA: 0xCC5D0 Offset: 0xCB9D0 VA: 0x1800CC5D0
	// RVA: 0x19B9DF0 Offset: 0x19B83F0 VA: 0x1819B9DF0
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunctionAttribute] // RVA: 0xCC7F0 Offset: 0xCBBF0 VA: 0x1800CC7F0
	// RVA: 0x19BA3B0 Offset: 0x19B89B0 VA: 0x1819BA3B0
	private static bool SupportsComputeShaders() { }

	[FreeFunctionAttribute] // RVA: 0xCC8D0 Offset: 0xCBCD0 VA: 0x1800CC8D0
	// RVA: 0x19BA3E0 Offset: 0x19B89E0 VA: 0x1819BA3E0
	private static bool SupportsInstancing() { }

	[FreeFunctionAttribute] // RVA: 0xCCA60 Offset: 0xCBE60 VA: 0x1800CCA60
	// RVA: 0x19BA2F0 Offset: 0x19B88F0 VA: 0x1819BA2F0
	private static int SupportedRenderTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCCC10 Offset: 0xCC010 VA: 0x1800CCC10
	// RVA: 0x19BA2C0 Offset: 0x19B88C0 VA: 0x1819BA2C0
	private static int SupportedRandomWriteTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCCD00 Offset: 0xCC100 VA: 0x1800CCD00
	// RVA: 0x19BA6D0 Offset: 0x19B8CD0 VA: 0x1819BA6D0
	private static bool UsesReversedZBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xCCE90 Offset: 0xCC290 VA: 0x1800CCE90
	// RVA: 0x19BA1C0 Offset: 0x19B87C0 VA: 0x1819BA1C0
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCCF40 Offset: 0xCC340 VA: 0x1800CCF40
	// RVA: 0x19BA580 Offset: 0x19B8B80 VA: 0x1819BA580
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xCD000 Offset: 0xCC400 VA: 0x1800CD000
	// RVA: 0x19BA380 Offset: 0x19B8980 VA: 0x1819BA380
	private static bool SupportsAsyncGPUReadback() { }

	[FreeFunctionAttribute] // RVA: 0xCD050 Offset: 0xCC450 VA: 0x1800CD050
	// RVA: 0x19BA410 Offset: 0x19B8A10 VA: 0x1819BA410
	private static bool SupportsMipStreaming() { }

	[FreeFunctionAttribute] // RVA: 0xCD210 Offset: 0xCC610 VA: 0x1800CD210
	// RVA: 0x19BA200 Offset: 0x19B8800 VA: 0x1819BA200
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD2D0 Offset: 0xCC6D0 VA: 0x1800CD2D0
	// RVA: 0x19B9DB0 Offset: 0x19B83B0 VA: 0x1819B9DB0
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0xCD460 Offset: 0xCC860 VA: 0x1800CD460
	// RVA: 0x19B9FA0 Offset: 0x19B85A0 VA: 0x1819B9FA0
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

}

