public class BaseNetworkable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6292
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint group; // 0x18
	public uint prefabID; // 0x1C

	// Methods

	// RVA: 0x20015C0 Offset: 0x1FFFBC0 VA: 0x1820015C0
	public static void ResetToPool(BaseNetworkable instance) { }

	// RVA: 0x2001650 Offset: 0x1FFFC50 VA: 0x182001650
	public void ResetToPool() { }

	// RVA: 0x20012E0 Offset: 0x1FFF8E0 VA: 0x1820012E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28720 Offset: 0x1E26D20 VA: 0x181E28720
	public void CopyTo(BaseNetworkable instance) { }

	// RVA: 0x20003B0 Offset: 0x1FFE9B0 VA: 0x1820003B0
	public BaseNetworkable Copy() { }

	// RVA: 0x2000CC0 Offset: 0x1FFF2C0 VA: 0x182000CC0
	public static BaseNetworkable Deserialize(Stream stream) { }

	// RVA: 0x2000430 Offset: 0x1FFEA30 VA: 0x182000430
	public static BaseNetworkable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2000990 Offset: 0x1FFEF90 VA: 0x182000990
	public static BaseNetworkable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2000A20 Offset: 0x1FFF020 VA: 0x182000A20
	public static BaseNetworkable Deserialize(byte[] buffer) { }

	// RVA: 0x20013F0 Offset: 0x1FFF9F0 VA: 0x1820013F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2001B90 Offset: 0x2000190 VA: 0x182001B90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2001BB0 Offset: 0x20001B0 VA: 0x182001BB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseNetworkable previous) { }

	// RVA: 0x20015A0 Offset: 0x1FFFBA0 VA: 0x1820015A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2001060 Offset: 0x1FFF660 VA: 0x182001060
	public static BaseNetworkable Deserialize(byte[] buffer, BaseNetworkable instance, bool isDelta = False) { }

	// RVA: 0x2000EB0 Offset: 0x1FFF4B0 VA: 0x182000EB0
	public static BaseNetworkable Deserialize(Stream stream, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x20004B0 Offset: 0x1FFEAB0 VA: 0x1820004B0
	public static BaseNetworkable DeserializeLengthDelimited(Stream stream, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x2000730 Offset: 0x1FFED30 VA: 0x182000730
	public static BaseNetworkable DeserializeLength(Stream stream, int length, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x20016E0 Offset: 0x1FFFCE0 VA: 0x1820016E0
	public static void SerializeDelta(Stream stream, BaseNetworkable instance, BaseNetworkable previous) { }

	// RVA: 0x2001A60 Offset: 0x2000060 VA: 0x182001A60
	public static void Serialize(Stream stream, BaseNetworkable instance) { }

	// RVA: 0x2001B80 Offset: 0x2000180 VA: 0x182001B80
	public byte[] ToProtoBytes() { }

	// RVA: 0x2001B90 Offset: 0x2000190 VA: 0x182001B90
	public void ToProto(Stream stream) { }

	// RVA: 0x2001950 Offset: 0x1FFFF50 VA: 0x182001950
	public static byte[] SerializeToBytes(BaseNetworkable instance) { }

	// RVA: 0x20018A0 Offset: 0x1FFFEA0 VA: 0x1820018A0
	public static void SerializeLengthDelimited(Stream stream, BaseNetworkable instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x220CC70 Offset: 0x220B270 VA: 0x18220CC70
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x220CBC0 Offset: 0x220B1C0 VA: 0x18220CBC0
	protected Message StartMessage(Message.Type type, Connection connection) { }

	// RVA: 0x220C830 Offset: 0x220AE30 VA: 0x18220C830
	public void Decrypt(Connection connection, NetRead read) { }

	// RVA: 0x220CA50 Offset: 0x220B050 VA: 0x18220CA50
	public void Encrypt(Connection connection, ref MemoryStream stream) { }

	// RVA: 0x220CBA0 Offset: 0x220B1A0 VA: 0x18220CBA0
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
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	protected bool get_JustCreated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	protected void set_JustCreated(bool value) { }

	// RVA: 0xA4DAE0 Offset: 0xA4C0E0 VA: 0x180A4DAE0
	public void ClientSpawn(Entity info) { }

	// RVA: 0xA4DA60 Offset: 0xA4C060 VA: 0x180A4DA60 Slot: 13
	public virtual void ClientOnEnable() { }

	// RVA: 0xA4D870 Offset: 0xA4BE70 VA: 0x180A4D870 Slot: 14
	protected virtual void ClientInit(Entity info) { }

	// RVA: 0xA4ED90 Offset: 0xA4D390 VA: 0x180A4ED90
	public void OnNetworkUpdate(Entity entity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public virtual void PreNetworkUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public virtual void PostNetworkUpdate() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 17
	public virtual bool ShouldDestroyWithGroup() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 18
	public virtual bool ShouldDestroyImmediately() { }

	// RVA: 0xA4E920 Offset: 0xA4CF20 VA: 0x180A4E920
	public void NetworkDestroy(bool immediately) { }

	// RVA: 0xA4DEB0 Offset: 0xA4C4B0 VA: 0x180A4DEB0 Slot: 19
	protected virtual void DoClientDestroy() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	internal virtual void DoNetworkDestroy() { }

	// RVA: 0xA4D650 Offset: 0xA4BC50 VA: 0x180A4D650
	public void BroadcastOnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0xA4EF10 Offset: 0xA4D510 VA: 0x180A4EF10 Slot: 21
	public virtual void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA4E250 Offset: 0xA4C850 VA: 0x180A4E250
	public BaseEntity GetParentEntity() { }

	// RVA: 0xA4E260 Offset: 0xA4C860 VA: 0x180A4E260
	public bool HasParent() { }

	// RVA: 0xA4D5C0 Offset: 0xA4BBC0 VA: 0x180A4D5C0
	public void AddChild(BaseEntity child) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	protected virtual void OnChildAdded(BaseEntity child) { }

	// RVA: 0xA4EF90 Offset: 0xA4D590 VA: 0x180A4EF90
	public void RemoveChild(BaseEntity child) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	protected virtual void OnChildRemoved(BaseEntity child) { }

	// RVA: 0xA4F3D0 Offset: 0xA4D9D0 VA: 0x180A4F3D0
	public GameManager get_gameManager() { }

	// RVA: 0xA4F430 Offset: 0xA4DA30 VA: 0x180A4F430
	public PrefabAttribute.Library get_prefabAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4F2B0 Offset: 0xA4D8B0 VA: 0x180A4F2B0 Slot: 7
	public bool get_IsDestroyed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F1930 Offset: 0x6EFF30 VA: 0x1806F1930
	private void set_IsDestroyed(bool value) { }

	// RVA: 0xA4F2C0 Offset: 0xA4D8C0 VA: 0x180A4F2C0
	public string get_PrefabName() { }

	// RVA: 0xA4F340 Offset: 0xA4D940 VA: 0x180A4F340
	public string get_ShortPrefabName() { }

	// RVA: 0x82DFB0 Offset: 0x82C5B0 VA: 0x18082DFB0 Slot: 24
	public virtual Vector3 GetNetworkPosition() { }

	// RVA: 0xA4E210 Offset: 0xA4C810 VA: 0x180A4E210 Slot: 25
	public virtual Quaternion GetNetworkRotation() { }

	// RVA: 0xA4E270 Offset: 0xA4C870 VA: 0x180A4E270
	public string InvokeString() { }

	// RVA: 0xA4E880 Offset: 0xA4CE80 VA: 0x180A4E880
	public BaseEntity LookupPrefab() { }

	// RVA: 0xA4E1C0 Offset: 0xA4C7C0 VA: 0x180A4E1C0 Slot: 26
	public bool EqualNetID(BaseNetworkable other) { }

	// RVA: 0xA4E1F0 Offset: 0xA4C7F0 VA: 0x180A4E1F0
	public bool EqualNetID(uint otherID) { }

	// RVA: 0xA4F000 Offset: 0xA4D600 VA: 0x180A4F000 Slot: 27
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

	// RVA: 0xA4EC50 Offset: 0xA4D250 VA: 0x180A4EC50 Slot: 10
	public void OnNetworkGroupChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public void OnNetworkSubscribersEnter(List<Connection> connections) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public void OnNetworkSubscribersLeave(List<Connection> connections) { }

	// RVA: 0xA4E0D0 Offset: 0xA4C6D0 VA: 0x180A4E0D0
	private void EntityDestroy() { }

	// RVA: 0xA4DF70 Offset: 0xA4C570 VA: 0x180A4DF70
	private void DoEntityDestroy() { }

	// RVA: 0xA4F050 Offset: 0xA4D650 VA: 0x180A4F050
	private void SpawnShared() { }

	// RVA: 0xA4E4C0 Offset: 0xA4CAC0 VA: 0x180A4E4C0 Slot: 34
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

	// RVA: 0xA4F210 Offset: 0xA4D810 VA: 0x180A4F210
	protected void .ctor() { }

	// RVA: 0xA4F160 Offset: 0xA4D760 VA: 0x180A4F160
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

	// RVA: 0xA53CC0 Offset: 0xA522C0 VA: 0x180A53CC0 Slot: 6
	protected override Manager get_visibilityManager() { }

	// RVA: 0xA53C50 Offset: 0xA52250 VA: 0x180A53C50
	public void .ctor() { }

}

public abstract class BaseNetworkable.EntityRealm : IEnumerable<BaseNetworkable>, IEnumerable // TypeDefIndex: 9479
{	// Fields
	private ListDictionary<uint, BaseNetworkable> entityList; // 0x10

	// Properties
	public int Count { get; }
	protected abstract Manager visibilityManager { get; }

	// Methods

	// RVA: 0xA542C0 Offset: 0xA528C0 VA: 0x180A542C0
	public int get_Count() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract Manager get_visibilityManager();

	// RVA: 0xA53D90 Offset: 0xA52390 VA: 0x180A53D90
	public bool Contains(uint uid) { }

	// RVA: 0xA54060 Offset: 0xA52660 VA: 0x180A54060
	public BaseNetworkable Find(uint uid) { }

	// RVA: 0xA54150 Offset: 0xA52750 VA: 0x180A54150
	public void RegisterID(BaseNetworkable ent) { }

	// RVA: 0xA54250 Offset: 0xA52850 VA: 0x180A54250
	public void UnregisterID(BaseNetworkable ent) { }

	// RVA: 0xA53DF0 Offset: 0xA523F0 VA: 0x180A53DF0
	public Group FindGroup(uint uid) { }

	// RVA: 0xA54210 Offset: 0xA52810 VA: 0x180A54210
	public Group TryFindGroup(uint uid) { }

	// RVA: 0xA53E30 Offset: 0xA52430 VA: 0x180A53E30
	public void FindInGroup(uint uid, List<BaseNetworkable> list) { }

	// RVA: 0xA540E0 Offset: 0xA526E0 VA: 0x180A540E0 Slot: 4
	public IEnumerator<BaseNetworkable> GetEnumerator() { }

	// RVA: 0xA540E0 Offset: 0xA526E0 VA: 0x180A540E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xA53D40 Offset: 0xA52340 VA: 0x180A53D40
	public void Clear() { }

	// RVA: 0xA53C50 Offset: 0xA52250 VA: 0x180A53C50
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
	// RVA: 0xA4D540 Offset: 0xA4BB40 VA: 0x180A4D540
	public static bool IsValid(BaseNetworkable ent) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D530 Offset: 0xA4BB30 VA: 0x180A4D530
	public static bool IsRealNull(BaseNetworkable ent) { }

}

