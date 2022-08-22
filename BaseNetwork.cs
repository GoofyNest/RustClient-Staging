public class BaseNetworkable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6292
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint group; // 0x18
	public uint prefabID; // 0x1C

	// Methods

	// RVA: 0x2001DE0 Offset: 0x20003E0 VA: 0x182001DE0
	public static void ResetToPool(BaseNetworkable instance) { }

	// RVA: 0x2001E70 Offset: 0x2000470 VA: 0x182001E70
	public void ResetToPool() { }

	// RVA: 0x2001B00 Offset: 0x2000100 VA: 0x182001B00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28F40 Offset: 0x1E27540 VA: 0x181E28F40
	public void CopyTo(BaseNetworkable instance) { }

	// RVA: 0x2000BD0 Offset: 0x1FFF1D0 VA: 0x182000BD0
	public BaseNetworkable Copy() { }

	// RVA: 0x20014E0 Offset: 0x1FFFAE0 VA: 0x1820014E0
	public static BaseNetworkable Deserialize(Stream stream) { }

	// RVA: 0x2000C50 Offset: 0x1FFF250 VA: 0x182000C50
	public static BaseNetworkable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20011B0 Offset: 0x1FFF7B0 VA: 0x1820011B0
	public static BaseNetworkable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2001240 Offset: 0x1FFF840 VA: 0x182001240
	public static BaseNetworkable Deserialize(byte[] buffer) { }

	// RVA: 0x2001C10 Offset: 0x2000210 VA: 0x182001C10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20023B0 Offset: 0x20009B0 VA: 0x1820023B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20023D0 Offset: 0x20009D0 VA: 0x1820023D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseNetworkable previous) { }

	// RVA: 0x2001DC0 Offset: 0x20003C0 VA: 0x182001DC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2001880 Offset: 0x1FFFE80 VA: 0x182001880
	public static BaseNetworkable Deserialize(byte[] buffer, BaseNetworkable instance, bool isDelta = False) { }

	// RVA: 0x20016D0 Offset: 0x1FFFCD0 VA: 0x1820016D0
	public static BaseNetworkable Deserialize(Stream stream, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x2000CD0 Offset: 0x1FFF2D0 VA: 0x182000CD0
	public static BaseNetworkable DeserializeLengthDelimited(Stream stream, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x2000F50 Offset: 0x1FFF550 VA: 0x182000F50
	public static BaseNetworkable DeserializeLength(Stream stream, int length, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x2001F00 Offset: 0x2000500 VA: 0x182001F00
	public static void SerializeDelta(Stream stream, BaseNetworkable instance, BaseNetworkable previous) { }

	// RVA: 0x2002280 Offset: 0x2000880 VA: 0x182002280
	public static void Serialize(Stream stream, BaseNetworkable instance) { }

	// RVA: 0x20023A0 Offset: 0x20009A0 VA: 0x1820023A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20023B0 Offset: 0x20009B0 VA: 0x1820023B0
	public void ToProto(Stream stream) { }

	// RVA: 0x2002170 Offset: 0x2000770 VA: 0x182002170
	public static byte[] SerializeToBytes(BaseNetworkable instance) { }

	// RVA: 0x20020C0 Offset: 0x20006C0 VA: 0x1820020C0
	public static void SerializeLengthDelimited(Stream stream, BaseNetworkable instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public NetRead get_read() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_read(NetRead value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public NetWrite get_write() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_write(NetWrite value) { }

	// RVA: 0x220D490 Offset: 0x220BA90 VA: 0x18220D490
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x220D3E0 Offset: 0x220B9E0 VA: 0x18220D3E0
	protected Message StartMessage(Message.Type type, Connection connection) { }

	// RVA: 0x220D050 Offset: 0x220B650 VA: 0x18220D050
	public void Decrypt(Connection connection, NetRead read) { }

	// RVA: 0x220D270 Offset: 0x220B870 VA: 0x18220D270
	public void Encrypt(Connection connection, ref MemoryStream stream) { }

	// RVA: 0x220D3C0 Offset: 0x220B9C0 VA: 0x18220D3C0
	public void Record(Connection connection, Stream stream) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public virtual string GetDebug(Connection connection) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
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
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	protected bool get_JustCreated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	protected void set_JustCreated(bool value) { }

	// RVA: 0xA4DFB0 Offset: 0xA4C5B0 VA: 0x180A4DFB0
	public void ClientSpawn(Entity info) { }

	// RVA: 0xA4DF30 Offset: 0xA4C530 VA: 0x180A4DF30 Slot: 13
	public virtual void ClientOnEnable() { }

	// RVA: 0xA4DD40 Offset: 0xA4C340 VA: 0x180A4DD40 Slot: 14
	protected virtual void ClientInit(Entity info) { }

	// RVA: 0xA4F260 Offset: 0xA4D860 VA: 0x180A4F260
	public void OnNetworkUpdate(Entity entity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public virtual void PreNetworkUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public virtual void PostNetworkUpdate() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 17
	public virtual bool ShouldDestroyWithGroup() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 18
	public virtual bool ShouldDestroyImmediately() { }

	// RVA: 0xA4EDF0 Offset: 0xA4D3F0 VA: 0x180A4EDF0
	public void NetworkDestroy(bool immediately) { }

	// RVA: 0xA4E380 Offset: 0xA4C980 VA: 0x180A4E380 Slot: 19
	protected virtual void DoClientDestroy() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	internal virtual void DoNetworkDestroy() { }

	// RVA: 0xA4DB20 Offset: 0xA4C120 VA: 0x180A4DB20
	public void BroadcastOnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0xA4F3E0 Offset: 0xA4D9E0 VA: 0x180A4F3E0 Slot: 21
	public virtual void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA4E720 Offset: 0xA4CD20 VA: 0x180A4E720
	public BaseEntity GetParentEntity() { }

	// RVA: 0xA4E730 Offset: 0xA4CD30 VA: 0x180A4E730
	public bool HasParent() { }

	// RVA: 0xA4DA90 Offset: 0xA4C090 VA: 0x180A4DA90
	public void AddChild(BaseEntity child) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 22
	protected virtual void OnChildAdded(BaseEntity child) { }

	// RVA: 0xA4F460 Offset: 0xA4DA60 VA: 0x180A4F460
	public void RemoveChild(BaseEntity child) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	protected virtual void OnChildRemoved(BaseEntity child) { }

	// RVA: 0xA4F8A0 Offset: 0xA4DEA0 VA: 0x180A4F8A0
	public GameManager get_gameManager() { }

	// RVA: 0xA4F900 Offset: 0xA4DF00 VA: 0x180A4F900
	public PrefabAttribute.Library get_prefabAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4F780 Offset: 0xA4DD80 VA: 0x180A4F780 Slot: 7
	public bool get_IsDestroyed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F18C0 Offset: 0x6EFEC0 VA: 0x1806F18C0
	private void set_IsDestroyed(bool value) { }

	// RVA: 0xA4F790 Offset: 0xA4DD90 VA: 0x180A4F790
	public string get_PrefabName() { }

	// RVA: 0xA4F810 Offset: 0xA4DE10 VA: 0x180A4F810
	public string get_ShortPrefabName() { }

	// RVA: 0x82E500 Offset: 0x82CB00 VA: 0x18082E500 Slot: 24
	public virtual Vector3 GetNetworkPosition() { }

	// RVA: 0xA4E6E0 Offset: 0xA4CCE0 VA: 0x180A4E6E0 Slot: 25
	public virtual Quaternion GetNetworkRotation() { }

	// RVA: 0xA4E740 Offset: 0xA4CD40 VA: 0x180A4E740
	public string InvokeString() { }

	// RVA: 0xA4ED50 Offset: 0xA4D350 VA: 0x180A4ED50
	public BaseEntity LookupPrefab() { }

	// RVA: 0xA4E690 Offset: 0xA4CC90 VA: 0x180A4E690 Slot: 26
	public bool EqualNetID(BaseNetworkable other) { }

	// RVA: 0xA4E6C0 Offset: 0xA4CCC0 VA: 0x180A4E6C0
	public bool EqualNetID(uint otherID) { }

	// RVA: 0xA4F4D0 Offset: 0xA4DAD0 VA: 0x180A4F4D0 Slot: 27
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

	// RVA: 0xA4F120 Offset: 0xA4D720 VA: 0x180A4F120 Slot: 10
	public void OnNetworkGroupChange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public void OnNetworkSubscribersEnter(List<Connection> connections) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public void OnNetworkSubscribersLeave(List<Connection> connections) { }

	// RVA: 0xA4E5A0 Offset: 0xA4CBA0 VA: 0x180A4E5A0
	private void EntityDestroy() { }

	// RVA: 0xA4E440 Offset: 0xA4CA40 VA: 0x180A4E440
	private void DoEntityDestroy() { }

	// RVA: 0xA4F520 Offset: 0xA4DB20 VA: 0x180A4F520
	private void SpawnShared() { }

	// RVA: 0xA4E990 Offset: 0xA4CF90 VA: 0x180A4E990 Slot: 34
	public virtual void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool get_isServer() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool get_isClient() { }

	// RVA: -1 Offset: -1
	public T ToClient<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB0A0 Offset: 0x5C96A0 VA: 0x1805CB0A0
	|-BaseNetworkable.ToClient<BaseEntity>
	|-BaseNetworkable.ToClient<object>
	*/

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 35
	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA4F6E0 Offset: 0xA4DCE0 VA: 0x180A4F6E0
	protected void .ctor() { }

	// RVA: 0xA4F630 Offset: 0xA4DC30 VA: 0x180A4F630
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

	// RVA: 0xA54190 Offset: 0xA52790 VA: 0x180A54190 Slot: 6
	protected override Manager get_visibilityManager() { }

	// RVA: 0xA54120 Offset: 0xA52720 VA: 0x180A54120
	public void .ctor() { }

}

public abstract class BaseNetworkable.EntityRealm : IEnumerable<BaseNetworkable>, IEnumerable // TypeDefIndex: 9479
{	// Fields
	private ListDictionary<uint, BaseNetworkable> entityList; // 0x10

	// Properties
	public int Count { get; }
	protected abstract Manager visibilityManager { get; }

	// Methods

	// RVA: 0xA54790 Offset: 0xA52D90 VA: 0x180A54790
	public int get_Count() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract Manager get_visibilityManager();

	// RVA: 0xA54260 Offset: 0xA52860 VA: 0x180A54260
	public bool Contains(uint uid) { }

	// RVA: 0xA54530 Offset: 0xA52B30 VA: 0x180A54530
	public BaseNetworkable Find(uint uid) { }

	// RVA: 0xA54620 Offset: 0xA52C20 VA: 0x180A54620
	public void RegisterID(BaseNetworkable ent) { }

	// RVA: 0xA54720 Offset: 0xA52D20 VA: 0x180A54720
	public void UnregisterID(BaseNetworkable ent) { }

	// RVA: 0xA542C0 Offset: 0xA528C0 VA: 0x180A542C0
	public Group FindGroup(uint uid) { }

	// RVA: 0xA546E0 Offset: 0xA52CE0 VA: 0x180A546E0
	public Group TryFindGroup(uint uid) { }

	// RVA: 0xA54300 Offset: 0xA52900 VA: 0x180A54300
	public void FindInGroup(uint uid, List<BaseNetworkable> list) { }

	// RVA: 0xA545B0 Offset: 0xA52BB0 VA: 0x180A545B0 Slot: 4
	public IEnumerator<BaseNetworkable> GetEnumerator() { }

	// RVA: 0xA545B0 Offset: 0xA52BB0 VA: 0x180A545B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xA54210 Offset: 0xA52810 VA: 0x180A54210
	public void Clear() { }

	// RVA: 0xA54120 Offset: 0xA52720 VA: 0x180A54120
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
	// RVA: 0xA4DA10 Offset: 0xA4C010 VA: 0x180A4DA10
	public static bool IsValid(BaseNetworkable ent) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4DA00 Offset: 0xA4C000 VA: 0x180A4DA00
	public static bool IsRealNull(BaseNetworkable ent) { }

}

