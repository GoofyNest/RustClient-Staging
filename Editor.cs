public struct Editor // TypeDefIndex: 5274
{	// Fields
	private PublishedFileId fileId; // 0x0
	private bool creatingNew; // 0x8
	private WorkshopFileType creatingType; // 0xC
	private AppId consumerAppId; // 0x10
	private string Title; // 0x18
	private string Description; // 0x20
	private string MetaData; // 0x28
	private string ChangeLog; // 0x30
	private string Language; // 0x38
	private string PreviewFile; // 0x40
	private DirectoryInfo ContentFolder; // 0x48
	private Nullable<RemoteStoragePublishedFileVisibility> Visibility; // 0x50
	private List<string> Tags; // 0x58
	private Dictionary<string, List<string>> KeyValueTags; // 0x60
	private HashSet<string> KeyValueTagsToRemove; // 0x68

	// Properties
	public static Editor NewMicrotransactionFile { get; }

	// Methods

	// RVA: 0x21F480 Offset: 0x21E880 VA: 0x18021F480
	internal void .ctor(WorkshopFileType filetype) { }

	// RVA: 0x21F4B0 Offset: 0x21E8B0 VA: 0x18021F4B0
	public void .ctor(PublishedFileId fileId) { }

	// RVA: 0x19C2EB0 Offset: 0x19C14B0 VA: 0x1819C2EB0
	public static Editor get_NewMicrotransactionFile() { }

	// RVA: 0x21F410 Offset: 0x21E810 VA: 0x18021F410
	public Editor WithTitle(string t) { }

	// RVA: 0x21F070 Offset: 0x21E470 VA: 0x18021F070
	public Editor WithChangeLog(string t) { }

	// RVA: 0x21F210 Offset: 0x21E610 VA: 0x18021F210
	public Editor WithPreviewFile(string t) { }

	// RVA: 0x21F0E0 Offset: 0x21E4E0 VA: 0x18021F0E0
	public Editor WithContent(DirectoryInfo t) { }

	// RVA: 0x21F150 Offset: 0x21E550 VA: 0x18021F150
	public Editor WithContent(string folderName) { }

	// RVA: 0x21F280 Offset: 0x21E680 VA: 0x18021F280
	public Editor WithPublicVisibility() { }

	// RVA: 0x21F320 Offset: 0x21E720 VA: 0x18021F320
	public Editor WithTag(string tag) { }

	[AsyncStateMachineAttribute] // RVA: 0x9CB90 Offset: 0x9BF90 VA: 0x18009CB90
	// RVA: 0x21EF10 Offset: 0x21E310 VA: 0x18021EF10
	public Task<PublishResult> SubmitAsync(IProgress<float> progress, Action<PublishResult> onItemCreated) { }

}

private struct Editor.<SubmitAsync>d__40 : IAsyncStateMachine // TypeDefIndex: 5275
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<PublishResult> <>t__builder; // 0x8
	public IProgress<float> progress; // 0x20
	public Editor <>4__this; // 0x28
	public Action<PublishResult> onItemCreated; // 0x98
	private PublishResult <result>5__2; // 0xA0
	private CallResult<CreateItemResult_t> <>u__1; // 0xB8
	private UGCUpdateHandle_t <handle>5__3; // 0xD0
	private CallResult<SubmitItemUpdateResult_t> <updating>5__4; // 0xD8
	private TaskAwaiter <>u__2; // 0xF0

	// Methods

	// RVA: 0x2204B0 Offset: 0x21F8B0 VA: 0x1802204B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2204C0 Offset: 0x21F8C0 VA: 0x1802204C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Editor : ConsoleSystem // TypeDefIndex: 11909
{	// Methods

	// RVA: 0x6DBDB0 Offset: 0x6DA3B0 VA: 0x1806DBDB0
	public void .ctor() { }

}

