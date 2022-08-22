internal class PersistentCall // TypeDefIndex: 3635
{	[FormerlySerializedAsAttribute] // RVA: 0xE00E0 Offset: 0xDF4E0 VA: 0x1800E00E0
	[SerializeField] // RVA: 0xE00E0 Offset: 0xDF4E0 VA: 0x1800E00E0
	private Object m_Target; // 0x10
	[SerializeField] // RVA: 0xE0230 Offset: 0xDF630 VA: 0x1800E0230
	[FormerlySerializedAsAttribute] // RVA: 0xE0230 Offset: 0xDF630 VA: 0x1800E0230
	private string m_MethodName; // 0x18
	[SerializeField] // RVA: 0xE0300 Offset: 0xDF700 VA: 0x1800E0300
	[FormerlySerializedAsAttribute] // RVA: 0xE0300 Offset: 0xDF700 VA: 0x1800E0300
	private PersistentListenerMode m_Mode; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE04A0 Offset: 0xDF8A0 VA: 0x1800E04A0
	[SerializeField] // RVA: 0xE04A0 Offset: 0xDF8A0 VA: 0x1800E04A0
	private ArgumentCache m_Arguments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xE05E0 Offset: 0xDF9E0 VA: 0x1800E05E0
	[SerializeField] // RVA: 0xE05E0 Offset: 0xDF9E0 VA: 0x1800E05E0
	[FormerlySerializedAsAttribute] // RVA: 0xE05E0 Offset: 0xDF9E0 VA: 0x1800E05E0
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

