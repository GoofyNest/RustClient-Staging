public class Lerp : ConsoleSystem // TypeDefIndex: 11946
{	[ClientVar] // RVA: 0xAAD40 Offset: 0xAA140 VA: 0x1800AAD40
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

	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static bool debug { get; set; }
	[ClientVar] // RVA: 0xAAF90 Offset: 0xAA390 VA: 0x1800AAF90
	public static float inertia { get; set; }
	[ClientVar] // RVA: 0xAB060 Offset: 0xAA460 VA: 0x1800AB060
	public static float smoothing { get; set; }
	[ClientVar] // RVA: 0xAB240 Offset: 0xAA640 VA: 0x1800AB240
	public static float interpolation { get; set; }
	[ClientVar] // RVA: 0xAB380 Offset: 0xAA780 VA: 0x1800AB380
	public static float extrapolation { get; set; }
	[ClientVar] // RVA: 0xAB510 Offset: 0xAA910 VA: 0x1800AB510
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

