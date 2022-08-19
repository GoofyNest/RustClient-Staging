public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 3638
{	// Fields
	private InvokableCallList m_Calls; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE0B60 Offset: 0xDFF60 VA: 0x1800E0B60
	[SerializeField] // RVA: 0xE0B60 Offset: 0xDFF60 VA: 0x1800E0B60
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x18340D0 Offset: 0x18326D0 VA: 0x1818340D0
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x18335C0 Offset: 0x1831BC0 VA: 0x1818335C0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, object targetObj);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x1833620 Offset: 0x1831C20 VA: 0x181833620
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x1833790 Offset: 0x1831D90 VA: 0x181833790
	internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x18335C0 Offset: 0x1831BC0 VA: 0x1818335C0
	private void DirtyPersistentCalls() { }

	// RVA: 0x1833E30 Offset: 0x1832430 VA: 0x181833E30
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x1833560 Offset: 0x1831B60 VA: 0x181833560
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x1833EC0 Offset: 0x18324C0 VA: 0x181833EC0
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x1833E70 Offset: 0x1832470 VA: 0x181833E70
	public void RemoveAllListeners() { }

	// RVA: 0x1833D70 Offset: 0x1832370 VA: 0x181833D70
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x1834050 Offset: 0x1832650 VA: 0x181834050 Slot: 3
	public override string ToString() { }

	// RVA: 0x1833B90 Offset: 0x1832190 VA: 0x181833B90
	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes) { }

}

