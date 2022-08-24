internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
{
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 3260

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 3261

internal class <Module> // TypeDefIndex: 3262

[VisibleToOtherModulesAttribute] // RVA: 0xB9290 Offset: 0xB8690 VA: 0x1800B9290
[AttributeUsageAttribute] // RVA: 0xB9290 Offset: 0xB8690 VA: 0x1800B9290
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18


	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

public class AssetBundle : Object // TypeDefIndex: 3992
{
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[ExcludeFromPresetAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
[NativeHeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
public class AssetBundle : Object // TypeDefIndex: 3992

	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xAC210 Offset: 0xAB610 VA: 0x1800AC210
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunctionAttribute] // RVA: 0xAC2A0 Offset: 0xAB6A0 VA: 0x1800AC2A0
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundle LoadFromFile(string path) { }

	[NativeMethodAttribute] // RVA: 0xAC490 Offset: 0xAB890 VA: 0x1800AC490
	public bool Contains(string name) { }

	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-AssetBundle.LoadAsset<WorkshopSkinBase>
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xAC540 Offset: 0xAB940 VA: 0x1800AC540
	public Object LoadAsset(string name, Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC5E0 Offset: 0xAB9E0 VA: 0x1800AC5E0
	[TypeInferenceRuleAttribute] // RVA: 0xAC5E0 Offset: 0xAB9E0 VA: 0x1800AC5E0
	[NativeMethodAttribute] // RVA: 0xAC5E0 Offset: 0xAB9E0 VA: 0x1800AC5E0
	private Object LoadAsset_Internal(string name, Type type) { }

	public AssetBundleRequest LoadAssetAsync(string name) { }

	public AssetBundleRequest LoadAssetAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-AssetBundle.LoadAssetAsync<object>
	|-AssetBundle.LoadAssetAsync<Sprite>
	|-AssetBundle.LoadAssetAsync<TextAsset>
	|-AssetBundle.LoadAssetAsync<Texture2D>
	*/

	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-AssetBundle.ConvertObjects<object>
	*/

	public T[] LoadAllAssets<T>() { }
	/* GenericInstMethod :
	|
	|-AssetBundle.LoadAllAssets<AssetBundleManifest>
	|-AssetBundle.LoadAllAssets<object>
	*/

	public Object[] LoadAllAssets(Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC720 Offset: 0xABB20 VA: 0x1800AC720
	[NativeMethodAttribute] // RVA: 0xAC720 Offset: 0xABB20 VA: 0x1800AC720
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethodAttribute] // RVA: 0xAC900 Offset: 0xABD00 VA: 0x1800AC900
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethodAttribute] // RVA: 0xACA10 Offset: 0xABE10 VA: 0x1800ACA10
	public string[] GetAllAssetNames() { }

	[NativeThrowsAttribute] // RVA: 0xACB90 Offset: 0xABF90 VA: 0x1800ACB90
	[NativeMethodAttribute] // RVA: 0xACB90 Offset: 0xABF90 VA: 0x1800ACB90
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

}

public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 3993
{	public AssetBundle assetBundle { get; }


	[NativeMethodAttribute] // RVA: 0xACE30 Offset: 0xAC230 VA: 0x1800ACE30
	public AssetBundle get_assetBundle() { }

	public void .ctor() { }

}

public class AssetBundleManifest : Object // TypeDefIndex: 3994
{
	[NativeMethodAttribute] // RVA: 0xAD090 Offset: 0xAC490 VA: 0x1800AD090
	public string[] GetAllAssetBundles() { }

}

public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
{
[NativeHeaderAttribute] // RVA: 0xAD310 Offset: 0xAC710 VA: 0x1800AD310
[RequiredByNativeCodeAttribute] // RVA: 0xAD310 Offset: 0xAC710 VA: 0x1800AD310
public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
	public Object asset { get; }


	[NativeMethodAttribute] // RVA: 0xAE710 Offset: 0xADB10 VA: 0x1800AE710
	public Object get_asset() { }

	public void .ctor() { }

}

public static class AssetPool // TypeDefIndex: 6562
{	public static Dictionary<Type, AssetPool.Pool> storage; // 0x37B0


	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-AssetPool.Get<Mesh>
	|-AssetPool.Get<object>
	*/

	public static void Free(ref Mesh mesh) { }

	private static AssetPool.Pool GetPool<T>() { }
	/* GenericInstMethod :
	|
	|-AssetPool.GetPool<object>
	|-AssetPool.GetPool<Mesh>
	*/

	public static void Clear() { }

	private static void .cctor() { }

}

public class AssetPool.Pool // TypeDefIndex: 6563
{	public Stack<Object> stack; // 0x10
	public int allocated; // 0x18
	public int available; // 0x1C
	public string name; // 0x20


	public void .ctor(string name) { }

	public T Pop<T>() { }
	/* GenericInstMethod :
	|
	|-AssetPool.Pool.Pop<object>
	*/

	public void Push<T>(ref T instance) { }
	/* GenericInstMethod :
	|
	|-AssetPool.Pool.Push<object>
	|-AssetPool.Pool.Push<Mesh>
	*/

	public void Clear() { }

}

public class AssetBundleBackend : FileSystemBackend, IDisposable // TypeDefIndex: 6651
{
public class AssetBundleBackend : FileSystemBackend, IDisposable // TypeDefIndex: 6651
	private AssetBundle rootBundle; // 0x28
	private AssetBundleManifest manifest; // 0x30
	private Dictionary<string, AssetBundle> bundles; // 0x38
	private Dictionary<string, AssetBundle> files; // 0x40
	private string assetPath; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <LoadProgress>k__BackingField; // 0x50

	public static bool Enabled { get; }
	public float LoadProgress { get; set; }


	public static bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_LoadProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_LoadProgress(float value) { }

	public void Load(string assetRoot) { }

	private AssetBundle LoadBundle(string bundleName) { }

	public void BuildFileIndex() { }

	public void Dispose() { }

	public override List<string> UnloadBundles(string partialName) { }

	protected override T LoadAsset<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-AssetBundleBackend.LoadAsset<object>
	*/

	protected override LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority) { }

	protected override string[] LoadAssetList(string folder, string search) { }

	public override T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-AssetBundleBackend.LoadAllFromBundle<object>
	*/

	public void .ctor() { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass17_0 // TypeDefIndex: 6652
{	public AssetBundleBackend <>4__this; // 0x10
	public int maxConcurrency; // 0x18
	public int priority; // 0x1C


	public void .ctor() { }

	internal bool <LoadAssetsAsync>b__0(string p) { }

	internal AssetBundle <LoadAssetsAsync>b__1(string p) { }

	internal LoadAssetsResult <LoadAssetsAsync>b__2(IGrouping<AssetBundle, string> g) { }

}

private sealed class AssetBundleBackend.<>c // TypeDefIndex: 6653
{	public static readonly AssetBundleBackend.<>c <>9; // 0x0
	public static Func<string, string> <>9__17_3; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <LoadAssetsAsync>b__17_3(string p) { }

}

private sealed class AssetBundleBackend.<>c__DisplayClass18_0 // TypeDefIndex: 6654
{	public string folder; // 0x10
	public Func<KeyValuePair<string, AssetBundle>, bool> <>9__0; // 0x18


	public void .ctor() { }

	internal bool <LoadAssetList>b__0(KeyValuePair<string, AssetBundle> x) { }

}

internal class AssetBundleLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6655
{	private readonly AssetBundle _bundle; // 0x20
	private readonly List<string> _filePaths; // 0x28
	private readonly int _maxConcurrency; // 0x30
	private readonly int _priority; // 0x34
	private readonly List<AssetBundleRequest> _requests; // 0x38
	[TupleElementNamesAttribute] // RVA: 0xC0BC0 Offset: 0xBFFC0 VA: 0x1800C0BC0
	private readonly List<ValueTuple<string, AssetBundleRequest>> _pendingRequests; // 0x40
	private int _index; // 0x48

	public override int TotalCount { get; }
	public override bool keepWaiting { get; }


	public override int get_TotalCount() { }

	internal void .ctor(AssetBundle bundle, List<string> filePaths, int maxConcurrency, int priority) { }

	public override bool get_keepWaiting() { }

	private bool Update() { }

	public override Dictionary<string, Object> GetResult() { }

}

public class AssetPreloadResult : CustomYieldInstruction // TypeDefIndex: 6656
{	private readonly FileSystemBackend _backend; // 0x10
	private readonly LoadAssetsResult _load; // 0x18
	private readonly List<ValueTuple<string, Object>> _loaded; // 0x20
	private readonly int _alreadyLoadedCount; // 0x28

	public int TotalCount { get; }
	public int CompletedCount { get; }
	[TupleElementNamesAttribute] // RVA: 0xC0F40 Offset: 0xC0340 VA: 0x1800C0F40
	public IReadOnlyList<ValueTuple<string, Object>> Results { get; }
	public override bool keepWaiting { get; }


	internal void .ctor(FileSystemBackend backend, LoadAssetsResult load, List<ValueTuple<string, Object>> loaded) { }

	public int get_TotalCount() { }

	public int get_CompletedCount() { }

	public IReadOnlyList<ValueTuple<string, Object>> get_Results() { }

	public override bool get_keepWaiting() { }

	private void OnAssetLoaded(string path, Object obj) { }

}

public static class AssetNameCache // TypeDefIndex: 10720
{	private static Dictionary<Object, string> mixed; // 0x0
	private static Dictionary<Object, string> lower; // 0x8
	private static Dictionary<Object, string> upper; // 0x10


	private static string LookupName(Object obj) { }

	private static string LookupNameLower(Object obj) { }

	private static string LookupNameUpper(Object obj) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static string GetName(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static string GetNameLower(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static string GetNameUpper(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static string GetName(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static string GetNameLower(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static string GetNameUpper(Material mat) { }

	private static void .cctor() { }

}

public static class AssetStorage // TypeDefIndex: 11370
{
	public static void Save<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-AssetStorage.Save<object>
	*/

	public static void Save(ref Texture2D asset) { }

	public static void Save(ref Texture2D asset, string path, bool linear, bool compress) { }

	public static void Load<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-AssetStorage.Load<object>
	*/

	public static void Delete<T>(ref T asset) { }
	/* GenericInstMethod :
	|
	|-AssetStorage.Delete<object>
	*/

}

