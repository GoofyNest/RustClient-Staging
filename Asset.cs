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

	// RVA: 0x7ED280 Offset: 0x7EB880 VA: 0x1807ED280
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

	// RVA: 0x231FDC0 Offset: 0x231E3C0 VA: 0x18231FDC0
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xAC0D0 Offset: 0xAB4D0 VA: 0x1800AC0D0
	// RVA: 0x231FC50 Offset: 0x231E250 VA: 0x18231FC50
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x231FCA0 Offset: 0x231E2A0 VA: 0x18231FCA0
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunctionAttribute] // RVA: 0xAC150 Offset: 0xAB550 VA: 0x1800AC150
	// RVA: 0x231FCE0 Offset: 0x231E2E0 VA: 0x18231FCE0
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x231FD30 Offset: 0x231E330 VA: 0x18231FD30
	public static AssetBundle LoadFromFile(string path) { }

	[NativeMethodAttribute] // RVA: 0xAC290 Offset: 0xAB690 VA: 0x1800AC290
	// RVA: 0x231F650 Offset: 0x231DC50 VA: 0x18231F650
	public bool Contains(string name) { }

	// RVA: -1 Offset: -1
	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E3D0 Offset: 0x159C9D0 VA: 0x18159E3D0
	|-AssetBundle.LoadAsset<WorkshopSkinBase>
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xAC310 Offset: 0xAB710 VA: 0x1800AC310
	// RVA: 0x231FB30 Offset: 0x231E130 VA: 0x18231FB30
	public Object LoadAsset(string name, Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	[TypeInferenceRuleAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	[NativeMethodAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	// RVA: 0x231FAD0 Offset: 0x231E0D0 VA: 0x18231FAD0
	private Object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x231F910 Offset: 0x231DF10 VA: 0x18231F910
	public AssetBundleRequest LoadAssetAsync(string name) { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAssetAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36CE0 Offset: 0x1A352E0 VA: 0x181A36CE0
	|-AssetBundle.LoadAssetAsync<object>
	|-AssetBundle.LoadAssetAsync<Sprite>
	|-AssetBundle.LoadAssetAsync<TextAsset>
	|-AssetBundle.LoadAssetAsync<Texture2D>
	*/

	// RVA: 0x231F7F0 Offset: 0x231DDF0 VA: 0x18231F7F0
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36B10 Offset: 0x1A35110 VA: 0x181A36B10
	|-AssetBundle.ConvertObjects<object>
	*/

	// RVA: -1 Offset: -1
	public T[] LoadAllAssets<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36C40 Offset: 0x1A35240 VA: 0x181A36C40
	|-AssetBundle.LoadAllAssets<AssetBundleManifest>
	|-AssetBundle.LoadAllAssets<object>
	*/

	// RVA: 0x231F6E0 Offset: 0x231DCE0 VA: 0x18231F6E0
	public Object[] LoadAllAssets(Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC5B0 Offset: 0xAB9B0 VA: 0x1800AC5B0
	[NativeMethodAttribute] // RVA: 0xAC5B0 Offset: 0xAB9B0 VA: 0x1800AC5B0
	// RVA: 0x231F790 Offset: 0x231DD90 VA: 0x18231F790
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethodAttribute] // RVA: 0xAC7B0 Offset: 0xABBB0 VA: 0x1800AC7B0
	// RVA: 0x231FD70 Offset: 0x231E370 VA: 0x18231FD70
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethodAttribute] // RVA: 0xAC900 Offset: 0xABD00 VA: 0x1800AC900
	// RVA: 0x231F6A0 Offset: 0x231DCA0 VA: 0x18231F6A0
	public string[] GetAllAssetNames() { }

	[NativeThrowsAttribute] // RVA: 0xACAB0 Offset: 0xABEB0 VA: 0x1800ACAB0
	[NativeMethodAttribute] // RVA: 0xACAB0 Offset: 0xABEB0 VA: 0x1800ACAB0
	// RVA: 0x231FA70 Offset: 0x231E070 VA: 0x18231FA70
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

}

public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 3993
{	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xACCC0 Offset: 0xAC0C0 VA: 0x1800ACCC0
	// RVA: 0x231F590 Offset: 0x231DB90 VA: 0x18231F590
	public AssetBundle get_assetBundle() { }

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
	public void .ctor() { }

}

public class AssetBundleManifest : Object // TypeDefIndex: 3994
{	// Methods

	[NativeMethodAttribute] // RVA: 0xACED0 Offset: 0xAC2D0 VA: 0x1800ACED0
	// RVA: 0x231F5D0 Offset: 0x231DBD0 VA: 0x18231F5D0
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
	// RVA: 0x231F610 Offset: 0x231DC10 VA: 0x18231F610
	public Object get_asset() { }

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
	public void .ctor() { }

}

public static class AssetPool // TypeDefIndex: 6562
{	// Fields
	public static Dictionary<Type, AssetPool.Pool> storage; // 0x2B10398

	// Methods

	// RVA: -1 Offset: -1
	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9F80 Offset: 0x5C8580 VA: 0x1805C9F80
	|-AssetPool.Get<Mesh>
	|-AssetPool.Get<object>
	*/

	// RVA: 0x1B9D830 Offset: 0x1B9BE30 VA: 0x181B9D830
	public static void Free(ref Mesh mesh) { }

	// RVA: -1 Offset: -1
	private static AssetPool.Pool GetPool<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C5C0 Offset: 0x125ABC0 VA: 0x18125C5C0
	|-AssetPool.GetPool<object>
	|-AssetPool.GetPool<Mesh>
	*/

	// RVA: 0x1B9D6D0 Offset: 0x1B9BCD0 VA: 0x181B9D6D0
	public static void Clear() { }

	// RVA: 0x1B9D8B0 Offset: 0x1B9BEB0 VA: 0x181B9D8B0
	private static void .cctor() { }

}

public class AssetPool.Pool // TypeDefIndex: 6563
{	// Fields
	public Stack<Object> stack; // 0x10
	public int allocated; // 0x18
	public int available; // 0x1C
	public string name; // 0x20

	// Methods

	// RVA: 0x1BA9360 Offset: 0x1BA7960 VA: 0x181BA9360
	public void .ctor(string name) { }

	// RVA: -1 Offset: -1
	public T Pop<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3900 Offset: 0x5D1F00 VA: 0x1805D3900
	|-AssetPool.Pool.Pop<object>
	*/

	// RVA: -1 Offset: -1
	public void Push<T>(ref T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157A740 Offset: 0x1578D40 VA: 0x18157A740
	|-AssetPool.Pool.Push<object>
	|-AssetPool.Pool.Push<Mesh>
	*/

	// RVA: 0x1BA9200 Offset: 0x1BA7800 VA: 0x181BA9200
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

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public static bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x684AC0 Offset: 0x6830C0 VA: 0x180684AC0
	public float get_LoadProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22BBCA0 Offset: 0x22BA2A0 VA: 0x1822BBCA0
	private void set_LoadProgress(float value) { }

	// RVA: 0x22BB510 Offset: 0x22B9B10 VA: 0x1822BB510
	public void Load(string assetRoot) { }

	// RVA: 0x22BB3B0 Offset: 0x22B99B0 VA: 0x1822BB3B0
	private AssetBundle LoadBundle(string bundleName) { }

	// RVA: 0x22BAAB0 Offset: 0x22B90B0 VA: 0x1822BAAB0
	public void BuildFileIndex() { }

	// RVA: 0x22BACA0 Offset: 0x22B92A0 VA: 0x1822BACA0 Slot: 9
	public void Dispose() { }

	// RVA: 0x22BB7A0 Offset: 0x22B9DA0 VA: 0x1822BB7A0 Slot: 4
	public override List<string> UnloadBundles(string partialName) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected override T LoadAsset<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9EE0 Offset: 0x5C84E0 VA: 0x1805C9EE0
	|-AssetBundleBackend.LoadAsset<object>
	*/

	// RVA: 0x22BB230 Offset: 0x22B9830 VA: 0x1822BB230 Slot: 6
	protected override LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22BAEB0 Offset: 0x22B94B0 VA: 0x1822BAEB0 Slot: 7
	protected override string[] LoadAssetList(string folder, string search) { }

	// RVA: -1 Offset: -1 Slot: 8
	public override T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36880 Offset: 0x1A34E80 VA: 0x181A36880
	|-AssetBundleBackend.LoadAllFromBundle<object>
	*/

	// RVA: 0x22BBA60 Offset: 0x22BA060 VA: 0x1822BBA60
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

	// RVA: 0x22BDF70 Offset: 0x22BC570 VA: 0x1822BDF70
	internal bool <LoadAssetsAsync>b__0(string p) { }

	// RVA: 0x22BDFD0 Offset: 0x22BC5D0 VA: 0x1822BDFD0
	internal AssetBundle <LoadAssetsAsync>b__1(string p) { }

	// RVA: 0x22BE030 Offset: 0x22BC630 VA: 0x1822BE030
	internal LoadAssetsResult <LoadAssetsAsync>b__2(IGrouping<AssetBundle, string> g) { }

}

private sealed class AssetBundleBackend.<>c // TypeDefIndex: 6653
{	// Fields
	public static readonly AssetBundleBackend.<>c <>9; // 0x0
	public static Func<string, string> <>9__17_3; // 0x8

	// Methods

	// RVA: 0x22BE2F0 Offset: 0x22BC8F0 VA: 0x1822BE2F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	internal string <LoadAssetsAsync>b__17_3(string p) { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass18_0 // TypeDefIndex: 6654
{	// Fields
	public string folder; // 0x10
	public Func<KeyValuePair<string, AssetBundle>, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22BE290 Offset: 0x22BC890 VA: 0x1822BE290
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

	// RVA: 0x22BC5E0 Offset: 0x22BABE0 VA: 0x1822BC5E0 Slot: 8
	public override int get_TotalCount() { }

	// RVA: 0x22BC2E0 Offset: 0x22BA8E0 VA: 0x1822BC2E0
	internal void .ctor(AssetBundle bundle, List<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22BC620 Offset: 0x22BAC20 VA: 0x1822BC620 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22BBE30 Offset: 0x22BA430 VA: 0x1822BBE30
	private bool Update() { }

	// RVA: 0x22BBCB0 Offset: 0x22BA2B0 VA: 0x1822BBCB0 Slot: 11
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

	// RVA: 0x22BC7C0 Offset: 0x22BADC0 VA: 0x1822BC7C0
	internal void .ctor(FileSystemBackend backend, LoadAssetsResult load, List<ValueTuple<string, Object>> loaded) { }

	// RVA: 0x22BC9C0 Offset: 0x22BAFC0 VA: 0x1822BC9C0
	public int get_TotalCount() { }

	// RVA: 0x22BC990 Offset: 0x22BAF90 VA: 0x1822BC990
	public int get_CompletedCount() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IReadOnlyList<ValueTuple<string, Object>> get_Results() { }

	// RVA: 0x13D2870 Offset: 0x13D0E70 VA: 0x1813D2870 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22BC640 Offset: 0x22BAC40 VA: 0x1822BC640
	private void OnAssetLoaded(string path, Object obj) { }

}

public static class AssetNameCache // TypeDefIndex: 10716
{	// Fields
	private static Dictionary<Object, string> mixed; // 0x0
	private static Dictionary<Object, string> lower; // 0x8
	private static Dictionary<Object, string> upper; // 0x10

	// Methods

	// RVA: 0x8309E0 Offset: 0x82EFE0 VA: 0x1808309E0
	private static string LookupName(Object obj) { }

	// RVA: 0x830720 Offset: 0x82ED20 VA: 0x180830720
	private static string LookupNameLower(Object obj) { }

	// RVA: 0x830880 Offset: 0x82EE80 VA: 0x180830880
	private static string LookupNameUpper(Object obj) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x830660 Offset: 0x82EC60 VA: 0x180830660
	public static string GetName(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8304E0 Offset: 0x82EAE0 VA: 0x1808304E0
	public static string GetNameLower(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8305A0 Offset: 0x82EBA0 VA: 0x1808305A0
	public static string GetNameUpper(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8306C0 Offset: 0x82ECC0 VA: 0x1808306C0
	public static string GetName(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x830540 Offset: 0x82EB40 VA: 0x180830540
	public static string GetNameLower(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x830600 Offset: 0x82EC00 VA: 0x180830600
	public static string GetNameUpper(Material mat) { }

	// RVA: 0x830B20 Offset: 0x82F120 VA: 0x180830B20
	private static void .cctor() { }

}

public static class AssetStorage // TypeDefIndex: 11366
{	// Methods

	// RVA: -1 Offset: -1
	public static void Save<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569880 Offset: 0x1567E80 VA: 0x181569880
	|-AssetStorage.Save<object>
	*/

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void Save(ref Texture2D asset) { }

	// RVA: 0x830C00 Offset: 0x82F200 VA: 0x180830C00
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
	|-RVA: 0x15697E0 Offset: 0x1567DE0 VA: 0x1815697E0
	|-AssetStorage.Delete<object>
	*/

}

