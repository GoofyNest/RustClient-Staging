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
	// RVA: 0x19B4C60 Offset: 0x19B3260 VA: 0x1819B4C60
	public static int get_width() { }

	[NativeMethodAttribute] // RVA: 0x839F0 Offset: 0x82DF0 VA: 0x1800839F0
	// RVA: 0x19B4C00 Offset: 0x19B3200 VA: 0x1819B4C00
	public static int get_height() { }

	[NativeNameAttribute] // RVA: 0x83A70 Offset: 0x82E70 VA: 0x180083A70
	// RVA: 0x19B4BA0 Offset: 0x19B31A0 VA: 0x1819B4BA0
	public static float get_dpi() { }

	// RVA: 0x19B4B60 Offset: 0x19B3160 VA: 0x1819B4B60
	public static Resolution get_currentResolution() { }

	[NativeNameAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x19B4BD0 Offset: 0x19B31D0 VA: 0x1819B4BD0
	public static bool get_fullScreen() { }

	[NativeNameAttribute] // RVA: 0x83D40 Offset: 0x83140 VA: 0x180083D40
	// RVA: 0x19B4A60 Offset: 0x19B3060 VA: 0x1819B4A60
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

	// RVA: 0x19B4AC0 Offset: 0x19B30C0 VA: 0x1819B4AC0
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[FreeFunctionAttribute] // RVA: 0x83E90 Offset: 0x83290 VA: 0x180083E90
	// RVA: 0x19B4C30 Offset: 0x19B3230 VA: 0x1819B4C30
	public static Resolution[] get_resolutions() { }

	// RVA: 0x19B4B20 Offset: 0x19B3120 VA: 0x1819B4B20
	private static void get_currentResolution_Injected(out Resolution ret) { }

}

