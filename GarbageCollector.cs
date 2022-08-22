public static class GarbageCollector // TypeDefIndex: 3650
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<GarbageCollector.Mode> GCModeChanged; // 0x147D0

	// Properties
	public static GarbageCollector.Mode GCMode { get; set; }
	public static bool isIncremental { get; }
	public static ulong incrementalTimeSliceNanoseconds { get; set; }

	// Methods

	// RVA: 0x19A9FA0 Offset: 0x19A85A0 VA: 0x1819A9FA0
	public static GarbageCollector.Mode get_GCMode() { }

	// RVA: 0x19AA070 Offset: 0x19A8670 VA: 0x1819AA070
	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x19A9FD0 Offset: 0x19A85D0 VA: 0x1819A9FD0
	private static void SetMode(GarbageCollector.Mode mode) { }

	// RVA: 0x19A9FA0 Offset: 0x19A85A0 VA: 0x1819A9FA0
	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] // RVA: 0xE13E0 Offset: 0xE07E0 VA: 0x1800E13E0
	// RVA: 0x19AA040 Offset: 0x19A8640 VA: 0x1819AA040
	public static bool get_isIncremental() { }

	// RVA: 0x19AA010 Offset: 0x19A8610 VA: 0x1819AA010
	public static ulong get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x19AA110 Offset: 0x19A8710 VA: 0x1819AA110
	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }

}

public enum GarbageCollector.Mode // TypeDefIndex: 3651
{	// Fields
	public int value__; // 0x0
	public const GarbageCollector.Mode Disabled = 0;
	public const GarbageCollector.Mode Enabled = 1;

}

