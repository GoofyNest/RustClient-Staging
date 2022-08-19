public class LoadBalancer : SingletonComponent<LoadBalancer> // TypeDefIndex: 11311
{	// Fields
	public static bool Paused; // 0x0
	private const float MinMilliseconds = 1;
	private const float MaxMilliseconds = 100;
	private const int MinBacklog = 1000;
	private const int MaxBacklog = 100000;
	private Queue<DeferredAction>[] queues; // 0x18
	private Stopwatch watch; // 0x20

	// Methods

	// RVA: 0x4F7E10 Offset: 0x4F6410 VA: 0x1804F7E10
	protected void LateUpdate() { }

	// RVA: 0x4F7B10 Offset: 0x4F6110 VA: 0x1804F7B10
	public static int Count() { }

	// RVA: 0x4F8150 Offset: 0x4F6750 VA: 0x1804F8150
	public static void ProcessAll() { }

	// RVA: 0x4F7CD0 Offset: 0x4F62D0 VA: 0x1804F7CD0
	public static void Enqueue(DeferredAction action) { }

	// RVA: 0x4F7C30 Offset: 0x4F6230 VA: 0x1804F7C30
	private static void CreateInstance() { }

	// RVA: 0x4F82B0 Offset: 0x4F68B0 VA: 0x1804F82B0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

