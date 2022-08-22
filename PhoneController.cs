public class PhoneController : EntityComponent<BaseEntity> // TypeDefIndex: 9451
{	// Fields
	public int PhoneNumber; // 0x20
	public string PhoneName; // 0x28
	public bool CanModifyPhoneName; // 0x30
	public bool CanSaveNumbers; // 0x31
	public bool RequirePower; // 0x32
	public bool RequireParent; // 0x33
	public float CallWaitingTime; // 0x34
	public bool AppendGridToName; // 0x38
	public bool IsMobile; // 0x39
	public bool CanSaveVoicemail; // 0x3A
	public GameObjectRef PhoneDialog; // 0x40
	public VoiceProcessor VProcessor; // 0x48
	public PreloadedCassetteContent PreloadedContent; // 0x50
	public SoundDefinition DialToneSfx; // 0x58
	public SoundDefinition RingingSfx; // 0x60
	public SoundDefinition ErrorSfx; // 0x68
	public SoundDefinition CallIncomingWhileBusySfx; // 0x70
	public SoundDefinition PickupHandsetSfx; // 0x78
	public SoundDefinition PutDownHandsetSfx; // 0x80
	public SoundDefinition FailedWrongNumber; // 0x88
	public SoundDefinition FailedNoAnswer; // 0x90
	public SoundDefinition FailedNetworkBusy; // 0x98
	public SoundDefinition FailedEngaged; // 0xA0
	public SoundDefinition FailedRemoteHangUp; // 0xA8
	public SoundDefinition FailedSelfHangUp; // 0xB0
	public Light RingingLight; // 0xB8
	public float RingingLightFrequency; // 0xC0
	public AudioSource answeringMachineSound; // 0xC8
	public EntityRef currentPlayerRef; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <lastDialedNumber>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PhoneDirectory <savedNumbers>k__BackingField; // 0xE8
	public List<VoicemailEntry> savedVoicemail; // 0xF0
	private SoundDefinition currentlyLoadedPreloadedContent; // 0xF8
	private string connectedPlayerId; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Telephone.CallState <clientCallState>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PhoneDialler <CurrentDialog>k__BackingField; // 0x110
	private float callStartTime; // 0x118
	private Sound ringingSound; // 0x120
	private Sound dialingSound; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PhoneDirectory <currentDirectory>k__BackingField; // 0x130
	private TimeSince lastDirectoryUpdate; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ConnectedCallPhoneNumber>k__BackingField; // 0x13C
	private int voicemailTarget; // 0x140
	private OggEncoder currentEncoder; // 0x148
	private AudioInterceptComponent activeIntercept; // 0x150
	private int requestedDialNumber; // 0x158
	private bool cachedCanLeaveVoicemail; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TimeSince <AnsweringMessageStartTime>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <AnsweringMachineMessageLength>k__BackingField; // 0x164

	// Properties
	public int MaxVoicemailSlots { get; }
	public BasePlayer currentPlayer { get; set; }
	private bool isServer { get; }
	public int lastDialedNumber { get; set; }
	public PhoneDirectory savedNumbers { get; set; }
	public BaseEntity ParentEntity { get; }
	private Cassette cachedCassette { get; }
	public Telephone.CallState clientCallState { get; set; }
	public PhoneDialler CurrentDialog { get; set; }
	public float CallDuration { get; }
	public PhoneDirectory currentDirectory { get; set; }
	public int ConnectedCallPhoneNumber { get; set; }
	public TimeSince AnsweringMessageStartTime { get; set; }
	public float AnsweringMachineMessageLength { get; set; }
	public bool IsDead { get; }

	// Methods

	// RVA: 0x88C8E0 Offset: 0x88AEE0 VA: 0x18088C8E0
	public void PlayVoicemail(uint id) { }

	// RVA: 0x88D0F0 Offset: 0x88B6F0 VA: 0x18088D0F0
	public void StopVoicemail() { }

	// RVA: 0x88B8F0 Offset: 0x889EF0 VA: 0x18088B8F0
	public void DeleteVoicemail(uint id) { }

	// RVA: 0x88B560 Offset: 0x889B60 VA: 0x18088B560
	public void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x88D660 Offset: 0x88BC60 VA: 0x18088D660
	public int get_MaxVoicemailSlots() { }

	// RVA: 0x88D830 Offset: 0x88BE30 VA: 0x18088D830
	public BasePlayer get_currentPlayer() { }

	// RVA: 0x88D9D0 Offset: 0x88BFD0 VA: 0x18088D9D0
	public void set_currentPlayer(BasePlayer value) { }

	// RVA: 0x88D8B0 Offset: 0x88BEB0 VA: 0x18088D8B0
	private bool get_isServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D960 Offset: 0x88BF60 VA: 0x18088D960
	public int get_lastDialedNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9E0 Offset: 0x88BFE0 VA: 0x18088D9E0
	public void set_lastDialedNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	public PhoneDirectory get_savedNumbers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9F0 Offset: 0x88BFF0 VA: 0x18088D9F0
	public void set_savedNumbers(PhoneDirectory value) { }

	// RVA: 0x88D700 Offset: 0x88BD00 VA: 0x18088D700
	public BaseEntity get_ParentEntity() { }

	// RVA: 0x88D740 Offset: 0x88BD40 VA: 0x18088D740
	private Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D820 Offset: 0x88BE20 VA: 0x18088D820
	public Telephone.CallState get_clientCallState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9C0 Offset: 0x88BFC0 VA: 0x18088D9C0
	private void set_clientCallState(Telephone.CallState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D560 Offset: 0x88BB60 VA: 0x18088D560
	public PhoneDialler get_CurrentDialog() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9B0 Offset: 0x88BFB0 VA: 0x18088D9B0
	private void set_CurrentDialog(PhoneDialler value) { }

	// RVA: 0x88D520 Offset: 0x88BB20 VA: 0x18088D520
	public float get_CallDuration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701870 Offset: 0x6FFE70 VA: 0x180701870
	public PhoneDirectory get_currentDirectory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701900 Offset: 0x6FFF00 VA: 0x180701900
	private void set_currentDirectory(PhoneDirectory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D550 Offset: 0x88BB50 VA: 0x18088D550
	public int get_ConnectedCallPhoneNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9A0 Offset: 0x88BFA0 VA: 0x18088D9A0
	private void set_ConnectedCallPhoneNumber(int value) { }

	// RVA: 0x88C4C0 Offset: 0x88AAC0 VA: 0x18088C4C0
	public void OpenDialler(BasePlayer player) { }

	// RVA: 0x88AA20 Offset: 0x889020 VA: 0x18088AA20
	public void AnswerPhone(BasePlayer player) { }

	// RVA: 0x88ABA0 Offset: 0x8891A0 VA: 0x18088ABA0
	public void AnswerViaUI() { }

	// RVA: 0x88C0A0 Offset: 0x88A6A0 VA: 0x18088C0A0
	public void OnClosedDialler(BasePlayer player) { }

	// RVA: 0x88C450 Offset: 0x88AA50 VA: 0x18088C450
	public void OnLocalPlayerCancelled() { }

	// RVA: 0x88D460 Offset: 0x88BA60 VA: 0x18088D460
	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	// RVA: 0x88CBE0 Offset: 0x88B1E0 VA: 0x18088CBE0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	// RVA: 0x88D1E0 Offset: 0x88B7E0 VA: 0x18088D1E0
	private void ToggleRingingLight() { }

	// RVA: 0x88B850 Offset: 0x889E50 VA: 0x18088B850
	public void ControllerLateUpdate() { }

	// RVA: 0x88B960 Offset: 0x889F60 VA: 0x18088B960
	public void DialNumber(int number) { }

	// RVA: 0x88ACD0 Offset: 0x8892D0 VA: 0x18088ACD0
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x88B2C0 Offset: 0x8898C0 VA: 0x18088B2C0
	public void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg, Cassette cachedCassette) { }

	// RVA: 0x88AFE0 Offset: 0x8895E0 VA: 0x18088AFE0
	public void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D510 Offset: 0x88BB10 VA: 0x18088D510
	public TimeSince get_AnsweringMessageStartTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D990 Offset: 0x88BF90 VA: 0x18088D990
	private void set_AnsweringMessageStartTime(TimeSince value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D500 Offset: 0x88BB00 VA: 0x18088D500
	public float get_AnsweringMachineMessageLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D980 Offset: 0x88BF80 VA: 0x18088D980
	private void set_AnsweringMachineMessageLength(float value) { }

	// RVA: 0x88C640 Offset: 0x88AC40 VA: 0x18088C640
	private void PlayAnsweringMessage(AudioClip clip, bool canLeaveVoicemail) { }

	// RVA: 0x88BC60 Offset: 0x88A260 VA: 0x18088BC60
	public void InitiateVoicemailRecord() { }

	// RVA: 0x88B9D0 Offset: 0x889FD0 VA: 0x18088B9D0
	public void FinishVoicemailRecording() { }

	// RVA: 0x88AC00 Offset: 0x889200 VA: 0x18088AC00
	public void ClientHangUp() { }

	// RVA: 0x88C420 Offset: 0x88AA20 VA: 0x18088C420
	public void OnIncomingCallDuringCall() { }

	// RVA: 0x88C470 Offset: 0x88AA70 VA: 0x18088C470
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	// RVA: 0x88D150 Offset: 0x88B750 VA: 0x18088D150
	public void SubmitNewName(string newName) { }

	// RVA: 0x88CB30 Offset: 0x88B130 VA: 0x18088CB30
	public bool RequestPhoneDirectory(int page) { }

	// RVA: 0x88C950 Offset: 0x88AF50 VA: 0x18088C950
	public void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	// RVA: 0x88B740 Offset: 0x889D40 VA: 0x18088B740
	public void Client_AddSavedNumber(uint number, string savedPhoneName) { }

	// RVA: 0x88B7E0 Offset: 0x889DE0 VA: 0x18088B7E0
	public void Client_RemoveSavedNumber(uint number) { }

	// RVA: 0x88BF40 Offset: 0x88A540 VA: 0x18088BF40
	public void OnClientLoaded() { }

	// RVA: 0x88D570 Offset: 0x88BB70 VA: 0x18088D570
	public bool get_IsDead() { }

	// RVA: 0x88BE10 Offset: 0x88A410 VA: 0x18088BE10
	private bool IsPowered() { }

	// RVA: 0x88BF00 Offset: 0x88A500 VA: 0x18088BF00
	public bool IsSavedContactValid(string contactName, int contactNumber) { }

	// RVA: 0x88C270 Offset: 0x88A870 VA: 0x18088C270
	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x88D4A0 Offset: 0x88BAA0 VA: 0x18088D4A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D3A0 Offset: 0x88B9A0 VA: 0x18088D3A0
	private void <ClientToggleVoicemail>b__3_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D2E0 Offset: 0x88B8E0 VA: 0x18088D2E0
	private void <ClientReceiveAnsweringData>b__93_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D220 Offset: 0x88B820 VA: 0x18088D220
	private void <ClientPlayAnsweringMessage>b__94_0(AudioClip clip, bool success) { }

}

