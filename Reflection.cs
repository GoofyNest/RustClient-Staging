public class Reflection : ConsoleSystem // TypeDefIndex: 11962
{	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static bool interiors; // 0x0
	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static bool forests; // 0x1

	[ClientVar] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	public static int resolution { get; set; }
	[ClientVar] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	public static float updateinterval { get; set; }
	[ClientVar] // RVA: 0x894B0 Offset: 0x888B0 VA: 0x1800894B0
	public static int timeslicing { get; set; }


	public static int get_resolution() { }

	public static void set_resolution(int value) { }

	public static float get_updateinterval() { }

	public static void set_updateinterval(float value) { }

	public static int get_timeslicing() { }

	public static void set_timeslicing(int value) { }

	private static ReflectionProbeTimeSlicingMode TimeSlicingFromInt(int i) { }

	private static int TimeSlicingToInt(ReflectionProbeTimeSlicingMode mode) { }

	public void .ctor() { }

	private static void .cctor() { }

}

