public static class LevelManager // TypeDefIndex: 9963
{	public static string CurrentLevelName; // 0x2B4F

	public static bool isLoaded { get; }


	public static bool get_isLoaded() { }

	public static bool IsValid(string strName) { }

	public static void LoadLevel(string strName, bool keepLoadingScreenOpen = True) { }

	[IteratorStateMachineAttribute] // RVA: 0xAAB80 Offset: 0xA9F80 VA: 0x1800AAB80
	public static IEnumerator LoadLevelAsync(string strName, bool keepLoadingScreenOpen = True) { }

	public static void UnloadLevel(bool loadingScreen = True) { }

}

private sealed class LevelManager.<LoadLevelAsync>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9964
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string strName; // 0x20
	public bool keepLoadingScreenOpen; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

