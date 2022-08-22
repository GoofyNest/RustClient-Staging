public class BoomBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6391
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string radioIp; // 0x18
	public ulong assignedRadioBy; // 0x20

	// Methods

	// RVA: 0x1F6C6E0 Offset: 0x1F6ACE0 VA: 0x181F6C6E0
	public static void ResetToPool(BoomBox instance) { }

	// RVA: 0x1F6C630 Offset: 0x1F6AC30 VA: 0x181F6C630
	public void ResetToPool() { }

	// RVA: 0x1F6C4D0 Offset: 0x1F6AAD0 VA: 0x181F6C4D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DAD6F0 Offset: 0x1DABCF0 VA: 0x181DAD6F0
	public void CopyTo(BoomBox instance) { }

	// RVA: 0x1F6B7D0 Offset: 0x1F69DD0 VA: 0x181F6B7D0
	public BoomBox Copy() { }

	// RVA: 0x1F6C310 Offset: 0x1F6A910 VA: 0x181F6C310
	public static BoomBox Deserialize(Stream stream) { }

	// RVA: 0x1F6BAC0 Offset: 0x1F6A0C0 VA: 0x181F6BAC0
	public static BoomBox DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6BB40 Offset: 0x1F6A140 VA: 0x181F6BB40
	public static BoomBox DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6BE10 Offset: 0x1F6A410 VA: 0x181F6BE10
	public static BoomBox Deserialize(byte[] buffer) { }

	// RVA: 0x1F6C5F0 Offset: 0x1F6ABF0 VA: 0x181F6C5F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F6CC40 Offset: 0x1F6B240 VA: 0x181F6CC40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F6CC60 Offset: 0x1F6B260 VA: 0x181F6CC60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BoomBox previous) { }

	// RVA: 0x1F6C610 Offset: 0x1F6AC10 VA: 0x181F6C610 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6C210 Offset: 0x1F6A810 VA: 0x181F6C210
	public static BoomBox Deserialize(byte[] buffer, BoomBox instance, bool isDelta = False) { }

	// RVA: 0x1F6C090 Offset: 0x1F6A690 VA: 0x181F6C090
	public static BoomBox Deserialize(Stream stream, BoomBox instance, bool isDelta) { }

	// RVA: 0x1F6B860 Offset: 0x1F69E60 VA: 0x181F6B860
	public static BoomBox DeserializeLengthDelimited(Stream stream, BoomBox instance, bool isDelta) { }

	// RVA: 0x1F6BBD0 Offset: 0x1F6A1D0 VA: 0x181F6BBD0
	public static BoomBox DeserializeLength(Stream stream, int length, BoomBox instance, bool isDelta) { }

	// RVA: 0x1F6C790 Offset: 0x1F6AD90 VA: 0x181F6C790
	public static void SerializeDelta(Stream stream, BoomBox instance, BoomBox previous) { }

	// RVA: 0x1F6CAE0 Offset: 0x1F6B0E0 VA: 0x181F6CAE0
	public static void Serialize(Stream stream, BoomBox instance) { }

	// RVA: 0x1F6CC30 Offset: 0x1F6B230 VA: 0x181F6CC30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F6CC40 Offset: 0x1F6B240 VA: 0x181F6CC40
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6C9D0 Offset: 0x1F6AFD0 VA: 0x181F6C9D0
	public static byte[] SerializeToBytes(BoomBox instance) { }

	// RVA: 0x1F6C920 Offset: 0x1F6AF20 VA: 0x181F6C920
	public static void SerializeLengthDelimited(Stream stream, BoomBox instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x518360 Offset: 0x516960 VA: 0x180518360
	public static void LoadStations() { }

	// RVA: 0x517DE0 Offset: 0x5163E0 VA: 0x180517DE0
	private static string GetStationData() { }

	// RVA: 0x518230 Offset: 0x516830 VA: 0x180518230
	private static bool IsStationValid(string url) { }

	// RVA: 0x5190F0 Offset: 0x5176F0 VA: 0x1805190F0
	public static void ParseServerUrlList() { }

	// RVA: 0x5196C0 Offset: 0x517CC0 VA: 0x1805196C0
	public static void ResetServerValidStations() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_CurrentRadioIp() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_CurrentRadioIp(string value) { }

	// RVA: 0x517A70 Offset: 0x516070 VA: 0x180517A70
	public void ChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x518940 Offset: 0x516F40 VA: 0x180518940
	public void OnChangedBoomBoxSettings(string newIP) { }

	// RVA: 0x517870 Offset: 0x515E70 VA: 0x180517870
	public bool CanChangeRadioSettings(BasePlayer player) { }

	// RVA: 0x5190A0 Offset: 0x5176A0 VA: 0x1805190A0
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x519C60 Offset: 0x518260 VA: 0x180519C60
	private bool get_IsLocalPlayer() { }

	// RVA: 0x5185C0 Offset: 0x516BC0 VA: 0x1805185C0
	public void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x519C10 Offset: 0x518210 VA: 0x180519C10
	public BaseEntity get_BaseEntity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public Cassette get_CurrentCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	private void set_CurrentCassette(Cassette value) { }

	// RVA: 0x519470 Offset: 0x517A70 VA: 0x180519470
	public void Play(BasePlayer forPlayer) { }

	// RVA: 0x5198E0 Offset: 0x517EE0 VA: 0x1805198E0
	public void Stop(BasePlayer forPlayer) { }

	// RVA: 0x5179D0 Offset: 0x515FD0 VA: 0x1805179D0
	public bool CanStop(BasePlayer forPlayer) { }

	// RVA: 0x517920 Offset: 0x515F20 VA: 0x180517920
	public bool CanStart(BasePlayer forPlayer) { }

	// RVA: 0x517F20 Offset: 0x516520 VA: 0x180517F20
	private bool HasTape() { }

	// RVA: 0x519A70 Offset: 0x518070 VA: 0x180519A70
	private void UpdateAudioClip(AudioClip clip) { }

	// RVA: 0x517BF0 Offset: 0x5161F0 VA: 0x180517BF0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	// RVA: 0x517D90 Offset: 0x516390 VA: 0x180517D90
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5189B0 Offset: 0x516FB0 VA: 0x1805189B0
	public void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next, DeployableBoomBox deployable) { }

	// RVA: 0x518620 Offset: 0x516C20 VA: 0x180518620
	private void LocalPlayerRadioTick() { }

	// RVA: 0x519600 Offset: 0x517C00 VA: 0x180519600
	public void RequestCassetteAudioUpdate() { }

	// RVA: 0x519010 Offset: 0x517610 VA: 0x180519010
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x518880 Offset: 0x516E80 VA: 0x180518880
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x519800 Offset: 0x517E00 VA: 0x180519800 Slot: 10
	public void Show() { }

	// RVA: 0x517F80 Offset: 0x516580 VA: 0x180517F80 Slot: 11
	public void Hide() { }

	// RVA: 0x5180F0 Offset: 0x5166F0 VA: 0x1805180F0
	private bool IsPowered() { }

	// RVA: 0x518040 Offset: 0x516640 VA: 0x180518040
	private bool IsOn() { }

	// RVA: 0x517E60 Offset: 0x516460 VA: 0x180517E60
	private bool HasFlag(BaseEntity.Flags f) { }

	// RVA: 0x519730 Offset: 0x517D30 VA: 0x180519730
	private void SetFlag(BaseEntity.Flags f, bool state) { }

	// RVA: 0x519DA0 Offset: 0x5183A0 VA: 0x180519DA0
	private bool get_isClient() { }

	// RVA: 0x519BB0 Offset: 0x5181B0 VA: 0x180519BB0
	public void .ctor() { }

	// RVA: 0x519B60 Offset: 0x518160 VA: 0x180519B60
	private static void .cctor() { }

}

