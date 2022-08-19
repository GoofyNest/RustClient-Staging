internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 3260

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 3261

// Namespace: 
internal class <Module> // TypeDefIndex: 3262

// Namespace: UnityEngine
[VisibleToOtherModulesAttribute] // RVA: 0xDA100 Offset: 0xD9500 VA: 0x1800DA100
[AttributeUsageAttribute] // RVA: 0xDA100 Offset: 0xD9500 VA: 0x1800DA100
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 3263
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0x7ED280 Offset: 0x7EB880 VA: 0x1807ED280
	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

public class AssetBundle : Object // TypeDefIndex: 3992
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[ExcludeFromPresetAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
[NativeHeaderAttribute] // RVA: 0xABA70 Offset: 0xAAE70 VA: 0x1800ABA70
public class AssetBundle : Object // TypeDefIndex: 3992
	// Methods

	// RVA: 0x231FF80 Offset: 0x231E580 VA: 0x18231FF80
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xAC030 Offset: 0xAB430 VA: 0x1800AC030
	// RVA: 0x231FE10 Offset: 0x231E410 VA: 0x18231FE10
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x231FE60 Offset: 0x231E460 VA: 0x18231FE60
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	[FreeFunctionAttribute] // RVA: 0xAC0B0 Offset: 0xAB4B0 VA: 0x1800AC0B0
	// RVA: 0x231FEA0 Offset: 0x231E4A0 VA: 0x18231FEA0
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x231FEF0 Offset: 0x231E4F0 VA: 0x18231FEF0
	public static AssetBundle LoadFromFile(string path) { }

	[NativeMethodAttribute] // RVA: 0xAC1C0 Offset: 0xAB5C0 VA: 0x1800AC1C0
	// RVA: 0x231F810 Offset: 0x231DE10 VA: 0x18231F810
	public bool Contains(string name) { }

	// RVA: -1 Offset: -1
	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E3D0 Offset: 0x159C9D0 VA: 0x18159E3D0
	|-AssetBundle.LoadAsset<WorkshopSkinBase>
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xAC2A0 Offset: 0xAB6A0 VA: 0x1800AC2A0
	// RVA: 0x231FCF0 Offset: 0x231E2F0 VA: 0x18231FCF0
	public Object LoadAsset(string name, Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC340 Offset: 0xAB740 VA: 0x1800AC340
	[TypeInferenceRuleAttribute] // RVA: 0xAC340 Offset: 0xAB740 VA: 0x1800AC340
	[NativeMethodAttribute] // RVA: 0xAC340 Offset: 0xAB740 VA: 0x1800AC340
	// RVA: 0x231FC90 Offset: 0x231E290 VA: 0x18231FC90
	private Object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x231FAD0 Offset: 0x231E0D0 VA: 0x18231FAD0
	public AssetBundleRequest LoadAssetAsync(string name) { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAssetAsync<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36D20 Offset: 0x1A35320 VA: 0x181A36D20
	|-AssetBundle.LoadAssetAsync<object>
	|-AssetBundle.LoadAssetAsync<Sprite>
	|-AssetBundle.LoadAssetAsync<TextAsset>
	|-AssetBundle.LoadAssetAsync<Texture2D>
	*/

	// RVA: 0x231F9B0 Offset: 0x231DFB0 VA: 0x18231F9B0
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36B50 Offset: 0x1A35150 VA: 0x181A36B50
	|-AssetBundle.ConvertObjects<object>
	*/

	// RVA: -1 Offset: -1
	public T[] LoadAllAssets<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36C80 Offset: 0x1A35280 VA: 0x181A36C80
	|-AssetBundle.LoadAllAssets<AssetBundleManifest>
	|-AssetBundle.LoadAllAssets<object>
	*/

	// RVA: 0x231F8A0 Offset: 0x231DEA0 VA: 0x18231F8A0
	public Object[] LoadAllAssets(Type type) { }

	[NativeThrowsAttribute] // RVA: 0xAC510 Offset: 0xAB910 VA: 0x1800AC510
	[NativeMethodAttribute] // RVA: 0xAC510 Offset: 0xAB910 VA: 0x1800AC510
	// RVA: 0x231F950 Offset: 0x231DF50 VA: 0x18231F950
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethodAttribute] // RVA: 0xAC770 Offset: 0xABB70 VA: 0x1800AC770
	// RVA: 0x231FF30 Offset: 0x231E530 VA: 0x18231FF30
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeMethodAttribute] // RVA: 0xAC860 Offset: 0xABC60 VA: 0x1800AC860
	// RVA: 0x231F860 Offset: 0x231DE60 VA: 0x18231F860
	public string[] GetAllAssetNames() { }

	[NativeThrowsAttribute] // RVA: 0xACA10 Offset: 0xABE10 VA: 0x1800ACA10
	[NativeMethodAttribute] // RVA: 0xACA10 Offset: 0xABE10 VA: 0x1800ACA10
	// RVA: 0x231FC30 Offset: 0x231E230 VA: 0x18231FC30
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

}

public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 3993
{	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xACC20 Offset: 0xAC020 VA: 0x1800ACC20
	// RVA: 0x231F750 Offset: 0x231DD50 VA: 0x18231F750
	public AssetBundle get_assetBundle() { }

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
	public void .ctor() { }

}

public class AssetBundleManifest : Object // TypeDefIndex: 3994
{	// Methods

	[NativeMethodAttribute] // RVA: 0xACE60 Offset: 0xAC260 VA: 0x1800ACE60
	// RVA: 0x231F790 Offset: 0x231DD90 VA: 0x18231F790
	public string[] GetAllAssetBundles() { }

}

public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xAD0A0 Offset: 0xAC4A0 VA: 0x1800AD0A0
[RequiredByNativeCodeAttribute] // RVA: 0xAD0A0 Offset: 0xAC4A0 VA: 0x1800AD0A0
public class AssetBundleRequest : AsyncOperation // TypeDefIndex: 3996
	// Properties
	public Object asset { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xAE470 Offset: 0xAD870 VA: 0x1800AE470
	// RVA: 0x231F7D0 Offset: 0x231DDD0 VA: 0x18231F7D0
	public Object get_asset() { }

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
	public void .ctor() { }

}

public static class AssetPool // TypeDefIndex: 6562
{	// Fields
	public static Dictionary<Type, AssetPool.Pool> storage; // 0x2B11378

	// Methods

	// RVA: -1 Offset: -1
	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9F80 Offset: 0x5C8580 VA: 0x1805C9F80
	|-AssetPool.Get<Mesh>
	|-AssetPool.Get<object>
	*/

	// RVA: 0x1B9D9F0 Offset: 0x1B9BFF0 VA: 0x181B9D9F0
	public static void Free(ref Mesh mesh) { }

	// RVA: -1 Offset: -1
	private static AssetPool.Pool GetPool<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C5C0 Offset: 0x125ABC0 VA: 0x18125C5C0
	|-AssetPool.GetPool<object>
	|-AssetPool.GetPool<Mesh>
	*/

	// RVA: 0x1B9D890 Offset: 0x1B9BE90 VA: 0x181B9D890
	public static void Clear() { }

	// RVA: 0x1B9DA70 Offset: 0x1B9C070 VA: 0x181B9DA70
	private static void .cctor() { }

}

public class AssetPool.Pool // TypeDefIndex: 6563
{	// Fields
	public Stack<Object> stack; // 0x10
	public int allocated; // 0x18
	public int available; // 0x1C
	public string name; // 0x20

	// Methods

	// RVA: 0x1BA9520 Offset: 0x1BA7B20 VA: 0x181BA9520
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

	// RVA: 0x1BA93C0 Offset: 0x1BA79C0 VA: 0x181BA93C0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <LoadProgress>k__BackingField; // 0x50

	// Properties
	public static bool Enabled { get; }
	public float LoadProgress { get; set; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public static bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x684AC0 Offset: 0x6830C0 VA: 0x180684AC0
	public float get_LoadProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22BBE60 Offset: 0x22BA460 VA: 0x1822BBE60
	private void set_LoadProgress(float value) { }

	// RVA: 0x22BB6D0 Offset: 0x22B9CD0 VA: 0x1822BB6D0
	public void Load(string assetRoot) { }

	// RVA: 0x22BB570 Offset: 0x22B9B70 VA: 0x1822BB570
	private AssetBundle LoadBundle(string bundleName) { }

	// RVA: 0x22BAC70 Offset: 0x22B9270 VA: 0x1822BAC70
	public void BuildFileIndex() { }

	// RVA: 0x22BAE60 Offset: 0x22B9460 VA: 0x1822BAE60 Slot: 9
	public void Dispose() { }

	// RVA: 0x22BB960 Offset: 0x22B9F60 VA: 0x1822BB960 Slot: 4
	public override List<string> UnloadBundles(string partialName) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected override T LoadAsset<T>(string filePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9EE0 Offset: 0x5C84E0 VA: 0x1805C9EE0
	|-AssetBundleBackend.LoadAsset<object>
	*/

	// RVA: 0x22BB3F0 Offset: 0x22B99F0 VA: 0x1822BB3F0 Slot: 6
	protected override LoadAssetsResult LoadAssetsAsync(List<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22BB070 Offset: 0x22B9670 VA: 0x1822BB070 Slot: 7
	protected override string[] LoadAssetList(string folder, string search) { }

	// RVA: -1 Offset: -1 Slot: 8
	public override T[] LoadAllFromBundle<T>(string bundleName, string editorSearch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A368C0 Offset: 0x1A34EC0 VA: 0x181A368C0
	|-AssetBundleBackend.LoadAllFromBundle<object>
	*/

	// RVA: 0x22BBC20 Offset: 0x22BA220 VA: 0x1822BBC20
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

	// RVA: 0x22BE130 Offset: 0x22BC730 VA: 0x1822BE130
	internal bool <LoadAssetsAsync>b__0(string p) { }

	// RVA: 0x22BE190 Offset: 0x22BC790 VA: 0x1822BE190
	internal AssetBundle <LoadAssetsAsync>b__1(string p) { }

	// RVA: 0x22BE1F0 Offset: 0x22BC7F0 VA: 0x1822BE1F0
	internal LoadAssetsResult <LoadAssetsAsync>b__2(IGrouping<AssetBundle, string> g) { }

}

private sealed class AssetBundleBackend.<>c // TypeDefIndex: 6653
{	// Fields
	public static readonly AssetBundleBackend.<>c <>9; // 0x0
	public static Func<string, string> <>9__17_3; // 0x8

	// Methods

	// RVA: 0x22BE4B0 Offset: 0x22BCAB0 VA: 0x1822BE4B0
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

	// RVA: 0x22BE450 Offset: 0x22BCA50 VA: 0x1822BE450
	internal bool <LoadAssetList>b__0(KeyValuePair<string, AssetBundle> x) { }

}

internal class AssetBundleLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6655
{	// Fields
	private readonly AssetBundle _bundle; // 0x20
	private readonly List<string> _filePaths; // 0x28
	private readonly int _maxConcurrency; // 0x30
	private readonly int _priority; // 0x34
	private readonly List<AssetBundleRequest> _requests; // 0x38
	[TupleElementNamesAttribute] // RVA: 0xC0810 Offset: 0xBFC10 VA: 0x1800C0810
	private readonly List<ValueTuple<string, AssetBundleRequest>> _pendingRequests; // 0x40
	private int _index; // 0x48

	// Properties
	public override int TotalCount { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22BC7A0 Offset: 0x22BADA0 VA: 0x1822BC7A0 Slot: 8
	public override int get_TotalCount() { }

	// RVA: 0x22BC4A0 Offset: 0x22BAAA0 VA: 0x1822BC4A0
	internal void .ctor(AssetBundle bundle, List<string> filePaths, int maxConcurrency, int priority) { }

	// RVA: 0x22BC7E0 Offset: 0x22BADE0 VA: 0x1822BC7E0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22BBFF0 Offset: 0x22BA5F0 VA: 0x1822BBFF0
	private bool Update() { }

	// RVA: 0x22BBE70 Offset: 0x22BA470 VA: 0x1822BBE70 Slot: 11
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
	[TupleElementNamesAttribute] // RVA: 0xC0C20 Offset: 0xC0020 VA: 0x1800C0C20
	public IReadOnlyList<ValueTuple<string, Object>> Results { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22BC980 Offset: 0x22BAF80 VA: 0x1822BC980
	internal void .ctor(FileSystemBackend backend, LoadAssetsResult load, List<ValueTuple<string, Object>> loaded) { }

	// RVA: 0x22BCB80 Offset: 0x22BB180 VA: 0x1822BCB80
	public int get_TotalCount() { }

	// RVA: 0x22BCB50 Offset: 0x22BB150 VA: 0x1822BCB50
	public int get_CompletedCount() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IReadOnlyList<ValueTuple<string, Object>> get_Results() { }

	// RVA: 0x13D2870 Offset: 0x13D0E70 VA: 0x1813D2870 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22BC800 Offset: 0x22BAE00 VA: 0x1822BC800
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

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x830660 Offset: 0x82EC60 VA: 0x180830660
	public static string GetName(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8304E0 Offset: 0x82EAE0 VA: 0x1808304E0
	public static string GetNameLower(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8305A0 Offset: 0x82EBA0 VA: 0x1808305A0
	public static string GetNameUpper(PhysicMaterial mat) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8306C0 Offset: 0x82ECC0 VA: 0x1808306C0
	public static string GetName(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x830540 Offset: 0x82EB40 VA: 0x180830540
	public static string GetNameLower(Material mat) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

