public sealed class Screen // TypeDefIndex: 3386
{	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static Resolution currentResolution { get; }
	public static bool fullScreen { get; }
	public static Resolution[] resolutions { get; }


	[NativeMethodAttribute] // RVA: 0x838A0 Offset: 0x82CA0 VA: 0x1800838A0
	public static int get_width() { }

	[NativeMethodAttribute] // RVA: 0x839F0 Offset: 0x82DF0 VA: 0x1800839F0
	public static int get_height() { }

	[NativeNameAttribute] // RVA: 0x83A70 Offset: 0x82E70 VA: 0x180083A70
	public static float get_dpi() { }

	public static Resolution get_currentResolution() { }

	[NativeNameAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public static bool get_fullScreen() { }

	[NativeNameAttribute] // RVA: 0x83D40 Offset: 0x83140 VA: 0x180083D40
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[FreeFunctionAttribute] // RVA: 0x83E90 Offset: 0x83290 VA: 0x180083E90
	public static Resolution[] get_resolutions() { }

	private static void get_currentResolution_Injected(out Resolution ret) { }

}

