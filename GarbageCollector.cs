public static class GarbageCollector // TypeDefIndex: 3650
{	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private static Action<GarbageCollector.Mode> GCModeChanged; // 0x13A80

	public static GarbageCollector.Mode GCMode { get; set; }
	public static bool isIncremental { get; }
	public static ulong incrementalTimeSliceNanoseconds { get; set; }


	public static GarbageCollector.Mode get_GCMode() { }

	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] // RVA: 0x80C30 Offset: 0x80030 VA: 0x180080C30
	private static void SetMode(GarbageCollector.Mode mode) { }

	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] // RVA: 0xE1500 Offset: 0xE0900 VA: 0x1800E1500
	public static bool get_isIncremental() { }

	public static ulong get_incrementalTimeSliceNanoseconds() { }

	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }

}

public enum GarbageCollector.Mode // TypeDefIndex: 3651
{	public int value__; // 0x0
	public const GarbageCollector.Mode Disabled = 0;
	public const GarbageCollector.Mode Enabled = 1;

}

