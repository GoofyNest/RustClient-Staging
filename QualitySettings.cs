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

	// RVA: 0x18FD0E0 Offset: 0x18FB6E0 VA: 0x1818FD0E0
	public static int get_pixelLightCount() { }

	// RVA: 0x18FD140 Offset: 0x18FB740 VA: 0x1818FD140
	public static int get_shadowCascades() { }

	// RVA: 0x18FD390 Offset: 0x18FB990 VA: 0x1818FD390
	public static void set_shadowCascades(int value) { }

	// RVA: 0x18FD170 Offset: 0x18FB770 VA: 0x1818FD170
	public static float get_shadowDistance() { }

	// RVA: 0x18FD3D0 Offset: 0x18FB9D0 VA: 0x1818FD3D0
	public static void set_shadowDistance(float value) { }

	// RVA: 0x18FCFF0 Offset: 0x18FB5F0 VA: 0x1818FCFF0
	public static float get_lodBias() { }

	// RVA: 0x18FD310 Offset: 0x18FB910 VA: 0x1818FD310
	public static void set_lodBias(float value) { }

	// RVA: 0x18FCF90 Offset: 0x18FB590 VA: 0x1818FCF90
	public static AnisotropicFiltering get_anisotropicFiltering() { }

	// RVA: 0x18FD290 Offset: 0x18FB890 VA: 0x1818FD290
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	// RVA: 0x18FD020 Offset: 0x18FB620 VA: 0x1818FD020
	public static int get_masterTextureLimit() { }

	// RVA: 0x18FD080 Offset: 0x18FB680 VA: 0x1818FD080
	public static int get_maximumLODLevel() { }

	// RVA: 0x18FD0B0 Offset: 0x18FB6B0 VA: 0x1818FD0B0
	public static int get_particleRaycastBudget() { }

	// RVA: 0x18FD1A0 Offset: 0x18FB7A0 VA: 0x1818FD1A0
	public static bool get_softVegetation() { }

	// RVA: 0x18FD260 Offset: 0x18FB860 VA: 0x1818FD260
	public static int get_vSyncCount() { }

	// RVA: 0x18FD490 Offset: 0x18FBA90 VA: 0x1818FD490
	public static void set_vSyncCount(int value) { }

	// RVA: 0x18FCFC0 Offset: 0x18FB5C0 VA: 0x1818FCFC0
	public static int get_antiAliasing() { }

	// RVA: 0x18FD2D0 Offset: 0x18FB8D0 VA: 0x1818FD2D0
	public static void set_antiAliasing(int value) { }

	// RVA: 0x18FD110 Offset: 0x18FB710 VA: 0x1818FD110
	public static bool get_realtimeReflectionProbes() { }

	// RVA: 0x18FD1D0 Offset: 0x18FB7D0 VA: 0x1818FD1D0
	public static bool get_streamingMipmapsActive() { }

	// RVA: 0x18FD410 Offset: 0x18FBA10 VA: 0x1818FD410
	public static void set_streamingMipmapsActive(bool value) { }

	// RVA: 0x18FD230 Offset: 0x18FB830 VA: 0x1818FD230
	public static float get_streamingMipmapsMemoryBudget() { }

	// RVA: 0x18FD450 Offset: 0x18FBA50 VA: 0x1818FD450
	public static void set_streamingMipmapsMemoryBudget(float value) { }

	// RVA: 0x18FD200 Offset: 0x18FB800 VA: 0x1818FD200
	public static int get_streamingMipmapsMaxLevelReduction() { }

	// RVA: 0x18FD050 Offset: 0x18FB650 VA: 0x1818FD050
	public static int get_maxQueuedFrames() { }

	// RVA: 0x18FD350 Offset: 0x18FB950 VA: 0x1818FD350
	public static void set_maxQueuedFrames(int value) { }

	[NativeNameAttribute] // RVA: 0x8D260 Offset: 0x8C660 VA: 0x18008D260
	// RVA: 0x18FCEF0 Offset: 0x18FB4F0 VA: 0x1818FCEF0
	public static int GetQualityLevel() { }

	[NativeNameAttribute] // RVA: 0x8D310 Offset: 0x8C710 VA: 0x18008D310
	// RVA: 0x18FCF20 Offset: 0x18FB520 VA: 0x1818FCF20
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	[NativeNameAttribute] // RVA: 0x8D440 Offset: 0x8C840 VA: 0x18008D440
	[StaticAccessorAttribute] // RVA: 0x8D440 Offset: 0x8C840 VA: 0x18008D440
	// RVA: 0x18FCF60 Offset: 0x18FB560 VA: 0x1818FCF60
	public static ColorSpace get_activeColorSpace() { }

}

