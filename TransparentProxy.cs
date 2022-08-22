internal class TransparentProxy // TypeDefIndex: 1160
{	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x148E850 Offset: 0x148CE50 VA: 0x18148E850
	internal RuntimeType GetProxyType() { }

	// RVA: 0x148F060 Offset: 0x148D660 VA: 0x18148F060
	private bool get_IsContextBoundObject() { }

	// RVA: 0x4D2120 Offset: 0x4D0720 VA: 0x1804D2120
	private Context get_TargetContext() { }

	// RVA: 0x148E910 Offset: 0x148CF10 VA: 0x18148E910
	private bool InCurrentContext() { }

	// RVA: 0x148EA10 Offset: 0x148D010 VA: 0x18148EA10
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x148ED30 Offset: 0x148D330 VA: 0x18148ED30
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

