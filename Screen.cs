public sealed class Screen // TypeDefIndex: 3386
{	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static Resolution currentResolution { get; }
	public static bool fullScreen { get; }
	public static Resolution[] resolutions { get; }


	[NativeMethodAttribute] // RVA: 0x83970 Offset: 0x82D70 VA: 0x180083970
	public static int get_width() { }

	[NativeMethodAttribute] // RVA: 0x83B00 Offset: 0x82F00 VA: 0x180083B00
	public static int get_height() { }

	[NativeNameAttribute] // RVA: 0x83B80 Offset: 0x82F80 VA: 0x180083B80
	public static float get_dpi() { }

	public static Resolution get_currentResolution() { }

	[NativeNameAttribute] // RVA: 0x83CE0 Offset: 0x830E0 VA: 0x180083CE0
	public static bool get_fullScreen() { }

	[NativeNameAttribute] // RVA: 0x83E10 Offset: 0x83210 VA: 0x180083E10
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[FreeFunctionAttribute] // RVA: 0x83EE0 Offset: 0x832E0 VA: 0x180083EE0
	public static Resolution[] get_resolutions() { }

	private static void get_currentResolution_Injected(out Resolution ret) { }

}

