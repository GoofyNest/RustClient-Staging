public abstract class RealProxy // TypeDefIndex: 1161
{	// Fields
	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	// Properties
	internal Identity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x12D79D0 Offset: 0x12D5FD0 VA: 0x1812D79D0
	protected void .ctor() { }

	// RVA: 0x1483900 Offset: 0x1481F00 VA: 0x181483900
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x1483890 Offset: 0x1481E90 VA: 0x181483890
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x1483780 Offset: 0x1481D80 VA: 0x181483780
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x14823C0 Offset: 0x14809C0 VA: 0x1814823C0
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x1482200 Offset: 0x1480800 VA: 0x181482200
	public Type GetProxiedType() { }

	// RVA: 0x1482180 Offset: 0x1480780 VA: 0x181482180 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x14823E0 Offset: 0x14809E0 VA: 0x1814823E0
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x14823D0 Offset: 0x14809D0 VA: 0x1814823D0 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x1482290 Offset: 0x1480890 VA: 0x181482290 Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x1482060 Offset: 0x1480660 VA: 0x181482060
	internal object GetAppDomainTarget() { }

	// RVA: 0x1483200 Offset: 0x1481800 VA: 0x181483200
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

}

