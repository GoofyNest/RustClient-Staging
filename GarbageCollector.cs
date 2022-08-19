public static class GarbageCollector // TypeDefIndex: 3650
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static Action<GarbageCollector.Mode> GCModeChanged; // 0x147D0

	// Properties
	public static GarbageCollector.Mode GCMode { get; set; }
	public static bool isIncremental { get; }
	public static ulong incrementalTimeSliceNanoseconds { get; set; }

	// Methods

	// RVA: 0x19A9FE0 Offset: 0x19A85E0 VA: 0x1819A9FE0
	public static GarbageCollector.Mode get_GCMode() { }

	// RVA: 0x19AA0B0 Offset: 0x19A86B0 VA: 0x1819AA0B0
	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x19AA010 Offset: 0x19A8610 VA: 0x1819AA010
	private static void SetMode(GarbageCollector.Mode mode) { }

	// RVA: 0x19A9FE0 Offset: 0x19A85E0 VA: 0x1819A9FE0
	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] // RVA: 0xE1380 Offset: 0xE0780 VA: 0x1800E1380
	// RVA: 0x19AA080 Offset: 0x19A8680 VA: 0x1819AA080
	public static bool get_isIncremental() { }

	// RVA: 0x19AA050 Offset: 0x19A8650 VA: 0x1819AA050
	public static ulong get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x19AA150 Offset: 0x19A8750 VA: 0x1819AA150
	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }

}

public enum GarbageCollector.Mode // TypeDefIndex: 3651
{	// Fields
	public int value__; // 0x0
	public const GarbageCollector.Mode Disabled = 0;
	public const GarbageCollector.Mode Enabled = 1;

}

