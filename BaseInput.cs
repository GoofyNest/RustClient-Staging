public class BaseInput : UIBehaviour // TypeDefIndex: 5079
{	// Properties
	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }

	// Methods

	// RVA: 0x10B7550 Offset: 0x10B5B50 VA: 0x1810B7550 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x10B7560 Offset: 0x10B5B60 VA: 0x1810B7560 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x10B7650 Offset: 0x10B5C50 VA: 0x1810B7650 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x10B7540 Offset: 0x10B5B40 VA: 0x1810B7540 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x10B7630 Offset: 0x10B5C30 VA: 0x1810B7630 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x10B75F0 Offset: 0x10B5BF0 VA: 0x1810B75F0 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x10B74C0 Offset: 0x10B5AC0 VA: 0x1810B74C0 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x10B74D0 Offset: 0x10B5AD0 VA: 0x1810B74D0 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x10B74E0 Offset: 0x10B5AE0 VA: 0x1810B74E0 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x10B7570 Offset: 0x10B5B70 VA: 0x1810B7570 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x10B7600 Offset: 0x10B5C00 VA: 0x1810B7600 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x10B7620 Offset: 0x10B5C20 VA: 0x1810B7620 Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x10B7610 Offset: 0x10B5C10 VA: 0x1810B7610 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x10B74F0 Offset: 0x10B5AF0 VA: 0x1810B74F0 Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x10B74A0 Offset: 0x10B5AA0 VA: 0x1810B74A0 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x10B74B0 Offset: 0x10B5AB0 VA: 0x1810B74B0 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

