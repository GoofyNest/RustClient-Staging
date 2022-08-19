public sealed class Screen // TypeDefIndex: 3386
{	// Properties
	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static Resolution currentResolution { get; }
	public static bool fullScreen { get; }
	public static Resolution[] resolutions { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x83830 Offset: 0x82C30 VA: 0x180083830
	// RVA: 0x19B4CA0 Offset: 0x19B32A0 VA: 0x1819B4CA0
	public static int get_width() { }

	[NativeMethodAttribute] // RVA: 0x83980 Offset: 0x82D80 VA: 0x180083980
	// RVA: 0x19B4C40 Offset: 0x19B3240 VA: 0x1819B4C40
	public static int get_height() { }

	[NativeNameAttribute] // RVA: 0x83A00 Offset: 0x82E00 VA: 0x180083A00
	// RVA: 0x19B4BE0 Offset: 0x19B31E0 VA: 0x1819B4BE0
	public static float get_dpi() { }

	// RVA: 0x19B4BA0 Offset: 0x19B31A0 VA: 0x1819B4BA0
	public static Resolution get_currentResolution() { }

	[NativeNameAttribute] // RVA: 0x83B70 Offset: 0x82F70 VA: 0x180083B70
	// RVA: 0x19B4C10 Offset: 0x19B3210 VA: 0x1819B4C10
	public static bool get_fullScreen() { }

	[NativeNameAttribute] // RVA: 0x83C60 Offset: 0x83060 VA: 0x180083C60
	// RVA: 0x19B4AA0 Offset: 0x19B30A0 VA: 0x1819B4AA0
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

	// RVA: 0x19B4B00 Offset: 0x19B3100 VA: 0x1819B4B00
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[FreeFunctionAttribute] // RVA: 0x83E20 Offset: 0x83220 VA: 0x180083E20
	// RVA: 0x19B4C70 Offset: 0x19B3270 VA: 0x1819B4C70
	public static Resolution[] get_resolutions() { }

	// RVA: 0x19B4B60 Offset: 0x19B3160 VA: 0x1819B4B60
	private static void get_currentResolution_Injected(out Resolution ret) { }

}

