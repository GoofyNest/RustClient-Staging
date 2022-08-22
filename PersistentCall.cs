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

	// RVA: 0x181DCB0 Offset: 0x181C2B0 VA: 0x18181DCB0
	public Object get_target() { }

	// RVA: 0x181DCA0 Offset: 0x181C2A0 VA: 0x18181DCA0
	public string get_methodName() { }

	// RVA: 0x181DC80 Offset: 0x181C280 VA: 0x18181DC80
	public PersistentListenerMode get_mode() { }

	// RVA: 0x181DC90 Offset: 0x181C290 VA: 0x18181DC90
	public ArgumentCache get_arguments() { }

	// RVA: 0x1832AE0 Offset: 0x18310E0 VA: 0x181832AE0
	public bool IsValid() { }

	// RVA: 0x1832780 Offset: 0x1830D80 VA: 0x181832780
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x1832230 Offset: 0x1830830 VA: 0x181832230
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x1832B70 Offset: 0x1831170 VA: 0x181832B70
	public void .ctor() { }

}

