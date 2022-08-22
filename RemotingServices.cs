public static class RemotingServices // TypeDefIndex: 1143
{	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x148BF60 Offset: 0x148A560 VA: 0x18148BF60
	private static void .cctor() { }

	// RVA: 0x148AC70 Offset: 0x1489270 VA: 0x18148AC70
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x148A4A0 Offset: 0x1488AA0 VA: 0x18148A4A0
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x148AD10 Offset: 0x1489310 VA: 0x18148AD10
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x148A4B0 Offset: 0x1488AB0 VA: 0x18148A4B0
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x1487C40 Offset: 0x1486240 VA: 0x181487C40
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x1487CE0 Offset: 0x14862E0 VA: 0x181487CE0
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x148A400 Offset: 0x1488A00 VA: 0x18148A400
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x148B980 Offset: 0x1489F80 VA: 0x18148B980
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x148B9E0 Offset: 0x1489FE0 VA: 0x18148B9E0
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x148ADB0 Offset: 0x14893B0 VA: 0x18148ADB0
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x148AD60 Offset: 0x1489360 VA: 0x18148AD60
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x148AE10 Offset: 0x1489410 VA: 0x18148AE10
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x148A330 Offset: 0x1488930 VA: 0x18148A330
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x1489700 Offset: 0x1487D00 VA: 0x181489700
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x14898C0 Offset: 0x1487EC0 VA: 0x1814898C0
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1488DB0 Offset: 0x14873B0 VA: 0x181488DB0
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1489B30 Offset: 0x1488130 VA: 0x181489B30
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x148AC80 Offset: 0x1489280 VA: 0x18148AC80
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x1488050 Offset: 0x1486650 VA: 0x181488050
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x14881B0 Offset: 0x14867B0 VA: 0x1814881B0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x1488390 Offset: 0x1486990 VA: 0x181488390
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1487EC0 Offset: 0x14864C0 VA: 0x181487EC0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x1489000 Offset: 0x1487600 VA: 0x181489000
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x148B510 Offset: 0x1489B10 VA: 0x18148B510
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x1489BD0 Offset: 0x14881D0 VA: 0x181489BD0
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x1488F00 Offset: 0x1487500 VA: 0x181488F00
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x1488480 Offset: 0x1486A80 VA: 0x181488480
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x1487D90 Offset: 0x1486390 VA: 0x181487D90
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x1488570 Offset: 0x1486B70 VA: 0x181488570
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x148B300 Offset: 0x1489900 VA: 0x18148B300
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x148A220 Offset: 0x1488820 VA: 0x18148A220
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x148A380 Offset: 0x1488980 VA: 0x18148A380
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x148B620 Offset: 0x1489C20 VA: 0x18148B620
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x1488690 Offset: 0x1486C90 VA: 0x181488690
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x148B7C0 Offset: 0x1489DC0 VA: 0x18148B7C0
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x148B2B0 Offset: 0x14898B0 VA: 0x18148B2B0
	private static void RegisterInternalChannels() { }

	// RVA: 0x1488B50 Offset: 0x1487150 VA: 0x181488B50
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x14893B0 Offset: 0x14879B0 VA: 0x1814893B0
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x148B8C0 Offset: 0x1489EC0 VA: 0x18148B8C0
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x148BD70 Offset: 0x148A370 VA: 0x18148BD70
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x1489AC0 Offset: 0x14880C0 VA: 0x181489AC0
	private static string GetNormalizedUri(string uri) { }

}

private class RemotingServices.CACD // TypeDefIndex: 1144
{	// Fields
	public object d; // 0x10
	public object c; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

