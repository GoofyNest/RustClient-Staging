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

	// RVA: 0xE76930 Offset: 0xE74F30 VA: 0x180E76930
	public void Update() { }

	// RVA: 0xE76510 Offset: 0xE74B10 VA: 0x180E76510
	public void SetFilenameText(string filename) { }

	// RVA: 0xE76120 Offset: 0xE74720 VA: 0x180E76120
	public void OnDisable() { }

	// RVA: 0xE761B0 Offset: 0xE747B0 VA: 0x180E761B0
	public void OpenFileBrowser() { }

	[IteratorStateMachineAttribute] // RVA: 0xD63B0 Offset: 0xD57B0 VA: 0x1800D63B0
	// RVA: 0xE75E20 Offset: 0xE74420 VA: 0x180E75E20
	public IEnumerator BrowseForTexture() { }

	// RVA: 0xE75FB0 Offset: 0xE745B0 VA: 0x180E75FB0
	public void Load(string fullname) { }

	// RVA: 0xE765A0 Offset: 0xE74BA0 VA: 0x180E765A0
	public void SetTexture(Texture tex) { }

	// RVA: 0xE76B80 Offset: 0xE75180 VA: 0x180E76B80
	public bool get_IsDefault() { }

	// RVA: 0xE76B10 Offset: 0xE75110 VA: 0x180E76B10
	public bool get_IsClear() { }

	// RVA: 0xE76250 Offset: 0xE74850 VA: 0x180E76250 Slot: 4
	public override void Read(Material source, Material def) { }

	// RVA: 0xE76220 Offset: 0xE74820 VA: 0x180E76220
	public void OpenFileLocation() { }

	// RVA: 0xE76430 Offset: 0xE74A30 VA: 0x180E76430
	public void SaveFile() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6470 Offset: 0xD5870 VA: 0x1800D6470
	// RVA: 0xE75E90 Offset: 0xE74490 VA: 0x180E75E90
	private IEnumerator DoSaveFile() { }

	// RVA: 0xE76390 Offset: 0xE74990 VA: 0x180E76390
	public void ResetToDefault() { }

	// RVA: 0xE76300 Offset: 0xE74900 VA: 0x180E76300
	public void ResetToClear() { }

	// RVA: 0xE766F0 Offset: 0xE74CF0 VA: 0x180E766F0
	public void StartWatching() { }

	// RVA: 0xE75F00 Offset: 0xE74500 VA: 0x180E75F00
	public void FileChanged(string name) { }

	// RVA: 0xE768B0 Offset: 0xE74EB0 VA: 0x180E768B0
	public void StopWatching() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE768F0 Offset: 0xE74EF0 VA: 0x180E768F0
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

	// RVA: 0xE76C00 Offset: 0xE75200 VA: 0x180E76C00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE76F10 Offset: 0xE75510 VA: 0x180E76F10 Slot: 8
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

	// RVA: 0xE78940 Offset: 0xE76F40 VA: 0x180E78940 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE78CD0 Offset: 0xE772D0 VA: 0x180E78CD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

