internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 3260

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 3261

// Namespace: 
internal class <Module> // TypeDefIndex: 3262

// Namespace: UnityEngine
[VisibleToOtherModulesAttribute] // RVA: 0xB71D0 Offset: 0xB65D0 VA: 0x1800B71D0
[AttributeUsageAttribute] // RVA: 0xB71D0 Offset: 0xB65D0 VA: 0x1800B71D0
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0x7B8CB0 Offset: 0x7B72B0 VA: 0x1807B8CB0
	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

public class AssetBundle : Object // TypeDefIndex: 3992
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[ExcludeFromPresetAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
[NativeHeaderAttribute] // RVA: 0xABB10 Offset: 0xAAF10 VA: 0x1800ABB10
public class AssetBundle : Object // TypeDefIndex: 3992
	// Methods

	// RVA: 0x23208A0 Offset: 0x231EEA0 VA: 0x1823208A0
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xAC0D0 Offset: 0xAB4D0 VA: 0x1800AC0D0
	// RVA: 0x2320730 Offset: 0x231ED30 VA: 0x182320730
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x2320780 Offset: 0x231ED80 VA: 0x182320780
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunctionAttribute] // RVA: 0xAC150 Offset: 0xAB550 VA: 0x1800AC150
	// RVA: 0x23207C0 Offset: 0x231EDC0 VA: 0x1823207C0
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x2320810 Offset: 0x231EE10 VA: 0x182320810
	public static AssetBundle LoadFromFile(string path) { }

	[NativeMethodAttribute] // RVA: 0xAC290 Offset: 0xAB690 VA: 0x1800AC290
	// RVA: 0x2320130 Offset: 0x231E730 VA: 0x182320130
	public bool Contains(string name) { }

	// RVA: -1 Offset: -1
	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159D760 Offset: 0x159BD60 VA: 0x18159D760
	|-AssetBundle.LoadAsset<WorkshopSkinBase>
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xAC310 Offset: 0xAB710 VA: 0x1800AC310
	// RVA: 0x2320610 Offset: 0x231EC10 VA: 0x182320610
	public Object LoadAsset(string name, Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	[TypeInferenceRuleAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	[NativeMethodAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	// RVA: 0x23205B0 Offset: 0x231EBB0 VA: 0x1823205B0
	private Object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x23203F0 Offset: 0x231E9F0 VA: 0x1823203F0
	public AssetBundleRequest LoadAssetAsync(string name) { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAssetAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A366C0 Offset: 0x1A34CC0 VA: 0x181A366C0
	|-AssetBundle.LoadAssetAsync<object>
	|-AssetBundle.LoadAssetAsync<Sprite>
	|-AssetBundle.LoadAssetAsync<TextAsset>
	|-AssetBundle.LoadAssetAsync<Texture2D>
	*/

	// RVA: 0x23202D0 Offset: 0x231E8D0 VA: 0x1823202D0
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A364F0 Offset: 0x1A34AF0 VA: 0x181A364F0
	|-AssetBundle.ConvertObjects<object>
	*/

	// RVA: -1 Offset: -1
	public T[] LoadAllAssets<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36620 Offset: 0x1A34C20 VA: 0x181A36620
	|-AssetBundle.LoadAllAssets<AssetBundleManifest>
	|-AssetBundle.LoadAllAssets<object>
	*/

	// RVA: 0x23201C0 Offset: 0x231E7C0 VA: 0x1823201C0
	public Object[] LoadAllAssets(Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC5B0 Offset: 0xAB9B0 VA: 0x1800AC5B0
	[NativeMethodAttribute] // RVA: 0xAC5B0 Offset: 0xAB9B0 VA: 0x1800AC5B0
	// RVA: 0x2320270 Offset: 0x231E870 VA: 0x182320270
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethodAttribute] // RVA: 0xAC7B0 Offset: 0xABBB0 VA: 0x1800AC7B0
	// RVA: 0x2320850 Offset: 0x231EE50 VA: 0x182320850
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethodAttribute] // RVA: 0xAC900 Offset: 0xABD00 VA: 0x1800AC900
	// RVA: 0x2320180 Offset: 0x231E780 VA: 0x182320180
	public string[] GetAllAssetNames() { }

	[NativeThrowsAttribute] // RVA: 0xACAB0 Offset: 0xABEB0 VA: 0x1800ACAB0
	[NativeMethodAttribute] // RVA: 0xACAB0 Offset: 0xABEB0 VA: 0x1800ACAB0
	// RVA: 0x2320550 Offset: 0x231EB50 VA: 0x182320550
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

}

public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 3993
{	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xACCC0 Offset: 0xAC0C0 VA: 0x1800ACCC0
	// RVA: 0x2320070 Offset: 0x231E670 VA: 0x182320070
	public AssetBundle get_assetBundle() { }

	// RVA: 0x5177F0 Offset: 0x515DF0 VA: 0x1805177F0
	public void .ctor() { }

}

public class AssetBundleManifest : Object // TypeDefIndex: 3994
{	// Methods

	[NativeMethodAttribute] // RVA: 0xACED0 Offset: 0xAC2D0 VA: 0x1800ACED0
	// RVA: 0x23200B0 Offset: 0x231E6B0 VA: 0x1823200B0
	public string[] GetAllAssetBundles() { }

}

public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xAD140 Offset: 0xAC540 VA: 0x1800AD140
[RequiredByNativeCodeAttribute] // RVA: 0xAD140 Offset: 0xAC540 VA: 0x1800AD140
public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
	// Properties
	public Object asset { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xAE510 Offset: 0xAD910 VA: 0x1800AE510
	// RVA: 0x23200F0 Offset: 0x231E6F0 VA: 0x1823200F0
	public Object get_asset() { }

	// RVA: 0x5177F0 Offset: 0x515DF0 VA: 0x1805177F0
	public void .ctor() { }

}

public static class AssetPool // TypeDefIndex: 6562
{	// Fields
	public static Dictionary<Type, AssetPool.Pool> storage; // 0x34DF

	// Methods

	// RVA: -1 Offset: -1
	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9F10 Offset: 0x5C8510 VA: 0x1805C9F10
	|-AssetPool.Get<Mesh>
	|-AssetPool.Get<object>
	*/

	// RVA: 0x1B9E2E0 Offset: 0x1B9C8E0 VA: 0x181B9E2E0
	public static void Free(ref Mesh mesh) { }

	// RVA: -1 Offset: -1
	private static AssetPool.Pool GetPool<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CF20 Offset: 0x125B520 VA: 0x18125CF20
	|-AssetPool.GetPool<object>
	|-AssetPool.GetPool<Mesh>
	*/

	// RVA: 0x1B9E180 Offset: 0x1B9C780 VA: 0x181B9E180
	public static void Clear() { }

	// RVA: 0x1B9E360 Offset: 0x1B9C960 VA: 0x181B9E360
	private static void .cctor() { }

}

public class AssetPool.Pool // TypeDefIndex: 6563
{	// Fields
	public Stack<Object> stack; // 0x10
	public int allocated; // 0x18
	public int available; // 0x1C
	public string name; // 0x20

	// Methods

	// RVA: 0x1BA9E10 Offset: 0x1BA8410 VA: 0x181BA9E10
	public void .ctor(string name) { }

	// RVA: -1 Offset: -1
	public T Pop<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3890 Offset: 0x5D1E90 VA: 0x1805D3890
	|-AssetPool.Pool.Pop<object>
	*/

	// RVA: -1 Offset: -1
	public void Push<T>(ref T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579AD0 Offset: 0x15780D0 VA: 0x181579AD0
	|-AssetPool.Pool.Push<object>
	|-AssetPool.Pool.Push<Mesh>
	*/

	// RVA: 0x1BA9CB0 Offset: 0x1BA82B0 VA: 0x181BA9CB0
	public void Clear() { }

}

public class AssetBundleBackend : FileSystemBackend, IDisposable // TypeDefIndex: 6651
{
// Namespace: 
public class AssetBundleBackend : FileSystemBackend, IDisposable // TypeDefIndex: 6651
	// Fields
	private AssetBundle rootBundle; // 0x28
	private AssetBundleManifest manifest; // 0x30
	private Dictionary<string, AssetBundle> bundles; // 0x38
	private Dictionary<string, AssetBundle> files; // 0x40
	private string assetPath; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <LoadProgress>k__BackingField; // 0x50

	// Properties
	public static bool Enabled { get; }
	public float LoadProgress { get; set; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public static bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x684A50 Offset: 0x683050 VA: 0x180684A50
	public float get_LoadProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22BC780 Offset: 0x22BAD80 VA: 0x1822BC780
	private void set_LoadProgress(float value) { }

	// RVA: 0x22BBFF0 Offset: 0x22BA5F0 VA: 0x1822BBFF0
	public void Load(string assetRoot) { }

	// RVA: 0x22BBE90 Offset: 0x22BA490 VA: 0x1822BBE90
	private AssetBundle LoadBundle(string bundleName) { }

	// RVA: 0x22BB590 Offset: 0x22B9B90 VA: 0x1822BB590
	public void BuildFileIndex() { }

	// RVA: 0x22BB780 Offset: 0x22B9D80 VA: 0x1822BB780 Slot: 9
	public void Dispose() { }

	// RVA: 0x22BC280 Offset: 0x22BA880 VA: 0x1822BC280 Slot: 4
	public override List<string> UnloadBundles(string partialName) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected override T LoadAsset<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9E70 Offset: 0x5C8470 VA: 0x1805C9E70
	|-AssetBundleBackend.LoadAsset<object>
	*/

	// RVA: 0x22BBD10 Offset: 0x22BA310 VA: 0x1822BBD10 Slot: 6
	protected override LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22BB990 Offset: 0x22B9F90 VA: 0x1822BB990 Slot: 7
	protected override string[] LoadAssetList(string folder, string search) { }

	// RVA: -1 Offset: -1 Slot: 8
	public override T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36260 Offset: 0x1A34860 VA: 0x181A36260
	|-AssetBundleBackend.LoadAllFromBundle<object>
	*/

	// RVA: 0x22BC540 Offset: 0x22BAB40 VA: 0x1822BC540
	public void .ctor() { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass17_0 // TypeDefIndex: 6652
{	// Fields
	public AssetBundleBackend <>4__this; // 0x10
	public int maxConcurrency; // 0x18
	public int priority; // 0x1C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22BEA50 Offset: 0x22BD050 VA: 0x1822BEA50
	internal bool <LoadAssetsAsync>b__0(string p) { }

	// RVA: 0x22BEAB0 Offset: 0x22BD0B0 VA: 0x1822BEAB0
	internal AssetBundle <LoadAssetsAsync>b__1(string p) { }

	// RVA: 0x22BEB10 Offset: 0x22BD110 VA: 0x1822BEB10
	internal LoadAssetsResult <LoadAssetsAsync>b__2(IGrouping<AssetBundle, string> g) { }

}

private sealed class AssetBundleBackend.<>c // TypeDefIndex: 6653
{	// Fields
	public static readonly AssetBundleBackend.<>c <>9; // 0x0
	public static Func<string, string> <>9__17_3; // 0x8

	// Methods

	// RVA: 0x22BEDD0 Offset: 0x22BD3D0 VA: 0x1822BEDD0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	internal string <LoadAssetsAsync>b__17_3(string p) { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass18_0 // TypeDefIndex: 6654
{	// Fields
	public string folder; // 0x10
	public Func<KeyValuePair<string, AssetBundle>, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22BED70 Offset: 0x22BD370 VA: 0x1822BED70
	internal bool <LoadAssetList>b__0(KeyValuePair<string, AssetBundle> x) { }

}

internal class AssetBundleLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6655
{	// Fields
	private readonly AssetBundle _bundle; // 0x20
	private readonly List<string> _filePaths; // 0x28
	private readonly int _maxConcurrency; // 0x30
	private readonly int _priority; // 0x34
	private readonly List<AssetBundleRequest> _requests; // 0x38
	[TupleElementNamesAttribute] // RVA: 0xC0930 Offset: 0xBFD30 VA: 0x1800C0930
	private readonly List<ValueTuple<string, AssetBundleRequest>> _pendingRequests; // 0x40
	private int _index; // 0x48

	// Properties
	public override int TotalCount { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22BD0C0 Offset: 0x22BB6C0 VA: 0x1822BD0C0 Slot: 8
	public override int get_TotalCount() { }

	// RVA: 0x22BCDC0 Offset: 0x22BB3C0 VA: 0x1822BCDC0
	internal void .ctor(AssetBundle bundle, List<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22BD100 Offset: 0x22BB700 VA: 0x1822BD100 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22BC910 Offset: 0x22BAF10 VA: 0x1822BC910
	private bool Update() { }

	// RVA: 0x22BC790 Offset: 0x22BAD90 VA: 0x1822BC790 Slot: 11
	public override Dictionary<string, Object> GetResult() { }

}

public class AssetPreloadResult : CustomYieldInstruction // TypeDefIndex: 6656
{	// Fields
	private readonly FileSystemBackend _backend; // 0x10
	private readonly LoadAssetsResult _load; // 0x18
	private readonly List<ValueTuple<string, Object>> _loaded; // 0x20
	private readonly int _alreadyLoadedCount; // 0x28

	// Properties
	public int TotalCount { get; }
	public int CompletedCount { get; }
	[TupleElementNamesAttribute] // RVA: 0xC0D00 Offset: 0xC0100 VA: 0x1800C0D00
	public IReadOnlyList<ValueTuple<string, Object>> Results { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22BD2A0 Offset: 0x22BB8A0 VA: 0x1822BD2A0
	internal void .ctor(FileSystemBackend backend, LoadAssetsResult load, List<ValueTuple<string, Object>> loaded) { }

	// RVA: 0x22BD4A0 Offset: 0x22BBAA0 VA: 0x1822BD4A0
	public int get_TotalCount() { }

	// RVA: 0x22BD470 Offset: 0x22BBA70 VA: 0x1822BD470
	public int get_CompletedCount() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IReadOnlyList<ValueTuple<string, Object>> get_Results() { }

	// RVA: 0x13D1C30 Offset: 0x13D0230 VA: 0x1813D1C30 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22BD120 Offset: 0x22BB720 VA: 0x1822BD120
	private void OnAssetLoaded(string path, Object obj) { }

}

public static class AssetNameCache // TypeDefIndex: 10716
{	// Fields
	private static Dictionary<Object, string> mixed; // 0x0
	private static Dictionary<Object, string> lower; // 0x8
	private static Dictionary<Object, string> upper; // 0x10

	// Methods

	// RVA: 0x831040 Offset: 0x82F640 VA: 0x180831040
	private static string LookupName(Object obj) { }

	// RVA: 0x830D80 Offset: 0x82F380 VA: 0x180830D80
	private static string LookupNameLower(Object obj) { }

	// RVA: 0x830EE0 Offset: 0x82F4E0 VA: 0x180830EE0
	private static string LookupNameUpper(Object obj) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x830CC0 Offset: 0x82F2C0 VA: 0x180830CC0
	public static string GetName(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x830B40 Offset: 0x82F140 VA: 0x180830B40
	public static string GetNameLower(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x830C00 Offset: 0x82F200 VA: 0x180830C00
	public static string GetNameUpper(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x830D20 Offset: 0x82F320 VA: 0x180830D20
	public static string GetName(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x830BA0 Offset: 0x82F1A0 VA: 0x180830BA0
	public static string GetNameLower(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x830C60 Offset: 0x82F260 VA: 0x180830C60
	public static string GetNameUpper(Material mat) { }

	// RVA: 0x831180 Offset: 0x82F780 VA: 0x180831180
	private static void .cctor() { }

}

public static class AssetStorage // TypeDefIndex: 11366
{	// Methods

	// RVA: -1 Offset: -1
	public static void Save<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568C10 Offset: 0x1567210 VA: 0x181568C10
	|-AssetStorage.Save<object>
	*/

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void Save(ref Texture2D asset) { }

	// RVA: 0x831260 Offset: 0x82F860 VA: 0x180831260
	public static void Save(ref Texture2D asset, string path, bool linear, bool compress) { }

	// RVA: -1 Offset: -1
	public static void Load<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-AssetStorage.Load<object>
	*/

	// RVA: -1 Offset: -1
	public static void Delete<T>(ref T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568B70 Offset: 0x1567170 VA: 0x181568B70
	|-AssetStorage.Delete<object>
	*/

}

