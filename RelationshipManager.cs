public class RelationshipManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6359
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong lastTeamIndex; // 0x18
	public List<PlayerTeam> teamList; // 0x20
	public int maxTeamSize; // 0x28
	public List<RelationshipManager.PlayerRelationships> relationships; // 0x30

	// Methods

	// RVA: 0x1E01F60 Offset: 0x1E00560 VA: 0x181E01F60
	public static void ResetToPool(RelationshipManager instance) { }

	// RVA: 0x1E01C30 Offset: 0x1E00230 VA: 0x181E01C30
	public void ResetToPool() { }

	// RVA: 0x1E01B70 Offset: 0x1E00170 VA: 0x181E01B70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E00A30 Offset: 0x1DFF030 VA: 0x181E00A30
	public void CopyTo(RelationshipManager instance) { }

	// RVA: 0x1E00CC0 Offset: 0x1DFF2C0 VA: 0x181E00CC0
	public RelationshipManager Copy() { }

	// RVA: 0x1E015D0 Offset: 0x1DFFBD0 VA: 0x181E015D0
	public static RelationshipManager Deserialize(Stream stream) { }

	// RVA: 0x1E00D40 Offset: 0x1DFF340 VA: 0x181E00D40
	public static RelationshipManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E01190 Offset: 0x1DFF790 VA: 0x181E01190
	public static RelationshipManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E01A50 Offset: 0x1E00050 VA: 0x181E01A50
	public static RelationshipManager Deserialize(byte[] buffer) { }

	// RVA: 0x1E01BF0 Offset: 0x1E001F0 VA: 0x181E01BF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E02BE0 Offset: 0x1E011E0 VA: 0x181E02BE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E02C00 Offset: 0x1E01200 VA: 0x181E02C00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager previous) { }

	// RVA: 0x1E01C10 Offset: 0x1E00210 VA: 0x181E01C10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E01650 Offset: 0x1DFFC50 VA: 0x181E01650
	public static RelationshipManager Deserialize(byte[] buffer, RelationshipManager instance, bool isDelta = False) { }

	// RVA: 0x1E01750 Offset: 0x1DFFD50 VA: 0x181E01750
	public static RelationshipManager Deserialize(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E00DC0 Offset: 0x1DFF3C0 VA: 0x181E00DC0
	public static RelationshipManager DeserializeLengthDelimited(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E01220 Offset: 0x1DFF820 VA: 0x181E01220
	public static RelationshipManager DeserializeLength(Stream stream, int length, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E02280 Offset: 0x1E00880 VA: 0x181E02280
	public static void SerializeDelta(Stream stream, RelationshipManager instance, RelationshipManager previous) { }

	// RVA: 0x1E02830 Offset: 0x1E00E30 VA: 0x181E02830
	public static void Serialize(Stream stream, RelationshipManager instance) { }

	// RVA: 0x1E02BD0 Offset: 0x1E011D0 VA: 0x181E02BD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E02BE0 Offset: 0x1E011E0 VA: 0x181E02BE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E02720 Offset: 0x1E00D20 VA: 0x181E02720
	public static byte[] SerializeToBytes(RelationshipManager instance) { }

	// RVA: 0x1E02670 Offset: 0x1E00C70 VA: 0x181E02670
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1DF9200 Offset: 0x1DF7800 VA: 0x181DF9200
	public static void ResetToPool(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF90E0 Offset: 0x1DF76E0 VA: 0x181DF90E0
	public void ResetToPool() { }

	// RVA: 0x1DF89D0 Offset: 0x1DF6FD0 VA: 0x181DF89D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF6EC0 Offset: 0x1DF54C0 VA: 0x181DF6EC0
	public void CopyTo(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF6F30 Offset: 0x1DF5530 VA: 0x181DF6F30
	public RelationshipManager.PlayerRelationshipInfo Copy() { }

	// RVA: 0x1DF82A0 Offset: 0x1DF68A0 VA: 0x181DF82A0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream) { }

	// RVA: 0x1DF6FE0 Offset: 0x1DF55E0 VA: 0x181DF6FE0
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF77E0 Offset: 0x1DF5DE0 VA: 0x181DF77E0
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DF85D0 Offset: 0x1DF6BD0 VA: 0x181DF85D0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DF8A50 Offset: 0x1DF7050 VA: 0x181DF8A50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DF9A90 Offset: 0x1DF8090 VA: 0x181DF9A90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DF9AB0 Offset: 0x1DF80B0 VA: 0x181DF9AB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF8D40 Offset: 0x1DF7340 VA: 0x181DF8D40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DF7BD0 Offset: 0x1DF61D0 VA: 0x181DF7BD0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta = False) { }

	// RVA: 0x1DF7FB0 Offset: 0x1DF65B0 VA: 0x181DF7FB0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF7060 Offset: 0x1DF5660 VA: 0x181DF7060
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF7430 Offset: 0x1DF5A30 VA: 0x181DF7430
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF9320 Offset: 0x1DF7920 VA: 0x181DF9320
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF9830 Offset: 0x1DF7E30 VA: 0x181DF9830
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF9A80 Offset: 0x1DF8080 VA: 0x181DF9A80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DF9A90 Offset: 0x1DF8090 VA: 0x181DF9A90
	public void ToProto(Stream stream) { }

	// RVA: 0x1DF9720 Offset: 0x1DF7D20 VA: 0x181DF9720
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF9670 Offset: 0x1DF7C70 VA: 0x181DF9670
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class RelationshipManager.PlayerRelationships : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6361
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerID; // 0x18
	public List<RelationshipManager.PlayerRelationshipInfo> relations; // 0x20

	// Methods

	// RVA: 0x1DFB430 Offset: 0x1DF9A30 VA: 0x181DFB430
	public static void ResetToPool(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFB5F0 Offset: 0x1DF9BF0 VA: 0x181DFB5F0
	public void ResetToPool() { }

	// RVA: 0x1DFB370 Offset: 0x1DF9970 VA: 0x181DFB370 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF9AD0 Offset: 0x1DF80D0 VA: 0x181DF9AD0
	public void CopyTo(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DF9C90 Offset: 0x1DF8290 VA: 0x181DF9C90
	public RelationshipManager.PlayerRelationships Copy() { }

	// RVA: 0x1DFAC10 Offset: 0x1DF9210 VA: 0x181DFAC10
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream) { }

	// RVA: 0x1DFA3A0 Offset: 0x1DF89A0 VA: 0x181DFA3A0
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFA420 Offset: 0x1DF8A20 VA: 0x181DFA420
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFB250 Offset: 0x1DF9850 VA: 0x181DFB250
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer) { }

	// RVA: 0x1DFB3F0 Offset: 0x1DF99F0 VA: 0x181DFB3F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFBDE0 Offset: 0x1DFA3E0 VA: 0x181DFBDE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFBE00 Offset: 0x1DFA400 VA: 0x181DFBE00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DFB410 Offset: 0x1DF9A10 VA: 0x181DFB410 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFAB10 Offset: 0x1DF9110 VA: 0x181DFAB10
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer, RelationshipManager.PlayerRelationships instance, bool isDelta = False) { }

	// RVA: 0x1DFAC90 Offset: 0x1DF9290 VA: 0x181DFAC90
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF9D10 Offset: 0x1DF8310 VA: 0x181DF9D10
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DFA4B0 Offset: 0x1DF8AB0 VA: 0x181DFA4B0
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DFB7B0 Offset: 0x1DF9DB0 VA: 0x181DFB7B0
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationships instance, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DFBBB0 Offset: 0x1DFA1B0 VA: 0x181DFBBB0
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFBDD0 Offset: 0x1DFA3D0 VA: 0x181DFBDD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFBDE0 Offset: 0x1DFA3E0 VA: 0x181DFBDE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFBAA0 Offset: 0x1DFA0A0 VA: 0x181DFBAA0
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFB9F0 Offset: 0x1DF9FF0 VA: 0x181DFB9F0
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x94BB50 Offset: 0x94A150 VA: 0x18094BB50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x94C360 Offset: 0x94A960 VA: 0x18094C360
	public static void RequestUpdatedContacts() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x949E80 Offset: 0x948480 VA: 0x180949E80
	public void CLIENT_DoMugshot(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x949F60 Offset: 0x948560 VA: 0x180949F60
	public void CLIENT_RecieveLocalRelationships(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94B710 Offset: 0x949D10 VA: 0x18094B710
	public static void ChangeRelationship(ulong targetPlayerID, RelationshipManager.RelationshipType newRelationshipType) { }

	// RVA: 0x94C480 Offset: 0x94AA80 VA: 0x18094C480
	public static bool VisCheck(Vector3 a, Vector3 b) { }

	// RVA: 0x94AAE0 Offset: 0x9490E0 VA: 0x18094AAE0
	public static void CaptureAndSendMugshot(BasePlayer targetPlayer) { }

	// RVA: 0x94B8A0 Offset: 0x949EA0 VA: 0x18094B8A0
	public static RelationshipManager.PlayerRelationships GetLocal() { }

	// RVA: 0x94B900 Offset: 0x949F00 VA: 0x18094B900
	private static uint GetSteamIdHash(ulong requesterSteamId, ulong targetSteamId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x94C7C0 Offset: 0x94ADC0 VA: 0x18094C7C0
	public static RelationshipManager get_ClientInstance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x94C820 Offset: 0x94AE20 VA: 0x18094C820
	private static void set_ClientInstance(RelationshipManager value) { }

	// RVA: 0x94BA80 Offset: 0x94A080 VA: 0x18094BA80
	public void OnEnable() { }

	// RVA: 0x94B9B0 Offset: 0x949FB0 VA: 0x18094B9B0
	public void OnDestroy() { }

	// RVA: 0x94C420 Offset: 0x94AA20 VA: 0x18094C420
	public static bool TeamsEnabled() { }

	// RVA: 0x94B910 Offset: 0x949F10 VA: 0x18094B910 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x94C760 Offset: 0x94AD60 VA: 0x18094C760
	public void .ctor() { }

	// RVA: 0x94C620 Offset: 0x94AC20 VA: 0x18094C620
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

	// RVA: 0x93C280 Offset: 0x93A880 VA: 0x18093C280
	public bool get_IsMugshotLoaded() { }

	// RVA: 0x93BC30 Offset: 0x93A230 VA: 0x18093BC30 Slot: 4
	public void EnterPool() { }

	// RVA: 0x93BC30 Offset: 0x93A230 VA: 0x18093BC30 Slot: 5
	public void LeavePool() { }

	// RVA: 0x93BFE0 Offset: 0x93A5E0 VA: 0x18093BFE0
	private void Reset() { }

	// RVA: 0x93C210 Offset: 0x93A810 VA: 0x18093C210
	public void .ctor() { }

	// RVA: 0x93BE10 Offset: 0x93A410 VA: 0x18093BE10
	public void RequestMugshot() { }

	// RVA: 0x93C200 Offset: 0x93A800 VA: 0x18093C200
	private void WaitingForMugshotTimeout() { }

	// RVA: 0x93BC40 Offset: 0x93A240 VA: 0x18093BC40 Slot: 6
	public void OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

}

public class RelationshipManager.PlayerRelationships : Pool.IPooled // TypeDefIndex: 8631
{	// Fields
	public bool dirty; // 0x10
	public ulong ownerPlayer; // 0x18
	public Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo> relations; // 0x20

	// Methods

	// RVA: 0x93C370 Offset: 0x93A970 VA: 0x18093C370
	public RelationshipManager.PlayerRelationshipInfo GetRelations(ulong player) { }

	// RVA: 0x93C4E0 Offset: 0x93AAE0 VA: 0x18093C4E0
	public void .ctor() { }

	// RVA: 0x93C2F0 Offset: 0x93A8F0 VA: 0x18093C2F0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x93C450 Offset: 0x93AA50 VA: 0x18093C450 Slot: 5
	public void LeavePool() { }

}

private sealed class RelationshipManager.<>c // TypeDefIndex: 8632
{	// Fields
	public static readonly RelationshipManager.<>c <>9; // 0x0
	public static Func<ulong, ulong> <>9__10_0; // 0x8
	public static Func<RelationshipManager.PlayerRelationshipInfo, ulong> <>9__10_1; // 0x10

	// Methods

	// RVA: 0x957420 Offset: 0x955A20 VA: 0x180957420
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	internal ulong <CLIENT_RecieveLocalRelationships>b__10_0(ulong r) { }

	// RVA: 0x9573C0 Offset: 0x9559C0 VA: 0x1809573C0
	internal ulong <CLIENT_RecieveLocalRelationships>b__10_1(RelationshipManager.PlayerRelationshipInfo r) { }

}

