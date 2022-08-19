internal class ElementUnderPointer // TypeDefIndex: 4639
{	// Fields
	private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
	private VisualElement[] m_TopElementUnderPointer; // 0x18
	private IPointerEvent[] m_TriggerPointerEvent; // 0x20
	private IMouseEvent[] m_TriggerMouseEvent; // 0x28
	private Vector2[] m_PickingPointerPositions; // 0x30
	private bool[] m_IsPickingPointerTemporaries; // 0x38

	// Methods

	// RVA: 0xEAB640 Offset: 0xEA9C40 VA: 0x180EAB640
	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	// RVA: 0x9EB5E0 Offset: 0x9E9BE0 VA: 0x1809EB5E0
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0xEAB480 Offset: 0xEA9A80 VA: 0x180EAB480
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0xEABB00 Offset: 0xEAA100 VA: 0x180EABB00
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEAB6E0 Offset: 0xEA9CE0 VA: 0x180EAB6E0
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEAB700 Offset: 0xEA9D00 VA: 0x180EAB700
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent, bool temporary) { }

	// RVA: 0xEAA320 Offset: 0xEA8920 VA: 0x180EAA320
	internal void CommitElementUnderPointers(EventDispatcher dispatcher) { }

}

