public class RelationshipManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6359
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong lastTeamIndex; // 0x18
	public List<PlayerTeam> teamList; // 0x20
	public int maxTeamSize; // 0x28
	public List<RelationshipManager.PlayerRelationships> relationships; // 0x30

	// Methods

	// RVA: 0x1E01740 Offset: 0x1DFFD40 VA: 0x181E01740
	public static void ResetToPool(RelationshipManager instance) { }

	// RVA: 0x1E01410 Offset: 0x1DFFA10 VA: 0x181E01410
	public void ResetToPool() { }

	// RVA: 0x1E01350 Offset: 0x1DFF950 VA: 0x181E01350 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E00210 Offset: 0x1DFE810 VA: 0x181E00210
	public void CopyTo(RelationshipManager instance) { }

	// RVA: 0x1E004A0 Offset: 0x1DFEAA0 VA: 0x181E004A0
	public RelationshipManager Copy() { }

	// RVA: 0x1E00DB0 Offset: 0x1DFF3B0 VA: 0x181E00DB0
	public static RelationshipManager Deserialize(Stream stream) { }

	// RVA: 0x1E00520 Offset: 0x1DFEB20 VA: 0x181E00520
	public static RelationshipManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E00970 Offset: 0x1DFEF70 VA: 0x181E00970
	public static RelationshipManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E01230 Offset: 0x1DFF830 VA: 0x181E01230
	public static RelationshipManager Deserialize(byte[] buffer) { }

	// RVA: 0x1E013D0 Offset: 0x1DFF9D0 VA: 0x181E013D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E023C0 Offset: 0x1E009C0 VA: 0x181E023C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E023E0 Offset: 0x1E009E0 VA: 0x181E023E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager previous) { }

	// RVA: 0x1E013F0 Offset: 0x1DFF9F0 VA: 0x181E013F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E00E30 Offset: 0x1DFF430 VA: 0x181E00E30
	public static RelationshipManager Deserialize(byte[] buffer, RelationshipManager instance, bool isDelta = False) { }

	// RVA: 0x1E00F30 Offset: 0x1DFF530 VA: 0x181E00F30
	public static RelationshipManager Deserialize(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E005A0 Offset: 0x1DFEBA0 VA: 0x181E005A0
	public static RelationshipManager DeserializeLengthDelimited(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E00A00 Offset: 0x1DFF000 VA: 0x181E00A00
	public static RelationshipManager DeserializeLength(Stream stream, int length, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1E01A60 Offset: 0x1E00060 VA: 0x181E01A60
	public static void SerializeDelta(Stream stream, RelationshipManager instance, RelationshipManager previous) { }

	// RVA: 0x1E02010 Offset: 0x1E00610 VA: 0x181E02010
	public static void Serialize(Stream stream, RelationshipManager instance) { }

	// RVA: 0x1E023B0 Offset: 0x1E009B0 VA: 0x181E023B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E023C0 Offset: 0x1E009C0 VA: 0x181E023C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E01F00 Offset: 0x1E00500 VA: 0x181E01F00
	public static byte[] SerializeToBytes(RelationshipManager instance) { }

	// RVA: 0x1E01E50 Offset: 0x1E00450 VA: 0x181E01E50
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1DF89E0 Offset: 0x1DF6FE0 VA: 0x181DF89E0
	public static void ResetToPool(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF88C0 Offset: 0x1DF6EC0 VA: 0x181DF88C0
	public void ResetToPool() { }

	// RVA: 0x1DF81B0 Offset: 0x1DF67B0 VA: 0x181DF81B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF66A0 Offset: 0x1DF4CA0 VA: 0x181DF66A0
	public void CopyTo(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF6710 Offset: 0x1DF4D10 VA: 0x181DF6710
	public RelationshipManager.PlayerRelationshipInfo Copy() { }

	// RVA: 0x1DF7A80 Offset: 0x1DF6080 VA: 0x181DF7A80
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream) { }

	// RVA: 0x1DF67C0 Offset: 0x1DF4DC0 VA: 0x181DF67C0
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF6FC0 Offset: 0x1DF55C0 VA: 0x181DF6FC0
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DF7DB0 Offset: 0x1DF63B0 VA: 0x181DF7DB0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DF8230 Offset: 0x1DF6830 VA: 0x181DF8230
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DF9270 Offset: 0x1DF7870 VA: 0x181DF9270 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DF9290 Offset: 0x1DF7890 VA: 0x181DF9290 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF8520 Offset: 0x1DF6B20 VA: 0x181DF8520 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DF73B0 Offset: 0x1DF59B0 VA: 0x181DF73B0
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta = False) { }

	// RVA: 0x1DF7790 Offset: 0x1DF5D90 VA: 0x181DF7790
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF6840 Offset: 0x1DF4E40 VA: 0x181DF6840
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF6C10 Offset: 0x1DF5210 VA: 0x181DF6C10
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF8B00 Offset: 0x1DF7100 VA: 0x181DF8B00
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF9010 Offset: 0x1DF7610 VA: 0x181DF9010
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF9260 Offset: 0x1DF7860 VA: 0x181DF9260
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DF9270 Offset: 0x1DF7870 VA: 0x181DF9270
	public void ToProto(Stream stream) { }

	// RVA: 0x1DF8F00 Offset: 0x1DF7500 VA: 0x181DF8F00
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF8E50 Offset: 0x1DF7450 VA: 0x181DF8E50
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class RelationshipManager.PlayerRelationships : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6361
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerID; // 0x18
	public List<RelationshipManager.PlayerRelationshipInfo> relations; // 0x20

	// Methods

	// RVA: 0x1DFAC10 Offset: 0x1DF9210 VA: 0x181DFAC10
	public static void ResetToPool(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFADD0 Offset: 0x1DF93D0 VA: 0x181DFADD0
	public void ResetToPool() { }

	// RVA: 0x1DFAB50 Offset: 0x1DF9150 VA: 0x181DFAB50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF92B0 Offset: 0x1DF78B0 VA: 0x181DF92B0
	public void CopyTo(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DF9470 Offset: 0x1DF7A70 VA: 0x181DF9470
	public RelationshipManager.PlayerRelationships Copy() { }

	// RVA: 0x1DFA3F0 Offset: 0x1DF89F0 VA: 0x181DFA3F0
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream) { }

	// RVA: 0x1DF9B80 Offset: 0x1DF8180 VA: 0x181DF9B80
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF9C00 Offset: 0x1DF8200 VA: 0x181DF9C00
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFAA30 Offset: 0x1DF9030 VA: 0x181DFAA30
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer) { }

	// RVA: 0x1DFABD0 Offset: 0x1DF91D0 VA: 0x181DFABD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFB5C0 Offset: 0x1DF9BC0 VA: 0x181DFB5C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFB5E0 Offset: 0x1DF9BE0 VA: 0x181DFB5E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DFABF0 Offset: 0x1DF91F0 VA: 0x181DFABF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFA2F0 Offset: 0x1DF88F0 VA: 0x181DFA2F0
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer, RelationshipManager.PlayerRelationships instance, bool isDelta = False) { }

	// RVA: 0x1DFA470 Offset: 0x1DF8A70 VA: 0x181DFA470
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF94F0 Offset: 0x1DF7AF0 VA: 0x181DF94F0
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF9C90 Offset: 0x1DF8290 VA: 0x181DF9C90
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DFAF90 Offset: 0x1DF9590 VA: 0x181DFAF90
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationships instance, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DFB390 Offset: 0x1DF9990 VA: 0x181DFB390
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFB5B0 Offset: 0x1DF9BB0 VA: 0x181DFB5B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFB5C0 Offset: 0x1DF9BC0 VA: 0x181DFB5C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFB280 Offset: 0x1DF9880 VA: 0x181DFB280
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DFB1D0 Offset: 0x1DF97D0 VA: 0x181DFB1D0
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x94B640 Offset: 0x949C40 VA: 0x18094B640 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x94BE50 Offset: 0x94A450 VA: 0x18094BE50
	public static void RequestUpdatedContacts() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x949970 Offset: 0x947F70 VA: 0x180949970
	public void CLIENT_DoMugshot(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x949A50 Offset: 0x948050 VA: 0x180949A50
	public void CLIENT_RecieveLocalRelationships(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94B200 Offset: 0x949800 VA: 0x18094B200
	public static void ChangeRelationship(ulong targetPlayerID, RelationshipManager.RelationshipType newRelationshipType) { }

	// RVA: 0x94BF70 Offset: 0x94A570 VA: 0x18094BF70
	public static bool VisCheck(Vector3 a, Vector3 b) { }

	// RVA: 0x94A5D0 Offset: 0x948BD0 VA: 0x18094A5D0
	public static void CaptureAndSendMugshot(BasePlayer targetPlayer) { }

	// RVA: 0x94B390 Offset: 0x949990 VA: 0x18094B390
	public static RelationshipManager.PlayerRelationships GetLocal() { }

	// RVA: 0x94B3F0 Offset: 0x9499F0 VA: 0x18094B3F0
	private static uint GetSteamIdHash(ulong requesterSteamId, ulong targetSteamId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x94C2B0 Offset: 0x94A8B0 VA: 0x18094C2B0
	public static RelationshipManager get_ClientInstance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x94C310 Offset: 0x94A910 VA: 0x18094C310
	private static void set_ClientInstance(RelationshipManager value) { }

	// RVA: 0x94B570 Offset: 0x949B70 VA: 0x18094B570
	public void OnEnable() { }

	// RVA: 0x94B4A0 Offset: 0x949AA0 VA: 0x18094B4A0
	public void OnDestroy() { }

	// RVA: 0x94BF10 Offset: 0x94A510 VA: 0x18094BF10
	public static bool TeamsEnabled() { }

	// RVA: 0x94B400 Offset: 0x949A00 VA: 0x18094B400 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x94C250 Offset: 0x94A850 VA: 0x18094C250
	public void .ctor() { }

	// RVA: 0x94C110 Offset: 0x94A710 VA: 0x18094C110
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

	// RVA: 0x93BD70 Offset: 0x93A370 VA: 0x18093BD70
	public bool get_IsMugshotLoaded() { }

	// RVA: 0x93B720 Offset: 0x939D20 VA: 0x18093B720 Slot: 4
	public void EnterPool() { }

	// RVA: 0x93B720 Offset: 0x939D20 VA: 0x18093B720 Slot: 5
	public void LeavePool() { }

	// RVA: 0x93BAD0 Offset: 0x93A0D0 VA: 0x18093BAD0
	private void Reset() { }

	// RVA: 0x93BD00 Offset: 0x93A300 VA: 0x18093BD00
	public void .ctor() { }

	// RVA: 0x93B900 Offset: 0x939F00 VA: 0x18093B900
	public void RequestMugshot() { }

	// RVA: 0x93BCF0 Offset: 0x93A2F0 VA: 0x18093BCF0
	private void WaitingForMugshotTimeout() { }

	// RVA: 0x93B730 Offset: 0x939D30 VA: 0x18093B730 Slot: 6
	public void OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

}

public class RelationshipManager.PlayerRelationships : Pool.IPooled // TypeDefIndex: 8631
{	// Fields
	public bool dirty; // 0x10
	public ulong ownerPlayer; // 0x18
	public Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo> relations; // 0x20

	// Methods

	// RVA: 0x93BE60 Offset: 0x93A460 VA: 0x18093BE60
	public RelationshipManager.PlayerRelationshipInfo GetRelations(ulong player) { }

	// RVA: 0x93BFD0 Offset: 0x93A5D0 VA: 0x18093BFD0
	public void .ctor() { }

	// RVA: 0x93BDE0 Offset: 0x93A3E0 VA: 0x18093BDE0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x93BF40 Offset: 0x93A540 VA: 0x18093BF40 Slot: 5
	public void LeavePool() { }

}

private sealed class RelationshipManager.<>c // TypeDefIndex: 8632
{	// Fields
	public static readonly RelationshipManager.<>c <>9; // 0x0
	public static Func<ulong, ulong> <>9__10_0; // 0x8
	public static Func<RelationshipManager.PlayerRelationshipInfo, ulong> <>9__10_1; // 0x10

	// Methods

	// RVA: 0x956F20 Offset: 0x955520 VA: 0x180956F20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
	internal ulong <CLIENT_RecieveLocalRelationships>b__10_0(ulong r) { }

	// RVA: 0x956EC0 Offset: 0x9554C0 VA: 0x180956EC0
	internal ulong <CLIENT_RecieveLocalRelationships>b__10_1(RelationshipManager.PlayerRelationshipInfo r) { }

}

