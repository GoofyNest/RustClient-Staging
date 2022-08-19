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

	// RVA: 0x1F0EA0 Offset: 0x1F02A0 VA: 0x1801F0EA0
	public string get_deviceName() { }

	// RVA: 0x1F0EB0 Offset: 0x1F02B0 VA: 0x1801F0EB0
	public string get_operatingSystem() { }

	// RVA: 0x1F0C30 Offset: 0x1F0030 VA: 0x1801F0C30
	public string get_processorType() { }

	// RVA: 0x1F1800 Offset: 0x1F0C00 VA: 0x1801F1800
	public string get_processorCount() { }

	// RVA: 0x1F1840 Offset: 0x1F0C40 VA: 0x1801F1840
	public string get_systemMemorySize() { }

	// RVA: 0x1F0C50 Offset: 0x1F0050 VA: 0x1801F0C50
	public string get_graphicsDeviceName() { }

	// RVA: 0x1F1710 Offset: 0x1F0B10 VA: 0x1801F1710
	public string get_graphicsDeviceVersion() { }

	// RVA: 0x1F1720 Offset: 0x1F0B20 VA: 0x1801F1720
	public string get_graphicsMemorySize() { }

	// RVA: 0x1F1790 Offset: 0x1F0B90 VA: 0x1801F1790
	public string get_graphicsShaderLevel() { }

	// RVA: 0x1F1670 Offset: 0x1F0A70 VA: 0x1801F1670
	public string get_graphicsDeviceType() { }

	// RVA: 0x1F1660 Offset: 0x1F0A60 VA: 0x1801F1660
	public string get_deviceUniqueIdentifier() { }

	// RVA: 0x1F1700 Offset: 0x1F0B00 VA: 0x1801F1700
	public string get_graphicsDeviceVendor() { }

	// RVA: 0x1F1780 Offset: 0x1F0B80 VA: 0x1801F1780
	public bool get_graphicsMultiThreaded() { }

	// RVA: 0x1F1830 Offset: 0x1F0C30 VA: 0x1801F1830
	public int get_processorFrequency() { }

	// RVA: 0x1F17C0 Offset: 0x1F0BC0 VA: 0x1801F17C0
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

	// RVA: 0x1F1430 Offset: 0x1F0830 VA: 0x1801F1430
	public string get_unityVersion() { }

	// RVA: 0x1F1470 Offset: 0x1F0870 VA: 0x1801F1470
	public string get_version() { }

	// RVA: 0x1F1110 Offset: 0x1F0510 VA: 0x1801F1110
	public string get_companyName() { }

	// RVA: 0x1F1190 Offset: 0x1F0590 VA: 0x1801F1190
	public bool get_isEditor() { }

	// RVA: 0x1F11A0 Offset: 0x1F05A0 VA: 0x1801F11A0
	public bool get_isPlayer() { }

	// RVA: 0x1F1390 Offset: 0x1F0790 VA: 0x1801F1390
	public string get_systemLanguage() { }

	// RVA: 0x1F1420 Offset: 0x1F0820 VA: 0x1801F1420
	public int get_targetFrameRate() { }

	// RVA: 0x1F1120 Offset: 0x1F0520 VA: 0x1801F1120
	public Resolution get_currentResolution() { }

	// RVA: 0x1F12F0 Offset: 0x1F06F0 VA: 0x1801F12F0
	public int get_screenWidth() { }

	// RVA: 0x1F12E0 Offset: 0x1F06E0 VA: 0x1801F12E0
	public int get_screenHeight() { }

	// RVA: 0x1F1150 Offset: 0x1F0550 VA: 0x1801F1150
	public bool get_fullScreen() { }

	// RVA: 0x1F1050 Offset: 0x1F0450 VA: 0x1801F1050
	public string get_anisotropicFiltering() { }

	// RVA: 0x1F10E0 Offset: 0x1F04E0 VA: 0x1801F10E0
	public string get_antiAliasing() { }

	// RVA: 0x1F1280 Offset: 0x1F0680 VA: 0x1801F1280
	public string get_qualityLevel() { }

	// RVA: 0x1F1160 Offset: 0x1F0560 VA: 0x1801F1160
	public string get_globalMaximumLOD() { }

	// RVA: 0x1F11C0 Offset: 0x1F05C0 VA: 0x1801F11C0
	public string get_lodBias() { }

	// RVA: 0x1F11F0 Offset: 0x1F05F0 VA: 0x1801F11F0
	public string get_maximumLODLevel() { }

	// RVA: 0x1F1220 Offset: 0x1F0620 VA: 0x1801F1220
	public string get_particleRaycastBudget() { }

	// RVA: 0x1F1250 Offset: 0x1F0650 VA: 0x1801F1250
	public string get_pixelLightCount() { }

	// RVA: 0x1F12B0 Offset: 0x1F06B0 VA: 0x1801F12B0
	public string get_realtimeReflectionProbes() { }

	// RVA: 0x1F1300 Offset: 0x1F0700 VA: 0x1801F1300
	public string get_shadowCascades() { }

	// RVA: 0x1F1330 Offset: 0x1F0730 VA: 0x1801F1330
	public string get_shadowDistance() { }

	// RVA: 0x1F1360 Offset: 0x1F0760 VA: 0x1801F1360
	public string get_softVegetation() { }

	// RVA: 0x1F1440 Offset: 0x1F0840 VA: 0x1801F1440
	public string get_vSyncCount() { }

}

