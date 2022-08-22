public static class Performance // TypeDefIndex: 6208
{	// Fields
	public static Func<int> GetMemoryUsage; // 0x0
	public static Func<int> GetGarbageCollections; // 0x8
	private static Stopwatch Stopwatch; // 0x10
	private static int frames; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static int <FrameCountLastSecond>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static int <MemoryUsage>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static int <GarbageCollections>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x14B7740 Offset: 0x14B5D40 VA: 0x1814B7740
	public static FrameRateCategory get_FrameRateCategory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B7680 Offset: 0x14B5C80 VA: 0x1814B7680
	public static int get_FrameCountLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B7A70 Offset: 0x14B6070 VA: 0x1814B7A70
	private static void set_FrameCountLastSecond(int value) { }

	// RVA: 0x14B7500 Offset: 0x14B5B00 VA: 0x1814B7500
	public static double get_AvgFrameTimeLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B79B0 Offset: 0x14B5FB0 VA: 0x1814B79B0
	public static int get_MemoryUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B7B30 Offset: 0x14B6130 VA: 0x1814B7B30
	private static void set_MemoryUsage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B7950 Offset: 0x14B5F50 VA: 0x1814B7950
	public static int get_GarbageCollections() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B7AD0 Offset: 0x14B60D0 VA: 0x1814B7AD0
	private static void set_GarbageCollections(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B7A10 Offset: 0x14B6010 VA: 0x1814B7A10
	public static float get_SecondsSinceLastConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B7B90 Offset: 0x14B6190 VA: 0x1814B7B90
	private static void set_SecondsSinceLastConnection(float value) { }

	// RVA: 0x14B7620 Offset: 0x14B5C20 VA: 0x1814B7620
	public static int[] get_CategorizedFrameCount() { }

	// RVA: 0x14B6CB0 Offset: 0x14B52B0 VA: 0x1814B6CB0
	internal static void Frame() { }

	// RVA: 0x14B6F00 Offset: 0x14B5500 VA: 0x1814B6F00
	private static void OneSecond(double timelapse) { }

	// RVA: 0x14B6B30 Offset: 0x14B5130 VA: 0x1814B6B30
	private static FrameRateCategory CategorizeFrameRate(int i) { }

	// RVA: 0x14B71D0 Offset: 0x14B57D0 VA: 0x1814B71D0
	private static void UpdateFrameBuckets() { }

	// RVA: 0x14B6DE0 Offset: 0x14B53E0 VA: 0x1814B6DE0
	public static int GetFrameCount(FrameRateCategory category) { }

	// RVA: 0x14B6E70 Offset: 0x14B5470 VA: 0x1814B6E70
	public static float GetFrameFraction(FrameRateCategory category) { }

	// RVA: 0x14B73E0 Offset: 0x14B59E0 VA: 0x1814B73E0
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

	// RVA: 0x86E930 Offset: 0x86CF30 VA: 0x18086E930
	private void Update() { }

	// RVA: 0x86E790 Offset: 0x86CD90 VA: 0x18086E790
	public List<int> GetFrameTimes(int requestedStart, int maxCount, out int startIndex) { }

	// RVA: 0x86E090 Offset: 0x86C690 VA: 0x18086E090
	private void FPSTimer() { }

	// RVA: 0x86DE00 Offset: 0x86C400 VA: 0x18086DE00
	private float AverageFrameRate() { }

	// RVA: 0x86DF30 Offset: 0x86C530 VA: 0x18086DF30
	private float AverageFrameTime() { }

	// RVA: 0x86EB70 Offset: 0x86D170 VA: 0x18086EB70
	public void .ctor() { }

	// RVA: 0x86EAA0 Offset: 0x86D0A0 VA: 0x18086EAA0
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

