internal class PersistentCall // TypeDefIndex: 3635
{	[FormerlySerializedAsAttribute] // RVA: 0xE01B0 Offset: 0xDF5B0 VA: 0x1800E01B0
	[SerializeField] // RVA: 0xE01B0 Offset: 0xDF5B0 VA: 0x1800E01B0
	private Object m_Target; // 0x10
	[SerializeField] // RVA: 0xE0300 Offset: 0xDF700 VA: 0x1800E0300
	[FormerlySerializedAsAttribute] // RVA: 0xE0300 Offset: 0xDF700 VA: 0x1800E0300
	private string m_MethodName; // 0x18
	[SerializeField] // RVA: 0xE03C0 Offset: 0xDF7C0 VA: 0x1800E03C0
	[FormerlySerializedAsAttribute] // RVA: 0xE03C0 Offset: 0xDF7C0 VA: 0x1800E03C0
	private PersistentListenerMode m_Mode; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE0560 Offset: 0xDF960 VA: 0x1800E0560
	[SerializeField] // RVA: 0xE0560 Offset: 0xDF960 VA: 0x1800E0560
	private ArgumentCache m_Arguments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xE0680 Offset: 0xDFA80 VA: 0x1800E0680
	[FormerlySerializedAsAttribute] // RVA: 0xE0680 Offset: 0xDFA80 VA: 0x1800E0680
	[SerializeField] // RVA: 0xE0680 Offset: 0xDFA80 VA: 0x1800E0680
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

