internal class PointerDispatchState // TypeDefIndex: 4604
{	// Fields
	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20

	// Methods

	// RVA: 0xEB7C70 Offset: 0xEB6270 VA: 0x180EB7C70
	public void .ctor() { }

	// RVA: 0xEB7AD0 Offset: 0xEB60D0 VA: 0x180EB7AD0
	internal void Reset() { }

	// RVA: 0x9EB5E0 Offset: 0x9E9BE0 VA: 0x1809EB5E0
	public IEventHandler GetCapturingElement(int pointerId) { }

	// RVA: 0xEB7300 Offset: 0xEB5900 VA: 0x180EB7300
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0xEB71A0 Offset: 0xEB57A0 VA: 0x180EB71A0
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0xEB7A80 Offset: 0xEB6080 VA: 0x180EB7A80
	public void ReleasePointer(int pointerId) { }

	// RVA: 0xEB7A20 Offset: 0xEB6020 VA: 0x180EB7A20
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0xEB7380 Offset: 0xEB5980 VA: 0x180EB7380
	public void ProcessPointerCapture(int pointerId) { }

	// RVA: 0xEB7160 Offset: 0xEB5760 VA: 0x180EB7160
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0xEB7340 Offset: 0xEB5940 VA: 0x180EB7340
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0xEB7BC0 Offset: 0xEB61C0 VA: 0x180EB7BC0
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

