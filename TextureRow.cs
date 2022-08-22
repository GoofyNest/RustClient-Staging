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

	// RVA: 0xE76670 Offset: 0xE74C70 VA: 0x180E76670
	public void Update() { }

	// RVA: 0xE76250 Offset: 0xE74850 VA: 0x180E76250
	public void SetFilenameText(string filename) { }

	// RVA: 0xE75E60 Offset: 0xE74460 VA: 0x180E75E60
	public void OnDisable() { }

	// RVA: 0xE75EF0 Offset: 0xE744F0 VA: 0x180E75EF0
	public void OpenFileBrowser() { }

	[IteratorStateMachineAttribute] // RVA: 0xD63B0 Offset: 0xD57B0 VA: 0x1800D63B0
	// RVA: 0xE75B60 Offset: 0xE74160 VA: 0x180E75B60
	public IEnumerator BrowseForTexture() { }

	// RVA: 0xE75CF0 Offset: 0xE742F0 VA: 0x180E75CF0
	public void Load(string fullname) { }

	// RVA: 0xE762E0 Offset: 0xE748E0 VA: 0x180E762E0
	public void SetTexture(Texture tex) { }

	// RVA: 0xE768C0 Offset: 0xE74EC0 VA: 0x180E768C0
	public bool get_IsDefault() { }

	// RVA: 0xE76850 Offset: 0xE74E50 VA: 0x180E76850
	public bool get_IsClear() { }

	// RVA: 0xE75F90 Offset: 0xE74590 VA: 0x180E75F90 Slot: 4
	public override void Read(Material source, Material def) { }

	// RVA: 0xE75F60 Offset: 0xE74560 VA: 0x180E75F60
	public void OpenFileLocation() { }

	// RVA: 0xE76170 Offset: 0xE74770 VA: 0x180E76170
	public void SaveFile() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6470 Offset: 0xD5870 VA: 0x1800D6470
	// RVA: 0xE75BD0 Offset: 0xE741D0 VA: 0x180E75BD0
	private IEnumerator DoSaveFile() { }

	// RVA: 0xE760D0 Offset: 0xE746D0 VA: 0x180E760D0
	public void ResetToDefault() { }

	// RVA: 0xE76040 Offset: 0xE74640 VA: 0x180E76040
	public void ResetToClear() { }

	// RVA: 0xE76430 Offset: 0xE74A30 VA: 0x180E76430
	public void StartWatching() { }

	// RVA: 0xE75C40 Offset: 0xE74240 VA: 0x180E75C40
	public void FileChanged(string name) { }

	// RVA: 0xE765F0 Offset: 0xE74BF0 VA: 0x180E765F0
	public void StopWatching() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE76630 Offset: 0xE74C30 VA: 0x180E76630
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

	// RVA: 0xE76940 Offset: 0xE74F40 VA: 0x180E76940 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE76C50 Offset: 0xE75250 VA: 0x180E76C50 Slot: 8
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

	// RVA: 0xE78680 Offset: 0xE76C80 VA: 0x180E78680 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE78A10 Offset: 0xE77010 VA: 0x180E78A10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

