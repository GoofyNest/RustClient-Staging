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

	// RVA: 0xAC9750 Offset: 0xAC7D50 VA: 0x180AC9750
	public static bool get_isSupported() { }

	// RVA: 0xAC96C0 Offset: 0xAC7CC0 VA: 0x180AC96C0
	public static bool get_isProperlyLoaded() { }

	// RVA: 0xAC9640 Offset: 0xAC7C40 VA: 0x180AC9640
	public static string get_isNotSupportedString() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x98480 Offset: 0x97880 VA: 0x180098480
	// RVA: 0xAC95F0 Offset: 0xAC7BF0 VA: 0x180AC95F0
	private static void OnStartUp() { }

	// RVA: 0xAC8E70 Offset: 0xAC7470 VA: 0x180AC8E70
	public static void LoadIfNeeded() { }

	// RVA: 0xAC92A0 Offset: 0xAC78A0 VA: 0x180AC92A0
	private static Texture3D LoadTexture3D(TextAsset textData, int size) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

