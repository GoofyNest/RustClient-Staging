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

	// RVA: 0x223F00 Offset: 0x223300 VA: 0x180223F00
	internal void .ctor(WorkshopFileType filetype) { }

	// RVA: 0x223F30 Offset: 0x223330 VA: 0x180223F30
	public void .ctor(PublishedFileId fileId) { }

	// RVA: 0x19D5AB0 Offset: 0x19D40B0 VA: 0x1819D5AB0
	public static Editor get_NewMicrotransactionFile() { }

	// RVA: 0x223E90 Offset: 0x223290 VA: 0x180223E90
	public Editor WithTitle(string t) { }

	// RVA: 0x223AF0 Offset: 0x222EF0 VA: 0x180223AF0
	public Editor WithChangeLog(string t) { }

	// RVA: 0x223C90 Offset: 0x223090 VA: 0x180223C90
	public Editor WithPreviewFile(string t) { }

	// RVA: 0x223B60 Offset: 0x222F60 VA: 0x180223B60
	public Editor WithContent(DirectoryInfo t) { }

	// RVA: 0x223BD0 Offset: 0x222FD0 VA: 0x180223BD0
	public Editor WithContent(string folderName) { }

	// RVA: 0x223D00 Offset: 0x223100 VA: 0x180223D00
	public Editor WithPublicVisibility() { }

	// RVA: 0x223DA0 Offset: 0x2231A0 VA: 0x180223DA0
	public Editor WithTag(string tag) { }

	[AsyncStateMachineAttribute] // RVA: 0x9CB90 Offset: 0x9BF90 VA: 0x18009CB90
	// RVA: 0x223990 Offset: 0x222D90 VA: 0x180223990
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

	// RVA: 0x224F30 Offset: 0x224330 VA: 0x180224F30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224F40 Offset: 0x224340 VA: 0x180224F40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Editor : ConsoleSystem // TypeDefIndex: 11909
{	// Methods

	// RVA: 0x6DBE20 Offset: 0x6DA420 VA: 0x1806DBE20
	public void .ctor() { }

}

