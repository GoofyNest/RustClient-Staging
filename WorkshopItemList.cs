internal class WorkshopItemList : MonoBehaviour // TypeDefIndex: 7743
{	// Fields
	private static int StaticRefresh; // 0x0
	public WorkshopItemButton ButtonPrefab; // 0x18
	public GameObject Container; // 0x20
	public ListType ListType; // 0x28
	private const int PerPage = 50;
	public int Page; // 0x2C
	public Button PreviousPage; // 0x30
	public Button NextPage; // 0x38
	public Text PageInfo; // 0x40
	public string ItemFilter; // 0x48
	public Dropdown ItemTypeSelector; // 0x50
	private int ForcedRefresh; // 0x58
	private int TotalResults; // 0x5C
	private bool Refreshing; // 0x60

	// Properties
	private int NumPages { get; }

	// Methods

	// RVA: 0xE84760 Offset: 0xE82D60 VA: 0x180E84760
	public static void RefreshAll() { }

	// RVA: 0xE84A40 Offset: 0xE83040 VA: 0x180E84A40
	private int get_NumPages() { }

	// RVA: 0xE84210 Offset: 0xE82810 VA: 0x180E84210
	private void Awake() { }

	// RVA: 0xE84720 Offset: 0xE82D20 VA: 0x180E84720
	private void PageNext() { }

	// RVA: 0xE84740 Offset: 0xE82D40 VA: 0x180E84740
	private void PagePrev() { }

	// RVA: 0xE84670 Offset: 0xE82C70 VA: 0x180E84670
	public void OnChangedItemType(int type) { }

	// RVA: 0xE84940 Offset: 0xE82F40 VA: 0x180E84940
	private void Update() { }

	// RVA: 0xE848E0 Offset: 0xE82EE0 VA: 0x180E848E0
	public void SwitchToLatest() { }

	// RVA: 0xE84920 Offset: 0xE82F20 VA: 0x180E84920
	public void SwitchToTrending() { }

	// RVA: 0xE84900 Offset: 0xE82F00 VA: 0x180E84900
	public void SwitchToPopular() { }

	// RVA: 0xE848C0 Offset: 0xE82EC0 VA: 0x180E848C0
	public void SwitchToAccepted() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1580 Offset: 0xD0980 VA: 0x1800D1580
	// RVA: 0xE847D0 Offset: 0xE82DD0 VA: 0x180E847D0
	public Task Refresh() { }

	// RVA: 0xE84A30 Offset: 0xE83030 VA: 0x180E84A30
	public void .ctor() { }

	// RVA: 0xE849F0 Offset: 0xE82FF0 VA: 0x180E849F0
	private static void .cctor() { }

}

private sealed class WorkshopItemList.<>c // TypeDefIndex: 7744
{	// Fields
	public static readonly WorkshopItemList.<>c <>9; // 0x0
	public static Func<Skinnable, bool> <>9__17_0; // 0x8
	public static Func<Skinnable, string> <>9__17_1; // 0x10
	public static Func<string, string> <>9__17_2; // 0x18
	public static Func<Item, DateTime> <>9__26_0; // 0x20

	// Methods

	// RVA: 0xE80B10 Offset: 0xE7F110 VA: 0x180E80B10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80900 Offset: 0xE7EF00 VA: 0x180E80900
	internal bool <Awake>b__17_0(Skinnable x) { }

	// RVA: 0x956EC0 Offset: 0x9554C0 VA: 0x180956EC0
	internal string <Awake>b__17_1(Skinnable x) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
	internal string <Awake>b__17_2(string x) { }

	// RVA: 0xE80920 Offset: 0xE7EF20 VA: 0x180E80920
	internal DateTime <Refresh>b__26_0(Item x) { }

}

private struct WorkshopItemList.<Refresh>d__26 : IAsyncStateMachine // TypeDefIndex: 7745
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WorkshopItemList <>4__this; // 0x20
	private TaskAwaiter<Nullable<ResultPage>> <>u__1; // 0x28

	// Methods

	// RVA: 0x1375B0 Offset: 0x1369B0 VA: 0x1801375B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

