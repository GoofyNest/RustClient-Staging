public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1258
{
	private object[] _outArgs;
	private object[] _args;
	private LogicalCallContext _callCtx;
	private object _returnValue;
	private string _uri;
	private Exception _exception;
	private MethodBase _methodBase;
	private string _methodName;
	private Type[] _methodSignature;
	private string _typeName;
	private MethodReturnDictionary _properties;
	private Identity _targetIdentity;
	private ArgInfo _inArgInfo;

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


	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	public int get_ArgCount() { }

	public object[] get_Args() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public virtual IDictionary get_Properties() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public void set_Uri(string value) { }

	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	public object GetArg(int argNum) { }

	public Exception get_Exception() { }

	public object[] get_OutArgs() { }

	public virtual object get_ReturnValue() { }

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

