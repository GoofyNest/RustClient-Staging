public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 5081
{	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
	private readonly PointerInputModule.MouseState m_MouseState; // 0x50

	// Methods

	// RVA: 0x10C9860 Offset: 0x10C7E60 VA: 0x1810C9860
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x10CA220 Offset: 0x10C8820 VA: 0x1810CA220
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x10C9A90 Offset: 0x10C8090 VA: 0x1810C9A90
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x10C8FD0 Offset: 0x10C75D0 VA: 0x1810C8FD0
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x10CA330 Offset: 0x10C8930 VA: 0x1810CA330
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x10C9840 Offset: 0x10C7E40 VA: 0x1810C9840 Slot: 26
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x10C91C0 Offset: 0x10C77C0 VA: 0x1810C91C0 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x10C9190 Offset: 0x10C7790 VA: 0x1810C9190
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x10CA280 Offset: 0x10C8880 VA: 0x1810CA280
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x10CA1D0 Offset: 0x10C87D0 VA: 0x1810CA1D0 Slot: 28
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x10C9E60 Offset: 0x10C8460 VA: 0x1810C9E60 Slot: 29
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x10C9DC0 Offset: 0x10C83C0 VA: 0x1810C9DC0 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10C8E40 Offset: 0x10C7440 VA: 0x1810C8E40
	protected void ClearSelection() { }

	// RVA: 0x10CA3F0 Offset: 0x10C89F0 VA: 0x1810CA3F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10C90B0 Offset: 0x10C76B0 VA: 0x1810C90B0
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x10CA5E0 Offset: 0x10C8BE0 VA: 0x1810CA5E0
	protected void .ctor() { }

}

public class PointerInputModule.MouseButtonEventData // TypeDefIndex: 5084
{	// Fields
	public PointerEventData.FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x10C6F70 Offset: 0x10C5570 VA: 0x1810C6F70
	public bool PressedThisFrame() { }

	// RVA: 0x10C6F90 Offset: 0x10C5590 VA: 0x1810C6F90
	public bool ReleasedThisFrame() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

