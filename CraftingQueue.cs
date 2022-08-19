public class CraftingQueue : SingletonComponent<CraftingQueue> // TypeDefIndex: 10988
{	// Fields
	public GameObject queueContainer; // 0x18
	public GameObject queueItemPrefab; // 0x20
	private ScrollRect scrollRect; // 0x28
	private static Dictionary<int, int> CraftingItems; // 0x0
	public static bool isCrafting; // 0x8

	// Methods

	// RVA: 0x6C1790 Offset: 0x6BFD90 VA: 0x1806C1790 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6C1810 Offset: 0x6BFE10 VA: 0x1806C1810
	public void ClearCraftingQueue() { }

	// RVA: 0x6C2710 Offset: 0x6C0D10 VA: 0x1806C2710
	internal static void TaskStarted(int taskid, float time) { }

	// RVA: 0x6C1930 Offset: 0x6BFF30 VA: 0x1806C1930
	internal static int Count(ItemBlueprint bp) { }

	// RVA: 0x6C1AD0 Offset: 0x6C00D0 VA: 0x1806C1AD0
	internal static void TaskAdd(int taskid, int itemid, int amount, int skinid) { }

	// RVA: 0x6C22B0 Offset: 0x6C08B0 VA: 0x1806C22B0
	internal static void TaskFinished(int taskid, bool success, int amountleft) { }

	// RVA: 0x6C1E90 Offset: 0x6C0490 VA: 0x1806C1E90
	internal static void TaskFastTracked(int taskid) { }

	// RVA: 0x6C2A00 Offset: 0x6C1000 VA: 0x1806C2A00
	public void UpdateVisibility() { }

	// RVA: 0x6C1A40 Offset: 0x6C0040 VA: 0x1806C1A40
	public CraftingQueueIcon GetActive() { }

	// RVA: 0x6C2AF0 Offset: 0x6C10F0 VA: 0x1806C2AF0
	public void .ctor() { }

	// RVA: 0x6C2A90 Offset: 0x6C1090 VA: 0x1806C2A90
	private static void .cctor() { }

}

private sealed class CraftingQueue.<>c__DisplayClass6_0 // TypeDefIndex: 10989
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8EC0 Offset: 0x6C74C0 VA: 0x1806C8EC0
	internal bool <TaskStarted>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass9_0 // TypeDefIndex: 10990
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8EC0 Offset: 0x6C74C0 VA: 0x1806C8EC0
	internal bool <TaskFinished>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass10_0 // TypeDefIndex: 10991
{	// Fields
	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8EC0 Offset: 0x6C74C0 VA: 0x1806C8EC0
	internal bool <TaskFastTracked>b__0(CraftingQueueIcon x) { }

}

