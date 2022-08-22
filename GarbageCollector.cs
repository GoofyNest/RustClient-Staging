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

	// RVA: 0x19AA260 Offset: 0x19A8860 VA: 0x1819AA260
	public static GarbageCollector.Mode get_GCMode() { }

	// RVA: 0x19AA330 Offset: 0x19A8930 VA: 0x1819AA330
	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x19AA290 Offset: 0x19A8890 VA: 0x1819AA290
	private static void SetMode(GarbageCollector.Mode mode) { }

	// RVA: 0x19AA260 Offset: 0x19A8860 VA: 0x1819AA260
	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] // RVA: 0xE13E0 Offset: 0xE07E0 VA: 0x1800E13E0
	// RVA: 0x19AA300 Offset: 0x19A8900 VA: 0x1819AA300
	public static bool get_isIncremental() { }

	// RVA: 0x19AA2D0 Offset: 0x19A88D0 VA: 0x1819AA2D0
	public static ulong get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x19AA3D0 Offset: 0x19A89D0 VA: 0x1819AA3D0
	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }

}

public enum GarbageCollector.Mode // TypeDefIndex: 3651
{	// Fields
	public int value__; // 0x0
	public const GarbageCollector.Mode Disabled = 0;
	public const GarbageCollector.Mode Enabled = 1;

}

