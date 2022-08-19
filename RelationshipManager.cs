public class RelationshipManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6359
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong lastTeamIndex; // 0x18
	public List<PlayerTeam> teamList; // 0x20
	public int maxTeamSize; // 0x28
	public List<RelationshipManager.PlayerRelationships> relationships; // 0x30

	// Methods

	// RVA: 0x1E01640 Offset: 0x1DFFC40 VA: 0x181E01640
	public static void ResetToPool(RelationshipManager instance) { }

	// RVA: 0x1E01310 Offset: 0x1DFF910 VA: 0x181E01310
	public void ResetToPool() { }

	// RVA: 0x1E01250 Offset: 0x1DFF850 VA: 0x181E01250 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E00110 Offset: 0x1DFE710 VA: 0x181E00110
	public void CopyTo(RelationshipManager instance) { }

	// RVA: 0x1E003A0 Offset: 0x1DFE9A0 VA: 0x181E003A0
	public RelationshipManager Copy() { }

	// RVA: 0x1E00CB0 Offset: 0x1DFF2B0 VA: 0x181E00CB0
	public static RelationshipManager Deserialize(Stream stream) { }

	// RVA: 0x1E00420 Offset: 0x1DFEA20 VA: 0x181E00420
	public static RelationshipManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E00870 Offset: 0x1DFEE70 VA: 0x181E00870
	public static RelationshipManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E01130 Offset: 0x1DFF730 VA: 0x181E01130
	public static RelationshipManager Deserialize(byte[] buffer) { }

	// RVA: 0x1E012D0 Offset: 0x1DFF8D0 VA: 0x181E012D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E022C0 Offset: 0x1E008C0 VA: 0x181E022C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E022E0 Offset: 0x1E008E0 VA: 0x181E022E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager previous) { }

	// RVA: 0x1E012F0 Offset: 0x1DFF8F0 VA: 0x181E012F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E00D30 Offset: 0x1DFF330 VA: 0x181E00D30
	public static RelationshipManager Deserialize(byte[] buffer, RelationshipManager instance, bool isDelta = False) { }

	// RVA: 0x1E00E30 Offset: 0x1DFF430 VA: 0x181E00E30
	public static RelationshipManager Deserialize(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E004A0 Offset: 0x1DFEAA0 VA: 0x181E004A0
	public static RelationshipManager DeserializeLengthDelimited(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E00900 Offset: 0x1DFEF00 VA: 0x181E00900
	public static RelationshipManager DeserializeLength(Stream stream, int length, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E01960 Offset: 0x1DFFF60 VA: 0x181E01960
	public static void SerializeDelta(Stream stream, RelationshipManager instance, RelationshipManager previous) { }

	// RVA: 0x1E01F10 Offset: 0x1E00510 VA: 0x181E01F10
	public static void Serialize(Stream stream, RelationshipManager instance) { }

	// RVA: 0x1E022B0 Offset: 0x1E008B0 VA: 0x181E022B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E022C0 Offset: 0x1E008C0 VA: 0x181E022C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E01E00 Offset: 0x1E00400 VA: 0x181E01E00
	public static byte[] SerializeToBytes(RelationshipManager instance) { }

	// RVA: 0x1E01D50 Offset: 0x1E00350 VA: 0x181E01D50
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

	// RVA: 0x1DF88E0 Offset: 0x1DF6EE0 VA: 0x181DF88E0
	public static void ResetToPool(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF87C0 Offset: 0x1DF6DC0 VA: 0x181DF87C0
	public void ResetToPool() { }

	// RVA: 0x1DF80B0 Offset: 0x1DF66B0 VA: 0x181DF80B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF65A0 Offset: 0x1DF4BA0 VA: 0x181DF65A0
	public void CopyTo(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF6610 Offset: 0x1DF4C10 VA: 0x181DF6610
	public RelationshipManager.PlayerRelationshipInfo Copy() { }

	// RVA: 0x1DF7980 Offset: 0x1DF5F80 VA: 0x181DF7980
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream) { }

	// RVA: 0x1DF66C0 Offset: 0x1DF4CC0 VA: 0x181DF66C0
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF6EC0 Offset: 0x1DF54C0 VA: 0x181DF6EC0
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DF7CB0 Offset: 0x1DF62B0 VA: 0x181DF7CB0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DF8130 Offset: 0x1DF6730 VA: 0x181DF8130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DF9170 Offset: 0x1DF7770 VA: 0x181DF9170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DF9190 Offset: 0x1DF7790 VA: 0x181DF9190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF8420 Offset: 0x1DF6A20 VA: 0x181DF8420 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DF72B0 Offset: 0x1DF58B0 VA: 0x181DF72B0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta = False) { }

	// RVA: 0x1DF7690 Offset: 0x1DF5C90 VA: 0x181DF7690
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF6740 Offset: 0x1DF4D40 VA: 0x181DF6740
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF6B10 Offset: 0x1DF5110 VA: 0x181DF6B10
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF8A00 Offset: 0x1DF7000 VA: 0x181DF8A00
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF8F10 Offset: 0x1DF7510 VA: 0x181DF8F10
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF9160 Offset: 0x1DF7760 VA: 0x181DF9160
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DF9170 Offset: 0x1DF7770 VA: 0x181DF9170
	public void ToProto(Stream stream) { }

	// RVA: 0x1DF8E00 Offset: 0x1DF7400 VA: 0x181DF8E00
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF8D50 Offset: 0x1DF7350 VA: 0x181DF8D50
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

	// RVA: 0x1DFAB10 Offset: 0x1DF9110 VA: 0x181DFAB10
	public static void ResetToPool(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFACD0 Offset: 0x1DF92D0 VA: 0x181DFACD0
	public void ResetToPool() { }

	// RVA: 0x1DFAA50 Offset: 0x1DF9050 VA: 0x181DFAA50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF91B0 Offset: 0x1DF77B0 VA: 0x181DF91B0
	public void CopyTo(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DF9370 Offset: 0x1DF7970 VA: 0x181DF9370
	public RelationshipManager.PlayerRelationships Copy() { }

	// RVA: 0x1DFA2F0 Offset: 0x1DF88F0 VA: 0x181DFA2F0
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream) { }

	// RVA: 0x1DF9A80 Offset: 0x1DF8080 VA: 0x181DF9A80
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF9B00 Offset: 0x1DF8100 VA: 0x181DF9B00
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFA930 Offset: 0x1DF8F30 VA: 0x181DFA930
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer) { }

	// RVA: 0x1DFAAD0 Offset: 0x1DF90D0 VA: 0x181DFAAD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFB4C0 Offset: 0x1DF9AC0 VA: 0x181DFB4C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFB4E0 Offset: 0x1DF9AE0 VA: 0x181DFB4E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DFAAF0 Offset: 0x1DF90F0 VA: 0x181DFAAF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFA1F0 Offset: 0x1DF87F0 VA: 0x181DFA1F0
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer, RelationshipManager.PlayerRelationships instance, bool isDelta = False) { }

	// RVA: 0x1DFA370 Offset: 0x1DF8970 VA: 0x181DFA370
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF93F0 Offset: 0x1DF79F0 VA: 0x181DF93F0
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF9B90 Offset: 0x1DF8190 VA: 0x181DF9B90
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DFAE90 Offset: 0x1DF9490 VA: 0x181DFAE90
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationships instance, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DFB290 Offset: 0x1DF9890 VA: 0x181DFB290
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFB4B0 Offset: 0x1DF9AB0 VA: 0x181DFB4B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFB4C0 Offset: 0x1DF9AC0 VA: 0x181DFB4C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFB180 Offset: 0x1DF9780 VA: 0x181DFB180
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFB0D0 Offset: 0x1DF96D0 VA: 0x181DFB0D0
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
	[ClientVar] // RVA: 0xB3B30 Offset: 0xB2F30 VA: 0x1800B3B30
	public static Vector3 mugshotOffset; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static RelationshipManager <ClientInstance>k__BackingField; // 0x18
	public static int clientMaxTeamSize; // 0x20

	// Properties
	public static RelationshipManager ClientInstance { get; set; }

	// Methods

	// RVA: 0x94B530 Offset: 0x949B30 VA: 0x18094B530 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x94BD40 Offset: 0x94A340 VA: 0x18094BD40
	public static void RequestUpdatedContacts() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x949860 Offset: 0x947E60 VA: 0x180949860
	public void CLIENT_DoMugshot(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x94C1A0 Offset: 0x94A7A0 VA: 0x18094C1A0
	public static RelationshipManager get_ClientInstance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

