public class PhoneDialler : UIDialog // TypeDefIndex: 10897
{	// Fields
	public GameObject DialingRoot; // 0x30
	public GameObject CallInProcessRoot; // 0x38
	public GameObject IncomingCallRoot; // 0x40
	public RustText ThisPhoneNumber; // 0x48
	public RustInput PhoneNameInput; // 0x50
	public RustText textDisplay; // 0x58
	public RustText CallTimeText; // 0x60
	public RustButton DefaultDialViewButton; // 0x68
	public RustText[] IncomingCallNumber; // 0x70
	public GameObject NumberDialRoot; // 0x78
	public GameObject PromptVoicemailRoot; // 0x80
	public RustButton ContactsButton; // 0x88
	public RustText FailText; // 0x90
	public NeedsCursor CursorController; // 0x98
	public NeedsKeyboard KeyboardController; // 0xA0
	public Translate.Phrase WrongNumberPhrase; // 0xA8
	public Translate.Phrase NetworkBusy; // 0xB0
	public Translate.Phrase Engaged; // 0xB8
	public GameObjectRef DirectoryEntryPrefab; // 0xC0
	public Transform DirectoryRoot; // 0xC8
	public GameObject NoDirectoryRoot; // 0xD0
	public RustButton DirectoryPageUp; // 0xD8
	public RustButton DirectoryPageDown; // 0xE0
	public Transform ContactsRoot; // 0xE8
	public RustInput ContactsNameInput; // 0xF0
	public RustInput ContactsNumberInput; // 0xF8
	public GameObject NoContactsRoot; // 0x100
	public RustButton AddContactButton; // 0x108
	public SoundDefinition DialToneSfx; // 0x110
	public Button[] NumberButtons; // 0x118
	public Translate.Phrase AnsweringMachine; // 0x120
	public VoicemailDialog Voicemail; // 0x128
	public GameObject VoicemailRoot; // 0x130
	private PhoneController attachedPhone; // 0x138
	private Telephone.CallState lastState; // 0x140
	private List<GameObject> spawnedDirectoryEntries; // 0x148
	private int directoryPage; // 0x150
	private TimeSince lastKeyDelete; // 0x154
	private Sound dialTone; // 0x158
	private string textEntered; // 0x160
	private int lastEnteredFrame; // 0x168
	private bool inputtingNumber; // 0x16C

	// Properties
	public bool IsContactsActive { get; }
	public float NormalisedAnsweringMessagePlayTime { get; }
	public bool IsPlayingAnsweringMessage { get; }

	// Methods

	// RVA: 0x890860 Offset: 0x88EE60 VA: 0x180890860
	public bool get_IsContactsActive() { }

	// RVA: 0x88F500 Offset: 0x88DB00 VA: 0x18088F500
	public void SetPhone(PhoneController t) { }

	// RVA: 0x88FA40 Offset: 0x88E040 VA: 0x18088FA40
	public void Update() { }

	// RVA: 0x88DE50 Offset: 0x88C450 VA: 0x18088DE50
	public void EnterNumber(int i) { }

	// RVA: 0x88F400 Offset: 0x88DA00 VA: 0x18088F400
	public void SetNumber(string number) { }

	// RVA: 0x88DA60 Offset: 0x88C060 VA: 0x18088DA60
	public void ClearCode() { }

	// RVA: 0x88DD40 Offset: 0x88C340 VA: 0x18088DD40
	public void Dial() { }

	// RVA: 0x88E8C0 Offset: 0x88CEC0 VA: 0x18088E8C0
	public void OnFail(Telephone.DialFailReason reason) { }

	// RVA: 0x88EA10 Offset: 0x88D010 VA: 0x18088EA10
	public void OnPhoneStateChanged(PhoneController c) { }

	// RVA: 0x88DA00 Offset: 0x88C000 VA: 0x18088DA00
	public void Answer() { }

	// RVA: 0x88E140 Offset: 0x88C740 VA: 0x18088E140
	public void HangUp() { }

	// RVA: 0x88DB10 Offset: 0x88C110 VA: 0x18088DB10 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x88DF70 Offset: 0x88C570 VA: 0x18088DF70
	public void ForceClose() { }

	// RVA: 0x88E0E0 Offset: 0x88C6E0 VA: 0x18088E0E0
	public static string FormatPhoneNumber(string number) { }

	// RVA: 0x88E4F0 Offset: 0x88CAF0 VA: 0x18088E4F0
	public void OnClickedDirectory() { }

	// RVA: 0x88EE30 Offset: 0x88D430 VA: 0x18088EE30
	public void OnReceivedDirectory() { }

	// RVA: 0x88E390 Offset: 0x88C990 VA: 0x18088E390
	public void OnClickedContacts() { }

	// RVA: 0x88F080 Offset: 0x88D680 VA: 0x18088F080
	public void PopulateDirectory(PhoneDirectory directory, Transform forRoot, bool showDeleteOption) { }

	// RVA: 0x88E2F0 Offset: 0x88C8F0 VA: 0x18088E2F0
	public void OnClickedCallDirectoryEntry(string number) { }

	// RVA: 0x88E450 Offset: 0x88CA50 VA: 0x18088E450
	public void OnClickedDeletePhoneNumber(string phoneNumber) { }

	// RVA: 0x88E980 Offset: 0x88CF80 VA: 0x18088E980
	public void OnNameInput(string newName) { }

	// RVA: 0x88E660 Offset: 0x88CC60 VA: 0x18088E660
	public void OnClickedSaveNumber() { }

	// RVA: 0x88F800 Offset: 0x88DE00 VA: 0x18088F800
	public void UpdateAddContactButton() { }

	// RVA: 0x88E170 Offset: 0x88C770 VA: 0x18088E170
	public void LoadDirectory(int direction) { }

	// RVA: 0x88F8C0 Offset: 0x88DEC0 VA: 0x18088F8C0
	private void UpdateIncomingCallText(PhoneController c) { }

	[IteratorStateMachineAttribute] // RVA: 0x88F00 Offset: 0x88300 VA: 0x180088F00
	// RVA: 0x88EF80 Offset: 0x88D580 VA: 0x18088EF80
	private IEnumerator PlayInputBeepsForPhoneNumber(string number) { }

	// RVA: 0x88ED10 Offset: 0x88D310 VA: 0x18088ED10
	public void OnReceivedAnsweringMessage(float length, bool canLeaveVoicemail) { }

	// RVA: 0x88EF50 Offset: 0x88D550 VA: 0x18088EF50
	public void OnStartedRecordingVoicemail(float duration) { }

	// RVA: 0x88DF40 Offset: 0x88C540 VA: 0x18088DF40
	public void FinishVoicemailRecording() { }

	// RVA: 0x88F010 Offset: 0x88D610 VA: 0x18088F010
	public void PlayVoicemail(uint id) { }

	// RVA: 0x88F7A0 Offset: 0x88DDA0 VA: 0x18088F7A0
	public void StopVoicemail() { }

	// RVA: 0x88DCD0 Offset: 0x88C2D0 VA: 0x18088DCD0
	public void DeleteVoicemail(uint id) { }

	// RVA: 0x890930 Offset: 0x88EF30 VA: 0x180890930
	public float get_NormalisedAnsweringMessagePlayTime() { }

	// RVA: 0x890890 Offset: 0x88EE90 VA: 0x180890890
	public bool get_IsPlayingAnsweringMessage() { }

	// RVA: 0x88E7E0 Offset: 0x88CDE0 VA: 0x18088E7E0
	public void OnClickedVoicemail() { }

	// RVA: 0x88DCA0 Offset: 0x88C2A0 VA: 0x18088DCA0
	public void CopyCurrentNumberToClipboard() { }

	// RVA: 0x8907F0 Offset: 0x88EDF0 VA: 0x1808907F0
	public void .ctor() { }

}

private sealed class PhoneDialler.<PlayInputBeepsForPhoneNumber>d__68 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10898
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PhoneDialler <>4__this; // 0x20
	public string number; // 0x28
	private int <i>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x920AC0 Offset: 0x91F0C0 VA: 0x180920AC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x920CD0 Offset: 0x91F2D0 VA: 0x180920CD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

