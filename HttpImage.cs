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

	// RVA: 0xFC1AB0 Offset: 0xFC00B0 VA: 0x180FC1AB0
	private void Init() { }

	// RVA: 0xFC22D0 Offset: 0xFC08D0 VA: 0x180FC22D0
	private void Start() { }

	// RVA: 0xFC1F60 Offset: 0xFC0560 VA: 0x180FC1F60
	private void OnDestroy() { }

	// RVA: 0xFC1C10 Offset: 0xFC0210 VA: 0x180FC1C10
	public bool Load(string url) { }

	[IteratorStateMachineAttribute] // RVA: 0x75CA0 Offset: 0x750A0 VA: 0x180075CA0
	// RVA: 0xFC2580 Offset: 0xFC0B80 VA: 0x180FC2580
	private IEnumerator WaitForLoad(string url) { }

	// RVA: 0xFC2370 Offset: 0xFC0970 VA: 0x180FC2370
	private void UpdateImageTexture(ValueTuple<Texture2D, Sprite> tex) { }

	// RVA: 0xFC21C0 Offset: 0xFC07C0 VA: 0x180FC21C0
	public void SetMissingImage() { }

	// RVA: 0xFC2140 Offset: 0xFC0740 VA: 0x180FC2140
	public void SetLoadingImage() { }

	[IteratorStateMachineAttribute] // RVA: 0x75E90 Offset: 0x75290 VA: 0x180075E90
	// RVA: 0xFC2240 Offset: 0xFC0840 VA: 0x180FC2240
	private IEnumerator StartAndWaitForLoad(string url) { }

	// RVA: 0xFC1710 Offset: 0xFBFD10 VA: 0x180FC1710
	private void AutosizeForTexture(Texture2D texture) { }

	// RVA: 0xFC2060 Offset: 0xFC0660 VA: 0x180FC2060
	private void SetImageEnabled(bool enabled) { }

	// RVA: 0xFC1980 Offset: 0xFBFF80 VA: 0x180FC1980
	private static Sprite CreateSprite(Texture2D texture) { }

	// RVA: 0xFC26B0 Offset: 0xFC0CB0 VA: 0x180FC26B0
	public void .ctor() { }

	// RVA: 0xFC2610 Offset: 0xFC0C10 VA: 0x180FC2610
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

	// RVA: 0xFD90D0 Offset: 0xFD76D0 VA: 0x180FD90D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD92B0 Offset: 0xFD78B0 VA: 0x180FD92B0 Slot: 8
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

	// RVA: 0xFD7820 Offset: 0xFD5E20 VA: 0x180FD7820 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD7D50 Offset: 0xFD6350 VA: 0x180FD7D50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

