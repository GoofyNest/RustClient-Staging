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

	// RVA: 0x12D1260 Offset: 0x12CF860 VA: 0x1812D1260
	protected void .ctor() { }

	// RVA: 0x1484570 Offset: 0x1482B70 VA: 0x181484570
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x1484500 Offset: 0x1482B00 VA: 0x181484500
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x14843F0 Offset: 0x14829F0 VA: 0x1814843F0
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x1483030 Offset: 0x1481630 VA: 0x181483030
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x1482E70 Offset: 0x1481470 VA: 0x181482E70
	public Type GetProxiedType() { }

	// RVA: 0x1482DF0 Offset: 0x14813F0 VA: 0x181482DF0 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x1483050 Offset: 0x1481650 VA: 0x181483050
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x1483040 Offset: 0x1481640 VA: 0x181483040 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x1482F00 Offset: 0x1481500 VA: 0x181482F00 Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x1482CD0 Offset: 0x14812D0 VA: 0x181482CD0
	internal object GetAppDomainTarget() { }

	// RVA: 0x1483E70 Offset: 0x1482470 VA: 0x181483E70
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

}

