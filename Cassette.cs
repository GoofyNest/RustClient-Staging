public class Cassette : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6389
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public uint holder; // 0x18
	public ulong creatorSteamId; // 0x20
	public int preloadAudioId; // 0x28

	// Methods

	// RVA: 0x20A8C20 Offset: 0x20A7220 VA: 0x1820A8C20
	public static void ResetToPool(Cassette instance) { }

	// RVA: 0x20A8B80 Offset: 0x20A7180 VA: 0x1820A8B80
	public void ResetToPool() { }

	// RVA: 0x20A8830 Offset: 0x20A6E30 VA: 0x1820A8830 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A7670 Offset: 0x20A5C70 VA: 0x1820A7670
	public void CopyTo(Cassette instance) { }

	// RVA: 0x20A76A0 Offset: 0x20A5CA0 VA: 0x1820A76A0
	public Cassette Copy() { }

	// RVA: 0x20A80E0 Offset: 0x20A66E0 VA: 0x1820A80E0
	public static Cassette Deserialize(Stream stream) { }

	// RVA: 0x20A7A00 Offset: 0x20A6000 VA: 0x1820A7A00
	public static Cassette DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A7A80 Offset: 0x20A6080 VA: 0x1820A7A80
	public static Cassette DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A7DD0 Offset: 0x20A63D0 VA: 0x1820A7DD0
	public static Cassette Deserialize(byte[] buffer) { }

	// RVA: 0x20A8950 Offset: 0x20A6F50 VA: 0x1820A8950
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A9200 Offset: 0x20A7800 VA: 0x1820A9200 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A9220 Offset: 0x20A7820 VA: 0x1820A9220 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Cassette previous) { }

	// RVA: 0x20A8B60 Offset: 0x20A7160 VA: 0x1820A8B60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A8330 Offset: 0x20A6930 VA: 0x1820A8330
	public static Cassette Deserialize(byte[] buffer, Cassette instance, bool isDelta = False) { }

	// RVA: 0x20A8620 Offset: 0x20A6C20 VA: 0x1820A8620
	public static Cassette Deserialize(Stream stream, Cassette instance, bool isDelta) { }

	// RVA: 0x20A7720 Offset: 0x20A5D20 VA: 0x1820A7720
	public static Cassette DeserializeLengthDelimited(Stream stream, Cassette instance, bool isDelta) { }

	// RVA: 0x20A7B10 Offset: 0x20A6110 VA: 0x1820A7B10
	public static Cassette DeserializeLength(Stream stream, int length, Cassette instance, bool isDelta) { }

	// RVA: 0x20A8CC0 Offset: 0x20A72C0 VA: 0x1820A8CC0
	public static void SerializeDelta(Stream stream, Cassette instance, Cassette previous) { }

	// RVA: 0x20A90A0 Offset: 0x20A76A0 VA: 0x1820A90A0
	public static void Serialize(Stream stream, Cassette instance) { }

	// RVA: 0x20A91F0 Offset: 0x20A77F0 VA: 0x1820A91F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A9200 Offset: 0x20A7800 VA: 0x1820A9200
	public void ToProto(Stream stream) { }

	// RVA: 0x20A8F90 Offset: 0x20A7590 VA: 0x1820A8F90
	public static byte[] SerializeToBytes(Cassette instance) { }

	// RVA: 0x20A8EE0 Offset: 0x20A74E0 VA: 0x1820A8EE0
	public static void SerializeLengthDelimited(Stream stream, Cassette instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Cassette : BaseEntity, IUGCBrowserEntity // TypeDefIndex: 8544
{	// Fields
	private static List<Cassette.LoadRequest> loadQueue; // 0x0
	private static bool isLoading; // 0x8
	public float MaxCassetteLength; // 0x168
	[ReplicatedVar] // RVA: 0xA9A10 Offset: 0xA8E10 VA: 0x1800A9A10
	public static float MaxCassetteFileSizeMB; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <AudioId>k__BackingField; // 0x16C
	public ulong CreatorSteamId; // 0x170
	public PreloadedCassetteContent.PreloadType PreloadType; // 0x178
	public PreloadedCassetteContent PreloadContent; // 0x180
	public SoundDefinition InsertCassetteSfx; // 0x188
	public int ViewmodelIndex; // 0x190
	public Sprite HudSprite; // 0x198
	public int MaximumVoicemailSlots; // 0x1A0
	private int preloadedAudioId; // 0x1A4
	private uint cachedId; // 0x1A8
	private AudioClip cachedClip; // 0x1B0
	private bool notifyOnLoad; // 0x1B8
	private Action<AudioClip> audioLoadFromServerCallback; // 0x1C0

	// Properties
	public uint AudioId { get; set; }
	public SoundDefinition PreloadedAudio { get; }

	// Methods

	// RVA: 0x5304D0 Offset: 0x52EAD0 VA: 0x1805304D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x530CA0 Offset: 0x52F2A0 VA: 0x180530CA0
	public static void RequestAudioLoad(byte[] data, Action<AudioClip, bool> onComplete, BaseEntity targetEntity) { }

	// RVA: 0x531110 Offset: 0x52F710 VA: 0x180531110
	public static void RunCassetteQueue() { }

	// RVA: 0x52FEB0 Offset: 0x52E4B0 VA: 0x18052FEB0
	public static void LoadAudio(byte[] data, Action<AudioClip, bool> onComplete) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5316C0 Offset: 0x52FCC0 VA: 0x1805316C0
	public uint get_AudioId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x531710 Offset: 0x52FD10 VA: 0x180531710
	private void set_AudioId(uint value) { }

	// RVA: 0x5316D0 Offset: 0x52FCD0 VA: 0x1805316D0
	public SoundDefinition get_PreloadedAudio() { }

	// RVA: 0x5301B0 Offset: 0x52E7B0 VA: 0x1805301B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5303B0 Offset: 0x52E9B0 VA: 0x1805303B0 Slot: 81
	public override void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	// RVA: 0x52F480 Offset: 0x52DA80 VA: 0x18052F480
	private void ForceLoadNotify() { }

	// RVA: 0x531340 Offset: 0x52F940 VA: 0x180531340
	public void WriteNewAudio(byte[] data, Action<AudioClip> onAudioReady, ulong userSteamId) { }

	// RVA: 0x530E40 Offset: 0x52F440 VA: 0x180530E40
	public void RequestFileUpdate(Action<AudioClip> onAudioReady) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x52F140 Offset: 0x52D740 VA: 0x18052F140
	public void Client_ReceiveAudio(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x52F3F0 Offset: 0x52D9F0 VA: 0x18052F3F0
	private void FailedNetworkFileRequest(BaseEntity.RPCMessage msg) { }

	// RVA: 0x52FB70 Offset: 0x52E170 VA: 0x18052FB70
	public static bool IsOggValid(byte[] data, Cassette c) { }

	// RVA: 0x52FD40 Offset: 0x52E340 VA: 0x18052FD40
	private static bool IsOggValid(byte[] data, float maxLength) { }

	// RVA: 0x52F120 Offset: 0x52D720 VA: 0x18052F120
	private static float ByteToMegabyte(int byteSize) { }

	// RVA: 0x52F530 Offset: 0x52DB30 VA: 0x18052F530
	private static double GetOggLength(byte[] t) { }

	// RVA: 0x531650 Offset: 0x52FC50 VA: 0x180531650
	public void .ctor() { }

	// RVA: 0x5315C0 Offset: 0x52FBC0 VA: 0x1805315C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x531270 Offset: 0x52F870 VA: 0x180531270
	private void <Client_ReceiveAudio>b__32_0(AudioClip clip, bool success) { }

}

private struct Cassette.LoadRequest // TypeDefIndex: 8545
{	// Fields
	public byte[] Data; // 0x0
	public Action<AudioClip, bool> Callback; // 0x8
	public BaseEntity ForEntity; // 0x10

}

private sealed class Cassette.<>c__DisplayClass29_0 // TypeDefIndex: 8546
{	// Fields
	public Cassette <>4__this; // 0x10
	public Action<AudioClip> onAudioReady; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5470C0 Offset: 0x5456C0 VA: 0x1805470C0
	internal void <WriteNewAudio>b__0(AudioClip clip, bool success) { }

}

private sealed class Cassette.<>c__DisplayClass31_0 // TypeDefIndex: 8547
{	// Fields
	public Cassette <>4__this; // 0x10
	public byte[] data; // 0x18
	public Action<AudioClip> onAudioReady; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5471B0 Offset: 0x5457B0 VA: 0x1805471B0
	internal void <RequestFileUpdate>b__0(AudioClip clip, bool success) { }

}

