internal class TransparentProxy // TypeDefIndex: 1160
{	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x148E590 Offset: 0x148CB90 VA: 0x18148E590
	internal RuntimeType GetProxyType() { }

	// RVA: 0x148EDA0 Offset: 0x148D3A0 VA: 0x18148EDA0
	private bool get_IsContextBoundObject() { }

	// RVA: 0x4D2120 Offset: 0x4D0720 VA: 0x1804D2120
	private Context get_TargetContext() { }

	// RVA: 0x148E650 Offset: 0x148CC50 VA: 0x18148E650
	private bool InCurrentContext() { }

	// RVA: 0x148E750 Offset: 0x148CD50 VA: 0x18148E750
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x148EA70 Offset: 0x148D070 VA: 0x18148EA70
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

