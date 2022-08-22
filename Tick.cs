public static class Tick // TypeDefIndex: 6603
{	// Fields
	private static Tick.Entry.List Timed; // 0x0
	private static Tick.Entry.List Update; // 0x8
	private static Tick.Entry.List Late; // 0x10
	private static List<Object> RemoveList; // 0x18

	// Methods

	// RVA: 0x1BAE6A0 Offset: 0x1BACCA0 VA: 0x181BAE6A0
	public static void AddTimed(Object obj, float minDelay, float maxDelay, Action action, string DebugName) { }

	// RVA: 0x1BAE810 Offset: 0x1BACE10 VA: 0x181BAE810
	public static void Add(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BAE550 Offset: 0x1BACB50 VA: 0x181BAE550
	public static void AddLateUpdate(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BAEC30 Offset: 0x1BAD230 VA: 0x181BAEC30
	public static void RemoveAll(Object obj) { }

	// RVA: 0x1BAE960 Offset: 0x1BACF60 VA: 0x181BAE960
	private static void Cleanup() { }

	// RVA: 0x1BAEBA0 Offset: 0x1BAD1A0 VA: 0x181BAEBA0
	internal static void OnFrame() { }

	// RVA: 0x1BAEB30 Offset: 0x1BAD130 VA: 0x181BAEB30
	internal static void OnFrameLate() { }

	// RVA: 0x1BAECB0 Offset: 0x1BAD2B0 VA: 0x181BAECB0
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

	// RVA: 0x1BA4620 Offset: 0x1BA2C20 VA: 0x181BA4620
	public void Remove(Object obj) { }

	// RVA: 0x1BA4920 Offset: 0x1BA2F20 VA: 0x181BA4920
	internal void Tick() { }

	// RVA: 0x1BA4720 Offset: 0x1BA2D20 VA: 0x181BA4720
	internal void TickTimed() { }

	// RVA: 0x1BA4A50 Offset: 0x1BA3050 VA: 0x181BA4A50
	public void .ctor() { }

}

