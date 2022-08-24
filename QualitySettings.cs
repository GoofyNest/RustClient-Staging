public sealed class QualitySettings : Object // TypeDefIndex: 3395
{	public static int pixelLightCount { get; }
	public static int shadowCascades { get; set; }
	public static float shadowDistance { get; set; }
	[NativePropertyAttribute] // RVA: 0x8D760 Offset: 0x8CB60 VA: 0x18008D760
	public static float lodBias { get; set; }
	[NativePropertyAttribute] // RVA: 0x8D7B0 Offset: 0x8CBB0 VA: 0x18008D7B0
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
	[StaticAccessorAttribute] // RVA: 0x8D9E0 Offset: 0x8CDE0 VA: 0x18008D9E0
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

	[NativeNameAttribute] // RVA: 0x8D370 Offset: 0x8C770 VA: 0x18008D370
	public static int GetQualityLevel() { }

	[NativeNameAttribute] // RVA: 0x8D3F0 Offset: 0x8C7F0 VA: 0x18008D3F0
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	[StaticAccessorAttribute] // RVA: 0x8D580 Offset: 0x8C980 VA: 0x18008D580
	[NativeNameAttribute] // RVA: 0x8D580 Offset: 0x8C980 VA: 0x18008D580
	public static ColorSpace get_activeColorSpace() { }

}

