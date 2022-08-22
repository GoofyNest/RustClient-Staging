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

	// RVA: 0xFC2810 Offset: 0xFC0E10 VA: 0x180FC2810
	private void Init() { }

	// RVA: 0xFC3030 Offset: 0xFC1630 VA: 0x180FC3030
	private void Start() { }

	// RVA: 0xFC2CC0 Offset: 0xFC12C0 VA: 0x180FC2CC0
	private void OnDestroy() { }

	// RVA: 0xFC2970 Offset: 0xFC0F70 VA: 0x180FC2970
	public bool Load(string url) { }

	[IteratorStateMachineAttribute] // RVA: 0x75CA0 Offset: 0x750A0 VA: 0x180075CA0
	// RVA: 0xFC32E0 Offset: 0xFC18E0 VA: 0x180FC32E0
	private IEnumerator WaitForLoad(string url) { }

	// RVA: 0xFC30D0 Offset: 0xFC16D0 VA: 0x180FC30D0
	private void UpdateImageTexture(ValueTuple<Texture2D, Sprite> tex) { }

	// RVA: 0xFC2F20 Offset: 0xFC1520 VA: 0x180FC2F20
	public void SetMissingImage() { }

	// RVA: 0xFC2EA0 Offset: 0xFC14A0 VA: 0x180FC2EA0
	public void SetLoadingImage() { }

	[IteratorStateMachineAttribute] // RVA: 0x75E90 Offset: 0x75290 VA: 0x180075E90
	// RVA: 0xFC2FA0 Offset: 0xFC15A0 VA: 0x180FC2FA0
	private IEnumerator StartAndWaitForLoad(string url) { }

	// RVA: 0xFC2470 Offset: 0xFC0A70 VA: 0x180FC2470
	private void AutosizeForTexture(Texture2D texture) { }

	// RVA: 0xFC2DC0 Offset: 0xFC13C0 VA: 0x180FC2DC0
	private void SetImageEnabled(bool enabled) { }

	// RVA: 0xFC26E0 Offset: 0xFC0CE0 VA: 0x180FC26E0
	private static Sprite CreateSprite(Texture2D texture) { }

	// RVA: 0xFC3410 Offset: 0xFC1A10 VA: 0x180FC3410
	public void .ctor() { }

	// RVA: 0xFC3370 Offset: 0xFC1970 VA: 0x180FC3370
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

	// RVA: 0xFD9E30 Offset: 0xFD8430 VA: 0x180FD9E30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFDA010 Offset: 0xFD8610 VA: 0x180FDA010 Slot: 8
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

	// RVA: 0xFD8580 Offset: 0xFD6B80 VA: 0x180FD8580 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFD8AB0 Offset: 0xFD70B0 VA: 0x180FD8AB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

