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

	// RVA: 0xE85210 Offset: 0xE83810 VA: 0x180E85210
	public static void RefreshAll() { }

	// RVA: 0xE854F0 Offset: 0xE83AF0 VA: 0x180E854F0
	private int get_NumPages() { }

	// RVA: 0xE84CC0 Offset: 0xE832C0 VA: 0x180E84CC0
	private void Awake() { }

	// RVA: 0xE851D0 Offset: 0xE837D0 VA: 0x180E851D0
	private void PageNext() { }

	// RVA: 0xE851F0 Offset: 0xE837F0 VA: 0x180E851F0
	private void PagePrev() { }

	// RVA: 0xE85120 Offset: 0xE83720 VA: 0x180E85120
	public void OnChangedItemType(int type) { }

	// RVA: 0xE853F0 Offset: 0xE839F0 VA: 0x180E853F0
	private void Update() { }

	// RVA: 0xE85390 Offset: 0xE83990 VA: 0x180E85390
	public void SwitchToLatest() { }

	// RVA: 0xE853D0 Offset: 0xE839D0 VA: 0x180E853D0
	public void SwitchToTrending() { }

	// RVA: 0xE853B0 Offset: 0xE839B0 VA: 0x180E853B0
	public void SwitchToPopular() { }

	// RVA: 0xE85370 Offset: 0xE83970 VA: 0x180E85370
	public void SwitchToAccepted() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1580 Offset: 0xD0980 VA: 0x1800D1580
	// RVA: 0xE85280 Offset: 0xE83880 VA: 0x180E85280
	public Task Refresh() { }

	// RVA: 0xE854E0 Offset: 0xE83AE0 VA: 0x180E854E0
	public void .ctor() { }

	// RVA: 0xE854A0 Offset: 0xE83AA0 VA: 0x180E854A0
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

	// RVA: 0xE815C0 Offset: 0xE7FBC0 VA: 0x180E815C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE813B0 Offset: 0xE7F9B0 VA: 0x180E813B0
	internal bool <Awake>b__17_0(Skinnable x) { }

	// RVA: 0x9573C0 Offset: 0x9559C0 VA: 0x1809573C0
	internal string <Awake>b__17_1(Skinnable x) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	internal string <Awake>b__17_2(string x) { }

	// RVA: 0xE813D0 Offset: 0xE7F9D0 VA: 0x180E813D0
	internal DateTime <Refresh>b__26_0(Item x) { }

}

private struct WorkshopItemList.<Refresh>d__26 : IAsyncStateMachine // TypeDefIndex: 7745
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WorkshopItemList <>4__this; // 0x20
	private TaskAwaiter<Nullable<ResultPage>> <>u__1; // 0x28

	// Methods

	// RVA: 0x1373D0 Offset: 0x1367D0 VA: 0x1801373D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

