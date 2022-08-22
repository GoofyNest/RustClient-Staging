public static class GarbageCollector // TypeDefIndex: 3650
{	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<GarbageCollector.Mode> GCModeChanged; // 0x2B10510

	public static GarbageCollector.Mode GCMode { get; set; }
	public static bool isIncremental { get; }
	public static ulong incrementalTimeSliceNanoseconds { get; set; }


	public static GarbageCollector.Mode get_GCMode() { }

	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	private static void SetMode(GarbageCollector.Mode mode) { }

	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] // RVA: 0xE13E0 Offset: 0xE07E0 VA: 0x1800E13E0
	public static bool get_isIncremental() { }

	public static ulong get_incrementalTimeSliceNanoseconds() { }

	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }

}

public enum GarbageCollector.Mode // TypeDefIndex: 3651
{	public int value__; // 0x0
	public const GarbageCollector.Mode Disabled = 0;
	public const GarbageCollector.Mode Enabled = 1;

}

