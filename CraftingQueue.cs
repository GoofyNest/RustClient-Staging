public class CraftingQueue : SingletonComponent<CraftingQueue> // TypeDefIndex: 10988
{	// Fields
	public GameObject queueContainer; // 0x18
	public GameObject queueItemPrefab; // 0x20
	private ScrollRect scrollRect; // 0x28
	private static Dictionary<int, int> CraftingItems; // 0x0
	public static bool isCrafting; // 0x8

	// Methods

	// RVA: 0x6C18A0 Offset: 0x6BFEA0 VA: 0x1806C18A0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6C1920 Offset: 0x6BFF20 VA: 0x1806C1920
	public void ClearCraftingQueue() { }

	// RVA: 0x6C2820 Offset: 0x6C0E20 VA: 0x1806C2820
	internal static void TaskStarted(int taskid, float time) { }

	// RVA: 0x6C1A40 Offset: 0x6C0040 VA: 0x1806C1A40
	internal static int Count(ItemBlueprint bp) { }

	// RVA: 0x6C1BE0 Offset: 0x6C01E0 VA: 0x1806C1BE0
	internal static void TaskAdd(int taskid, int itemid, int amount, int skinid) { }

	// RVA: 0x6C23C0 Offset: 0x6C09C0 VA: 0x1806C23C0
	internal static void TaskFinished(int taskid, bool success, int amountleft) { }

	// RVA: 0x6C1FA0 Offset: 0x6C05A0 VA: 0x1806C1FA0
	internal static void TaskFastTracked(int taskid) { }

	// RVA: 0x6C2B10 Offset: 0x6C1110 VA: 0x1806C2B10
	public void UpdateVisibility() { }

	// RVA: 0x6C1B50 Offset: 0x6C0150 VA: 0x1806C1B50
	public CraftingQueueIcon GetActive() { }

	// RVA: 0x6C2C00 Offset: 0x6C1200 VA: 0x1806C2C00
	public void .ctor() { }

	// RVA: 0x6C2BA0 Offset: 0x6C11A0 VA: 0x1806C2BA0
	private static void .cctor() { }

}

private sealed class CraftingQueue.<>c__DisplayClass6_0 // TypeDefIndex: 10989
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8FD0 Offset: 0x6C75D0 VA: 0x1806C8FD0
	internal bool <TaskStarted>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass9_0 // TypeDefIndex: 10990
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8FD0 Offset: 0x6C75D0 VA: 0x1806C8FD0
	internal bool <TaskFinished>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass10_0 // TypeDefIndex: 10991
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8FD0 Offset: 0x6C75D0 VA: 0x1806C8FD0
	internal bool <TaskFastTracked>b__0(CraftingQueueIcon x) { }

}

