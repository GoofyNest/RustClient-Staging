public class DeployableBoomBox : ContainerIOEntity, ICassettePlayer, IAudioConnectionSource // TypeDefIndex: 8378
{	private Option __menuOption_ChangeRadioSettings; // 0x378
	private Option __menuOption_Play; // 0x3D0
	private Option __menuOption_Stop; // 0x428
	public BoomBox BoxController; // 0x480
	public int PowerUsageWhilePlaying; // 0x488
	public const int MaxBacktrackHopsClient = 30;
	public bool IsStatic; // 0x48C
	private List<Vector3> connectedPositions; // 0x490
	private int lastConnectCount; // 0x498

	public override bool HasMenuOptions { get; }
	public BaseEntity ToBaseEntity { get; }
	public float VolumeVisualisationMultiplier { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public BaseEntity get_ToBaseEntity() { }

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

	[BaseEntity.Menu] // RVA: 0xD7060 Offset: 0xD6460 VA: 0x1800D7060
	[BaseEntity.Menu.Description] // RVA: 0xD7060 Offset: 0xD6460 VA: 0x1800D7060
	[BaseEntity.Menu.Icon] // RVA: 0xD7060 Offset: 0xD6460 VA: 0x1800D7060
	[BaseEntity.Menu.ShowIf] // RVA: 0xD7060 Offset: 0xD6460 VA: 0x1800D7060
	public void ChangeRadioSettings(BasePlayer player) { }

	private bool CanChangeRadioSettings(BasePlayer player) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	public void WaitForShoutcastLoad() { }

	public void ClearConnectedPositions() { }

	public void SetAudioClipOnAttachedSpeakers(IOEntity entity, AudioClip clip, float time, int depth, ShoutcastStreamer streamer) { }

	private bool IsPositionValidForSpeaker(Vector3 pos) { }

	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	public AudioSource GetSource() { }

	public float get_VolumeVisualisationMultiplier() { }

	public void OnLoadedWithCassette(Cassette c) { }

	public void OnCensorRecordingsChanged() { }

	public float GetClosestDistance(Vector3 position) { }

	public float GetFakeInput() { }

	public void OnStreamChangedByCensorSetting(bool connectingToStream) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public void StartPlayProximityCheck() { }

	public void EndPlayProximityCheck() { }

	private void ProximityCheck() { }

	public IOEntity ToEntity() { }

	public override int ConsumptionAmount() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

