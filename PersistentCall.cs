internal class PersistentCall // TypeDefIndex: 3635
{	[FormerlySerializedAsAttribute] // RVA: 0xE01F0 Offset: 0xDF5F0 VA: 0x1800E01F0
	[SerializeField] // RVA: 0xE01F0 Offset: 0xDF5F0 VA: 0x1800E01F0
	private Object m_Target; // 0x10
	[SerializeField] // RVA: 0xE0300 Offset: 0xDF700 VA: 0x1800E0300
	[FormerlySerializedAsAttribute] // RVA: 0xE0300 Offset: 0xDF700 VA: 0x1800E0300
	private string m_MethodName; // 0x18
	[SerializeField] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	[FormerlySerializedAsAttribute] // RVA: 0xE03B0 Offset: 0xDF7B0 VA: 0x1800E03B0
	private PersistentListenerMode m_Mode; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE0520 Offset: 0xDF920 VA: 0x1800E0520
	[SerializeField] // RVA: 0xE0520 Offset: 0xDF920 VA: 0x1800E0520
	private ArgumentCache m_Arguments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xE05F0 Offset: 0xDF9F0 VA: 0x1800E05F0
	[FormerlySerializedAsAttribute] // RVA: 0xE05F0 Offset: 0xDF9F0 VA: 0x1800E05F0
	[SerializeField] // RVA: 0xE05F0 Offset: 0xDF9F0 VA: 0x1800E05F0
	private UnityEventCallState m_CallState; // 0x30

	public Object target { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }


	public Object get_target() { }

	public string get_methodName() { }

	public PersistentListenerMode get_mode() { }

	public ArgumentCache get_arguments() { }

	public bool IsValid() { }

	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	public void .ctor() { }

}

