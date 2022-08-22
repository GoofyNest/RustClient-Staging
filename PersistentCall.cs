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

	// RVA: 0x180B0F0 Offset: 0x18096F0 VA: 0x18180B0F0
	public Object get_target() { }

	// RVA: 0x180B0E0 Offset: 0x18096E0 VA: 0x18180B0E0
	public string get_methodName() { }

	// RVA: 0x180B0C0 Offset: 0x18096C0 VA: 0x18180B0C0
	public PersistentListenerMode get_mode() { }

	// RVA: 0x180B0D0 Offset: 0x18096D0 VA: 0x18180B0D0
	public ArgumentCache get_arguments() { }

	// RVA: 0x1820420 Offset: 0x181EA20 VA: 0x181820420
	public bool IsValid() { }

	// RVA: 0x18200C0 Offset: 0x181E6C0 VA: 0x1818200C0
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x181FB70 Offset: 0x181E170 VA: 0x18181FB70
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x18204B0 Offset: 0x181EAB0 VA: 0x1818204B0
	public void .ctor() { }

}

