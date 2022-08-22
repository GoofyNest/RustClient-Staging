public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 3638
{	// Fields
	private InvokableCallList m_Calls; // 0x10
	[SerializeField] // RVA: 0xE0BE0 Offset: 0xDFFE0 VA: 0x1800E0BE0
	[FormerlySerializedAsAttribute] // RVA: 0xE0BE0 Offset: 0xDFFE0 VA: 0x1800E0BE0
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x1834350 Offset: 0x1832950 VA: 0x181834350
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1833840 Offset: 0x1831E40 VA: 0x181833840 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, object targetObj);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x18338A0 Offset: 0x1831EA0 VA: 0x1818338A0
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x1833A10 Offset: 0x1832010 VA: 0x181833A10
	internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x1833840 Offset: 0x1831E40 VA: 0x181833840
	private void DirtyPersistentCalls() { }

	// RVA: 0x18340B0 Offset: 0x18326B0 VA: 0x1818340B0
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x18337E0 Offset: 0x1831DE0 VA: 0x1818337E0
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x1834140 Offset: 0x1832740 VA: 0x181834140
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x18340F0 Offset: 0x18326F0 VA: 0x1818340F0
	public void RemoveAllListeners() { }

	// RVA: 0x1833FF0 Offset: 0x18325F0 VA: 0x181833FF0
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x18342D0 Offset: 0x18328D0 VA: 0x1818342D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1833E10 Offset: 0x1832410 VA: 0x181833E10
	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes) { }

}

