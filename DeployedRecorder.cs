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

	// RVA: 0x979380 Offset: 0x977980 VA: 0x180979380 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x97A8C0 Offset: 0x978EC0 VA: 0x18097A8C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x979C40 Offset: 0x978240 VA: 0x180979C40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 155
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x979160 Offset: 0x977760 VA: 0x180979160 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0xD6A40 Offset: 0xD5E40 VA: 0x1800D6A40
	[BaseEntity.Menu.Description] // RVA: 0xD6A40 Offset: 0xD5E40 VA: 0x1800D6A40
	[BaseEntity.Menu.Icon] // RVA: 0xD6A40 Offset: 0xD5E40 VA: 0x1800D6A40
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6A40 Offset: 0xD5E40 VA: 0x1800D6A40
	// RVA: 0x97A550 Offset: 0x978B50 VA: 0x18097A550
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6CA0 Offset: 0xD60A0 VA: 0x1800D6CA0
	[BaseEntity.Menu.Description] // RVA: 0xD6CA0 Offset: 0xD60A0 VA: 0x1800D6CA0
	[BaseEntity.Menu.Icon] // RVA: 0xD6CA0 Offset: 0xD60A0 VA: 0x1800D6CA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6CA0 Offset: 0xD60A0 VA: 0x1800D6CA0
	// RVA: 0x97A660 Offset: 0x978C60 VA: 0x18097A660
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x9790D0 Offset: 0x9776D0 VA: 0x1809790D0
	private bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x979040 Offset: 0x977640 VA: 0x180979040
	private bool CanStart(BasePlayer forPlayer) { }

	// RVA: 0x9798E0 Offset: 0x977EE0 VA: 0x1809798E0
	private bool HasTape() { }

	// RVA: 0x97A710 Offset: 0x978D10 VA: 0x18097A710
	private void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x97A780 Offset: 0x978D80 VA: 0x18097A780
	private void UpdateCassetteMesh() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x979180 Offset: 0x977780 VA: 0x180979180
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x979320 Offset: 0x977920 VA: 0x180979320
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x979A00 Offset: 0x978000 VA: 0x180979A00 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x979BA0 Offset: 0x9781A0 VA: 0x180979BA0 Slot: 156
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x979940 Offset: 0x977F40 VA: 0x180979940 Slot: 157
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x97A600 Offset: 0x978C00 VA: 0x18097A600 Slot: 27
	public override void ResetState() { }

	// RVA: 0x97A860 Offset: 0x978E60 VA: 0x18097A860
	public void .ctor() { }

}

