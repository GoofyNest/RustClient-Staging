public class TextureRow : MaterialRow // TypeDefIndex: 7759
{	private string Filename; // 0x20
	public bool IsNormalMap; // 0x28
	public RawImage TargetImage; // 0x30
	public Text FilenameLabel; // 0x38
	public Button Reset; // 0x40
	public Button Clear; // 0x48
	public bool HasChanges; // 0x50
	private Texture Default; // 0x58
	private FileSystemWatcher watcher; // 0x60

	public bool IsDefault { get; }
	public bool IsClear { get; }


	public void Update() { }

	public void SetFilenameText(string filename) { }

	public void OnDisable() { }

	public void OpenFileBrowser() { }

	[IteratorStateMachineAttribute] // RVA: 0xD64E0 Offset: 0xD58E0 VA: 0x1800D64E0
	public IEnumerator BrowseForTexture() { }

	public void Load(string fullname) { }

	public void SetTexture(Texture tex) { }

	public bool get_IsDefault() { }

	public bool get_IsClear() { }

	public override void Read(Material source, Material def) { }

	public void OpenFileLocation() { }

	public void SaveFile() { }

	[IteratorStateMachineAttribute] // RVA: 0xD65A0 Offset: 0xD59A0 VA: 0x1800D65A0
	private IEnumerator DoSaveFile() { }

	public void ResetToDefault() { }

	public void ResetToClear() { }

	public void StartWatching() { }

	public void FileChanged(string name) { }

	public void StopWatching() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void <StartWatching>b__26_0(object a, FileSystemEventArgs e) { }

}

private sealed class TextureRow.<BrowseForTexture>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7760
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextureRow <>4__this; // 0x20

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

private sealed class TextureRow.<DoSaveFile>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7761
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextureRow <>4__this; // 0x20

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

