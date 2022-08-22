public class DeployableBoomBox : ContainerIOEntity, ICassettePlayer, IAudioConnectionSource // TypeDefIndex: 8378
{	// Fields
	private Option __menuOption_ChangeRadioSettings; // 0x378
	private Option __menuOption_Play; // 0x3D0
	private Option __menuOption_Stop; // 0x428
	public BoomBox BoxController; // 0x480
	public int PowerUsageWhilePlaying; // 0x488
	public const int MaxBacktrackHopsClient = 30;
	public bool IsStatic; // 0x48C
	private List<Vector3> connectedPositions; // 0x490
	private int lastConnectCount; // 0x498

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseEntity ToBaseEntity { get; }
	public float VolumeVisualisationMultiplier { get; }

	// Methods

	// RVA: 0x976860 Offset: 0x974E60 VA: 0x180976860 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x978CB0 Offset: 0x9772B0 VA: 0x180978CB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9772D0 Offset: 0x9758D0 VA: 0x1809772D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 167
	public BaseEntity get_ToBaseEntity() { }

	[BaseEntity.Menu] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Description] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Icon] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	// RVA: 0x977E60 Offset: 0x976460 VA: 0x180977E60
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Description] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Icon] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	// RVA: 0x978A40 Offset: 0x977040 VA: 0x180978A40
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x9764F0 Offset: 0x974AF0 VA: 0x1809764F0
	private bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x9764C0 Offset: 0x974AC0 VA: 0x1809764C0
	private bool CanStart(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	[BaseEntity.Menu.Description] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	[BaseEntity.Menu.Icon] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	// RVA: 0x976520 Offset: 0x974B20 VA: 0x180976520
	public void ChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x976490 Offset: 0x974A90 VA: 0x180976490
	private bool CanChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x977200 Offset: 0x975800 VA: 0x180977200 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9765A0 Offset: 0x974BA0 VA: 0x1809765A0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9765E0 Offset: 0x974BE0 VA: 0x1809765E0
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x977290 Offset: 0x975890 VA: 0x180977290
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x978A70 Offset: 0x977070 VA: 0x180978A70
	public void WaitForShoutcastLoad() { }

	// RVA: 0x976550 Offset: 0x974B50 VA: 0x180976550
	public void ClearConnectedPositions() { }

	// RVA: 0x978300 Offset: 0x976900 VA: 0x180978300
	public void SetAudioClipOnAttachedSpeakers(IOEntity entity, AudioClip clip, float time, int depth, ShoutcastStreamer streamer) { }

	// RVA: 0x977060 Offset: 0x975660 VA: 0x180977060
	private bool IsPositionValidForSpeaker(Vector3 pos) { }

	// RVA: 0x978740 Offset: 0x976D40 VA: 0x180978740 Slot: 170
	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	// RVA: 0x9788E0 Offset: 0x976EE0 VA: 0x1809788E0 Slot: 171
	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	// RVA: 0x977040 Offset: 0x975640 VA: 0x180977040 Slot: 172
	public AudioSource GetSource() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 173
	public float get_VolumeVisualisationMultiplier() { }

	// RVA: 0x977260 Offset: 0x975860 VA: 0x180977260 Slot: 168
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x9771D0 Offset: 0x9757D0 VA: 0x1809771D0 Slot: 169
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x9766A0 Offset: 0x974CA0 VA: 0x1809766A0
	public float GetClosestDistance(Vector3 position) { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 174
	public float GetFakeInput() { }

	// RVA: 0x977D90 Offset: 0x976390 VA: 0x180977D90
	public void OnStreamChangedByCensorSetting(bool connectingToStream) { }

	// RVA: 0x2FA9A0 Offset: 0x2F8FA0 VA: 0x1802FA9A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x9789C0 Offset: 0x976FC0 VA: 0x1809789C0
	public void StartPlayProximityCheck() { }

	// RVA: 0x976630 Offset: 0x974C30 VA: 0x180976630
	public void EndPlayProximityCheck() { }

	// RVA: 0x977E90 Offset: 0x976490 VA: 0x180977E90
	private void ProximityCheck() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 175
	public IOEntity ToEntity() { }

	// RVA: 0x976620 Offset: 0x974C20 VA: 0x180976620 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x977170 Offset: 0x975770 VA: 0x180977170 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x978C30 Offset: 0x977230 VA: 0x180978C30
	public void .ctor() { }

}

