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

	// RVA: 0xE844A0 Offset: 0xE82AA0 VA: 0x180E844A0
	public static void RefreshAll() { }

	// RVA: 0xE84780 Offset: 0xE82D80 VA: 0x180E84780
	private int get_NumPages() { }

	// RVA: 0xE83F50 Offset: 0xE82550 VA: 0x180E83F50
	private void Awake() { }

	// RVA: 0xE84460 Offset: 0xE82A60 VA: 0x180E84460
	private void PageNext() { }

	// RVA: 0xE84480 Offset: 0xE82A80 VA: 0x180E84480
	private void PagePrev() { }

	// RVA: 0xE843B0 Offset: 0xE829B0 VA: 0x180E843B0
	public void OnChangedItemType(int type) { }

	// RVA: 0xE84680 Offset: 0xE82C80 VA: 0x180E84680
	private void Update() { }

	// RVA: 0xE84620 Offset: 0xE82C20 VA: 0x180E84620
	public void SwitchToLatest() { }

	// RVA: 0xE84660 Offset: 0xE82C60 VA: 0x180E84660
	public void SwitchToTrending() { }

	// RVA: 0xE84640 Offset: 0xE82C40 VA: 0x180E84640
	public void SwitchToPopular() { }

	// RVA: 0xE84600 Offset: 0xE82C00 VA: 0x180E84600
	public void SwitchToAccepted() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1580 Offset: 0xD0980 VA: 0x1800D1580
	// RVA: 0xE84510 Offset: 0xE82B10 VA: 0x180E84510
	public Task Refresh() { }

	// RVA: 0xE84770 Offset: 0xE82D70 VA: 0x180E84770
	public void .ctor() { }

	// RVA: 0xE84730 Offset: 0xE82D30 VA: 0x180E84730
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

	// RVA: 0xE80850 Offset: 0xE7EE50 VA: 0x180E80850
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80640 Offset: 0xE7EC40 VA: 0x180E80640
	internal bool <Awake>b__17_0(Skinnable x) { }

	// RVA: 0x956DB0 Offset: 0x9553B0 VA: 0x180956DB0
	internal string <Awake>b__17_1(Skinnable x) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	internal string <Awake>b__17_2(string x) { }

	// RVA: 0xE80660 Offset: 0xE7EC60 VA: 0x180E80660
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

