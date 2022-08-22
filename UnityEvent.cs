public class UnityEvent : UnityEventBase // TypeDefIndex: 3640
{	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1834660 Offset: 0x1832C60 VA: 0x181834660
	public void .ctor() { }

	// RVA: 0x1834220 Offset: 0x1832820 VA: 0x181834220
	public void AddListener(UnityAction call) { }

	// RVA: 0x18342D0 Offset: 0x18328D0 VA: 0x1818342D0 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	// RVA: 0x1834330 Offset: 0x1832930 VA: 0x181834330 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x18343A0 Offset: 0x18329A0 VA: 0x1818343A0
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x1834400 Offset: 0x1832A00 VA: 0x181834400
	public void Invoke() { }

}

