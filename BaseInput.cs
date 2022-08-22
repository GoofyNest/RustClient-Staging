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

	// RVA: 0x10B6AE0 Offset: 0x10B50E0 VA: 0x1810B6AE0 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x10B6AF0 Offset: 0x10B50F0 VA: 0x1810B6AF0 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x10B6BE0 Offset: 0x10B51E0 VA: 0x1810B6BE0 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x10B6AD0 Offset: 0x10B50D0 VA: 0x1810B6AD0 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x10B6BC0 Offset: 0x10B51C0 VA: 0x1810B6BC0 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x10B6B80 Offset: 0x10B5180 VA: 0x1810B6B80 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x10B6A50 Offset: 0x10B5050 VA: 0x1810B6A50 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x10B6A60 Offset: 0x10B5060 VA: 0x1810B6A60 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x10B6A70 Offset: 0x10B5070 VA: 0x1810B6A70 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x10B6B00 Offset: 0x10B5100 VA: 0x1810B6B00 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x10B6B90 Offset: 0x10B5190 VA: 0x1810B6B90 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x10B6BB0 Offset: 0x10B51B0 VA: 0x1810B6BB0 Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x10B6BA0 Offset: 0x10B51A0 VA: 0x1810B6BA0 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x10B6A80 Offset: 0x10B5080 VA: 0x1810B6A80 Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x10B6A30 Offset: 0x10B5030 VA: 0x1810B6A30 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x10B6A40 Offset: 0x10B5040 VA: 0x1810B6A40 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

