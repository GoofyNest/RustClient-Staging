public class TypeThroughButton : Button, IUpdateSelectedHandler, IEventSystemHandler // TypeDefIndex: 11243
{	// Fields
	public InputField typingTarget; // 0xF0
	private Event _processingEvent; // 0xF8

	// Methods

	// RVA: 0x4D52F0 Offset: 0x4D38F0 VA: 0x1804D52F0 Slot: 43
	public void OnUpdateSelected(BaseEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xA2880 Offset: 0xA1C80 VA: 0x1800A2880
	// RVA: 0x4D5260 Offset: 0x4D3860 VA: 0x1804D5260
	private IEnumerator DelayedActivateTextField(Event e) { }

	// RVA: 0x4D5440 Offset: 0x4D3A40 VA: 0x1804D5440
	public void .ctor() { }

}

private sealed class TypeThroughButton.<DelayedActivateTextField>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11244
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TypeThroughButton <>4__this; // 0x20
	public Event e; // 0x28

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

	// RVA: 0x4D54B0 Offset: 0x4D3AB0 VA: 0x1804D54B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D5650 Offset: 0x4D3C50 VA: 0x1804D5650 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}
