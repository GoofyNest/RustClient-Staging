public class SceneManager // TypeDefIndex: 3656
{	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private static UnityAction<Scene> sceneUnloaded; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x10

	public static int sceneCount { get; }


	[NativeMethodAttribute] // RVA: 0xE5E00 Offset: 0xE5200 VA: 0x1800E5E00
	[StaticAccessorAttribute] // RVA: 0xE5E00 Offset: 0xE5200 VA: 0x1800E5E00
	[NativeHeaderAttribute] // RVA: 0xE5E00 Offset: 0xE5200 VA: 0x1800E5E00
	public static int get_sceneCount() { }

	[StaticAccessorAttribute] // RVA: 0xE5F60 Offset: 0xE5360 VA: 0x1800E5F60
	public static Scene GetActiveScene() { }

	[StaticAccessorAttribute] // RVA: 0xE5F60 Offset: 0xE5360 VA: 0x1800E5F60
	public static Scene GetSceneByName(string name) { }

	[StaticAccessorAttribute] // RVA: 0xE6250 Offset: 0xE5650 VA: 0x1800E6250
	[NativeThrowsAttribute] // RVA: 0xE6250 Offset: 0xE5650 VA: 0x1800E6250
	public static Scene GetSceneAt(int index) { }

	[StaticAccessorAttribute] // RVA: 0xE6250 Offset: 0xE5650 VA: 0x1800E6250
	[NativeThrowsAttribute] // RVA: 0xE6250 Offset: 0xE5650 VA: 0x1800E6250
	public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) { }

	[NativeThrowsAttribute] // RVA: 0xE64C0 Offset: 0xE58C0 VA: 0x1800E64C0
	[StaticAccessorAttribute] // RVA: 0xE64C0 Offset: 0xE58C0 VA: 0x1800E64C0
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	[NativeThrowsAttribute] // RVA: 0xE64C0 Offset: 0xE58C0 VA: 0x1800E64C0
	[StaticAccessorAttribute] // RVA: 0xE64C0 Offset: 0xE58C0 VA: 0x1800E64C0
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[StaticAccessorAttribute] // RVA: 0xE6250 Offset: 0xE5650 VA: 0x1800E6250
	[NativeThrowsAttribute] // RVA: 0xE6250 Offset: 0xE5650 VA: 0x1800E6250
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	public static Scene CreateScene(string sceneName) { }

	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	private static void GetActiveScene_Injected(out Scene ret) { }

	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

}

