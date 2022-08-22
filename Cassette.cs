public class Cassette : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6389
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public uint holder; // 0x18
	public ulong creatorSteamId; // 0x20
	public int preloadAudioId; // 0x28

	// Methods

	// RVA: 0x20A8400 Offset: 0x20A6A00 VA: 0x1820A8400
	public static void ResetToPool(Cassette instance) { }

	// RVA: 0x20A8360 Offset: 0x20A6960 VA: 0x1820A8360
	public void ResetToPool() { }

	// RVA: 0x20A8010 Offset: 0x20A6610 VA: 0x1820A8010 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A6E50 Offset: 0x20A5450 VA: 0x1820A6E50
	public void CopyTo(Cassette instance) { }

	// RVA: 0x20A6E80 Offset: 0x20A5480 VA: 0x1820A6E80
	public Cassette Copy() { }

	// RVA: 0x20A78C0 Offset: 0x20A5EC0 VA: 0x1820A78C0
	public static Cassette Deserialize(Stream stream) { }

	// RVA: 0x20A71E0 Offset: 0x20A57E0 VA: 0x1820A71E0
	public static Cassette DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A7260 Offset: 0x20A5860 VA: 0x1820A7260
	public static Cassette DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A75B0 Offset: 0x20A5BB0 VA: 0x1820A75B0
	public static Cassette Deserialize(byte[] buffer) { }

	// RVA: 0x20A8130 Offset: 0x20A6730 VA: 0x1820A8130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A89E0 Offset: 0x20A6FE0 VA: 0x1820A89E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A8A00 Offset: 0x20A7000 VA: 0x1820A8A00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Cassette previous) { }

	// RVA: 0x20A8340 Offset: 0x20A6940 VA: 0x1820A8340 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A7B10 Offset: 0x20A6110 VA: 0x1820A7B10
	public static Cassette Deserialize(byte[] buffer, Cassette instance, bool isDelta = False) { }

	// RVA: 0x20A7E00 Offset: 0x20A6400 VA: 0x1820A7E00
	public static Cassette Deserialize(Stream stream, Cassette instance, bool isDelta) { }

	// RVA: 0x20A6F00 Offset: 0x20A5500 VA: 0x1820A6F00
	public static Cassette DeserializeLengthDelimited(Stream stream, Cassette instance, bool isDelta) { }

	// RVA: 0x20A72F0 Offset: 0x20A58F0 VA: 0x1820A72F0
	public static Cassette DeserializeLength(Stream stream, int length, Cassette instance, bool isDelta) { }

	// RVA: 0x20A84A0 Offset: 0x20A6AA0 VA: 0x1820A84A0
	public static void SerializeDelta(Stream stream, Cassette instance, Cassette previous) { }

	// RVA: 0x20A8880 Offset: 0x20A6E80 VA: 0x1820A8880
	public static void Serialize(Stream stream, Cassette instance) { }

	// RVA: 0x20A89D0 Offset: 0x20A6FD0 VA: 0x1820A89D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A89E0 Offset: 0x20A6FE0 VA: 0x1820A89E0
	public void ToProto(Stream stream) { }

	// RVA: 0x20A8770 Offset: 0x20A6D70 VA: 0x1820A8770
	public static byte[] SerializeToBytes(Cassette instance) { }

	// RVA: 0x20A86C0 Offset: 0x20A6CC0 VA: 0x1820A86C0
	public static void SerializeLengthDelimited(Stream stream, Cassette instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x530540 Offset: 0x52EB40 VA: 0x180530540 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x530D10 Offset: 0x52F310 VA: 0x180530D10
	public static void RequestAudioLoad(byte[] data, Action<AudioClip, bool> onComplete, BaseEntity targetEntity) { }

	// RVA: 0x531180 Offset: 0x52F780 VA: 0x180531180
	public static void RunCassetteQueue() { }

	// RVA: 0x52FF20 Offset: 0x52E520 VA: 0x18052FF20
	public static void LoadAudio(byte[] data, Action<AudioClip, bool> onComplete) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x531730 Offset: 0x52FD30 VA: 0x180531730
	public uint get_AudioId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x531780 Offset: 0x52FD80 VA: 0x180531780
	private void set_AudioId(uint value) { }

	// RVA: 0x531740 Offset: 0x52FD40 VA: 0x180531740
	public SoundDefinition get_PreloadedAudio() { }

	// RVA: 0x530220 Offset: 0x52E820 VA: 0x180530220 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x530420 Offset: 0x52EA20 VA: 0x180530420 Slot: 81
	public override void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	// RVA: 0x52F4F0 Offset: 0x52DAF0 VA: 0x18052F4F0
	private void ForceLoadNotify() { }

	// RVA: 0x5313B0 Offset: 0x52F9B0 VA: 0x1805313B0
	public void WriteNewAudio(byte[] data, Action<AudioClip> onAudioReady, ulong userSteamId) { }

	// RVA: 0x530EB0 Offset: 0x52F4B0 VA: 0x180530EB0
	public void RequestFileUpdate(Action<AudioClip> onAudioReady) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x52F1B0 Offset: 0x52D7B0 VA: 0x18052F1B0
	public void Client_ReceiveAudio(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x52F460 Offset: 0x52DA60 VA: 0x18052F460
	private void FailedNetworkFileRequest(BaseEntity.RPCMessage msg) { }

	// RVA: 0x52FBE0 Offset: 0x52E1E0 VA: 0x18052FBE0
	public static bool IsOggValid(byte[] data, Cassette c) { }

	// RVA: 0x52FDB0 Offset: 0x52E3B0 VA: 0x18052FDB0
	private static bool IsOggValid(byte[] data, float maxLength) { }

	// RVA: 0x52F190 Offset: 0x52D790 VA: 0x18052F190
	private static float ByteToMegabyte(int byteSize) { }

	// RVA: 0x52F5A0 Offset: 0x52DBA0 VA: 0x18052F5A0
	private static double GetOggLength(byte[] t) { }

	// RVA: 0x5316C0 Offset: 0x52FCC0 VA: 0x1805316C0
	public void .ctor() { }

	// RVA: 0x531630 Offset: 0x52FC30 VA: 0x180531630
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5312E0 Offset: 0x52F8E0 VA: 0x1805312E0
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

	// RVA: 0x547130 Offset: 0x545730 VA: 0x180547130
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

	// RVA: 0x547220 Offset: 0x545820 VA: 0x180547220
	internal void <RequestFileUpdate>b__0(AudioClip clip, bool success) { }

}

