public class HttpImage : MonoBehaviour // TypeDefIndex: 7044
{	public static Dictionary<string, UnityWebRequest> RequestCache; // 0x0
	public static Dictionary<string, ValueTuple<Texture2D, Sprite>> TextureCache; // 0x8
	public Texture2D LoadingImage; // 0x18
	public Texture2D MissingImage; // 0x20
	private RawImage rawImage; // 0x28
	private Image image; // 0x30
	private Sprite loadingSprite; // 0x38
	private Sprite missingSprite; // 0x40
	public string Url; // 0x48
	public bool AutosizeHeight; // 0x50
	public bool GenerateMipmaps; // 0x51
	public float MaxWidth; // 0x54
	public float MaxHeight; // 0x58


	private void Init() { }

	private void Start() { }

	private void OnDestroy() { }

	public bool Load(string url) { }

	[IteratorStateMachineAttribute] // RVA: 0x75DA0 Offset: 0x751A0 VA: 0x180075DA0
	private IEnumerator WaitForLoad(string url) { }

	private void UpdateImageTexture(ValueTuple<Texture2D, Sprite> tex) { }

	public void SetMissingImage() { }

	public void SetLoadingImage() { }

	[IteratorStateMachineAttribute] // RVA: 0x75F40 Offset: 0x75340 VA: 0x180075F40
	private IEnumerator StartAndWaitForLoad(string url) { }

	private void AutosizeForTexture(Texture2D texture) { }

	private void SetImageEnabled(bool enabled) { }

	private static Sprite CreateSprite(Texture2D texture) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class HttpImage.<WaitForLoad>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7045
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public HttpImage <>4__this; // 0x28

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

private sealed class HttpImage.<StartAndWaitForLoad>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7046
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public HttpImage <>4__this; // 0x28
	private UnityWebRequest <request>5__2; // 0x30

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

