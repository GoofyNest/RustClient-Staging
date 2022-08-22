public struct SystemInformation // TypeDefIndex: 6205
{	// Fields
	public SystemInformation.Hardware hardware; // 0x0
	public SystemInformation.Environment environment; // 0x1

}

public struct SystemInformation.Hardware // TypeDefIndex: 6206
{	// Properties
	public string deviceName { get; }
	public string operatingSystem { get; }
	public string processorType { get; }
	public string processorCount { get; }
	public string systemMemorySize { get; }
	public string graphicsDeviceName { get; }
	public string graphicsDeviceVersion { get; }
	public string graphicsMemorySize { get; }
	public string graphicsShaderLevel { get; }
	public string graphicsDeviceType { get; }
	public string deviceUniqueIdentifier { get; }
	public string graphicsDeviceVendor { get; }
	public bool graphicsMultiThreaded { get; }
	public int processorFrequency { get; }
	public string processorArchitecture { get; }

	// Methods

	// RVA: 0x1F0E20 Offset: 0x1F0220 VA: 0x1801F0E20
	public string get_deviceName() { }

	// RVA: 0x1F0E30 Offset: 0x1F0230 VA: 0x1801F0E30
	public string get_operatingSystem() { }

	// RVA: 0x1F0BB0 Offset: 0x1EFFB0 VA: 0x1801F0BB0
	public string get_processorType() { }

	// RVA: 0x1F1780 Offset: 0x1F0B80 VA: 0x1801F1780
	public string get_processorCount() { }

	// RVA: 0x1F17C0 Offset: 0x1F0BC0 VA: 0x1801F17C0
	public string get_systemMemorySize() { }

	// RVA: 0x1F0BD0 Offset: 0x1EFFD0 VA: 0x1801F0BD0
	public string get_graphicsDeviceName() { }

	// RVA: 0x1F1690 Offset: 0x1F0A90 VA: 0x1801F1690
	public string get_graphicsDeviceVersion() { }

	// RVA: 0x1F16A0 Offset: 0x1F0AA0 VA: 0x1801F16A0
	public string get_graphicsMemorySize() { }

	// RVA: 0x1F1710 Offset: 0x1F0B10 VA: 0x1801F1710
	public string get_graphicsShaderLevel() { }

	// RVA: 0x1F15F0 Offset: 0x1F09F0 VA: 0x1801F15F0
	public string get_graphicsDeviceType() { }

	// RVA: 0x1F15E0 Offset: 0x1F09E0 VA: 0x1801F15E0
	public string get_deviceUniqueIdentifier() { }

	// RVA: 0x1F1680 Offset: 0x1F0A80 VA: 0x1801F1680
	public string get_graphicsDeviceVendor() { }

	// RVA: 0x1F1700 Offset: 0x1F0B00 VA: 0x1801F1700
	public bool get_graphicsMultiThreaded() { }

	// RVA: 0x1F17B0 Offset: 0x1F0BB0 VA: 0x1801F17B0
	public int get_processorFrequency() { }

	// RVA: 0x1F1740 Offset: 0x1F0B40 VA: 0x1801F1740
	public string get_processorArchitecture() { }

}

public struct SystemInformation.Environment // TypeDefIndex: 6207
{	// Properties
	public string unityVersion { get; }
	public string version { get; }
	public string companyName { get; }
	public bool isEditor { get; }
	public bool isPlayer { get; }
	public string systemLanguage { get; }
	public int targetFrameRate { get; }
	public Resolution currentResolution { get; }
	public int screenWidth { get; }
	public int screenHeight { get; }
	public bool fullScreen { get; }
	public string anisotropicFiltering { get; }
	public string antiAliasing { get; }
	public string qualityLevel { get; }
	public string globalMaximumLOD { get; }
	public string lodBias { get; }
	public string maximumLODLevel { get; }
	public string particleRaycastBudget { get; }
	public string pixelLightCount { get; }
	public string realtimeReflectionProbes { get; }
	public string shadowCascades { get; }
	public string shadowDistance { get; }
	public string softVegetation { get; }
	public string vSyncCount { get; }

	// Methods

	// RVA: 0x1F13B0 Offset: 0x1F07B0 VA: 0x1801F13B0
	public string get_unityVersion() { }

	// RVA: 0x1F13F0 Offset: 0x1F07F0 VA: 0x1801F13F0
	public string get_version() { }

	// RVA: 0x1F1090 Offset: 0x1F0490 VA: 0x1801F1090
	public string get_companyName() { }

	// RVA: 0x1F1110 Offset: 0x1F0510 VA: 0x1801F1110
	public bool get_isEditor() { }

	// RVA: 0x1F1120 Offset: 0x1F0520 VA: 0x1801F1120
	public bool get_isPlayer() { }

	// RVA: 0x1F1310 Offset: 0x1F0710 VA: 0x1801F1310
	public string get_systemLanguage() { }

	// RVA: 0x1F13A0 Offset: 0x1F07A0 VA: 0x1801F13A0
	public int get_targetFrameRate() { }

	// RVA: 0x1F10A0 Offset: 0x1F04A0 VA: 0x1801F10A0
	public Resolution get_currentResolution() { }

	// RVA: 0x1F1270 Offset: 0x1F0670 VA: 0x1801F1270
	public int get_screenWidth() { }

	// RVA: 0x1F1260 Offset: 0x1F0660 VA: 0x1801F1260
	public int get_screenHeight() { }

	// RVA: 0x1F10D0 Offset: 0x1F04D0 VA: 0x1801F10D0
	public bool get_fullScreen() { }

	// RVA: 0x1F0FD0 Offset: 0x1F03D0 VA: 0x1801F0FD0
	public string get_anisotropicFiltering() { }

	// RVA: 0x1F1060 Offset: 0x1F0460 VA: 0x1801F1060
	public string get_antiAliasing() { }

	// RVA: 0x1F1200 Offset: 0x1F0600 VA: 0x1801F1200
	public string get_qualityLevel() { }

	// RVA: 0x1F10E0 Offset: 0x1F04E0 VA: 0x1801F10E0
	public string get_globalMaximumLOD() { }

	// RVA: 0x1F1140 Offset: 0x1F0540 VA: 0x1801F1140
	public string get_lodBias() { }

	// RVA: 0x1F1170 Offset: 0x1F0570 VA: 0x1801F1170
	public string get_maximumLODLevel() { }

	// RVA: 0x1F11A0 Offset: 0x1F05A0 VA: 0x1801F11A0
	public string get_particleRaycastBudget() { }

	// RVA: 0x1F11D0 Offset: 0x1F05D0 VA: 0x1801F11D0
	public string get_pixelLightCount() { }

	// RVA: 0x1F1230 Offset: 0x1F0630 VA: 0x1801F1230
	public string get_realtimeReflectionProbes() { }

	// RVA: 0x1F1280 Offset: 0x1F0680 VA: 0x1801F1280
	public string get_shadowCascades() { }

	// RVA: 0x1F12B0 Offset: 0x1F06B0 VA: 0x1801F12B0
	public string get_shadowDistance() { }

	// RVA: 0x1F12E0 Offset: 0x1F06E0 VA: 0x1801F12E0
	public string get_softVegetation() { }

	// RVA: 0x1F13C0 Offset: 0x1F07C0 VA: 0x1801F13C0
	public string get_vSyncCount() { }

}

