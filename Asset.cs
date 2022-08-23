internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
{
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 3260

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 3261

internal class <Module> // TypeDefIndex: 3262

[VisibleToOtherModulesAttribute] // RVA: 0xB71D0 Offset: 0xB65D0 VA: 0x1800B71D0
[AttributeUsageAttribute] // RVA: 0xB71D0 Offset: 0xB65D0 VA: 0x1800B71D0
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18


	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

public class AssetBundle : Object // TypeDefIndex: 3992
{
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

	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xAC0D0 Offset: 0xAB4D0 VA: 0x1800AC0D0
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunctionAttribute] // RVA: 0xAC150 Offset: 0xAB550 VA: 0x1800AC150
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	public static AssetBundle LoadFromFile(string path) { }

	[NativeMethodAttribute] // RVA: 0xAC290 Offset: 0xAB690 VA: 0x1800AC290
	public bool Contains(string name) { }

	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159D860 Offset: 0x159BE60 VA: 0x18159D860
	|-AssetBundle.LoadAsset<WorkshopSkinBase>
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xAC310 Offset: 0xAB710 VA: 0x1800AC310
	public Object LoadAsset(string name, Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	[TypeInferenceRuleAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	[NativeMethodAttribute] // RVA: 0xAC3E0 Offset: 0xAB7E0 VA: 0x1800AC3E0
	private Object LoadAsset_Internal(string name, Type type) { }

	public AssetBundleRequest LoadAssetAsync(string name) { }

	public AssetBundleRequest LoadAssetAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A367C0 Offset: 0x1A34DC0 VA: 0x181A367C0
	|-AssetBundle.LoadAssetAsync<object>
	|-AssetBundle.LoadAssetAsync<Sprite>
	|-AssetBundle.LoadAssetAsync<TextAsset>
	|-AssetBundle.LoadAssetAsync<Texture2D>
	*/

	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A365F0 Offset: 0x1A34BF0 VA: 0x181A365F0
	|-AssetBundle.ConvertObjects<object>
	*/

	public T[] LoadAllAssets<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36720 Offset: 0x1A34D20 VA: 0x181A36720
	|-AssetBundle.LoadAllAssets<AssetBundleManifest>
	|-AssetBundle.LoadAllAssets<object>
	*/

	public Object[] LoadAllAssets(Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC5B0 Offset: 0xAB9B0 VA: 0x1800AC5B0
	[NativeMethodAttribute] // RVA: 0xAC5B0 Offset: 0xAB9B0 VA: 0x1800AC5B0
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethodAttribute] // RVA: 0xAC7B0 Offset: 0xABBB0 VA: 0x1800AC7B0
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethodAttribute] // RVA: 0xAC900 Offset: 0xABD00 VA: 0x1800AC900
	public string[] GetAllAssetNames() { }

	[NativeThrowsAttribute] // RVA: 0xACAB0 Offset: 0xABEB0 VA: 0x1800ACAB0
	[NativeMethodAttribute] // RVA: 0xACAB0 Offset: 0xABEB0 VA: 0x1800ACAB0
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

}

public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 3993
{	public AssetBundle assetBundle { get; }


	[NativeMethodAttribute] // RVA: 0xACCC0 Offset: 0xAC0C0 VA: 0x1800ACCC0
	public AssetBundle get_assetBundle() { }

	public void .ctor() { }

}

public class AssetBundleManifest : Object // TypeDefIndex: 3994
{
	[NativeMethodAttribute] // RVA: 0xACED0 Offset: 0xAC2D0 VA: 0x1800ACED0
	public string[] GetAllAssetBundles() { }

}

public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
{
[NativeHeaderAttribute] // RVA: 0xAD140 Offset: 0xAC540 VA: 0x1800AD140
[RequiredByNativeCodeAttribute] // RVA: 0xAD140 Offset: 0xAC540 VA: 0x1800AD140
public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
	public Object asset { get; }


	[NativeMethodAttribute] // RVA: 0xAE510 Offset: 0xAD910 VA: 0x1800AE510
	public Object get_asset() { }

	public void .ctor() { }

}

public static class AssetPool // TypeDefIndex: 6562
{	public static Dictionary<Type, AssetPool.Pool> storage; // 0x34DF


	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9FE0 Offset: 0x5C85E0 VA: 0x1805C9FE0
	|-AssetPool.Get<Mesh>
	|-AssetPool.Get<object>
	*/

	public static void Free(ref Mesh mesh) { }

	private static AssetPool.Pool GetPool<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D020 Offset: 0x125B620 VA: 0x18125D020
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
	|-RVA: 0x5D3960 Offset: 0x5D1F60 VA: 0x1805D3960
	|-AssetPool.Pool.Pop<object>
	*/

	public void Push<T>(ref T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579BD0 Offset: 0x15781D0 VA: 0x181579BD0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <LoadProgress>k__BackingField; // 0x50

	public static bool Enabled { get; }
	public float LoadProgress { get; set; }


	public static bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_LoadProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_LoadProgress(float value) { }

	public void Load(string assetRoot) { }

	private AssetBundle LoadBundle(string bundleName) { }

	public void BuildFileIndex() { }

	public void Dispose() { }

	public override List<string> UnloadBundles(string partialName) { }

	protected override T LoadAsset<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9F40 Offset: 0x5C8540 VA: 0x1805C9F40
	|-AssetBundleBackend.LoadAsset<object>
	*/

	protected override LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority) { }

	protected override string[] LoadAssetList(string folder, string search) { }

	public override T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36360 Offset: 0x1A34960 VA: 0x181A36360
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
	[TupleElementNamesAttribute] // RVA: 0xC0930 Offset: 0xBFD30 VA: 0x1800C0930
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
	[TupleElementNamesAttribute] // RVA: 0xC0D00 Offset: 0xC0100 VA: 0x1800C0D00
	public IReadOnlyList<ValueTuple<string, Object>> Results { get; }
	public override bool keepWaiting { get; }


	internal void .ctor(FileSystemBackend backend, LoadAssetsResult load, List<ValueTuple<string, Object>> loaded) { }

	public int get_TotalCount() { }

	public int get_CompletedCount() { }

	public IReadOnlyList<ValueTuple<string, Object>> get_Results() { }

	public override bool get_keepWaiting() { }

	private void OnAssetLoaded(string path, Object obj) { }

}

public static class AssetNameCache // TypeDefIndex: 10716
{	private static Dictionary<Object, string> mixed; // 0x0
	private static Dictionary<Object, string> lower; // 0x8
	private static Dictionary<Object, string> upper; // 0x10


	private static string LookupName(Object obj) { }

	private static string LookupNameLower(Object obj) { }

	private static string LookupNameUpper(Object obj) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string GetName(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string GetNameLower(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string GetNameUpper(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string GetName(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string GetNameLower(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string GetNameUpper(Material mat) { }

	private static void .cctor() { }

}

public static class AssetStorage // TypeDefIndex: 11366
{
	public static void Save<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568D10 Offset: 0x1567310 VA: 0x181568D10
	|-AssetStorage.Save<object>
	*/

	public static void Save(ref Texture2D asset) { }

	public static void Save(ref Texture2D asset, string path, bool linear, bool compress) { }

	public static void Load<T>(ref T asset, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-AssetStorage.Load<object>
	*/

	public static void Delete<T>(ref T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568C70 Offset: 0x1567270 VA: 0x181568C70
	|-AssetStorage.Delete<object>
	*/

}

