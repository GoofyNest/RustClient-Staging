public static class LevelManager // TypeDefIndex: 9963
{	// Fields
	public static string CurrentLevelName; // 0x2B111C0

	// Properties
	public static bool isLoaded { get; }

	// Methods

	// RVA: 0x68BFF0 Offset: 0x68A5F0 VA: 0x18068BFF0
	public static bool get_isLoaded() { }

	// RVA: 0x68BDD0 Offset: 0x68A3D0 VA: 0x18068BDD0
	public static bool IsValid(string strName) { }

	// RVA: 0x68BE60 Offset: 0x68A460 VA: 0x18068BE60
	public static void LoadLevel(string strName, bool keepLoadingScreenOpen = True) { }

	[IteratorStateMachineAttribute] // RVA: 0xAAB80 Offset: 0xA9F80 VA: 0x1800AAB80
	// RVA: 0x68BDE0 Offset: 0x68A3E0 VA: 0x18068BDE0
	public static IEnumerator LoadLevelAsync(string strName, bool keepLoadingScreenOpen = True) { }

	// RVA: 0x68BEF0 Offset: 0x68A4F0 VA: 0x18068BEF0
	public static void UnloadLevel(bool loadingScreen = True) { }

}

private sealed class LevelManager.<LoadLevelAsync>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9964
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string strName; // 0x20
	public bool keepLoadingScreenOpen; // 0x28

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

	// RVA: 0x690450 Offset: 0x68EA50 VA: 0x180690450 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6905C0 Offset: 0x68EBC0 VA: 0x1806905C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

