public class CraftingQueue : SingletonComponent<CraftingQueue> // TypeDefIndex: 10988
{	public GameObject queueContainer; // 0x18
	public GameObject queueItemPrefab; // 0x20
	private ScrollRect scrollRect; // 0x28
	private static Dictionary<int, int> CraftingItems; // 0x0
	public static bool isCrafting; // 0x8


	protected override void Awake() { }

	public void ClearCraftingQueue() { }

	internal static void TaskStarted(int taskid, float time) { }

	internal static int Count(ItemBlueprint bp) { }

	internal static void TaskAdd(int taskid, int itemid, int amount, int skinid) { }

	internal static void TaskFinished(int taskid, bool success, int amountleft) { }

	internal static void TaskFastTracked(int taskid) { }

	public void UpdateVisibility() { }

	public CraftingQueueIcon GetActive() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class CraftingQueue.<>c__DisplayClass6_0 // TypeDefIndex: 10989
{	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18


	public void .ctor() { }

	internal bool <TaskStarted>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass9_0 // TypeDefIndex: 10990
{	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18


	public void .ctor() { }

	internal bool <TaskFinished>b__0(CraftingQueueIcon x) { }

}

private sealed class CraftingQueue.<>c__DisplayClass10_0 // TypeDefIndex: 10991
{	public int taskid; // 0x10
	public Func<CraftingQueueIcon, bool> <>9__0; // 0x18


	public void .ctor() { }

	internal bool <TaskFastTracked>b__0(CraftingQueueIcon x) { }

}

