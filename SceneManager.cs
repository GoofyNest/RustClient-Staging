public class SceneManager // TypeDefIndex: 3656
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static UnityAction<Scene> sceneUnloaded; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x10

	public static int sceneCount { get; }


	[NativeHeaderAttribute] // RVA: 0xE5E10 Offset: 0xE5210 VA: 0x1800E5E10
	[NativeMethodAttribute] // RVA: 0xE5E10 Offset: 0xE5210 VA: 0x1800E5E10
	[StaticAccessorAttribute] // RVA: 0xE5E10 Offset: 0xE5210 VA: 0x1800E5E10
	public static int get_sceneCount() { }

	[StaticAccessorAttribute] // RVA: 0xE5F70 Offset: 0xE5370 VA: 0x1800E5F70
	public static Scene GetActiveScene() { }

	[StaticAccessorAttribute] // RVA: 0xE5F70 Offset: 0xE5370 VA: 0x1800E5F70
	public static Scene GetSceneByName(string name) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	public static Scene GetSceneAt(int index) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	[StaticAccessorAttribute] // RVA: 0xE6610 Offset: 0xE5A10 VA: 0x1800E6610
	[NativeThrowsAttribute] // RVA: 0xE6610 Offset: 0xE5A10 VA: 0x1800E6610
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	public static Scene CreateScene(string sceneName) { }

	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	private static void GetActiveScene_Injected(out Scene ret) { }

	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

}

