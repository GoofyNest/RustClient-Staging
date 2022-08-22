public class GameTip : SingletonComponent<GameTip> // TypeDefIndex: 10941
{	// Fields
	public CanvasGroup canvasGroup; // 0x18
	public RustIcon icon; // 0x20
	public Image background; // 0x28
	public RustText text; // 0x30
	public GameTip.Theme[] themes; // 0x38
	public static BaseTip[] Tips; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool showgametips; // 0x8

	// Methods

	// RVA: 0x75D460 Offset: 0x75BA60 VA: 0x18075D460
	public void OnEnable() { }

	// RVA: 0x75D1F0 Offset: 0x75B7F0 VA: 0x18075D1F0
	private void ClientConnected() { }

	// RVA: 0x75D9A0 Offset: 0x75BFA0 VA: 0x18075D9A0
	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x8C790 Offset: 0x8BB90 VA: 0x18008C790
	// RVA: 0x75D930 Offset: 0x75BF30 VA: 0x18075D930
	private IEnumerator Think() { }

	// RVA: 0x75D290 Offset: 0x75B890 VA: 0x18075D290
	private float GetStyleHoldDuration(int style) { }

	// RVA: 0x75CFE0 Offset: 0x75B5E0 VA: 0x18075CFE0
	private void ApplyStyle(int style) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x75D4F0 Offset: 0x75BAF0 VA: 0x18075D4F0
	public static void ShowGameTip(string text) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x75D340 Offset: 0x75B940 VA: 0x18075D340
	public static void HideGameTip() { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x75D6A0 Offset: 0x75BCA0 VA: 0x18075D6A0
	public static void ShowToast(int style, string text) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x75D600 Offset: 0x75BC00 VA: 0x18075D600
	public static void ShowToast_Translated(int style, string key, string english) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x75D400 Offset: 0x75BA00 VA: 0x18075D400
	public static BaseTip[] ListGameTips() { }

	// RVA: 0x75F100 Offset: 0x75D700 VA: 0x18075F100
	public void .ctor() { }

	// RVA: 0x75D9F0 Offset: 0x75BFF0 VA: 0x18075D9F0
	private static void .cctor() { }

}

public struct GameTip.Theme // TypeDefIndex: 10942
{	// Fields
	public Icons Icon; // 0x0
	public Color BackgroundColor; // 0x4
	public Color ForegroundColor; // 0x14
	public float duration; // 0x24

}

private sealed class GameTip.<Think>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10943
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameTip <>4__this; // 0x20
	private BaseTip[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private BaseTip <tip>5__4; // 0x38

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

	// RVA: 0x763830 Offset: 0x761E30 VA: 0x180763830 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x763D30 Offset: 0x762330 VA: 0x180763D30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

