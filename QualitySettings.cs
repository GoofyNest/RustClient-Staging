public sealed class QualitySettings : Object // TypeDefIndex: 3395
{	public static int pixelLightCount { get; }
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


	public static int get_pixelLightCount() { }

	public static int get_shadowCascades() { }

	public static void set_shadowCascades(int value) { }

	public static float get_shadowDistance() { }

	public static void set_shadowDistance(float value) { }

	public static float get_lodBias() { }

	public static void set_lodBias(float value) { }

	public static AnisotropicFiltering get_anisotropicFiltering() { }

	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	public static int get_masterTextureLimit() { }

	public static int get_maximumLODLevel() { }

	public static int get_particleRaycastBudget() { }

	public static bool get_softVegetation() { }

	public static int get_vSyncCount() { }

	public static void set_vSyncCount(int value) { }

	public static int get_antiAliasing() { }

	public static void set_antiAliasing(int value) { }

	public static bool get_realtimeReflectionProbes() { }

	public static bool get_streamingMipmapsActive() { }

	public static void set_streamingMipmapsActive(bool value) { }

	public static float get_streamingMipmapsMemoryBudget() { }

	public static void set_streamingMipmapsMemoryBudget(float value) { }

	public static int get_streamingMipmapsMaxLevelReduction() { }

	public static int get_maxQueuedFrames() { }

	public static void set_maxQueuedFrames(int value) { }

	[NativeNameAttribute] // RVA: 0x8D260 Offset: 0x8C660 VA: 0x18008D260
	public static int GetQualityLevel() { }

	[NativeNameAttribute] // RVA: 0x8D310 Offset: 0x8C710 VA: 0x18008D310
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	[NativeNameAttribute] // RVA: 0x8D440 Offset: 0x8C840 VA: 0x18008D440
	[StaticAccessorAttribute] // RVA: 0x8D440 Offset: 0x8C840 VA: 0x18008D440
	public static ColorSpace get_activeColorSpace() { }

}

