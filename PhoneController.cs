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

	// RVA: 0x8711C0 Offset: 0x86F7C0 VA: 0x1808711C0
	public void PlayVoicemail(uint id) { }

	// RVA: 0x8719D0 Offset: 0x86FFD0 VA: 0x1808719D0
	public void StopVoicemail() { }

	// RVA: 0x8701D0 Offset: 0x86E7D0 VA: 0x1808701D0
	public void DeleteVoicemail(uint id) { }

	// RVA: 0x86FE40 Offset: 0x86E440 VA: 0x18086FE40
	public void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x871F40 Offset: 0x870540 VA: 0x180871F40
	public int get_MaxVoicemailSlots() { }

	// RVA: 0x872110 Offset: 0x870710 VA: 0x180872110
	public BasePlayer get_currentPlayer() { }

	// RVA: 0x8722B0 Offset: 0x8708B0 VA: 0x1808722B0
	public void set_currentPlayer(BasePlayer value) { }

	// RVA: 0x872190 Offset: 0x870790 VA: 0x180872190
	private bool get_isServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872240 Offset: 0x870840 VA: 0x180872240
	public int get_lastDialedNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8722C0 Offset: 0x8708C0 VA: 0x1808722C0
	public void set_lastDialedNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	public PhoneDirectory get_savedNumbers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8722D0 Offset: 0x8708D0 VA: 0x1808722D0
	public void set_savedNumbers(PhoneDirectory value) { }

	// RVA: 0x871FE0 Offset: 0x8705E0 VA: 0x180871FE0
	public BaseEntity get_ParentEntity() { }

	// RVA: 0x872020 Offset: 0x870620 VA: 0x180872020
	private Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872100 Offset: 0x870700 VA: 0x180872100
	public Telephone.CallState get_clientCallState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8722A0 Offset: 0x8708A0 VA: 0x1808722A0
	private void set_clientCallState(Telephone.CallState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871E40 Offset: 0x870440 VA: 0x180871E40
	public PhoneDialler get_CurrentDialog() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872290 Offset: 0x870890 VA: 0x180872290
	private void set_CurrentDialog(PhoneDialler value) { }

	// RVA: 0x871E00 Offset: 0x870400 VA: 0x180871E00
	public float get_CallDuration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701920 Offset: 0x6FFF20 VA: 0x180701920
	public PhoneDirectory get_currentDirectory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7019B0 Offset: 0x6FFFB0 VA: 0x1807019B0
	private void set_currentDirectory(PhoneDirectory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871E30 Offset: 0x870430 VA: 0x180871E30
	public int get_ConnectedCallPhoneNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872280 Offset: 0x870880 VA: 0x180872280
	private void set_ConnectedCallPhoneNumber(int value) { }

	// RVA: 0x870DA0 Offset: 0x86F3A0 VA: 0x180870DA0
	public void OpenDialler(BasePlayer player) { }

	// RVA: 0x86F300 Offset: 0x86D900 VA: 0x18086F300
	public void AnswerPhone(BasePlayer player) { }

	// RVA: 0x86F480 Offset: 0x86DA80 VA: 0x18086F480
	public void AnswerViaUI() { }

	// RVA: 0x870980 Offset: 0x86EF80 VA: 0x180870980
	public void OnClosedDialler(BasePlayer player) { }

	// RVA: 0x870D30 Offset: 0x86F330 VA: 0x180870D30
	public void OnLocalPlayerCancelled() { }

	// RVA: 0x871D40 Offset: 0x870340 VA: 0x180871D40
	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	// RVA: 0x8714C0 Offset: 0x86FAC0 VA: 0x1808714C0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	// RVA: 0x871AC0 Offset: 0x8700C0 VA: 0x180871AC0
	private void ToggleRingingLight() { }

	// RVA: 0x870130 Offset: 0x86E730 VA: 0x180870130
	public void ControllerLateUpdate() { }

	// RVA: 0x870240 Offset: 0x86E840 VA: 0x180870240
	public void DialNumber(int number) { }

	// RVA: 0x86F5B0 Offset: 0x86DBB0 VA: 0x18086F5B0
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x86FBA0 Offset: 0x86E1A0 VA: 0x18086FBA0
	public void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg, Cassette cachedCassette) { }

	// RVA: 0x86F8C0 Offset: 0x86DEC0 VA: 0x18086F8C0
	public void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871DF0 Offset: 0x8703F0 VA: 0x180871DF0
	public TimeSince get_AnsweringMessageStartTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872270 Offset: 0x870870 VA: 0x180872270
	private void set_AnsweringMessageStartTime(TimeSince value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871DE0 Offset: 0x8703E0 VA: 0x180871DE0
	public float get_AnsweringMachineMessageLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872260 Offset: 0x870860 VA: 0x180872260
	private void set_AnsweringMachineMessageLength(float value) { }

	// RVA: 0x870F20 Offset: 0x86F520 VA: 0x180870F20
	private void PlayAnsweringMessage(AudioClip clip, bool canLeaveVoicemail) { }

	// RVA: 0x870540 Offset: 0x86EB40 VA: 0x180870540
	public void InitiateVoicemailRecord() { }

	// RVA: 0x8702B0 Offset: 0x86E8B0 VA: 0x1808702B0
	public void FinishVoicemailRecording() { }

	// RVA: 0x86F4E0 Offset: 0x86DAE0 VA: 0x18086F4E0
	public void ClientHangUp() { }

	// RVA: 0x870D00 Offset: 0x86F300 VA: 0x180870D00
	public void OnIncomingCallDuringCall() { }

	// RVA: 0x870D50 Offset: 0x86F350 VA: 0x180870D50
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	// RVA: 0x871A30 Offset: 0x870030 VA: 0x180871A30
	public void SubmitNewName(string newName) { }

	// RVA: 0x871410 Offset: 0x86FA10 VA: 0x180871410
	public bool RequestPhoneDirectory(int page) { }

	// RVA: 0x871230 Offset: 0x86F830 VA: 0x180871230
	public void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	// RVA: 0x870020 Offset: 0x86E620 VA: 0x180870020
	public void Client_AddSavedNumber(uint number, string savedPhoneName) { }

	// RVA: 0x8700C0 Offset: 0x86E6C0 VA: 0x1808700C0
	public void Client_RemoveSavedNumber(uint number) { }

	// RVA: 0x870820 Offset: 0x86EE20 VA: 0x180870820
	public void OnClientLoaded() { }

	// RVA: 0x871E50 Offset: 0x870450 VA: 0x180871E50
	public bool get_IsDead() { }

	// RVA: 0x8706F0 Offset: 0x86ECF0 VA: 0x1808706F0
	private bool IsPowered() { }

	// RVA: 0x8707E0 Offset: 0x86EDE0 VA: 0x1808707E0
	public bool IsSavedContactValid(string contactName, int contactNumber) { }

	// RVA: 0x870B50 Offset: 0x86F150 VA: 0x180870B50
	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x871D80 Offset: 0x870380 VA: 0x180871D80
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871C80 Offset: 0x870280 VA: 0x180871C80
	private void <ClientToggleVoicemail>b__3_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871BC0 Offset: 0x8701C0 VA: 0x180871BC0
	private void <ClientReceiveAnsweringData>b__93_0(AudioClip clip, bool success) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871B00 Offset: 0x870100 VA: 0x180871B00
	private void <ClientPlayAnsweringMessage>b__94_0(AudioClip clip, bool success) { }

}

