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

	// RVA: 0x875030 Offset: 0x873630 VA: 0x180875030
	public bool get_IsContactsActive() { }

	// RVA: 0x873CD0 Offset: 0x8722D0 VA: 0x180873CD0
	public void SetPhone(PhoneController t) { }

	// RVA: 0x874210 Offset: 0x872810 VA: 0x180874210
	public void Update() { }

	// RVA: 0x872620 Offset: 0x870C20 VA: 0x180872620
	public void EnterNumber(int i) { }

	// RVA: 0x873BD0 Offset: 0x8721D0 VA: 0x180873BD0
	public void SetNumber(string number) { }

	// RVA: 0x872230 Offset: 0x870830 VA: 0x180872230
	public void ClearCode() { }

	// RVA: 0x872510 Offset: 0x870B10 VA: 0x180872510
	public void Dial() { }

	// RVA: 0x873090 Offset: 0x871690 VA: 0x180873090
	public void OnFail(Telephone.DialFailReason reason) { }

	// RVA: 0x8731E0 Offset: 0x8717E0 VA: 0x1808731E0
	public void OnPhoneStateChanged(PhoneController c) { }

	// RVA: 0x8721D0 Offset: 0x8707D0 VA: 0x1808721D0
	public void Answer() { }

	// RVA: 0x872910 Offset: 0x870F10 VA: 0x180872910
	public void HangUp() { }

	// RVA: 0x8722E0 Offset: 0x8708E0 VA: 0x1808722E0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x872740 Offset: 0x870D40 VA: 0x180872740
	public void ForceClose() { }

	// RVA: 0x8728B0 Offset: 0x870EB0 VA: 0x1808728B0
	public static string FormatPhoneNumber(string number) { }

	// RVA: 0x872CC0 Offset: 0x8712C0 VA: 0x180872CC0
	public void OnClickedDirectory() { }

	// RVA: 0x873600 Offset: 0x871C00 VA: 0x180873600
	public void OnReceivedDirectory() { }

	// RVA: 0x872B60 Offset: 0x871160 VA: 0x180872B60
	public void OnClickedContacts() { }

	// RVA: 0x873850 Offset: 0x871E50 VA: 0x180873850
	public void PopulateDirectory(PhoneDirectory directory, Transform forRoot, bool showDeleteOption) { }

	// RVA: 0x872AC0 Offset: 0x8710C0 VA: 0x180872AC0
	public void OnClickedCallDirectoryEntry(string number) { }

	// RVA: 0x872C20 Offset: 0x871220 VA: 0x180872C20
	public void OnClickedDeletePhoneNumber(string phoneNumber) { }

	// RVA: 0x873150 Offset: 0x871750 VA: 0x180873150
	public void OnNameInput(string newName) { }

	// RVA: 0x872E30 Offset: 0x871430 VA: 0x180872E30
	public void OnClickedSaveNumber() { }

	// RVA: 0x873FD0 Offset: 0x8725D0 VA: 0x180873FD0
	public void UpdateAddContactButton() { }

	// RVA: 0x872940 Offset: 0x870F40 VA: 0x180872940
	public void LoadDirectory(int direction) { }

	// RVA: 0x874090 Offset: 0x872690 VA: 0x180874090
	private void UpdateIncomingCallText(PhoneController c) { }

	[IteratorStateMachineAttribute] // RVA: 0x88F00 Offset: 0x88300 VA: 0x180088F00
	// RVA: 0x873750 Offset: 0x871D50 VA: 0x180873750
	private IEnumerator PlayInputBeepsForPhoneNumber(string number) { }

	// RVA: 0x8734E0 Offset: 0x871AE0 VA: 0x1808734E0
	public void OnReceivedAnsweringMessage(float length, bool canLeaveVoicemail) { }

	// RVA: 0x873720 Offset: 0x871D20 VA: 0x180873720
	public void OnStartedRecordingVoicemail(float duration) { }

	// RVA: 0x872710 Offset: 0x870D10 VA: 0x180872710
	public void FinishVoicemailRecording() { }

	// RVA: 0x8737E0 Offset: 0x871DE0 VA: 0x1808737E0
	public void PlayVoicemail(uint id) { }

	// RVA: 0x873F70 Offset: 0x872570 VA: 0x180873F70
	public void StopVoicemail() { }

	// RVA: 0x8724A0 Offset: 0x870AA0 VA: 0x1808724A0
	public void DeleteVoicemail(uint id) { }

	// RVA: 0x875100 Offset: 0x873700 VA: 0x180875100
	public float get_NormalisedAnsweringMessagePlayTime() { }

	// RVA: 0x875060 Offset: 0x873660 VA: 0x180875060
	public bool get_IsPlayingAnsweringMessage() { }

	// RVA: 0x872FB0 Offset: 0x8715B0 VA: 0x180872FB0
	public void OnClickedVoicemail() { }

	// RVA: 0x872470 Offset: 0x870A70 VA: 0x180872470
	public void CopyCurrentNumberToClipboard() { }

	// RVA: 0x874FC0 Offset: 0x8735C0 VA: 0x180874FC0
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

	// RVA: 0x9204A0 Offset: 0x91EAA0 VA: 0x1809204A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9206B0 Offset: 0x91ECB0 VA: 0x1809206B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

