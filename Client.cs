internal class ClientIdentity : Identity // TypeDefIndex: 1134
{	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0xFE0B30 Offset: 0xFDF130 VA: 0x180FE0B30
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0xFE0C00 Offset: 0xFDF200 VA: 0x180FE0C00
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0xFE0CD0 Offset: 0xFDF2D0 VA: 0x180FE0CD0
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0xFE0CA0 Offset: 0xFDF2A0 VA: 0x180FE0CA0
	public string get_TargetUri() { }

}

internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 1146
{	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0xFE0B10 Offset: 0xFDF110 VA: 0x180FE0B10
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0xFE0A10 Offset: 0xFDF010 VA: 0x180FE0A10 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0xFE0A70 Offset: 0xFDF070 VA: 0x180FE0A70 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0xFE08F0 Offset: 0xFDEEF0 VA: 0x180FE08F0 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 1230
{	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(Context ctx) { }

	// RVA: 0x1472760 Offset: 0x1470D60 VA: 0x181472760 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x14724A0 Offset: 0x1470AA0 VA: 0x1814724A0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 1231
{	// Fields
	private IMessageSink _replySink; // 0x10
	private Context _context; // 0x18

	// Methods

	// RVA: 0xFDC620 Offset: 0xFDAC20 VA: 0x180FDC620
	public void .ctor(Context ctx, IMessageSink replySink) { }

	// RVA: 0x14723B0 Offset: 0x14709B0 VA: 0x1814723B0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1472360 Offset: 0x1470960 VA: 0x181472360 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal struct ClientGameServerDeny_t : ICallbackData // TypeDefIndex: 5296
{	// Fields
	internal uint AppID; // 0x0
	internal uint GameServerIP; // 0x4
	internal ushort GameServerPort; // 0x8
	internal ushort Secure; // 0xA
	internal uint Reason; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4700 Offset: 0x1E3B00 VA: 0x1801E4700 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E46F0 Offset: 0x1E3AF0 VA: 0x1801E46F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E5B0 Offset: 0x136CBB0 VA: 0x18136E5B0
	private static void .cctor() { }

}

public class ClientReady : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6494
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ClientReady.ClientInfo> clientInfo; // 0x18

	// Methods

	// RVA: 0x20ABF90 Offset: 0x20AA590 VA: 0x1820ABF90
	public static void ResetToPool(ClientReady instance) { }

	// RVA: 0x20ABDE0 Offset: 0x20AA3E0 VA: 0x1820ABDE0
	public void ResetToPool() { }

	// RVA: 0x20ABB60 Offset: 0x20AA160 VA: 0x1820ABB60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20AAE20 Offset: 0x20A9420 VA: 0x1820AAE20
	public void CopyTo(ClientReady instance) { }

	// RVA: 0x20AAFD0 Offset: 0x20A95D0 VA: 0x1820AAFD0
	public ClientReady Copy() { }

	// RVA: 0x20AB6D0 Offset: 0x20A9CD0 VA: 0x1820AB6D0
	public static ClientReady Deserialize(Stream stream) { }

	// RVA: 0x20AB050 Offset: 0x20A9650 VA: 0x1820AB050
	public static ClientReady DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AB3A0 Offset: 0x20A99A0 VA: 0x1820AB3A0
	public static ClientReady DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20ABA40 Offset: 0x20AA040 VA: 0x1820ABA40
	public static ClientReady Deserialize(byte[] buffer) { }

	// RVA: 0x20ABDA0 Offset: 0x20AA3A0 VA: 0x1820ABDA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AC6D0 Offset: 0x20AACD0 VA: 0x1820AC6D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AC6F0 Offset: 0x20AACF0 VA: 0x1820AC6F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ClientReady previous) { }

	// RVA: 0x20ABDC0 Offset: 0x20AA3C0 VA: 0x1820ABDC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AB940 Offset: 0x20A9F40 VA: 0x1820AB940
	public static ClientReady Deserialize(byte[] buffer, ClientReady instance, bool isDelta = False) { }

	// RVA: 0x20AB750 Offset: 0x20A9D50 VA: 0x1820AB750
	public static ClientReady Deserialize(Stream stream, ClientReady instance, bool isDelta) { }

	// RVA: 0x20AB0D0 Offset: 0x20A96D0 VA: 0x1820AB0D0
	public static ClientReady DeserializeLengthDelimited(Stream stream, ClientReady instance, bool isDelta) { }

	// RVA: 0x20AB430 Offset: 0x20A9A30 VA: 0x1820AB430
	public static ClientReady DeserializeLength(Stream stream, int length, ClientReady instance, bool isDelta) { }

	// RVA: 0x20AC140 Offset: 0x20AA740 VA: 0x1820AC140
	public static void SerializeDelta(Stream stream, ClientReady instance, ClientReady previous) { }

	// RVA: 0x20AC4E0 Offset: 0x20AAAE0 VA: 0x1820AC4E0
	public static void Serialize(Stream stream, ClientReady instance) { }

	// RVA: 0x20AC6C0 Offset: 0x20AACC0 VA: 0x1820AC6C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AC6D0 Offset: 0x20AACD0 VA: 0x1820AC6D0
	public void ToProto(Stream stream) { }

	// RVA: 0x20AC3D0 Offset: 0x20AA9D0 VA: 0x1820AC3D0
	public static byte[] SerializeToBytes(ClientReady instance) { }

	// RVA: 0x20AC320 Offset: 0x20AA920 VA: 0x1820AC320
	public static void SerializeLengthDelimited(Stream stream, ClientReady instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ClientReady.ClientInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6495
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public string value; // 0x20

	// Methods

	// RVA: 0x20AA6B0 Offset: 0x20A8CB0 VA: 0x1820AA6B0
	public static void ResetToPool(ClientReady.ClientInfo instance) { }

	// RVA: 0x20AA770 Offset: 0x20A8D70 VA: 0x1820AA770
	public void ResetToPool() { }

	// RVA: 0x20AA5F0 Offset: 0x20A8BF0 VA: 0x1820AA5F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A9B10 Offset: 0x20A8110 VA: 0x1820A9B10
	public void CopyTo(ClientReady.ClientInfo instance) { }

	// RVA: 0x20A9B60 Offset: 0x20A8160 VA: 0x1820A9B60
	public ClientReady.ClientInfo Copy() { }

	// RVA: 0x20AA570 Offset: 0x20A8B70 VA: 0x1820AA570
	public static ClientReady.ClientInfo Deserialize(Stream stream) { }

	// RVA: 0x20A9BF0 Offset: 0x20A81F0 VA: 0x1820A9BF0
	public static ClientReady.ClientInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A9EE0 Offset: 0x20A84E0 VA: 0x1820A9EE0
	public static ClientReady.ClientInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AA350 Offset: 0x20A8950 VA: 0x1820AA350
	public static ClientReady.ClientInfo Deserialize(byte[] buffer) { }

	// RVA: 0x20AA670 Offset: 0x20A8C70 VA: 0x1820AA670
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AADE0 Offset: 0x20A93E0 VA: 0x1820AADE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AAE00 Offset: 0x20A9400 VA: 0x1820AAE00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ClientReady.ClientInfo previous) { }

	// RVA: 0x20AA690 Offset: 0x20A8C90 VA: 0x1820AA690 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AA470 Offset: 0x20A8A70 VA: 0x1820AA470
	public static ClientReady.ClientInfo Deserialize(byte[] buffer, ClientReady.ClientInfo instance, bool isDelta = False) { }

	// RVA: 0x20AA1C0 Offset: 0x20A87C0 VA: 0x1820AA1C0
	public static ClientReady.ClientInfo Deserialize(Stream stream, ClientReady.ClientInfo instance, bool isDelta) { }

	// RVA: 0x20A9C70 Offset: 0x20A8270 VA: 0x1820A9C70
	public static ClientReady.ClientInfo DeserializeLengthDelimited(Stream stream, ClientReady.ClientInfo instance, bool isDelta) { }

	// RVA: 0x20A9F70 Offset: 0x20A8570 VA: 0x1820A9F70
	public static ClientReady.ClientInfo DeserializeLength(Stream stream, int length, ClientReady.ClientInfo instance, bool isDelta) { }

	// RVA: 0x20AA830 Offset: 0x20A8E30 VA: 0x1820AA830
	public static void SerializeDelta(Stream stream, ClientReady.ClientInfo instance, ClientReady.ClientInfo previous) { }

	// RVA: 0x20AAC00 Offset: 0x20A9200 VA: 0x1820AAC00
	public static void Serialize(Stream stream, ClientReady.ClientInfo instance) { }

	// RVA: 0x20AADD0 Offset: 0x20A93D0 VA: 0x1820AADD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AADE0 Offset: 0x20A93E0 VA: 0x1820AADE0
	public void ToProto(Stream stream) { }

	// RVA: 0x20AAAF0 Offset: 0x20A90F0 VA: 0x1820AAAF0
	public static byte[] SerializeToBytes(ClientReady.ClientInfo instance) { }

	// RVA: 0x20AAA40 Offset: 0x20A9040 VA: 0x1820AAA40
	public static void SerializeLengthDelimited(Stream stream, ClientReady.ClientInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class Client : BaseNetwork // TypeDefIndex: 6687
{	// Fields
	public static float MaxReceiveTime; // 0x0
	public static float MinReceiveFraction; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Connection <Connection>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <IsPlaying>k__BackingField; // 0x30
	public Manager visibility; // 0x38
	public static string disconnectReason; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <ConnectedAddress>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ConnectedPort>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <ServerName>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsOfficialServer>k__BackingField; // 0x58
	public Stats IncomingStats; // 0x60
	public IClientCallback callbackHandler; // 0x68

	// Properties
	public Connection Connection { get; set; }
	public virtual bool IsPlaying { get; }
	public string ConnectedAddress { get; set; }
	public int ConnectedPort { get; set; }
	public string ServerName { get; set; }
	public bool IsOfficialServer { get; set; }
	public bool IsRecording { get; }
	public string RecordFilename { get; }
	public TimeSpan RecordTimeElapsed { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public Connection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	protected void set_Connection(Connection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0 Slot: 7
	public virtual bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_ConnectedAddress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_ConnectedAddress(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public int get_ConnectedPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	public void set_ConnectedPort(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_ServerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_ServerName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_IsOfficialServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	public void set_IsOfficialServer(bool value) { }

	// RVA: 0x220D260 Offset: 0x220B860 VA: 0x18220D260 Slot: 8
	public virtual bool Connect(string strURL, int port) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void Cycle() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void Disconnect(string reason, bool sendReasonToServer = True) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public virtual bool IsConnected() { }

	// RVA: 0x220D410 Offset: 0x220BA10 VA: 0x18220D410
	protected void OnDisconnected(string str) { }

	// RVA: 0x220D2D0 Offset: 0x220B8D0 VA: 0x18220D2D0
	public Networkable CreateNetworkable(uint networkID, uint networkGroup) { }

	// RVA: 0x220D380 Offset: 0x220B980 VA: 0x18220D380
	public void DestroyNetworkable(ref Networkable networkable) { }

	// RVA: 0x220D4D0 Offset: 0x220BAD0 VA: 0x18220D4D0
	public void SetupNetworkable(Networkable net) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 12
	public virtual int GetLastPing() { }

	// RVA: 0x220D800 Offset: 0x220BE00 VA: 0x18220D800
	public bool get_IsRecording() { }

	// RVA: 0xFA0EB0 Offset: 0xF9F4B0 VA: 0x180FA0EB0
	public string get_RecordFilename() { }

	// RVA: 0x220D820 Offset: 0x220BE20 VA: 0x18220D820
	public TimeSpan get_RecordTimeElapsed() { }

	// RVA: 0x220D500 Offset: 0x220BB00 VA: 0x18220D500
	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	// RVA: 0x220D620 Offset: 0x220BC20 VA: 0x18220D620
	public void StopRecording() { }

	// RVA: 0x220D690 Offset: 0x220BC90 VA: 0x18220D690
	public void .ctor() { }

	// RVA: 0x220D640 Offset: 0x220BC40 VA: 0x18220D640
	private static void .cctor() { }

}

public class ClientVar : ConsoleVar // TypeDefIndex: 6894
{	// Methods

	// RVA: 0x22B2150 Offset: 0x22B0750 VA: 0x1822B2150
	public void .ctor() { }

}

public enum ClientIntegrityViolationType // TypeDefIndex: 7140
{	// Fields
	public int value__; // 0x0
	public const ClientIntegrityViolationType IntegrityViolationNone = 0;
	public const ClientIntegrityViolationType EACHashCatalogueFileNotFound = 1;
	public const ClientIntegrityViolationType EACHashCatalogueError = 2;
	public const ClientIntegrityViolationType EACHashCatalogueCertificateRevoked = 3;
	public const ClientIntegrityViolationType UnknownGameFileVersion = 4;
	public const ClientIntegrityViolationType RequiredGameFileNotFound = 5;
	public const ClientIntegrityViolationType UncataloguedGameFileForbidden = 6;
	public const ClientIntegrityViolationType UnknownSystemFileVersion = 7;
	public const ClientIntegrityViolationType ForbiddenModuleLoaded = 8;
	public const ClientIntegrityViolationType CorruptedMemory = 9;
	public const ClientIntegrityViolationType HackToolDetected = 10;
	public const ClientIntegrityViolationType InternalAntiCheatViolation = 11;
	public const ClientIntegrityViolationType CorruptedNetworkMessageFlow = 12;
	public const ClientIntegrityViolationType CannotRunUnderVirtualMachine = 13;
	public const ClientIntegrityViolationType ForbiddenSystemConfiguration = 14;

}

public class Client : Client // TypeDefIndex: 7331
{	// Fields
	private Peer peer; // 0x70
	public static byte[] ReusableBytes; // 0x0
	private Stopwatch cycleTimer; // 0x78

	// Methods

	// RVA: 0x22CC890 Offset: 0x22CAE90 VA: 0x1822CC890 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x22CB580 Offset: 0x22C9B80 VA: 0x1822CB580 Slot: 8
	public override bool Connect(string strURL, int port) { }

	// RVA: 0x22CC310 Offset: 0x22CA910 VA: 0x1822CC310
	internal bool HandleRaknetPacket(byte type) { }

	// RVA: 0x22CBCF0 Offset: 0x22CA2F0 VA: 0x1822CBCF0
	protected void HandleMessage() { }

	// RVA: 0x22CB690 Offset: 0x22C9C90 VA: 0x1822CB690 Slot: 9
	public override void Cycle() { }

	// RVA: 0x22CBAB0 Offset: 0x22CA0B0 VA: 0x1822CBAB0 Slot: 10
	public override void Disconnect(string reason, bool sendReasonToServer) { }

	// RVA: 0x22CBC10 Offset: 0x22CA210 VA: 0x1822CBC10 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22CBCD0 Offset: 0x22CA2D0 VA: 0x1822CBCD0 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22CBC90 Offset: 0x22CA290 VA: 0x1822CBC90 Slot: 12
	public override int GetLastPing() { }

	// RVA: 0x22CC8A0 Offset: 0x22CAEA0 VA: 0x1822CC8A0 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22CCA40 Offset: 0x22CB040 VA: 0x1822CCA40
	public void .ctor() { }

	// RVA: 0x22CC9F0 Offset: 0x22CAFF0 VA: 0x1822CC9F0
	private static void .cctor() { }

}

public class ClientIOLine : BaseMonoBehaviour // TypeDefIndex: 8884
{	// Fields
	public RendererLOD _lod; // 0x18
	public LineRenderer _line; // 0x20
	public Material directionalMaterial; // 0x28
	public Material defaultMaterial; // 0x30
	public IOEntity.IOType lineType; // 0x38
	public static List<ClientIOLine> _allLines; // 0x0
	public WireTool.WireColour colour; // 0x3C
	public IOEntity ownerIOEnt; // 0x40

	// Properties
	public int PositionCount { get; }

	// Methods

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void SetIOEntityOwner(IOEntity newOwner) { }

	// RVA: 0x570520 Offset: 0x56EB20 VA: 0x180570520
	public void OnEnable() { }

	// RVA: 0x570490 Offset: 0x56EA90 VA: 0x180570490
	public void OnDisable() { }

	// RVA: 0x570620 Offset: 0x56EC20 VA: 0x180570620
	public static void SetDirectionVisibleAll(bool isVisible, IOEntity.IOType forType) { }

	// RVA: 0x570780 Offset: 0x56ED80 VA: 0x180570780
	public static void SetDirectionVisibleSingle(bool isVisible, ClientIOLine line) { }

	// RVA: 0x56FF60 Offset: 0x56E560 VA: 0x18056FF60
	public void Clear() { }

	// RVA: 0x56FF90 Offset: 0x56E590 VA: 0x18056FF90
	public void DelayedDirectionTest() { }

	// RVA: 0x570900 Offset: 0x56EF00 VA: 0x180570900
	public void SetDirectionVisible(bool isVisible) { }

	// RVA: 0x570B90 Offset: 0x56F190 VA: 0x180570B90
	public void SetVisible(bool isVisible) { }

	// RVA: 0x570AB0 Offset: 0x56F0B0 VA: 0x180570AB0
	public void SetLineCullDistance(float length) { }

	// RVA: 0x570B00 Offset: 0x56F100 VA: 0x180570B00
	public void SetPositions(Vector3[] positions, float[] slackLevels) { }

	// RVA: 0x56FE70 Offset: 0x56E470 VA: 0x18056FE70
	public void AddPosition(Vector3 worldPos) { }

	// RVA: 0x5709E0 Offset: 0x56EFE0 VA: 0x1805709E0
	public void SetLastNodePosition(Vector3 worldPos) { }

	// RVA: 0x5705B0 Offset: 0x56EBB0 VA: 0x1805705B0
	public void RemoveLastPosition() { }

	// RVA: 0x5702E0 Offset: 0x56E8E0 VA: 0x1805702E0
	public float GetLength() { }

	// RVA: 0x570C40 Offset: 0x56F240 VA: 0x180570C40
	public void UpdateBoundsAndPosition() { }

	// RVA: 0x5701D0 Offset: 0x56E7D0 VA: 0x1805701D0
	public Vector3 GetLastPlacedNodePosition() { }

	// RVA: 0x570CC0 Offset: 0x56F2C0 VA: 0x180570CC0
	public int get_PositionCount() { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

	// RVA: 0x570C60 Offset: 0x56F260 VA: 0x180570C60
	private static void .cctor() { }

}

public class Client : SingletonComponent<Client>, IClientCallback // TypeDefIndex: 9144
{	// Fields
	public static Translate.Phrase loading_loading; // 0x0
	public static Translate.Phrase loading_connecting; // 0x8
	public static Translate.Phrase loading_connectionaccepted; // 0x10
	public static Translate.Phrase loading_connecting_negotiate; // 0x18
	public static Translate.Phrase loading_level; // 0x20
	public static Translate.Phrase loading_skinnablewarmup; // 0x28
	public static Translate.Phrase loading_preloadcomplete; // 0x30
	public static Translate.Phrase loading_openingscene; // 0x38
	public static Translate.Phrase loading_clientready; // 0x40
	public static Translate.Phrase loading_prefabwarmup; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnConnected; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnDisconnected; // 0x58
	private IAuthTicket authTicket; // 0x18
	private IEnumerator currentCoroutine; // 0x20
	private bool connectionRetry; // 0x28
	private static Client.ConnectionProtocol[] config_raknet; // 0x60
	private static Client.ConnectionProtocol[] config_steamworks; // 0x68
	private static Client.ConnectionProtocol[] config_default; // 0x70
	private static Mesh _cubeMesh; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <IsScrubbingDemo>k__BackingField; // 0x80
	public static ulong DemoLocalClient; // 0x88
	private static Reader Demo; // 0x90
	private static float PreDemoPhysicsSteps; // 0x98
	private const float demoTickDistSq = 2500;
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static BasePlayer <DemoSpectatePlayer>k__BackingField; // 0xA0
	public static BaseEntity CurrentEntity; // 0xA8
	public HashSet<uint> subscriptions; // 0x30
	private const long EntityPositionPacketSize = 36;
	private const long EntityFlagsPacketSize = 8;
	private static EventSystem _eventsystem; // 0xB0
	private float LastConfigSaveTime; // 0x38
	private Stopwatch ngTimer; // 0x40

	// Properties
	private bool StatsEnabled { get; }
	public static bool IsPlayingDemo { get; }
	public static bool IsRecordingDemo { get; }
	public static bool IsScrubbingDemo { get; set; }
	public static TimeSpan RecordingTimeElapsed { get; }
	public static string RecordingFilename { get; }
	public static BasePlayer DemoLocalPlayer { get; }
	public static TimeSpan DemoProgress { get; }
	public static TimeSpan DemoLength { get; }
	public static float DemoNormalizedTime { get; }
	public static string DemoName { get; }
	public static DateTime DemoRecordedTime { get; }
	public static BasePlayer DemoSpectatePlayer { get; set; }
	public static EventSystem EventSystem { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x545F50 Offset: 0x544550 VA: 0x180545F50
	public static void add_OnConnected(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x546960 Offset: 0x544F60 VA: 0x180546960
	public static void remove_OnConnected(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x546050 Offset: 0x544650 VA: 0x180546050
	public static void add_OnDisconnected(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x546A60 Offset: 0x545060 VA: 0x180546A60
	public static void remove_OnDisconnected(Action value) { }

	// RVA: 0x5468A0 Offset: 0x544EA0 VA: 0x1805468A0
	private bool get_StatsEnabled() { }

	// RVA: 0x5439F0 Offset: 0x541FF0 VA: 0x1805439F0
	private void RegisterIncoming(string type, long bytes) { }

	// RVA: 0x543B30 Offset: 0x542130 VA: 0x180543B30
	private void RegisterIncoming(string type, string entity, long bytes) { }

	// RVA: 0x542010 Offset: 0x540610 VA: 0x180542010 Slot: 8
	public void OnNetworkMessage(Message packet) { }

	// RVA: 0x541ED0 Offset: 0x5404D0 VA: 0x180541ED0
	private void OnMessage(Message packet) { }

	// RVA: 0x543360 Offset: 0x541960 VA: 0x180543360
	private void OnRequestUserInformation(Message packet) { }

	// RVA: 0x53F820 Offset: 0x53DE20 VA: 0x18053F820
	private void OnApproved(Message packet) { }

	// RVA: 0x542FD0 Offset: 0x5415D0 VA: 0x180542FD0
	private void OnRPCMessage(Message packet) { }

	// RVA: 0x53EE70 Offset: 0x53D470 VA: 0x18053EE70
	private string GetOSName() { }

	// RVA: 0x53BE70 Offset: 0x53A470 VA: 0x18053BE70
	public void CancelAuthTicket() { }

	// RVA: 0x53ECA0 Offset: 0x53D2A0 VA: 0x18053ECA0
	public IAuthTicket GetAuthTicket(bool cancelOld = True) { }

	// RVA: 0x53BF30 Offset: 0x53A530 VA: 0x18053BF30
	private void CancelLoading() { }

	// RVA: 0x544420 Offset: 0x542A20 VA: 0x180544420
	private Coroutine StartLoading(IEnumerator coroutine) { }

	[AsyncStateMachineAttribute] // RVA: 0xD2320 Offset: 0xD1720 VA: 0x1800D2320
	// RVA: 0x53C1D0 Offset: 0x53A7D0 VA: 0x18053C1D0
	public Task Connect(string strAddress, int port, string protocol, bool hideIpAddress = False) { }

	// RVA: 0x53E250 Offset: 0x53C850 VA: 0x18053E250
	private void DestroyNetworkables() { }

	[IteratorStateMachineAttribute] // RVA: 0xD24A0 Offset: 0xD18A0 VA: 0x1800D24A0
	// RVA: 0x53E470 Offset: 0x53CA70 VA: 0x18053E470
	private IEnumerator DoClientConnected(Approval msg) { }

	// RVA: 0x53FA50 Offset: 0x53E050 VA: 0x18053FA50 Slot: 9
	public void OnClientDisconnected(string strReason) { }

	// RVA: 0x53BFE0 Offset: 0x53A5E0 VA: 0x18053BFE0
	public static void ClientCleanup() { }

	// RVA: 0x53FC90 Offset: 0x53E290 VA: 0x18053FC90
	private static void OnConsoleReplicatedVars(Message packet) { }

	// RVA: 0x5440E0 Offset: 0x5426E0 VA: 0x1805440E0
	private static void SetReplicatedVar(string fullName, string value) { }

	// RVA: 0x543D30 Offset: 0x542330 VA: 0x180543D30
	private void RunDebugCommands() { }

	// RVA: 0x53E500 Offset: 0x53CB00 VA: 0x18053E500
	private void DrawColliders() { }

	// RVA: 0x544F00 Offset: 0x543500 VA: 0x180544F00
	private void UpdateNetgraph() { }

	// RVA: 0x53ED50 Offset: 0x53D350 VA: 0x18053ED50
	private Stats GetCurrentNetworkStats() { }

	// RVA: 0x546700 Offset: 0x544D00 VA: 0x180546700
	public static bool get_IsPlayingDemo() { }

	// RVA: 0x546750 Offset: 0x544D50 VA: 0x180546750
	public static bool get_IsRecordingDemo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5467A0 Offset: 0x544DA0 VA: 0x1805467A0
	public static bool get_IsScrubbingDemo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x546C40 Offset: 0x545240 VA: 0x180546C40
	public static void set_IsScrubbingDemo(bool value) { }

	// RVA: 0x546850 Offset: 0x544E50 VA: 0x180546850
	public static TimeSpan get_RecordingTimeElapsed() { }

	// RVA: 0x546800 Offset: 0x544E00 VA: 0x180546800
	public static string get_RecordingFilename() { }

	// RVA: 0x5461D0 Offset: 0x5447D0 VA: 0x1805461D0
	public static BasePlayer get_DemoLocalPlayer() { }

	// RVA: 0x546390 Offset: 0x544990 VA: 0x180546390
	public static TimeSpan get_DemoProgress() { }

	// RVA: 0x546150 Offset: 0x544750 VA: 0x180546150
	public static TimeSpan get_DemoLength() { }

	// RVA: 0x5462D0 Offset: 0x5448D0 VA: 0x1805462D0
	public static float get_DemoNormalizedTime() { }

	// RVA: 0x546260 Offset: 0x544860 VA: 0x180546260
	public static string get_DemoName() { }

	// RVA: 0x546430 Offset: 0x544A30 VA: 0x180546430
	public static DateTime get_DemoRecordedTime() { }

	// RVA: 0x544500 Offset: 0x542B00 VA: 0x180544500
	public void StartPlayingDemo(Reader demo, bool inPlace) { }

	[IteratorStateMachineAttribute] // RVA: 0xD2850 Offset: 0xD1C50 VA: 0x1800D2850
	// RVA: 0x544460 Offset: 0x542A60 VA: 0x180544460
	private IEnumerator StartPlayingDemoInternal(Reader demo, bool inPlace) { }

	// RVA: 0x53FDA0 Offset: 0x53E3A0 VA: 0x18053FDA0
	private void OnDemoKeyframe(Indexer.Keyframe keyframe, HashSet<uint> changedEnts) { }

	// RVA: 0x5448B0 Offset: 0x542EB0 VA: 0x1805448B0
	public void StopRecordingDemo() { }

	// RVA: 0x5445B0 Offset: 0x542BB0 VA: 0x1805445B0
	public void StopPlayingDemo(bool finished = False) { }

	// RVA: 0x53D490 Offset: 0x53BA90 VA: 0x18053D490
	private void DemoFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5464E0 Offset: 0x544AE0 VA: 0x1805464E0
	public static BasePlayer get_DemoSpectatePlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x546B60 Offset: 0x545160 VA: 0x180546B60
	private static void set_DemoSpectatePlayer(BasePlayer value) { }

	// RVA: 0x53E0A0 Offset: 0x53C6A0 VA: 0x18053E0A0
	private void DemoSpectateNextPlayer(bool forward) { }

	// RVA: 0x53D9E0 Offset: 0x53BFE0 VA: 0x18053D9E0
	private void DemoLateUpdate(bool isLastCall) { }

	// RVA: 0x53DF10 Offset: 0x53C510 VA: 0x18053DF10
	private void DemoPlayerTick(PlayerTick playerTick) { }

	// RVA: 0x541950 Offset: 0x53FF50 VA: 0x180541950
	private void OnGroupEnter(Message msg) { }

	// RVA: 0x541A50 Offset: 0x540050 VA: 0x180541A50
	private void OnGroupLeave(Message msg) { }

	// RVA: 0x540B70 Offset: 0x53F170 VA: 0x180540B70
	private void OnEntityDestroy(Message msg) { }

	// RVA: 0x5416F0 Offset: 0x53FCF0 VA: 0x1805416F0
	private void OnGroupDestroy(Message msg) { }

	// RVA: 0x540F50 Offset: 0x53F550 VA: 0x180540F50
	private void OnGroupChange(Message msg) { }

	// RVA: 0x540880 Offset: 0x53EE80 VA: 0x180540880
	private void OnEntities(Message packet) { }

	// RVA: 0x53C310 Offset: 0x53A910 VA: 0x18053C310
	private BaseEntity CreateOrUpdateEntity(Entity info, long size) { }

	// RVA: 0x540DD0 Offset: 0x53F3D0 VA: 0x180540DD0
	private void OnEntityPosition(Message packet) { }

	// RVA: 0x544C80 Offset: 0x543280 VA: 0x180544C80
	private void UpdateEntityPosition(uint entID, Vector3 pos, Vector3 rot, float time, uint parentID) { }

	// RVA: 0x540D50 Offset: 0x53F350 VA: 0x180540D50
	private void OnEntityFlags(Message packet) { }

	// RVA: 0x544A00 Offset: 0x543000 VA: 0x180544A00
	private void UpdateEntityFlags(uint entID, int flags) { }

	// RVA: 0x5465A0 Offset: 0x544BA0 VA: 0x1805465A0
	public static EventSystem get_EventSystem() { }

	// RVA: 0x53BF70 Offset: 0x53A570 VA: 0x18053BF70
	private void ClearVisibility() { }

	// RVA: 0x53F570 Offset: 0x53DB70 VA: 0x18053F570
	private void NetworkInit() { }

	// RVA: 0x545260 Offset: 0x543860 VA: 0x180545260
	private void Update() { }

	// RVA: 0x53EED0 Offset: 0x53D4D0 VA: 0x18053EED0
	private void LateUpdate() { }

	// RVA: 0x53E390 Offset: 0x53C990 VA: 0x18053E390
	private void Disconnect() { }

	// RVA: 0x540810 Offset: 0x53EE10 VA: 0x180540810
	private void OnDisable() { }

	// RVA: 0x53F750 Offset: 0x53DD50 VA: 0x18053F750
	private void OnApplicationQuit() { }

	// RVA: 0x541B50 Offset: 0x540150 VA: 0x180541B50
	private void OnLeaveServer() { }

	// RVA: 0x543F50 Offset: 0x542550 VA: 0x180543F50
	private void SaveConfigs(bool force = False) { }

	// RVA: 0x53EE00 Offset: 0x53D400 VA: 0x18053EE00
	private static extern uint GetCurrentProcessId() { }

	// RVA: 0x543960 Offset: 0x541F60 VA: 0x180543960
	private static extern IntPtr OpenProcess(Client.ProcessAccessFlags processAccess, bool bInheritHandle, uint processId) { }

	// RVA: 0x544970 Offset: 0x542F70 VA: 0x180544970
	private static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode) { }

	// RVA: 0x5441E0 Offset: 0x5427E0 VA: 0x1805441E0
	private void ShutdownClient() { }

	// RVA: 0x545E90 Offset: 0x544490 VA: 0x180545E90
	public void .ctor() { }

	// RVA: 0x545AA0 Offset: 0x5440A0 VA: 0x180545AA0
	private static void .cctor() { }

}

private enum Client.ConnectionProtocol // TypeDefIndex: 9145
{	// Fields
	public int value__; // 0x0
	public const Client.ConnectionProtocol Raknet = 0;
	public const Client.ConnectionProtocol Steamworks = 1;

}

public enum Client.ProcessAccessFlags // TypeDefIndex: 9146
{	// Fields
	public uint value__; // 0x0
	public const Client.ProcessAccessFlags Terminate = 1;
	public const Client.ProcessAccessFlags Synchronize = 1048576;

}

private struct Client.<Connect>d__37 : IAsyncStateMachine // TypeDefIndex: 9147
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Client <>4__this; // 0x20
	public string strAddress; // 0x28
	public bool hideIpAddress; // 0x30
	public int port; // 0x34
	public string protocol; // 0x38
	private Client.ConnectionProtocol[] <configs>5__2; // 0x40
	private TaskAwaiter <>u__1; // 0x48
	private int <i>5__3; // 0x50

	// Methods

	// RVA: 0xF2CF0 Offset: 0xF20F0 VA: 0x1800F2CF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class Client.<>c // TypeDefIndex: 9148
{	// Fields
	public static readonly Client.<>c <>9; // 0x0
	public static Func<ConsoleSystem.Command, bool> <>9__39_0; // 0x8

	// Methods

	// RVA: 0x589D80 Offset: 0x588380 VA: 0x180589D80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589A00 Offset: 0x588000 VA: 0x180589A00
	internal bool <DoClientConnected>b__39_0(ConsoleSystem.Command x) { }

}

private sealed class Client.<DoClientConnected>d__39 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9149
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Approval msg; // 0x20
	public Client <>4__this; // 0x28
	private BenchmarkTimer <>7__wrap1; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x586DA0 Offset: 0x5853A0 VA: 0x180586DA0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x585770 Offset: 0x583D70 VA: 0x180585770 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x586E50 Offset: 0x585450 VA: 0x180586E50
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x586D50 Offset: 0x585350 VA: 0x180586D50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Client.<StartPlayingDemoInternal>d__78 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9150
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Reader demo; // 0x20
	public Client <>4__this; // 0x28
	public bool inPlace; // 0x30
	private BenchmarkTimer <>7__wrap1; // 0x38
	private BenchmarkTimer <>7__wrap2; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x589630 Offset: 0x587C30 VA: 0x180589630 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x588210 Offset: 0x586810 VA: 0x180588210 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x589810 Offset: 0x587E10 VA: 0x180589810
	private void <>m__Finally1() { }

	// RVA: 0x589860 Offset: 0x587E60 VA: 0x180589860
	private void <>m__Finally2() { }

	// RVA: 0x5898B0 Offset: 0x587EB0 VA: 0x1805898B0
	private void <>m__Finally3() { }

	// RVA: 0x589900 Offset: 0x587F00 VA: 0x180589900
	private void <>m__Finally4() { }

	// RVA: 0x589950 Offset: 0x587F50 VA: 0x180589950
	private void <>m__Finally5() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5895E0 Offset: 0x587BE0 VA: 0x1805895E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public struct ClientPerformanceReport // TypeDefIndex: 9293
{	// Fields
	public int request_id; // 0x0
	public string user_id; // 0x8
	public float fps_average; // 0x10
	public int fps; // 0x14
	public int frame_id; // 0x18
	public float frame_time; // 0x1C
	public float frame_time_average; // 0x20
	public long memory_system; // 0x28
	public long memory_collections; // 0x30
	public long memory_managed_heap; // 0x38
	public float realtime_since_startup; // 0x40
	public bool streamer_mode; // 0x44
	public int ping; // 0x48
	public int tasks_invokes; // 0x4C
	public int tasks_load_balancer; // 0x50
	public int workshop_skins_queued; // 0x54

}

public class ClientFrametimeReport // TypeDefIndex: 9307
{	// Fields
	public int request_id; // 0x10
	public int start_frame; // 0x14
	public List<int> frame_times; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class ClientFrametimeRequest // TypeDefIndex: 9308
{	// Fields
	public int request_id; // 0x10
	public int start_frame; // 0x14
	public int max_frames; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class ClientBuildingManager : BuildingManager // TypeDefIndex: 9828
{	// Methods

	// RVA: 0x56FC90 Offset: 0x56E290 VA: 0x18056FC90
	public void Cycle() { }

	// RVA: 0x56FC20 Offset: 0x56E220 VA: 0x18056FC20 Slot: 4
	protected override BuildingManager.Building CreateBuilding(uint id) { }

	// RVA: 0x56FDB0 Offset: 0x56E3B0 VA: 0x18056FDB0 Slot: 5
	protected override void DisposeBuilding(ref BuildingManager.Building building) { }

	// RVA: 0x56FE10 Offset: 0x56E410 VA: 0x18056FE10
	public void .ctor() { }

}

public static class Client // TypeDefIndex: 11650
{	// Fields
	public const byte Default = 0;
	public const byte Tick = 1;

}

public class Client : ConsoleSystem // TypeDefIndex: 11892
{	// Fields
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int maxpeerspersecond; // 0x0
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int maxpacketspersecond_effect; // 0x4
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int maxpacketspersecond_voice; // 0x8
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool prediction; // 0xC
	[ClientVar] // RVA: 0x8D9D0 Offset: 0x8CDD0 VA: 0x18008D9D0
	public static int maxunack; // 0x10
	[ClientVar] // RVA: 0x8DB40 Offset: 0x8CF40 VA: 0x18008DB40
	public static bool pushtotalk; // 0x14
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debugdragdrop; // 0x15
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debuglootsounds; // 0x16
	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static float headlerp; // 0x18
	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static bool headlerp_inertia; // 0x1C
	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static float camlerp; // 0x20
	[ClientVar] // RVA: 0x8DFC0 Offset: 0x8D3C0 VA: 0x18008DFC0
	public static bool camlerptilt; // 0x24
	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static float camzoomlerp; // 0x28
	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static float camspeed; // 0x2C
	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static float camzoomspeed; // 0x30
	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static float camlookspeed; // 0x34
	[ClientVar] // RVA: 0x8E5B0 Offset: 0x8D9B0 VA: 0x18008E5B0
	public static float camdist; // 0x38
	[ClientVar] // RVA: 0x8E5B0 Offset: 0x8D9B0 VA: 0x18008E5B0
	public static string cambone; // 0x40
	[ClientVar] // RVA: 0x8E5B0 Offset: 0x8D9B0 VA: 0x18008E5B0
	public static float camfov; // 0x48
	[ClientVar] // RVA: 0x8E5B0 Offset: 0x8D9B0 VA: 0x18008E5B0
	public static Vector3 camoffset; // 0x4C
	[ClientVar] // RVA: 0x8E5B0 Offset: 0x8D9B0 VA: 0x18008E5B0
	public static bool camoffset_relative; // 0x58
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool sortSkinsRecentlyUsed; // 0x59
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool headbob; // 0x5A
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool crosshair; // 0x5B
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool hitcross; // 0x5C
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool hurtpunch; // 0x5D
	private static bool hasAppliedPhysicalCameraDefaults; // 0x5E
	public static Vector2[] CameraSensorSize; // 0x60
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static bool showCamInfo; // 0x68
	[ClientVar] // RVA: 0x8EBA0 Offset: 0x8DFA0 VA: 0x18008EBA0
	public static float lookatradius; // 0x6C
	[ClientVar] // RVA: 0x8ECF0 Offset: 0x8E0F0 VA: 0x18008ECF0
	public static int RockSkin; // 0x70
	[ClientVar] // RVA: 0x8ECF0 Offset: 0x8E0F0 VA: 0x18008ECF0
	public static int UnderwearSkin; // 0x74

	// Properties
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float maxreceivetime { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float minreceivefraction { get; set; }
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static bool camPhysical { get; set; }
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static int camPhysicalSensor { get; set; }
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static float camPhysicalFocalLength { get; set; }

	// Methods

	// RVA: 0x6D0230 Offset: 0x6CE830 VA: 0x1806D0230
	public static float get_maxreceivetime() { }

	// RVA: 0x6D17F0 Offset: 0x6CFDF0 VA: 0x1806D17F0
	public static void set_maxreceivetime(float value) { }

	// RVA: 0x6D0290 Offset: 0x6CE890 VA: 0x1806D0290
	public static float get_minreceivefraction() { }

	// RVA: 0x6D18B0 Offset: 0x6CFEB0 VA: 0x1806D18B0
	public static void set_minreceivefraction(float value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CF810 Offset: 0x6CDE10 VA: 0x1806CF810
	public static string connect(string address = "127.0.0.1:28015", string protocol = "", bool hideIpAddress = False) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CFAD0 Offset: 0x6CE0D0 VA: 0x1806CFAD0
	public static string connecthidden(string address = "127.0.0.1:28015", string protocol = "") { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CFE10 Offset: 0x6CE410 VA: 0x1806CFE10
	public static string fps() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CFBB0 Offset: 0x6CE1B0 VA: 0x1806CFBB0
	public static string disconnect() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D0950 Offset: 0x6CEF50 VA: 0x1806D0950
	public static void report() { }

	[ClientVar] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	// RVA: 0x6D06F0 Offset: 0x6CECF0 VA: 0x1806D06F0
	public static string printpos() { }

	[ClientVar] // RVA: 0x8F4C0 Offset: 0x8E8C0 VA: 0x18008F4C0
	// RVA: 0x6D0810 Offset: 0x6CEE10 VA: 0x1806D0810
	public static string printrot() { }

	[ClientVar] // RVA: 0x8F7A0 Offset: 0x8EBA0 VA: 0x18008F7A0
	// RVA: 0x6D0390 Offset: 0x6CE990 VA: 0x1806D0390
	public static string printeyes() { }

	[ClientVar] // RVA: 0x8F820 Offset: 0x8EC20 VA: 0x18008F820
	// RVA: 0x6D05E0 Offset: 0x6CEBE0 VA: 0x1806D05E0
	public static string printinput() { }

	[ClientVar] // RVA: 0x8F9B0 Offset: 0x8EDB0 VA: 0x18008F9B0
	// RVA: 0x6D04D0 Offset: 0x6CEAD0 VA: 0x1806D04D0
	public static string printhead() { }

	// RVA: 0x6CE590 Offset: 0x6CCB90 VA: 0x1806CE590
	public static string GetClientFolder(string folder) { }

	// RVA: 0x6D0150 Offset: 0x6CE750 VA: 0x1806D0150
	public static bool get_camPhysical() { }

	// RVA: 0x6D1350 Offset: 0x6CF950 VA: 0x1806D1350
	public static void set_camPhysical(bool value) { }

	// RVA: 0x6CFF60 Offset: 0x6CE560 VA: 0x1806CFF60
	public static int get_camPhysicalSensor() { }

	// RVA: 0x6D11B0 Offset: 0x6CF7B0 VA: 0x1806D11B0
	public static void set_camPhysicalSensor(int value) { }

	// RVA: 0x6CFE80 Offset: 0x6CE480 VA: 0x1806CFE80
	public static float get_camPhysicalFocalLength() { }

	// RVA: 0x6D10D0 Offset: 0x6CF6D0 VA: 0x1806D10D0
	public static void set_camPhysicalFocalLength(float value) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6CF6A0 Offset: 0x6CDCA0 VA: 0x1806CF6A0
	public static void camPhysicalSensorTypes(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x6D1C20 Offset: 0x6D0220 VA: 0x1806D1C20
	public static void sv(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CFB40 Offset: 0x6CE140 VA: 0x1806CFB40
	public static void consoletoggle() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D02F0 Offset: 0x6CE8F0 VA: 0x1806D02F0
	public static int ping() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CF560 Offset: 0x6CDB60 VA: 0x1806CF560
	public static void benchmark(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CF410 Offset: 0x6CDA10 VA: 0x1806CF410
	public static void benchmark_demo(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D1970 Offset: 0x6CFF70 VA: 0x1806D1970
	public static void setunderwear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE5C0 Offset: 0x6CCBC0 VA: 0x1806CE5C0
	public static void PlayerSeed(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CEA60 Offset: 0x6CD060 VA: 0x1806CEA60
	public static void ShufflePlayerSeed(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE970 Offset: 0x6CCF70 VA: 0x1806CE970
	public static void ReportPlayer(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE8B0 Offset: 0x6CCEB0 VA: 0x1806CE8B0
	public static void ReportBug(ConsoleSystem.Arg arg) { }

	// RVA: 0x6CF3B0 Offset: 0x6CD9B0 VA: 0x1806CF3B0
	public void .ctor() { }

	// RVA: 0x6CED20 Offset: 0x6CD320 VA: 0x1806CED20
	private static void .cctor() { }

}

public enum Client.CameraSensorType // TypeDefIndex: 11893
{	// Fields
	public int value__; // 0x0
	public const Client.CameraSensorType _8Mm = 0;
	public const Client.CameraSensorType Super8Mm = 1;
	public const Client.CameraSensorType _16Mm = 2;
	public const Client.CameraSensorType Super16mm = 3;
	public const Client.CameraSensorType _32mm2Perf = 4;
	public const Client.CameraSensorType _35mmAcademy = 5;
	public const Client.CameraSensorType Super35 = 6;
	public const Client.CameraSensorType _65mmALEXA = 7;
	public const Client.CameraSensorType _70mm = 8;
	public const Client.CameraSensorType _70mmImax = 9;
	public const Client.CameraSensorType ALEXA_LF = 10;
	public const Client.CameraSensorType ALEXA_35 = 11;
	public const Client.CameraSensorType Custom = 12;

}

public static class Client // TypeDefIndex: 12039
{	// Fields
	public const float UseDistance = 2;
	private static Scene _entityScene; // 0x0
	private static Scene _effectScene; // 0x4
	private static Scene _decorScene; // 0x8

	// Properties
	public static Scene EntityScene { get; }
	public static Scene EffectScene { get; }
	public static Scene DecorScene { get; }

	// Methods

	// RVA: 0x4BB260 Offset: 0x4B9860 VA: 0x1804BB260
	public static Scene get_EntityScene() { }

	// RVA: 0x4BB1E0 Offset: 0x4B97E0 VA: 0x1804BB1E0
	public static Scene get_EffectScene() { }

	// RVA: 0x4BB160 Offset: 0x4B9760 VA: 0x1804BB160
	public static Scene get_DecorScene() { }

}

