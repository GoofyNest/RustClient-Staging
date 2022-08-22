public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 4905
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xE4A60 Offset: 0xE3E60 VA: 0x1800E4A60
	[SerializeField] // RVA: 0xE4A60 Offset: 0xE3E60 VA: 0x1800E4A60
	private Button.ButtonClickedEvent m_OnClick; // 0xE8

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x10B75A0 Offset: 0x10B5BA0 VA: 0x1810B75A0
	protected void .ctor() { }

	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x8721C0 Offset: 0x8707C0 VA: 0x1808721C0
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x10B7510 Offset: 0x10B5B10 VA: 0x1810B7510
	private void Press() { }

	// RVA: 0x10B7410 Offset: 0x10B5A10 VA: 0x1810B7410 Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10B7440 Offset: 0x10B5A40 VA: 0x1810B7440 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xE5E90 Offset: 0xE5290 VA: 0x1800E5E90
	// RVA: 0x10B73A0 Offset: 0x10B59A0 VA: 0x1810B73A0
	private IEnumerator OnFinishSubmit() { }

}

public class Button.ButtonClickedEvent : UnityEvent // TypeDefIndex: 4906
{	// Methods

	// RVA: 0x10B7390 Offset: 0x10B5990 VA: 0x1810B7390
	public void .ctor() { }

}

private sealed class Button.<OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4907
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Button <>4__this; // 0x20
	private float <fadeTime>5__2; // 0x28
	private float <elapsedTime>5__3; // 0x2C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x10CEC30 Offset: 0x10CD230 VA: 0x1810CEC30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10CED10 Offset: 0x10CD310 VA: 0x1810CED10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public enum BUTTON // TypeDefIndex: 10101
{	// Fields
	public int value__; // 0x0
	public const BUTTON FORWARD = 2;
	public const BUTTON BACKWARD = 4;
	public const BUTTON LEFT = 8;
	public const BUTTON RIGHT = 16;
	public const BUTTON JUMP = 32;
	public const BUTTON DUCK = 64;
	public const BUTTON SPRINT = 128;
	public const BUTTON USE = 256;
	public const BUTTON FIRE_PRIMARY = 1024;
	public const BUTTON FIRE_SECONDARY = 2048;
	public const BUTTON RELOAD = 8192;
	public const BUTTON FIRE_THIRD = 134217728;

}

