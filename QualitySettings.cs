public sealed class QualitySettings : Object // TypeDefIndex: 3395
{	// Properties
	public static int pixelLightCount { get; }
	public static int shadowCascades { get; set; }
	public static float shadowDistance { get; set; }
	[NativePropertyAttribute] // RVA: 0x8D650 Offset: 0x8CA50 VA: 0x18008D650
	public static float lodBias { get; set; }
	[NativePropertyAttribute] // RVA: 0x8D6A0 Offset: 0x8CAA0 VA: 0x18008D6A0
	public static AnisotropicFiltering anisotropicFiltering { get; set; }
	public static int masterTextureLimit { get; }
	public static int maximumLODLevel { get; }
	public static int particleRaycastBudget { get; }
	public static bool softVegetation { get; }
	public static int vSyncCount { get; set; }
	public static int antiAliasing { get; set; }
	public static bool realtimeReflectionProbes { get; }
	public static bool streamingMipmapsActive { get; set; }
	public static float streamingMipmapsMemoryBudget { get; set; }
	public static int streamingMipmapsMaxLevelReduction { get; }
	[StaticAccessorAttribute] // RVA: 0x8D8A0 Offset: 0x8CCA0 VA: 0x18008D8A0
	public static int maxQueuedFrames { get; set; }
	public static ColorSpace activeColorSpace { get; }

	// Methods

	// RVA: 0x18FD9C0 Offset: 0x18FBFC0 VA: 0x1818FD9C0
	public static int get_pixelLightCount() { }

	// RVA: 0x18FDA20 Offset: 0x18FC020 VA: 0x1818FDA20
	public static int get_shadowCascades() { }

	// RVA: 0x18FDC70 Offset: 0x18FC270 VA: 0x1818FDC70
	public static void set_shadowCascades(int value) { }

	// RVA: 0x18FDA50 Offset: 0x18FC050 VA: 0x1818FDA50
	public static float get_shadowDistance() { }

	// RVA: 0x18FDCB0 Offset: 0x18FC2B0 VA: 0x1818FDCB0
	public static void set_shadowDistance(float value) { }

	// RVA: 0x18FD8D0 Offset: 0x18FBED0 VA: 0x1818FD8D0
	public static float get_lodBias() { }

	// RVA: 0x18FDBF0 Offset: 0x18FC1F0 VA: 0x1818FDBF0
	public static void set_lodBias(float value) { }

	// RVA: 0x18FD870 Offset: 0x18FBE70 VA: 0x1818FD870
	public static AnisotropicFiltering get_anisotropicFiltering() { }

	// RVA: 0x18FDB70 Offset: 0x18FC170 VA: 0x1818FDB70
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	// RVA: 0x18FD900 Offset: 0x18FBF00 VA: 0x1818FD900
	public static int get_masterTextureLimit() { }

	// RVA: 0x18FD960 Offset: 0x18FBF60 VA: 0x1818FD960
	public static int get_maximumLODLevel() { }

	// RVA: 0x18FD990 Offset: 0x18FBF90 VA: 0x1818FD990
	public static int get_particleRaycastBudget() { }

	// RVA: 0x18FDA80 Offset: 0x18FC080 VA: 0x1818FDA80
	public static bool get_softVegetation() { }

	// RVA: 0x18FDB40 Offset: 0x18FC140 VA: 0x1818FDB40
	public static int get_vSyncCount() { }

	// RVA: 0x18FDD70 Offset: 0x18FC370 VA: 0x1818FDD70
	public static void set_vSyncCount(int value) { }

	// RVA: 0x18FD8A0 Offset: 0x18FBEA0 VA: 0x1818FD8A0
	public static int get_antiAliasing() { }

	// RVA: 0x18FDBB0 Offset: 0x18FC1B0 VA: 0x1818FDBB0
	public static void set_antiAliasing(int value) { }

	// RVA: 0x18FD9F0 Offset: 0x18FBFF0 VA: 0x1818FD9F0
	public static bool get_realtimeReflectionProbes() { }

	// RVA: 0x18FDAB0 Offset: 0x18FC0B0 VA: 0x1818FDAB0
	public static bool get_streamingMipmapsActive() { }

	// RVA: 0x18FDCF0 Offset: 0x18FC2F0 VA: 0x1818FDCF0
	public static void set_streamingMipmapsActive(bool value) { }

	// RVA: 0x18FDB10 Offset: 0x18FC110 VA: 0x1818FDB10
	public static float get_streamingMipmapsMemoryBudget() { }

	// RVA: 0x18FDD30 Offset: 0x18FC330 VA: 0x1818FDD30
	public static void set_streamingMipmapsMemoryBudget(float value) { }

	// RVA: 0x18FDAE0 Offset: 0x18FC0E0 VA: 0x1818FDAE0
	public static int get_streamingMipmapsMaxLevelReduction() { }

	// RVA: 0x18FD930 Offset: 0x18FBF30 VA: 0x1818FD930
	public static int get_maxQueuedFrames() { }

	// RVA: 0x18FDC30 Offset: 0x18FC230 VA: 0x1818FDC30
	public static void set_maxQueuedFrames(int value) { }

	[NativeNameAttribute] // RVA: 0x8D260 Offset: 0x8C660 VA: 0x18008D260
	// RVA: 0x18FD7D0 Offset: 0x18FBDD0 VA: 0x1818FD7D0
	public static int GetQualityLevel() { }

	[NativeNameAttribute] // RVA: 0x8D310 Offset: 0x8C710 VA: 0x18008D310
	// RVA: 0x18FD800 Offset: 0x18FBE00 VA: 0x1818FD800
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	[NativeNameAttribute] // RVA: 0x8D440 Offset: 0x8C840 VA: 0x18008D440
	[StaticAccessorAttribute] // RVA: 0x8D440 Offset: 0x8C840 VA: 0x18008D440
	// RVA: 0x18FD840 Offset: 0x18FBE40 VA: 0x1818FD840
	public static ColorSpace get_activeColorSpace() { }

}

