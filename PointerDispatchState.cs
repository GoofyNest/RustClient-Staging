internal class PointerDispatchState // TypeDefIndex: 4604
{	// Fields
	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20

	// Methods

	// RVA: 0xEB7F30 Offset: 0xEB6530 VA: 0x180EB7F30
	public void .ctor() { }

	// RVA: 0xEB7D90 Offset: 0xEB6390 VA: 0x180EB7D90
	internal void Reset() { }

	// RVA: 0x9EB8A0 Offset: 0x9E9EA0 VA: 0x1809EB8A0
	public IEventHandler GetCapturingElement(int pointerId) { }

	// RVA: 0xEB75C0 Offset: 0xEB5BC0 VA: 0x180EB75C0
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0xEB7460 Offset: 0xEB5A60 VA: 0x180EB7460
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0xEB7D40 Offset: 0xEB6340 VA: 0x180EB7D40
	public void ReleasePointer(int pointerId) { }

	// RVA: 0xEB7CE0 Offset: 0xEB62E0 VA: 0x180EB7CE0
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0xEB7640 Offset: 0xEB5C40 VA: 0x180EB7640
	public void ProcessPointerCapture(int pointerId) { }

	// RVA: 0xEB7420 Offset: 0xEB5A20 VA: 0x180EB7420
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0xEB7600 Offset: 0xEB5C00 VA: 0x180EB7600
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0xEB7E80 Offset: 0xEB6480 VA: 0x180EB7E80
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

