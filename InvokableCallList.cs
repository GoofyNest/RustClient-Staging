internal class InvokableCallList // TypeDefIndex: 3637
{	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private readonly List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x1830110 Offset: 0x182E710 VA: 0x181830110
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x18300B0 Offset: 0x182E6B0 VA: 0x1818300B0
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x18302A0 Offset: 0x182E8A0 VA: 0x1818302A0
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x18301C0 Offset: 0x182E7C0 VA: 0x1818301C0
	public void Clear() { }

	// RVA: 0x1830170 Offset: 0x182E770 VA: 0x181830170
	public void ClearPersistent() { }

	// RVA: 0x1830210 Offset: 0x182E810 VA: 0x181830210
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x1830420 Offset: 0x182EA20 VA: 0x181830420
	public void .ctor() { }

}

