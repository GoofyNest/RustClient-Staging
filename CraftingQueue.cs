public class CraftingQueue : SingletonComponent<CraftingQueue> // TypeDefIndex: 10988
{	// Fields
	public GameObject queueContainer; // 0x18
	public GameObject queueItemPrefab; // 0x20
	private ScrollRect scrollRect; // 0x28
	private static Dictionary<int, int> CraftingItems; // 0x0
	public static bool isCrafting; // 0x8

	// Methods

	// RVA: 0x6C1830 Offset: 0x6BFE30 VA: 0x1806C1830 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6C18B0 Offset: 0x6BFEB0 VA: 0x1806C18B0
	public void ClearCraftingQueue() { }

	// RVA: 0x6C27B0 Offset: 0x6C0DB0 VA: 0x1806C27B0
	internal static void TaskStarted(int taskid, float time) { }

	// RVA: 0x6C19D0 Offset: 0x6BFFD0 VA: 0x1806C19D0
	internal static int Count(ItemBlueprint bp) { }

	// RVA: 0x6C1B70 Offset: 0x6C0170 VA: 0x1806C1B70
	internal static void TaskAdd(int taskid, int itemid, int amount, int skinid) { }

	// RVA: 0x6C2350 Offset: 0x6C0950 VA: 0x1806C2350
	internal static void TaskFinished(int taskid, bool success, int amountleft) { }

	// RVA: 0x6C1F30 Offset: 0x6C0530 VA: 0x1806C1F30
	internal static void TaskFastTracked(int taskid) { }

	// RVA: 0x6C2AA0 Offset: 0x6C10A0 VA: 0x1806C2AA0
	public void UpdateVisibility() { }

	// RVA: 0x6C1AE0 Offset: 0x6C00E0 VA: 0x1806C1AE0
	public CraftingQueueIcon GetActive() { }

	// RVA: 0x6C2B90 Offset: 0x6C1190 VA: 0x1806C2B90
	public void .ctor() { }

	// RVA: 0x6C2B30 Offset: 0x6C1130 VA: 0x1806C2B30
	private static void .cctor() { }

}

private sealed class CraftingQueue.<>c__DisplayClass6_0 // TypeDefIndex: 10989
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8F60 Offset: 0x6C7560 VA: 0x1806C8F60
	internal bool <TaskStarted>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass9_0 // TypeDefIndex: 10990
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8F60 Offset: 0x6C7560 VA: 0x1806C8F60
	internal bool <TaskFinished>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass10_0 // TypeDefIndex: 10991
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8F60 Offset: 0x6C7560 VA: 0x1806C8F60
	internal bool <TaskFastTracked>b__0(CraftingQueueIcon x) { }

}

