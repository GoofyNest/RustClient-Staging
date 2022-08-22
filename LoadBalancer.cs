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

	// RVA: 0x4F7DA0 Offset: 0x4F63A0 VA: 0x1804F7DA0
	protected void LateUpdate() { }

	// RVA: 0x4F7AA0 Offset: 0x4F60A0 VA: 0x1804F7AA0
	public static int Count() { }

	// RVA: 0x4F80E0 Offset: 0x4F66E0 VA: 0x1804F80E0
	public static void ProcessAll() { }

	// RVA: 0x4F7C60 Offset: 0x4F6260 VA: 0x1804F7C60
	public static void Enqueue(DeferredAction action) { }

	// RVA: 0x4F7BC0 Offset: 0x4F61C0 VA: 0x1804F7BC0
	private static void CreateInstance() { }

	// RVA: 0x4F8240 Offset: 0x4F6840 VA: 0x1804F8240
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

