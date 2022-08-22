public static class Tick // TypeDefIndex: 6603
{	// Fields
	private static Tick.Entry.List Timed; // 0x0
	private static Tick.Entry.List Update; // 0x8
	private static Tick.Entry.List Late; // 0x10
	private static List<Object> RemoveList; // 0x18

	// Methods

	// RVA: 0x1BAEE90 Offset: 0x1BAD490 VA: 0x181BAEE90
	public static void AddTimed(Object obj, float minDelay, float maxDelay, Action action, string DebugName) { }

	// RVA: 0x1BAF000 Offset: 0x1BAD600 VA: 0x181BAF000
	public static void Add(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BAED40 Offset: 0x1BAD340 VA: 0x181BAED40
	public static void AddLateUpdate(Object obj, Action action, string DebugName) { }

	// RVA: 0x1BAF420 Offset: 0x1BADA20 VA: 0x181BAF420
	public static void RemoveAll(Object obj) { }

	// RVA: 0x1BAF150 Offset: 0x1BAD750 VA: 0x181BAF150
	private static void Cleanup() { }

	// RVA: 0x1BAF390 Offset: 0x1BAD990 VA: 0x181BAF390
	internal static void OnFrame() { }

	// RVA: 0x1BAF320 Offset: 0x1BAD920 VA: 0x181BAF320
	internal static void OnFrameLate() { }

	// RVA: 0x1BAF4A0 Offset: 0x1BADAA0 VA: 0x181BAF4A0
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

	// RVA: 0x1BA4E10 Offset: 0x1BA3410 VA: 0x181BA4E10
	public void Remove(Object obj) { }

	// RVA: 0x1BA5110 Offset: 0x1BA3710 VA: 0x181BA5110
	internal void Tick() { }

	// RVA: 0x1BA4F10 Offset: 0x1BA3510 VA: 0x181BA4F10
	internal void TickTimed() { }

	// RVA: 0x1BA5240 Offset: 0x1BA3840 VA: 0x181BA5240
	public void .ctor() { }

}

