public class UnityEvent : UnityEventBase // TypeDefIndex: 3640
{	private object[] m_InvokeArray; // 0x28


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor() { }

	public void AddListener(UnityAction call) { }

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	public void Invoke() { }

}

