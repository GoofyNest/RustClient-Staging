public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 5081
{	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
	private readonly PointerInputModule.MouseState m_MouseState; // 0x50

	// Methods

	// RVA: 0x10C8B30 Offset: 0x10C7130 VA: 0x1810C8B30
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x10C94F0 Offset: 0x10C7AF0 VA: 0x1810C94F0
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x10C8D60 Offset: 0x10C7360 VA: 0x1810C8D60
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x10C82A0 Offset: 0x10C68A0 VA: 0x1810C82A0
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x10C9600 Offset: 0x10C7C00 VA: 0x1810C9600
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x10C8B10 Offset: 0x10C7110 VA: 0x1810C8B10 Slot: 26
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x10C8490 Offset: 0x10C6A90 VA: 0x1810C8490 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x10C8460 Offset: 0x10C6A60 VA: 0x1810C8460
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x10C9550 Offset: 0x10C7B50 VA: 0x1810C9550
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x10C94A0 Offset: 0x10C7AA0 VA: 0x1810C94A0 Slot: 28
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x10C9130 Offset: 0x10C7730 VA: 0x1810C9130 Slot: 29
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x10C9090 Offset: 0x10C7690 VA: 0x1810C9090 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x10C8110 Offset: 0x10C6710 VA: 0x1810C8110
	protected void ClearSelection() { }

	// RVA: 0x10C96C0 Offset: 0x10C7CC0 VA: 0x1810C96C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10C8380 Offset: 0x10C6980 VA: 0x1810C8380
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x10C98B0 Offset: 0x10C7EB0 VA: 0x1810C98B0
	protected void .ctor() { }

}

public class PointerInputModule.MouseButtonEventData // TypeDefIndex: 5084
{	// Fields
	public PointerEventData.FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x10C6240 Offset: 0x10C4840 VA: 0x1810C6240
	public bool PressedThisFrame() { }

	// RVA: 0x10C6260 Offset: 0x10C4860 VA: 0x1810C6260
	public bool ReleasedThisFrame() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

