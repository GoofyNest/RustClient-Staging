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

	// RVA: 0xE74C50 Offset: 0xE73250 VA: 0x180E74C50
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE74BF0 Offset: 0xE731F0 VA: 0x180E74BF0
	protected WorkshopItemEditor get_Editor() { }

	// RVA: 0xE74AE0 Offset: 0xE730E0 VA: 0x180E74AE0
	public void StartExport() { }

	// RVA: 0xE74B00 Offset: 0xE73100 VA: 0x180E74B00
	public void Update() { }

	// RVA: 0xE742E0 Offset: 0xE728E0 VA: 0x180E742E0
	public bool CanPublish() { }

	[AsyncStateMachineAttribute] // RVA: 0xD6E50 Offset: 0xD6250 VA: 0x1800D6E50
	// RVA: 0xE74510 Offset: 0xE72B10 VA: 0x180E74510
	private Task DoExport(bool publishToSteam, bool OpenFolder, string forceFolderName) { }

	[AsyncStateMachineAttribute] // RVA: 0xD6F40 Offset: 0xD6340 VA: 0x1800D6F40
	// RVA: 0xE748A0 Offset: 0xE72EA0 VA: 0x180E748A0
	private Task ExportToFolder(string folder, bool OpenFolder) { }

	// RVA: 0xE743B0 Offset: 0xE729B0 VA: 0x180E743B0
	private void CreateWorkshopIcon(string folder) { }

	[AsyncStateMachineAttribute] // RVA: 0xD7240 Offset: 0xD6640 VA: 0x1800D7240
	// RVA: 0xE749C0 Offset: 0xE72FC0 VA: 0x180E749C0
	private Task PublishToSteam(string folder) { }

	[AsyncStateMachineAttribute] // RVA: 0xD7290 Offset: 0xD6690 VA: 0x1800D7290
	// RVA: 0xE74730 Offset: 0xE72D30 VA: 0x180E74730
	private Task ExportTexture(Dictionary<string, string> data, string folder, int group, string paramname, Material mat, Material defaultMat, bool isNormalMap = False) { }

	// RVA: 0xE74640 Offset: 0xE72C40 VA: 0x180E74640
	public void Export() { }

	[AsyncStateMachineAttribute] // RVA: 0xD73B0 Offset: 0xD67B0 VA: 0x1800D73B0
	// RVA: 0xE74640 Offset: 0xE72C40 VA: 0x180E74640
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

	// RVA: 0x137560 Offset: 0x136960 VA: 0x180137560 Slot: 4
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

	// RVA: 0x137590 Offset: 0x136990 VA: 0x180137590 Slot: 4
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

	// RVA: 0x1375A0 Offset: 0x1369A0 VA: 0x1801375A0 Slot: 4
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

	// RVA: 0x137580 Offset: 0x136980 VA: 0x180137580 Slot: 4
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

	// RVA: 0x137570 Offset: 0x136970 VA: 0x180137570 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

