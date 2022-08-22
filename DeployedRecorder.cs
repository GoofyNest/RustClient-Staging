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

	// RVA: 0x979990 Offset: 0x977F90 VA: 0x180979990 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x97AED0 Offset: 0x9794D0 VA: 0x18097AED0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x97A250 Offset: 0x978850 VA: 0x18097A250 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 155
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x979770 Offset: 0x977D70 VA: 0x180979770 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Description] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Icon] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	// RVA: 0x97AB60 Offset: 0x979160 VA: 0x18097AB60
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Description] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Icon] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	// RVA: 0x97AC70 Offset: 0x979270 VA: 0x18097AC70
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x9796E0 Offset: 0x977CE0 VA: 0x1809796E0
	private bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x979650 Offset: 0x977C50 VA: 0x180979650
	private bool CanStart(BasePlayer forPlayer) { }

	// RVA: 0x979EF0 Offset: 0x9784F0 VA: 0x180979EF0
	private bool HasTape() { }

	// RVA: 0x97AD20 Offset: 0x979320 VA: 0x18097AD20
	private void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x97AD90 Offset: 0x979390 VA: 0x18097AD90
	private void UpdateCassetteMesh() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x979790 Offset: 0x977D90 VA: 0x180979790
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x979930 Offset: 0x977F30 VA: 0x180979930
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x97A010 Offset: 0x978610 VA: 0x18097A010 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x97A1B0 Offset: 0x9787B0 VA: 0x18097A1B0 Slot: 156
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x979F50 Offset: 0x978550 VA: 0x180979F50 Slot: 157
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x97AC10 Offset: 0x979210 VA: 0x18097AC10 Slot: 27
	public override void ResetState() { }

	// RVA: 0x97AE70 Offset: 0x979470 VA: 0x18097AE70
	public void .ctor() { }

}

