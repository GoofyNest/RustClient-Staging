internal class PersistentCall // TypeDefIndex: 3635
{	// Fields
	[SerializeField] // RVA: 0xDFFD0 Offset: 0xDF3D0 VA: 0x1800DFFD0
	[FormerlySerializedAsAttribute] // RVA: 0xDFFD0 Offset: 0xDF3D0 VA: 0x1800DFFD0
	private Object m_Target; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE01D0 Offset: 0xDF5D0 VA: 0x1800E01D0
	[SerializeField] // RVA: 0xE01D0 Offset: 0xDF5D0 VA: 0x1800E01D0
	private string m_MethodName; // 0x18
	[SerializeField] // RVA: 0xE0280 Offset: 0xDF680 VA: 0x1800E0280
	[FormerlySerializedAsAttribute] // RVA: 0xE0280 Offset: 0xDF680 VA: 0x1800E0280
	private PersistentListenerMode m_Mode; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE0420 Offset: 0xDF820 VA: 0x1800E0420
	[SerializeField] // RVA: 0xE0420 Offset: 0xDF820 VA: 0x1800E0420
	private ArgumentCache m_Arguments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xE0560 Offset: 0xDF960 VA: 0x1800E0560
	[SerializeField] // RVA: 0xE0560 Offset: 0xDF960 VA: 0x1800E0560
	[FormerlySerializedAsAttribute] // RVA: 0xE0560 Offset: 0xDF960 VA: 0x1800E0560
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

	// RVA: 0x1832860 Offset: 0x1830E60 VA: 0x181832860
	public bool IsValid() { }

	// RVA: 0x1832500 Offset: 0x1830B00 VA: 0x181832500
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x1831FB0 Offset: 0x18305B0 VA: 0x181831FB0
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x18328F0 Offset: 0x1830EF0 VA: 0x1818328F0
	public void .ctor() { }

}

