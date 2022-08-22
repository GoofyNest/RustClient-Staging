internal class ImportVersion2 : SingletonComponent<ImportVersion2> // TypeDefIndex: 7772
{	// Fields
	private AssetBundle Bundle; // 0x18

	// Methods

	// RVA: 0xE73EF0 Offset: 0xE724F0 VA: 0x180E73EF0
	public void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xD9560 Offset: 0xD8960 VA: 0x1800D9560
	// RVA: 0xE73BB0 Offset: 0xE721B0 VA: 0x180E73BB0
	internal IEnumerator DoImport(IWorkshopContent item, Skin skin) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9730 Offset: 0xD8B30 VA: 0x1800D9730
	// RVA: 0xE73E30 Offset: 0xE72430 VA: 0x180E73E30
	public IEnumerator LoadItem(string Folder, string BundleName, Skin skin) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9820 Offset: 0xD8C20 VA: 0x1800D9820
	// RVA: 0xE73FF0 Offset: 0xE725F0 VA: 0x180E73FF0
	private IEnumerator ProcessMaterial(int v, Material inputMaterial, Skin skin) { }

	// RVA: 0xE73C50 Offset: 0xE72250 VA: 0x180E73C50
	private Texture2D ImportTexture(string name, Material inputMaterial, Material outputMaterial, bool normal, Skin skin, int group, string targetName) { }

	// RVA: 0xE739D0 Offset: 0xE71FD0 VA: 0x180E739D0
	private Texture2D ConvertMetalToSpec(Texture2D tex, Material outputMaterial) { }

	// RVA: 0xE740A0 Offset: 0xE726A0 VA: 0x180E740A0
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

	// RVA: 0xE78540 Offset: 0xE76B40 VA: 0x180E78540 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE788F0 Offset: 0xE76EF0 VA: 0x180E788F0 Slot: 8
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

	// RVA: 0xE80AC0 Offset: 0xE7F0C0 VA: 0x180E80AC0
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

	// RVA: 0xE7D5F0 Offset: 0xE7BBF0 VA: 0x180E7D5F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7DB90 Offset: 0xE7C190 VA: 0x180E7DB90 Slot: 8
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

	// RVA: 0xE7E7E0 Offset: 0xE7CDE0 VA: 0x180E7E7E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7ED60 Offset: 0xE7D360 VA: 0x180E7ED60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

