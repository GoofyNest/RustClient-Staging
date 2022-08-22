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

	// RVA: 0x976E70 Offset: 0x975470 VA: 0x180976E70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9792C0 Offset: 0x9778C0 VA: 0x1809792C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9778E0 Offset: 0x975EE0 VA: 0x1809778E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 167
	public BaseEntity get_ToBaseEntity() { }

	[BaseEntity.Menu] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Description] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.Icon] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6AE0 Offset: 0xD5EE0 VA: 0x1800D6AE0
	// RVA: 0x978470 Offset: 0x976A70 VA: 0x180978470
	public void Play(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Description] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.Icon] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6D10 Offset: 0xD6110 VA: 0x1800D6D10
	// RVA: 0x979050 Offset: 0x977650 VA: 0x180979050
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x976B00 Offset: 0x975100 VA: 0x180976B00
	private bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x976AD0 Offset: 0x9750D0 VA: 0x180976AD0
	private bool CanStart(BasePlayer forPlayer) { }

	[BaseEntity.Menu] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	[BaseEntity.Menu.Description] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	[BaseEntity.Menu.Icon] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD6FC0 Offset: 0xD63C0 VA: 0x1800D6FC0
	// RVA: 0x976B30 Offset: 0x975130 VA: 0x180976B30
	public void ChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x976AA0 Offset: 0x9750A0 VA: 0x180976AA0
	private bool CanChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x977810 Offset: 0x975E10 VA: 0x180977810 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x976BB0 Offset: 0x9751B0 VA: 0x180976BB0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x976BF0 Offset: 0x9751F0 VA: 0x180976BF0
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9778A0 Offset: 0x975EA0 VA: 0x1809778A0
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x979080 Offset: 0x977680 VA: 0x180979080
	public void WaitForShoutcastLoad() { }

	// RVA: 0x976B60 Offset: 0x975160 VA: 0x180976B60
	public void ClearConnectedPositions() { }

	// RVA: 0x978910 Offset: 0x976F10 VA: 0x180978910
	public void SetAudioClipOnAttachedSpeakers(IOEntity entity, AudioClip clip, float time, int depth, ShoutcastStreamer streamer) { }

	// RVA: 0x977670 Offset: 0x975C70 VA: 0x180977670
	private bool IsPositionValidForSpeaker(Vector3 pos) { }

	// RVA: 0x978D50 Offset: 0x977350 VA: 0x180978D50 Slot: 170
	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	// RVA: 0x978EF0 Offset: 0x9774F0 VA: 0x180978EF0 Slot: 171
	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	// RVA: 0x977650 Offset: 0x975C50 VA: 0x180977650 Slot: 172
	public AudioSource GetSource() { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 173
	public float get_VolumeVisualisationMultiplier() { }

	// RVA: 0x977870 Offset: 0x975E70 VA: 0x180977870 Slot: 168
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x9777E0 Offset: 0x975DE0 VA: 0x1809777E0 Slot: 169
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x976CB0 Offset: 0x9752B0 VA: 0x180976CB0
	public float GetClosestDistance(Vector3 position) { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 174
	public float GetFakeInput() { }

	// RVA: 0x9783A0 Offset: 0x9769A0 VA: 0x1809783A0
	public void OnStreamChangedByCensorSetting(bool connectingToStream) { }

	// RVA: 0x2FA9A0 Offset: 0x2F8FA0 VA: 0x1802FA9A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x978FD0 Offset: 0x9775D0 VA: 0x180978FD0
	public void StartPlayProximityCheck() { }

	// RVA: 0x976C40 Offset: 0x975240 VA: 0x180976C40
	public void EndPlayProximityCheck() { }

	// RVA: 0x9784A0 Offset: 0x976AA0 VA: 0x1809784A0
	private void ProximityCheck() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 175
	public IOEntity ToEntity() { }

	// RVA: 0x976C30 Offset: 0x975230 VA: 0x180976C30 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x977780 Offset: 0x975D80 VA: 0x180977780 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x979240 Offset: 0x977840 VA: 0x180979240
	public void .ctor() { }

}

