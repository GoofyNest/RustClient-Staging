public class Reflection : ConsoleSystem // TypeDefIndex: 11958
{	// Fields
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool interiors; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool forests; // 0x1

	// Properties
	[ClientVar] // RVA: 0x89230 Offset: 0x88630 VA: 0x180089230
	public static int resolution { get; set; }
	[ClientVar] // RVA: 0x89230 Offset: 0x88630 VA: 0x180089230
	public static float updateinterval { get; set; }
	[ClientVar] // RVA: 0x89230 Offset: 0x88630 VA: 0x180089230
	public static int timeslicing { get; set; }

	// Methods

	// RVA: 0x36A5F0 Offset: 0x368BF0 VA: 0x18036A5F0
	public static int get_resolution() { }

	// RVA: 0x36A740 Offset: 0x368D40 VA: 0x18036A740
	public static void set_resolution(int value) { }

	// RVA: 0x36A6E0 Offset: 0x368CE0 VA: 0x18036A6E0
	public static float get_updateinterval() { }

	// RVA: 0x36A8C0 Offset: 0x368EC0 VA: 0x18036A8C0
	public static void set_updateinterval(float value) { }

	// RVA: 0x36A650 Offset: 0x368C50 VA: 0x18036A650
	public static int get_timeslicing() { }

	// RVA: 0x36A7F0 Offset: 0x368DF0 VA: 0x18036A7F0
	public static void set_timeslicing(int value) { }

	// RVA: 0x36A550 Offset: 0x368B50 VA: 0x18036A550
	private static ReflectionProbeTimeSlicingMode TimeSlicingFromInt(int i) { }

	// RVA: 0x36A570 Offset: 0x368B70 VA: 0x18036A570
	private static int TimeSlicingToInt(ReflectionProbeTimeSlicingMode mode) { }

	// RVA: 0x36A590 Offset: 0x368B90 VA: 0x18036A590
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

