public class UnityEvent : UnityEventBase // TypeDefIndex: 3640
{	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18346A0 Offset: 0x1832CA0 VA: 0x1818346A0
	public void .ctor() { }

	// RVA: 0x1834260 Offset: 0x1832860 VA: 0x181834260
	public void AddListener(UnityAction call) { }

	// RVA: 0x1834310 Offset: 0x1832910 VA: 0x181834310 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	// RVA: 0x1834370 Offset: 0x1832970 VA: 0x181834370 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x18343E0 Offset: 0x18329E0 VA: 0x1818343E0
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x1834440 Offset: 0x1832A40 VA: 0x181834440
	public void Invoke() { }

}

