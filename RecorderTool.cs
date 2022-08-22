public class RecorderTool : ThrownWeapon, ICassettePlayer // TypeDefIndex: 8627
{	// Fields
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Cassette <cachedCassette>k__BackingField; // 0x2E8
	private OggEncoder currentEncoder; // 0x2F0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x93CFF0 Offset: 0x93B5F0 VA: 0x18093CFF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93E6F0 Offset: 0x93CCF0 VA: 0x18093E6F0
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93E700 Offset: 0x93CD00 VA: 0x18093E700
	private void set_cachedCassette(Cassette value) { }

	// RVA: 0x93E620 Offset: 0x93CC20 VA: 0x18093E620
	public Sprite get_LoadedCassetteIcon() { }

	// RVA: 0x93C5B0 Offset: 0x93ABB0 VA: 0x18093C5B0
	private bool HasCassette() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 160
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x93C610 Offset: 0x93AC10 VA: 0x18093C610 Slot: 162
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x93C8A0 Offset: 0x93AEA0 VA: 0x18093C8A0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x93C530 Offset: 0x93AB30 VA: 0x18093C530 Slot: 20
	internal override void DoNetworkDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8384A0 Offset: 0x836AA0 VA: 0x1808384A0
	public int get_StartCountdown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8384E0 Offset: 0x836AE0 VA: 0x1808384E0
	private void set_StartCountdown(int value) { }

	// RVA: 0x93E5A0 Offset: 0x93CBA0 VA: 0x18093E5A0
	private bool get_IsCountingDown() { }

	// RVA: 0x93E6B0 Offset: 0x93CCB0 VA: 0x18093E6B0
	public float get_NormalizedTapeUsed() { }

	// RVA: 0x93D900 Offset: 0x93BF00 VA: 0x18093D900
	private void StartRecording() { }

	// RVA: 0x93DFB0 Offset: 0x93C5B0 VA: 0x18093DFB0
	private void TickDownStart() { }

	// RVA: 0x93DB30 Offset: 0x93C130 VA: 0x18093DB30
	public void StopRecording() { }

	// RVA: 0x93C620 Offset: 0x93AC20 VA: 0x18093C620 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x93C060 Offset: 0x93A660 VA: 0x18093C060
	private void CancelRecording() { }

	// RVA: 0x93D840 Offset: 0x93BE40 VA: 0x18093D840
	private void RequestFileUpdate() { }

	// RVA: 0x93E0E0 Offset: 0x93C6E0 VA: 0x18093E0E0
	public void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x93C690 Offset: 0x93AC90 VA: 0x18093C690 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93C2B0 Offset: 0x93A8B0 VA: 0x18093C2B0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93C470 Offset: 0x93AA70 VA: 0x18093C470
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x93CF50 Offset: 0x93B550 VA: 0x18093CF50 Slot: 161
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x93E1B0 Offset: 0x93C7B0 VA: 0x18093E1B0
	private void UpdateViewmodelCassette(ViewModel vm) { }

	// RVA: 0x93E380 Offset: 0x93C980 VA: 0x18093E380
	private void UpdateViewmodelPlay(BasePlayer forPlayer, ViewModel vm) { }

	// RVA: 0x93C640 Offset: 0x93AC40 VA: 0x18093C640 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x93D7F0 Offset: 0x93BDF0 VA: 0x18093D7F0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x93E580 Offset: 0x93CB80 VA: 0x18093E580
	public void .ctor() { }

	// RVA: 0x93E510 Offset: 0x93CB10 VA: 0x18093E510
	private static void .cctor() { }

}

