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

	// RVA: 0xAC9EE0 Offset: 0xAC84E0 VA: 0x180AC9EE0
	public static bool get_isSupported() { }

	// RVA: 0xAC9E50 Offset: 0xAC8450 VA: 0x180AC9E50
	public static bool get_isProperlyLoaded() { }

	// RVA: 0xAC9DD0 Offset: 0xAC83D0 VA: 0x180AC9DD0
	public static string get_isNotSupportedString() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x98480 Offset: 0x97880 VA: 0x180098480
	// RVA: 0xAC9D80 Offset: 0xAC8380 VA: 0x180AC9D80
	private static void OnStartUp() { }

	// RVA: 0xAC9600 Offset: 0xAC7C00 VA: 0x180AC9600
	public static void LoadIfNeeded() { }

	// RVA: 0xAC9A30 Offset: 0xAC8030 VA: 0x180AC9A30
	private static Texture3D LoadTexture3D(TextAsset textData, int size) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

