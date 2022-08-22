public class TextureRow : MaterialRow // TypeDefIndex: 7759
{	// Fields
	private string Filename; // 0x20
	public bool IsNormalMap; // 0x28
	public RawImage TargetImage; // 0x30
	public Text FilenameLabel; // 0x38
	public Button Reset; // 0x40
	public Button Clear; // 0x48
	public bool HasChanges; // 0x50
	private Texture Default; // 0x58
	private FileSystemWatcher watcher; // 0x60

	// Properties
	public bool IsDefault { get; }
	public bool IsClear { get; }

	// Methods

	// RVA: 0xE773E0 Offset: 0xE759E0 VA: 0x180E773E0
	public void Update() { }

	// RVA: 0xE76FC0 Offset: 0xE755C0 VA: 0x180E76FC0
	public void SetFilenameText(string filename) { }

	// RVA: 0xE76BD0 Offset: 0xE751D0 VA: 0x180E76BD0
	public void OnDisable() { }

	// RVA: 0xE76C60 Offset: 0xE75260 VA: 0x180E76C60
	public void OpenFileBrowser() { }

	[IteratorStateMachineAttribute] // RVA: 0xD63B0 Offset: 0xD57B0 VA: 0x1800D63B0
	// RVA: 0xE768D0 Offset: 0xE74ED0 VA: 0x180E768D0
	public IEnumerator BrowseForTexture() { }

	// RVA: 0xE76A60 Offset: 0xE75060 VA: 0x180E76A60
	public void Load(string fullname) { }

	// RVA: 0xE77050 Offset: 0xE75650 VA: 0x180E77050
	public void SetTexture(Texture tex) { }

	// RVA: 0xE77630 Offset: 0xE75C30 VA: 0x180E77630
	public bool get_IsDefault() { }

	// RVA: 0xE775C0 Offset: 0xE75BC0 VA: 0x180E775C0
	public bool get_IsClear() { }

	// RVA: 0xE76D00 Offset: 0xE75300 VA: 0x180E76D00 Slot: 4
	public override void Read(Material source, Material def) { }

	// RVA: 0xE76CD0 Offset: 0xE752D0 VA: 0x180E76CD0
	public void OpenFileLocation() { }

	// RVA: 0xE76EE0 Offset: 0xE754E0 VA: 0x180E76EE0
	public void SaveFile() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6470 Offset: 0xD5870 VA: 0x1800D6470
	// RVA: 0xE76940 Offset: 0xE74F40 VA: 0x180E76940
	private IEnumerator DoSaveFile() { }

	// RVA: 0xE76E40 Offset: 0xE75440 VA: 0x180E76E40
	public void ResetToDefault() { }

	// RVA: 0xE76DB0 Offset: 0xE753B0 VA: 0x180E76DB0
	public void ResetToClear() { }

	// RVA: 0xE771A0 Offset: 0xE757A0 VA: 0x180E771A0
	public void StartWatching() { }

	// RVA: 0xE769B0 Offset: 0xE74FB0 VA: 0x180E769B0
	public void FileChanged(string name) { }

	// RVA: 0xE77360 Offset: 0xE75960 VA: 0x180E77360
	public void StopWatching() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE773A0 Offset: 0xE759A0 VA: 0x180E773A0
	private void <StartWatching>b__26_0(object a, FileSystemEventArgs e) { }

}

private sealed class TextureRow.<BrowseForTexture>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7760
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextureRow <>4__this; // 0x20

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

	// RVA: 0xE776B0 Offset: 0xE75CB0 VA: 0x180E776B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE779C0 Offset: 0xE75FC0 VA: 0x180E779C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class TextureRow.<DoSaveFile>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7761
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextureRow <>4__this; // 0x20

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

	// RVA: 0xE793F0 Offset: 0xE779F0 VA: 0x180E793F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE79780 Offset: 0xE77D80 VA: 0x180E79780 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

