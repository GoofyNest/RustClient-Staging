internal class ElementUnderPointer // TypeDefIndex: 4639
{	// Fields
	private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
	private VisualElement[] m_TopElementUnderPointer; // 0x18
	private IPointerEvent[] m_TriggerPointerEvent; // 0x20
	private IMouseEvent[] m_TriggerMouseEvent; // 0x28
	private Vector2[] m_PickingPointerPositions; // 0x30
	private bool[] m_IsPickingPointerTemporaries; // 0x38

	// Methods

	// RVA: 0xEAB900 Offset: 0xEA9F00 VA: 0x180EAB900
	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	// RVA: 0x9EB8A0 Offset: 0x9E9EA0 VA: 0x1809EB8A0
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0xEAB740 Offset: 0xEA9D40 VA: 0x180EAB740
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0xEABDC0 Offset: 0xEAA3C0 VA: 0x180EABDC0
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEAB9A0 Offset: 0xEA9FA0 VA: 0x180EAB9A0
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEAB9C0 Offset: 0xEA9FC0 VA: 0x180EAB9C0
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent, bool temporary) { }

	// RVA: 0xEAA5E0 Offset: 0xEA8BE0 VA: 0x180EAA5E0
	internal void CommitElementUnderPointers(EventDispatcher dispatcher) { }

}

