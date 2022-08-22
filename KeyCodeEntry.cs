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

	// RVA: 0x680040 Offset: 0x67E640 VA: 0x180680040
	public void SetUsingGuestCode(bool should) { }

	// RVA: 0x67FF20 Offset: 0x67E520 VA: 0x18067FF20 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4C27D0 Offset: 0x4C0DD0 VA: 0x1804C27D0
	public void Cancel() { }

	// RVA: 0x67FB20 Offset: 0x67E120 VA: 0x18067FB20
	public void ClearCode() { }

	// RVA: 0x67FB90 Offset: 0x67E190 VA: 0x18067FB90
	private void DeleteCodeCharacter() { }

	// RVA: 0x6800A0 Offset: 0x67E6A0 VA: 0x1806800A0
	public void Update() { }

	// RVA: 0x67FC70 Offset: 0x67E270 VA: 0x18067FC70
	public void EnterLastUsedNumber() { }

	[IteratorStateMachineAttribute] // RVA: 0x88480 Offset: 0x87880 VA: 0x180088480
	// RVA: 0x67FFD0 Offset: 0x67E5D0 VA: 0x18067FFD0
	private IEnumerator ProcessLastNumberInput() { }

	// RVA: 0x67FEA0 Offset: 0x67E4A0 VA: 0x18067FEA0
	public void EnterNumber(int i) { }

	// RVA: 0x67FD50 Offset: 0x67E350 VA: 0x18067FD50
	private void EnterNumberInternal(int i, bool bypassTimeCheck = False) { }

	// RVA: 0x67FEB0 Offset: 0x67E4B0 VA: 0x18067FEB0
	public void Finished() { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
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

	// RVA: 0x690610 Offset: 0x68EC10 VA: 0x180690610 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6907D0 Offset: 0x68EDD0 VA: 0x1806907D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

