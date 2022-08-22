public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1246
{	// Fields
	private string _uri; // 0x10
	private string _typeName; // 0x18
	private string _methodName; // 0x20
	private object[] _args; // 0x28
	private Type[] _methodSignature; // 0x30
	private MethodBase _methodBase; // 0x38
	private LogicalCallContext _callContext; // 0x40
	private Identity _targetIdentity; // 0x48
	private Type[] _genericArguments; // 0x50
	protected IDictionary ExternalProperties; // 0x58
	protected IDictionary InternalProperties; // 0x60

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	private Type[] GenericArguments { get; }

	// Methods

	// RVA: 0x1473930 Offset: 0x1471F30 VA: 0x181473930
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147EA40 Offset: 0x147D040 VA: 0x18147EA40
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x147D910 Offset: 0x147BF10 VA: 0x18147D910
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x147DEE0 Offset: 0x147C4E0 VA: 0x18147DEE0 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x147DAE0 Offset: 0x147C0E0 VA: 0x18147DAE0 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147ECB0 Offset: 0x147D2B0 VA: 0x18147ECB0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x147ED30 Offset: 0x147D330 VA: 0x18147ED30 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x147EDA0 Offset: 0x147D3A0 VA: 0x18147EDA0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x147EDD0 Offset: 0x147D3D0 VA: 0x18147EDD0 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x147EE20 Offset: 0x147D420 VA: 0x18147EE20 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x1473B20 Offset: 0x1472120 VA: 0x181473B20 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x147DE30 Offset: 0x147C430 VA: 0x18147DE30 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x147EFA0 Offset: 0x147D5A0 VA: 0x18147EFA0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Uri(string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x147DAA0 Offset: 0x147C0A0 VA: 0x18147DAA0 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public virtual void Init() { }

	// RVA: 0x147E200 Offset: 0x147C800 VA: 0x18147E200
	public void ResolveMethod() { }

	// RVA: 0x147D700 Offset: 0x147BD00 VA: 0x18147D700
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x147DDA0 Offset: 0x147C3A0 VA: 0x18147DDA0
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x147ECD0 Offset: 0x147D2D0 VA: 0x18147ECD0
	private Type[] get_GenericArguments() { }

}

