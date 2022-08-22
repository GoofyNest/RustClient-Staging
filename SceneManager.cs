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
	// RVA: 0x19A1B20 Offset: 0x19A0120 VA: 0x1819A1B20
	public static int get_sceneCount() { }

	[StaticAccessorAttribute] // RVA: 0xE5F70 Offset: 0xE5370 VA: 0x1800E5F70
	// RVA: 0x19A1370 Offset: 0x199F970 VA: 0x1819A1370
	public static Scene GetActiveScene() { }

	[StaticAccessorAttribute] // RVA: 0xE5F70 Offset: 0xE5370 VA: 0x1800E5F70
	// RVA: 0x19A1490 Offset: 0x199FA90 VA: 0x1819A1490
	public static Scene GetSceneByName(string name) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19A13F0 Offset: 0x199F9F0 VA: 0x1819A13F0
	public static Scene GetSceneAt(int index) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19A12E0 Offset: 0x199F8E0 VA: 0x1819A12E0
	public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19A19F0 Offset: 0x199FFF0 VA: 0x1819A19F0
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	[StaticAccessorAttribute] // RVA: 0xE6610 Offset: 0xE5A10 VA: 0x1800E6610
	[NativeThrowsAttribute] // RVA: 0xE6610 Offset: 0xE5A10 VA: 0x1800E6610
	// RVA: 0x19A1670 Offset: 0x199FC70 VA: 0x1819A1670
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrowsAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	[StaticAccessorAttribute] // RVA: 0xE6260 Offset: 0xE5660 VA: 0x1800E6260
	// RVA: 0x19A1970 Offset: 0x199FF70 VA: 0x1819A1970
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A1A70 Offset: 0x19A0070 VA: 0x1819A1A70
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A1B50 Offset: 0x19A0150 VA: 0x1819A1B50
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	// RVA: 0x19A1290 Offset: 0x199F890 VA: 0x1819A1290
	public static Scene CreateScene(string sceneName) { }

	// RVA: 0x19A1870 Offset: 0x199FE70 VA: 0x1819A1870
	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x19A17D0 Offset: 0x199FDD0 VA: 0x1819A17D0
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19A1770 Offset: 0x199FD70 VA: 0x1819A1770
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A16D0 Offset: 0x199FCD0 VA: 0x1819A16D0
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	// RVA: 0x19A1720 Offset: 0x199FD20 VA: 0x1819A1720
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x19A1A30 Offset: 0x19A0030 VA: 0x1819A1A30
	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A1540 Offset: 0x199FB40 VA: 0x1819A1540
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A15A0 Offset: 0x199FBA0 VA: 0x1819A15A0
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A14E0 Offset: 0x199FAE0 VA: 0x1819A14E0
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x19A1330 Offset: 0x199F930 VA: 0x1819A1330
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x19A1440 Offset: 0x199FA40 VA: 0x1819A1440
	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	// RVA: 0x19A13B0 Offset: 0x199F9B0 VA: 0x1819A13B0
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	// RVA: 0x19A1230 Offset: 0x199F830 VA: 0x1819A1230
	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) { }

	// RVA: 0x19A19B0 Offset: 0x199FFB0 VA: 0x1819A19B0
	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x19A1600 Offset: 0x199FC00 VA: 0x1819A1600
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x19A1920 Offset: 0x199FF20 VA: 0x1819A1920
	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }

}

