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

	// RVA: 0x148BCA0 Offset: 0x148A2A0 VA: 0x18148BCA0
	private static void .cctor() { }

	// RVA: 0x148A9B0 Offset: 0x1488FB0 VA: 0x18148A9B0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x148A1E0 Offset: 0x14887E0 VA: 0x18148A1E0
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x148AA50 Offset: 0x1489050 VA: 0x18148AA50
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x148A1F0 Offset: 0x14887F0 VA: 0x18148A1F0
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x1487980 Offset: 0x1485F80 VA: 0x181487980
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x1487A20 Offset: 0x1486020 VA: 0x181487A20
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x148A140 Offset: 0x1488740 VA: 0x18148A140
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x148B6C0 Offset: 0x1489CC0 VA: 0x18148B6C0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x148B720 Offset: 0x1489D20 VA: 0x18148B720
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x148AAF0 Offset: 0x14890F0 VA: 0x18148AAF0
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x148AAA0 Offset: 0x14890A0 VA: 0x18148AAA0
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x148AB50 Offset: 0x1489150 VA: 0x18148AB50
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x148A070 Offset: 0x1488670 VA: 0x18148A070
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x1489440 Offset: 0x1487A40 VA: 0x181489440
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x1489600 Offset: 0x1487C00 VA: 0x181489600
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1488AF0 Offset: 0x14870F0 VA: 0x181488AF0
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1489870 Offset: 0x1487E70 VA: 0x181489870
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x148A9C0 Offset: 0x1488FC0 VA: 0x18148A9C0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x1487D90 Offset: 0x1486390 VA: 0x181487D90
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x1487EF0 Offset: 0x14864F0 VA: 0x181487EF0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x14880D0 Offset: 0x14866D0 VA: 0x1814880D0
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1487C00 Offset: 0x1486200 VA: 0x181487C00
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x1488D40 Offset: 0x1487340 VA: 0x181488D40
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x148B250 Offset: 0x1489850 VA: 0x18148B250
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x1489910 Offset: 0x1487F10 VA: 0x181489910
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x1488C40 Offset: 0x1487240 VA: 0x181488C40
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x14881C0 Offset: 0x14867C0 VA: 0x1814881C0
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x1487AD0 Offset: 0x14860D0 VA: 0x181487AD0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x14882B0 Offset: 0x14868B0 VA: 0x1814882B0
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x148B040 Offset: 0x1489640 VA: 0x18148B040
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x1489F60 Offset: 0x1488560 VA: 0x181489F60
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x148A0C0 Offset: 0x14886C0 VA: 0x18148A0C0
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x148B360 Offset: 0x1489960 VA: 0x18148B360
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x14883D0 Offset: 0x14869D0 VA: 0x1814883D0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x148B500 Offset: 0x1489B00 VA: 0x18148B500
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x148AFF0 Offset: 0x14895F0 VA: 0x18148AFF0
	private static void RegisterInternalChannels() { }

	// RVA: 0x1488890 Offset: 0x1486E90 VA: 0x181488890
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x14890F0 Offset: 0x14876F0 VA: 0x1814890F0
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x148B600 Offset: 0x1489C00 VA: 0x18148B600
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x148BAB0 Offset: 0x148A0B0 VA: 0x18148BAB0
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x1489800 Offset: 0x1487E00 VA: 0x181489800
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

