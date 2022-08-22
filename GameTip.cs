public class GameTip : SingletonComponent<GameTip> // TypeDefIndex: 10941
{	public CanvasGroup canvasGroup; // 0x18
	public RustIcon icon; // 0x20
	public Image background; // 0x28
	public RustText text; // 0x30
	public GameTip.Theme[] themes; // 0x38
	public static BaseTip[] Tips; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool showgametips; // 0x8


	public void OnEnable() { }

	private void ClientConnected() { }

	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x8C790 Offset: 0x8BB90 VA: 0x18008C790
	private IEnumerator Think() { }

	private float GetStyleHoldDuration(int style) { }

	private void ApplyStyle(int style) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static void ShowGameTip(string text) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static void HideGameTip() { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static void ShowToast(int style, string text) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	public static void ShowToast_Translated(int style, string key, string english) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static BaseTip[] ListGameTips() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct GameTip.Theme // TypeDefIndex: 10942
{	public Icons Icon; // 0x0
	public Color BackgroundColor; // 0x4
	public Color ForegroundColor; // 0x14
	public float duration; // 0x24

}

private sealed class GameTip.<Think>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10943
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameTip <>4__this; // 0x20
	private BaseTip[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private BaseTip <tip>5__4; // 0x38

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

