public sealed class QualitySettings : Object // TypeDefIndex: 3395
{	// Properties
	public static int pixelLightCount { get; }
	public static int shadowCascades { get; set; }
	public static float shadowDistance { get; set; }
	[NativePropertyAttribute] // RVA: 0x8D580 Offset: 0x8C980 VA: 0x18008D580
	public static float lodBias { get; set; }
	[NativePropertyAttribute] // RVA: 0x8D600 Offset: 0x8CA00 VA: 0x18008D600
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
	[StaticAccessorAttribute] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	public static int maxQueuedFrames { get; set; }
	public static ColorSpace activeColorSpace { get; }

	// Methods

	// RVA: 0x18FD740 Offset: 0x18FBD40 VA: 0x1818FD740
	public static int get_pixelLightCount() { }

	// RVA: 0x18FD7A0 Offset: 0x18FBDA0 VA: 0x1818FD7A0
	public static int get_shadowCascades() { }

	// RVA: 0x18FD9F0 Offset: 0x18FBFF0 VA: 0x1818FD9F0
	public static void set_shadowCascades(int value) { }

	// RVA: 0x18FD7D0 Offset: 0x18FBDD0 VA: 0x1818FD7D0
	public static float get_shadowDistance() { }

	// RVA: 0x18FDA30 Offset: 0x18FC030 VA: 0x1818FDA30
	public static void set_shadowDistance(float value) { }

	// RVA: 0x18FD650 Offset: 0x18FBC50 VA: 0x1818FD650
	public static float get_lodBias() { }

	// RVA: 0x18FD970 Offset: 0x18FBF70 VA: 0x1818FD970
	public static void set_lodBias(float value) { }

	// RVA: 0x18FD5F0 Offset: 0x18FBBF0 VA: 0x1818FD5F0
	public static AnisotropicFiltering get_anisotropicFiltering() { }

	// RVA: 0x18FD8F0 Offset: 0x18FBEF0 VA: 0x1818FD8F0
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	// RVA: 0x18FD680 Offset: 0x18FBC80 VA: 0x1818FD680
	public static int get_masterTextureLimit() { }

	// RVA: 0x18FD6E0 Offset: 0x18FBCE0 VA: 0x1818FD6E0
	public static int get_maximumLODLevel() { }

	// RVA: 0x18FD710 Offset: 0x18FBD10 VA: 0x1818FD710
	public static int get_particleRaycastBudget() { }

	// RVA: 0x18FD800 Offset: 0x18FBE00 VA: 0x1818FD800
	public static bool get_softVegetation() { }

	// RVA: 0x18FD8C0 Offset: 0x18FBEC0 VA: 0x1818FD8C0
	public static int get_vSyncCount() { }

	// RVA: 0x18FDAF0 Offset: 0x18FC0F0 VA: 0x1818FDAF0
	public static void set_vSyncCount(int value) { }

	// RVA: 0x18FD620 Offset: 0x18FBC20 VA: 0x1818FD620
	public static int get_antiAliasing() { }

	// RVA: 0x18FD930 Offset: 0x18FBF30 VA: 0x1818FD930
	public static void set_antiAliasing(int value) { }

	// RVA: 0x18FD770 Offset: 0x18FBD70 VA: 0x1818FD770
	public static bool get_realtimeReflectionProbes() { }

	// RVA: 0x18FD830 Offset: 0x18FBE30 VA: 0x1818FD830
	public static bool get_streamingMipmapsActive() { }

	// RVA: 0x18FDA70 Offset: 0x18FC070 VA: 0x1818FDA70
	public static void set_streamingMipmapsActive(bool value) { }

	// RVA: 0x18FD890 Offset: 0x18FBE90 VA: 0x1818FD890
	public static float get_streamingMipmapsMemoryBudget() { }

	// RVA: 0x18FDAB0 Offset: 0x18FC0B0 VA: 0x1818FDAB0
	public static void set_streamingMipmapsMemoryBudget(float value) { }

	// RVA: 0x18FD860 Offset: 0x18FBE60 VA: 0x1818FD860
	public static int get_streamingMipmapsMaxLevelReduction() { }

	// RVA: 0x18FD6B0 Offset: 0x18FBCB0 VA: 0x1818FD6B0
	public static int get_maxQueuedFrames() { }

	// RVA: 0x18FD9B0 Offset: 0x18FBFB0 VA: 0x1818FD9B0
	public static void set_maxQueuedFrames(int value) { }

	[NativeNameAttribute] // RVA: 0x8D1E0 Offset: 0x8C5E0 VA: 0x18008D1E0
	// RVA: 0x18FD550 Offset: 0x18FBB50 VA: 0x1818FD550
	public static int GetQualityLevel() { }

	[NativeNameAttribute] // RVA: 0x8D240 Offset: 0x8C640 VA: 0x18008D240
	// RVA: 0x18FD580 Offset: 0x18FBB80 VA: 0x1818FD580
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	[NativeNameAttribute] // RVA: 0x8D3C0 Offset: 0x8C7C0 VA: 0x18008D3C0
	[StaticAccessorAttribute] // RVA: 0x8D3C0 Offset: 0x8C7C0 VA: 0x18008D3C0
	// RVA: 0x18FD5C0 Offset: 0x18FBBC0 VA: 0x1818FD5C0
	public static ColorSpace get_activeColorSpace() { }

}

