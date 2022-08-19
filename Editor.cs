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

	// RVA: 0x223F80 Offset: 0x223380 VA: 0x180223F80
	internal void .ctor(WorkshopFileType filetype) { }

	// RVA: 0x223FB0 Offset: 0x2233B0 VA: 0x180223FB0
	public void .ctor(PublishedFileId fileId) { }

	// RVA: 0x19D5830 Offset: 0x19D3E30 VA: 0x1819D5830
	public static Editor get_NewMicrotransactionFile() { }

	// RVA: 0x223F10 Offset: 0x223310 VA: 0x180223F10
	public Editor WithTitle(string t) { }

	// RVA: 0x223B70 Offset: 0x222F70 VA: 0x180223B70
	public Editor WithChangeLog(string t) { }

	// RVA: 0x223D10 Offset: 0x223110 VA: 0x180223D10
	public Editor WithPreviewFile(string t) { }

	// RVA: 0x223BE0 Offset: 0x222FE0 VA: 0x180223BE0
	public Editor WithContent(DirectoryInfo t) { }

	// RVA: 0x223C50 Offset: 0x223050 VA: 0x180223C50
	public Editor WithContent(string folderName) { }

	// RVA: 0x223D80 Offset: 0x223180 VA: 0x180223D80
	public Editor WithPublicVisibility() { }

	// RVA: 0x223E20 Offset: 0x223220 VA: 0x180223E20
	public Editor WithTag(string tag) { }

	[AsyncStateMachineAttribute] // RVA: 0x9CA80 Offset: 0x9BE80 VA: 0x18009CA80
	// RVA: 0x223A10 Offset: 0x222E10 VA: 0x180223A10
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

	// RVA: 0x224FB0 Offset: 0x2243B0 VA: 0x180224FB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224FC0 Offset: 0x2243C0 VA: 0x180224FC0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Editor : ConsoleSystem // TypeDefIndex: 11909
{	// Methods

	// RVA: 0x6DBD10 Offset: 0x6DA310 VA: 0x1806DBD10
	public void .ctor() { }

}

