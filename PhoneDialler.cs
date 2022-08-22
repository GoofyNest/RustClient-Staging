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

	// RVA: 0x875140 Offset: 0x873740 VA: 0x180875140
	public bool get_IsContactsActive() { }

	// RVA: 0x873DE0 Offset: 0x8723E0 VA: 0x180873DE0
	public void SetPhone(PhoneController t) { }

	// RVA: 0x874320 Offset: 0x872920 VA: 0x180874320
	public void Update() { }

	// RVA: 0x872730 Offset: 0x870D30 VA: 0x180872730
	public void EnterNumber(int i) { }

	// RVA: 0x873CE0 Offset: 0x8722E0 VA: 0x180873CE0
	public void SetNumber(string number) { }

	// RVA: 0x872340 Offset: 0x870940 VA: 0x180872340
	public void ClearCode() { }

	// RVA: 0x872620 Offset: 0x870C20 VA: 0x180872620
	public void Dial() { }

	// RVA: 0x8731A0 Offset: 0x8717A0 VA: 0x1808731A0
	public void OnFail(Telephone.DialFailReason reason) { }

	// RVA: 0x8732F0 Offset: 0x8718F0 VA: 0x1808732F0
	public void OnPhoneStateChanged(PhoneController c) { }

	// RVA: 0x8722E0 Offset: 0x8708E0 VA: 0x1808722E0
	public void Answer() { }

	// RVA: 0x872A20 Offset: 0x871020 VA: 0x180872A20
	public void HangUp() { }

	// RVA: 0x8723F0 Offset: 0x8709F0 VA: 0x1808723F0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x872850 Offset: 0x870E50 VA: 0x180872850
	public void ForceClose() { }

	// RVA: 0x8729C0 Offset: 0x870FC0 VA: 0x1808729C0
	public static string FormatPhoneNumber(string number) { }

	// RVA: 0x872DD0 Offset: 0x8713D0 VA: 0x180872DD0
	public void OnClickedDirectory() { }

	// RVA: 0x873710 Offset: 0x871D10 VA: 0x180873710
	public void OnReceivedDirectory() { }

	// RVA: 0x872C70 Offset: 0x871270 VA: 0x180872C70
	public void OnClickedContacts() { }

	// RVA: 0x873960 Offset: 0x871F60 VA: 0x180873960
	public void PopulateDirectory(PhoneDirectory directory, Transform forRoot, bool showDeleteOption) { }

	// RVA: 0x872BD0 Offset: 0x8711D0 VA: 0x180872BD0
	public void OnClickedCallDirectoryEntry(string number) { }

	// RVA: 0x872D30 Offset: 0x871330 VA: 0x180872D30
	public void OnClickedDeletePhoneNumber(string phoneNumber) { }

	// RVA: 0x873260 Offset: 0x871860 VA: 0x180873260
	public void OnNameInput(string newName) { }

	// RVA: 0x872F40 Offset: 0x871540 VA: 0x180872F40
	public void OnClickedSaveNumber() { }

	// RVA: 0x8740E0 Offset: 0x8726E0 VA: 0x1808740E0
	public void UpdateAddContactButton() { }

	// RVA: 0x872A50 Offset: 0x871050 VA: 0x180872A50
	public void LoadDirectory(int direction) { }

	// RVA: 0x8741A0 Offset: 0x8727A0 VA: 0x1808741A0
	private void UpdateIncomingCallText(PhoneController c) { }

	[IteratorStateMachineAttribute] // RVA: 0x88F00 Offset: 0x88300 VA: 0x180088F00
	// RVA: 0x873860 Offset: 0x871E60 VA: 0x180873860
	private IEnumerator PlayInputBeepsForPhoneNumber(string number) { }

	// RVA: 0x8735F0 Offset: 0x871BF0 VA: 0x1808735F0
	public void OnReceivedAnsweringMessage(float length, bool canLeaveVoicemail) { }

	// RVA: 0x873830 Offset: 0x871E30 VA: 0x180873830
	public void OnStartedRecordingVoicemail(float duration) { }

	// RVA: 0x872820 Offset: 0x870E20 VA: 0x180872820
	public void FinishVoicemailRecording() { }

	// RVA: 0x8738F0 Offset: 0x871EF0 VA: 0x1808738F0
	public void PlayVoicemail(uint id) { }

	// RVA: 0x874080 Offset: 0x872680 VA: 0x180874080
	public void StopVoicemail() { }

	// RVA: 0x8725B0 Offset: 0x870BB0 VA: 0x1808725B0
	public void DeleteVoicemail(uint id) { }

	// RVA: 0x875210 Offset: 0x873810 VA: 0x180875210
	public float get_NormalisedAnsweringMessagePlayTime() { }

	// RVA: 0x875170 Offset: 0x873770 VA: 0x180875170
	public bool get_IsPlayingAnsweringMessage() { }

	// RVA: 0x8730C0 Offset: 0x8716C0 VA: 0x1808730C0
	public void OnClickedVoicemail() { }

	// RVA: 0x872580 Offset: 0x870B80 VA: 0x180872580
	public void CopyCurrentNumberToClipboard() { }

	// RVA: 0x8750D0 Offset: 0x8736D0 VA: 0x1808750D0
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

	// RVA: 0x9205B0 Offset: 0x91EBB0 VA: 0x1809205B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9207C0 Offset: 0x91EDC0 VA: 0x1809207C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

