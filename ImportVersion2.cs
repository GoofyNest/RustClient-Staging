internal class ImportVersion2 : SingletonComponent<ImportVersion2> // TypeDefIndex: 7772
{	// Fields
	private AssetBundle Bundle; // 0x18

	// Methods

	// RVA: 0xE73C30 Offset: 0xE72230 VA: 0x180E73C30
	public void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xD9560 Offset: 0xD8960 VA: 0x1800D9560
	// RVA: 0xE738F0 Offset: 0xE71EF0 VA: 0x180E738F0
	internal IEnumerator DoImport(IWorkshopContent item, Skin skin) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9730 Offset: 0xD8B30 VA: 0x1800D9730
	// RVA: 0xE73B70 Offset: 0xE72170 VA: 0x180E73B70
	public IEnumerator LoadItem(string Folder, string BundleName, Skin skin) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9820 Offset: 0xD8C20 VA: 0x1800D9820
	// RVA: 0xE73D30 Offset: 0xE72330 VA: 0x180E73D30
	private IEnumerator ProcessMaterial(int v, Material inputMaterial, Skin skin) { }

	// RVA: 0xE73990 Offset: 0xE71F90 VA: 0x180E73990
	private Texture2D ImportTexture(string name, Material inputMaterial, Material outputMaterial, bool normal, Skin skin, int group, string targetName) { }

	// RVA: 0xE73710 Offset: 0xE71D10 VA: 0x180E73710
	private Texture2D ConvertMetalToSpec(Texture2D tex, Material outputMaterial) { }

	// RVA: 0xE73DE0 Offset: 0xE723E0 VA: 0x180E73DE0
	public void .ctor() { }

}

private sealed class ImportVersion2.<DoImport>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7773
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ImportVersion2 <>4__this; // 0x20
	public IWorkshopContent item; // 0x28
	public Skin skin; // 0x30

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

	// RVA: 0xE78280 Offset: 0xE76880 VA: 0x180E78280 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE78630 Offset: 0xE76C30 VA: 0x180E78630 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ImportVersion2.<>c__DisplayClass3_0 // TypeDefIndex: 7774
{	// Fields
	public AssetBundleCreateRequest request; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80800 Offset: 0xE7EE00 VA: 0x180E80800
	internal bool <LoadItem>b__0() { }

}

private sealed class ImportVersion2.<LoadItem>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7775
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string BundleName; // 0x20
	private ImportVersion2.<>c__DisplayClass3_0 <>8__1; // 0x28
	public ImportVersion2 <>4__this; // 0x30
	public string Folder; // 0x38
	public Skin skin; // 0x40
	private WorkshopSkinBase <asset>5__2; // 0x48

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

	// RVA: 0xE7D330 Offset: 0xE7B930 VA: 0x180E7D330 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7D8D0 Offset: 0xE7BED0 VA: 0x180E7D8D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ImportVersion2.<ProcessMaterial>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7776
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Material inputMaterial; // 0x20
	public Skin skin; // 0x28
	public int v; // 0x30
	public ImportVersion2 <>4__this; // 0x38

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

	// RVA: 0xE7E520 Offset: 0xE7CB20 VA: 0x180E7E520 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7EAA0 Offset: 0xE7D0A0 VA: 0x180E7EAA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

