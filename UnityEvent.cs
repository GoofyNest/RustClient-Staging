public class UnityEvent : UnityEventBase // TypeDefIndex: 3640
{	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1822260 Offset: 0x1820860 VA: 0x181822260
	public void .ctor() { }

	// RVA: 0x1821E20 Offset: 0x1820420 VA: 0x181821E20
	public void AddListener(UnityAction call) { }

	// RVA: 0x1821ED0 Offset: 0x18204D0 VA: 0x181821ED0 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	// RVA: 0x1821F30 Offset: 0x1820530 VA: 0x181821F30 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x1821FA0 Offset: 0x18205A0 VA: 0x181821FA0
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x1822000 Offset: 0x1820600 VA: 0x181822000
	public void Invoke() { }

}

