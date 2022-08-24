public static class GarbageCollector // TypeDefIndex: 3650
{	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<GarbageCollector.Mode> GCModeChanged; // 0x14A1A

	public static GarbageCollector.Mode GCMode { get; set; }
	public static bool isIncremental { get; }
	public static ulong incrementalTimeSliceNanoseconds { get; set; }


	public static GarbageCollector.Mode get_GCMode() { }

	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] // RVA: 0x80B20 Offset: 0x7FF20 VA: 0x180080B20
	private static void SetMode(GarbageCollector.Mode mode) { }

	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] // RVA: 0xE13D0 Offset: 0xE07D0 VA: 0x1800E13D0
	public static bool get_isIncremental() { }

	public static ulong get_incrementalTimeSliceNanoseconds() { }

	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }

}

public enum GarbageCollector.Mode // TypeDefIndex: 3651
{	public int value__; // 0x0
	public const GarbageCollector.Mode Disabled = 0;
	public const GarbageCollector.Mode Enabled = 1;

}

