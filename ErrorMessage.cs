internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 1236
{	// Fields
	private string _uri; // 0x10

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; }
	public LogicalCallContext LogicalCallContext { get; }

	// Methods

	// RVA: 0x1476CD0 Offset: 0x14752D0 VA: 0x181476CD0
	public void .ctor() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1476D20 Offset: 0x1475320 VA: 0x181476D20 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x1476D50 Offset: 0x1475350 VA: 0x181476D50 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 11
	public string get_Uri() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

}

