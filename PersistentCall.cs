internal class PersistentCall // TypeDefIndex: 3635
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xE00E0 Offset: 0xDF4E0 VA: 0x1800E00E0
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

	// Properties
	public Object target { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }

	// Methods

	// RVA: 0x181D9F0 Offset: 0x181BFF0 VA: 0x18181D9F0
	public Object get_target() { }

	// RVA: 0x181D9E0 Offset: 0x181BFE0 VA: 0x18181D9E0
	public string get_methodName() { }

	// RVA: 0x181D9C0 Offset: 0x181BFC0 VA: 0x18181D9C0
	public PersistentListenerMode get_mode() { }

	// RVA: 0x181D9D0 Offset: 0x181BFD0 VA: 0x18181D9D0
	public ArgumentCache get_arguments() { }

	// RVA: 0x1832820 Offset: 0x1830E20 VA: 0x181832820
	public bool IsValid() { }

	// RVA: 0x18324C0 Offset: 0x1830AC0 VA: 0x1818324C0
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x1831F70 Offset: 0x1830570 VA: 0x181831F70
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x18328B0 Offset: 0x1830EB0 VA: 0x1818328B0
	public void .ctor() { }

}

