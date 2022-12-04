public class RelationshipManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6368
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong lastTeamIndex;
	public List<PlayerTeam> teamList;
	public int maxTeamSize;
	public List<RelationshipManager.PlayerRelationships> relationships;


	public static void ResetToPool(RelationshipManager instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(RelationshipManager instance) { }

	public RelationshipManager Copy() { }

	public static RelationshipManager Deserialize(Stream stream) { }

	public static RelationshipManager DeserializeLengthDelimited(Stream stream) { }

	public static RelationshipManager DeserializeLength(Stream stream, int length) { }

	public static RelationshipManager Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static RelationshipManager Deserialize(byte[] buffer, RelationshipManager instance, bool isDelta = False) { }

	public static RelationshipManager Deserialize(Stream stream, RelationshipManager instance, bool isDelta) { }

	public static RelationshipManager DeserializeLengthDelimited(Stream stream, RelationshipManager instance, bool isDelta) { }

	public static RelationshipManager DeserializeLength(Stream stream, int length, RelationshipManager instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, RelationshipManager instance, RelationshipManager previous) { }

	public static void Serialize(Stream stream, RelationshipManager instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(RelationshipManager instance) { }

	public static void SerializeLengthDelimited(Stream stream, RelationshipManager instance) { }

	public void .ctor() { }

}

public class RelationshipManager.PlayerRelationshipInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6369
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong playerID;
	public int type;
	public int weight;
	public uint mugshotCrc;
	public string displayName;
	public string notes;
	public float timeSinceSeen;


	public static void ResetToPool(RelationshipManager.PlayerRelationshipInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(RelationshipManager.PlayerRelationshipInfo instance) { }

	public RelationshipManager.PlayerRelationshipInfo Copy() { }

	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream) { }

	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream) { }

	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length) { }

	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta = False) { }

	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, RelationshipManager.PlayerRelationshipInfo previous) { }

	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationshipInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	public void .ctor() { }

}

public class RelationshipManager.PlayerRelationships : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6370
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong playerID;
	public List<RelationshipManager.PlayerRelationshipInfo> relations;


	public static void ResetToPool(RelationshipManager.PlayerRelationships instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(RelationshipManager.PlayerRelationships instance) { }

	public RelationshipManager.PlayerRelationships Copy() { }

	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream) { }

	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream) { }

	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length) { }

	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationships previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer, RelationshipManager.PlayerRelationships instance, bool isDelta = False) { }

	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationships instance, RelationshipManager.PlayerRelationships previous) { }

	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationships instance) { }

	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	public void .ctor() { }

}

public class RelationshipManager : BaseEntity // TypeDefIndex: 10353
{
	[ReplicatedVar]
	public static bool contacts;
	private const int MugshotResolution = 256;
	private const int MugshotMaxFileSize = 65536;
	private const float MugshotMaxDistance = 50;
	public static RelationshipManager.PlayerRelationships localRelationships;
	[ClientVar]
	public static Vector3 mugshotOffset;
	[CompilerGeneratedAttribute]
	private static RelationshipManager <ClientInstance>k__BackingField;
	public static int clientMaxTeamSize;

	public static RelationshipManager ClientInstance { get; set; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public static void RequestUpdatedContacts() { }

	[BaseEntity.RPC_Client]
	public void CLIENT_DoMugshot(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	public void CLIENT_RecieveLocalRelationships(BaseEntity.RPCMessage msg) { }

	public static void ChangeRelationship(ulong targetPlayerID, RelationshipManager.RelationshipType newRelationshipType) { }

	public static bool VisCheck(Vector3 a, Vector3 b) { }

	public static void CaptureAndSendMugshot(BasePlayer targetPlayer) { }

	public static RelationshipManager.PlayerRelationships GetLocal() { }

	private static uint GetSteamIdHash(ulong requesterSteamId, ulong targetSteamId) { }

	[CompilerGeneratedAttribute]
	public static RelationshipManager get_ClientInstance() { }

	[CompilerGeneratedAttribute]
	private static void set_ClientInstance(RelationshipManager value) { }

	public void OnEnable() { }

	public void OnDestroy() { }

	public static bool TeamsEnabled() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum RelationshipManager.RelationshipType // TypeDefIndex: 10354
{
	public int value__;
	public const RelationshipManager.RelationshipType NONE = 0;
	public const RelationshipManager.RelationshipType Acquaintance = 1;
	public const RelationshipManager.RelationshipType Friend = 2;
	public const RelationshipManager.RelationshipType Enemy = 3;

}

public class RelationshipManager.PlayerRelationshipInfo : Pool.IPooled, IServerFileReceiver // TypeDefIndex: 10355
{
	public string displayName;
	public ulong player;
	public RelationshipManager.RelationshipType type;
	public int weight;
	public uint mugshotCrc;
	public string notes;
	public float lastSeenTime;
	private readonly Action mugshotTimeoutAction;
	private uint loadedMugshotCrc;
	public bool mugshotLoading;
	public Texture2D mugshotTexture;

	public bool IsMugshotLoaded { get; }


	public bool get_IsMugshotLoaded() { }

	public void EnterPool() { }

	public void LeavePool() { }

	private void Reset() { }

	public void .ctor() { }

	public void RequestMugshot() { }

	private void WaitingForMugshotTimeout() { }

	public void OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

}

public class RelationshipManager.PlayerRelationships : Pool.IPooled // TypeDefIndex: 10356
{
	public bool dirty;
	public ulong ownerPlayer;
	public Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo> relations;


	public RelationshipManager.PlayerRelationshipInfo GetRelations(ulong player) { }

	public void .ctor() { }

	public void EnterPool() { }

	public void LeavePool() { }

}

private sealed class RelationshipManager.<>c // TypeDefIndex: 10357
{
	public static readonly RelationshipManager.<>c <>9;
	public static Func<ulong, ulong> <>9__11_0;
	public static Func<RelationshipManager.PlayerRelationshipInfo, ulong> <>9__11_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal ulong <CLIENT_RecieveLocalRelationships>

	internal ulong <CLIENT_RecieveLocalRelationships>

}

