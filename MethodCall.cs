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

	// RVA: 0x1473670 Offset: 0x1471C70 VA: 0x181473670
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147E780 Offset: 0x147CD80 VA: 0x18147E780
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x147D650 Offset: 0x147BC50 VA: 0x18147D650
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x147DC20 Offset: 0x147C220 VA: 0x18147DC20 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x147D820 Offset: 0x147BE20 VA: 0x18147D820 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147E9F0 Offset: 0x147CFF0 VA: 0x18147E9F0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x147EA70 Offset: 0x147D070 VA: 0x18147EA70 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x147EAE0 Offset: 0x147D0E0 VA: 0x18147EAE0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x147EB10 Offset: 0x147D110 VA: 0x18147EB10 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x147EB60 Offset: 0x147D160 VA: 0x18147EB60 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x1473860 Offset: 0x1471E60 VA: 0x181473860 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x147DB70 Offset: 0x147C170 VA: 0x18147DB70 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x147ECE0 Offset: 0x147D2E0 VA: 0x18147ECE0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Uri(string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x147D7E0 Offset: 0x147BDE0 VA: 0x18147D7E0 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public virtual void Init() { }

	// RVA: 0x147DF40 Offset: 0x147C540 VA: 0x18147DF40
	public void ResolveMethod() { }

	// RVA: 0x147D440 Offset: 0x147BA40 VA: 0x18147D440
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x147DAE0 Offset: 0x147C0E0 VA: 0x18147DAE0
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x147EA10 Offset: 0x147D010 VA: 0x18147EA10
	private Type[] get_GenericArguments() { }

}

