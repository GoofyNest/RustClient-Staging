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

	// RVA: 0x18FD700 Offset: 0x18FBD00 VA: 0x1818FD700
	public static int get_pixelLightCount() { }

	// RVA: 0x18FD760 Offset: 0x18FBD60 VA: 0x1818FD760
	public static int get_shadowCascades() { }

	// RVA: 0x18FD9B0 Offset: 0x18FBFB0 VA: 0x1818FD9B0
	public static void set_shadowCascades(int value) { }

	// RVA: 0x18FD790 Offset: 0x18FBD90 VA: 0x1818FD790
	public static float get_shadowDistance() { }

	// RVA: 0x18FD9F0 Offset: 0x18FBFF0 VA: 0x1818FD9F0
	public static void set_shadowDistance(float value) { }

	// RVA: 0x18FD610 Offset: 0x18FBC10 VA: 0x1818FD610
	public static float get_lodBias() { }

	// RVA: 0x18FD930 Offset: 0x18FBF30 VA: 0x1818FD930
	public static void set_lodBias(float value) { }

	// RVA: 0x18FD5B0 Offset: 0x18FBBB0 VA: 0x1818FD5B0
	public static AnisotropicFiltering get_anisotropicFiltering() { }

	// RVA: 0x18FD8B0 Offset: 0x18FBEB0 VA: 0x1818FD8B0
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	// RVA: 0x18FD640 Offset: 0x18FBC40 VA: 0x1818FD640
	public static int get_masterTextureLimit() { }

	// RVA: 0x18FD6A0 Offset: 0x18FBCA0 VA: 0x1818FD6A0
	public static int get_maximumLODLevel() { }

	// RVA: 0x18FD6D0 Offset: 0x18FBCD0 VA: 0x1818FD6D0
	public static int get_particleRaycastBudget() { }

	// RVA: 0x18FD7C0 Offset: 0x18FBDC0 VA: 0x1818FD7C0
	public static bool get_softVegetation() { }

	// RVA: 0x18FD880 Offset: 0x18FBE80 VA: 0x1818FD880
	public static int get_vSyncCount() { }

	// RVA: 0x18FDAB0 Offset: 0x18FC0B0 VA: 0x1818FDAB0
	public static void set_vSyncCount(int value) { }

	// RVA: 0x18FD5E0 Offset: 0x18FBBE0 VA: 0x1818FD5E0
	public static int get_antiAliasing() { }

	// RVA: 0x18FD8F0 Offset: 0x18FBEF0 VA: 0x1818FD8F0
	public static void set_antiAliasing(int value) { }

	// RVA: 0x18FD730 Offset: 0x18FBD30 VA: 0x1818FD730
	public static bool get_realtimeReflectionProbes() { }

	// RVA: 0x18FD7F0 Offset: 0x18FBDF0 VA: 0x1818FD7F0
	public static bool get_streamingMipmapsActive() { }

	// RVA: 0x18FDA30 Offset: 0x18FC030 VA: 0x1818FDA30
	public static void set_streamingMipmapsActive(bool value) { }

	// RVA: 0x18FD850 Offset: 0x18FBE50 VA: 0x1818FD850
	public static float get_streamingMipmapsMemoryBudget() { }

	// RVA: 0x18FDA70 Offset: 0x18FC070 VA: 0x1818FDA70
	public static void set_streamingMipmapsMemoryBudget(float value) { }

	// RVA: 0x18FD820 Offset: 0x18FBE20 VA: 0x1818FD820
	public static int get_streamingMipmapsMaxLevelReduction() { }

	// RVA: 0x18FD670 Offset: 0x18FBC70 VA: 0x1818FD670
	public static int get_maxQueuedFrames() { }

	// RVA: 0x18FD970 Offset: 0x18FBF70 VA: 0x1818FD970
	public static void set_maxQueuedFrames(int value) { }

	[NativeNameAttribute] // RVA: 0x8D260 Offset: 0x8C660 VA: 0x18008D260
	// RVA: 0x18FD510 Offset: 0x18FBB10 VA: 0x1818FD510
	public static int GetQualityLevel() { }

	[NativeNameAttribute] // RVA: 0x8D310 Offset: 0x8C710 VA: 0x18008D310
	// RVA: 0x18FD540 Offset: 0x18FBB40 VA: 0x1818FD540
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	[NativeNameAttribute] // RVA: 0x8D440 Offset: 0x8C840 VA: 0x18008D440
	[StaticAccessorAttribute] // RVA: 0x8D440 Offset: 0x8C840 VA: 0x18008D440
	// RVA: 0x18FD580 Offset: 0x18FBB80 VA: 0x1818FD580
	public static ColorSpace get_activeColorSpace() { }

}

