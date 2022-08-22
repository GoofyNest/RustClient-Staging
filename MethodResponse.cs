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

	// RVA: 0x1472C20 Offset: 0x1471220 VA: 0x181472C20
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x147EFD0 Offset: 0x147D5D0 VA: 0x18147EFD0
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x147EC60 Offset: 0x147D260 VA: 0x18147EC60
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x147E7F0 Offset: 0x147CDF0 VA: 0x18147E7F0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147E400 Offset: 0x147CA00 VA: 0x18147E400
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x147F0A0 Offset: 0x147D6A0 VA: 0x18147F0A0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x147F0B0 Offset: 0x147D6B0 VA: 0x18147F0B0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x147F120 Offset: 0x147D720 VA: 0x18147F120 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x147F2A0 Offset: 0x147D8A0 VA: 0x18147F2A0 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x147F320 Offset: 0x147D920 VA: 0x18147F320 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x147F3D0 Offset: 0x147D9D0 VA: 0x18147F3D0 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x1472D50 Offset: 0x1471350 VA: 0x181472D50 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x147F5F0 Offset: 0x147DBF0 VA: 0x18147F5F0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x147E770 Offset: 0x147CD70 VA: 0x18147E770 Slot: 14
	public string get_Uri() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Uri(string value) { }

	// RVA: 0x147E770 Offset: 0x147CD70 VA: 0x18147E770 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x147E0E0 Offset: 0x147C6E0 VA: 0x18147E0E0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x147E120 Offset: 0x147C720 VA: 0x18147E120 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

