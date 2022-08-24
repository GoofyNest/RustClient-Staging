public class DeployedRecorder : StorageContainer, ICassettePlayer // TypeDefIndex: 8379
{	private Option __menuOption_Play; // 0x3D0
	private Option __menuOption_Stop; // 0x428
	public AudioSource SoundSource; // 0x480
	public ItemDefinition[] ValidCassettes; // 0x488
	public SoundDefinition PlaySfx; // 0x490
	public SoundDefinition StopSfx; // 0x498
	public SwapKeycard TapeSwapper; // 0x4A0
	private Cassette cachedCassette; // 0x4A8
	private bool initialLoad; // 0x4B0

	public override bool HasMenuOptions { get; }
	public BaseEntity ToBaseEntity { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public BaseEntity get_ToBaseEntity() { }

	protected override void ClientInit(Entity info) { }

	[BaseEntity.Menu] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Description] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Icon] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6DB0 Offset: 0xD61B0 VA: 0x1800D6DB0
	[BaseEntity.Menu.Description] // RVA: 0xD6DB0 Offset: 0xD61B0 VA: 0x1800D6DB0
	[BaseEntity.Menu.Icon] // RVA: 0xD6DB0 Offset: 0xD61B0 VA: 0x1800D6DB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6DB0 Offset: 0xD61B0 VA: 0x1800D6DB0
	public void Stop(BasePlayer forPlayer) { }

	private bool CanStop(BasePlayer forPlayer) { }

	private bool CanStart(BasePlayer forPlayer) { }

	private bool HasTape() { }

	private void UpdateAudioClip(AudioClip clip) { }

	private void UpdateCassetteMesh() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void OnLoadedWithCassette(Cassette c) { }

	public void OnCensorRecordingsChanged() { }

	public override void ResetState() { }

	public void .ctor() { }

}

