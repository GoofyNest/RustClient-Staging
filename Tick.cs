public static class Tick // TypeDefIndex: 6603
{	// Fields
	private static Tick.Entry.List Timed; // 0x0
	private static Tick.Entry.List Update; // 0x8
	private static Tick.Entry.List Late; // 0x10
	private static List<Object> RemoveList; // 0x18

	// Methods

	// RVA: 0x1BAE5A0 Offset: 0x1BACBA0 VA: 0x181BAE5A0
	public static void AddTimed(Object obj, float minDelay, float maxDelay, Action action, string DebugName) { }

	// RVA: 0x1BAE710 Offset: 0x1BACD10 VA: 0x181BAE710
	public static void Add(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BAE450 Offset: 0x1BACA50 VA: 0x181BAE450
	public static void AddLateUpdate(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BAEB30 Offset: 0x1BAD130 VA: 0x181BAEB30
	public static void RemoveAll(Object obj) { }

	// RVA: 0x1BAE860 Offset: 0x1BACE60 VA: 0x181BAE860
	private static void Cleanup() { }

	// RVA: 0x1BAEAA0 Offset: 0x1BAD0A0 VA: 0x181BAEAA0
	internal static void OnFrame() { }

	// RVA: 0x1BAEA30 Offset: 0x1BAD030 VA: 0x181BAEA30
	internal static void OnFrameLate() { }

	// RVA: 0x1BAEBB0 Offset: 0x1BAD1B0 VA: 0x181BAEBB0
	private static void .cctor() { }

}

public struct Tick.Entry // TypeDefIndex: 6604
{	// Fields
	public Object TargetObject; // 0x0
	public float MinDelay; // 0x8
	public float RandDelay; // 0xC
	public float NextCall; // 0x10
	public Action Function; // 0x18
	private bool Errored; // 0x20
	public string DebugName; // 0x28

}

public class Tick.Entry.List : List<Tick.Entry> // TypeDefIndex: 6605
{	// Methods

	// RVA: 0x1BA4520 Offset: 0x1BA2B20 VA: 0x181BA4520
	public void Remove(Object obj) { }

	// RVA: 0x1BA4820 Offset: 0x1BA2E20 VA: 0x181BA4820
	internal void Tick() { }

	// RVA: 0x1BA4620 Offset: 0x1BA2C20 VA: 0x181BA4620
	internal void TickTimed() { }

	// RVA: 0x1BA4950 Offset: 0x1BA2F50 VA: 0x181BA4950
	public void .ctor() { }

}

