public class WorkshopMainMenu : SingletonComponent<WorkshopMainMenu> // TypeDefIndex: 11182
{	public static Translate.Phrase loading_workshop; // 0x0
	public static Translate.Phrase loading_workshop_setup; // 0x8
	public static Translate.Phrase loading_workshop_skinnables; // 0x10
	public static Translate.Phrase loading_workshop_item; // 0x18


	public void CreateNewItem() { }

	private void OnEnable() { }

	[IteratorStateMachineAttribute] // RVA: 0x9D1A0 Offset: 0x9C5A0 VA: 0x18009D1A0
	private IEnumerator CreateNewItemAsync() { }

	public void StartEditingItem(IWorkshopContent id) { }

	public void StartViewingItem(IWorkshopContent id) { }

	[IteratorStateMachineAttribute] // RVA: 0x9D410 Offset: 0x9C810 VA: 0x18009D410
	private IEnumerator LoadEditor() { }

	[IteratorStateMachineAttribute] // RVA: 0x9D4D0 Offset: 0x9C8D0 VA: 0x18009D4D0
	private IEnumerator StartEditingItemAsync(IWorkshopContent id) { }

	[IteratorStateMachineAttribute] // RVA: 0x9D720 Offset: 0x9CB20 VA: 0x18009D720
	private IEnumerator StartViewingItemAsync(IWorkshopContent id) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class WorkshopMainMenu.<CreateNewItemAsync>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11183
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopMainMenu.<>c // TypeDefIndex: 11184
{	public static readonly WorkshopMainMenu.<>c <>9; // 0x0
	public static Action<bool, string> <>9__9_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <LoadEditor>b__9_0(bool o, string str) { }

}

private sealed class WorkshopMainMenu.<LoadEditor>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11185
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopMainMenu.<StartEditingItemAsync>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11186
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20
	public IWorkshopContent id; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopMainMenu.<StartViewingItemAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11187
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopMainMenu <>4__this; // 0x20
	public IWorkshopContent id; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

