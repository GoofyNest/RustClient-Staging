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

	// RVA: 0x976970 Offset: 0x974F70 VA: 0x180976970 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x978DC0 Offset: 0x9773C0 VA: 0x180978DC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9773E0 Offset: 0x9759E0 VA: 0x1809773E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 167
	public BaseEntity get_ToBaseEntity() { }

	[BaseEntity.Menu] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Description] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Icon] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	// RVA: 0x977F70 Offset: 0x976570 VA: 0x180977F70
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Description] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Icon] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	// RVA: 0x978B50 Offset: 0x977150 VA: 0x180978B50
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x976600 Offset: 0x974C00 VA: 0x180976600
	private bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x9765D0 Offset: 0x974BD0 VA: 0x1809765D0
	private bool CanStart(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	[BaseEntity.Menu.Description] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	[BaseEntity.Menu.Icon] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	// RVA: 0x976630 Offset: 0x974C30 VA: 0x180976630
	public void ChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x9765A0 Offset: 0x974BA0 VA: 0x1809765A0
	private bool CanChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x977310 Offset: 0x975910 VA: 0x180977310 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9766B0 Offset: 0x974CB0 VA: 0x1809766B0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9766F0 Offset: 0x974CF0 VA: 0x1809766F0
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9773A0 Offset: 0x9759A0 VA: 0x1809773A0
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x978B80 Offset: 0x977180 VA: 0x180978B80
	public void WaitForShoutcastLoad() { }

	// RVA: 0x976660 Offset: 0x974C60 VA: 0x180976660
	public void ClearConnectedPositions() { }

	// RVA: 0x978410 Offset: 0x976A10 VA: 0x180978410
	public void SetAudioClipOnAttachedSpeakers(IOEntity entity, AudioClip clip, float time, int depth, ShoutcastStreamer streamer) { }

	// RVA: 0x977170 Offset: 0x975770 VA: 0x180977170
	private bool IsPositionValidForSpeaker(Vector3 pos) { }

	// RVA: 0x978850 Offset: 0x976E50 VA: 0x180978850 Slot: 170
	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	// RVA: 0x9789F0 Offset: 0x976FF0 VA: 0x1809789F0 Slot: 171
	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	// RVA: 0x977150 Offset: 0x975750 VA: 0x180977150 Slot: 172
	public AudioSource GetSource() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 173
	public float get_VolumeVisualisationMultiplier() { }

	// RVA: 0x977370 Offset: 0x975970 VA: 0x180977370 Slot: 168
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x9772E0 Offset: 0x9758E0 VA: 0x1809772E0 Slot: 169
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x9767B0 Offset: 0x974DB0 VA: 0x1809767B0
	public float GetClosestDistance(Vector3 position) { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 174
	public float GetFakeInput() { }

	// RVA: 0x977EA0 Offset: 0x9764A0 VA: 0x180977EA0
	public void OnStreamChangedByCensorSetting(bool connectingToStream) { }

	// RVA: 0x2FA9A0 Offset: 0x2F8FA0 VA: 0x1802FA9A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x978AD0 Offset: 0x9770D0 VA: 0x180978AD0
	public void StartPlayProximityCheck() { }

	// RVA: 0x976740 Offset: 0x974D40 VA: 0x180976740
	public void EndPlayProximityCheck() { }

	// RVA: 0x977FA0 Offset: 0x9765A0 VA: 0x180977FA0
	private void ProximityCheck() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 175
	public IOEntity ToEntity() { }

	// RVA: 0x976730 Offset: 0x974D30 VA: 0x180976730 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x977280 Offset: 0x975880 VA: 0x180977280 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x978D40 Offset: 0x977340 VA: 0x180978D40
	public void .ctor() { }

}

