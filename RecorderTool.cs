public class RecorderTool : ThrownWeapon, ICassettePlayer // TypeDefIndex: 8627
{	// Fields
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool debugRecording; // 0x0
	public AudioSource RecorderAudioSource; // 0x2A0
	public SoundDefinition RecordStartSfx; // 0x2A8
	public SoundDefinition RewindSfx; // 0x2B0
	public SoundDefinition RecordFinishedSfx; // 0x2B8
	public SoundDefinition PlayTapeSfx; // 0x2C0
	public SoundDefinition StopTapeSfx; // 0x2C8
	public float ThrowScale; // 0x2D0
	private bool recording; // 0x2D4
	public static bool IsRecording; // 0x1
	private AudioInterceptComponent activeIntercept; // 0x2D8
	private float recordStartTime; // 0x2E0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Cassette <cachedCassette>k__BackingField; // 0x2E8
	private OggEncoder currentEncoder; // 0x2F0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <StartCountdown>k__BackingField; // 0x2F8
	private Sound rewindingSound; // 0x300
	private uint cassetteToLoad; // 0x308
	private static readonly int PlayAnimBool; // 0x4

	// Properties
	public Cassette cachedCassette { get; set; }
	public Sprite LoadedCassetteIcon { get; }
	public BaseEntity ToBaseEntity { get; }
	public int StartCountdown { get; set; }
	private bool IsCountingDown { get; }
	public float NormalizedTapeUsed { get; }

	// Methods

	// RVA: 0x93CEE0 Offset: 0x93B4E0 VA: 0x18093CEE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x93E5E0 Offset: 0x93CBE0 VA: 0x18093E5E0
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x93E5F0 Offset: 0x93CBF0 VA: 0x18093E5F0
	private void set_cachedCassette(Cassette value) { }

	// RVA: 0x93E510 Offset: 0x93CB10 VA: 0x18093E510
	public Sprite get_LoadedCassetteIcon() { }

	// RVA: 0x93C4A0 Offset: 0x93AAA0 VA: 0x18093C4A0
	private bool HasCassette() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 160
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x93C500 Offset: 0x93AB00 VA: 0x18093C500 Slot: 162
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x93C790 Offset: 0x93AD90 VA: 0x18093C790 Slot: 138
	public override void OnInput() { }

	// RVA: 0x93C420 Offset: 0x93AA20 VA: 0x18093C420 Slot: 20
	internal override void DoNetworkDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x838390 Offset: 0x836990 VA: 0x180838390
	public int get_StartCountdown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8383D0 Offset: 0x8369D0 VA: 0x1808383D0
	private void set_StartCountdown(int value) { }

	// RVA: 0x93E490 Offset: 0x93CA90 VA: 0x18093E490
	private bool get_IsCountingDown() { }

	// RVA: 0x93E5A0 Offset: 0x93CBA0 VA: 0x18093E5A0
	public float get_NormalizedTapeUsed() { }

	// RVA: 0x93D7F0 Offset: 0x93BDF0 VA: 0x18093D7F0
	private void StartRecording() { }

	// RVA: 0x93DEA0 Offset: 0x93C4A0 VA: 0x18093DEA0
	private void TickDownStart() { }

	// RVA: 0x93DA20 Offset: 0x93C020 VA: 0x18093DA20
	public void StopRecording() { }

	// RVA: 0x93C510 Offset: 0x93AB10 VA: 0x18093C510 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x93BF50 Offset: 0x93A550 VA: 0x18093BF50
	private void CancelRecording() { }

	// RVA: 0x93D730 Offset: 0x93BD30 VA: 0x18093D730
	private void RequestFileUpdate() { }

	// RVA: 0x93DFD0 Offset: 0x93C5D0 VA: 0x18093DFD0
	public void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x93C580 Offset: 0x93AB80 VA: 0x18093C580 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x93C1A0 Offset: 0x93A7A0 VA: 0x18093C1A0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x93C360 Offset: 0x93A960 VA: 0x18093C360
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x93CE40 Offset: 0x93B440 VA: 0x18093CE40 Slot: 161
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x93E0A0 Offset: 0x93C6A0 VA: 0x18093E0A0
	private void UpdateViewmodelCassette(ViewModel vm) { }

	// RVA: 0x93E270 Offset: 0x93C870 VA: 0x18093E270
	private void UpdateViewmodelPlay(BasePlayer forPlayer, ViewModel vm) { }

	// RVA: 0x93C530 Offset: 0x93AB30 VA: 0x18093C530 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x93D6E0 Offset: 0x93BCE0 VA: 0x18093D6E0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x93E470 Offset: 0x93CA70 VA: 0x18093E470
	public void .ctor() { }

	// RVA: 0x93E400 Offset: 0x93CA00 VA: 0x18093E400
	private static void .cctor() { }

}

