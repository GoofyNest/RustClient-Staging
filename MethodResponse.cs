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

	// RVA: 0x1473B50 Offset: 0x1472150 VA: 0x181473B50
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x147FF00 Offset: 0x147E500 VA: 0x18147FF00
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x147FB90 Offset: 0x147E190 VA: 0x18147FB90
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x147F720 Offset: 0x147DD20 VA: 0x18147F720
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147F330 Offset: 0x147D930 VA: 0x18147F330
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x147FFD0 Offset: 0x147E5D0 VA: 0x18147FFD0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x147FFE0 Offset: 0x147E5E0 VA: 0x18147FFE0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x1480050 Offset: 0x147E650 VA: 0x181480050 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x14801D0 Offset: 0x147E7D0 VA: 0x1814801D0 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x1480250 Offset: 0x147E850 VA: 0x181480250 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x1480300 Offset: 0x147E900 VA: 0x181480300 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x1473C80 Offset: 0x1472280 VA: 0x181473C80 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x1480520 Offset: 0x147EB20 VA: 0x181480520 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x147F6A0 Offset: 0x147DCA0 VA: 0x18147F6A0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Uri(string value) { }

	// RVA: 0x147F6A0 Offset: 0x147DCA0 VA: 0x18147F6A0 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x147F010 Offset: 0x147D610 VA: 0x18147F010 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x147F050 Offset: 0x147D650 VA: 0x18147F050 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

