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
	// RVA: 0x19B4F20 Offset: 0x19B3520 VA: 0x1819B4F20
	public static int get_width() { }

	[NativeMethodAttribute] // RVA: 0x839F0 Offset: 0x82DF0 VA: 0x1800839F0
	// RVA: 0x19B4EC0 Offset: 0x19B34C0 VA: 0x1819B4EC0
	public static int get_height() { }

	[NativeNameAttribute] // RVA: 0x83A70 Offset: 0x82E70 VA: 0x180083A70
	// RVA: 0x19B4E60 Offset: 0x19B3460 VA: 0x1819B4E60
	public static float get_dpi() { }

	// RVA: 0x19B4E20 Offset: 0x19B3420 VA: 0x1819B4E20
	public static Resolution get_currentResolution() { }

	[NativeNameAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x19B4E90 Offset: 0x19B3490 VA: 0x1819B4E90
	public static bool get_fullScreen() { }

	[NativeNameAttribute] // RVA: 0x83D40 Offset: 0x83140 VA: 0x180083D40
	// RVA: 0x19B4D20 Offset: 0x19B3320 VA: 0x1819B4D20
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

	// RVA: 0x19B4D80 Offset: 0x19B3380 VA: 0x1819B4D80
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[FreeFunctionAttribute] // RVA: 0x83E90 Offset: 0x83290 VA: 0x180083E90
	// RVA: 0x19B4EF0 Offset: 0x19B34F0 VA: 0x1819B4EF0
	public static Resolution[] get_resolutions() { }

	// RVA: 0x19B4DE0 Offset: 0x19B33E0 VA: 0x1819B4DE0
	private static void get_currentResolution_Injected(out Resolution ret) { }

}

