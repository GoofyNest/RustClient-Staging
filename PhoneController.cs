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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <lastDialedNumber>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private PhoneDirectory <savedNumbers>k__BackingField; // 0xE8
	public List<VoicemailEntry> savedVoicemail; // 0xF0
	private SoundDefinition currentlyLoadedPreloadedContent; // 0xF8
	private string connectedPlayerId; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Telephone.CallState <clientCallState>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private PhoneDialler <CurrentDialog>k__BackingField; // 0x110
	private float callStartTime; // 0x118
	private Sound ringingSound; // 0x120
	private Sound dialingSound; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private PhoneDirectory <currentDirectory>k__BackingField; // 0x130
	private TimeSince lastDirectoryUpdate; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <ConnectedCallPhoneNumber>k__BackingField; // 0x13C
	private int voicemailTarget; // 0x140
	private OggEncoder currentEncoder; // 0x148
	private AudioInterceptComponent activeIntercept; // 0x150
	private int requestedDialNumber; // 0x158
	private bool cachedCanLeaveVoicemail; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TimeSince <AnsweringMessageStartTime>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x8710B0 Offset: 0x86F6B0 VA: 0x1808710B0
	public void PlayVoicemail(uint id) { }

	// RVA: 0x8718C0 Offset: 0x86FEC0 VA: 0x1808718C0
	public void StopVoicemail() { }

	// RVA: 0x8700C0 Offset: 0x86E6C0 VA: 0x1808700C0
	public void DeleteVoicemail(uint id) { }

	// RVA: 0x86FD30 Offset: 0x86E330 VA: 0x18086FD30
	public void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x871E30 Offset: 0x870430 VA: 0x180871E30
	public int get_MaxVoicemailSlots() { }

	// RVA: 0x872000 Offset: 0x870600 VA: 0x180872000
	public BasePlayer get_currentPlayer() { }

	// RVA: 0x8721A0 Offset: 0x8707A0 VA: 0x1808721A0
	public void set_currentPlayer(BasePlayer value) { }

	// RVA: 0x872080 Offset: 0x870680 VA: 0x180872080
	private bool get_isServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x872130 Offset: 0x870730 VA: 0x180872130
	public int get_lastDialedNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8721B0 Offset: 0x8707B0 VA: 0x1808721B0
	public void set_lastDialedNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	public PhoneDirectory get_savedNumbers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8721C0 Offset: 0x8707C0 VA: 0x1808721C0
	public void set_savedNumbers(PhoneDirectory value) { }

	// RVA: 0x871ED0 Offset: 0x8704D0 VA: 0x180871ED0
	public BaseEntity get_ParentEntity() { }

	// RVA: 0x871F10 Offset: 0x870510 VA: 0x180871F10
	private Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x871FF0 Offset: 0x8705F0 VA: 0x180871FF0
	public Telephone.CallState get_clientCallState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x872190 Offset: 0x870790 VA: 0x180872190
	private void set_clientCallState(Telephone.CallState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x871D30 Offset: 0x870330 VA: 0x180871D30
	public PhoneDialler get_CurrentDialog() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x872180 Offset: 0x870780 VA: 0x180872180
	private void set_CurrentDialog(PhoneDialler value) { }

	// RVA: 0x871CF0 Offset: 0x8702F0 VA: 0x180871CF0
	public float get_CallDuration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x701810 Offset: 0x6FFE10 VA: 0x180701810
	public PhoneDirectory get_currentDirectory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7018A0 Offset: 0x6FFEA0 VA: 0x1807018A0
	private void set_currentDirectory(PhoneDirectory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x871D20 Offset: 0x870320 VA: 0x180871D20
	public int get_ConnectedCallPhoneNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x872170 Offset: 0x870770 VA: 0x180872170
	private void set_ConnectedCallPhoneNumber(int value) { }

	// RVA: 0x870C90 Offset: 0x86F290 VA: 0x180870C90
	public void OpenDialler(BasePlayer player) { }

	// RVA: 0x86F1F0 Offset: 0x86D7F0 VA: 0x18086F1F0
	public void AnswerPhone(BasePlayer player) { }

	// RVA: 0x86F370 Offset: 0x86D970 VA: 0x18086F370
	public void AnswerViaUI() { }

	// RVA: 0x870870 Offset: 0x86EE70 VA: 0x180870870
	public void OnClosedDialler(BasePlayer player) { }

	// RVA: 0x870C20 Offset: 0x86F220 VA: 0x180870C20
	public void OnLocalPlayerCancelled() { }

	// RVA: 0x871C30 Offset: 0x870230 VA: 0x180871C30
	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	// RVA: 0x8713B0 Offset: 0x86F9B0 VA: 0x1808713B0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	// RVA: 0x8719B0 Offset: 0x86FFB0 VA: 0x1808719B0
	private void ToggleRingingLight() { }

	// RVA: 0x870020 Offset: 0x86E620 VA: 0x180870020
	public void ControllerLateUpdate() { }

	// RVA: 0x870130 Offset: 0x86E730 VA: 0x180870130
	public void DialNumber(int number) { }

	// RVA: 0x86F4A0 Offset: 0x86DAA0 VA: 0x18086F4A0
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x86FA90 Offset: 0x86E090 VA: 0x18086FA90
	public void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg, Cassette cachedCassette) { }

	// RVA: 0x86F7B0 Offset: 0x86DDB0 VA: 0x18086F7B0
	public void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x871CE0 Offset: 0x8702E0 VA: 0x180871CE0
	public TimeSince get_AnsweringMessageStartTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x872160 Offset: 0x870760 VA: 0x180872160
	private void set_AnsweringMessageStartTime(TimeSince value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x871CD0 Offset: 0x8702D0 VA: 0x180871CD0
	public float get_AnsweringMachineMessageLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x872150 Offset: 0x870750 VA: 0x180872150
	private void set_AnsweringMachineMessageLength(float value) { }

	// RVA: 0x870E10 Offset: 0x86F410 VA: 0x180870E10
	private void PlayAnsweringMessage(AudioClip clip, bool canLeaveVoicemail) { }

	// RVA: 0x870430 Offset: 0x86EA30 VA: 0x180870430
	public void InitiateVoicemailRecord() { }

	// RVA: 0x8701A0 Offset: 0x86E7A0 VA: 0x1808701A0
	public void FinishVoicemailRecording() { }

	// RVA: 0x86F3D0 Offset: 0x86D9D0 VA: 0x18086F3D0
	public void ClientHangUp() { }

	// RVA: 0x870BF0 Offset: 0x86F1F0 VA: 0x180870BF0
	public void OnIncomingCallDuringCall() { }

	// RVA: 0x870C40 Offset: 0x86F240 VA: 0x180870C40
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	// RVA: 0x871920 Offset: 0x86FF20 VA: 0x180871920
	public void SubmitNewName(string newName) { }

	// RVA: 0x871300 Offset: 0x86F900 VA: 0x180871300
	public bool RequestPhoneDirectory(int page) { }

	// RVA: 0x871120 Offset: 0x86F720 VA: 0x180871120
	public void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	// RVA: 0x86FF10 Offset: 0x86E510 VA: 0x18086FF10
	public void Client_AddSavedNumber(uint number, string savedPhoneName) { }

	// RVA: 0x86FFB0 Offset: 0x86E5B0 VA: 0x18086FFB0
	public void Client_RemoveSavedNumber(uint number) { }

	// RVA: 0x870710 Offset: 0x86ED10 VA: 0x180870710
	public void OnClientLoaded() { }

	// RVA: 0x871D40 Offset: 0x870340 VA: 0x180871D40
	public bool get_IsDead() { }

	// RVA: 0x8705E0 Offset: 0x86EBE0 VA: 0x1808705E0
	private bool IsPowered() { }

	// RVA: 0x8706D0 Offset: 0x86ECD0 VA: 0x1808706D0
	public bool IsSavedContactValid(string contactName, int contactNumber) { }

	// RVA: 0x870A40 Offset: 0x86F040 VA: 0x180870A40
	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x871C70 Offset: 0x870270 VA: 0x180871C70
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x871B70 Offset: 0x870170 VA: 0x180871B70
	private void <ClientToggleVoicemail>b__3_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x871AB0 Offset: 0x8700B0 VA: 0x180871AB0
	private void <ClientReceiveAnsweringData>b__93_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8719F0 Offset: 0x86FFF0 VA: 0x1808719F0
	private void <ClientPlayAnsweringMessage>b__94_0(AudioClip clip, bool success) { }

}

