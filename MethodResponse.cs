public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1250
{	// Fields
	private string _methodName; // 0x10
	private string _uri; // 0x18
	private string _typeName; // 0x20
	private MethodBase _methodBase; // 0x28
	private object _returnValue; // 0x30
	private Exception _exception; // 0x38
	private Type[] _methodSignature; // 0x40
	private ArgInfo _inArgInfo; // 0x48
	private object[] _args; // 0x50
	private object[] _outArgs; // 0x58
	private IMethodCallMessage _callMsg; // 0x60
	private LogicalCallContext _callContext; // 0x68
	private Identity _targetIdentity; // 0x70
	protected IDictionary ExternalProperties; // 0x78
	protected IDictionary InternalProperties; // 0x80

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public Exception Exception { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public object[] OutArgs { get; }
	public virtual IDictionary Properties { get; }
	public object ReturnValue { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x1473890 Offset: 0x1471E90 VA: 0x181473890
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x147FC40 Offset: 0x147E240 VA: 0x18147FC40
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x147F8D0 Offset: 0x147DED0 VA: 0x18147F8D0
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x147F460 Offset: 0x147DA60 VA: 0x18147F460
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147F070 Offset: 0x147D670 VA: 0x18147F070
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x147FD10 Offset: 0x147E310 VA: 0x18147FD10 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x147FD20 Offset: 0x147E320 VA: 0x18147FD20 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x147FD90 Offset: 0x147E390 VA: 0x18147FD90 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x147FF10 Offset: 0x147E510 VA: 0x18147FF10 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x147FF90 Offset: 0x147E590 VA: 0x18147FF90 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x1480040 Offset: 0x147E640 VA: 0x181480040 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x14739C0 Offset: 0x1471FC0 VA: 0x1814739C0 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x1480260 Offset: 0x147E860 VA: 0x181480260 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x147F3E0 Offset: 0x147D9E0 VA: 0x18147F3E0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Uri(string value) { }

	// RVA: 0x147F3E0 Offset: 0x147D9E0 VA: 0x18147F3E0 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x147ED50 Offset: 0x147D350 VA: 0x18147ED50 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x147ED90 Offset: 0x147D390 VA: 0x18147ED90 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

