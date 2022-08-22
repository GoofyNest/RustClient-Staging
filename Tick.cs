public static class Tick // TypeDefIndex: 6603
{	// Fields
	private static Tick.Entry.List Timed; // 0x0
	private static Tick.Entry.List Update; // 0x8
	private static Tick.Entry.List Late; // 0x10
	private static List<Object> RemoveList; // 0x18

	// Methods

	// RVA: 0x1BAE3E0 Offset: 0x1BAC9E0 VA: 0x181BAE3E0
	public static void AddTimed(Object obj, float minDelay, float maxDelay, Action action, string DebugName) { }

	// RVA: 0x1BAE550 Offset: 0x1BACB50 VA: 0x181BAE550
	public static void Add(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BAE290 Offset: 0x1BAC890 VA: 0x181BAE290
	public static void AddLateUpdate(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BAE970 Offset: 0x1BACF70 VA: 0x181BAE970
	public static void RemoveAll(Object obj) { }

	// RVA: 0x1BAE6A0 Offset: 0x1BACCA0 VA: 0x181BAE6A0
	private static void Cleanup() { }

	// RVA: 0x1BAE8E0 Offset: 0x1BACEE0 VA: 0x181BAE8E0
	internal static void OnFrame() { }

	// RVA: 0x1BAE870 Offset: 0x1BACE70 VA: 0x181BAE870
	internal static void OnFrameLate() { }

	// RVA: 0x1BAE9F0 Offset: 0x1BACFF0 VA: 0x181BAE9F0
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

	// RVA: 0x1BA4360 Offset: 0x1BA2960 VA: 0x181BA4360
	public void Remove(Object obj) { }

	// RVA: 0x1BA4660 Offset: 0x1BA2C60 VA: 0x181BA4660
	internal void Tick() { }

	// RVA: 0x1BA4460 Offset: 0x1BA2A60 VA: 0x181BA4460
	internal void TickTimed() { }

	// RVA: 0x1BA4790 Offset: 0x1BA2D90 VA: 0x181BA4790
	public void .ctor() { }

}

