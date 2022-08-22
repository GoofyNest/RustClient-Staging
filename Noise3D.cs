public static class Noise3D // TypeDefIndex: 11551
{	// Fields
	private static bool ms_IsSupportedChecked; // 0x0
	private static bool ms_IsSupported; // 0x1
	private static Texture3D ms_NoiseTexture; // 0x8
	private const HideFlags kHideFlags = 61;
	private const int kMinShaderLevel = 35;

	// Properties
	public static bool isSupported { get; }
	public static bool isProperlyLoaded { get; }
	public static string isNotSupportedString { get; }

	// Methods

	// RVA: 0xAC9A10 Offset: 0xAC8010 VA: 0x180AC9A10
	public static bool get_isSupported() { }

	// RVA: 0xAC9980 Offset: 0xAC7F80 VA: 0x180AC9980
	public static bool get_isProperlyLoaded() { }

	// RVA: 0xAC9900 Offset: 0xAC7F00 VA: 0x180AC9900
	public static string get_isNotSupportedString() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x98480 Offset: 0x97880 VA: 0x180098480
	// RVA: 0xAC98B0 Offset: 0xAC7EB0 VA: 0x180AC98B0
	private static void OnStartUp() { }

	// RVA: 0xAC9130 Offset: 0xAC7730 VA: 0x180AC9130
	public static void LoadIfNeeded() { }

	// RVA: 0xAC9560 Offset: 0xAC7B60 VA: 0x180AC9560
	private static Texture3D LoadTexture3D(TextAsset textData, int size) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

