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

	// RVA: 0x1472A00 Offset: 0x1471000 VA: 0x181472A00
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147DB10 Offset: 0x147C110 VA: 0x18147DB10
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x147C9E0 Offset: 0x147AFE0 VA: 0x18147C9E0
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x147CFB0 Offset: 0x147B5B0 VA: 0x18147CFB0 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x147CBB0 Offset: 0x147B1B0 VA: 0x18147CBB0 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147DD80 Offset: 0x147C380 VA: 0x18147DD80 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x147DE00 Offset: 0x147C400 VA: 0x18147DE00 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x147DE70 Offset: 0x147C470 VA: 0x18147DE70 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x147DEA0 Offset: 0x147C4A0 VA: 0x18147DEA0 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x147DEF0 Offset: 0x147C4F0 VA: 0x18147DEF0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x1472BF0 Offset: 0x14711F0 VA: 0x181472BF0 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x147CF00 Offset: 0x147B500 VA: 0x18147CF00 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x147E070 Offset: 0x147C670 VA: 0x18147E070 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 11
	public string get_Uri() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Uri(string value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x147CB70 Offset: 0x147B170 VA: 0x18147CB70 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public virtual void Init() { }

	// RVA: 0x147D2D0 Offset: 0x147B8D0 VA: 0x18147D2D0
	public void ResolveMethod() { }

	// RVA: 0x147C7D0 Offset: 0x147ADD0 VA: 0x18147C7D0
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x147CE70 Offset: 0x147B470 VA: 0x18147CE70
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x147DDA0 Offset: 0x147C3A0 VA: 0x18147DDA0
	private Type[] get_GenericArguments() { }

}

