public class Lerp : ConsoleSystem // TypeDefIndex: 11942
{	// Fields
	[ClientVar] // RVA: 0xAAA40 Offset: 0xA9E40 VA: 0x1800AAA40
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

	// Properties
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool debug { get; set; }
	[ClientVar] // RVA: 0xAABA0 Offset: 0xA9FA0 VA: 0x1800AABA0
	public static float inertia { get; set; }
	[ClientVar] // RVA: 0xAAD30 Offset: 0xAA130 VA: 0x1800AAD30
	public static float smoothing { get; set; }
	[ClientVar] // RVA: 0xAADA0 Offset: 0xAA1A0 VA: 0x1800AADA0
	public static float interpolation { get; set; }
	[ClientVar] // RVA: 0xAAF30 Offset: 0xAA330 VA: 0x1800AAF30
	public static float extrapolation { get; set; }
	[ClientVar] // RVA: 0xAB110 Offset: 0xAA510 VA: 0x1800AB110
	public static int timeoffsetinterval { get; set; }

	// Methods

	// RVA: 0x365680 Offset: 0x363C80 VA: 0x180365680
	public static bool get_debug() { }

	// RVA: 0x365EC0 Offset: 0x3644C0 VA: 0x180365EC0
	public static void set_debug(bool value) { }

	// RVA: 0x3658C0 Offset: 0x363EC0 VA: 0x1803658C0
	public static float get_inertia() { }

	// RVA: 0x365FD0 Offset: 0x3645D0 VA: 0x180365FD0
	public static void set_inertia(float value) { }

	// RVA: 0x365C80 Offset: 0x364280 VA: 0x180365C80
	public static float get_smoothing() { }

	// RVA: 0x366130 Offset: 0x364730 VA: 0x180366130
	public static void set_smoothing(float value) { }

	// RVA: 0x365AA0 Offset: 0x3640A0 VA: 0x180365AA0
	public static float get_interpolation() { }

	// RVA: 0x366080 Offset: 0x364680 VA: 0x180366080
	public static void set_interpolation(float value) { }

	// RVA: 0x3656E0 Offset: 0x363CE0 VA: 0x1803656E0
	public static float get_extrapolation() { }

	// RVA: 0x365F20 Offset: 0x364520 VA: 0x180365F20
	public static void set_extrapolation(float value) { }

	// RVA: 0x365E60 Offset: 0x364460 VA: 0x180365E60
	public static int get_timeoffsetinterval() { }

	// RVA: 0x3661E0 Offset: 0x3647E0 VA: 0x1803661E0
	public static void set_timeoffsetinterval(int value) { }

	// RVA: 0x365620 Offset: 0x363C20 VA: 0x180365620
	public void .ctor() { }

	// RVA: 0x365590 Offset: 0x363B90 VA: 0x180365590
	private static void .cctor() { }

}

