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

	// RVA: 0xE74990 Offset: 0xE72F90 VA: 0x180E74990
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE74930 Offset: 0xE72F30 VA: 0x180E74930
	protected WorkshopItemEditor get_Editor() { }

	// RVA: 0xE74820 Offset: 0xE72E20 VA: 0x180E74820
	public void StartExport() { }

	// RVA: 0xE74840 Offset: 0xE72E40 VA: 0x180E74840
	public void Update() { }

	// RVA: 0xE74020 Offset: 0xE72620 VA: 0x180E74020
	public bool CanPublish() { }

	[AsyncStateMachineAttribute] // RVA: 0xD6DB0 Offset: 0xD61B0 VA: 0x1800D6DB0
	// RVA: 0xE74250 Offset: 0xE72850 VA: 0x180E74250
	private Task DoExport(bool publishToSteam, bool OpenFolder, string forceFolderName) { }

	[AsyncStateMachineAttribute] // RVA: 0xD6EB0 Offset: 0xD62B0 VA: 0x1800D6EB0
	// RVA: 0xE745E0 Offset: 0xE72BE0 VA: 0x180E745E0
	private Task ExportToFolder(string folder, bool OpenFolder) { }

	// RVA: 0xE740F0 Offset: 0xE726F0 VA: 0x180E740F0
	private void CreateWorkshopIcon(string folder) { }

	[AsyncStateMachineAttribute] // RVA: 0xD7190 Offset: 0xD6590 VA: 0x1800D7190
	// RVA: 0xE74700 Offset: 0xE72D00 VA: 0x180E74700
	private Task PublishToSteam(string folder) { }

	[AsyncStateMachineAttribute] // RVA: 0xD7220 Offset: 0xD6620 VA: 0x1800D7220
	// RVA: 0xE74470 Offset: 0xE72A70 VA: 0x180E74470
	private Task ExportTexture(Dictionary<string, string> data, string folder, int group, string paramname, Material mat, Material defaultMat, bool isNormalMap = False) { }

	// RVA: 0xE74380 Offset: 0xE72980 VA: 0x180E74380
	public void Export() { }

	[AsyncStateMachineAttribute] // RVA: 0xD7340 Offset: 0xD6740 VA: 0x1800D7340
	// RVA: 0xE74380 Offset: 0xE72980 VA: 0x180E74380
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

	// RVA: 0x1375E0 Offset: 0x1369E0 VA: 0x1801375E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
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

	// RVA: 0x137610 Offset: 0x136A10 VA: 0x180137610 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
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

	// RVA: 0x137620 Offset: 0x136A20 VA: 0x180137620 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
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

	// RVA: 0x137600 Offset: 0x136A00 VA: 0x180137600 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
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

	// RVA: 0x1375F0 Offset: 0x1369F0 VA: 0x1801375F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

