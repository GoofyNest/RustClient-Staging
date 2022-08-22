public static class GarbageCollector // TypeDefIndex: 3650
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<GarbageCollector.Mode> GCModeChanged; // 0x2B10510

	// Properties
	public static GarbageCollector.Mode GCMode { get; set; }
	public static bool isIncremental { get; }
	public static ulong incrementalTimeSliceNanoseconds { get; set; }

	// Methods

	// RVA: 0x1997660 Offset: 0x1995C60 VA: 0x181997660
	public static GarbageCollector.Mode get_GCMode() { }

	// RVA: 0x1997730 Offset: 0x1995D30 VA: 0x181997730
	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x1997690 Offset: 0x1995C90 VA: 0x181997690
	private static void SetMode(GarbageCollector.Mode mode) { }

	// RVA: 0x1997660 Offset: 0x1995C60 VA: 0x181997660
	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] // RVA: 0xE13E0 Offset: 0xE07E0 VA: 0x1800E13E0
	// RVA: 0x1997700 Offset: 0x1995D00 VA: 0x181997700
	public static bool get_isIncremental() { }

	// RVA: 0x19976D0 Offset: 0x1995CD0 VA: 0x1819976D0
	public static ulong get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x19977D0 Offset: 0x1995DD0 VA: 0x1819977D0
	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }

}

public enum GarbageCollector.Mode // TypeDefIndex: 3651
{	// Fields
	public int value__; // 0x0
	public const GarbageCollector.Mode Disabled = 0;
	public const GarbageCollector.Mode Enabled = 1;

}

