public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 3638
{	// Fields
	private InvokableCallList m_Calls; // 0x10
	[SerializeField] // RVA: 0xE0BE0 Offset: 0xDFFE0 VA: 0x1800E0BE0
	[FormerlySerializedAsAttribute] // RVA: 0xE0BE0 Offset: 0xDFFE0 VA: 0x1800E0BE0
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x1821C90 Offset: 0x1820290 VA: 0x181821C90
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1821180 Offset: 0x181F780 VA: 0x181821180 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, object targetObj);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x18211E0 Offset: 0x181F7E0 VA: 0x1818211E0
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x1821350 Offset: 0x181F950 VA: 0x181821350
	internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x1821180 Offset: 0x181F780 VA: 0x181821180
	private void DirtyPersistentCalls() { }

	// RVA: 0x18219F0 Offset: 0x181FFF0 VA: 0x1818219F0
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x1821120 Offset: 0x181F720 VA: 0x181821120
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x1821A80 Offset: 0x1820080 VA: 0x181821A80
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x1821A30 Offset: 0x1820030 VA: 0x181821A30
	public void RemoveAllListeners() { }

	// RVA: 0x1821930 Offset: 0x181FF30 VA: 0x181821930
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x1821C10 Offset: 0x1820210 VA: 0x181821C10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1821750 Offset: 0x181FD50 VA: 0x181821750
	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes) { }

}

