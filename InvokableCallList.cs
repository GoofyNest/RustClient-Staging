internal class InvokableCallList // TypeDefIndex: 3637
{	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private readonly List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x181D550 Offset: 0x181BB50 VA: 0x18181D550
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x181D4F0 Offset: 0x181BAF0 VA: 0x18181D4F0
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x181D6E0 Offset: 0x181BCE0 VA: 0x18181D6E0
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x181D600 Offset: 0x181BC00 VA: 0x18181D600
	public void Clear() { }

	// RVA: 0x181D5B0 Offset: 0x181BBB0 VA: 0x18181D5B0
	public void ClearPersistent() { }

	// RVA: 0x181D650 Offset: 0x181BC50 VA: 0x18181D650
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x181D860 Offset: 0x181BE60 VA: 0x18181D860
	public void .ctor() { }

}

