public class Lerp : ConsoleSystem // TypeDefIndex: 11942
{	[ClientVar] // RVA: 0xAAAE0 Offset: 0xA9EE0 VA: 0x1800AAAE0
	public static bool enabled; // 0x0
	private static float inertia_cur; // 0x4
	private const float inertia_def = 0;
	private const float inertia_min = 0;
	private const float inertia_max = 1;
	private static float smoothing_cur; // 0x8
	private const float smoothing_def = 0,1;
	private const float smoothing_min = 0;
	private const float smoothing_max = 1;
	private static float interpolation_cur; // 0xC
	private const float interpolation_def = 0,1;
	private const float interpolation_min = 0;
	private const float interpolation_max = 1;
	private static float extrapolation_cur; // 0x10
	private const float extrapolation_def = 1;
	private const float extrapolation_min = 0;
	private const float extrapolation_max = 2;

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debug { get; set; }
	[ClientVar] // RVA: 0xAAC70 Offset: 0xAA070 VA: 0x1800AAC70
	public static float inertia { get; set; }
	[ClientVar] // RVA: 0xAAE00 Offset: 0xAA200 VA: 0x1800AAE00
	public static float smoothing { get; set; }
	[ClientVar] // RVA: 0xAAF30 Offset: 0xAA330 VA: 0x1800AAF30
	public static float interpolation { get; set; }
	[ClientVar] // RVA: 0xAB0D0 Offset: 0xAA4D0 VA: 0x1800AB0D0
	public static float extrapolation { get; set; }
	[ClientVar] // RVA: 0xAB280 Offset: 0xAA680 VA: 0x1800AB280
	public static int timeoffsetinterval { get; set; }


	public static bool get_debug() { }

	public static void set_debug(bool value) { }

	public static float get_inertia() { }

	public static void set_inertia(float value) { }

	public static float get_smoothing() { }

	public static void set_smoothing(float value) { }

	public static float get_interpolation() { }

	public static void set_interpolation(float value) { }

	public static float get_extrapolation() { }

	public static void set_extrapolation(float value) { }

	public static int get_timeoffsetinterval() { }

	public static void set_timeoffsetinterval(int value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

