public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1258
{	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x148BBB0 Offset: 0x148A1B0 VA: 0x18148BBB0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x148BAE0 Offset: 0x148A0E0 VA: 0x18148BAE0
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x5177D0 Offset: 0x515DD0 VA: 0x1805177D0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x148BCB0 Offset: 0x148A2B0 VA: 0x18148BCB0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x148BD20 Offset: 0x148A320 VA: 0x18148BD20 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x148BD90 Offset: 0x148A390 VA: 0x18148BD90 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x148C000 Offset: 0x148A600 VA: 0x18148C000 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x148C080 Offset: 0x148A680 VA: 0x18148C080 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_Uri(string value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x1275D70 Offset: 0x1274370 VA: 0x181275D70 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x148BF20 Offset: 0x148A520 VA: 0x18148BF20 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

