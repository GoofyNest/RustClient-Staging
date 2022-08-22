public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 4905
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xE4A60 Offset: 0xE3E60 VA: 0x1800E4A60
	[SerializeField] // RVA: 0xE4A60 Offset: 0xE3E60 VA: 0x1800E4A60
	private Button.ButtonClickedEvent m_OnClick; // 0xE8

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x10B82D0 Offset: 0x10B68D0 VA: 0x1810B82D0
	protected void .ctor() { }

	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x88D9F0 Offset: 0x88BFF0 VA: 0x18088D9F0
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x10B8240 Offset: 0x10B6840 VA: 0x1810B8240
	private void Press() { }

	// RVA: 0x10B8140 Offset: 0x10B6740 VA: 0x1810B8140 Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10B8170 Offset: 0x10B6770 VA: 0x1810B8170 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xE5E90 Offset: 0xE5290 VA: 0x1800E5E90
	// RVA: 0x10B80D0 Offset: 0x10B66D0 VA: 0x1810B80D0
	private IEnumerator OnFinishSubmit() { }

}

public class Button.ButtonClickedEvent : UnityEvent // TypeDefIndex: 4906
{	// Methods

	// RVA: 0x10B80C0 Offset: 0x10B66C0 VA: 0x1810B80C0
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

	// RVA: 0x10CF960 Offset: 0x10CDF60 VA: 0x1810CF960 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10CFA40 Offset: 0x10CE040 VA: 0x1810CFA40 Slot: 8
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

