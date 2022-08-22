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

	// RVA: 0x12D1520 Offset: 0x12CFB20 VA: 0x1812D1520
	protected void .ctor() { }

	// RVA: 0x1484830 Offset: 0x1482E30 VA: 0x181484830
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x14847C0 Offset: 0x1482DC0 VA: 0x1814847C0
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x14846B0 Offset: 0x1482CB0 VA: 0x1814846B0
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x14832F0 Offset: 0x14818F0 VA: 0x1814832F0
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x1483130 Offset: 0x1481730 VA: 0x181483130
	public Type GetProxiedType() { }

	// RVA: 0x14830B0 Offset: 0x14816B0 VA: 0x1814830B0 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x1483310 Offset: 0x1481910 VA: 0x181483310
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x1483300 Offset: 0x1481900 VA: 0x181483300 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x14831C0 Offset: 0x14817C0 VA: 0x1814831C0 Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x1482F90 Offset: 0x1481590 VA: 0x181482F90
	internal object GetAppDomainTarget() { }

	// RVA: 0x1484130 Offset: 0x1482730 VA: 0x181484130
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

}

