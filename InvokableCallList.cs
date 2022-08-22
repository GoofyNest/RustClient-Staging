internal class InvokableCallList // TypeDefIndex: 3637
{	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private readonly List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x182FE50 Offset: 0x182E450 VA: 0x18182FE50
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x182FDF0 Offset: 0x182E3F0 VA: 0x18182FDF0
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x182FFE0 Offset: 0x182E5E0 VA: 0x18182FFE0
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x182FF00 Offset: 0x182E500 VA: 0x18182FF00
	public void Clear() { }

	// RVA: 0x182FEB0 Offset: 0x182E4B0 VA: 0x18182FEB0
	public void ClearPersistent() { }

	// RVA: 0x182FF50 Offset: 0x182E550 VA: 0x18182FF50
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x1830160 Offset: 0x182E760 VA: 0x181830160
	public void .ctor() { }

}

