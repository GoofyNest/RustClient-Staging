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
	// RVA: 0x19B4720 Offset: 0x19B2D20 VA: 0x1819B4720
	public static int get_sceneCount() { }

	[StaticAccessorAttribute] // RVA: 0xE5F70 Offset: 0xE5370 VA: 0x1800E5F70
	// RVA: 0x19B3F70 Offset: 0x19B2570 VA: 0x1819B3F70
	public static Scene GetActiveScene() { }

	[StaticAccessorAttribute] // RVA: 0xE5F70 Offset: 0xE5370 VA: 0x1800E5F70
	// RVA: 0x19B4090 Offset: 0x19B2690 VA: 0x1819B4090
	public static Scene GetSceneByName(string name) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19B3FF0 Offset: 0x19B25F0 VA: 0x1819B3FF0
	public static Scene GetSceneAt(int index) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19B3EE0 Offset: 0x19B24E0 VA: 0x1819B3EE0
	public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19B45F0 Offset: 0x19B2BF0 VA: 0x1819B45F0
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	[StaticAccessorAttribute] // RVA: 0xE6610 Offset: 0xE5A10 VA: 0x1800E6610
	[NativeThrowsAttribute] // RVA: 0xE6610 Offset: 0xE5A10 VA: 0x1800E6610
	// RVA: 0x19B4270 Offset: 0x19B2870 VA: 0x1819B4270
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19B4570 Offset: 0x19B2B70 VA: 0x1819B4570
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B4670 Offset: 0x19B2C70 VA: 0x1819B4670
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B4750 Offset: 0x19B2D50 VA: 0x1819B4750
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	// RVA: 0x19B3E90 Offset: 0x19B2490 VA: 0x1819B3E90
	public static Scene CreateScene(string sceneName) { }

	// RVA: 0x19B4470 Offset: 0x19B2A70 VA: 0x1819B4470
	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x19B43D0 Offset: 0x19B29D0 VA: 0x1819B43D0
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19B4370 Offset: 0x19B2970 VA: 0x1819B4370
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B42D0 Offset: 0x19B28D0 VA: 0x1819B42D0
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	// RVA: 0x19B4320 Offset: 0x19B2920 VA: 0x1819B4320
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19B4630 Offset: 0x19B2C30 VA: 0x1819B4630
	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B4140 Offset: 0x19B2740 VA: 0x1819B4140
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B41A0 Offset: 0x19B27A0 VA: 0x1819B41A0
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19B40E0 Offset: 0x19B26E0 VA: 0x1819B40E0
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x19B3F30 Offset: 0x19B2530 VA: 0x1819B3F30
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x19B4040 Offset: 0x19B2640 VA: 0x1819B4040
	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	// RVA: 0x19B3FB0 Offset: 0x19B25B0 VA: 0x1819B3FB0
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	// RVA: 0x19B3E30 Offset: 0x19B2430 VA: 0x1819B3E30
	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	// RVA: 0x19B45B0 Offset: 0x19B2BB0 VA: 0x1819B45B0
	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x19B4200 Offset: 0x19B2800 VA: 0x1819B4200
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x19B4520 Offset: 0x19B2B20 VA: 0x1819B4520
	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

}

