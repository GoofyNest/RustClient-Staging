public static class Performance // TypeDefIndex: 6208
{	// Fields
	public static Func<int> GetMemoryUsage; // 0x0
	public static Func<int> GetGarbageCollections; // 0x8
	private static Stopwatch Stopwatch; // 0x10
	private static int frames; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static int <FrameCountLastSecond>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static int <MemoryUsage>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static int <GarbageCollections>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static float <SecondsSinceLastConnection>k__BackingField; // 0x28
	public static int TargetFrameRate; // 0x2C
	private static int[] frameBuckets; // 0x30
	private static float[] frameBucketFractions; // 0x38

	// Properties
	public static FrameRateCategory FrameRateCategory { get; }
	public static int FrameCountLastSecond { get; set; }
	public static double AvgFrameTimeLastSecond { get; }
	public static int MemoryUsage { get; set; }
	public static int GarbageCollections { get; set; }
	public static float SecondsSinceLastConnection { get; set; }
	public static int[] CategorizedFrameCount { get; }

	// Methods

	// RVA: 0x14B7480 Offset: 0x14B5A80 VA: 0x1814B7480
	public static FrameRateCategory get_FrameRateCategory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B73C0 Offset: 0x14B59C0 VA: 0x1814B73C0
	public static int get_FrameCountLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B77B0 Offset: 0x14B5DB0 VA: 0x1814B77B0
	private static void set_FrameCountLastSecond(int value) { }

	// RVA: 0x14B7240 Offset: 0x14B5840 VA: 0x1814B7240
	public static double get_AvgFrameTimeLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B76F0 Offset: 0x14B5CF0 VA: 0x1814B76F0
	public static int get_MemoryUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B7870 Offset: 0x14B5E70 VA: 0x1814B7870
	private static void set_MemoryUsage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B7690 Offset: 0x14B5C90 VA: 0x1814B7690
	public static int get_GarbageCollections() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B7810 Offset: 0x14B5E10 VA: 0x1814B7810
	private static void set_GarbageCollections(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B7750 Offset: 0x14B5D50 VA: 0x1814B7750
	public static float get_SecondsSinceLastConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B78D0 Offset: 0x14B5ED0 VA: 0x1814B78D0
	private static void set_SecondsSinceLastConnection(float value) { }

	// RVA: 0x14B7360 Offset: 0x14B5960 VA: 0x1814B7360
	public static int[] get_CategorizedFrameCount() { }

	// RVA: 0x14B69F0 Offset: 0x14B4FF0 VA: 0x1814B69F0
	internal static void Frame() { }

	// RVA: 0x14B6C40 Offset: 0x14B5240 VA: 0x1814B6C40
	private static void OneSecond(double timelapse) { }

	// RVA: 0x14B6870 Offset: 0x14B4E70 VA: 0x1814B6870
	private static FrameRateCategory CategorizeFrameRate(int i) { }

	// RVA: 0x14B6F10 Offset: 0x14B5510 VA: 0x1814B6F10
	private static void UpdateFrameBuckets() { }

	// RVA: 0x14B6B20 Offset: 0x14B5120 VA: 0x1814B6B20
	public static int GetFrameCount(FrameRateCategory category) { }

	// RVA: 0x14B6BB0 Offset: 0x14B51B0 VA: 0x1814B6BB0
	public static float GetFrameFraction(FrameRateCategory category) { }

	// RVA: 0x14B7120 Offset: 0x14B5720 VA: 0x1814B7120
	private static void .cctor() { }

}

public class Performance : SingletonComponent<Performance> // TypeDefIndex: 9318
{	// Fields
	public static Performance.Tick current; // 0x0
	public static Performance.Tick report; // 0x50
	public const int FrameHistoryCount = 1000;
	private const int HistoryLength = 60;
	private static long cycles; // 0xA0
	private static int[] frameRateHistory; // 0xA8
	private static float[] frameTimeHistory; // 0xB0
	private static int[] frameTimes; // 0xB8
	private int frames; // 0x18
	private float time; // 0x1C

	// Methods

	// RVA: 0x86E820 Offset: 0x86CE20 VA: 0x18086E820
	private void Update() { }

	// RVA: 0x86E680 Offset: 0x86CC80 VA: 0x18086E680
	public List<int> GetFrameTimes(int requestedStart, int maxCount, out int startIndex) { }

	// RVA: 0x86DF80 Offset: 0x86C580 VA: 0x18086DF80
	private void FPSTimer() { }

	// RVA: 0x86DCF0 Offset: 0x86C2F0 VA: 0x18086DCF0
	private float AverageFrameRate() { }

	// RVA: 0x86DE20 Offset: 0x86C420 VA: 0x18086DE20
	private float AverageFrameTime() { }

	// RVA: 0x86EA60 Offset: 0x86D060 VA: 0x18086EA60
	public void .ctor() { }

	// RVA: 0x86E990 Offset: 0x86CF90 VA: 0x18086E990
	private static void .cctor() { }

}

public struct Performance.Tick // TypeDefIndex: 9319
{	// Fields
	public int frameID; // 0x0
	public int frameRate; // 0x4
	public float frameTime; // 0x8
	public float frameRateAverage; // 0xC
	public float frameTimeAverage; // 0x10
	public long memoryUsageSystem; // 0x18
	public long memoryAllocations; // 0x20
	public long memoryCollections; // 0x28
	public long loadBalancerTasks; // 0x30
	public long invokeHandlerTasks; // 0x38
	public long workshopSkinsQueued; // 0x40
	public int ping; // 0x48
	public bool gcTriggered; // 0x4C

}

private struct Performance.LagSpike // TypeDefIndex: 9320
{	// Fields
	public int Index; // 0x0
	public int Time; // 0x4

}
