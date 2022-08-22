public class Publisher : MonoBehaviour // TypeDefIndex: 7762
{	// Fields
	public InputField ChangeLog; // 0x18
	public Button PublishButton; // 0x20
	public Texture2D IconBackground; // 0x28
	private Skinnable Skinnable; // 0x30
	private Skin Skin; // 0x38
	private ulong ItemId; // 0x40
	private string Title; // 0x48
	private GameObject Prefab; // 0x50

	// Properties
	protected WorkshopInterface Interface { get; }
	protected WorkshopItemEditor Editor { get; }

	// Methods

	// RVA: 0xE75700 Offset: 0xE73D00 VA: 0x180E75700
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE756A0 Offset: 0xE73CA0 VA: 0x180E756A0
	protected WorkshopItemEditor get_Editor() { }

	// RVA: 0xE75590 Offset: 0xE73B90 VA: 0x180E75590
	public void StartExport() { }

	// RVA: 0xE755B0 Offset: 0xE73BB0 VA: 0x180E755B0
	public void Update() { }

	// RVA: 0xE74D90 Offset: 0xE73390 VA: 0x180E74D90
	public bool CanPublish() { }

	[AsyncStateMachineAttribute] // RVA: 0xD6E50 Offset: 0xD6250 VA: 0x1800D6E50
	// RVA: 0xE74FC0 Offset: 0xE735C0 VA: 0x180E74FC0
	private Task DoExport(bool publishToSteam, bool OpenFolder, string forceFolderName) { }

	[AsyncStateMachineAttribute] // RVA: 0xD6F40 Offset: 0xD6340 VA: 0x1800D6F40
	// RVA: 0xE75350 Offset: 0xE73950 VA: 0x180E75350
	private Task ExportToFolder(string folder, bool OpenFolder) { }

	// RVA: 0xE74E60 Offset: 0xE73460 VA: 0x180E74E60
	private void CreateWorkshopIcon(string folder) { }

	[AsyncStateMachineAttribute] // RVA: 0xD7240 Offset: 0xD6640 VA: 0x1800D7240
	// RVA: 0xE75470 Offset: 0xE73A70 VA: 0x180E75470
	private Task PublishToSteam(string folder) { }

	[AsyncStateMachineAttribute] // RVA: 0xD7290 Offset: 0xD6690 VA: 0x1800D7290
	// RVA: 0xE751E0 Offset: 0xE737E0 VA: 0x180E751E0
	private Task ExportTexture(Dictionary<string, string> data, string folder, int group, string paramname, Material mat, Material defaultMat, bool isNormalMap = False) { }

	// RVA: 0xE750F0 Offset: 0xE736F0 VA: 0x180E750F0
	public void Export() { }

	[AsyncStateMachineAttribute] // RVA: 0xD73B0 Offset: 0xD67B0 VA: 0x1800D73B0
	// RVA: 0xE750F0 Offset: 0xE736F0 VA: 0x180E750F0
	public Task DoExport() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private struct Publisher.<DoExport>d__15 : IAsyncStateMachine // TypeDefIndex: 7763
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Publisher <>4__this; // 0x20
	public string forceFolderName; // 0x28
	public bool OpenFolder; // 0x30
	public bool publishToSteam; // 0x31
	private string <tempFolder>5__2; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x137380 Offset: 0x136780 VA: 0x180137380 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<ExportToFolder>d__16 : IAsyncStateMachine // TypeDefIndex: 7764
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Publisher <>4__this; // 0x20
	public string folder; // 0x28
	public bool OpenFolder; // 0x30
	private Skin.Manifest <data>5__2; // 0x38
	private int <i>5__3; // 0x40
	private Material <mat>5__4; // 0x48
	private Skin.Manifest.Group <group>5__5; // 0x50
	private bool <isCloth>5__6; // 0x58
	private bool <hasDetailLayer>5__7; // 0x59
	private bool <hasDirtLayer>5__8; // 0x5A
	private TaskAwaiter <>u__1; // 0x60

	// Methods

	// RVA: 0x1373B0 Offset: 0x1367B0 VA: 0x1801373B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<PublishToSteam>d__18 : IAsyncStateMachine // TypeDefIndex: 7765
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Publisher <>4__this; // 0x20
	public string folder; // 0x28
	private TaskAwaiter<PublishResult> <>u__1; // 0x30
	private TaskAwaiter<Nullable<Item>> <>u__2; // 0x38

	// Methods

	// RVA: 0x1373C0 Offset: 0x1367C0 VA: 0x1801373C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<ExportTexture>d__19 : IAsyncStateMachine // TypeDefIndex: 7766
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string paramname; // 0x20
	public Material mat; // 0x28
	public Material defaultMat; // 0x30
	public Dictionary<string, string> data; // 0x38
	public Publisher <>4__this; // 0x40
	public int group; // 0x48
	public bool isNormalMap; // 0x4C
	public string folder; // 0x50
	private TaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0x1373A0 Offset: 0x1367A0 VA: 0x1801373A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Publisher.<DoExport>d__21 : IAsyncStateMachine // TypeDefIndex: 7767
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Publisher <>4__this; // 0x20
	private TaskAwaiter<string> <>u__1; // 0x28
	private TaskAwaiter <>u__2; // 0x30

	// Methods

	// RVA: 0x137390 Offset: 0x136790 VA: 0x180137390 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

