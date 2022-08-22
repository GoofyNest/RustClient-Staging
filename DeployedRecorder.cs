public class DeployedRecorder : StorageContainer, ICassettePlayer // TypeDefIndex: 8379
{	// Fields
	private Option __menuOption_Play; // 0x3D0
	private Option __menuOption_Stop; // 0x428
	public AudioSource SoundSource; // 0x480
	public ItemDefinition[] ValidCassettes; // 0x488
	public SoundDefinition PlaySfx; // 0x490
	public SoundDefinition StopSfx; // 0x498
	public SwapKeycard TapeSwapper; // 0x4A0
	private Cassette cachedCassette; // 0x4A8
	private bool initialLoad; // 0x4B0

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: 0x979490 Offset: 0x977A90 VA: 0x180979490 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x97A9D0 Offset: 0x978FD0 VA: 0x18097A9D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x979D50 Offset: 0x978350 VA: 0x180979D50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 155
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x979270 Offset: 0x977870 VA: 0x180979270 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Description] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Icon] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	// RVA: 0x97A660 Offset: 0x978C60 VA: 0x18097A660
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Description] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Icon] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	// RVA: 0x97A770 Offset: 0x978D70 VA: 0x18097A770
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x9791E0 Offset: 0x9777E0 VA: 0x1809791E0
	private bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x979150 Offset: 0x977750 VA: 0x180979150
	private bool CanStart(BasePlayer forPlayer) { }

	// RVA: 0x9799F0 Offset: 0x977FF0 VA: 0x1809799F0
	private bool HasTape() { }

	// RVA: 0x97A820 Offset: 0x978E20 VA: 0x18097A820
	private void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x97A890 Offset: 0x978E90 VA: 0x18097A890
	private void UpdateCassetteMesh() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x979290 Offset: 0x977890 VA: 0x180979290
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x979430 Offset: 0x977A30 VA: 0x180979430
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x979B10 Offset: 0x978110 VA: 0x180979B10 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x979CB0 Offset: 0x9782B0 VA: 0x180979CB0 Slot: 156
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x979A50 Offset: 0x978050 VA: 0x180979A50 Slot: 157
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x97A710 Offset: 0x978D10 VA: 0x18097A710 Slot: 27
	public override void ResetState() { }

	// RVA: 0x97A970 Offset: 0x978F70 VA: 0x18097A970
	public void .ctor() { }

}

