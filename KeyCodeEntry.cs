public class KeyCodeEntry : UIDialog // TypeDefIndex: 10895
{	// Fields
	public Text textDisplay; // 0x30
	public Action<string> onCodeEntered; // 0x38
	public Text typeDisplay; // 0x40
	public Translate.Phrase masterCodePhrase; // 0x48
	public Translate.Phrase guestCodePhrase; // 0x50
	public GameObject memoryKeycodeButton; // 0x58
	private static string lastCodeEntered; // 0x0
	private string textEntered; // 0x60
	private TimeSince lastKeyDelete; // 0x68
	private bool isEnteringNumber; // 0x6C
	private int lastEnteredFrame; // 0x70

	// Methods

	// RVA: 0x67FFD0 Offset: 0x67E5D0 VA: 0x18067FFD0
	public void SetUsingGuestCode(bool should) { }

	// RVA: 0x67FEB0 Offset: 0x67E4B0 VA: 0x18067FEB0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4C2760 Offset: 0x4C0D60 VA: 0x1804C2760
	public void Cancel() { }

	// RVA: 0x67FAB0 Offset: 0x67E0B0 VA: 0x18067FAB0
	public void ClearCode() { }

	// RVA: 0x67FB20 Offset: 0x67E120 VA: 0x18067FB20
	private void DeleteCodeCharacter() { }

	// RVA: 0x680030 Offset: 0x67E630 VA: 0x180680030
	public void Update() { }

	// RVA: 0x67FC00 Offset: 0x67E200 VA: 0x18067FC00
	public void EnterLastUsedNumber() { }

	[IteratorStateMachineAttribute] // RVA: 0x88480 Offset: 0x87880 VA: 0x180088480
	// RVA: 0x67FF60 Offset: 0x67E560 VA: 0x18067FF60
	private IEnumerator ProcessLastNumberInput() { }

	// RVA: 0x67FE30 Offset: 0x67E430 VA: 0x18067FE30
	public void EnterNumber(int i) { }

	// RVA: 0x67FCE0 Offset: 0x67E2E0 VA: 0x18067FCE0
	private void EnterNumberInternal(int i, bool bypassTimeCheck = False) { }

	// RVA: 0x67FE40 Offset: 0x67E440 VA: 0x18067FE40
	public void Finished() { }

	// RVA: 0x4C1A40 Offset: 0x4C0040 VA: 0x1804C1A40
	public void .ctor() { }

}

private sealed class KeyCodeEntry.<ProcessLastNumberInput>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10896
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public KeyCodeEntry <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x6905A0 Offset: 0x68EBA0 VA: 0x1806905A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x690760 Offset: 0x68ED60 VA: 0x180690760 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

