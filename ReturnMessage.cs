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

	// RVA: 0x148C820 Offset: 0x148AE20 VA: 0x18148C820
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x148C750 Offset: 0x148AD50 VA: 0x18148C750
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x517840 Offset: 0x515E40 VA: 0x180517840 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x148C920 Offset: 0x148AF20 VA: 0x18148C920 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x148C990 Offset: 0x148AF90 VA: 0x18148C990 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x148CA00 Offset: 0x148B000 VA: 0x18148CA00 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x148CC70 Offset: 0x148B270 VA: 0x18148CC70 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x148CCF0 Offset: 0x148B2F0 VA: 0x18148CCF0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 14
	public string get_Uri() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_Uri(string value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x1275410 Offset: 0x1273A10 VA: 0x181275410 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x148CB90 Offset: 0x148B190 VA: 0x18148CB90 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}
