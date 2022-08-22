public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 3638
{	// Fields
	private InvokableCallList m_Calls; // 0x10
	[SerializeField] // RVA: 0xE0BE0 Offset: 0xDFFE0 VA: 0x1800E0BE0
	[FormerlySerializedAsAttribute] // RVA: 0xE0BE0 Offset: 0xDFFE0 VA: 0x1800E0BE0
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x1834090 Offset: 0x1832690 VA: 0x181834090
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1833580 Offset: 0x1831B80 VA: 0x181833580 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, object targetObj);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x18335E0 Offset: 0x1831BE0 VA: 0x1818335E0
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x1833750 Offset: 0x1831D50 VA: 0x181833750
	internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x1833580 Offset: 0x1831B80 VA: 0x181833580
	private void DirtyPersistentCalls() { }

	// RVA: 0x1833DF0 Offset: 0x18323F0 VA: 0x181833DF0
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x1833520 Offset: 0x1831B20 VA: 0x181833520
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x1833E80 Offset: 0x1832480 VA: 0x181833E80
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x1833E30 Offset: 0x1832430 VA: 0x181833E30
	public void RemoveAllListeners() { }

	// RVA: 0x1833D30 Offset: 0x1832330 VA: 0x181833D30
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x1834010 Offset: 0x1832610 VA: 0x181834010 Slot: 3
	public override string ToString() { }

	// RVA: 0x1833B50 Offset: 0x1832150 VA: 0x181833B50
	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes) { }

}

