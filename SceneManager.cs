public class SceneManager // TypeDefIndex: 3656
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static UnityAction<Scene> sceneUnloaded; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x10

	// Properties
	public static int sceneCount { get; }

	// Methods

	[NativeHeaderAttribute] // RVA: 0xE5D50 Offset: 0xE5150 VA: 0x1800E5D50
	[NativeMethodAttribute] // RVA: 0xE5D50 Offset: 0xE5150 VA: 0x1800E5D50
	[StaticAccessorAttribute] // RVA: 0xE5D50 Offset: 0xE5150 VA: 0x1800E5D50
	// RVA: 0x19B44A0 Offset: 0x19B2AA0 VA: 0x1819B44A0
	public static int get_sceneCount() { }

	[StaticAccessorAttribute] // RVA: 0xE5F20 Offset: 0xE5320 VA: 0x1800E5F20
	// RVA: 0x19B3CF0 Offset: 0x19B22F0 VA: 0x1819B3CF0
	public static Scene GetActiveScene() { }

	[StaticAccessorAttribute] // RVA: 0xE5F20 Offset: 0xE5320 VA: 0x1800E5F20
	// RVA: 0x19B3E10 Offset: 0x19B2410 VA: 0x1819B3E10
	public static Scene GetSceneByName(string name) { }

	[NativeThrowsAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	[StaticAccessorAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	// RVA: 0x19B3D70 Offset: 0x19B2370 VA: 0x1819B3D70
	public static Scene GetSceneAt(int index) { }

	[NativeThrowsAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	[StaticAccessorAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	// RVA: 0x19B3C60 Offset: 0x19B2260 VA: 0x1819B3C60
	public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) { }

	[NativeThrowsAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	[StaticAccessorAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	// RVA: 0x19B4370 Offset: 0x19B2970 VA: 0x1819B4370
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	[NativeThrowsAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	[StaticAccessorAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	// RVA: 0x19B3FF0 Offset: 0x19B25F0 VA: 0x1819B3FF0
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrowsAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	[StaticAccessorAttribute] // RVA: 0xE6210 Offset: 0xE5610 VA: 0x1800E6210
	// RVA: 0x19B42F0 Offset: 0x19B28F0 VA: 0x1819B42F0
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B43F0 Offset: 0x19B29F0 VA: 0x1819B43F0
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B44D0 Offset: 0x19B2AD0 VA: 0x1819B44D0
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	// RVA: 0x19B3C10 Offset: 0x19B2210 VA: 0x1819B3C10
	public static Scene CreateScene(string sceneName) { }

	// RVA: 0x19B41F0 Offset: 0x19B27F0 VA: 0x1819B41F0
	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x19B4150 Offset: 0x19B2750 VA: 0x1819B4150
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19B40F0 Offset: 0x19B26F0 VA: 0x1819B40F0
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B4050 Offset: 0x19B2650 VA: 0x1819B4050
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	// RVA: 0x19B40A0 Offset: 0x19B26A0 VA: 0x1819B40A0
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19B43B0 Offset: 0x19B29B0 VA: 0x1819B43B0
	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B3EC0 Offset: 0x19B24C0 VA: 0x1819B3EC0
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B3F20 Offset: 0x19B2520 VA: 0x1819B3F20
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19B3E60 Offset: 0x19B2460 VA: 0x1819B3E60
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x19B3CB0 Offset: 0x19B22B0 VA: 0x1819B3CB0
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x19B3DC0 Offset: 0x19B23C0 VA: 0x1819B3DC0
	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	// RVA: 0x19B3D30 Offset: 0x19B2330 VA: 0x1819B3D30
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	// RVA: 0x19B3BB0 Offset: 0x19B21B0 VA: 0x1819B3BB0
	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	// RVA: 0x19B4330 Offset: 0x19B2930 VA: 0x1819B4330
	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x19B3F80 Offset: 0x19B2580 VA: 0x1819B3F80
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x19B42A0 Offset: 0x19B28A0 VA: 0x1819B42A0
	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

}

