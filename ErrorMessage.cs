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

	// RVA: 0x1477C00 Offset: 0x1476200 VA: 0x181477C00
	public void .ctor() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1477C50 Offset: 0x1476250 VA: 0x181477C50 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x1477C80 Offset: 0x1476280 VA: 0x181477C80 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

}

