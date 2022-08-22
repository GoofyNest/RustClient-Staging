public class BaseNetworkable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6292
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint group; // 0x18
	public uint prefabID; // 0x1C

	// Methods

	// RVA: 0x2001300 Offset: 0x1FFF900 VA: 0x182001300
	public static void ResetToPool(BaseNetworkable instance) { }

	// RVA: 0x2001390 Offset: 0x1FFF990 VA: 0x182001390
	public void ResetToPool() { }

	// RVA: 0x2001020 Offset: 0x1FFF620 VA: 0x182001020 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28460 Offset: 0x1E26A60 VA: 0x181E28460
	public void CopyTo(BaseNetworkable instance) { }

	// RVA: 0x20000F0 Offset: 0x1FFE6F0 VA: 0x1820000F0
	public BaseNetworkable Copy() { }

	// RVA: 0x2000A00 Offset: 0x1FFF000 VA: 0x182000A00
	public static BaseNetworkable Deserialize(Stream stream) { }

	// RVA: 0x2000170 Offset: 0x1FFE770 VA: 0x182000170
	public static BaseNetworkable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20006D0 Offset: 0x1FFECD0 VA: 0x1820006D0
	public static BaseNetworkable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2000760 Offset: 0x1FFED60 VA: 0x182000760
	public static BaseNetworkable Deserialize(byte[] buffer) { }

	// RVA: 0x2001130 Offset: 0x1FFF730 VA: 0x182001130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20018D0 Offset: 0x1FFFED0 VA: 0x1820018D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20018F0 Offset: 0x1FFFEF0 VA: 0x1820018F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseNetworkable previous) { }

	// RVA: 0x20012E0 Offset: 0x1FFF8E0 VA: 0x1820012E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2000DA0 Offset: 0x1FFF3A0 VA: 0x182000DA0
	public static BaseNetworkable Deserialize(byte[] buffer, BaseNetworkable instance, bool isDelta = False) { }

	// RVA: 0x2000BF0 Offset: 0x1FFF1F0 VA: 0x182000BF0
	public static BaseNetworkable Deserialize(Stream stream, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x20001F0 Offset: 0x1FFE7F0 VA: 0x1820001F0
	public static BaseNetworkable DeserializeLengthDelimited(Stream stream, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x2000470 Offset: 0x1FFEA70 VA: 0x182000470
	public static BaseNetworkable DeserializeLength(Stream stream, int length, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x2001420 Offset: 0x1FFFA20 VA: 0x182001420
	public static void SerializeDelta(Stream stream, BaseNetworkable instance, BaseNetworkable previous) { }

	// RVA: 0x20017A0 Offset: 0x1FFFDA0 VA: 0x1820017A0
	public static void Serialize(Stream stream, BaseNetworkable instance) { }

	// RVA: 0x20018C0 Offset: 0x1FFFEC0 VA: 0x1820018C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20018D0 Offset: 0x1FFFED0 VA: 0x1820018D0
	public void ToProto(Stream stream) { }

	// RVA: 0x2001690 Offset: 0x1FFFC90 VA: 0x182001690
	public static byte[] SerializeToBytes(BaseNetworkable instance) { }

	// RVA: 0x20015E0 Offset: 0x1FFFBE0 VA: 0x1820015E0
	public static void SerializeLengthDelimited(Stream stream, BaseNetworkable instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public abstract class BaseNetwork // TypeDefIndex: 6679
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private NetRead <read>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private NetWrite <write>k__BackingField; // 0x18
	public INetworkCryptocraphy cryptography; // 0x20

	// Properties
	public NetRead read { get; set; }
	public NetWrite write { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public NetRead get_read() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_read(NetRead value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public NetWrite get_write() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_write(NetWrite value) { }

	// RVA: 0x220C9B0 Offset: 0x220AFB0 VA: 0x18220C9B0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x220C900 Offset: 0x220AF00 VA: 0x18220C900
	protected Message StartMessage(Message.Type type, Connection connection) { }

	// RVA: 0x220C570 Offset: 0x220AB70 VA: 0x18220C570
	public void Decrypt(Connection connection, NetRead read) { }

	// RVA: 0x220C790 Offset: 0x220AD90 VA: 0x18220C790
	public void Encrypt(Connection connection, ref MemoryStream stream) { }

	// RVA: 0x220C8E0 Offset: 0x220AEE0 VA: 0x18220C8E0
	public void Record(Connection connection, Stream stream) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public virtual string GetDebug(Connection connection) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

}

public enum BaseNetwork.StatTypeLong // TypeDefIndex: 6680
{	// Fields
	public int value__; // 0x0
	public const BaseNetwork.StatTypeLong BytesSent = 0;
	public const BaseNetwork.StatTypeLong BytesSent_LastSecond = 1;
	public const BaseNetwork.StatTypeLong BytesReceived = 2;
	public const BaseNetwork.StatTypeLong BytesReceived_LastSecond = 3;
	public const BaseNetwork.StatTypeLong MessagesInSendBuffer = 4;
	public const BaseNetwork.StatTypeLong BytesInSendBuffer = 5;
	public const BaseNetwork.StatTypeLong MessagesInResendBuffer = 6;
	public const BaseNetwork.StatTypeLong BytesInResendBuffer = 7;
	public const BaseNetwork.StatTypeLong PacketLossAverage = 8;
	public const BaseNetwork.StatTypeLong PacketLossLastSecond = 9;
	public const BaseNetwork.StatTypeLong ThrottleBytes = 10;

}

public abstract class BaseNetworkable : BaseMonoBehaviour, IPrefabPostProcess, IEntity, NetworkHandler // TypeDefIndex: 9475
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <JustCreated>k__BackingField; // 0x18
	private DeferredAction entityDestroy; // 0x20
	public List<Component> postNetworkUpdateComponents; // 0x28
	public EntityRef parentEntity; // 0x30
	public readonly List<BaseEntity> children; // 0x40
	public bool canTriggerParent; // 0x48
	[HeaderAttribute] // RVA: 0x72360 Offset: 0x71760 VA: 0x180072360
	[ReadOnlyAttribute] // RVA: 0x72360 Offset: 0x71760 VA: 0x180072360
	public uint prefabID; // 0x4C
	[TooltipAttribute] // RVA: 0x724D0 Offset: 0x718D0 VA: 0x1800724D0
	public bool globalBroadcast; // 0x50
	public Networkable net; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsDestroyed>k__BackingField; // 0x60
	private string _prefabName; // 0x68
	private string _prefabNameWithoutExtension; // 0x70
	public static BaseNetworkable.EntityRealm clientEntities; // 0x0
	private const bool isServersideEntity = False;

	// Properties
	protected bool JustCreated { get; set; }
	public GameManager gameManager { get; }
	public PrefabAttribute.Library prefabAttribute { get; }
	public bool IsDestroyed { get; set; }
	public string PrefabName { get; }
	public string ShortPrefabName { get; }
	public bool isServer { get; }
	public bool isClient { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	protected bool get_JustCreated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	protected void set_JustCreated(bool value) { }

	// RVA: 0xA4D820 Offset: 0xA4BE20 VA: 0x180A4D820
	public void ClientSpawn(Entity info) { }

	// RVA: 0xA4D7A0 Offset: 0xA4BDA0 VA: 0x180A4D7A0 Slot: 13
	public virtual void ClientOnEnable() { }

	// RVA: 0xA4D5B0 Offset: 0xA4BBB0 VA: 0x180A4D5B0 Slot: 14
	protected virtual void ClientInit(Entity info) { }

	// RVA: 0xA4EAD0 Offset: 0xA4D0D0 VA: 0x180A4EAD0
	public void OnNetworkUpdate(Entity entity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public virtual void PreNetworkUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public virtual void PostNetworkUpdate() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 17
	public virtual bool ShouldDestroyWithGroup() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 18
	public virtual bool ShouldDestroyImmediately() { }

	// RVA: 0xA4E660 Offset: 0xA4CC60 VA: 0x180A4E660
	public void NetworkDestroy(bool immediately) { }

	// RVA: 0xA4DBF0 Offset: 0xA4C1F0 VA: 0x180A4DBF0 Slot: 19
	protected virtual void DoClientDestroy() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	internal virtual void DoNetworkDestroy() { }

	// RVA: 0xA4D390 Offset: 0xA4B990 VA: 0x180A4D390
	public void BroadcastOnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0xA4EC50 Offset: 0xA4D250 VA: 0x180A4EC50 Slot: 21
	public virtual void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA4DF90 Offset: 0xA4C590 VA: 0x180A4DF90
	public BaseEntity GetParentEntity() { }

	// RVA: 0xA4DFA0 Offset: 0xA4C5A0 VA: 0x180A4DFA0
	public bool HasParent() { }

	// RVA: 0xA4D300 Offset: 0xA4B900 VA: 0x180A4D300
	public void AddChild(BaseEntity child) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	protected virtual void OnChildAdded(BaseEntity child) { }

	// RVA: 0xA4ECD0 Offset: 0xA4D2D0 VA: 0x180A4ECD0
	public void RemoveChild(BaseEntity child) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	protected virtual void OnChildRemoved(BaseEntity child) { }

	// RVA: 0xA4F110 Offset: 0xA4D710 VA: 0x180A4F110
	public GameManager get_gameManager() { }

	// RVA: 0xA4F170 Offset: 0xA4D770 VA: 0x180A4F170
	public PrefabAttribute.Library get_prefabAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4EFF0 Offset: 0xA4D5F0 VA: 0x180A4EFF0 Slot: 7
	public bool get_IsDestroyed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F1820 Offset: 0x6EFE20 VA: 0x1806F1820
	private void set_IsDestroyed(bool value) { }

	// RVA: 0xA4F000 Offset: 0xA4D600 VA: 0x180A4F000
	public string get_PrefabName() { }

	// RVA: 0xA4F080 Offset: 0xA4D680 VA: 0x180A4F080
	public string get_ShortPrefabName() { }

	// RVA: 0x82DEA0 Offset: 0x82C4A0 VA: 0x18082DEA0 Slot: 24
	public virtual Vector3 GetNetworkPosition() { }

	// RVA: 0xA4DF50 Offset: 0xA4C550 VA: 0x180A4DF50 Slot: 25
	public virtual Quaternion GetNetworkRotation() { }

	// RVA: 0xA4DFB0 Offset: 0xA4C5B0 VA: 0x180A4DFB0
	public string InvokeString() { }

	// RVA: 0xA4E5C0 Offset: 0xA4CBC0 VA: 0x180A4E5C0
	public BaseEntity LookupPrefab() { }

	// RVA: 0xA4DF00 Offset: 0xA4C500 VA: 0x180A4DF00 Slot: 26
	public bool EqualNetID(BaseNetworkable other) { }

	// RVA: 0xA4DF30 Offset: 0xA4C530 VA: 0x180A4DF30
	public bool EqualNetID(uint otherID) { }

	// RVA: 0xA4ED40 Offset: 0xA4D340 VA: 0x180A4ED40 Slot: 27
	public virtual void ResetState() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 28
	public virtual void InitShared() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public virtual void PreInitShared() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 30
	public virtual void PostInitShared() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 31
	public virtual void DestroyShared() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 32
	public virtual void OnNetworkGroupEnter(Group group) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 33
	public virtual void OnNetworkGroupLeave(Group group) { }

	// RVA: 0xA4E990 Offset: 0xA4CF90 VA: 0x180A4E990 Slot: 10
	public void OnNetworkGroupChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public void OnNetworkSubscribersEnter(List<Connection> connections) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public void OnNetworkSubscribersLeave(List<Connection> connections) { }

	// RVA: 0xA4DE10 Offset: 0xA4C410 VA: 0x180A4DE10
	private void EntityDestroy() { }

	// RVA: 0xA4DCB0 Offset: 0xA4C2B0 VA: 0x180A4DCB0
	private void DoEntityDestroy() { }

	// RVA: 0xA4ED90 Offset: 0xA4D390 VA: 0x180A4ED90
	private void SpawnShared() { }

	// RVA: 0xA4E200 Offset: 0xA4C800 VA: 0x180A4E200 Slot: 34
	public virtual void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool get_isServer() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool get_isClient() { }

	// RVA: -1 Offset: -1
	public T ToClient<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB110 Offset: 0x5C9710 VA: 0x1805CB110
	|-BaseNetworkable.ToClient<BaseEntity>
	|-BaseNetworkable.ToClient<object>
	*/

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 35
	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA4EF50 Offset: 0xA4D550 VA: 0x180A4EF50
	protected void .ctor() { }

	// RVA: 0xA4EEA0 Offset: 0xA4D4A0 VA: 0x180A4EEA0
	private static void .cctor() { }

}

public struct BaseNetworkable.SaveInfo // TypeDefIndex: 9476
{	// Fields
	public Entity msg; // 0x0
	public bool forDisk; // 0x8
	public Connection forConnection; // 0x10

	// Methods

	// RVA: 0xFBCE0 Offset: 0xFB0E0 VA: 0x1800FBCE0
	internal bool SendingTo(Connection ownerConnection) { }

}

public struct BaseNetworkable.LoadInfo // TypeDefIndex: 9477
{	// Fields
	public Entity msg; // 0x0
	public bool fromDisk; // 0x8

}

public class BaseNetworkable.EntityRealmClient : BaseNetworkable.EntityRealm // TypeDefIndex: 9478
{	// Properties
	protected override Manager visibilityManager { get; }

	// Methods

	// RVA: 0xA53A00 Offset: 0xA52000 VA: 0x180A53A00 Slot: 6
	protected override Manager get_visibilityManager() { }

	// RVA: 0xA53990 Offset: 0xA51F90 VA: 0x180A53990
	public void .ctor() { }

}

public abstract class BaseNetworkable.EntityRealm : IEnumerable<BaseNetworkable>, IEnumerable // TypeDefIndex: 9479
{	// Fields
	private ListDictionary<uint, BaseNetworkable> entityList; // 0x10

	// Properties
	public int Count { get; }
	protected abstract Manager visibilityManager { get; }

	// Methods

	// RVA: 0xA54000 Offset: 0xA52600 VA: 0x180A54000
	public int get_Count() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract Manager get_visibilityManager();

	// RVA: 0xA53AD0 Offset: 0xA520D0 VA: 0x180A53AD0
	public bool Contains(uint uid) { }

	// RVA: 0xA53DA0 Offset: 0xA523A0 VA: 0x180A53DA0
	public BaseNetworkable Find(uint uid) { }

	// RVA: 0xA53E90 Offset: 0xA52490 VA: 0x180A53E90
	public void RegisterID(BaseNetworkable ent) { }

	// RVA: 0xA53F90 Offset: 0xA52590 VA: 0x180A53F90
	public void UnregisterID(BaseNetworkable ent) { }

	// RVA: 0xA53B30 Offset: 0xA52130 VA: 0x180A53B30
	public Group FindGroup(uint uid) { }

	// RVA: 0xA53F50 Offset: 0xA52550 VA: 0x180A53F50
	public Group TryFindGroup(uint uid) { }

	// RVA: 0xA53B70 Offset: 0xA52170 VA: 0x180A53B70
	public void FindInGroup(uint uid, List<BaseNetworkable> list) { }

	// RVA: 0xA53E20 Offset: 0xA52420 VA: 0x180A53E20 Slot: 4
	public IEnumerator<BaseNetworkable> GetEnumerator() { }

	// RVA: 0xA53E20 Offset: 0xA52420 VA: 0x180A53E20 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xA53A80 Offset: 0xA52080 VA: 0x180A53A80
	public void Clear() { }

	// RVA: 0xA53990 Offset: 0xA51F90 VA: 0x180A53990
	protected void .ctor() { }

}

public enum BaseNetworkable.DestroyMode // TypeDefIndex: 9480
{	// Fields
	public byte value__; // 0x0
	public const BaseNetworkable.DestroyMode None = 0;
	public const BaseNetworkable.DestroyMode Gib = 1;

}

public static class BaseNetworkableEx // TypeDefIndex: 9481
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D280 Offset: 0xA4B880 VA: 0x180A4D280
	public static bool IsValid(BaseNetworkable ent) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D270 Offset: 0xA4B870 VA: 0x180A4D270
	public static bool IsRealNull(BaseNetworkable ent) { }

}

