internal abstract class ServerIdentity : Identity // TypeDefIndex: 1145
{	// Fields
	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

	// Properties
	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }

	// Methods

	// RVA: 0x12034C0 Offset: 0x1201AC0 VA: 0x1812034C0
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public Type get_ObjectType() { }

	// RVA: 0x1203330 Offset: 0x1201930 VA: 0x181203330
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x1203320 Offset: 0x1201920 VA: 0x181203320 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x12030B0 Offset: 0x12016B0 VA: 0x1812030B0 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1202F60 Offset: 0x1201560 VA: 0x181202F60
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public Lease get_Lease() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public Context get_Context() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	// RVA: 0x1203280 Offset: 0x1201880 VA: 0x181203280
	protected void DisposeServerObject() { }

}

internal class ServerContextTerminatorSink : IMessageSink // TypeDefIndex: 1259
{	// Methods

	// RVA: 0x148CE80 Offset: 0x148B480 VA: 0x18148CE80 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x148CD70 Offset: 0x148B370 VA: 0x18148CD70 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 1260
{	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x148D320 Offset: 0x148B920 VA: 0x18148D320 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x148D100 Offset: 0x148B700 VA: 0x18148D100 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 1261
{	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0xFDC360 Offset: 0xFDA960 VA: 0x180FDC360
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x148D040 Offset: 0x148B640 VA: 0x18148D040 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x148CFF0 Offset: 0x148B5F0 VA: 0x18148CFF0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal sealed class ServerCertValidationCallbackWrapper : MulticastDelegate // TypeDefIndex: 2542
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFFB630 Offset: 0xFF9C30 VA: 0x180FFB630 Slot: 12
	public virtual bool Invoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x121BBB0 Offset: 0x121A1B0 VA: 0x18121BBB0 Slot: 13
	public virtual IAsyncResult BeginInvoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback __callback, object object) { }

	// RVA: 0xFF6250 Offset: 0xFF4850 VA: 0x180FF6250 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

internal class ServerCertValidationCallback // TypeDefIndex: 2985
{	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0xFFCFF0 Offset: 0xFFB5F0 VA: 0x180FFCFF0
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0xFFCDE0 Offset: 0xFFB3E0 VA: 0x180FFCDE0
	internal void Callback(object state) { }

	// RVA: 0xFFCEA0 Offset: 0xFFB4A0 VA: 0x180FFCEA0
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

private class ServerCertValidationCallback.CallbackContext // TypeDefIndex: 2986
{	// Fields
	internal readonly object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal bool result; // 0x2C

	// Methods

	// RVA: 0xFF6EC0 Offset: 0xFF54C0 VA: 0x180FF6EC0
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

public struct ServerInfo : IEquatable<ServerInfo> // TypeDefIndex: 5557
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Name>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <Ping>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <GameDir>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Map>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Description>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private uint <AppId>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <Players>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <MaxPlayers>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <BotPlayers>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <Passworded>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <Secure>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private uint <LastTimePlayed>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <Version>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <TagString>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <SteamId>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private uint <AddressRaw>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private IPAddress <Address>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <ConnectionPort>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <QueryPort>k__BackingField; // 0x6C
	private string[] _tags; // 0x70

	// Properties
	public string Name { get; set; }
	public int Ping { get; set; }
	public string GameDir { set; }
	public string Map { get; set; }
	public string Description { set; }
	public uint AppId { get; set; }
	public int Players { get; set; }
	public int MaxPlayers { get; set; }
	public int BotPlayers { set; }
	public bool Passworded { set; }
	public bool Secure { get; set; }
	public uint LastTimePlayed { get; set; }
	public int Version { set; }
	public string TagString { get; set; }
	public ulong SteamId { get; set; }
	public uint AddressRaw { get; set; }
	public IPAddress Address { get; set; }
	public int ConnectionPort { get; set; }
	public int QueryPort { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	public void set_Name(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public int get_Ping() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19DFD0 Offset: 0x19D3D0 VA: 0x18019DFD0
	public void set_Ping(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF14F0 Offset: 0xF08F0 VA: 0x1800F14F0
	public void set_GameDir(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
	public string get_Map() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF1500 Offset: 0xF0900 VA: 0x1800F1500
	public void set_Map(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF1560 Offset: 0xF0960 VA: 0x1800F1560
	public void set_Description(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0xF3F50 Offset: 0xF3350 VA: 0x1800F3F50
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F80 Offset: 0xF3380 VA: 0x1800F3F80
	public void set_AppId(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D86A0 Offset: 0x1D7AA0 VA: 0x1801D86A0
	public int get_Players() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8730 Offset: 0x1D7B30 VA: 0x1801D8730
	public void set_Players(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D10C0 Offset: 0x1D04C0 VA: 0x1801D10C0
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8720 Offset: 0x1D7B20 VA: 0x1801D8720
	public void set_MaxPlayers(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D86F0 Offset: 0x1D7AF0 VA: 0x1801D86F0
	public void set_BotPlayers(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D2830 Offset: 0x1D1C30 VA: 0x1801D2830
	public void set_Passworded(bool value) { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D86C0 Offset: 0x1D7AC0 VA: 0x1801D86C0
	public bool get_Secure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8750 Offset: 0x1D7B50 VA: 0x1801D8750
	public void set_Secure(bool value) { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D8690 Offset: 0x1D7A90 VA: 0x1801D8690
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8710 Offset: 0x1D7B10 VA: 0x1801D8710
	public void set_LastTimePlayed(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8770 Offset: 0x1D7B70 VA: 0x1801D8770
	public void set_Version(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0xFC8A0 Offset: 0xFBCA0 VA: 0x1800FC8A0
	public string get_TagString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37F0 Offset: 0xF2BF0 VA: 0x1800F37F0
	public void set_TagString(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D86D0 Offset: 0x1D7AD0 VA: 0x1801D86D0
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8760 Offset: 0x1D7B60 VA: 0x1801D8760
	public void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D8660 Offset: 0x1D7A60 VA: 0x1801D8660
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D86E0 Offset: 0x1D7AE0 VA: 0x1801D86E0
	public void set_AddressRaw(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D8670 Offset: 0x1D7A70 VA: 0x1801D8670
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3810 Offset: 0xF2C10 VA: 0x1800F3810
	public void set_Address(IPAddress value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D8680 Offset: 0x1D7A80 VA: 0x1801D8680
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8700 Offset: 0x1D7B00 VA: 0x1801D8700
	public void set_ConnectionPort(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D86B0 Offset: 0x1D7AB0 VA: 0x1801D86B0
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8740 Offset: 0x1D7B40 VA: 0x1801D8740
	public void set_QueryPort(int value) { }

	// RVA: 0x128F140 Offset: 0x128D740 VA: 0x18128F140
	internal static ServerInfo From(gameserveritem_t item) { }

	// RVA: 0x1D85A0 Offset: 0x1D79A0 VA: 0x1801D85A0
	public void .ctor(uint ip, ushort cport, ushort qport, uint timeplayed) { }

	// RVA: 0x1D8050 Offset: 0x1D7450 VA: 0x1801D8050
	public void AddToHistory() { }

	[AsyncStateMachineAttribute] // RVA: 0xA5D40 Offset: 0xA5140 VA: 0x1800A5D40
	// RVA: 0x1D8290 Offset: 0x1D7690 VA: 0x1801D8290
	public Task<Dictionary<string, string>> QueryRulesAsync() { }

	// RVA: 0x1D84B0 Offset: 0x1D78B0 VA: 0x1801D84B0
	public void RemoveFromHistory() { }

	// RVA: 0x1D7F10 Offset: 0x1D7310 VA: 0x1801D7F10
	public void AddToFavourites() { }

	// RVA: 0x1D83C0 Offset: 0x1D77C0 VA: 0x1801D83C0
	public void RemoveFromFavourites() { }

	// RVA: 0x1D8190 Offset: 0x1D7590 VA: 0x1801D8190 Slot: 4
	public bool Equals(ServerInfo other) { }

	// RVA: 0x1D8280 Offset: 0x1D7680 VA: 0x1801D8280 Slot: 2
	public override int GetHashCode() { }

}

private struct ServerInfo.<QueryRulesAsync>d__85 : IAsyncStateMachine // TypeDefIndex: 5558
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo <>4__this; // 0x20
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x98

	// Methods

	// RVA: 0x1DB230 Offset: 0x1DA630 VA: 0x1801DB230 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1DB240 Offset: 0x1DA640 VA: 0x1801DB240 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public enum ServerQuerySet // TypeDefIndex: 5695
{	// Fields
	public int value__; // 0x0
	public const ServerQuerySet Whitelist = 0;
	public const ServerQuerySet Internet = 1;
	public const ServerQuerySet LocalNetwork = 2;
	public const ServerQuerySet Friends = 3;
	public const ServerQuerySet Favorites = 4;
	public const ServerQuerySet History = 5;

}

public struct ServerInfo // TypeDefIndex: 5701
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly uint <AppId>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly string <Name>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly IPAddress <Address>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly uint <AddressRaw>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly int <ConnectionPort>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly int <QueryPort>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly string <Map>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly string <TagString>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly bool <IsSecure>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly int <Players>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly int <MaxPlayers>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly uint <LastTimePlayed>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly int <Ping>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly ulong <SteamId>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly uint <Born>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly IReadOnlyList<string> <Tags>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly string <ConnectionProtocol>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly string <ConnectionString>k__BackingField; // 0x70

	// Properties
	public uint AppId { get; }
	public string Name { get; }
	public IPAddress Address { get; }
	public uint AddressRaw { get; }
	public int ConnectionPort { get; }
	public int QueryPort { get; }
	public string Map { get; }
	public string TagString { get; }
	public bool IsSecure { get; }
	public int Players { get; }
	public int MaxPlayers { get; }
	public uint LastTimePlayed { get; }
	public int Ping { get; }
	public ulong SteamId { get; }
	public uint Born { get; }
	public IReadOnlyList<string> Tags { get; }
	public string ConnectionProtocol { get; }
	public string ConnectionString { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1EF120 Offset: 0x1EE520 VA: 0x1801EF120
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1EF130 Offset: 0x1EE530 VA: 0x1801EF130
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x12C240 Offset: 0x12B640 VA: 0x18012C240
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC880 Offset: 0xFBC80 VA: 0x1800FC880
	public string get_Map() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFCAD0 Offset: 0xFBED0 VA: 0x1800FCAD0
	public string get_TagString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23F990 Offset: 0x23ED90 VA: 0x18023F990
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8690 Offset: 0x1D7A90 VA: 0x1801D8690
	public int get_Players() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC890 Offset: 0xFBC90 VA: 0x1800FC890
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23F9A0 Offset: 0x23EDA0 VA: 0x18023F9A0
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1E0B70 Offset: 0x1DFF70 VA: 0x1801E0B70
	public int get_Ping() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D86D0 Offset: 0x1D7AD0 VA: 0x1801D86D0
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8660 Offset: 0x1D7A60 VA: 0x1801D8660
	public uint get_Born() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1D8670 Offset: 0x1D7A70 VA: 0x1801D8670
	public IReadOnlyList<string> get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC8D0 Offset: 0xFBCD0 VA: 0x1800FC8D0
	public string get_ConnectionProtocol() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x141F90 Offset: 0x141390 VA: 0x180141F90
	public string get_ConnectionString() { }

	// RVA: 0x23F970 Offset: 0x23ED70 VA: 0x18023F970
	public void .ctor(uint appId, string name, IPAddress address, int connectionPort, int queryPort, string map, string tagString, bool isSecure, int players, int maxPlayers, uint lastTimePlayed, int ping, ulong steamId, int authedPlayers = 2147483647) { }

	// RVA: 0x23004E0 Offset: 0x22FEAE0 VA: 0x1823004E0
	private static uint AddressToUInt32(IPAddress address) { }

	// RVA: 0x19E20F0 Offset: 0x19E06F0 VA: 0x1819E20F0
	private static uint Swap(uint x) { }

}

private sealed class ServerInfo.<>c // TypeDefIndex: 5702
{	// Fields
	public static readonly ServerInfo.<>c <>9; // 0x0
	public static Func<string, bool> <>9__54_0; // 0x8

	// Methods

	// RVA: 0x2300CA0 Offset: 0x22FF2A0 VA: 0x182300CA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2300C50 Offset: 0x22FF250 VA: 0x182300C50
	internal bool <.ctor>b__54_0(string x) { }

}

public struct ServerParameters // TypeDefIndex: 5703
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly string <ShortName>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly string <FullName>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly string <Version>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly bool <IsSecure>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly bool <HideIP>k__BackingField; // 0x19
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly IPAddress <Address>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly ushort <GamePort>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly ushort <QueryPort>k__BackingField; // 0x2A

	// Properties
	public string ShortName { get; }
	public string FullName { get; }
	public string Version { get; }
	public bool IsSecure { get; }
	public bool HideIP { get; }
	public IPAddress Address { get; }
	public ushort GamePort { get; }
	public ushort QueryPort { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public string get_ShortName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	public string get_FullName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23FB30 Offset: 0x23EF30 VA: 0x18023FB30
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23FB20 Offset: 0x23EF20 VA: 0x18023FB20
	public bool get_HideIP() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37B0 Offset: 0xF2BB0 VA: 0x1800F37B0
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23FB10 Offset: 0x23EF10 VA: 0x18023FB10
	public ushort get_GamePort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23FB40 Offset: 0x23EF40 VA: 0x18023FB40
	public ushort get_QueryPort() { }

	// RVA: 0x23F9B0 Offset: 0x23EDB0 VA: 0x18023F9B0
	public void .ctor(string shortName, string fullName, string version, bool isSecure, bool hideIP, IPAddress address, ushort gamePort, ushort queryPort = 0) { }

}

public static class ServerInfoExtensions // TypeDefIndex: 6157
{	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x9A050 Offset: 0x99450 VA: 0x18009A050
	[ExtensionAttribute] // RVA: 0x9A050 Offset: 0x99450 VA: 0x18009A050
	// RVA: 0x2315FC0 Offset: 0x23145C0 VA: 0x182315FC0
	public static Task<Dictionary<string, string>> QueryRulesAsync(ServerInfo server) { }

}

private struct ServerInfoExtensions.<QueryRulesAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 6158
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo server; // 0x20
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x98

	// Methods

	// RVA: 0x240B80 Offset: 0x23FF80 VA: 0x180240B80 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x240B90 Offset: 0x23FF90 VA: 0x180240B90 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class ServerListMetadata // TypeDefIndex: 6211
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static DateTimeOffset <LastDownloaded>k__BackingField; // 0x3650

	// Properties
	public static DateTimeOffset LastDownloaded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B8E70 Offset: 0x14B7470 VA: 0x1814B8E70
	public static DateTimeOffset get_LastDownloaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B8EC0 Offset: 0x14B74C0 VA: 0x1814B8EC0
	private static void set_LastDownloaded(DateTimeOffset value) { }

	// RVA: 0x14B87A0 Offset: 0x14B6DA0 VA: 0x1814B87A0
	public static void Refresh(bool force = False) { }

	// RVA: 0x14B8D10 Offset: 0x14B7310 VA: 0x1814B8D10
	private static void UpdateMetadata() { }

	// RVA: 0x14B7D80 Offset: 0x14B6380 VA: 0x1814B7D80
	private static void LoadMetadata(string json) { }

	// RVA: 0x14B86F0 Offset: 0x14B6CF0 VA: 0x1814B86F0
	private static void OnUpdated(Dictionary<IPEndPoint, int> metadata) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B8B90 Offset: 0x14B7190 VA: 0x1814B8B90
	internal static bool <LoadMetadata>g__TryParseIPEndPoint|6_0(string value, out IPEndPoint endPoint) { }

}

private sealed class ServerListMetadata.<>c // TypeDefIndex: 6212
{	// Fields
	public static readonly ServerListMetadata.<>c <>9; // 0x0
	public static Action<string> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x14BD160 Offset: 0x14BB760 VA: 0x1814BD160
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BC900 Offset: 0x14BAF00 VA: 0x1814BC900
	internal void <UpdateMetadata>b__5_0(string str) { }

}

public class ServerGib : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6330
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string gibName; // 0x18

	// Methods

	// RVA: 0x1E083F0 Offset: 0x1E069F0 VA: 0x181E083F0
	public static void ResetToPool(ServerGib instance) { }

	// RVA: 0x1E08360 Offset: 0x1E06960 VA: 0x181E08360
	public void ResetToPool() { }

	// RVA: 0x1E08210 Offset: 0x1E06810 VA: 0x181E08210 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67D50 Offset: 0x1D66350 VA: 0x181D67D50
	public void CopyTo(ServerGib instance) { }

	// RVA: 0x1E07870 Offset: 0x1E05E70 VA: 0x181E07870
	public ServerGib Copy() { }

	// RVA: 0x1E08190 Offset: 0x1E06790 VA: 0x181E08190
	public static ServerGib Deserialize(Stream stream) { }

	// RVA: 0x1E07B10 Offset: 0x1E06110 VA: 0x181E07B10
	public static ServerGib DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E07B90 Offset: 0x1E06190 VA: 0x181E07B90
	public static ServerGib DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E07E20 Offset: 0x1E06420 VA: 0x181E07E20
	public static ServerGib Deserialize(byte[] buffer) { }

	// RVA: 0x1E08320 Offset: 0x1E06920 VA: 0x181E08320
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E08860 Offset: 0x1E06E60 VA: 0x181E08860 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E08880 Offset: 0x1E06E80 VA: 0x181E08880 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ServerGib previous) { }

	// RVA: 0x1E08340 Offset: 0x1E06940 VA: 0x181E08340 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E08090 Offset: 0x1E06690 VA: 0x181E08090
	public static ServerGib Deserialize(byte[] buffer, ServerGib instance, bool isDelta = False) { }

	// RVA: 0x1E07F40 Offset: 0x1E06540 VA: 0x181E07F40
	public static ServerGib Deserialize(Stream stream, ServerGib instance, bool isDelta) { }

	// RVA: 0x1E078F0 Offset: 0x1E05EF0 VA: 0x181E078F0
	public static ServerGib DeserializeLengthDelimited(Stream stream, ServerGib instance, bool isDelta) { }

	// RVA: 0x1E07C20 Offset: 0x1E06220 VA: 0x181E07C20
	public static ServerGib DeserializeLength(Stream stream, int length, ServerGib instance, bool isDelta) { }

	// RVA: 0x1E08480 Offset: 0x1E06A80 VA: 0x181E08480
	public static void SerializeDelta(Stream stream, ServerGib instance, ServerGib previous) { }

	// RVA: 0x1E08760 Offset: 0x1E06D60 VA: 0x181E08760
	public static void Serialize(Stream stream, ServerGib instance) { }

	// RVA: 0x1E08850 Offset: 0x1E06E50 VA: 0x181E08850
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E08860 Offset: 0x1E06E60 VA: 0x181E08860
	public void ToProto(Stream stream) { }

	// RVA: 0x1E08650 Offset: 0x1E06C50 VA: 0x181E08650
	public static byte[] SerializeToBytes(ServerGib instance) { }

	// RVA: 0x1E085A0 Offset: 0x1E06BA0 VA: 0x181E085A0
	public static void SerializeLengthDelimited(Stream stream, ServerGib instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public abstract class Server : BaseNetwork // TypeDefIndex: 6703
{	// Fields
	public static ulong MaxPacketsPerSecond; // 0x0
	public static int MaxPacketSize; // 0x8
	public static int MaxConnectionsPerIP; // 0xC
	public static float MaxReceiveTime; // 0x10
	public string ip; // 0x28
	public int port; // 0x30
	public bool compressionEnabled; // 0x34
	public bool logging; // 0x35
	public Manager visibility; // 0x38
	public IServerCallback callbackHandler; // 0x40
	public bool debug; // 0x48
	internal uint lastValueGiven; // 0x4C
	public List<Connection> connections; // 0x50
	private Dictionary<ulong, Connection> connectionByGUID; // 0x58
	private Dictionary<string, List<Connection>> connectionsByIP; // 0x60

	// Properties
	public virtual string ProtocolId { get; }
	public virtual bool AllowPassthroughMessages { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsConnected();

	// RVA: 0x2214670 Offset: 0x2212C70 VA: 0x182214670 Slot: 8
	public virtual string get_ProtocolId() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool get_AllowPassthroughMessages() { }

	// RVA: 0x2214450 Offset: 0x2212A50 VA: 0x182214450
	public void Reset() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 10
	public virtual bool Start() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	public virtual void Stop(string shutdownMsg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void Cycle() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Disconnect(Connection cn);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Kick(Connection cn, string message, bool logfile = False);

	// RVA: 0x2214460 Offset: 0x2212A60 VA: 0x182214460
	public uint TakeUID() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void ReturnUID(uint uid) { }

	// RVA: 0x22142C0 Offset: 0x22128C0 VA: 0x1822142C0
	public void RegisterUID(uint uid) { }

	// RVA: 0x2214450 Offset: 0x2212A50 VA: 0x182214450
	internal void ResetUIDs() { }

	// RVA: 0x2213B60 Offset: 0x2212160 VA: 0x182213B60
	public Networkable CreateNetworkable() { }

	// RVA: 0x2213AC0 Offset: 0x22120C0 VA: 0x182213AC0
	public Networkable CreateNetworkable(uint uid) { }

	// RVA: 0x2213C70 Offset: 0x2212270 VA: 0x182213C70
	public void DestroyNetworkable(ref Networkable networkable) { }

	// RVA: 0x2213DD0 Offset: 0x22123D0 VA: 0x182213DD0
	protected void OnDisconnected(string strReason, Connection cn) { }

	// RVA: 0x2213D00 Offset: 0x2212300 VA: 0x182213D00
	protected Connection FindConnection(ulong guid) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	protected virtual void OnNewConnection() { }

	// RVA: 0x2213D80 Offset: 0x2212380 VA: 0x182213D80
	private string IPAddressWithoutPort(string address) { }

	// RVA: 0x2213FF0 Offset: 0x22125F0 VA: 0x182213FF0 Slot: 16
	protected virtual void OnNewConnection(Connection connection) { }

	// RVA: 0x22142D0 Offset: 0x22128D0 VA: 0x1822142D0
	protected void RemoveConnection(Connection connection) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public virtual int GetAveragePing(Connection connection) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public virtual void SendUnconnected(uint netAddr, ushort netPort, byte[] steamResponseBuffer, int packetSize) { }

	// RVA: 0x2214580 Offset: 0x2212B80 VA: 0x182214580
	protected void .ctor() { }

	// RVA: 0x2214500 Offset: 0x2212B00 VA: 0x182214500
	private static void .cctor() { }

}

public class ServerVar : ConsoleVar // TypeDefIndex: 6891
{	// Methods

	// RVA: 0x22B5740 Offset: 0x22B3D40 VA: 0x1822B5740
	public void .ctor() { }

}

public class ServerUserVar : ConsoleVar // TypeDefIndex: 6892
{	// Methods

	// RVA: 0x22B5720 Offset: 0x22B3D20 VA: 0x1822B5720
	public void .ctor() { }

}

public class ServerAllVar : ConsoleVar // TypeDefIndex: 6893
{	// Methods

	// RVA: 0x22B5700 Offset: 0x22B3D00 VA: 0x1822B5700
	public void .ctor() { }

}

public class Server : Server // TypeDefIndex: 7333
{	// Fields
	private Peer peer; // 0x68

	// Properties
	public override string ProtocolId { get; }
	public override bool AllowPassthroughMessages { get; }

	// Methods

	// RVA: 0x22D1330 Offset: 0x22CF930 VA: 0x1822D1330 Slot: 8
	public override string get_ProtocolId() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 9
	public override bool get_AllowPassthroughMessages() { }

	// RVA: 0xEE6D10 Offset: 0xEE5310 VA: 0x180EE6D10 Slot: 7
	public override bool IsConnected() { }

	// RVA: 0x22D0F20 Offset: 0x22CF520 VA: 0x1822D0F20 Slot: 10
	public override bool Start() { }

	// RVA: 0x22D0FB0 Offset: 0x22CF5B0 VA: 0x1822D0FB0 Slot: 11
	public override void Stop(string shutdownMsg) { }

	// RVA: 0x22D0470 Offset: 0x22CEA70 VA: 0x1822D0470 Slot: 13
	public override void Disconnect(Connection cn) { }

	// RVA: 0x22D0810 Offset: 0x22CEE10 VA: 0x1822D0810 Slot: 14
	public override void Kick(Connection cn, string message, bool logfile) { }

	// RVA: 0x22D05C0 Offset: 0x22CEBC0 VA: 0x1822D05C0
	internal bool HandleRaknetPacket(byte type, Connection connection) { }

	// RVA: 0x22D1110 Offset: 0x22CF710 VA: 0x1822D1110
	internal void UnconnectedPacket() { }

	// RVA: 0x22CFE50 Offset: 0x22CE450 VA: 0x1822CFE50
	internal void ConnectedPacket(Connection connection) { }

	// RVA: 0x22D00E0 Offset: 0x22CE6E0 VA: 0x1822D00E0 Slot: 12
	public override void Cycle() { }

	// RVA: 0x22D09F0 Offset: 0x22CEFF0 VA: 0x1822D09F0 Slot: 15
	protected override void OnNewConnection() { }

	// RVA: 0x22D0510 Offset: 0x22CEB10 VA: 0x1822D0510 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D04D0 Offset: 0x22CEAD0 VA: 0x1822D04D0 Slot: 17
	public override int GetAveragePing(Connection connection) { }

	// RVA: 0x22D05A0 Offset: 0x22CEBA0 VA: 0x1822D05A0 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22D0AF0 Offset: 0x22CF0F0 VA: 0x1822D0AF0 Slot: 18
	public override void SendUnconnected(uint netAddr, ushort netPort, byte[] data, int size) { }

	// RVA: 0x22D0D40 Offset: 0x22CF340 VA: 0x1822D0D40 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22D0BE0 Offset: 0x22CF1E0 VA: 0x1822D0BE0
	private void Send(SendInfo sendinfo, MemoryStream data, Connection connection) { }

	// RVA: 0x22D12D0 Offset: 0x22CF8D0 VA: 0x1822D12D0
	public void .ctor() { }

}

public class ServerConsole : SingletonComponent<ServerConsole> // TypeDefIndex: 9290
{	// Methods

	// RVA: 0x593060 Offset: 0x591660 VA: 0x180593060
	public void .ctor() { }

}

public class ServerGib : BaseCombatEntity // TypeDefIndex: 9605
{	// Fields
	public GameObject _gibSource; // 0x240
	public string _gibName; // 0x248
	public PhysicMaterial physicsMaterial; // 0x250
	private MeshCollider meshCollider; // 0x258
	private MeshFilter meshFilter; // 0x260
	private MeshRenderer meshRenderer; // 0x268
	private bool initialized; // 0x270

	// Methods

	// RVA: 0x593320 Offset: 0x591920 VA: 0x180593320
	public MeshCollider GetCollider() { }

	// RVA: 0x593330 Offset: 0x591930 VA: 0x180593330 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5930D0 Offset: 0x5916D0 VA: 0x1805930D0
	public void ClientSetGib(string newgibname) { }

	// RVA: 0x5930C0 Offset: 0x5916C0 VA: 0x1805930C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x593780 Offset: 0x591D80 VA: 0x180593780
	public void VisualsInit(Mesh mesh, Material[] materials) { }

	// RVA: 0x593390 Offset: 0x591990 VA: 0x180593390 Slot: 145
	public virtual void PhysicsInit(Mesh physicsMesh) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

public class ServerProjectile : EntityComponent<BaseEntity>, IServerComponent // TypeDefIndex: 9682
{	// Fields
	public Vector3 initialVelocity; // 0x20
	public float drag; // 0x2C
	public float gravityModifier; // 0x30
	public float speed; // 0x34
	public float scanRange; // 0x38
	public Vector3 swimScale; // 0x3C
	public Vector3 swimSpeed; // 0x48
	public float radius; // 0x54

	// Properties
	public virtual bool HasRangeLimit { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 10
	public virtual bool get_HasRangeLimit() { }

	// RVA: 0x5941D0 Offset: 0x5927D0 VA: 0x1805941D0
	public float GetMaxRange(float maxFuseTime) { }

	// RVA: 0x5942C0 Offset: 0x5928C0 VA: 0x1805942C0
	public void .ctor() { }

}

public class ServerMgr : SingletonComponent<ServerMgr> // TypeDefIndex: 10712
{
// Namespace: 
public class ServerMgr : SingletonComponent<ServerMgr> // TypeDefIndex: 10712
	// Fields
	public const string BYPASS_PROCEDURAL_SPAWN_PREF = "bypassProceduralSpawn";

	// Methods

	// RVA: 0x594170 Offset: 0x592770 VA: 0x180594170
	public void .ctor() { }

}

public class ServerPerformance : BaseMonoBehaviour // TypeDefIndex: 10713
{	// Fields
	public static ulong deaths; // 0x0
	public static ulong spawns; // 0x8
	public static ulong position_changes; // 0x10

	// Methods

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class ServerBrowser : MonoBehaviour // TypeDefIndex: 11150
{	// Fields
	public string orderBy; // 0x18
	private string searchText; // 0x20
	private bool showFull; // 0x28
	private bool showEmpty; // 0x29
	private HashSet<string> searchTags; // 0x30
	private HashSet<string> excludeTags; // 0x38

	// Methods

	// RVA: 0x592860 Offset: 0x590E60 VA: 0x180592860
	private void OnEnable() { }

	// RVA: 0x592770 Offset: 0x590D70 VA: 0x180592770
	private void OnDisable() { }

	// RVA: 0x592950 Offset: 0x590F50 VA: 0x180592950
	private void OnOpenStateChanged() { }

	// RVA: 0x5929C0 Offset: 0x590FC0 VA: 0x1805929C0
	public void RefreshAll() { }

	// RVA: 0x592650 Offset: 0x590C50 VA: 0x180592650
	private void ClearAll() { }

	// RVA: 0x592AF0 Offset: 0x5910F0 VA: 0x180592AF0
	public void SetOrder(string strBy) { }

	// RVA: 0x592E40 Offset: 0x591440 VA: 0x180592E40
	public void SetShowFull(bool showFull) { }

	// RVA: 0x592D70 Offset: 0x591370 VA: 0x180592D70
	public void SetShowEmpty(bool showFull) { }

	// RVA: 0x592C80 Offset: 0x591280 VA: 0x180592C80
	public void SetSearchFilter(string txt) { }

	// RVA: 0x592F10 Offset: 0x591510 VA: 0x180592F10
	public void SetTagsFilter(ServerBrowserTagFilters tagFilters) { }

	// RVA: 0x593000 Offset: 0x591600 VA: 0x180593000
	public void .ctor() { }

}

public class ServerBrowserCategory : MonoBehaviour // TypeDefIndex: 11151
{	// Fields
	public LocalizeText serverCountText; // 0x18
	public ServerBrowserList browserList; // 0x20
	public bool isDirty; // 0x28

	// Methods

	// RVA: 0x4A04D0 Offset: 0x49EAD0 VA: 0x1804A04D0
	public void OnEnable() { }

	// RVA: 0x58C870 Offset: 0x58AE70 VA: 0x18058C870
	public void Update() { }

	// RVA: 0x4A04D0 Offset: 0x49EAD0 VA: 0x1804A04D0
	public void Dirty() { }

	// RVA: 0x58C5E0 Offset: 0x58ABE0 VA: 0x18058C5E0
	public void UpdateCounts() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class ServerBrowserCategory.<>c // TypeDefIndex: 11152
{	// Fields
	public static readonly ServerBrowserCategory.<>c <>9; // 0x0
	public static Func<ServerInfo, int> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x5A4CA0 Offset: 0x5A32A0 VA: 0x1805A4CA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A47E0 Offset: 0x5A2DE0 VA: 0x1805A47E0
	internal int <UpdateCounts>b__6_0(ServerInfo x) { }

}

public class ServerBrowserInfo : SingletonComponent<ServerBrowserInfo> // TypeDefIndex: 11153
{	// Fields
	public bool isMain; // 0x18
	public Text serverName; // 0x20
	public Text serverMeta; // 0x28
	public Text serverText; // 0x30
	public Button viewWebpage; // 0x38
	public Button refresh; // 0x40
	public Nullable<ServerInfo> currentServer; // 0x48
	public HttpImage headerImage; // 0xC8
	public HttpImage logoImage; // 0xD0
	private string weburl; // 0xD8
	private Texture loadedTexture; // 0xE0
	private string descriptionText; // 0xE8

	// Methods

	// RVA: 0x58D6B0 Offset: 0x58BCB0 VA: 0x18058D6B0 Slot: 4
	public override void SingletonSetup() { }

	// RVA: 0x58CEE0 Offset: 0x58B4E0 VA: 0x18058CEE0
	public void Open(ServerInfo server) { }

	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	public void Close() { }

	// RVA: 0x58CA80 Offset: 0x58B080 VA: 0x18058CA80
	public void JoinServer() { }

	// RVA: 0x58C8C0 Offset: 0x58AEC0 VA: 0x18058C8C0
	public void JoinDelayed() { }

	// RVA: 0x58CD70 Offset: 0x58B370 VA: 0x18058CD70
	public static void Join(ServerInfo server) { }

	// RVA: 0x58D110 Offset: 0x58B710 VA: 0x18058D110
	public void Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x9A0C0 Offset: 0x994C0 VA: 0x18009A0C0
	// RVA: 0x58D040 Offset: 0x58B640 VA: 0x18058D040
	private void QueryRules() { }

	// RVA: 0x58C890 Offset: 0x58AE90 VA: 0x18058C890
	private void EnableRefreshButton() { }

	// RVA: 0x58D700 Offset: 0x58BD00 VA: 0x18058D700
	public void VisitWebpage() { }

	// RVA: 0x58D710 Offset: 0x58BD10 VA: 0x18058D710
	public void .ctor() { }

}

private struct ServerBrowserInfo.<QueryRules>d__19 : IAsyncStateMachine // TypeDefIndex: 11154
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ServerBrowserInfo <>4__this; // 0x28
	private bool <loadedImage>5__2; // 0x30
	private bool <loadedLogo>5__3; // 0x31
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x38

	// Methods

	// RVA: 0xF33B0 Offset: 0xF27B0 VA: 0x1800F33B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ServerBrowserItem : MonoBehaviour // TypeDefIndex: 11155
{	// Fields
	public TextMeshProUGUI serverName; // 0x18
	public RustText mapName; // 0x20
	public TextMeshProUGUI playerCount; // 0x28
	public TextMeshProUGUI ping; // 0x30
	public Toggle favourited; // 0x38
	public ServerBrowserTagList serverTagList; // 0x40
	private static RealTimeSince timeSinceGotFriendServers; // 0x0
	private static Dictionary<string, string> friendsOnServers; // 0x8
	private static RealTimeSince timeSinceGotFavouriteServers; // 0x10
	private static HashSet<string> favorites; // 0x18
	private ServerInfo serverInfo; // 0x48
	internal bool preventFavouriteToggle; // 0xC0

	// Methods

	// RVA: 0x58D770 Offset: 0x58BD70 VA: 0x18058D770
	private static string GetFriendOnServer(IPAddress addr, int port) { }

	// RVA: 0x58DD70 Offset: 0x58C370 VA: 0x18058DD70
	private static bool GetIsFavourite(IPAddress addr, int port) { }

	// RVA: 0x58DFB0 Offset: 0x58C5B0 VA: 0x18058DFB0
	internal void Init(ServerInfo s, bool isFavourites, bool isHistory) { }

	// RVA: 0x58E510 Offset: 0x58CB10 VA: 0x18058E510
	public void OnClicked() { }

	// RVA: 0x58E690 Offset: 0x58CC90 VA: 0x18058E690
	public void OnFavouriteToggle(bool favourite) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class ServerBrowserItem.<>c // TypeDefIndex: 11156
{	// Fields
	public static readonly ServerBrowserItem.<>c <>9; // 0x0
	public static Func<IPlayerInfo, bool> <>9__8_0; // 0x8
	public static Func<IPlayerInfo, bool> <>9__8_1; // 0x10
	public static Func<IPlayerInfo, bool> <>9__8_2; // 0x18
	public static Func<IPlayerInfo, string> <>9__8_3; // 0x20
	public static Func<IGrouping<string, IPlayerInfo>, string> <>9__8_4; // 0x28
	public static Func<IPlayerInfo, string> <>9__8_6; // 0x30
	public static Func<IGrouping<string, IPlayerInfo>, string> <>9__8_5; // 0x38
	public static Func<ServerInfo, string> <>9__11_0; // 0x40

	// Methods

	// RVA: 0x5A4B20 Offset: 0x5A3120 VA: 0x1805A4B20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A44A0 Offset: 0x5A2AA0 VA: 0x1805A44A0
	internal bool <GetFriendOnServer>b__8_0(IPlayerInfo x) { }

	// RVA: 0x5A44F0 Offset: 0x5A2AF0 VA: 0x1805A44F0
	internal bool <GetFriendOnServer>b__8_1(IPlayerInfo x) { }

	// RVA: 0x5A4540 Offset: 0x5A2B40 VA: 0x1805A4540
	internal bool <GetFriendOnServer>b__8_2(IPlayerInfo x) { }

	// RVA: 0x5A45A0 Offset: 0x5A2BA0 VA: 0x1805A45A0
	internal string <GetFriendOnServer>b__8_3(IPlayerInfo x) { }

	// RVA: 0x5A45F0 Offset: 0x5A2BF0 VA: 0x1805A45F0
	internal string <GetFriendOnServer>b__8_4(IGrouping<string, IPlayerInfo> x) { }

	// RVA: 0x5A4640 Offset: 0x5A2C40 VA: 0x1805A4640
	internal string <GetFriendOnServer>b__8_5(IGrouping<string, IPlayerInfo> x) { }

	// RVA: 0x5A4750 Offset: 0x5A2D50 VA: 0x1805A4750
	internal string <GetFriendOnServer>b__8_6(IPlayerInfo y) { }

	// RVA: 0x5A4760 Offset: 0x5A2D60 VA: 0x1805A4760
	internal string <GetIsFavourite>b__11_0(ServerInfo x) { }

}

public class ServerBrowserList : BaseMonoBehaviour, VirtualScroll.IDataSource // TypeDefIndex: 11157
{	// Fields
	public ServerBrowserList.QueryType queryType; // 0x18
	public static string VersionTag; // 0x0
	public ServerBrowserList.ServerKeyvalues[] keyValues; // 0x20
	private IServerQuery Request; // 0x28
	internal int servers; // 0x30
	internal int players; // 0x34
	public bool shouldShowSecureServers; // 0x38
	private HashSet<IPEndPoint> officialServers; // 0x40
	public ServerBrowserCategory categoryButton; // 0x48
	public bool startActive; // 0x50
	public Transform listTransform; // 0x58
	public int refreshOrder; // 0x60
	public bool UseOfficialServers; // 0x64
	public VirtualScroll VirtualScroll; // 0x68
	public ServerBrowserList.Rules[] rules; // 0x70
	public bool hideOfficialServers; // 0x78
	public bool excludeEmptyServersUsingQuery; // 0x79
	public bool alwaysIncludeEmptyServers; // 0x7A
	public bool clampPlayerCountsToTrustedValues; // 0x7B
	internal bool isDirty; // 0x7C
	private string searchFilter; // 0x80
	private bool showFull; // 0x88
	private bool showEmpty; // 0x89
	private HashSet<string> searchTags; // 0x90
	private HashSet<string> excludeTags; // 0x98
	private List<ServerInfo> serverList; // 0xA0
	private List<ServerInfo> serverListSortedFiltered; // 0xA8
	public string sortOrder; // 0xB0
	private RealTimeSince timeSinceRebuild; // 0xB8

	// Methods

	// RVA: 0x58FA80 Offset: 0x58E080 VA: 0x18058FA80
	public bool IsCheater() { }

	// RVA: 0x58FD50 Offset: 0x58E350 VA: 0x18058FD50
	public void Refresh() { }

	// RVA: 0x590C30 Offset: 0x58F230 VA: 0x180590C30
	private void ServerResponded(ServerInfo server) { }

	// RVA: 0x58F970 Offset: 0x58DF70 VA: 0x18058F970
	public void InitFilters(string searchFilter, bool showFull, bool showEmpty, HashSet<string> searchTags, HashSet<string> excludeTags) { }

	// RVA: 0x58F9E0 Offset: 0x58DFE0 VA: 0x18058F9E0
	public void Init() { }

	// RVA: 0x58FBA0 Offset: 0x58E1A0 VA: 0x18058FBA0
	public void OnEnable() { }

	// RVA: 0x58FB50 Offset: 0x58E150 VA: 0x18058FB50
	public void OnDisable() { }

	// RVA: 0x58EC20 Offset: 0x58D220 VA: 0x18058EC20
	public void Clear() { }

	// RVA: 0x58E880 Offset: 0x58CE80 VA: 0x18058E880
	public void AddServer(ServerInfo server) { }

	// RVA: 0x58FCC0 Offset: 0x58E2C0 VA: 0x18058FCC0
	public void Rebuild() { }

	// RVA: 0x58ECF0 Offset: 0x58D2F0 VA: 0x18058ECF0
	internal IOrderedEnumerable<ServerInfo> GetSortedServers() { }

	// RVA: 0x5916D0 Offset: 0x58FCD0 VA: 0x1805916D0
	public void Update() { }

	// RVA: 0x590AA0 Offset: 0x58F0A0 VA: 0x180590AA0
	public void SearchFilter(string searchtext, bool showFull, bool showEmpty, HashSet<string> searchTags, HashSet<string> excludeTags) { }

	// RVA: 0x58FC90 Offset: 0x58E290 VA: 0x18058FC90
	public void OrderBy(string strBy) { }

	// RVA: 0x591440 Offset: 0x58FA40 VA: 0x180591440
	private void UpdateAllPlayerClamps() { }

	// RVA: 0x58EB10 Offset: 0x58D110 VA: 0x18058EB10
	private static ServerInfo ClampPlayerCount(in ServerInfo server, int maxAllowedPlayers) { }

	// RVA: 0x58ECB0 Offset: 0x58D2B0 VA: 0x18058ECB0 Slot: 6
	public int GetItemCount() { }

	// RVA: 0x591310 Offset: 0x58F910 VA: 0x180591310 Slot: 7
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x591790 Offset: 0x58FD90 VA: 0x180591790
	public void .ctor() { }

	// RVA: 0x591720 Offset: 0x58FD20 VA: 0x180591720
	private static void .cctor() { }

}

public enum ServerBrowserList.QueryType // TypeDefIndex: 11158
{	// Fields
	public int value__; // 0x0
	public const ServerBrowserList.QueryType RegularInternet = 0;
	public const ServerBrowserList.QueryType Friends = 1;
	public const ServerBrowserList.QueryType History = 2;
	public const ServerBrowserList.QueryType LAN = 3;
	public const ServerBrowserList.QueryType Favourites = 4;
	public const ServerBrowserList.QueryType None = 5;

}

public struct ServerBrowserList.ServerKeyvalues // TypeDefIndex: 11159
{	// Fields
	public string key; // 0x0
	public string value; // 0x8

}

public struct ServerBrowserList.Rules // TypeDefIndex: 11160
{	// Fields
	public string tag; // 0x0
	public ServerBrowserList serverList; // 0x8

}

private sealed class ServerBrowserList.<>c // TypeDefIndex: 11161
{	// Fields
	public static readonly ServerBrowserList.<>c <>9; // 0x0
	public static Func<Manifest.ServerDesc, string> <>9__11_0; // 0x8
	public static Func<ServerInfo, bool> <>9__41_1; // 0x10
	public static Func<ServerInfo, bool> <>9__41_2; // 0x18
	public static Func<ServerInfo, int> <>9__41_3; // 0x20
	public static Func<ServerInfo, uint> <>9__41_5; // 0x28
	public static Func<ServerInfo, uint> <>9__41_7; // 0x30
	public static Func<ServerInfo, bool> <>9__41_8; // 0x38
	public static Func<ServerInfo, uint> <>9__41_9; // 0x40
	public static Func<ServerInfo, bool> <>9__41_10; // 0x48
	public static Func<ServerInfo, uint> <>9__41_11; // 0x50
	public static Func<ServerInfo, string> <>9__41_12; // 0x58
	public static Func<ServerInfo, string> <>9__41_13; // 0x60
	public static Func<ServerInfo, int> <>9__41_14; // 0x68
	public static Func<ServerInfo, int> <>9__41_15; // 0x70
	public static Func<ServerInfo, int> <>9__41_16; // 0x78

	// Methods

	// RVA: 0x5A4B80 Offset: 0x5A3180 VA: 0x1805A4B80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A48A0 Offset: 0x5A2EA0 VA: 0x1805A48A0
	internal string <Refresh>b__11_0(Manifest.ServerDesc x) { }

	// RVA: 0x5A4800 Offset: 0x5A2E00 VA: 0x1805A4800
	internal bool <GetSortedServers>b__41_1(ServerInfo x) { }

	// RVA: 0x5A4810 Offset: 0x5A2E10 VA: 0x1805A4810
	internal bool <GetSortedServers>b__41_2(ServerInfo x) { }

	// RVA: 0x5A47F0 Offset: 0x5A2DF0 VA: 0x1805A47F0
	internal int <GetSortedServers>b__41_3(ServerInfo x) { }

	// RVA: 0x5A4820 Offset: 0x5A2E20 VA: 0x1805A4820
	internal uint <GetSortedServers>b__41_5(ServerInfo x) { }

	// RVA: 0x5A4820 Offset: 0x5A2E20 VA: 0x1805A4820
	internal uint <GetSortedServers>b__41_7(ServerInfo x) { }

	// RVA: 0x5A47C0 Offset: 0x5A2DC0 VA: 0x1805A47C0
	internal bool <GetSortedServers>b__41_8(ServerInfo x) { }

	// RVA: 0x5A47D0 Offset: 0x5A2DD0 VA: 0x1805A47D0
	internal uint <GetSortedServers>b__41_9(ServerInfo x) { }

	// RVA: 0x5A47C0 Offset: 0x5A2DC0 VA: 0x1805A47C0
	internal bool <GetSortedServers>b__41_10(ServerInfo x) { }

	// RVA: 0x5A47D0 Offset: 0x5A2DD0 VA: 0x1805A47D0
	internal uint <GetSortedServers>b__41_11(ServerInfo x) { }

	// RVA: 0x4D1C30 Offset: 0x4D0230 VA: 0x1804D1C30
	internal string <GetSortedServers>b__41_12(ServerInfo x) { }

	// RVA: 0x4D1C30 Offset: 0x4D0230 VA: 0x1804D1C30
	internal string <GetSortedServers>b__41_13(ServerInfo x) { }

	// RVA: 0x5A47E0 Offset: 0x5A2DE0 VA: 0x1805A47E0
	internal int <GetSortedServers>b__41_14(ServerInfo x) { }

	// RVA: 0x5A47E0 Offset: 0x5A2DE0 VA: 0x1805A47E0
	internal int <GetSortedServers>b__41_15(ServerInfo x) { }

	// RVA: 0x5A47F0 Offset: 0x5A2DF0 VA: 0x1805A47F0
	internal int <GetSortedServers>b__41_16(ServerInfo x) { }

}

private sealed class ServerBrowserList.<>c__DisplayClass12_0 // TypeDefIndex: 11162
{	// Fields
	public ServerBrowserList.Rules rule; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4910 Offset: 0x5A2F10 VA: 0x1805A4910
	internal bool <ServerResponded>b__0(string x) { }

}

private sealed class ServerBrowserList.<>c__DisplayClass41_0 // TypeDefIndex: 11163
{	// Fields
	public ServerBrowserList <>4__this; // 0x10
	public int now; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A49C0 Offset: 0x5A2FC0 VA: 0x1805A49C0
	internal bool <GetSortedServers>b__0(ServerInfo x) { }

	// RVA: 0x5A4AA0 Offset: 0x5A30A0 VA: 0x1805A4AA0
	internal bool <GetSortedServers>b__4(ServerInfo x) { }

	// RVA: 0x5A4AA0 Offset: 0x5A30A0 VA: 0x1805A4AA0
	internal bool <GetSortedServers>b__6(ServerInfo x) { }

}

public class ServerBrowserTag : MonoBehaviour // TypeDefIndex: 11164
{	// Fields
	public string[] serverHasAnyOf; // 0x18
	public string[] serverHasNoneOf; // 0x20
	public bool isToggleable; // 0x28
	public Color activeColor; // 0x2C
	public Color inactiveColor; // 0x3C
	public Image background; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsActive>k__BackingField; // 0x58

	// Properties
	public bool IsActive { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	private void set_IsActive(bool value) { }

	// RVA: 0x5923A0 Offset: 0x5909A0 VA: 0x1805923A0
	public void OnEnable() { }

	// RVA: 0x592470 Offset: 0x590A70 VA: 0x180592470
	public bool Test(in ServerInfo serverInfo) { }

	// RVA: 0x5925A0 Offset: 0x590BA0 VA: 0x1805925A0
	public void Toggle() { }

	// RVA: 0x5923B0 Offset: 0x5909B0 VA: 0x1805923B0
	private void Refresh() { }

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public void .ctor() { }

}

public class ServerBrowserTagFilters : MonoBehaviour // TypeDefIndex: 11165
{	// Fields
	public RustButton Button; // 0x18
	public RectTransform OptionsParent; // 0x20
	public UnityEvent TagFiltersChanged; // 0x28
	private ServerBrowserTag[] _allTags; // 0x30
	private List<bool> _previousState; // 0x38

	// Methods

	// RVA: 0x591F40 Offset: 0x590540 VA: 0x180591F40
	public void Start() { }

	// RVA: 0x591EB0 Offset: 0x5904B0 VA: 0x180591EB0
	public void Open() { }

	// RVA: 0x591880 Offset: 0x58FE80 VA: 0x180591880
	public void Close() { }

	// RVA: 0x591C80 Offset: 0x590280 VA: 0x180591C80
	public void GetTags(out HashSet<string> searchTags, out HashSet<string> excludeTags) { }

	// RVA: 0x591B70 Offset: 0x590170 VA: 0x180591B70
	private List<bool> GetCurrentSelections() { }

	// RVA: 0x5921A0 Offset: 0x5907A0 VA: 0x1805921A0
	public void .ctor() { }

}

private sealed class ServerBrowserTagFilters.<>c // TypeDefIndex: 11166
{	// Fields
	public static readonly ServerBrowserTagFilters.<>c <>9; // 0x0
	public static Func<bool, bool> <>9__7_0; // 0x8
	public static Func<ServerBrowserTag, bool> <>9__9_0; // 0x10

	// Methods

	// RVA: 0x5A4BE0 Offset: 0x5A31E0 VA: 0x1805A4BE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4410 Offset: 0x5A2A10 VA: 0x1805A4410
	internal bool <Close>b__7_0(bool b) { }

	// RVA: 0x5A4480 Offset: 0x5A2A80 VA: 0x1805A4480
	internal bool <GetCurrentSelections>b__9_0(ServerBrowserTag t) { }

}

public class ServerBrowserTagList : MonoBehaviour // TypeDefIndex: 11167
{	// Fields
	private ServerBrowserTag[] _allTags; // 0x18

	// Methods

	// RVA: 0x592210 Offset: 0x590810 VA: 0x180592210
	private void Initialize() { }

	// RVA: 0x592210 Offset: 0x590810 VA: 0x180592210
	public void Awake() { }

	// RVA: 0x592270 Offset: 0x590870 VA: 0x180592270
	public bool Refresh(ServerInfo server) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerHistory : MonoBehaviour // TypeDefIndex: 11168
{	// Fields
	public ServerHistoryItem prefab; // 0x18
	public GameObject panelList; // 0x20
	internal IServerQuery Request; // 0x28

	// Methods

	// RVA: 0x593E20 Offset: 0x592420 VA: 0x180593E20
	private void Start() { }

	[AsyncStateMachineAttribute] // RVA: 0x9AE90 Offset: 0x9A290 VA: 0x18009AE90
	// RVA: 0x593E20 Offset: 0x592420 VA: 0x180593E20
	public Task Refresh() { }

	// RVA: 0x593BB0 Offset: 0x5921B0 VA: 0x180593BB0
	private void OnServer(ServerInfo server) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private struct ServerHistory.<Refresh>d__4 : IAsyncStateMachine // TypeDefIndex: 11169
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ServerHistory <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0xF3490 Offset: 0xF2890 VA: 0x1800F3490 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class ServerHistory.<>c // TypeDefIndex: 11170
{	// Fields
	public static readonly ServerHistory.<>c <>9; // 0x0
	public static Func<Transform, object> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x5A4D00 Offset: 0x5A3300 VA: 0x1805A4D00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4830 Offset: 0x5A2E30 VA: 0x1805A4830
	internal object <OnServer>b__5_0(Transform x) { }

}

public class ServerHistoryItem : MonoBehaviour // TypeDefIndex: 11171
{	// Fields
	private ServerInfo serverInfo; // 0x18
	public Text serverName; // 0x90
	public Text players; // 0x98
	public Text lastJoinDate; // 0xA0
	public uint order; // 0xA8

	// Methods

	// RVA: 0x593940 Offset: 0x591F40 VA: 0x180593940
	internal void Setup(ServerInfo s) { }

	// RVA: 0x593870 Offset: 0x591E70 VA: 0x180593870
	public void Open() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public static class ServerInfoHelpers // TypeDefIndex: 11172
{	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x9B3B0 Offset: 0x9A7B0 VA: 0x18009B3B0
	// RVA: 0x594050 Offset: 0x592650 VA: 0x180594050
	public static Task<Nullable<ServerInfo>> Load(string address, int port) { }

	[AsyncStateMachineAttribute] // RVA: 0x9B400 Offset: 0x9A800 VA: 0x18009B400
	// RVA: 0x593F10 Offset: 0x592510 VA: 0x180593F10
	public static Task<Dictionary<string, string>> LoadRules(ServerInfo serverInfo) { }

}

private struct ServerInfoHelpers.<Load>d__0 : IAsyncStateMachine // TypeDefIndex: 11173
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<ServerInfo>> <>t__builder; // 0x8
	public string address; // 0x20
	public int port; // 0x28
	private List<string> <endpointSet>5__2; // 0x30
	private int <i>5__3; // 0x38
	private IServerQuery <query>5__4; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0xF3350 Offset: 0xF2750 VA: 0x1800F3350 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3360 Offset: 0xF2760 VA: 0x1800F3360 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ServerInfoHelpers.<LoadRules>d__1 : IAsyncStateMachine // TypeDefIndex: 11174
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo serverInfo; // 0x20
	private Dictionary<string, string> <rules>5__2; // 0x98
	private int <i>5__3; // 0xA0
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0xA8
	private TaskAwaiter <>u__2; // 0xB0

	// Methods

	// RVA: 0xF32F0 Offset: 0xF26F0 VA: 0x1800F32F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3300 Offset: 0xF2700 VA: 0x1800F3300 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class Server // TypeDefIndex: 11651
{	// Fields
	public const byte Default = 0;
	public const byte Positions = 14;

}

public class Server : ConsoleSystem // TypeDefIndex: 11960
{	// Fields
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static string ip; // 0x0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int port; // 0x8
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int queryport; // 0xC
	[ServerVar] // RVA: 0xB4620 Offset: 0xB3A20 VA: 0x1800B4620
	public static int maxplayers; // 0x10
	[ServerVar] // RVA: 0xB4620 Offset: 0xB3A20 VA: 0x1800B4620
	public static string hostname; // 0x18
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static string identity; // 0x20
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static string level; // 0x28
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static string levelurl; // 0x30
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool leveltransfer; // 0x38
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int seed; // 0x3C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int salt; // 0x40
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int worldsize; // 0x44
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int saveinterval; // 0x48
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool secure; // 0x4C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int encryption; // 0x50
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int tickrate; // 0x54
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int entityrate; // 0x58
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float schematime; // 0x5C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float cycletime; // 0x60
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool official; // 0x64
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool stats; // 0x65
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool globalchat; // 0x66
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool stability; // 0x67
	[ServerVar] // RVA: 0xB4620 Offset: 0xB3A20 VA: 0x1800B4620
	public static bool radiation; // 0x68
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float itemdespawn; // 0x6C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float itemdespawn_quick; // 0x70
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float corpsedespawn; // 0x74
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float debrisdespawn; // 0x78
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool pve; // 0x7C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool cinematic; // 0x7D
	[ServerVar] // RVA: 0xB4620 Offset: 0xB3A20 VA: 0x1800B4620
	public static string description; // 0x80
	[ServerVar] // RVA: 0xB4620 Offset: 0xB3A20 VA: 0x1800B4620
	public static string url; // 0x88
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static string branch; // 0x90
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int queriesPerSecond; // 0x98
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int ipQueriesPerMin; // 0x9C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool statBackup; // 0xA0
	[ServerVar] // RVA: 0xB8940 Offset: 0xB7D40 VA: 0x1800B8940
	public static string headerimage; // 0xA8
	[ServerVar] // RVA: 0xB8940 Offset: 0xB7D40 VA: 0x1800B8940
	public static string logoimage; // 0xB0
	[ServerVar] // RVA: 0xB8940 Offset: 0xB7D40 VA: 0x1800B8940
	public static int saveBackupCount; // 0xB8
	[ReplicatedVar] // RVA: 0xB8AA0 Offset: 0xB7EA0 VA: 0x1800B8AA0
	public static string motd; // 0xC0
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float meleedamage; // 0xC8
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float arrowdamage; // 0xCC
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float bulletdamage; // 0xD0
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float bleedingdamage; // 0xD4
	[ReplicatedVar] // RVA: 0x858A0 Offset: 0x84CA0 VA: 0x1800858A0
	public static float funWaterDamageThreshold; // 0xD8
	[ReplicatedVar] // RVA: 0x858A0 Offset: 0x84CA0 VA: 0x1800858A0
	public static float funWaterWetnessGain; // 0xDC
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float meleearmor; // 0xE0
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float arrowarmor; // 0xE4
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float bulletarmor; // 0xE8
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float bleedingarmor; // 0xEC
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int updatebatch; // 0xF0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int updatebatchspawn; // 0xF4
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int entitybatchsize; // 0xF8
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float entitybatchtime; // 0xFC
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float composterUpdateInterval; // 0x100
	[ReplicatedVar] // RVA: 0xA99C0 Offset: 0xA8DC0 VA: 0x1800A99C0
	public static float planttick; // 0x104
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float planttickscale; // 0x108
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool useMinimumPlantCondition; // 0x10C
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float nonPlanterDeathChancePerTick; // 0x110
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float ceilingLightGrowableRange; // 0x114
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float artificialTemperatureGrowableRange; // 0x118
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float ceilingLightHeightOffset; // 0x11C
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float sprinklerRadius; // 0x120
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float sprinklerEyeHeightOffset; // 0x124
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float optimalPlanterQualitySaturation; // 0x128
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float metabolismtick; // 0x12C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float modifierTickRate; // 0x130
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static float rewounddelay; // 0x134
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static bool woundingenabled; // 0x138
	[ServerVar] // RVA: 0xB9EF0 Offset: 0xB92F0 VA: 0x1800B9EF0
	public static float woundedrecoverchance; // 0x13C
	[ServerVar] // RVA: 0xBA020 Offset: 0xB9420 VA: 0x1800BA020
	public static float incapacitatedrecoverchance; // 0x140
	[ServerVar] // RVA: 0xBB410 Offset: 0xBA810 VA: 0x1800BB410
	public static float woundedmaxfoodandwaterbonus; // 0x144
	[ServerVar] // RVA: 0xBB5B0 Offset: 0xBA9B0 VA: 0x1800BB5B0
	public static int crawlingminimumhealth; // 0x148
	[ServerVar] // RVA: 0xBB750 Offset: 0xBAB50 VA: 0x1800BB750
	public static int crawlingmaximumhealth; // 0x14C
	[ServerVar] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public static bool playerserverfall; // 0x150
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool plantlightdetection; // 0x151
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float respawnresetrange; // 0x154
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int maxunack; // 0x158
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool netcache; // 0x15C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool corpses; // 0x15D
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool events; // 0x15E
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool dropitems; // 0x15F
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int netcachesize; // 0x160
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int savecachesize; // 0x164
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int combatlogsize; // 0x168
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int combatlogdelay; // 0x16C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int authtimeout; // 0x170
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int playertimeout; // 0x174
	[ServerVar] // RVA: 0xB4620 Offset: 0xB3A20 VA: 0x1800B4620
	public static int idlekick; // 0x178
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int idlekickmode; // 0x17C
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int idlekickadmins; // 0x180
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static string gamemode; // 0x188
	[ServerVar] // RVA: 0xBC440 Offset: 0xBB840 VA: 0x1800BC440
	public static string tags; // 0x190
	[ServerVar] // RVA: 0xBC760 Offset: 0xBBB60 VA: 0x1800BC760
	public static bool censorplayerlist; // 0x198
	[ServerVar] // RVA: 0xBDB20 Offset: 0xBCF20 VA: 0x1800BDB20
	public static string bansServerEndpoint; // 0x1A0
	[ServerVar] // RVA: 0xBDCB0 Offset: 0xBD0B0 VA: 0x1800BDCB0
	public static int bansServerFailureMode; // 0x1A8
	[ServerVar] // RVA: 0xBDD40 Offset: 0xBD140 VA: 0x1800BDD40
	public static int bansServerTimeout; // 0x1AC
	[ServerVar] // RVA: 0xBDE20 Offset: 0xBD220 VA: 0x1800BDE20
	public static string reportsServerEndpoint; // 0x1B0
	[ServerVar] // RVA: 0xBDF90 Offset: 0xBD390 VA: 0x1800BDF90
	public static string reportsServerEndpointKey; // 0x1B8
	[ServerVar] // RVA: 0xBE100 Offset: 0xBD500 VA: 0x1800BE100
	public static bool printReportsToConsole; // 0x1C0

	// Methods

	// RVA: 0x36AB00 Offset: 0x369100 VA: 0x18036AB00
	public static float TickDelta() { }

	// RVA: 0x36AB70 Offset: 0x369170 VA: 0x18036AB70
	public static float TickTime(uint tick) { }

	// RVA: 0x36B5E0 Offset: 0x369BE0 VA: 0x18036B5E0
	public void .ctor() { }

	// RVA: 0x36AC40 Offset: 0x369240 VA: 0x18036AC40
	private static void .cctor() { }

}

