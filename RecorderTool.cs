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

	// RVA: 0x93D500 Offset: 0x93BB00 VA: 0x18093D500 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93EC00 Offset: 0x93D200 VA: 0x18093EC00
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93EC10 Offset: 0x93D210 VA: 0x18093EC10
	private void set_cachedCassette(Cassette value) { }

	// RVA: 0x93EB30 Offset: 0x93D130 VA: 0x18093EB30
	public Sprite get_LoadedCassetteIcon() { }

	// RVA: 0x93CAC0 Offset: 0x93B0C0 VA: 0x18093CAC0
	private bool HasCassette() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 160
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x93CB20 Offset: 0x93B120 VA: 0x18093CB20 Slot: 162
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x93CDB0 Offset: 0x93B3B0 VA: 0x18093CDB0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x93CA40 Offset: 0x93B040 VA: 0x18093CA40 Slot: 20
	internal override void DoNetworkDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8389F0 Offset: 0x836FF0 VA: 0x1808389F0
	public int get_StartCountdown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x838A30 Offset: 0x837030 VA: 0x180838A30
	private void set_StartCountdown(int value) { }

	// RVA: 0x93EAB0 Offset: 0x93D0B0 VA: 0x18093EAB0
	private bool get_IsCountingDown() { }

	// RVA: 0x93EBC0 Offset: 0x93D1C0 VA: 0x18093EBC0
	public float get_NormalizedTapeUsed() { }

	// RVA: 0x93DE10 Offset: 0x93C410 VA: 0x18093DE10
	private void StartRecording() { }

	// RVA: 0x93E4C0 Offset: 0x93CAC0 VA: 0x18093E4C0
	private void TickDownStart() { }

	// RVA: 0x93E040 Offset: 0x93C640 VA: 0x18093E040
	public void StopRecording() { }

	// RVA: 0x93CB30 Offset: 0x93B130 VA: 0x18093CB30 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x93C570 Offset: 0x93AB70 VA: 0x18093C570
	private void CancelRecording() { }

	// RVA: 0x93DD50 Offset: 0x93C350 VA: 0x18093DD50
	private void RequestFileUpdate() { }

	// RVA: 0x93E5F0 Offset: 0x93CBF0 VA: 0x18093E5F0
	public void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x93CBA0 Offset: 0x93B1A0 VA: 0x18093CBA0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93C7C0 Offset: 0x93ADC0 VA: 0x18093C7C0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x93C980 Offset: 0x93AF80 VA: 0x18093C980
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x93D460 Offset: 0x93BA60 VA: 0x18093D460 Slot: 161
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x93E6C0 Offset: 0x93CCC0 VA: 0x18093E6C0
	private void UpdateViewmodelCassette(ViewModel vm) { }

	// RVA: 0x93E890 Offset: 0x93CE90 VA: 0x18093E890
	private void UpdateViewmodelPlay(BasePlayer forPlayer, ViewModel vm) { }

	// RVA: 0x93CB50 Offset: 0x93B150 VA: 0x18093CB50 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x93DD00 Offset: 0x93C300 VA: 0x18093DD00 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x93EA90 Offset: 0x93D090 VA: 0x18093EA90
	public void .ctor() { }

	// RVA: 0x93EA20 Offset: 0x93D020 VA: 0x18093EA20
	private static void .cctor() { }

}

