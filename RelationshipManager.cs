public class RelationshipManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6359
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong lastTeamIndex; // 0x18
	public List<PlayerTeam> teamList; // 0x20
	public int maxTeamSize; // 0x28
	public List<RelationshipManager.PlayerRelationships> relationships; // 0x30

	// Methods

	// RVA: 0x1E01480 Offset: 0x1DFFA80 VA: 0x181E01480
	public static void ResetToPool(RelationshipManager instance) { }

	// RVA: 0x1E01150 Offset: 0x1DFF750 VA: 0x181E01150
	public void ResetToPool() { }

	// RVA: 0x1E01090 Offset: 0x1DFF690 VA: 0x181E01090 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFFF50 Offset: 0x1DFE550 VA: 0x181DFFF50
	public void CopyTo(RelationshipManager instance) { }

	// RVA: 0x1E001E0 Offset: 0x1DFE7E0 VA: 0x181E001E0
	public RelationshipManager Copy() { }

	// RVA: 0x1E00AF0 Offset: 0x1DFF0F0 VA: 0x181E00AF0
	public static RelationshipManager Deserialize(Stream stream) { }

	// RVA: 0x1E00260 Offset: 0x1DFE860 VA: 0x181E00260
	public static RelationshipManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E006B0 Offset: 0x1DFECB0 VA: 0x181E006B0
	public static RelationshipManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E00F70 Offset: 0x1DFF570 VA: 0x181E00F70
	public static RelationshipManager Deserialize(byte[] buffer) { }

	// RVA: 0x1E01110 Offset: 0x1DFF710 VA: 0x181E01110
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E02100 Offset: 0x1E00700 VA: 0x181E02100 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E02120 Offset: 0x1E00720 VA: 0x181E02120 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager previous) { }

	// RVA: 0x1E01130 Offset: 0x1DFF730 VA: 0x181E01130 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E00B70 Offset: 0x1DFF170 VA: 0x181E00B70
	public static RelationshipManager Deserialize(byte[] buffer, RelationshipManager instance, bool isDelta = False) { }

	// RVA: 0x1E00C70 Offset: 0x1DFF270 VA: 0x181E00C70
	public static RelationshipManager Deserialize(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E002E0 Offset: 0x1DFE8E0 VA: 0x181E002E0
	public static RelationshipManager DeserializeLengthDelimited(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E00740 Offset: 0x1DFED40 VA: 0x181E00740
	public static RelationshipManager DeserializeLength(Stream stream, int length, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E017A0 Offset: 0x1DFFDA0 VA: 0x181E017A0
	public static void SerializeDelta(Stream stream, RelationshipManager instance, RelationshipManager previous) { }

	// RVA: 0x1E01D50 Offset: 0x1E00350 VA: 0x181E01D50
	public static void Serialize(Stream stream, RelationshipManager instance) { }

	// RVA: 0x1E020F0 Offset: 0x1E006F0 VA: 0x181E020F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E02100 Offset: 0x1E00700 VA: 0x181E02100
	public void ToProto(Stream stream) { }

	// RVA: 0x1E01C40 Offset: 0x1E00240 VA: 0x181E01C40
	public static byte[] SerializeToBytes(RelationshipManager instance) { }

	// RVA: 0x1E01B90 Offset: 0x1E00190 VA: 0x181E01B90
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class RelationshipManager.PlayerRelationshipInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6360
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerID; // 0x18
	public int type; // 0x20
	public int weight; // 0x24
	public uint mugshotCrc; // 0x28
	public string displayName; // 0x30
	public string notes; // 0x38
	public float timeSinceSeen; // 0x40

	// Methods

	// RVA: 0x1DF8720 Offset: 0x1DF6D20 VA: 0x181DF8720
	public static void ResetToPool(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF8600 Offset: 0x1DF6C00 VA: 0x181DF8600
	public void ResetToPool() { }

	// RVA: 0x1DF7EF0 Offset: 0x1DF64F0 VA: 0x181DF7EF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF63E0 Offset: 0x1DF49E0 VA: 0x181DF63E0
	public void CopyTo(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF6450 Offset: 0x1DF4A50 VA: 0x181DF6450
	public RelationshipManager.PlayerRelationshipInfo Copy() { }

	// RVA: 0x1DF77C0 Offset: 0x1DF5DC0 VA: 0x181DF77C0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream) { }

	// RVA: 0x1DF6500 Offset: 0x1DF4B00 VA: 0x181DF6500
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF6D00 Offset: 0x1DF5300 VA: 0x181DF6D00
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DF7AF0 Offset: 0x1DF60F0 VA: 0x181DF7AF0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DF7F70 Offset: 0x1DF6570 VA: 0x181DF7F70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DF8FB0 Offset: 0x1DF75B0 VA: 0x181DF8FB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DF8FD0 Offset: 0x1DF75D0 VA: 0x181DF8FD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF8260 Offset: 0x1DF6860 VA: 0x181DF8260 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DF70F0 Offset: 0x1DF56F0 VA: 0x181DF70F0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta = False) { }

	// RVA: 0x1DF74D0 Offset: 0x1DF5AD0 VA: 0x181DF74D0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF6580 Offset: 0x1DF4B80 VA: 0x181DF6580
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF6950 Offset: 0x1DF4F50 VA: 0x181DF6950
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF8840 Offset: 0x1DF6E40 VA: 0x181DF8840
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF8D50 Offset: 0x1DF7350 VA: 0x181DF8D50
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF8FA0 Offset: 0x1DF75A0 VA: 0x181DF8FA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DF8FB0 Offset: 0x1DF75B0 VA: 0x181DF8FB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DF8C40 Offset: 0x1DF7240 VA: 0x181DF8C40
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF8B90 Offset: 0x1DF7190 VA: 0x181DF8B90
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class RelationshipManager.PlayerRelationships : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6361
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerID; // 0x18
	public List<RelationshipManager.PlayerRelationshipInfo> relations; // 0x20

	// Methods

	// RVA: 0x1DFA950 Offset: 0x1DF8F50 VA: 0x181DFA950
	public static void ResetToPool(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFAB10 Offset: 0x1DF9110 VA: 0x181DFAB10
	public void ResetToPool() { }

	// RVA: 0x1DFA890 Offset: 0x1DF8E90 VA: 0x181DFA890 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF8FF0 Offset: 0x1DF75F0 VA: 0x181DF8FF0
	public void CopyTo(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DF91B0 Offset: 0x1DF77B0 VA: 0x181DF91B0
	public RelationshipManager.PlayerRelationships Copy() { }

	// RVA: 0x1DFA130 Offset: 0x1DF8730 VA: 0x181DFA130
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream) { }

	// RVA: 0x1DF98C0 Offset: 0x1DF7EC0 VA: 0x181DF98C0
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF9940 Offset: 0x1DF7F40 VA: 0x181DF9940
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFA770 Offset: 0x1DF8D70 VA: 0x181DFA770
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer) { }

	// RVA: 0x1DFA910 Offset: 0x1DF8F10 VA: 0x181DFA910
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFB300 Offset: 0x1DF9900 VA: 0x181DFB300 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFB320 Offset: 0x1DF9920 VA: 0x181DFB320 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DFA930 Offset: 0x1DF8F30 VA: 0x181DFA930 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFA030 Offset: 0x1DF8630 VA: 0x181DFA030
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer, RelationshipManager.PlayerRelationships instance, bool isDelta = False) { }

	// RVA: 0x1DFA1B0 Offset: 0x1DF87B0 VA: 0x181DFA1B0
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF9230 Offset: 0x1DF7830 VA: 0x181DF9230
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF99D0 Offset: 0x1DF7FD0 VA: 0x181DF99D0
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DFACD0 Offset: 0x1DF92D0 VA: 0x181DFACD0
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationships instance, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DFB0D0 Offset: 0x1DF96D0 VA: 0x181DFB0D0
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFB2F0 Offset: 0x1DF98F0 VA: 0x181DFB2F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFB300 Offset: 0x1DF9900 VA: 0x181DFB300
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFAFC0 Offset: 0x1DF95C0 VA: 0x181DFAFC0
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFAF10 Offset: 0x1DF9510 VA: 0x181DFAF10
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class RelationshipManager : BaseEntity // TypeDefIndex: 8628
{	// Fields
	private const int MugshotResolution = 256;
	private const int MugshotMaxFileSize = 65536;
	private const float MugshotMaxDistance = 50;
	public static RelationshipManager.PlayerRelationships localRelationships; // 0x0
	[ClientVar] // RVA: 0xB3BA0 Offset: 0xB2FA0 VA: 0x1800B3BA0
	public static Vector3 mugshotOffset; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static RelationshipManager <ClientInstance>k__BackingField; // 0x18
	public static int clientMaxTeamSize; // 0x20

	// Properties
	public static RelationshipManager ClientInstance { get; set; }

	// Methods

	// RVA: 0x94B530 Offset: 0x949B30 VA: 0x18094B530 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x94BD40 Offset: 0x94A340 VA: 0x18094BD40
	public static void RequestUpdatedContacts() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x949860 Offset: 0x947E60 VA: 0x180949860
	public void CLIENT_DoMugshot(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x949940 Offset: 0x947F40 VA: 0x180949940
	public void CLIENT_RecieveLocalRelationships(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94B0F0 Offset: 0x9496F0 VA: 0x18094B0F0
	public static void ChangeRelationship(ulong targetPlayerID, RelationshipManager.RelationshipType newRelationshipType) { }

	// RVA: 0x94BE60 Offset: 0x94A460 VA: 0x18094BE60
	public static bool VisCheck(Vector3 a, Vector3 b) { }

	// RVA: 0x94A4C0 Offset: 0x948AC0 VA: 0x18094A4C0
	public static void CaptureAndSendMugshot(BasePlayer targetPlayer) { }

	// RVA: 0x94B280 Offset: 0x949880 VA: 0x18094B280
	public static RelationshipManager.PlayerRelationships GetLocal() { }

	// RVA: 0x94B2E0 Offset: 0x9498E0 VA: 0x18094B2E0
	private static uint GetSteamIdHash(ulong requesterSteamId, ulong targetSteamId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x94C1A0 Offset: 0x94A7A0 VA: 0x18094C1A0
	public static RelationshipManager get_ClientInstance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x94C200 Offset: 0x94A800 VA: 0x18094C200
	private static void set_ClientInstance(RelationshipManager value) { }

	// RVA: 0x94B460 Offset: 0x949A60 VA: 0x18094B460
	public void OnEnable() { }

	// RVA: 0x94B390 Offset: 0x949990 VA: 0x18094B390
	public void OnDestroy() { }

	// RVA: 0x94BE00 Offset: 0x94A400 VA: 0x18094BE00
	public static bool TeamsEnabled() { }

	// RVA: 0x94B2F0 Offset: 0x9498F0 VA: 0x18094B2F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x94C140 Offset: 0x94A740 VA: 0x18094C140
	public void .ctor() { }

	// RVA: 0x94C000 Offset: 0x94A600 VA: 0x18094C000
	private static void .cctor() { }

}

public enum RelationshipManager.RelationshipType // TypeDefIndex: 8629
{	// Fields
	public int value__; // 0x0
	public const RelationshipManager.RelationshipType NONE = 0;
	public const RelationshipManager.RelationshipType Acquaintance = 1;
	public const RelationshipManager.RelationshipType Friend = 2;
	public const RelationshipManager.RelationshipType Enemy = 3;

}

public class RelationshipManager.PlayerRelationshipInfo : Pool.IPooled, IServerFileReceiver // TypeDefIndex: 8630
{	// Fields
	public string displayName; // 0x10
	public ulong player; // 0x18
	public RelationshipManager.RelationshipType type; // 0x20
	public int weight; // 0x24
	public uint mugshotCrc; // 0x28
	public string notes; // 0x30
	public float lastSeenTime; // 0x38
	private readonly Action mugshotTimeoutAction; // 0x40
	private uint loadedMugshotCrc; // 0x48
	public bool mugshotLoading; // 0x4C
	public Texture2D mugshotTexture; // 0x50

	// Properties
	public bool IsMugshotLoaded { get; }

	// Methods

	// RVA: 0x93BC60 Offset: 0x93A260 VA: 0x18093BC60
	public bool get_IsMugshotLoaded() { }

	// RVA: 0x93B610 Offset: 0x939C10 VA: 0x18093B610 Slot: 4
	public void EnterPool() { }

	// RVA: 0x93B610 Offset: 0x939C10 VA: 0x18093B610 Slot: 5
	public void LeavePool() { }

	// RVA: 0x93B9C0 Offset: 0x939FC0 VA: 0x18093B9C0
	private void Reset() { }

	// RVA: 0x93BBF0 Offset: 0x93A1F0 VA: 0x18093BBF0
	public void .ctor() { }

	// RVA: 0x93B7F0 Offset: 0x939DF0 VA: 0x18093B7F0
	public void RequestMugshot() { }

	// RVA: 0x93BBE0 Offset: 0x93A1E0 VA: 0x18093BBE0
	private void WaitingForMugshotTimeout() { }

	// RVA: 0x93B620 Offset: 0x939C20 VA: 0x18093B620 Slot: 6
	public void OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

}

public class RelationshipManager.PlayerRelationships : Pool.IPooled // TypeDefIndex: 8631
{	// Fields
	public bool dirty; // 0x10
	public ulong ownerPlayer; // 0x18
	public Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo> relations; // 0x20

	// Methods

	// RVA: 0x93BD50 Offset: 0x93A350 VA: 0x18093BD50
	public RelationshipManager.PlayerRelationshipInfo GetRelations(ulong player) { }

	// RVA: 0x93BEC0 Offset: 0x93A4C0 VA: 0x18093BEC0
	public void .ctor() { }

	// RVA: 0x93BCD0 Offset: 0x93A2D0 VA: 0x18093BCD0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x93BE30 Offset: 0x93A430 VA: 0x18093BE30 Slot: 5
	public void LeavePool() { }

}

private sealed class RelationshipManager.<>c // TypeDefIndex: 8632
{	// Fields
	public static readonly RelationshipManager.<>c <>9; // 0x0
	public static Func<ulong, ulong> <>9__10_0; // 0x8
	public static Func<RelationshipManager.PlayerRelationshipInfo, ulong> <>9__10_1; // 0x10

	// Methods

	// RVA: 0x956E10 Offset: 0x955410 VA: 0x180956E10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	internal ulong <CLIENT_RecieveLocalRelationships>b__10_0(ulong r) { }

	// RVA: 0x956DB0 Offset: 0x9553B0 VA: 0x180956DB0
	internal ulong <CLIENT_RecieveLocalRelationships>b__10_1(RelationshipManager.PlayerRelationshipInfo r) { }

}

