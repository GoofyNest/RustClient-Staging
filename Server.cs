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

	// RVA: 0x1203E20 Offset: 0x1202420 VA: 0x181203E20
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public Type get_ObjectType() { }

	// RVA: 0x1203C90 Offset: 0x1202290 VA: 0x181203C90
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x1203C80 Offset: 0x1202280 VA: 0x181203C80 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x1203A10 Offset: 0x1202010 VA: 0x181203A10 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x12038C0 Offset: 0x1201EC0 VA: 0x1812038C0
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public Lease get_Lease() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public Context get_Context() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	// RVA: 0x1203BE0 Offset: 0x12021E0 VA: 0x181203BE0
	protected void DisposeServerObject() { }

}

internal class ServerContextTerminatorSink : IMessageSink // TypeDefIndex: 1259
{	// Methods

	// RVA: 0x148C210 Offset: 0x148A810 VA: 0x18148C210 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x148C100 Offset: 0x148A700 VA: 0x18148C100 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 1260
{	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x148C6B0 Offset: 0x148ACB0 VA: 0x18148C6B0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x148C490 Offset: 0x148AA90 VA: 0x18148C490 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 1261
{	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0xFDD0C0 Offset: 0xFDB6C0 VA: 0x180FDD0C0
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x148C3D0 Offset: 0x148A9D0 VA: 0x18148C3D0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x148C380 Offset: 0x148A980 VA: 0x18148C380 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal sealed class ServerCertValidationCallbackWrapper : MulticastDelegate // TypeDefIndex: 2542
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFFC390 Offset: 0xFFA990 VA: 0x180FFC390 Slot: 12
	public virtual bool Invoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x121C510 Offset: 0x121AB10 VA: 0x18121C510 Slot: 13
	public virtual IAsyncResult BeginInvoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback __callback, object object) { }

	// RVA: 0xFF6FB0 Offset: 0xFF55B0 VA: 0x180FF6FB0 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

internal class ServerCertValidationCallback // TypeDefIndex: 2985
{	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0xFFDD50 Offset: 0xFFC350 VA: 0x180FFDD50
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0xFFDB40 Offset: 0xFFC140 VA: 0x180FFDB40
	internal void Callback(object state) { }

	// RVA: 0xFFDC00 Offset: 0xFFC200 VA: 0x180FFDC00
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

	// RVA: 0xFF7C20 Offset: 0xFF6220 VA: 0x180FF7C20
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

public struct ServerInfo : IEquatable<ServerInfo> // TypeDefIndex: 5557
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Ping>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <GameDir>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Map>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Description>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <AppId>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Players>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <MaxPlayers>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <BotPlayers>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Passworded>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Secure>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <LastTimePlayed>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Version>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <TagString>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <SteamId>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <AddressRaw>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IPAddress <Address>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ConnectionPort>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	public void set_Name(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	public int get_Ping() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DC40 Offset: 0x19D040 VA: 0x18019DC40
	public void set_Ping(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1470 Offset: 0xF0870 VA: 0x1800F1470
	public void set_GameDir(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	public string get_Map() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1480 Offset: 0xF0880 VA: 0x1800F1480
	public void set_Map(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF14E0 Offset: 0xF08E0 VA: 0x1800F14E0
	public void set_Description(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xF3ED0 Offset: 0xF32D0 VA: 0x1800F3ED0
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3F00 Offset: 0xF3300 VA: 0x1800F3F00
	public void set_AppId(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D8C90 Offset: 0x1D8090 VA: 0x1801D8C90
	public int get_Players() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8D20 Offset: 0x1D8120 VA: 0x1801D8D20
	public void set_Players(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D16B0 Offset: 0x1D0AB0 VA: 0x1801D16B0
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8D10 Offset: 0x1D8110 VA: 0x1801D8D10
	public void set_MaxPlayers(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8CE0 Offset: 0x1D80E0 VA: 0x1801D8CE0
	public void set_BotPlayers(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D2E20 Offset: 0x1D2220 VA: 0x1801D2E20
	public void set_Passworded(bool value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D8CB0 Offset: 0x1D80B0 VA: 0x1801D8CB0
	public bool get_Secure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8D40 Offset: 0x1D8140 VA: 0x1801D8D40
	public void set_Secure(bool value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D8C80 Offset: 0x1D8080 VA: 0x1801D8C80
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8D00 Offset: 0x1D8100 VA: 0x1801D8D00
	public void set_LastTimePlayed(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8D60 Offset: 0x1D8160 VA: 0x1801D8D60
	public void set_Version(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xFC820 Offset: 0xFBC20 VA: 0x1800FC820
	public string get_TagString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3770 Offset: 0xF2B70 VA: 0x1800F3770
	public void set_TagString(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D8CC0 Offset: 0x1D80C0 VA: 0x1801D8CC0
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8D50 Offset: 0x1D8150 VA: 0x1801D8D50
	public void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D8C50 Offset: 0x1D8050 VA: 0x1801D8C50
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8CD0 Offset: 0x1D80D0 VA: 0x1801D8CD0
	public void set_AddressRaw(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D8C60 Offset: 0x1D8060 VA: 0x1801D8C60
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3790 Offset: 0xF2B90 VA: 0x1800F3790
	public void set_Address(IPAddress value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D8C70 Offset: 0x1D8070 VA: 0x1801D8C70
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8CF0 Offset: 0x1D80F0 VA: 0x1801D8CF0
	public void set_ConnectionPort(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D8CA0 Offset: 0x1D80A0 VA: 0x1801D8CA0
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8D30 Offset: 0x1D8130 VA: 0x1801D8D30
	public void set_QueryPort(int value) { }

	// RVA: 0x128FAA0 Offset: 0x128E0A0 VA: 0x18128FAA0
	internal static ServerInfo From(gameserveritem_t item) { }

	// RVA: 0x1D8B90 Offset: 0x1D7F90 VA: 0x1801D8B90
	public void .ctor(uint ip, ushort cport, ushort qport, uint timeplayed) { }

	// RVA: 0x1D8640 Offset: 0x1D7A40 VA: 0x1801D8640
	public void AddToHistory() { }

	[AsyncStateMachineAttribute] // RVA: 0xA5DD0 Offset: 0xA51D0 VA: 0x1800A5DD0
	// RVA: 0x1D8880 Offset: 0x1D7C80 VA: 0x1801D8880
	public Task<Dictionary<string, string>> QueryRulesAsync() { }

	// RVA: 0x1D8AA0 Offset: 0x1D7EA0 VA: 0x1801D8AA0
	public void RemoveFromHistory() { }

	// RVA: 0x1D8500 Offset: 0x1D7900 VA: 0x1801D8500
	public void AddToFavourites() { }

	// RVA: 0x1D89B0 Offset: 0x1D7DB0 VA: 0x1801D89B0
	public void RemoveFromFavourites() { }

	// RVA: 0x1D8780 Offset: 0x1D7B80 VA: 0x1801D8780 Slot: 4
	public bool Equals(ServerInfo other) { }

	// RVA: 0x1D8870 Offset: 0x1D7C70 VA: 0x1801D8870 Slot: 2
	public override int GetHashCode() { }

}

private struct ServerInfo.<QueryRulesAsync>d__85 : IAsyncStateMachine // TypeDefIndex: 5558
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo <>4__this; // 0x20
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x98

	// Methods

	// RVA: 0x1DB820 Offset: 0x1DAC20 VA: 0x1801DB820 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1DB830 Offset: 0x1DAC30 VA: 0x1801DB830 Slot: 5
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly uint <AppId>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <Name>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IPAddress <Address>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly uint <AddressRaw>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <ConnectionPort>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <QueryPort>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <Map>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <TagString>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <IsSecure>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <Players>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <MaxPlayers>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly uint <LastTimePlayed>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <Ping>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ulong <SteamId>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly uint <Born>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IReadOnlyList<string> <Tags>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <ConnectionProtocol>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1EF4C0 Offset: 0x1EE8C0 VA: 0x1801EF4C0
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1EF4D0 Offset: 0x1EE8D0 VA: 0x1801EF4D0
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12BFE0 Offset: 0x12B3E0 VA: 0x18012BFE0
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC800 Offset: 0xFBC00 VA: 0x1800FC800
	public string get_Map() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFCA50 Offset: 0xFBE50 VA: 0x1800FCA50
	public string get_TagString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23F910 Offset: 0x23ED10 VA: 0x18023F910
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8C80 Offset: 0x1D8080 VA: 0x1801D8C80
	public int get_Players() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC810 Offset: 0xFBC10 VA: 0x1800FC810
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23F920 Offset: 0x23ED20 VA: 0x18023F920
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1E0F10 Offset: 0x1E0310 VA: 0x1801E0F10
	public int get_Ping() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8CC0 Offset: 0x1D80C0 VA: 0x1801D8CC0
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8C50 Offset: 0x1D8050 VA: 0x1801D8C50
	public uint get_Born() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1D8C60 Offset: 0x1D8060 VA: 0x1801D8C60
	public IReadOnlyList<string> get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC850 Offset: 0xFBC50 VA: 0x1800FC850
	public string get_ConnectionProtocol() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x141D30 Offset: 0x141130 VA: 0x180141D30
	public string get_ConnectionString() { }

	// RVA: 0x23F8F0 Offset: 0x23ECF0 VA: 0x18023F8F0
	public void .ctor(uint appId, string name, IPAddress address, int connectionPort, int queryPort, string map, string tagString, bool isSecure, int players, int maxPlayers, uint lastTimePlayed, int ping, ulong steamId, int authedPlayers = 2147483647) { }

	// RVA: 0x2300E00 Offset: 0x22FF400 VA: 0x182300E00
	private static uint AddressToUInt32(IPAddress address) { }

	// RVA: 0x19CF770 Offset: 0x19CDD70 VA: 0x1819CF770
	private static uint Swap(uint x) { }

}

private sealed class ServerInfo.<>c // TypeDefIndex: 5702
{	// Fields
	public static readonly ServerInfo.<>c <>9; // 0x0
	public static Func<string, bool> <>9__54_0; // 0x8

	// Methods

	// RVA: 0x23015C0 Offset: 0x22FFBC0 VA: 0x1823015C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2301570 Offset: 0x22FFB70 VA: 0x182301570
	internal bool <.ctor>b__54_0(string x) { }

}

public struct ServerParameters // TypeDefIndex: 5703
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <ShortName>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <FullName>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <Version>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <IsSecure>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <HideIP>k__BackingField; // 0x19
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IPAddress <Address>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ushort <GamePort>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public string get_ShortName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public string get_FullName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23FAB0 Offset: 0x23EEB0 VA: 0x18023FAB0
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23FAA0 Offset: 0x23EEA0 VA: 0x18023FAA0
	public bool get_HideIP() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3730 Offset: 0xF2B30 VA: 0x1800F3730
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23FA90 Offset: 0x23EE90 VA: 0x18023FA90
	public ushort get_GamePort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23FAC0 Offset: 0x23EEC0 VA: 0x18023FAC0
	public ushort get_QueryPort() { }

	// RVA: 0x23F930 Offset: 0x23ED30 VA: 0x18023F930
	public void .ctor(string shortName, string fullName, string version, bool isSecure, bool hideIP, IPAddress address, ushort gamePort, ushort queryPort = 0) { }

}

public static class ServerInfoExtensions // TypeDefIndex: 6157
{	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x9A100 Offset: 0x99500 VA: 0x18009A100
	[ExtensionAttribute] // RVA: 0x9A100 Offset: 0x99500 VA: 0x18009A100
	// RVA: 0x23168E0 Offset: 0x2314EE0 VA: 0x1823168E0
	public static Task<Dictionary<string, string>> QueryRulesAsync(ServerInfo server) { }

}

private struct ServerInfoExtensions.<QueryRulesAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 6158
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo server; // 0x20
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x98

	// Methods

	// RVA: 0x240B00 Offset: 0x23FF00 VA: 0x180240B00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x240B10 Offset: 0x23FF10 VA: 0x180240B10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class ServerListMetadata // TypeDefIndex: 6211
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static DateTimeOffset <LastDownloaded>k__BackingField; // 0x2B10370

	// Properties
	public static DateTimeOffset LastDownloaded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B8200 Offset: 0x14B6800 VA: 0x1814B8200
	public static DateTimeOffset get_LastDownloaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B8250 Offset: 0x14B6850 VA: 0x1814B8250
	private static void set_LastDownloaded(DateTimeOffset value) { }

	// RVA: 0x14B7B30 Offset: 0x14B6130 VA: 0x1814B7B30
	public static void Refresh(bool force = False) { }

	// RVA: 0x14B80A0 Offset: 0x14B66A0 VA: 0x1814B80A0
	private static void UpdateMetadata() { }

	// RVA: 0x14B7110 Offset: 0x14B5710 VA: 0x1814B7110
	private static void LoadMetadata(string json) { }

	// RVA: 0x14B7A80 Offset: 0x14B6080 VA: 0x1814B7A80
	private static void OnUpdated(Dictionary<IPEndPoint, int> metadata) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B7F20 Offset: 0x14B6520 VA: 0x1814B7F20
	internal static bool <LoadMetadata>g__TryParseIPEndPoint|6_0(string value, out IPEndPoint endPoint) { }

}

private sealed class ServerListMetadata.<>c // TypeDefIndex: 6212
{	// Fields
	public static readonly ServerListMetadata.<>c <>9; // 0x0
	public static Action<string> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x14BC4F0 Offset: 0x14BAAF0 VA: 0x1814BC4F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BBC90 Offset: 0x14BA290 VA: 0x1814BBC90
	internal void <UpdateMetadata>b__5_0(string str) { }

}

public class ServerGib : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6330
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string gibName; // 0x18

	// Methods

	// RVA: 0x1E08D10 Offset: 0x1E07310 VA: 0x181E08D10
	public static void ResetToPool(ServerGib instance) { }

	// RVA: 0x1E08C80 Offset: 0x1E07280 VA: 0x181E08C80
	public void ResetToPool() { }

	// RVA: 0x1E08B30 Offset: 0x1E07130 VA: 0x181E08B30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68640 Offset: 0x1D66C40 VA: 0x181D68640
	public void CopyTo(ServerGib instance) { }

	// RVA: 0x1E08190 Offset: 0x1E06790 VA: 0x181E08190
	public ServerGib Copy() { }

	// RVA: 0x1E08AB0 Offset: 0x1E070B0 VA: 0x181E08AB0
	public static ServerGib Deserialize(Stream stream) { }

	// RVA: 0x1E08430 Offset: 0x1E06A30 VA: 0x181E08430
	public static ServerGib DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E084B0 Offset: 0x1E06AB0 VA: 0x181E084B0
	public static ServerGib DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E08740 Offset: 0x1E06D40 VA: 0x181E08740
	public static ServerGib Deserialize(byte[] buffer) { }

	// RVA: 0x1E08C40 Offset: 0x1E07240 VA: 0x181E08C40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E09180 Offset: 0x1E07780 VA: 0x181E09180 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E091A0 Offset: 0x1E077A0 VA: 0x181E091A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ServerGib previous) { }

	// RVA: 0x1E08C60 Offset: 0x1E07260 VA: 0x181E08C60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E089B0 Offset: 0x1E06FB0 VA: 0x181E089B0
	public static ServerGib Deserialize(byte[] buffer, ServerGib instance, bool isDelta = False) { }

	// RVA: 0x1E08860 Offset: 0x1E06E60 VA: 0x181E08860
	public static ServerGib Deserialize(Stream stream, ServerGib instance, bool isDelta) { }

	// RVA: 0x1E08210 Offset: 0x1E06810 VA: 0x181E08210
	public static ServerGib DeserializeLengthDelimited(Stream stream, ServerGib instance, bool isDelta) { }

	// RVA: 0x1E08540 Offset: 0x1E06B40 VA: 0x181E08540
	public static ServerGib DeserializeLength(Stream stream, int length, ServerGib instance, bool isDelta) { }

	// RVA: 0x1E08DA0 Offset: 0x1E073A0 VA: 0x181E08DA0
	public static void SerializeDelta(Stream stream, ServerGib instance, ServerGib previous) { }

	// RVA: 0x1E09080 Offset: 0x1E07680 VA: 0x181E09080
	public static void Serialize(Stream stream, ServerGib instance) { }

	// RVA: 0x1E09170 Offset: 0x1E07770 VA: 0x181E09170
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E09180 Offset: 0x1E07780 VA: 0x181E09180
	public void ToProto(Stream stream) { }

	// RVA: 0x1E08F70 Offset: 0x1E07570 VA: 0x181E08F70
	public static byte[] SerializeToBytes(ServerGib instance) { }

	// RVA: 0x1E08EC0 Offset: 0x1E074C0 VA: 0x181E08EC0
	public static void SerializeLengthDelimited(Stream stream, ServerGib instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2214F90 Offset: 0x2213590 VA: 0x182214F90 Slot: 8
	public virtual string get_ProtocolId() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool get_AllowPassthroughMessages() { }

	// RVA: 0x2214D70 Offset: 0x2213370 VA: 0x182214D70
	public void Reset() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 10
	public virtual bool Start() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	public virtual void Stop(string shutdownMsg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void Cycle() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Disconnect(Connection cn);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Kick(Connection cn, string message, bool logfile = False);

	// RVA: 0x2214D80 Offset: 0x2213380 VA: 0x182214D80
	public uint TakeUID() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void ReturnUID(uint uid) { }

	// RVA: 0x2214BE0 Offset: 0x22131E0 VA: 0x182214BE0
	public void RegisterUID(uint uid) { }

	// RVA: 0x2214D70 Offset: 0x2213370 VA: 0x182214D70
	internal void ResetUIDs() { }

	// RVA: 0x2214480 Offset: 0x2212A80 VA: 0x182214480
	public Networkable CreateNetworkable() { }

	// RVA: 0x22143E0 Offset: 0x22129E0 VA: 0x1822143E0
	public Networkable CreateNetworkable(uint uid) { }

	// RVA: 0x2214590 Offset: 0x2212B90 VA: 0x182214590
	public void DestroyNetworkable(ref Networkable networkable) { }

	// RVA: 0x22146F0 Offset: 0x2212CF0 VA: 0x1822146F0
	protected void OnDisconnected(string strReason, Connection cn) { }

	// RVA: 0x2214620 Offset: 0x2212C20 VA: 0x182214620
	protected Connection FindConnection(ulong guid) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	protected virtual void OnNewConnection() { }

	// RVA: 0x22146A0 Offset: 0x2212CA0 VA: 0x1822146A0
	private string IPAddressWithoutPort(string address) { }

	// RVA: 0x2214910 Offset: 0x2212F10 VA: 0x182214910 Slot: 16
	protected virtual void OnNewConnection(Connection connection) { }

	// RVA: 0x2214BF0 Offset: 0x22131F0 VA: 0x182214BF0
	protected void RemoveConnection(Connection connection) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 17
	public virtual int GetAveragePing(Connection connection) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public virtual void SendUnconnected(uint netAddr, ushort netPort, byte[] steamResponseBuffer, int packetSize) { }

	// RVA: 0x2214EA0 Offset: 0x22134A0 VA: 0x182214EA0
	protected void .ctor() { }

	// RVA: 0x2214E20 Offset: 0x2213420 VA: 0x182214E20
	private static void .cctor() { }

}

public class ServerVar : ConsoleVar // TypeDefIndex: 6891
{	// Methods

	// RVA: 0x22B6060 Offset: 0x22B4660 VA: 0x1822B6060
	public void .ctor() { }

}

public class ServerUserVar : ConsoleVar // TypeDefIndex: 6892
{	// Methods

	// RVA: 0x22B6040 Offset: 0x22B4640 VA: 0x1822B6040
	public void .ctor() { }

}

public class ServerAllVar : ConsoleVar // TypeDefIndex: 6893
{	// Methods

	// RVA: 0x22B6020 Offset: 0x22B4620 VA: 0x1822B6020
	public void .ctor() { }

}

public class Server : Server // TypeDefIndex: 7333
{	// Fields
	private Peer peer; // 0x68

	// Properties
	public override string ProtocolId { get; }
	public override bool AllowPassthroughMessages { get; }

	// Methods

	// RVA: 0x22D1C50 Offset: 0x22D0250 VA: 0x1822D1C50 Slot: 8
	public override string get_ProtocolId() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 9
	public override bool get_AllowPassthroughMessages() { }

	// RVA: 0xEE7A80 Offset: 0xEE6080 VA: 0x180EE7A80 Slot: 7
	public override bool IsConnected() { }

	// RVA: 0x22D1840 Offset: 0x22CFE40 VA: 0x1822D1840 Slot: 10
	public override bool Start() { }

	// RVA: 0x22D18D0 Offset: 0x22CFED0 VA: 0x1822D18D0 Slot: 11
	public override void Stop(string shutdownMsg) { }

	// RVA: 0x22D0D90 Offset: 0x22CF390 VA: 0x1822D0D90 Slot: 13
	public override void Disconnect(Connection cn) { }

	// RVA: 0x22D1130 Offset: 0x22CF730 VA: 0x1822D1130 Slot: 14
	public override void Kick(Connection cn, string message, bool logfile) { }

	// RVA: 0x22D0EE0 Offset: 0x22CF4E0 VA: 0x1822D0EE0
	internal bool HandleRaknetPacket(byte type, Connection connection) { }

	// RVA: 0x22D1A30 Offset: 0x22D0030 VA: 0x1822D1A30
	internal void UnconnectedPacket() { }

	// RVA: 0x22D0770 Offset: 0x22CED70 VA: 0x1822D0770
	internal void ConnectedPacket(Connection connection) { }

	// RVA: 0x22D0A00 Offset: 0x22CF000 VA: 0x1822D0A00 Slot: 12
	public override void Cycle() { }

	// RVA: 0x22D1310 Offset: 0x22CF910 VA: 0x1822D1310 Slot: 15
	protected override void OnNewConnection() { }

	// RVA: 0x22D0E30 Offset: 0x22CF430 VA: 0x1822D0E30 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D0DF0 Offset: 0x22CF3F0 VA: 0x1822D0DF0 Slot: 17
	public override int GetAveragePing(Connection connection) { }

	// RVA: 0x22D0EC0 Offset: 0x22CF4C0 VA: 0x1822D0EC0 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22D1410 Offset: 0x22CFA10 VA: 0x1822D1410 Slot: 18
	public override void SendUnconnected(uint netAddr, ushort netPort, byte[] data, int size) { }

	// RVA: 0x22D1660 Offset: 0x22CFC60 VA: 0x1822D1660 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22D1500 Offset: 0x22CFB00 VA: 0x1822D1500
	private void Send(SendInfo sendinfo, MemoryStream data, Connection connection) { }

	// RVA: 0x22D1BF0 Offset: 0x22D01F0 VA: 0x1822D1BF0
	public void .ctor() { }

}

public class ServerConsole : SingletonComponent<ServerConsole> // TypeDefIndex: 9290
{	// Methods

	// RVA: 0x592FF0 Offset: 0x5915F0 VA: 0x180592FF0
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

	// RVA: 0x5932B0 Offset: 0x5918B0 VA: 0x1805932B0
	public MeshCollider GetCollider() { }

	// RVA: 0x5932C0 Offset: 0x5918C0 VA: 0x1805932C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x593060 Offset: 0x591660 VA: 0x180593060
	public void ClientSetGib(string newgibname) { }

	// RVA: 0x593050 Offset: 0x591650 VA: 0x180593050 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x593710 Offset: 0x591D10 VA: 0x180593710
	public void VisualsInit(Mesh mesh, Material[] materials) { }

	// RVA: 0x593320 Offset: 0x591920 VA: 0x180593320 Slot: 145
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

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 10
	public virtual bool get_HasRangeLimit() { }

	// RVA: 0x594160 Offset: 0x592760 VA: 0x180594160
	public float GetMaxRange(float maxFuseTime) { }

	// RVA: 0x594250 Offset: 0x592850 VA: 0x180594250
	public void .ctor() { }

}

public class ServerMgr : SingletonComponent<ServerMgr> // TypeDefIndex: 10712
{
// Namespace: 
public class ServerMgr : SingletonComponent<ServerMgr> // TypeDefIndex: 10712
	// Fields
	public const string BYPASS_PROCEDURAL_SPAWN_PREF = "bypassProceduralSpawn";

	// Methods

	// RVA: 0x594100 Offset: 0x592700 VA: 0x180594100
	public void .ctor() { }

}

public class ServerPerformance : BaseMonoBehaviour // TypeDefIndex: 10713
{	// Fields
	public static ulong deaths; // 0x0
	public static ulong spawns; // 0x8
	public static ulong position_changes; // 0x10

	// Methods

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
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

	// RVA: 0x5927F0 Offset: 0x590DF0 VA: 0x1805927F0
	private void OnEnable() { }

	// RVA: 0x592700 Offset: 0x590D00 VA: 0x180592700
	private void OnDisable() { }

	// RVA: 0x5928E0 Offset: 0x590EE0 VA: 0x1805928E0
	private void OnOpenStateChanged() { }

	// RVA: 0x592950 Offset: 0x590F50 VA: 0x180592950
	public void RefreshAll() { }

	// RVA: 0x5925E0 Offset: 0x590BE0 VA: 0x1805925E0
	private void ClearAll() { }

	// RVA: 0x592A80 Offset: 0x591080 VA: 0x180592A80
	public void SetOrder(string strBy) { }

	// RVA: 0x592DD0 Offset: 0x5913D0 VA: 0x180592DD0
	public void SetShowFull(bool showFull) { }

	// RVA: 0x592D00 Offset: 0x591300 VA: 0x180592D00
	public void SetShowEmpty(bool showFull) { }

	// RVA: 0x592C10 Offset: 0x591210 VA: 0x180592C10
	public void SetSearchFilter(string txt) { }

	// RVA: 0x592EA0 Offset: 0x5914A0 VA: 0x180592EA0
	public void SetTagsFilter(ServerBrowserTagFilters tagFilters) { }

	// RVA: 0x592F90 Offset: 0x591590 VA: 0x180592F90
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

	// RVA: 0x58C800 Offset: 0x58AE00 VA: 0x18058C800
	public void Update() { }

	// RVA: 0x4A04D0 Offset: 0x49EAD0 VA: 0x1804A04D0
	public void Dirty() { }

	// RVA: 0x58C570 Offset: 0x58AB70 VA: 0x18058C570
	public void UpdateCounts() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class ServerBrowserCategory.<>c // TypeDefIndex: 11152
{	// Fields
	public static readonly ServerBrowserCategory.<>c <>9; // 0x0
	public static Func<ServerInfo, int> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x5A4C30 Offset: 0x5A3230 VA: 0x1805A4C30
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4770 Offset: 0x5A2D70 VA: 0x1805A4770
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

	// RVA: 0x58D640 Offset: 0x58BC40 VA: 0x18058D640 Slot: 4
	public override void SingletonSetup() { }

	// RVA: 0x58CE70 Offset: 0x58B470 VA: 0x18058CE70
	public void Open(ServerInfo server) { }

	// RVA: 0x4E6380 Offset: 0x4E4980 VA: 0x1804E6380
	public void Close() { }

	// RVA: 0x58CA10 Offset: 0x58B010 VA: 0x18058CA10
	public void JoinServer() { }

	// RVA: 0x58C850 Offset: 0x58AE50 VA: 0x18058C850
	public void JoinDelayed() { }

	// RVA: 0x58CD00 Offset: 0x58B300 VA: 0x18058CD00
	public static void Join(ServerInfo server) { }

	// RVA: 0x58D0A0 Offset: 0x58B6A0 VA: 0x18058D0A0
	public void Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x9A200 Offset: 0x99600 VA: 0x18009A200
	// RVA: 0x58CFD0 Offset: 0x58B5D0 VA: 0x18058CFD0
	private void QueryRules() { }

	// RVA: 0x58C820 Offset: 0x58AE20 VA: 0x18058C820
	private void EnableRefreshButton() { }

	// RVA: 0x58D690 Offset: 0x58BC90 VA: 0x18058D690
	public void VisitWebpage() { }

	// RVA: 0x58D6A0 Offset: 0x58BCA0 VA: 0x18058D6A0
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

	// RVA: 0xF3330 Offset: 0xF2730 VA: 0x1800F3330 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
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

	// RVA: 0x58D700 Offset: 0x58BD00 VA: 0x18058D700
	private static string GetFriendOnServer(IPAddress addr, int port) { }

	// RVA: 0x58DD00 Offset: 0x58C300 VA: 0x18058DD00
	private static bool GetIsFavourite(IPAddress addr, int port) { }

	// RVA: 0x58DF40 Offset: 0x58C540 VA: 0x18058DF40
	internal void Init(ServerInfo s, bool isFavourites, bool isHistory) { }

	// RVA: 0x58E4A0 Offset: 0x58CAA0 VA: 0x18058E4A0
	public void OnClicked() { }

	// RVA: 0x58E620 Offset: 0x58CC20 VA: 0x18058E620
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

	// RVA: 0x5A4AB0 Offset: 0x5A30B0 VA: 0x1805A4AB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4430 Offset: 0x5A2A30 VA: 0x1805A4430
	internal bool <GetFriendOnServer>b__8_0(IPlayerInfo x) { }

	// RVA: 0x5A4480 Offset: 0x5A2A80 VA: 0x1805A4480
	internal bool <GetFriendOnServer>b__8_1(IPlayerInfo x) { }

	// RVA: 0x5A44D0 Offset: 0x5A2AD0 VA: 0x1805A44D0
	internal bool <GetFriendOnServer>b__8_2(IPlayerInfo x) { }

	// RVA: 0x5A4530 Offset: 0x5A2B30 VA: 0x1805A4530
	internal string <GetFriendOnServer>b__8_3(IPlayerInfo x) { }

	// RVA: 0x5A4580 Offset: 0x5A2B80 VA: 0x1805A4580
	internal string <GetFriendOnServer>b__8_4(IGrouping<string, IPlayerInfo> x) { }

	// RVA: 0x5A45D0 Offset: 0x5A2BD0 VA: 0x1805A45D0
	internal string <GetFriendOnServer>b__8_5(IGrouping<string, IPlayerInfo> x) { }

	// RVA: 0x5A46E0 Offset: 0x5A2CE0 VA: 0x1805A46E0
	internal string <GetFriendOnServer>b__8_6(IPlayerInfo y) { }

	// RVA: 0x5A46F0 Offset: 0x5A2CF0 VA: 0x1805A46F0
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

	// RVA: 0x58FA10 Offset: 0x58E010 VA: 0x18058FA10
	public bool IsCheater() { }

	// RVA: 0x58FCE0 Offset: 0x58E2E0 VA: 0x18058FCE0
	public void Refresh() { }

	// RVA: 0x590BC0 Offset: 0x58F1C0 VA: 0x180590BC0
	private void ServerResponded(ServerInfo server) { }

	// RVA: 0x58F900 Offset: 0x58DF00 VA: 0x18058F900
	public void InitFilters(string searchFilter, bool showFull, bool showEmpty, HashSet<string> searchTags, HashSet<string> excludeTags) { }

	// RVA: 0x58F970 Offset: 0x58DF70 VA: 0x18058F970
	public void Init() { }

	// RVA: 0x58FB30 Offset: 0x58E130 VA: 0x18058FB30
	public void OnEnable() { }

	// RVA: 0x58FAE0 Offset: 0x58E0E0 VA: 0x18058FAE0
	public void OnDisable() { }

	// RVA: 0x58EBB0 Offset: 0x58D1B0 VA: 0x18058EBB0
	public void Clear() { }

	// RVA: 0x58E810 Offset: 0x58CE10 VA: 0x18058E810
	public void AddServer(ServerInfo server) { }

	// RVA: 0x58FC50 Offset: 0x58E250 VA: 0x18058FC50
	public void Rebuild() { }

	// RVA: 0x58EC80 Offset: 0x58D280 VA: 0x18058EC80
	internal IOrderedEnumerable<ServerInfo> GetSortedServers() { }

	// RVA: 0x591660 Offset: 0x58FC60 VA: 0x180591660
	public void Update() { }

	// RVA: 0x590A30 Offset: 0x58F030 VA: 0x180590A30
	public void SearchFilter(string searchtext, bool showFull, bool showEmpty, HashSet<string> searchTags, HashSet<string> excludeTags) { }

	// RVA: 0x58FC20 Offset: 0x58E220 VA: 0x18058FC20
	public void OrderBy(string strBy) { }

	// RVA: 0x5913D0 Offset: 0x58F9D0 VA: 0x1805913D0
	private void UpdateAllPlayerClamps() { }

	// RVA: 0x58EAA0 Offset: 0x58D0A0 VA: 0x18058EAA0
	private static ServerInfo ClampPlayerCount(in ServerInfo server, int maxAllowedPlayers) { }

	// RVA: 0x58EC40 Offset: 0x58D240 VA: 0x18058EC40 Slot: 6
	public int GetItemCount() { }

	// RVA: 0x5912A0 Offset: 0x58F8A0 VA: 0x1805912A0 Slot: 7
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x591720 Offset: 0x58FD20 VA: 0x180591720
	public void .ctor() { }

	// RVA: 0x5916B0 Offset: 0x58FCB0 VA: 0x1805916B0
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

	// RVA: 0x5A4B10 Offset: 0x5A3110 VA: 0x1805A4B10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4830 Offset: 0x5A2E30 VA: 0x1805A4830
	internal string <Refresh>b__11_0(Manifest.ServerDesc x) { }

	// RVA: 0x5A4790 Offset: 0x5A2D90 VA: 0x1805A4790
	internal bool <GetSortedServers>b__41_1(ServerInfo x) { }

	// RVA: 0x5A47A0 Offset: 0x5A2DA0 VA: 0x1805A47A0
	internal bool <GetSortedServers>b__41_2(ServerInfo x) { }

	// RVA: 0x5A4780 Offset: 0x5A2D80 VA: 0x1805A4780
	internal int <GetSortedServers>b__41_3(ServerInfo x) { }

	// RVA: 0x5A47B0 Offset: 0x5A2DB0 VA: 0x1805A47B0
	internal uint <GetSortedServers>b__41_5(ServerInfo x) { }

	// RVA: 0x5A47B0 Offset: 0x5A2DB0 VA: 0x1805A47B0
	internal uint <GetSortedServers>b__41_7(ServerInfo x) { }

	// RVA: 0x5A4750 Offset: 0x5A2D50 VA: 0x1805A4750
	internal bool <GetSortedServers>b__41_8(ServerInfo x) { }

	// RVA: 0x5A4760 Offset: 0x5A2D60 VA: 0x1805A4760
	internal uint <GetSortedServers>b__41_9(ServerInfo x) { }

	// RVA: 0x5A4750 Offset: 0x5A2D50 VA: 0x1805A4750
	internal bool <GetSortedServers>b__41_10(ServerInfo x) { }

	// RVA: 0x5A4760 Offset: 0x5A2D60 VA: 0x1805A4760
	internal uint <GetSortedServers>b__41_11(ServerInfo x) { }

	// RVA: 0x4D1BC0 Offset: 0x4D01C0 VA: 0x1804D1BC0
	internal string <GetSortedServers>b__41_12(ServerInfo x) { }

	// RVA: 0x4D1BC0 Offset: 0x4D01C0 VA: 0x1804D1BC0
	internal string <GetSortedServers>b__41_13(ServerInfo x) { }

	// RVA: 0x5A4770 Offset: 0x5A2D70 VA: 0x1805A4770
	internal int <GetSortedServers>b__41_14(ServerInfo x) { }

	// RVA: 0x5A4770 Offset: 0x5A2D70 VA: 0x1805A4770
	internal int <GetSortedServers>b__41_15(ServerInfo x) { }

	// RVA: 0x5A4780 Offset: 0x5A2D80 VA: 0x1805A4780
	internal int <GetSortedServers>b__41_16(ServerInfo x) { }

}

private sealed class ServerBrowserList.<>c__DisplayClass12_0 // TypeDefIndex: 11162
{	// Fields
	public ServerBrowserList.Rules rule; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A48A0 Offset: 0x5A2EA0 VA: 0x1805A48A0
	internal bool <ServerResponded>b__0(string x) { }

}

private sealed class ServerBrowserList.<>c__DisplayClass41_0 // TypeDefIndex: 11163
{	// Fields
	public ServerBrowserList <>4__this; // 0x10
	public int now; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4950 Offset: 0x5A2F50 VA: 0x1805A4950
	internal bool <GetSortedServers>b__0(ServerInfo x) { }

	// RVA: 0x5A4A30 Offset: 0x5A3030 VA: 0x1805A4A30
	internal bool <GetSortedServers>b__4(ServerInfo x) { }

	// RVA: 0x5A4A30 Offset: 0x5A3030 VA: 0x1805A4A30
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsActive>k__BackingField; // 0x58

	// Properties
	public bool IsActive { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5925D0 Offset: 0x590BD0 VA: 0x1805925D0
	private void set_IsActive(bool value) { }

	// RVA: 0x592330 Offset: 0x590930 VA: 0x180592330
	public void OnEnable() { }

	// RVA: 0x592400 Offset: 0x590A00 VA: 0x180592400
	public bool Test(in ServerInfo serverInfo) { }

	// RVA: 0x592530 Offset: 0x590B30 VA: 0x180592530
	public void Toggle() { }

	// RVA: 0x592340 Offset: 0x590940 VA: 0x180592340
	private void Refresh() { }

	// RVA: 0x592550 Offset: 0x590B50 VA: 0x180592550
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

	// RVA: 0x591ED0 Offset: 0x5904D0 VA: 0x180591ED0
	public void Start() { }

	// RVA: 0x591E40 Offset: 0x590440 VA: 0x180591E40
	public void Open() { }

	// RVA: 0x591810 Offset: 0x58FE10 VA: 0x180591810
	public void Close() { }

	// RVA: 0x591C10 Offset: 0x590210 VA: 0x180591C10
	public void GetTags(out HashSet<string> searchTags, out HashSet<string> excludeTags) { }

	// RVA: 0x591B00 Offset: 0x590100 VA: 0x180591B00
	private List<bool> GetCurrentSelections() { }

	// RVA: 0x592130 Offset: 0x590730 VA: 0x180592130
	public void .ctor() { }

}

private sealed class ServerBrowserTagFilters.<>c // TypeDefIndex: 11166
{	// Fields
	public static readonly ServerBrowserTagFilters.<>c <>9; // 0x0
	public static Func<bool, bool> <>9__7_0; // 0x8
	public static Func<ServerBrowserTag, bool> <>9__9_0; // 0x10

	// Methods

	// RVA: 0x5A4B70 Offset: 0x5A3170 VA: 0x1805A4B70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A43A0 Offset: 0x5A29A0 VA: 0x1805A43A0
	internal bool <Close>b__7_0(bool b) { }

	// RVA: 0x5A4410 Offset: 0x5A2A10 VA: 0x1805A4410
	internal bool <GetCurrentSelections>b__9_0(ServerBrowserTag t) { }

}

public class ServerBrowserTagList : MonoBehaviour // TypeDefIndex: 11167
{	// Fields
	private ServerBrowserTag[] _allTags; // 0x18

	// Methods

	// RVA: 0x5921A0 Offset: 0x5907A0 VA: 0x1805921A0
	private void Initialize() { }

	// RVA: 0x5921A0 Offset: 0x5907A0 VA: 0x1805921A0
	public void Awake() { }

	// RVA: 0x592200 Offset: 0x590800 VA: 0x180592200
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

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	private void Start() { }

	[AsyncStateMachineAttribute] // RVA: 0x9AFD0 Offset: 0x9A3D0 VA: 0x18009AFD0
	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public Task Refresh() { }

	// RVA: 0x593B40 Offset: 0x592140 VA: 0x180593B40
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

	// RVA: 0xF3410 Offset: 0xF2810 VA: 0x1800F3410 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class ServerHistory.<>c // TypeDefIndex: 11170
{	// Fields
	public static readonly ServerHistory.<>c <>9; // 0x0
	public static Func<Transform, object> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x5A4C90 Offset: 0x5A3290 VA: 0x1805A4C90
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A47C0 Offset: 0x5A2DC0 VA: 0x1805A47C0
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

	// RVA: 0x5938D0 Offset: 0x591ED0 VA: 0x1805938D0
	internal void Setup(ServerInfo s) { }

	// RVA: 0x593800 Offset: 0x591E00 VA: 0x180593800
	public void Open() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public static class ServerInfoHelpers // TypeDefIndex: 11172
{	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x9B440 Offset: 0x9A840 VA: 0x18009B440
	// RVA: 0x593FE0 Offset: 0x5925E0 VA: 0x180593FE0
	public static Task<Nullable<ServerInfo>> Load(string address, int port) { }

	[AsyncStateMachineAttribute] // RVA: 0x9B490 Offset: 0x9A890 VA: 0x18009B490
	// RVA: 0x593EA0 Offset: 0x5924A0 VA: 0x180593EA0
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

	// RVA: 0xF32D0 Offset: 0xF26D0 VA: 0x1800F32D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF32E0 Offset: 0xF26E0 VA: 0x1800F32E0 Slot: 5
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

	// RVA: 0xF3270 Offset: 0xF2670 VA: 0x1800F3270 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3280 Offset: 0xF2680 VA: 0x1800F3280 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class Server // TypeDefIndex: 11651
{	// Fields
	public const byte Default = 0;
	public const byte Positions = 14;

}

public class Server : ConsoleSystem // TypeDefIndex: 11960
{	// Fields
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static string ip; // 0x0
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int port; // 0x8
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int queryport; // 0xC
	[ServerVar] // RVA: 0xB4720 Offset: 0xB3B20 VA: 0x1800B4720
	public static int maxplayers; // 0x10
	[ServerVar] // RVA: 0xB4720 Offset: 0xB3B20 VA: 0x1800B4720
	public static string hostname; // 0x18
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static string identity; // 0x20
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static string level; // 0x28
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static string levelurl; // 0x30
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool leveltransfer; // 0x38
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int seed; // 0x3C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int salt; // 0x40
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int worldsize; // 0x44
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int saveinterval; // 0x48
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool secure; // 0x4C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int encryption; // 0x50
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int tickrate; // 0x54
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int entityrate; // 0x58
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float schematime; // 0x5C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float cycletime; // 0x60
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool official; // 0x64
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool stats; // 0x65
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool globalchat; // 0x66
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool stability; // 0x67
	[ServerVar] // RVA: 0xB4720 Offset: 0xB3B20 VA: 0x1800B4720
	public static bool radiation; // 0x68
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float itemdespawn; // 0x6C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float itemdespawn_quick; // 0x70
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float corpsedespawn; // 0x74
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float debrisdespawn; // 0x78
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool pve; // 0x7C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool cinematic; // 0x7D
	[ServerVar] // RVA: 0xB4720 Offset: 0xB3B20 VA: 0x1800B4720
	public static string description; // 0x80
	[ServerVar] // RVA: 0xB4720 Offset: 0xB3B20 VA: 0x1800B4720
	public static string url; // 0x88
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static string branch; // 0x90
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int queriesPerSecond; // 0x98
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int ipQueriesPerMin; // 0x9C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool statBackup; // 0xA0
	[ServerVar] // RVA: 0xB8A10 Offset: 0xB7E10 VA: 0x1800B8A10
	public static string headerimage; // 0xA8
	[ServerVar] // RVA: 0xB8A10 Offset: 0xB7E10 VA: 0x1800B8A10
	public static string logoimage; // 0xB0
	[ServerVar] // RVA: 0xB8A10 Offset: 0xB7E10 VA: 0x1800B8A10
	public static int saveBackupCount; // 0xB8
	[ReplicatedVar] // RVA: 0xB8B40 Offset: 0xB7F40 VA: 0x1800B8B40
	public static string motd; // 0xC0
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float meleedamage; // 0xC8
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float arrowdamage; // 0xCC
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float bulletdamage; // 0xD0
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float bleedingdamage; // 0xD4
	[ReplicatedVar] // RVA: 0x85960 Offset: 0x84D60 VA: 0x180085960
	public static float funWaterDamageThreshold; // 0xD8
	[ReplicatedVar] // RVA: 0x85960 Offset: 0x84D60 VA: 0x180085960
	public static float funWaterWetnessGain; // 0xDC
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float meleearmor; // 0xE0
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float arrowarmor; // 0xE4
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float bulletarmor; // 0xE8
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float bleedingarmor; // 0xEC
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int updatebatch; // 0xF0
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int updatebatchspawn; // 0xF4
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int entitybatchsize; // 0xF8
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float entitybatchtime; // 0xFC
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float composterUpdateInterval; // 0x100
	[ReplicatedVar] // RVA: 0xA9A10 Offset: 0xA8E10 VA: 0x1800A9A10
	public static float planttick; // 0x104
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float planttickscale; // 0x108
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool useMinimumPlantCondition; // 0x10C
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float nonPlanterDeathChancePerTick; // 0x110
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float ceilingLightGrowableRange; // 0x114
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float artificialTemperatureGrowableRange; // 0x118
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float ceilingLightHeightOffset; // 0x11C
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float sprinklerRadius; // 0x120
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float sprinklerEyeHeightOffset; // 0x124
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float optimalPlanterQualitySaturation; // 0x128
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float metabolismtick; // 0x12C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float modifierTickRate; // 0x130
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static float rewounddelay; // 0x134
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static bool woundingenabled; // 0x138
	[ServerVar] // RVA: 0xBA030 Offset: 0xB9430 VA: 0x1800BA030
	public static float woundedrecoverchance; // 0x13C
	[ServerVar] // RVA: 0xBB410 Offset: 0xBA810 VA: 0x1800BB410
	public static float incapacitatedrecoverchance; // 0x140
	[ServerVar] // RVA: 0xBB500 Offset: 0xBA900 VA: 0x1800BB500
	public static float woundedmaxfoodandwaterbonus; // 0x144
	[ServerVar] // RVA: 0xBB6D0 Offset: 0xBAAD0 VA: 0x1800BB6D0
	public static int crawlingminimumhealth; // 0x148
	[ServerVar] // RVA: 0xBB7F0 Offset: 0xBABF0 VA: 0x1800BB7F0
	public static int crawlingmaximumhealth; // 0x14C
	[ServerVar] // RVA: 0xB8BD0 Offset: 0xB7FD0 VA: 0x1800B8BD0
	public static bool playerserverfall; // 0x150
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool plantlightdetection; // 0x151
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float respawnresetrange; // 0x154
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int maxunack; // 0x158
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool netcache; // 0x15C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool corpses; // 0x15D
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool events; // 0x15E
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool dropitems; // 0x15F
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int netcachesize; // 0x160
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int savecachesize; // 0x164
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int combatlogsize; // 0x168
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int combatlogdelay; // 0x16C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int authtimeout; // 0x170
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int playertimeout; // 0x174
	[ServerVar] // RVA: 0xB4720 Offset: 0xB3B20 VA: 0x1800B4720
	public static int idlekick; // 0x178
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int idlekickmode; // 0x17C
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int idlekickadmins; // 0x180
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static string gamemode; // 0x188
	[ServerVar] // RVA: 0xBC620 Offset: 0xBBA20 VA: 0x1800BC620
	public static string tags; // 0x190
	[ServerVar] // RVA: 0xBC830 Offset: 0xBBC30 VA: 0x1800BC830
	public static bool censorplayerlist; // 0x198
	[ServerVar] // RVA: 0xBDD10 Offset: 0xBD110 VA: 0x1800BDD10
	public static string bansServerEndpoint; // 0x1A0
	[ServerVar] // RVA: 0xBDD50 Offset: 0xBD150 VA: 0x1800BDD50
	public static int bansServerFailureMode; // 0x1A8
	[ServerVar] // RVA: 0xBDDE0 Offset: 0xBD1E0 VA: 0x1800BDDE0
	public static int bansServerTimeout; // 0x1AC
	[ServerVar] // RVA: 0xBDF40 Offset: 0xBD340 VA: 0x1800BDF40
	public static string reportsServerEndpoint; // 0x1B0
	[ServerVar] // RVA: 0xBE0B0 Offset: 0xBD4B0 VA: 0x1800BE0B0
	public static string reportsServerEndpointKey; // 0x1B8
	[ServerVar] // RVA: 0xBE220 Offset: 0xBD620 VA: 0x1800BE220
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

