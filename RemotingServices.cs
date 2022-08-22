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

	// RVA: 0x148B030 Offset: 0x1489630 VA: 0x18148B030
	private static void .cctor() { }

	// RVA: 0x1489D40 Offset: 0x1488340 VA: 0x181489D40
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x1489570 Offset: 0x1487B70 VA: 0x181489570
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x1489DE0 Offset: 0x14883E0 VA: 0x181489DE0
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x1489580 Offset: 0x1487B80 VA: 0x181489580
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x1486D10 Offset: 0x1485310 VA: 0x181486D10
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x1486DB0 Offset: 0x14853B0 VA: 0x181486DB0
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x14894D0 Offset: 0x1487AD0 VA: 0x1814894D0
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x148AA50 Offset: 0x1489050 VA: 0x18148AA50
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x148AAB0 Offset: 0x14890B0 VA: 0x18148AAB0
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x1489E80 Offset: 0x1488480 VA: 0x181489E80
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x1489E30 Offset: 0x1488430 VA: 0x181489E30
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x1489EE0 Offset: 0x14884E0 VA: 0x181489EE0
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1489400 Offset: 0x1487A00 VA: 0x181489400
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x14887D0 Offset: 0x1486DD0 VA: 0x1814887D0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x1488990 Offset: 0x1486F90 VA: 0x181488990
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1487E80 Offset: 0x1486480 VA: 0x181487E80
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1488C00 Offset: 0x1487200 VA: 0x181488C00
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1489D50 Offset: 0x1488350 VA: 0x181489D50
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x1487120 Offset: 0x1485720 VA: 0x181487120
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x1487280 Offset: 0x1485880 VA: 0x181487280
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x1487460 Offset: 0x1485A60 VA: 0x181487460
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1486F90 Offset: 0x1485590 VA: 0x181486F90
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x14880D0 Offset: 0x14866D0 VA: 0x1814880D0
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x148A5E0 Offset: 0x1488BE0 VA: 0x18148A5E0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x1488CA0 Offset: 0x14872A0 VA: 0x181488CA0
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x1487FD0 Offset: 0x14865D0 VA: 0x181487FD0
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x1487550 Offset: 0x1485B50 VA: 0x181487550
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x1486E60 Offset: 0x1485460 VA: 0x181486E60
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x1487640 Offset: 0x1485C40 VA: 0x181487640
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x148A3D0 Offset: 0x14889D0 VA: 0x18148A3D0
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x14892F0 Offset: 0x14878F0 VA: 0x1814892F0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x1489450 Offset: 0x1487A50 VA: 0x181489450
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x148A6F0 Offset: 0x1488CF0 VA: 0x18148A6F0
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x1487760 Offset: 0x1485D60 VA: 0x181487760
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x148A890 Offset: 0x1488E90 VA: 0x18148A890
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x148A380 Offset: 0x1488980 VA: 0x18148A380
	private static void RegisterInternalChannels() { }

	// RVA: 0x1487C20 Offset: 0x1486220 VA: 0x181487C20
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x1488480 Offset: 0x1486A80 VA: 0x181488480
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x148A990 Offset: 0x1488F90 VA: 0x18148A990
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x148AE40 Offset: 0x1489440 VA: 0x18148AE40
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x1488B90 Offset: 0x1487190 VA: 0x181488B90
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

