public static class Noise3D // TypeDefIndex: 11555
{	private static bool ms_IsSupportedChecked; // 0x0
	private static bool ms_IsSupported; // 0x1
	private static Texture3D ms_NoiseTexture; // 0x8
	private const HideFlags kHideFlags = 61;
	private const int kMinShaderLevel = 35;

	public static bool isSupported { get; }
	public static bool isProperlyLoaded { get; }
	public static string isNotSupportedString { get; }


	public static bool get_isSupported() { }

	public static bool get_isProperlyLoaded() { }

	public static string get_isNotSupportedString() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x97E10 Offset: 0x97210 VA: 0x180097E10
	private static void OnStartUp() { }

	public static void LoadIfNeeded() { }

	private static Texture3D LoadTexture3D(TextAsset textData, int size) { }

	private static void .cctor() { }

}

