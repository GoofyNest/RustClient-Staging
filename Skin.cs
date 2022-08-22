public class Skin // TypeDefIndex: 7728
{	// Fields
	private string manifestName; // 0x10
	private string manifestContent; // 0x18
	private TextAsset manifestAsset; // 0x20
	private Skin.Manifest manifest; // 0x28
	private string iconName; // 0x30
	public Sprite sprite; // 0x38
	public int references; // 0x40
	public Skinnable Skinnable; // 0x48
	public Material[] Materials; // 0x50
	public Material[] DefaultMaterials; // 0x58
	public List<Texture> TextureAssets; // 0x60
	public List<Texture> TextureObjects; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <AssetsRequested>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IconRequested>k__BackingField; // 0x71
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <AssetsLoaded>k__BackingField; // 0x72
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IconLoaded>k__BackingField; // 0x73
	public Action OnLoaded; // 0x78
	public Action OnIconLoaded; // 0x80

	// Properties
	public bool AssetsRequested { get; set; }
	public bool IconRequested { get; set; }
	public bool AssetsLoaded { get; set; }
	public bool IconLoaded { get; set; }

	// Methods

	// RVA: 0xE750A0 Offset: 0xE736A0 VA: 0x180E750A0
	private void LoadManifestFromFile() { }

	// RVA: 0xE74BF0 Offset: 0xE731F0 VA: 0x180E74BF0
	private void DeserializeManifest() { }

	[IteratorStateMachineAttribute] // RVA: 0xCADC0 Offset: 0xCA1C0 VA: 0x1800CADC0
	// RVA: 0xE74FF0 Offset: 0xE735F0 VA: 0x180E74FF0
	public IEnumerator LoadIcon(ulong workshopId, string directory, AssetBundle bundle) { }

	[IteratorStateMachineAttribute] // RVA: 0xCAF10 Offset: 0xCA310 VA: 0x1800CAF10
	// RVA: 0xE74F40 Offset: 0xE73540 VA: 0x180E74F40
	public IEnumerator LoadAssets(ulong workshopId, string directory, AssetBundle bundle) { }

	// RVA: 0xE754F0 Offset: 0xE73AF0 VA: 0x180E754F0
	public void UnloadAssets() { }

	// RVA: 0xE757B0 Offset: 0xE73DB0 VA: 0x180E757B0
	private void UpdateTextureMetadata(Texture2D texture, string textureName, bool anisoFiltering, bool trilinearFiltering) { }

	// RVA: 0xE74BD0 Offset: 0xE731D0 VA: 0x180E74BD0
	internal void Apply(GameObject gameObject) { }

	// RVA: 0xE74C70 Offset: 0xE73270 VA: 0x180E74C70
	public int GetSizeInBytes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC312F0 Offset: 0xC2F8F0 VA: 0x180C312F0
	public bool get_AssetsRequested() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32410 Offset: 0xC30A10 VA: 0x180C32410
	public void set_AssetsRequested(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75840 Offset: 0xE73E40 VA: 0x180E75840
	public bool get_IconRequested() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75870 Offset: 0xE73E70 VA: 0x180E75870
	public void set_IconRequested(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75820 Offset: 0xE73E20 VA: 0x180E75820
	public bool get_AssetsLoaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75850 Offset: 0xE73E50 VA: 0x180E75850
	internal void set_AssetsLoaded(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75830 Offset: 0xE73E30 VA: 0x180E75830
	public bool get_IconLoaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75860 Offset: 0xE73E60 VA: 0x180E75860
	internal void set_IconLoaded(bool value) { }

	// RVA: 0xE749F0 Offset: 0xE72FF0 VA: 0x180E749F0
	public static void Apply(GameObject obj, Skinnable skinnable, Material[] Materials) { }

	// RVA: 0xE750D0 Offset: 0xE736D0 VA: 0x180E750D0
	internal void ReadDefaults() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Skin.Manifest // TypeDefIndex: 7729
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Version>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <ItemType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <AuthorId>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DateTime <PublishDate>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Skin.Manifest.Group[] <Groups>k__BackingField; // 0x30

	// Properties
	public int Version { get; set; }
	public string ItemType { get; set; }
	public ulong AuthorId { get; set; }
	public DateTime PublishDate { get; set; }
	public Skin.Manifest.Group[] Groups { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	public void set_Version(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_ItemType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ItemType(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public ulong get_AuthorId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73FD0 Offset: 0xE725D0 VA: 0x180E73FD0
	public void set_AuthorId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public DateTime get_PublishDate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72CC0 Offset: 0xE712C0 VA: 0x180E72CC0
	public void set_PublishDate(DateTime value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public Skin.Manifest.Group[] get_Groups() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_Groups(Skin.Manifest.Group[] value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Skin.Manifest.Group // TypeDefIndex: 7730
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Dictionary<string, string> <Textures>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Dictionary<string, float> <Floats>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Dictionary<string, Skin.Manifest.ColorEntry> <Colors>k__BackingField; // 0x20

	// Properties
	public Dictionary<string, string> Textures { get; set; }
	public Dictionary<string, float> Floats { get; set; }
	public Dictionary<string, Skin.Manifest.ColorEntry> Colors { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Dictionary<string, string> get_Textures() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Textures(Dictionary<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Dictionary<string, float> get_Floats() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Floats(Dictionary<string, float> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Dictionary<string, Skin.Manifest.ColorEntry> get_Colors() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Colors(Dictionary<string, Skin.Manifest.ColorEntry> value) { }

	// RVA: 0xE73520 Offset: 0xE71B20 VA: 0x180E73520
	public void .ctor() { }

}

public class Skin.Manifest.ColorEntry // TypeDefIndex: 7731
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <r>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <g>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <b>k__BackingField; // 0x18

	// Properties
	public float r { get; set; }
	public float g { get; set; }
	public float b { get; set; }

	// Methods

	// RVA: 0xE72CD0 Offset: 0xE712D0 VA: 0x180E72CD0
	public void .ctor(Color c) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA10E10 Offset: 0xA0F410 VA: 0x180A10E10
	public float get_r() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA10E30 Offset: 0xA0F430 VA: 0x180A10E30
	public void set_r(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72D10 Offset: 0xE71310 VA: 0x180E72D10
	public float get_g() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72D20 Offset: 0xE71320 VA: 0x180E72D20
	public void set_g(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_b() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	public void set_b(float value) { }

}

private sealed class Skin.<>c__DisplayClass10_0 // TypeDefIndex: 7732
{	// Fields
	public InventoryDef[] definitions; // 0x10
	public string downloadUrl; // 0x18
	public Skin <>4__this; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80680 Offset: 0xE7EC80 VA: 0x180E80680
	internal void <LoadIcon>g__FindURL|0() { }

}

private sealed class Skin.<LoadIcon>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7733
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AssetBundle bundle; // 0x20
	public Skin <>4__this; // 0x28
	public ulong workshopId; // 0x30
	public string directory; // 0x38
	private Skin.<>c__DisplayClass10_0 <>8__1; // 0x40
	private AssetBundleRequest <textRequest>5__2; // 0x48
	private UnityWebRequest <request>5__3; // 0x50
	private AsyncTextureLoad <request>5__4; // 0x58

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

	// RVA: 0xE7BEC0 Offset: 0xE7A4C0 VA: 0x180E7BEC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7CAE0 Offset: 0xE7B0E0 VA: 0x180E7CAE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Skin.<LoadAssets>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7734
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Skin <>4__this; // 0x20
	public ulong workshopId; // 0x28
	public AssetBundle bundle; // 0x30
	public string directory; // 0x38
	private int <i>5__2; // 0x40
	private Material <material>5__3; // 0x48
	private Dictionary.Enumerator<string, string> <>7__wrap3; // 0x50
	private KeyValuePair<string, string> <mat>5__5; // 0x78
	private bool <isDiffuseMap>5__6; // 0x88
	private bool <isNormalMap>5__7; // 0x89
	private bool <isOcclusionMap>5__8; // 0x8A
	private string <textureName>5__9; // 0x90
	private AssetBundleRequest <textureRequest>5__10; // 0x98
	private AsyncTextureLoad <request>5__11; // 0xA0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7BDD0 Offset: 0xE7A3D0 VA: 0x180E7BDD0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE7ACF0 Offset: 0xE792F0 VA: 0x180E7ACF0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0xE7BE80 Offset: 0xE7A480 VA: 0x180E7BE80
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7BD80 Offset: 0xE7A380 VA: 0x180E7BD80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

