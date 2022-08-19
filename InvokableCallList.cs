internal class InvokableCallList // TypeDefIndex: 3637
{	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private readonly List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x182FE90 Offset: 0x182E490 VA: 0x18182FE90
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x182FE30 Offset: 0x182E430 VA: 0x18182FE30
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x1830020 Offset: 0x182E620 VA: 0x181830020
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x182FF40 Offset: 0x182E540 VA: 0x18182FF40
	public void Clear() { }

	// RVA: 0x182FEF0 Offset: 0x182E4F0 VA: 0x18182FEF0
	public void ClearPersistent() { }

	// RVA: 0x182FF90 Offset: 0x182E590 VA: 0x18182FF90
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x18301A0 Offset: 0x182E7A0 VA: 0x1818301A0
	public void .ctor() { }

}

