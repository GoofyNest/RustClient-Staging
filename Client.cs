internal class ClientIdentity : Identity // TypeDefIndex: 1134
{	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0xFE15D0 Offset: 0xFDFBD0 VA: 0x180FE15D0
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0xFE16A0 Offset: 0xFDFCA0 VA: 0x180FE16A0
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0xFE1770 Offset: 0xFDFD70 VA: 0x180FE1770
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0xFE1740 Offset: 0xFDFD40 VA: 0x180FE1740
	public string get_TargetUri() { }

}

internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 1146
{	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0xFE15B0 Offset: 0xFDFBB0 VA: 0x180FE15B0
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0xFE14B0 Offset: 0xFDFAB0 VA: 0x180FE14B0 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0xFE1510 Offset: 0xFDFB10 VA: 0x180FE1510 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0xFE1390 Offset: 0xFDF990 VA: 0x180FE1390 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 1230
{	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(Context ctx) { }

	// RVA: 0x1471830 Offset: 0x146FE30 VA: 0x181471830 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1471570 Offset: 0x146FB70 VA: 0x181471570 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 1231
{	// Fields
	private IMessageSink _replySink; // 0x10
	private Context _context; // 0x18

	// Methods

	// RVA: 0xFDD0C0 Offset: 0xFDB6C0 VA: 0x180FDD0C0
	public void .ctor(Context ctx, IMessageSink replySink) { }

	// RVA: 0x1471480 Offset: 0x146FA80 VA: 0x181471480 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1471430 Offset: 0x146FA30 VA: 0x181471430 Slot: 5
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

	// RVA: 0x1E4B20 Offset: 0x1E3F20 VA: 0x1801E4B20 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4B10 Offset: 0x1E3F10 VA: 0x1801E4B10 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D6B0 Offset: 0x136BCB0 VA: 0x18136D6B0
	private static void .cctor() { }

}

public class ClientReady : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6494
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ClientReady.ClientInfo> clientInfo; // 0x18

	// Methods

	// RVA: 0x20AC7B0 Offset: 0x20AADB0 VA: 0x1820AC7B0
	public static void ResetToPool(ClientReady instance) { }

	// RVA: 0x20AC600 Offset: 0x20AAC00 VA: 0x1820AC600
	public void ResetToPool() { }

	// RVA: 0x20AC380 Offset: 0x20AA980 VA: 0x1820AC380 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20AB640 Offset: 0x20A9C40 VA: 0x1820AB640
	public void CopyTo(ClientReady instance) { }

	// RVA: 0x20AB7F0 Offset: 0x20A9DF0 VA: 0x1820AB7F0
	public ClientReady Copy() { }

	// RVA: 0x20ABEF0 Offset: 0x20AA4F0 VA: 0x1820ABEF0
	public static ClientReady Deserialize(Stream stream) { }

	// RVA: 0x20AB870 Offset: 0x20A9E70 VA: 0x1820AB870
	public static ClientReady DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20ABBC0 Offset: 0x20AA1C0 VA: 0x1820ABBC0
	public static ClientReady DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AC260 Offset: 0x20AA860 VA: 0x1820AC260
	public static ClientReady Deserialize(byte[] buffer) { }

	// RVA: 0x20AC5C0 Offset: 0x20AABC0 VA: 0x1820AC5C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20ACEF0 Offset: 0x20AB4F0 VA: 0x1820ACEF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20ACF10 Offset: 0x20AB510 VA: 0x1820ACF10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ClientReady previous) { }

	// RVA: 0x20AC5E0 Offset: 0x20AABE0 VA: 0x1820AC5E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AC160 Offset: 0x20AA760 VA: 0x1820AC160
	public static ClientReady Deserialize(byte[] buffer, ClientReady instance, bool isDelta = False) { }

	// RVA: 0x20ABF70 Offset: 0x20AA570 VA: 0x1820ABF70
	public static ClientReady Deserialize(Stream stream, ClientReady instance, bool isDelta) { }

	// RVA: 0x20AB8F0 Offset: 0x20A9EF0 VA: 0x1820AB8F0
	public static ClientReady DeserializeLengthDelimited(Stream stream, ClientReady instance, bool isDelta) { }

	// RVA: 0x20ABC50 Offset: 0x20AA250 VA: 0x1820ABC50
	public static ClientReady DeserializeLength(Stream stream, int length, ClientReady instance, bool isDelta) { }

	// RVA: 0x20AC960 Offset: 0x20AAF60 VA: 0x1820AC960
	public static void SerializeDelta(Stream stream, ClientReady instance, ClientReady previous) { }

	// RVA: 0x20ACD00 Offset: 0x20AB300 VA: 0x1820ACD00
	public static void Serialize(Stream stream, ClientReady instance) { }

	// RVA: 0x20ACEE0 Offset: 0x20AB4E0 VA: 0x1820ACEE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20ACEF0 Offset: 0x20AB4F0 VA: 0x1820ACEF0
	public void ToProto(Stream stream) { }

	// RVA: 0x20ACBF0 Offset: 0x20AB1F0 VA: 0x1820ACBF0
	public static byte[] SerializeToBytes(ClientReady instance) { }

	// RVA: 0x20ACB40 Offset: 0x20AB140 VA: 0x1820ACB40
	public static void SerializeLengthDelimited(Stream stream, ClientReady instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ClientReady.ClientInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6495
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public string value; // 0x20

	// Methods

	// RVA: 0x20AAED0 Offset: 0x20A94D0 VA: 0x1820AAED0
	public static void ResetToPool(ClientReady.ClientInfo instance) { }

	// RVA: 0x20AAF90 Offset: 0x20A9590 VA: 0x1820AAF90
	public void ResetToPool() { }

	// RVA: 0x20AAE10 Offset: 0x20A9410 VA: 0x1820AAE10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20AA330 Offset: 0x20A8930 VA: 0x1820AA330
	public void CopyTo(ClientReady.ClientInfo instance) { }

	// RVA: 0x20AA380 Offset: 0x20A8980 VA: 0x1820AA380
	public ClientReady.ClientInfo Copy() { }

	// RVA: 0x20AAD90 Offset: 0x20A9390 VA: 0x1820AAD90
	public static ClientReady.ClientInfo Deserialize(Stream stream) { }

	// RVA: 0x20AA410 Offset: 0x20A8A10 VA: 0x1820AA410
	public static ClientReady.ClientInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AA700 Offset: 0x20A8D00 VA: 0x1820AA700
	public static ClientReady.ClientInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AAB70 Offset: 0x20A9170 VA: 0x1820AAB70
	public static ClientReady.ClientInfo Deserialize(byte[] buffer) { }

	// RVA: 0x20AAE90 Offset: 0x20A9490 VA: 0x1820AAE90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AB600 Offset: 0x20A9C00 VA: 0x1820AB600 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AB620 Offset: 0x20A9C20 VA: 0x1820AB620 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ClientReady.ClientInfo previous) { }

	// RVA: 0x20AAEB0 Offset: 0x20A94B0 VA: 0x1820AAEB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AAC90 Offset: 0x20A9290 VA: 0x1820AAC90
	public static ClientReady.ClientInfo Deserialize(byte[] buffer, ClientReady.ClientInfo instance, bool isDelta = False) { }

	// RVA: 0x20AA9E0 Offset: 0x20A8FE0 VA: 0x1820AA9E0
	public static ClientReady.ClientInfo Deserialize(Stream stream, ClientReady.ClientInfo instance, bool isDelta) { }

	// RVA: 0x20AA490 Offset: 0x20A8A90 VA: 0x1820AA490
	public static ClientReady.ClientInfo DeserializeLengthDelimited(Stream stream, ClientReady.ClientInfo instance, bool isDelta) { }

	// RVA: 0x20AA790 Offset: 0x20A8D90 VA: 0x1820AA790
	public static ClientReady.ClientInfo DeserializeLength(Stream stream, int length, ClientReady.ClientInfo instance, bool isDelta) { }

	// RVA: 0x20AB050 Offset: 0x20A9650 VA: 0x1820AB050
	public static void SerializeDelta(Stream stream, ClientReady.ClientInfo instance, ClientReady.ClientInfo previous) { }

	// RVA: 0x20AB420 Offset: 0x20A9A20 VA: 0x1820AB420
	public static void Serialize(Stream stream, ClientReady.ClientInfo instance) { }

	// RVA: 0x20AB5F0 Offset: 0x20A9BF0 VA: 0x1820AB5F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AB600 Offset: 0x20A9C00 VA: 0x1820AB600
	public void ToProto(Stream stream) { }

	// RVA: 0x20AB310 Offset: 0x20A9910 VA: 0x1820AB310
	public static byte[] SerializeToBytes(ClientReady.ClientInfo instance) { }

	// RVA: 0x20AB260 Offset: 0x20A9860 VA: 0x1820AB260
	public static void SerializeLengthDelimited(Stream stream, ClientReady.ClientInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public Connection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	protected void set_Connection(Connection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0 Slot: 7
	public virtual bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_ConnectedAddress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_ConnectedAddress(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public int get_ConnectedPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5983C0 Offset: 0x5969C0 VA: 0x1805983C0
	public void set_ConnectedPort(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_ServerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_ServerName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_IsOfficialServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5925D0 Offset: 0x590BD0 VA: 0x1805925D0
	public void set_IsOfficialServer(bool value) { }

	// RVA: 0x220DA80 Offset: 0x220C080 VA: 0x18220DA80 Slot: 8
	public virtual bool Connect(string strURL, int port) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void Cycle() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void Disconnect(string reason, bool sendReasonToServer = True) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public virtual bool IsConnected() { }

	// RVA: 0x220DC30 Offset: 0x220C230 VA: 0x18220DC30
	protected void OnDisconnected(string str) { }

	// RVA: 0x220DAF0 Offset: 0x220C0F0 VA: 0x18220DAF0
	public Networkable CreateNetworkable(uint networkID, uint networkGroup) { }

	// RVA: 0x220DBA0 Offset: 0x220C1A0 VA: 0x18220DBA0
	public void DestroyNetworkable(ref Networkable networkable) { }

	// RVA: 0x220DCF0 Offset: 0x220C2F0 VA: 0x18220DCF0
	public void SetupNetworkable(Networkable net) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 12
	public virtual int GetLastPing() { }

	// RVA: 0x220E020 Offset: 0x220C620 VA: 0x18220E020
	public bool get_IsRecording() { }

	// RVA: 0xFA1950 Offset: 0xF9FF50 VA: 0x180FA1950
	public string get_RecordFilename() { }

	// RVA: 0x220E040 Offset: 0x220C640 VA: 0x18220E040
	public TimeSpan get_RecordTimeElapsed() { }

	// RVA: 0x220DD20 Offset: 0x220C320 VA: 0x18220DD20
	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	// RVA: 0x220DE40 Offset: 0x220C440 VA: 0x18220DE40
	public void StopRecording() { }

	// RVA: 0x220DEB0 Offset: 0x220C4B0 VA: 0x18220DEB0
	public void .ctor() { }

	// RVA: 0x220DE60 Offset: 0x220C460 VA: 0x18220DE60
	private static void .cctor() { }

}

public class ClientVar : ConsoleVar // TypeDefIndex: 6894
{	// Methods

	// RVA: 0x22B2970 Offset: 0x22B0F70 VA: 0x1822B2970
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

	// RVA: 0x22CD0B0 Offset: 0x22CB6B0 VA: 0x1822CD0B0 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x22CBDA0 Offset: 0x22CA3A0 VA: 0x1822CBDA0 Slot: 8
	public override bool Connect(string strURL, int port) { }

	// RVA: 0x22CCB30 Offset: 0x22CB130 VA: 0x1822CCB30
	internal bool HandleRaknetPacket(byte type) { }

	// RVA: 0x22CC510 Offset: 0x22CAB10 VA: 0x1822CC510
	protected void HandleMessage() { }

	// RVA: 0x22CBEB0 Offset: 0x22CA4B0 VA: 0x1822CBEB0 Slot: 9
	public override void Cycle() { }

	// RVA: 0x22CC2D0 Offset: 0x22CA8D0 VA: 0x1822CC2D0 Slot: 10
	public override void Disconnect(string reason, bool sendReasonToServer) { }

	// RVA: 0x22CC430 Offset: 0x22CAA30 VA: 0x1822CC430 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22CC4F0 Offset: 0x22CAAF0 VA: 0x1822CC4F0 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22CC4B0 Offset: 0x22CAAB0 VA: 0x1822CC4B0 Slot: 12
	public override int GetLastPing() { }

	// RVA: 0x22CD0C0 Offset: 0x22CB6C0 VA: 0x1822CD0C0 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22CD260 Offset: 0x22CB860 VA: 0x1822CD260
	public void .ctor() { }

	// RVA: 0x22CD210 Offset: 0x22CB810 VA: 0x1822CD210
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

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void SetIOEntityOwner(IOEntity newOwner) { }

	// RVA: 0x5704B0 Offset: 0x56EAB0 VA: 0x1805704B0
	public void OnEnable() { }

	// RVA: 0x570420 Offset: 0x56EA20 VA: 0x180570420
	public void OnDisable() { }

	// RVA: 0x5705B0 Offset: 0x56EBB0 VA: 0x1805705B0
	public static void SetDirectionVisibleAll(bool isVisible, IOEntity.IOType forType) { }

	// RVA: 0x570710 Offset: 0x56ED10 VA: 0x180570710
	public static void SetDirectionVisibleSingle(bool isVisible, ClientIOLine line) { }

	// RVA: 0x56FEF0 Offset: 0x56E4F0 VA: 0x18056FEF0
	public void Clear() { }

	// RVA: 0x56FF20 Offset: 0x56E520 VA: 0x18056FF20
	public void DelayedDirectionTest() { }

	// RVA: 0x570890 Offset: 0x56EE90 VA: 0x180570890
	public void SetDirectionVisible(bool isVisible) { }

	// RVA: 0x570B20 Offset: 0x56F120 VA: 0x180570B20
	public void SetVisible(bool isVisible) { }

	// RVA: 0x570A40 Offset: 0x56F040 VA: 0x180570A40
	public void SetLineCullDistance(float length) { }

	// RVA: 0x570A90 Offset: 0x56F090 VA: 0x180570A90
	public void SetPositions(Vector3[] positions, float[] slackLevels) { }

	// RVA: 0x56FE00 Offset: 0x56E400 VA: 0x18056FE00
	public void AddPosition(Vector3 worldPos) { }

	// RVA: 0x570970 Offset: 0x56EF70 VA: 0x180570970
	public void SetLastNodePosition(Vector3 worldPos) { }

	// RVA: 0x570540 Offset: 0x56EB40 VA: 0x180570540
	public void RemoveLastPosition() { }

	// RVA: 0x570270 Offset: 0x56E870 VA: 0x180570270
	public float GetLength() { }

	// RVA: 0x570BD0 Offset: 0x56F1D0 VA: 0x180570BD0
	public void UpdateBoundsAndPosition() { }

	// RVA: 0x570160 Offset: 0x56E760 VA: 0x180570160
	public Vector3 GetLastPlacedNodePosition() { }

	// RVA: 0x570C50 Offset: 0x56F250 VA: 0x180570C50
	public int get_PositionCount() { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
	public void .ctor() { }

	// RVA: 0x570BF0 Offset: 0x56F1F0 VA: 0x180570BF0
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
	// RVA: 0x545EE0 Offset: 0x5444E0 VA: 0x180545EE0
	public static void add_OnConnected(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5468F0 Offset: 0x544EF0 VA: 0x1805468F0
	public static void remove_OnConnected(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x545FE0 Offset: 0x5445E0 VA: 0x180545FE0
	public static void add_OnDisconnected(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5469F0 Offset: 0x544FF0 VA: 0x1805469F0
	public static void remove_OnDisconnected(Action value) { }

	// RVA: 0x546830 Offset: 0x544E30 VA: 0x180546830
	private bool get_StatsEnabled() { }

	// RVA: 0x543980 Offset: 0x541F80 VA: 0x180543980
	private void RegisterIncoming(string type, long bytes) { }

	// RVA: 0x543AC0 Offset: 0x5420C0 VA: 0x180543AC0
	private void RegisterIncoming(string type, string entity, long bytes) { }

	// RVA: 0x541FA0 Offset: 0x5405A0 VA: 0x180541FA0 Slot: 8
	public void OnNetworkMessage(Message packet) { }

	// RVA: 0x541E60 Offset: 0x540460 VA: 0x180541E60
	private void OnMessage(Message packet) { }

	// RVA: 0x5432F0 Offset: 0x5418F0 VA: 0x1805432F0
	private void OnRequestUserInformation(Message packet) { }

	// RVA: 0x53F7B0 Offset: 0x53DDB0 VA: 0x18053F7B0
	private void OnApproved(Message packet) { }

	// RVA: 0x542F60 Offset: 0x541560 VA: 0x180542F60
	private void OnRPCMessage(Message packet) { }

	// RVA: 0x53EE00 Offset: 0x53D400 VA: 0x18053EE00
	private string GetOSName() { }

	// RVA: 0x53BE00 Offset: 0x53A400 VA: 0x18053BE00
	public void CancelAuthTicket() { }

	// RVA: 0x53EC30 Offset: 0x53D230 VA: 0x18053EC30
	public IAuthTicket GetAuthTicket(bool cancelOld = True) { }

	// RVA: 0x53BEC0 Offset: 0x53A4C0 VA: 0x18053BEC0
	private void CancelLoading() { }

	// RVA: 0x5443B0 Offset: 0x5429B0 VA: 0x1805443B0
	private Coroutine StartLoading(IEnumerator coroutine) { }

	[AsyncStateMachineAttribute] // RVA: 0xD2320 Offset: 0xD1720 VA: 0x1800D2320
	// RVA: 0x53C160 Offset: 0x53A760 VA: 0x18053C160
	public Task Connect(string strAddress, int port, string protocol, bool hideIpAddress = False) { }

	// RVA: 0x53E1E0 Offset: 0x53C7E0 VA: 0x18053E1E0
	private void DestroyNetworkables() { }

	[IteratorStateMachineAttribute] // RVA: 0xD24A0 Offset: 0xD18A0 VA: 0x1800D24A0
	// RVA: 0x53E400 Offset: 0x53CA00 VA: 0x18053E400
	private IEnumerator DoClientConnected(Approval msg) { }

	// RVA: 0x53F9E0 Offset: 0x53DFE0 VA: 0x18053F9E0 Slot: 9
	public void OnClientDisconnected(string strReason) { }

	// RVA: 0x53BF70 Offset: 0x53A570 VA: 0x18053BF70
	public static void ClientCleanup() { }

	// RVA: 0x53FC20 Offset: 0x53E220 VA: 0x18053FC20
	private static void OnConsoleReplicatedVars(Message packet) { }

	// RVA: 0x544070 Offset: 0x542670 VA: 0x180544070
	private static void SetReplicatedVar(string fullName, string value) { }

	// RVA: 0x543CC0 Offset: 0x5422C0 VA: 0x180543CC0
	private void RunDebugCommands() { }

	// RVA: 0x53E490 Offset: 0x53CA90 VA: 0x18053E490
	private void DrawColliders() { }

	// RVA: 0x544E90 Offset: 0x543490 VA: 0x180544E90
	private void UpdateNetgraph() { }

	// RVA: 0x53ECE0 Offset: 0x53D2E0 VA: 0x18053ECE0
	private Stats GetCurrentNetworkStats() { }

	// RVA: 0x546690 Offset: 0x544C90 VA: 0x180546690
	public static bool get_IsPlayingDemo() { }

	// RVA: 0x5466E0 Offset: 0x544CE0 VA: 0x1805466E0
	public static bool get_IsRecordingDemo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x546730 Offset: 0x544D30 VA: 0x180546730
	public static bool get_IsScrubbingDemo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x546BD0 Offset: 0x5451D0 VA: 0x180546BD0
	public static void set_IsScrubbingDemo(bool value) { }

	// RVA: 0x5467E0 Offset: 0x544DE0 VA: 0x1805467E0
	public static TimeSpan get_RecordingTimeElapsed() { }

	// RVA: 0x546790 Offset: 0x544D90 VA: 0x180546790
	public static string get_RecordingFilename() { }

	// RVA: 0x546160 Offset: 0x544760 VA: 0x180546160
	public static BasePlayer get_DemoLocalPlayer() { }

	// RVA: 0x546320 Offset: 0x544920 VA: 0x180546320
	public static TimeSpan get_DemoProgress() { }

	// RVA: 0x5460E0 Offset: 0x5446E0 VA: 0x1805460E0
	public static TimeSpan get_DemoLength() { }

	// RVA: 0x546260 Offset: 0x544860 VA: 0x180546260
	public static float get_DemoNormalizedTime() { }

	// RVA: 0x5461F0 Offset: 0x5447F0 VA: 0x1805461F0
	public static string get_DemoName() { }

	// RVA: 0x5463C0 Offset: 0x5449C0 VA: 0x1805463C0
	public static DateTime get_DemoRecordedTime() { }

	// RVA: 0x544490 Offset: 0x542A90 VA: 0x180544490
	public void StartPlayingDemo(Reader demo, bool inPlace) { }

	[IteratorStateMachineAttribute] // RVA: 0xD2850 Offset: 0xD1C50 VA: 0x1800D2850
	// RVA: 0x5443F0 Offset: 0x5429F0 VA: 0x1805443F0
	private IEnumerator StartPlayingDemoInternal(Reader demo, bool inPlace) { }

	// RVA: 0x53FD30 Offset: 0x53E330 VA: 0x18053FD30
	private void OnDemoKeyframe(Indexer.Keyframe keyframe, HashSet<uint> changedEnts) { }

	// RVA: 0x544840 Offset: 0x542E40 VA: 0x180544840
	public void StopRecordingDemo() { }

	// RVA: 0x544540 Offset: 0x542B40 VA: 0x180544540
	public void StopPlayingDemo(bool finished = False) { }

	// RVA: 0x53D420 Offset: 0x53BA20 VA: 0x18053D420
	private void DemoFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x546470 Offset: 0x544A70 VA: 0x180546470
	public static BasePlayer get_DemoSpectatePlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x546AF0 Offset: 0x5450F0 VA: 0x180546AF0
	private static void set_DemoSpectatePlayer(BasePlayer value) { }

	// RVA: 0x53E030 Offset: 0x53C630 VA: 0x18053E030
	private void DemoSpectateNextPlayer(bool forward) { }

	// RVA: 0x53D970 Offset: 0x53BF70 VA: 0x18053D970
	private void DemoLateUpdate(bool isLastCall) { }

	// RVA: 0x53DEA0 Offset: 0x53C4A0 VA: 0x18053DEA0
	private void DemoPlayerTick(PlayerTick playerTick) { }

	// RVA: 0x5418E0 Offset: 0x53FEE0 VA: 0x1805418E0
	private void OnGroupEnter(Message msg) { }

	// RVA: 0x5419E0 Offset: 0x53FFE0 VA: 0x1805419E0
	private void OnGroupLeave(Message msg) { }

	// RVA: 0x540B00 Offset: 0x53F100 VA: 0x180540B00
	private void OnEntityDestroy(Message msg) { }

	// RVA: 0x541680 Offset: 0x53FC80 VA: 0x180541680
	private void OnGroupDestroy(Message msg) { }

	// RVA: 0x540EE0 Offset: 0x53F4E0 VA: 0x180540EE0
	private void OnGroupChange(Message msg) { }

	// RVA: 0x540810 Offset: 0x53EE10 VA: 0x180540810
	private void OnEntities(Message packet) { }

	// RVA: 0x53C2A0 Offset: 0x53A8A0 VA: 0x18053C2A0
	private BaseEntity CreateOrUpdateEntity(Entity info, long size) { }

	// RVA: 0x540D60 Offset: 0x53F360 VA: 0x180540D60
	private void OnEntityPosition(Message packet) { }

	// RVA: 0x544C10 Offset: 0x543210 VA: 0x180544C10
	private void UpdateEntityPosition(uint entID, Vector3 pos, Vector3 rot, float time, uint parentID) { }

	// RVA: 0x540CE0 Offset: 0x53F2E0 VA: 0x180540CE0
	private void OnEntityFlags(Message packet) { }

	// RVA: 0x544990 Offset: 0x542F90 VA: 0x180544990
	private void UpdateEntityFlags(uint entID, int flags) { }

	// RVA: 0x546530 Offset: 0x544B30 VA: 0x180546530
	public static EventSystem get_EventSystem() { }

	// RVA: 0x53BF00 Offset: 0x53A500 VA: 0x18053BF00
	private void ClearVisibility() { }

	// RVA: 0x53F500 Offset: 0x53DB00 VA: 0x18053F500
	private void NetworkInit() { }

	// RVA: 0x5451F0 Offset: 0x5437F0 VA: 0x1805451F0
	private void Update() { }

	// RVA: 0x53EE60 Offset: 0x53D460 VA: 0x18053EE60
	private void LateUpdate() { }

	// RVA: 0x53E320 Offset: 0x53C920 VA: 0x18053E320
	private void Disconnect() { }

	// RVA: 0x5407A0 Offset: 0x53EDA0 VA: 0x1805407A0
	private void OnDisable() { }

	// RVA: 0x53F6E0 Offset: 0x53DCE0 VA: 0x18053F6E0
	private void OnApplicationQuit() { }

	// RVA: 0x541AE0 Offset: 0x5400E0 VA: 0x180541AE0
	private void OnLeaveServer() { }

	// RVA: 0x543EE0 Offset: 0x5424E0 VA: 0x180543EE0
	private void SaveConfigs(bool force = False) { }

	// RVA: 0x53ED90 Offset: 0x53D390 VA: 0x18053ED90
	private static extern uint GetCurrentProcessId() { }

	// RVA: 0x5438F0 Offset: 0x541EF0 VA: 0x1805438F0
	private static extern IntPtr OpenProcess(Client.ProcessAccessFlags processAccess, bool bInheritHandle, uint processId) { }

	// RVA: 0x544900 Offset: 0x542F00 VA: 0x180544900
	private static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode) { }

	// RVA: 0x544170 Offset: 0x542770 VA: 0x180544170
	private void ShutdownClient() { }

	// RVA: 0x545E20 Offset: 0x544420 VA: 0x180545E20
	public void .ctor() { }

	// RVA: 0x545A30 Offset: 0x544030 VA: 0x180545A30
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

	// RVA: 0x589D10 Offset: 0x588310 VA: 0x180589D10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589990 Offset: 0x587F90 VA: 0x180589990
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
	// RVA: 0x586D30 Offset: 0x585330 VA: 0x180586D30 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x585700 Offset: 0x583D00 VA: 0x180585700 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x586DE0 Offset: 0x5853E0 VA: 0x180586DE0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x586CE0 Offset: 0x5852E0 VA: 0x180586CE0 Slot: 8
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
	// RVA: 0x5895C0 Offset: 0x587BC0 VA: 0x1805895C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5881A0 Offset: 0x5867A0 VA: 0x1805881A0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x5897A0 Offset: 0x587DA0 VA: 0x1805897A0
	private void <>m__Finally1() { }

	// RVA: 0x5897F0 Offset: 0x587DF0 VA: 0x1805897F0
	private void <>m__Finally2() { }

	// RVA: 0x589840 Offset: 0x587E40 VA: 0x180589840
	private void <>m__Finally3() { }

	// RVA: 0x589890 Offset: 0x587E90 VA: 0x180589890
	private void <>m__Finally4() { }

	// RVA: 0x5898E0 Offset: 0x587EE0 VA: 0x1805898E0
	private void <>m__Finally5() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x589570 Offset: 0x587B70 VA: 0x180589570 Slot: 8
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

	// RVA: 0x56FC20 Offset: 0x56E220 VA: 0x18056FC20
	public void Cycle() { }

	// RVA: 0x56FBB0 Offset: 0x56E1B0 VA: 0x18056FBB0 Slot: 4
	protected override BuildingManager.Building CreateBuilding(uint id) { }

	// RVA: 0x56FD40 Offset: 0x56E340 VA: 0x18056FD40 Slot: 5
	protected override void DisposeBuilding(ref BuildingManager.Building building) { }

	// RVA: 0x56FDA0 Offset: 0x56E3A0 VA: 0x18056FDA0
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

	// RVA: 0x6D01C0 Offset: 0x6CE7C0 VA: 0x1806D01C0
	public static float get_maxreceivetime() { }

	// RVA: 0x6D1780 Offset: 0x6CFD80 VA: 0x1806D1780
	public static void set_maxreceivetime(float value) { }

	// RVA: 0x6D0220 Offset: 0x6CE820 VA: 0x1806D0220
	public static float get_minreceivefraction() { }

	// RVA: 0x6D1840 Offset: 0x6CFE40 VA: 0x1806D1840
	public static void set_minreceivefraction(float value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CF7A0 Offset: 0x6CDDA0 VA: 0x1806CF7A0
	public static string connect(string address = "127.0.0.1:28015", string protocol = "", bool hideIpAddress = False) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CFA60 Offset: 0x6CE060 VA: 0x1806CFA60
	public static string connecthidden(string address = "127.0.0.1:28015", string protocol = "") { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CFDA0 Offset: 0x6CE3A0 VA: 0x1806CFDA0
	public static string fps() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CFB40 Offset: 0x6CE140 VA: 0x1806CFB40
	public static string disconnect() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D08E0 Offset: 0x6CEEE0 VA: 0x1806D08E0
	public static void report() { }

	[ClientVar] // RVA: 0x8F3B0 Offset: 0x8E7B0 VA: 0x18008F3B0
	// RVA: 0x6D0680 Offset: 0x6CEC80 VA: 0x1806D0680
	public static string printpos() { }

	[ClientVar] // RVA: 0x8F4C0 Offset: 0x8E8C0 VA: 0x18008F4C0
	// RVA: 0x6D07A0 Offset: 0x6CEDA0 VA: 0x1806D07A0
	public static string printrot() { }

	[ClientVar] // RVA: 0x8F7A0 Offset: 0x8EBA0 VA: 0x18008F7A0
	// RVA: 0x6D0320 Offset: 0x6CE920 VA: 0x1806D0320
	public static string printeyes() { }

	[ClientVar] // RVA: 0x8F820 Offset: 0x8EC20 VA: 0x18008F820
	// RVA: 0x6D0570 Offset: 0x6CEB70 VA: 0x1806D0570
	public static string printinput() { }

	[ClientVar] // RVA: 0x8F9B0 Offset: 0x8EDB0 VA: 0x18008F9B0
	// RVA: 0x6D0460 Offset: 0x6CEA60 VA: 0x1806D0460
	public static string printhead() { }

	// RVA: 0x6CE520 Offset: 0x6CCB20 VA: 0x1806CE520
	public static string GetClientFolder(string folder) { }

	// RVA: 0x6D00E0 Offset: 0x6CE6E0 VA: 0x1806D00E0
	public static bool get_camPhysical() { }

	// RVA: 0x6D12E0 Offset: 0x6CF8E0 VA: 0x1806D12E0
	public static void set_camPhysical(bool value) { }

	// RVA: 0x6CFEF0 Offset: 0x6CE4F0 VA: 0x1806CFEF0
	public static int get_camPhysicalSensor() { }

	// RVA: 0x6D1140 Offset: 0x6CF740 VA: 0x1806D1140
	public static void set_camPhysicalSensor(int value) { }

	// RVA: 0x6CFE10 Offset: 0x6CE410 VA: 0x1806CFE10
	public static float get_camPhysicalFocalLength() { }

	// RVA: 0x6D1060 Offset: 0x6CF660 VA: 0x1806D1060
	public static void set_camPhysicalFocalLength(float value) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6CF630 Offset: 0x6CDC30 VA: 0x1806CF630
	public static void camPhysicalSensorTypes(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x6D1BB0 Offset: 0x6D01B0 VA: 0x1806D1BB0
	public static void sv(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CFAD0 Offset: 0x6CE0D0 VA: 0x1806CFAD0
	public static void consoletoggle() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D0280 Offset: 0x6CE880 VA: 0x1806D0280
	public static int ping() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CF4F0 Offset: 0x6CDAF0 VA: 0x1806CF4F0
	public static void benchmark(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CF3A0 Offset: 0x6CD9A0 VA: 0x1806CF3A0
	public static void benchmark_demo(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D1900 Offset: 0x6CFF00 VA: 0x1806D1900
	public static void setunderwear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE550 Offset: 0x6CCB50 VA: 0x1806CE550
	public static void PlayerSeed(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE9F0 Offset: 0x6CCFF0 VA: 0x1806CE9F0
	public static void ShufflePlayerSeed(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE900 Offset: 0x6CCF00 VA: 0x1806CE900
	public static void ReportPlayer(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE840 Offset: 0x6CCE40 VA: 0x1806CE840
	public static void ReportBug(ConsoleSystem.Arg arg) { }

	// RVA: 0x6CF340 Offset: 0x6CD940 VA: 0x1806CF340
	public void .ctor() { }

	// RVA: 0x6CECB0 Offset: 0x6CD2B0 VA: 0x1806CECB0
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

	// RVA: 0x4BB1F0 Offset: 0x4B97F0 VA: 0x1804BB1F0
	public static Scene get_EntityScene() { }

	// RVA: 0x4BB170 Offset: 0x4B9770 VA: 0x1804BB170
	public static Scene get_EffectScene() { }

	// RVA: 0x4BB0F0 Offset: 0x4B96F0 VA: 0x1804BB0F0
	public static Scene get_DecorScene() { }

}

