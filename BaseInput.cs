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

	// RVA: 0x10B6820 Offset: 0x10B4E20 VA: 0x1810B6820 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x10B6830 Offset: 0x10B4E30 VA: 0x1810B6830 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x10B6920 Offset: 0x10B4F20 VA: 0x1810B6920 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x10B6810 Offset: 0x10B4E10 VA: 0x1810B6810 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x10B6900 Offset: 0x10B4F00 VA: 0x1810B6900 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x10B68C0 Offset: 0x10B4EC0 VA: 0x1810B68C0 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x10B6790 Offset: 0x10B4D90 VA: 0x1810B6790 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x10B67A0 Offset: 0x10B4DA0 VA: 0x1810B67A0 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x10B67B0 Offset: 0x10B4DB0 VA: 0x1810B67B0 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x10B6840 Offset: 0x10B4E40 VA: 0x1810B6840 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x10B68D0 Offset: 0x10B4ED0 VA: 0x1810B68D0 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x10B68F0 Offset: 0x10B4EF0 VA: 0x1810B68F0 Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x10B68E0 Offset: 0x10B4EE0 VA: 0x1810B68E0 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x10B67C0 Offset: 0x10B4DC0 VA: 0x1810B67C0 Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x10B6770 Offset: 0x10B4D70 VA: 0x1810B6770 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x10B6780 Offset: 0x10B4D80 VA: 0x1810B6780 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

