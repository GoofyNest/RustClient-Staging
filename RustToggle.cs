public class RustToggle : RustControl, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 7034
{	// Fields
	public StyleAsset StyleOff; // 0x30
	public Image Handle; // 0x38
	public RustText TextOn; // 0x40
	public RustText TextOff; // 0x48
	public bool Value; // 0x50
	public float SliderWidth; // 0x54
	public RustToggle.ChangedEvent OnChanged; // 0x58
	private Coroutine anim; // 0x60

	// Properties
	public override StyleAsset Styles { get; }

	// Methods

	// RVA: 0xFD0A80 Offset: 0xFCF080 VA: 0x180FD0A80 Slot: 19
	public override StyleAsset get_Styles() { }

	// RVA: 0xFD0A00 Offset: 0xFCF000 VA: 0x180FD0A00
	public void SetValue(bool value) { }

	// RVA: 0xFD0920 Offset: 0xFCEF20 VA: 0x180FD0920 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x724A0 Offset: 0x718A0 VA: 0x1800724A0
	// RVA: 0xFD0500 Offset: 0xFCEB00 VA: 0x180FD0500
	private IEnumerator AnimateTo() { }

	// RVA: 0xFD0570 Offset: 0xFCEB70 VA: 0x180FD0570 Slot: 29
	public override void ApplyStyles() { }

	// RVA: 0xFD0A20 Offset: 0xFCF020 VA: 0x180FD0A20
	public void .ctor() { }

}

public class RustToggle.ChangedEvent : UnityEvent<bool> // TypeDefIndex: 7035
{	// Methods

	// RVA: 0xFBE000 Offset: 0xFBC600 VA: 0x180FBE000
	public void .ctor() { }

}

private sealed class RustToggle.<AnimateTo>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7036
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RustToggle <>4__this; // 0x20
	private Vector2 <handleMin>5__2; // 0x28
	private Vector2 <handleMax>5__3; // 0x30
	private float <animTime>5__4; // 0x38
	private float <time>5__5; // 0x3C
	private Image <bg>5__6; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xFD66A0 Offset: 0xFD4CA0 VA: 0x180FD66A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFD6C30 Offset: 0xFD5230 VA: 0x180FD6C30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

