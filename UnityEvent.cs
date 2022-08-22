public class UnityEvent : UnityEventBase // TypeDefIndex: 3640
{	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1834920 Offset: 0x1832F20 VA: 0x181834920
	public void .ctor() { }

	// RVA: 0x18344E0 Offset: 0x1832AE0 VA: 0x1818344E0
	public void AddListener(UnityAction call) { }

	// RVA: 0x1834590 Offset: 0x1832B90 VA: 0x181834590 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	// RVA: 0x18345F0 Offset: 0x1832BF0 VA: 0x1818345F0 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x1834660 Offset: 0x1832C60 VA: 0x181834660
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x18346C0 Offset: 0x1832CC0 VA: 0x1818346C0
	public void Invoke() { }

}

