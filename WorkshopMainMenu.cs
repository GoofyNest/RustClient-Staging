public class WorkshopMainMenu : SingletonComponent<WorkshopMainMenu> // TypeDefIndex: 11178
{	// Fields
	public static Translate.Phrase loading_workshop; // 0x0
	public static Translate.Phrase loading_workshop_setup; // 0x8
	public static Translate.Phrase loading_workshop_skinnables; // 0x10
	public static Translate.Phrase loading_workshop_item; // 0x18

	// Methods

	// RVA: 0x8FEC70 Offset: 0x8FD270 VA: 0x1808FEC70
	public void CreateNewItem() { }

	// RVA: 0x8FED50 Offset: 0x8FD350 VA: 0x1808FED50
	private void OnEnable() { }

	[IteratorStateMachineAttribute] // RVA: 0x9CE30 Offset: 0x9C230 VA: 0x18009CE30
	// RVA: 0x8FEC00 Offset: 0x8FD200 VA: 0x1808FEC00
	private IEnumerator CreateNewItemAsync() { }

	// RVA: 0x8FEE30 Offset: 0x8FD430 VA: 0x1808FEE30
	public void StartEditingItem(IWorkshopContent id) { }

	// RVA: 0x8FEF50 Offset: 0x8FD550 VA: 0x1808FEF50
	public void StartViewingItem(IWorkshopContent id) { }

	[IteratorStateMachineAttribute] // RVA: 0x9D040 Offset: 0x9C440 VA: 0x18009D040
	// RVA: 0x8FECE0 Offset: 0x8FD2E0 VA: 0x1808FECE0
	private IEnumerator LoadEditor() { }

	[IteratorStateMachineAttribute] // RVA: 0x9D220 Offset: 0x9C620 VA: 0x18009D220
	// RVA: 0x8FEDA0 Offset: 0x8FD3A0 VA: 0x1808FEDA0
	private IEnumerator StartEditingItemAsync(IWorkshopContent id) { }

	[IteratorStateMachineAttribute] // RVA: 0x9D3B0 Offset: 0x9C7B0 VA: 0x18009D3B0
	// RVA: 0x8FEEC0 Offset: 0x8FD4C0 VA: 0x1808FEEC0
	private IEnumerator StartViewingItemAsync(IWorkshopContent id) { }

	// RVA: 0x8FF120 Offset: 0x8FD720 VA: 0x1808FF120
	public void .ctor() { }

	// RVA: 0x8FEFE0 Offset: 0x8FD5E0 VA: 0x1808FEFE0
	private static void .cctor() { }

}

private sealed class WorkshopMainMenu.<CreateNewItemAsync>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11179
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20

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

	// RVA: 0x8E9B40 Offset: 0x8E8140 VA: 0x1808E9B40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8E9C90 Offset: 0x8E8290 VA: 0x1808E9C90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopMainMenu.<>c // TypeDefIndex: 11180
{	// Fields
	public static readonly WorkshopMainMenu.<>c <>9; // 0x0
	public static Action<bool, string> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x8EE8C0 Offset: 0x8ECEC0 VA: 0x1808EE8C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8EE5E0 Offset: 0x8ECBE0 VA: 0x1808EE5E0
	internal void <LoadEditor>b__9_0(bool o, string str) { }

}

private sealed class WorkshopMainMenu.<LoadEditor>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11181
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20

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

	// RVA: 0x8ECD90 Offset: 0x8EB390 VA: 0x1808ECD90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8ED220 Offset: 0x8EB820 VA: 0x1808ED220 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopMainMenu.<StartEditingItemAsync>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11182
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20
	public IWorkshopContent id; // 0x28

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

	// RVA: 0x8EDD70 Offset: 0x8EC370 VA: 0x1808EDD70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8EDF50 Offset: 0x8EC550 VA: 0x1808EDF50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopMainMenu.<StartViewingItemAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11183
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20
	public IWorkshopContent id; // 0x28

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

	// RVA: 0x8EDFA0 Offset: 0x8EC5A0 VA: 0x1808EDFA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8EE180 Offset: 0x8EC780 VA: 0x1808EE180 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

