internal class ElementUnderPointer // TypeDefIndex: 4639
{	// Fields
	private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
	private VisualElement[] m_TopElementUnderPointer; // 0x18
	private IPointerEvent[] m_TriggerPointerEvent; // 0x20
	private IMouseEvent[] m_TriggerMouseEvent; // 0x28
	private Vector2[] m_PickingPointerPositions; // 0x30
	private bool[] m_IsPickingPointerTemporaries; // 0x38

	// Methods

	// RVA: 0xEAC3B0 Offset: 0xEAA9B0 VA: 0x180EAC3B0
	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	// RVA: 0x9EBD90 Offset: 0x9EA390 VA: 0x1809EBD90
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0xEAC1F0 Offset: 0xEAA7F0 VA: 0x180EAC1F0
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0xEAC870 Offset: 0xEAAE70 VA: 0x180EAC870
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEAC450 Offset: 0xEAAA50 VA: 0x180EAC450
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEAC470 Offset: 0xEAAA70 VA: 0x180EAC470
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent, bool temporary) { }

	// RVA: 0xEAB090 Offset: 0xEA9690 VA: 0x180EAB090
	internal void CommitElementUnderPointers(EventDispatcher dispatcher) { }

}

