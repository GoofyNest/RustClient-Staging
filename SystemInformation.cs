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

	// RVA: 0x1F1240 Offset: 0x1F0640 VA: 0x1801F1240
	public string get_deviceName() { }

	// RVA: 0x1F1250 Offset: 0x1F0650 VA: 0x1801F1250
	public string get_operatingSystem() { }

	// RVA: 0x1F0FD0 Offset: 0x1F03D0 VA: 0x1801F0FD0
	public string get_processorType() { }

	// RVA: 0x1F1BA0 Offset: 0x1F0FA0 VA: 0x1801F1BA0
	public string get_processorCount() { }

	// RVA: 0x1F1BE0 Offset: 0x1F0FE0 VA: 0x1801F1BE0
	public string get_systemMemorySize() { }

	// RVA: 0x1F0FF0 Offset: 0x1F03F0 VA: 0x1801F0FF0
	public string get_graphicsDeviceName() { }

	// RVA: 0x1F1AB0 Offset: 0x1F0EB0 VA: 0x1801F1AB0
	public string get_graphicsDeviceVersion() { }

	// RVA: 0x1F1AC0 Offset: 0x1F0EC0 VA: 0x1801F1AC0
	public string get_graphicsMemorySize() { }

	// RVA: 0x1F1B30 Offset: 0x1F0F30 VA: 0x1801F1B30
	public string get_graphicsShaderLevel() { }

	// RVA: 0x1F1A10 Offset: 0x1F0E10 VA: 0x1801F1A10
	public string get_graphicsDeviceType() { }

	// RVA: 0x1F1A00 Offset: 0x1F0E00 VA: 0x1801F1A00
	public string get_deviceUniqueIdentifier() { }

	// RVA: 0x1F1AA0 Offset: 0x1F0EA0 VA: 0x1801F1AA0
	public string get_graphicsDeviceVendor() { }

	// RVA: 0x1F1B20 Offset: 0x1F0F20 VA: 0x1801F1B20
	public bool get_graphicsMultiThreaded() { }

	// RVA: 0x1F1BD0 Offset: 0x1F0FD0 VA: 0x1801F1BD0
	public int get_processorFrequency() { }

	// RVA: 0x1F1B60 Offset: 0x1F0F60 VA: 0x1801F1B60
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

	// RVA: 0x1F17D0 Offset: 0x1F0BD0 VA: 0x1801F17D0
	public string get_unityVersion() { }

	// RVA: 0x1F1810 Offset: 0x1F0C10 VA: 0x1801F1810
	public string get_version() { }

	// RVA: 0x1F14B0 Offset: 0x1F08B0 VA: 0x1801F14B0
	public string get_companyName() { }

	// RVA: 0x1F1530 Offset: 0x1F0930 VA: 0x1801F1530
	public bool get_isEditor() { }

	// RVA: 0x1F1540 Offset: 0x1F0940 VA: 0x1801F1540
	public bool get_isPlayer() { }

	// RVA: 0x1F1730 Offset: 0x1F0B30 VA: 0x1801F1730
	public string get_systemLanguage() { }

	// RVA: 0x1F17C0 Offset: 0x1F0BC0 VA: 0x1801F17C0
	public int get_targetFrameRate() { }

	// RVA: 0x1F14C0 Offset: 0x1F08C0 VA: 0x1801F14C0
	public Resolution get_currentResolution() { }

	// RVA: 0x1F1690 Offset: 0x1F0A90 VA: 0x1801F1690
	public int get_screenWidth() { }

	// RVA: 0x1F1680 Offset: 0x1F0A80 VA: 0x1801F1680
	public int get_screenHeight() { }

	// RVA: 0x1F14F0 Offset: 0x1F08F0 VA: 0x1801F14F0
	public bool get_fullScreen() { }

	// RVA: 0x1F13F0 Offset: 0x1F07F0 VA: 0x1801F13F0
	public string get_anisotropicFiltering() { }

	// RVA: 0x1F1480 Offset: 0x1F0880 VA: 0x1801F1480
	public string get_antiAliasing() { }

	// RVA: 0x1F1620 Offset: 0x1F0A20 VA: 0x1801F1620
	public string get_qualityLevel() { }

	// RVA: 0x1F1500 Offset: 0x1F0900 VA: 0x1801F1500
	public string get_globalMaximumLOD() { }

	// RVA: 0x1F1560 Offset: 0x1F0960 VA: 0x1801F1560
	public string get_lodBias() { }

	// RVA: 0x1F1590 Offset: 0x1F0990 VA: 0x1801F1590
	public string get_maximumLODLevel() { }

	// RVA: 0x1F15C0 Offset: 0x1F09C0 VA: 0x1801F15C0
	public string get_particleRaycastBudget() { }

	// RVA: 0x1F15F0 Offset: 0x1F09F0 VA: 0x1801F15F0
	public string get_pixelLightCount() { }

	// RVA: 0x1F1650 Offset: 0x1F0A50 VA: 0x1801F1650
	public string get_realtimeReflectionProbes() { }

	// RVA: 0x1F16A0 Offset: 0x1F0AA0 VA: 0x1801F16A0
	public string get_shadowCascades() { }

	// RVA: 0x1F16D0 Offset: 0x1F0AD0 VA: 0x1801F16D0
	public string get_shadowDistance() { }

	// RVA: 0x1F1700 Offset: 0x1F0B00 VA: 0x1801F1700
	public string get_softVegetation() { }

	// RVA: 0x1F17E0 Offset: 0x1F0BE0 VA: 0x1801F17E0
	public string get_vSyncCount() { }

}

