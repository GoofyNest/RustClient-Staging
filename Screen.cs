public sealed class Screen // TypeDefIndex: 3386
{	// Properties
	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static Resolution currentResolution { get; }
	public static bool fullScreen { get; }
	public static Resolution[] resolutions { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x838A0 Offset: 0x82CA0 VA: 0x1800838A0
	// RVA: 0x19A2320 Offset: 0x19A0920 VA: 0x1819A2320
	public static int get_width() { }

	[NativeMethodAttribute] // RVA: 0x839F0 Offset: 0x82DF0 VA: 0x1800839F0
	// RVA: 0x19A22C0 Offset: 0x19A08C0 VA: 0x1819A22C0
	public static int get_height() { }

	[NativeNameAttribute] // RVA: 0x83A70 Offset: 0x82E70 VA: 0x180083A70
	// RVA: 0x19A2260 Offset: 0x19A0860 VA: 0x1819A2260
	public static float get_dpi() { }

	// RVA: 0x19A2220 Offset: 0x19A0820 VA: 0x1819A2220
	public static Resolution get_currentResolution() { }

	[NativeNameAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x19A2290 Offset: 0x19A0890 VA: 0x1819A2290
	public static bool get_fullScreen() { }

	[NativeNameAttribute] // RVA: 0x83D40 Offset: 0x83140 VA: 0x180083D40
	// RVA: 0x19A2120 Offset: 0x19A0720 VA: 0x1819A2120
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

	// RVA: 0x19A2180 Offset: 0x19A0780 VA: 0x1819A2180
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[FreeFunctionAttribute] // RVA: 0x83E90 Offset: 0x83290 VA: 0x180083E90
	// RVA: 0x19A22F0 Offset: 0x19A08F0 VA: 0x1819A22F0
	public static Resolution[] get_resolutions() { }

	// RVA: 0x19A21E0 Offset: 0x19A07E0 VA: 0x1819A21E0
	private static void get_currentResolution_Injected(out Resolution ret) { }

}

