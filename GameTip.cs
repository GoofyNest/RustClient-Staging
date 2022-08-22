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

	// RVA: 0x75D4C0 Offset: 0x75BAC0 VA: 0x18075D4C0
	public void OnEnable() { }

	// RVA: 0x75D250 Offset: 0x75B850 VA: 0x18075D250
	private void ClientConnected() { }

	// RVA: 0x75DA00 Offset: 0x75C000 VA: 0x18075DA00
	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x8C790 Offset: 0x8BB90 VA: 0x18008C790
	// RVA: 0x75D990 Offset: 0x75BF90 VA: 0x18075D990
	private IEnumerator Think() { }

	// RVA: 0x75D2F0 Offset: 0x75B8F0 VA: 0x18075D2F0
	private float GetStyleHoldDuration(int style) { }

	// RVA: 0x75D040 Offset: 0x75B640 VA: 0x18075D040
	private void ApplyStyle(int style) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x75D550 Offset: 0x75BB50 VA: 0x18075D550
	public static void ShowGameTip(string text) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x75D3A0 Offset: 0x75B9A0 VA: 0x18075D3A0
	public static void HideGameTip() { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x75D700 Offset: 0x75BD00 VA: 0x18075D700
	public static void ShowToast(int style, string text) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x75D660 Offset: 0x75BC60 VA: 0x18075D660
	public static void ShowToast_Translated(int style, string key, string english) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x75D460 Offset: 0x75BA60 VA: 0x18075D460
	public static BaseTip[] ListGameTips() { }

	// RVA: 0x75F160 Offset: 0x75D760 VA: 0x18075F160
	public void .ctor() { }

	// RVA: 0x75DA50 Offset: 0x75C050 VA: 0x18075DA50
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

	// RVA: 0x763890 Offset: 0x761E90 VA: 0x180763890 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x763D90 Offset: 0x762390 VA: 0x180763D90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

