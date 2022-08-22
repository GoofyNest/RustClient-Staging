public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 5081
{	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
	private readonly PointerInputModule.MouseState m_MouseState; // 0x50

	// Methods

	// RVA: 0x10C8DF0 Offset: 0x10C73F0 VA: 0x1810C8DF0
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x10C97B0 Offset: 0x10C7DB0 VA: 0x1810C97B0
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x10C9020 Offset: 0x10C7620 VA: 0x1810C9020
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x10C8560 Offset: 0x10C6B60 VA: 0x1810C8560
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x10C98C0 Offset: 0x10C7EC0 VA: 0x1810C98C0
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x10C8DD0 Offset: 0x10C73D0 VA: 0x1810C8DD0 Slot: 26
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x10C8750 Offset: 0x10C6D50 VA: 0x1810C8750 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x10C8720 Offset: 0x10C6D20 VA: 0x1810C8720
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x10C9810 Offset: 0x10C7E10 VA: 0x1810C9810
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x10C9760 Offset: 0x10C7D60 VA: 0x1810C9760 Slot: 28
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x10C93F0 Offset: 0x10C79F0 VA: 0x1810C93F0 Slot: 29
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x10C9350 Offset: 0x10C7950 VA: 0x1810C9350 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10C83D0 Offset: 0x10C69D0 VA: 0x1810C83D0
	protected void ClearSelection() { }

	// RVA: 0x10C9980 Offset: 0x10C7F80 VA: 0x1810C9980 Slot: 3
	public override string ToString() { }

	// RVA: 0x10C8640 Offset: 0x10C6C40 VA: 0x1810C8640
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x10C9B70 Offset: 0x10C8170 VA: 0x1810C9B70
	protected void .ctor() { }

}

public class PointerInputModule.MouseButtonEventData // TypeDefIndex: 5084
{	// Fields
	public PointerEventData.FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x10C6500 Offset: 0x10C4B00 VA: 0x1810C6500
	public bool PressedThisFrame() { }

	// RVA: 0x10C6520 Offset: 0x10C4B20 VA: 0x1810C6520
	public bool ReleasedThisFrame() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

