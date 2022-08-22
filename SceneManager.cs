public class SceneManager // TypeDefIndex: 3656
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static UnityAction<Scene> sceneUnloaded; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x10

	// Properties
	public static int sceneCount { get; }

	// Methods

	[NativeHeaderAttribute] // RVA: 0xE5E10 Offset: 0xE5210 VA: 0x1800E5E10
	[NativeMethodAttribute] // RVA: 0xE5E10 Offset: 0xE5210 VA: 0x1800E5E10
	[StaticAccessorAttribute] // RVA: 0xE5E10 Offset: 0xE5210 VA: 0x1800E5E10
	// RVA: 0x19B4460 Offset: 0x19B2A60 VA: 0x1819B4460
	public static int get_sceneCount() { }

	[StaticAccessorAttribute] // RVA: 0xE5F70 Offset: 0xE5370 VA: 0x1800E5F70
	// RVA: 0x19B3CB0 Offset: 0x19B22B0 VA: 0x1819B3CB0
	public static Scene GetActiveScene() { }

	[StaticAccessorAttribute] // RVA: 0xE5F70 Offset: 0xE5370 VA: 0x1800E5F70
	// RVA: 0x19B3DD0 Offset: 0x19B23D0 VA: 0x1819B3DD0
	public static Scene GetSceneByName(string name) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19B3D30 Offset: 0x19B2330 VA: 0x1819B3D30
	public static Scene GetSceneAt(int index) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19B3C20 Offset: 0x19B2220 VA: 0x1819B3C20
	public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19B4330 Offset: 0x19B2930 VA: 0x1819B4330
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	[StaticAccessorAttribute] // RVA: 0xE6610 Offset: 0xE5A10 VA: 0x1800E6610
	[NativeThrowsAttribute] // RVA: 0xE6610 Offset: 0xE5A10 VA: 0x1800E6610
	// RVA: 0x19B3FB0 Offset: 0x19B25B0 VA: 0x1819B3FB0
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19B42B0 Offset: 0x19B28B0 VA: 0x1819B42B0
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B43B0 Offset: 0x19B29B0 VA: 0x1819B43B0
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B4490 Offset: 0x19B2A90 VA: 0x1819B4490
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	// RVA: 0x19B3BD0 Offset: 0x19B21D0 VA: 0x1819B3BD0
	public static Scene CreateScene(string sceneName) { }

	// RVA: 0x19B41B0 Offset: 0x19B27B0 VA: 0x1819B41B0
	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x19B4110 Offset: 0x19B2710 VA: 0x1819B4110
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19B40B0 Offset: 0x19B26B0 VA: 0x1819B40B0
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B4010 Offset: 0x19B2610 VA: 0x1819B4010
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	// RVA: 0x19B4060 Offset: 0x19B2660 VA: 0x1819B4060
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19B4370 Offset: 0x19B2970 VA: 0x1819B4370
	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B3E80 Offset: 0x19B2480 VA: 0x1819B3E80
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B3EE0 Offset: 0x19B24E0 VA: 0x1819B3EE0
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B3E20 Offset: 0x19B2420 VA: 0x1819B3E20
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x19B3C70 Offset: 0x19B2270 VA: 0x1819B3C70
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x19B3D80 Offset: 0x19B2380 VA: 0x1819B3D80
	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	// RVA: 0x19B3CF0 Offset: 0x19B22F0 VA: 0x1819B3CF0
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	// RVA: 0x19B3B70 Offset: 0x19B2170 VA: 0x1819B3B70
	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	// RVA: 0x19B42F0 Offset: 0x19B28F0 VA: 0x1819B42F0
	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x19B3F40 Offset: 0x19B2540 VA: 0x1819B3F40
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x19B4260 Offset: 0x19B2860 VA: 0x1819B4260
	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

}

