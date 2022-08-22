internal class TransparentProxy // TypeDefIndex: 1160
{	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x148D920 Offset: 0x148BF20 VA: 0x18148D920
	internal RuntimeType GetProxyType() { }

	// RVA: 0x148E130 Offset: 0x148C730 VA: 0x18148E130
	private bool get_IsContextBoundObject() { }

	// RVA: 0x4D20B0 Offset: 0x4D06B0 VA: 0x1804D20B0
	private Context get_TargetContext() { }

	// RVA: 0x148D9E0 Offset: 0x148BFE0 VA: 0x18148D9E0
	private bool InCurrentContext() { }

	// RVA: 0x148DAE0 Offset: 0x148C0E0 VA: 0x18148DAE0
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x148DE00 Offset: 0x148C400 VA: 0x18148DE00
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

