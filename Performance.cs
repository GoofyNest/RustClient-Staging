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

	// RVA: 0x14B6810 Offset: 0x14B4E10 VA: 0x1814B6810
	public static FrameRateCategory get_FrameRateCategory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B6750 Offset: 0x14B4D50 VA: 0x1814B6750
	public static int get_FrameCountLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B6B40 Offset: 0x14B5140 VA: 0x1814B6B40
	private static void set_FrameCountLastSecond(int value) { }

	// RVA: 0x14B65D0 Offset: 0x14B4BD0 VA: 0x1814B65D0
	public static double get_AvgFrameTimeLastSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B6A80 Offset: 0x14B5080 VA: 0x1814B6A80
	public static int get_MemoryUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B6C00 Offset: 0x14B5200 VA: 0x1814B6C00
	private static void set_MemoryUsage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B6A20 Offset: 0x14B5020 VA: 0x1814B6A20
	public static int get_GarbageCollections() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B6BA0 Offset: 0x14B51A0 VA: 0x1814B6BA0
	private static void set_GarbageCollections(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B6AE0 Offset: 0x14B50E0 VA: 0x1814B6AE0
	public static float get_SecondsSinceLastConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B6C60 Offset: 0x14B5260 VA: 0x1814B6C60
	private static void set_SecondsSinceLastConnection(float value) { }

	// RVA: 0x14B66F0 Offset: 0x14B4CF0 VA: 0x1814B66F0
	public static int[] get_CategorizedFrameCount() { }

	// RVA: 0x14B5D80 Offset: 0x14B4380 VA: 0x1814B5D80
	internal static void Frame() { }

	// RVA: 0x14B5FD0 Offset: 0x14B45D0 VA: 0x1814B5FD0
	private static void OneSecond(double timelapse) { }

	// RVA: 0x14B5C00 Offset: 0x14B4200 VA: 0x1814B5C00
	private static FrameRateCategory CategorizeFrameRate(int i) { }

	// RVA: 0x14B62A0 Offset: 0x14B48A0 VA: 0x1814B62A0
	private static void UpdateFrameBuckets() { }

	// RVA: 0x14B5EB0 Offset: 0x14B44B0 VA: 0x1814B5EB0
	public static int GetFrameCount(FrameRateCategory category) { }

	// RVA: 0x14B5F40 Offset: 0x14B4540 VA: 0x1814B5F40
	public static float GetFrameFraction(FrameRateCategory category) { }

	// RVA: 0x14B64B0 Offset: 0x14B4AB0 VA: 0x1814B64B0
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

	// RVA: 0x88A090 Offset: 0x888690 VA: 0x18088A090
	private void Update() { }

	// RVA: 0x889EF0 Offset: 0x8884F0 VA: 0x180889EF0
	public List<int> GetFrameTimes(int requestedStart, int maxCount, out int startIndex) { }

	// RVA: 0x8897F0 Offset: 0x887DF0 VA: 0x1808897F0
	private void FPSTimer() { }

	// RVA: 0x889560 Offset: 0x887B60 VA: 0x180889560
	private float AverageFrameRate() { }

	// RVA: 0x889690 Offset: 0x887C90 VA: 0x180889690
	private float AverageFrameTime() { }

	// RVA: 0x88A2D0 Offset: 0x8888D0 VA: 0x18088A2D0
	public void .ctor() { }

	// RVA: 0x88A200 Offset: 0x888800 VA: 0x18088A200
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

