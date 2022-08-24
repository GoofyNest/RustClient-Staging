public class GameTip : SingletonComponent<GameTip> // TypeDefIndex: 10945
{	public CanvasGroup canvasGroup; // 0x18
	public RustIcon icon; // 0x20
	public Image background; // 0x28
	public RustText text; // 0x30
	public GameTip.Theme[] themes; // 0x38
	public static BaseTip[] Tips; // 0x0
	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static bool showgametips; // 0x8


	public void OnEnable() { }

	private void ClientConnected() { }

	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x8B140 Offset: 0x8A540 VA: 0x18008B140
	private IEnumerator Think() { }

	private float GetStyleHoldDuration(int style) { }

	private void ApplyStyle(int style) { }

	[ClientVar] // RVA: 0x85910 Offset: 0x84D10 VA: 0x180085910
	public static void ShowGameTip(string text) { }

	[ClientVar] // RVA: 0x85910 Offset: 0x84D10 VA: 0x180085910
	public static void HideGameTip() { }

	[ClientVar] // RVA: 0x85910 Offset: 0x84D10 VA: 0x180085910
	public static void ShowToast(int style, string text) { }

	[ClientVar] // RVA: 0x85910 Offset: 0x84D10 VA: 0x180085910
	public static void ShowToast_Translated(int style, string key, string english) { }

	[ClientVar] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public static BaseTip[] ListGameTips() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct GameTip.Theme // TypeDefIndex: 10946
{	public Icons Icon; // 0x0
	public Color BackgroundColor; // 0x4
	public Color ForegroundColor; // 0x14
	public float duration; // 0x24

}

private sealed class GameTip.<Think>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10947
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameTip <>4__this; // 0x20
	private BaseTip[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private BaseTip <tip>5__4; // 0x38

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

