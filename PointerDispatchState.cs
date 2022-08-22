internal class PointerDispatchState // TypeDefIndex: 4604
{	// Fields
	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20

	// Methods

	// RVA: 0xEB89E0 Offset: 0xEB6FE0 VA: 0x180EB89E0
	public void .ctor() { }

	// RVA: 0xEB8840 Offset: 0xEB6E40 VA: 0x180EB8840
	internal void Reset() { }

	// RVA: 0x9EBD90 Offset: 0x9EA390 VA: 0x1809EBD90
	public IEventHandler GetCapturingElement(int pointerId) { }

	// RVA: 0xEB8070 Offset: 0xEB6670 VA: 0x180EB8070
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0xEB7F10 Offset: 0xEB6510 VA: 0x180EB7F10
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0xEB87F0 Offset: 0xEB6DF0 VA: 0x180EB87F0
	public void ReleasePointer(int pointerId) { }

	// RVA: 0xEB8790 Offset: 0xEB6D90 VA: 0x180EB8790
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0xEB80F0 Offset: 0xEB66F0 VA: 0x180EB80F0
	public void ProcessPointerCapture(int pointerId) { }

	// RVA: 0xEB7ED0 Offset: 0xEB64D0 VA: 0x180EB7ED0
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0xEB80B0 Offset: 0xEB66B0 VA: 0x180EB80B0
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0xEB8930 Offset: 0xEB6F30 VA: 0x180EB8930
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

