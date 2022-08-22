public class HttpImage : MonoBehaviour // TypeDefIndex: 7044
{	// Fields
	public static Dictionary<string, UnityWebRequest> RequestCache; // 0x0
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

	// Methods

	// RVA: 0xFC1D70 Offset: 0xFC0370 VA: 0x180FC1D70
	private void Init() { }

	// RVA: 0xFC2590 Offset: 0xFC0B90 VA: 0x180FC2590
	private void Start() { }

	// RVA: 0xFC2220 Offset: 0xFC0820 VA: 0x180FC2220
	private void OnDestroy() { }

	// RVA: 0xFC1ED0 Offset: 0xFC04D0 VA: 0x180FC1ED0
	public bool Load(string url) { }

	[IteratorStateMachineAttribute] // RVA: 0x75CA0 Offset: 0x750A0 VA: 0x180075CA0
	// RVA: 0xFC2840 Offset: 0xFC0E40 VA: 0x180FC2840
	private IEnumerator WaitForLoad(string url) { }

	// RVA: 0xFC2630 Offset: 0xFC0C30 VA: 0x180FC2630
	private void UpdateImageTexture(ValueTuple<Texture2D, Sprite> tex) { }

	// RVA: 0xFC2480 Offset: 0xFC0A80 VA: 0x180FC2480
	public void SetMissingImage() { }

	// RVA: 0xFC2400 Offset: 0xFC0A00 VA: 0x180FC2400
	public void SetLoadingImage() { }

	[IteratorStateMachineAttribute] // RVA: 0x75E90 Offset: 0x75290 VA: 0x180075E90
	// RVA: 0xFC2500 Offset: 0xFC0B00 VA: 0x180FC2500
	private IEnumerator StartAndWaitForLoad(string url) { }

	// RVA: 0xFC19D0 Offset: 0xFBFFD0 VA: 0x180FC19D0
	private void AutosizeForTexture(Texture2D texture) { }

	// RVA: 0xFC2320 Offset: 0xFC0920 VA: 0x180FC2320
	private void SetImageEnabled(bool enabled) { }

	// RVA: 0xFC1C40 Offset: 0xFC0240 VA: 0x180FC1C40
	private static Sprite CreateSprite(Texture2D texture) { }

	// RVA: 0xFC2970 Offset: 0xFC0F70 VA: 0x180FC2970
	public void .ctor() { }

	// RVA: 0xFC28D0 Offset: 0xFC0ED0 VA: 0x180FC28D0
	private static void .cctor() { }

}

private sealed class HttpImage.<WaitForLoad>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7045
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public HttpImage <>4__this; // 0x28

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

	// RVA: 0xFD9390 Offset: 0xFD7990 VA: 0x180FD9390 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD9570 Offset: 0xFD7B70 VA: 0x180FD9570 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class HttpImage.<StartAndWaitForLoad>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7046
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public HttpImage <>4__this; // 0x28
	private UnityWebRequest <request>5__2; // 0x30

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

	// RVA: 0xFD7AE0 Offset: 0xFD60E0 VA: 0x180FD7AE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD8010 Offset: 0xFD6610 VA: 0x180FD8010 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

