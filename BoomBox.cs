public class BoomBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6391
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string radioIp; // 0x18
	public ulong assignedRadioBy; // 0x20

	// Methods

	// RVA: 0x1F6CF00 Offset: 0x1F6B500 VA: 0x181F6CF00
	public static void ResetToPool(BoomBox instance) { }

	// RVA: 0x1F6CE50 Offset: 0x1F6B450 VA: 0x181F6CE50
	public void ResetToPool() { }

	// RVA: 0x1F6CCF0 Offset: 0x1F6B2F0 VA: 0x181F6CCF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DADEE0 Offset: 0x1DAC4E0 VA: 0x181DADEE0
	public void CopyTo(BoomBox instance) { }

	// RVA: 0x1F6BFF0 Offset: 0x1F6A5F0 VA: 0x181F6BFF0
	public BoomBox Copy() { }

	// RVA: 0x1F6CB30 Offset: 0x1F6B130 VA: 0x181F6CB30
	public static BoomBox Deserialize(Stream stream) { }

	// RVA: 0x1F6C2E0 Offset: 0x1F6A8E0 VA: 0x181F6C2E0
	public static BoomBox DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6C360 Offset: 0x1F6A960 VA: 0x181F6C360
	public static BoomBox DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6C630 Offset: 0x1F6AC30 VA: 0x181F6C630
	public static BoomBox Deserialize(byte[] buffer) { }

	// RVA: 0x1F6CE10 Offset: 0x1F6B410 VA: 0x181F6CE10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F6D460 Offset: 0x1F6BA60 VA: 0x181F6D460 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F6D480 Offset: 0x1F6BA80 VA: 0x181F6D480 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BoomBox previous) { }

	// RVA: 0x1F6CE30 Offset: 0x1F6B430 VA: 0x181F6CE30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6CA30 Offset: 0x1F6B030 VA: 0x181F6CA30
	public static BoomBox Deserialize(byte[] buffer, BoomBox instance, bool isDelta = False) { }

	// RVA: 0x1F6C8B0 Offset: 0x1F6AEB0 VA: 0x181F6C8B0
	public static BoomBox Deserialize(Stream stream, BoomBox instance, bool isDelta) { }

	// RVA: 0x1F6C080 Offset: 0x1F6A680 VA: 0x181F6C080
	public static BoomBox DeserializeLengthDelimited(Stream stream, BoomBox instance, bool isDelta) { }

	// RVA: 0x1F6C3F0 Offset: 0x1F6A9F0 VA: 0x181F6C3F0
	public static BoomBox DeserializeLength(Stream stream, int length, BoomBox instance, bool isDelta) { }

	// RVA: 0x1F6CFB0 Offset: 0x1F6B5B0 VA: 0x181F6CFB0
	public static void SerializeDelta(Stream stream, BoomBox instance, BoomBox previous) { }

	// RVA: 0x1F6D300 Offset: 0x1F6B900 VA: 0x181F6D300
	public static void Serialize(Stream stream, BoomBox instance) { }

	// RVA: 0x1F6D450 Offset: 0x1F6BA50 VA: 0x181F6D450
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F6D460 Offset: 0x1F6BA60 VA: 0x181F6D460
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6D1F0 Offset: 0x1F6B7F0 VA: 0x181F6D1F0
	public static byte[] SerializeToBytes(BoomBox instance) { }

	// RVA: 0x1F6D140 Offset: 0x1F6B740 VA: 0x181F6D140
	public static void SerializeLengthDelimited(Stream stream, BoomBox instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class BoomBox : EntityComponent<BaseEntity>, INotifyLOD // TypeDefIndex: 9437
{	// Fields
	public static Dictionary<string, string> ValidStations; // 0x0
	public static Dictionary<string, string> ServerValidStations; // 0x8
	[ReplicatedVar] // RVA: 0xF0350 Offset: 0xEF750 VA: 0x1800F0350
	public static string ServerUrlList; // 0x10
	private static string lastParsedServerList; // 0x18
	public ShoutcastStreamer ShoutcastStreamer; // 0x20
	public GameObjectRef RadioIpDialog; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <CurrentRadioIp>k__BackingField; // 0x30
	public ulong AssignedRadioBy; // 0x38
	public AudioSource SoundSource; // 0x40
	public float ConditionLossRate; // 0x48
	public ItemDefinition[] ValidCassettes; // 0x50
	public SoundDefinition PlaySfx; // 0x58
	public SoundDefinition StopSfx; // 0x60
	public const BaseEntity.Flags HasCassette = 128;
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Cassette <CurrentCassette>k__BackingField; // 0x68
	private float localPlayerAchievementTime; // 0x70
	private bool hasAwardedLocalPlayerAchievement; // 0x74

	// Properties
	public string CurrentRadioIp { get; set; }
	private bool IsLocalPlayer { get; }
	public BaseEntity BaseEntity { get; }
	public Cassette CurrentCassette { get; set; }
	private bool isClient { get; }

	// Methods

	// RVA: 0x5182F0 Offset: 0x5168F0 VA: 0x1805182F0
	public static void LoadStations() { }

	// RVA: 0x517D70 Offset: 0x516370 VA: 0x180517D70
	private static string GetStationData() { }

	// RVA: 0x5181C0 Offset: 0x5167C0 VA: 0x1805181C0
	private static bool IsStationValid(string url) { }

	// RVA: 0x519080 Offset: 0x517680 VA: 0x180519080
	public static void ParseServerUrlList() { }

	// RVA: 0x519650 Offset: 0x517C50 VA: 0x180519650
	public static void ResetServerValidStations() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_CurrentRadioIp() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_CurrentRadioIp(string value) { }

	// RVA: 0x517A00 Offset: 0x516000 VA: 0x180517A00
	public void ChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x5188D0 Offset: 0x516ED0 VA: 0x1805188D0
	public void OnChangedBoomBoxSettings(string newIP) { }

	// RVA: 0x517800 Offset: 0x515E00 VA: 0x180517800
	public bool CanChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x519030 Offset: 0x517630 VA: 0x180519030
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x519BF0 Offset: 0x5181F0 VA: 0x180519BF0
	private bool get_IsLocalPlayer() { }

	// RVA: 0x518550 Offset: 0x516B50 VA: 0x180518550
	public void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x519BA0 Offset: 0x5181A0 VA: 0x180519BA0
	public BaseEntity get_BaseEntity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public Cassette get_CurrentCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	private void set_CurrentCassette(Cassette value) { }

	// RVA: 0x519400 Offset: 0x517A00 VA: 0x180519400
	public void Play(BasePlayer forPlayer) { }

	// RVA: 0x519870 Offset: 0x517E70 VA: 0x180519870
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x517960 Offset: 0x515F60 VA: 0x180517960
	public bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x5178B0 Offset: 0x515EB0 VA: 0x1805178B0
	public bool CanStart(BasePlayer forPlayer) { }

	// RVA: 0x517EB0 Offset: 0x5164B0 VA: 0x180517EB0
	private bool HasTape() { }

	// RVA: 0x519A00 Offset: 0x518000 VA: 0x180519A00
	private void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x517B80 Offset: 0x516180 VA: 0x180517B80
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	// RVA: 0x517D20 Offset: 0x516320 VA: 0x180517D20
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x518940 Offset: 0x516F40 VA: 0x180518940
	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next, DeployableBoomBox deployable) { }

	// RVA: 0x5185B0 Offset: 0x516BB0 VA: 0x1805185B0
	private void LocalPlayerRadioTick() { }

	// RVA: 0x519590 Offset: 0x517B90 VA: 0x180519590
	public void RequestCassetteAudioUpdate() { }

	// RVA: 0x518FA0 Offset: 0x5175A0 VA: 0x180518FA0
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x518810 Offset: 0x516E10 VA: 0x180518810
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x519790 Offset: 0x517D90 VA: 0x180519790 Slot: 10
	public void Show() { }

	// RVA: 0x517F10 Offset: 0x516510 VA: 0x180517F10 Slot: 11
	public void Hide() { }

	// RVA: 0x518080 Offset: 0x516680 VA: 0x180518080
	private bool IsPowered() { }

	// RVA: 0x517FD0 Offset: 0x5165D0 VA: 0x180517FD0
	private bool IsOn() { }

	// RVA: 0x517DF0 Offset: 0x5163F0 VA: 0x180517DF0
	private bool HasFlag(BaseEntity.Flags f) { }

	// RVA: 0x5196C0 Offset: 0x517CC0 VA: 0x1805196C0
	private void SetFlag(BaseEntity.Flags f, bool state) { }

	// RVA: 0x519D30 Offset: 0x518330 VA: 0x180519D30
	private bool get_isClient() { }

	// RVA: 0x519B40 Offset: 0x518140 VA: 0x180519B40
	public void .ctor() { }

	// RVA: 0x519AF0 Offset: 0x5180F0 VA: 0x180519AF0
	private static void .cctor() { }

}

