public class OcclusionCulling : MonoBehaviour // TypeDefIndex: 11513
{	// Fields
	public OcclusionCulling.DebugSettings debugSettings; // 0x18
	private Material debugMipMat; // 0x20
	private const float debugDrawDuration = 0,0334;
	private Material downscaleMat; // 0x28
	private Material blitCopyMat; // 0x30
	private int hiZLevelCount; // 0x38
	private int hiZWidth; // 0x3C
	private int hiZHeight; // 0x40
	private RenderTexture depthTexture; // 0x48
	private RenderTexture hiZTexture; // 0x50
	private RenderTexture[] hiZLevels; // 0x58
	private const int GridCellsPerAxis = 2097152;
	private const int GridHalfCellsPerAxis = 1048576;
	private const int GridMinHalfCellsPerAxis = -1048575;
	private const int GridMaxHalfCellsPerAxis = 1048575;
	private const float GridCellSize = 100;
	private const float GridHalfCellSize = 50;
	private const float GridRcpCellSize = 0,01;
	private const int GridPoolCapacity = 16384;
	private const int GridPoolGranularity = 4096;
	private static OcclusionCulling.HashedPool<OcclusionCulling.Cell> grid; // 0x0
	private static Queue<OcclusionCulling.Cell> gridChanged; // 0x8
	public ComputeShader computeShader; // 0x60
	public bool usePixelShaderFallback; // 0x68
	public bool useAsyncReadAPI; // 0x69
	private Camera camera; // 0x70
	private const int ComputeThreadsPerGroup = 64;
	private const int InputBufferStride = 16;
	private const int ResultBufferStride = 4;
	private const int OccludeeMaxSlotsPerPool = 1048576;
	private const int OccludeePoolGranularity = 2048;
	private const int StateBufferGranularity = 2048;
	private const int GridBufferGranularity = 256;
	private static Queue<OccludeeState> statePool; // 0x10
	private static OcclusionCulling.SimpleList<OccludeeState> staticOccludees; // 0x18
	private static OcclusionCulling.SimpleList<OccludeeState.State> staticStates; // 0x20
	private static OcclusionCulling.SimpleList<int> staticVisibilityChanged; // 0x28
	private static OcclusionCulling.SimpleList<OccludeeState> dynamicOccludees; // 0x30
	private static OcclusionCulling.SimpleList<OccludeeState.State> dynamicStates; // 0x38
	private static OcclusionCulling.SimpleList<int> dynamicVisibilityChanged; // 0x40
	private static List<int> staticChanged; // 0x48
	private static Queue<int> staticRecycled; // 0x50
	private static List<int> dynamicChanged; // 0x58
	private static Queue<int> dynamicRecycled; // 0x60
	private static OcclusionCulling.BufferSet staticSet; // 0x68
	private static OcclusionCulling.BufferSet dynamicSet; // 0x70
	private static OcclusionCulling.BufferSet gridSet; // 0x78
	private Vector4[] frustumPlanes; // 0x78
	private string[] frustumPropNames; // 0x80
	private float[] matrixToFloatTemp; // 0x88
	private Material fallbackMat; // 0x90
	private Material depthCopyMat; // 0x98
	private Matrix4x4 viewMatrix; // 0xA0
	private Matrix4x4 projMatrix; // 0xE0
	private Matrix4x4 viewProjMatrix; // 0x120
	private Matrix4x4 prevViewProjMatrix; // 0x160
	private Matrix4x4 invViewProjMatrix; // 0x1A0
	private bool useNativePath; // 0x1E0
	private static OcclusionCulling instance; // 0x80
	private static GraphicsDeviceType[] supportedDeviceTypes; // 0x88
	private static bool _enabled; // 0x90
	private static bool _safeMode; // 0x91
	private static OcclusionCulling.DebugFilter _debugShow; // 0x94

	// Properties
	public bool HiZReady { get; }
	public static OcclusionCulling Instance { get; }
	public static bool Supported { get; }
	public static bool Enabled { get; set; }
	public static bool SafeMode { get; set; }
	public static OcclusionCulling.DebugFilter DebugShow { get; set; }

	// Methods

	// RVA: 0x4BCC40 Offset: 0x4BB240 VA: 0x1804BCC40
	public static bool DebugFilterIsDynamic(int filter) { }

	// RVA: 0x9DD220 Offset: 0x9DB820 VA: 0x1809DD220
	public static bool DebugFilterIsStatic(int filter) { }

	// RVA: 0x9DD210 Offset: 0x9DB810 VA: 0x1809DD210
	public static bool DebugFilterIsGrid(int filter) { }

	// RVA: 0x9DD230 Offset: 0x9DB830 VA: 0x1809DD230
	private void DebugInitialize() { }

	// RVA: 0x9DD2D0 Offset: 0x9DB8D0 VA: 0x1809DD2D0
	private void DebugShutdown() { }

	// RVA: 0x9DD380 Offset: 0x9DB980 VA: 0x1809DD380
	private void DebugUpdate() { }

	// RVA: 0x9DC2C0 Offset: 0x9DA8C0 VA: 0x1809DC2C0
	private void DebugDraw() { }

	// RVA: 0x9DF130 Offset: 0x9DD730 VA: 0x1809DF130
	public static void NormalizePlane(ref Vector4 plane) { }

	// RVA: 0x9DD5E0 Offset: 0x9DBBE0 VA: 0x1809DD5E0
	public static void ExtractFrustum(Matrix4x4 viewProjMatrix, ref Vector4[] planes) { }

	// RVA: 0x9E4850 Offset: 0x9E2E50 VA: 0x1809E4850
	public bool get_HiZReady() { }

	// RVA: 0x9DB8C0 Offset: 0x9D9EC0 VA: 0x1809DB8C0
	public void CheckResizeHiZMap() { }

	// RVA: 0x9DEB90 Offset: 0x9DD190 VA: 0x1809DEB90
	private void InitializeHiZMap() { }

	// RVA: 0x9DDEA0 Offset: 0x9DC4A0 VA: 0x1809DDEA0
	private void FinalizeHiZMap() { }

	// RVA: 0x9DE8D0 Offset: 0x9DCED0 VA: 0x1809DE8D0
	private void InitializeHiZMap(int width, int height) { }

	// RVA: 0x9DD420 Offset: 0x9DBA20 VA: 0x1809DD420
	private void DestroyHiZMap() { }

	// RVA: 0x9DBC80 Offset: 0x9DA280 VA: 0x1809DBC80
	private RenderTexture CreateDepthTexture(string name, int width, int height, bool mips = False) { }

	// RVA: 0x9DBBA0 Offset: 0x9DA1A0 VA: 0x1809DBBA0
	private RenderTexture CreateDepthTextureMip(string name, int width, int height, int mip) { }

	// RVA: 0x9DE760 Offset: 0x9DCD60 VA: 0x1809DE760
	public void GrabDepthTexture() { }

	// RVA: 0x9DE1F0 Offset: 0x9DC7F0 VA: 0x1809DE1F0
	public void GenerateHiZMipChain() { }

	// RVA: 0x9DBD70 Offset: 0x9DA370 VA: 0x1809DBD70
	private void DebugDrawGizmos() { }

	// RVA: 0x9E4770 Offset: 0x9E2D70 VA: 0x1809E4770
	private static int floor(float x) { }

	// RVA: 0x9E1EB0 Offset: 0x9E04B0 VA: 0x1809E1EB0
	public static OcclusionCulling.Cell RegisterToGrid(OccludeeState occludee) { }

	// RVA: 0x9E3EC0 Offset: 0x9E24C0 VA: 0x1809E3EC0
	public static void UpdateInGrid(OccludeeState occludee) { }

	// RVA: 0x9E2E00 Offset: 0x9E1400 VA: 0x1809E2E00
	public static void UnregisterFromGrid(OccludeeState occludee) { }

	// RVA: 0x9E3AC0 Offset: 0x9E20C0 VA: 0x1809E3AC0
	public void UpdateGridBuffers() { }

	// RVA: 0x9E48D0 Offset: 0x9E2ED0 VA: 0x1809E48D0
	public static OcclusionCulling get_Instance() { }

	// RVA: 0x9E4990 Offset: 0x9E2F90 VA: 0x1809E4990
	public static bool get_Supported() { }

	// RVA: 0x9E47F0 Offset: 0x9E2DF0 VA: 0x1809E47F0
	public static bool get_Enabled() { }

	// RVA: 0x9E4A70 Offset: 0x9E3070 VA: 0x1809E4A70
	public static void set_Enabled(bool value) { }

	// RVA: 0x9E4930 Offset: 0x9E2F30 VA: 0x1809E4930
	public static bool get_SafeMode() { }

	// RVA: 0x9E4B70 Offset: 0x9E3170 VA: 0x1809E4B70
	public static void set_SafeMode(bool value) { }

	// RVA: 0x9E4790 Offset: 0x9E2D90 VA: 0x1809E4790
	public static OcclusionCulling.DebugFilter get_DebugShow() { }

	// RVA: 0x9E4A10 Offset: 0x9E3010 VA: 0x1809E4A10
	public static void set_DebugShow(OcclusionCulling.DebugFilter value) { }

	// RVA: 0x9DE810 Offset: 0x9DCE10 VA: 0x1809DE810
	private static void GrowStatePool() { }

	// RVA: 0x9DA490 Offset: 0x9D8A90 VA: 0x1809DA490
	private static OccludeeState Allocate() { }

	// RVA: 0x9E24E0 Offset: 0x9E0AE0 VA: 0x1809E24E0
	private static void Release(OccludeeState state) { }

	// RVA: 0x9DB780 Offset: 0x9D9D80 VA: 0x1809DB780
	private void Awake() { }

	// RVA: 0x9DF4E0 Offset: 0x9DDAE0 VA: 0x1809DF4E0
	private void OnEnable() { }

	// RVA: 0x9E2C40 Offset: 0x9E1240 VA: 0x1809E2C40
	private bool SupportsNativePath() { }

	// RVA: 0x9DF210 Offset: 0x9DD810 VA: 0x1809DF210
	private void OnDisable() { }

	// RVA: 0x9DEE50 Offset: 0x9DD450 VA: 0x1809DEE50
	public static void MakeAllVisible() { }

	// RVA: 0x9E4070 Offset: 0x9E2670 VA: 0x1809E4070
	private void Update() { }

	// RVA: -1 Offset: -1
	public static void RecursiveAddOccludees<T>(Transform transform, float minTimeVisible = 0,1, bool isStatic = True, bool stickyGizmos = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFEC30 Offset: 0xCFD230 VA: 0x180CFEC30
	|-OcclusionCulling.RecursiveAddOccludees<object>
	*/

	// RVA: 0x9DDFD0 Offset: 0x9DC5D0 VA: 0x1809DDFD0
	private static int FindFreeSlot(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled) { }

	// RVA: 0x9DE690 Offset: 0x9DCC90 VA: 0x1809DE690
	public static OccludeeState GetStateById(int id) { }

	// RVA: 0x9E1740 Offset: 0x9DFD40 VA: 0x1809E1740
	public static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	// RVA: 0x9E1910 Offset: 0x9DFF10 VA: 0x1809E1910
	private static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged, OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled, List<int> changed, OcclusionCulling.BufferSet set, OcclusionCulling.SimpleList<int> visibilityChanged) { }

	// RVA: 0x9E30F0 Offset: 0x9E16F0 VA: 0x1809E30F0
	public static void UnregisterOccludee(int id) { }

	// RVA: 0x9E31D0 Offset: 0x9E17D0 VA: 0x1809E31D0
	private static void UnregisterOccludee(int slot, OcclusionCulling.SimpleList<OccludeeState> occludees, Queue<int> recycled, List<int> changed) { }

	// RVA: 0x9E3970 Offset: 0x9E1F70 VA: 0x1809E3970
	public static void UpdateDynamicOccludee(int id, Vector3 center, float radius) { }

	// RVA: 0x9E33D0 Offset: 0x9E19D0 VA: 0x1809E33D0
	private void UpdateBuffers(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, List<int> changed, bool isStatic) { }

	// RVA: 0x9E3620 Offset: 0x9E1C20 VA: 0x1809E3620
	private void UpdateCameraMatrices(bool starting = False) { }

	// RVA: 0x9DFCE0 Offset: 0x9DE2E0 VA: 0x1809DFCE0
	private void OnPreCull() { }

	// RVA: 0x9DFB80 Offset: 0x9DE180 VA: 0x1809DFB80
	private void OnPostRender() { }

	// RVA: 0x9DF070 Offset: 0x9DD670 VA: 0x1809DF070
	private float[] MatrixToFloatArray(Matrix4x4 m) { }

	// RVA: 0x9E0040 Offset: 0x9DE640 VA: 0x1809E0040
	private void PrepareAndDispatch() { }

	// RVA: 0x9DEC90 Offset: 0x9DD290 VA: 0x1809DEC90
	private void IssueRead() { }

	// RVA: 0x9E2560 Offset: 0x9E0B60 VA: 0x1809E2560
	public void ResetTiming(OcclusionCulling.SmartList bucket) { }

	// RVA: 0x9E25F0 Offset: 0x9E0BF0 VA: 0x1809E25F0
	public void ResetTiming() { }

	// RVA: 0x9DE150 Offset: 0x9DC750 VA: 0x1809DE150
	private static bool FrustumCull(Vector4[] planes, Vector4 testSphere) { }

	// RVA: 0x9E1400 Offset: 0x9DFA00 VA: 0x1809E1400
	private static int ProcessOccludees_Safe(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SmartList bucket, Color32[] results, OcclusionCulling.SimpleList<int> changed, Vector4[] frustumPlanes, float time, uint frame) { }

	// RVA: 0x9E0F80 Offset: 0x9DF580 VA: 0x1809E0F80
	private static int ProcessOccludees_Fast(OccludeeState.State[] states, int[] bucket, int bucketCount, Color32[] results, int resultCount, int[] changed, ref int changedCount, Vector4[] frustumPlanes, float time, uint frame) { }

	// RVA: 0x9E1300 Offset: 0x9DF900 VA: 0x1809E1300
	private static extern int ProcessOccludees_Native(ref OccludeeState.State states, ref int bucket, int bucketCount, ref Color32 results, int resultCount, ref int changed, ref int changedCount, ref Vector4 frustumPlanes, float time, uint frame) { }

	// RVA: 0x9DB2B0 Offset: 0x9D98B0 VA: 0x1809DB2B0
	private void ApplyVisibility_Safe(float time, uint frame) { }

	// RVA: 0x9DA620 Offset: 0x9D8C20 VA: 0x1809DA620
	private void ApplyVisibility_Fast(float time, uint frame) { }

	// RVA: 0x9DABB0 Offset: 0x9D91B0 VA: 0x1809DABB0
	private void ApplyVisibility_Native(float time, uint frame) { }

	// RVA: 0x9E0D80 Offset: 0x9DF380 VA: 0x1809E0D80
	private void ProcessCallbacks(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SimpleList<int> changed) { }

	// RVA: 0x9E2700 Offset: 0x9E0D00 VA: 0x1809E2700
	public void RetrieveAndApplyVisibility() { }

	// RVA: 0x9E4680 Offset: 0x9E2C80 VA: 0x1809E4680
	public void .ctor() { }

	// RVA: 0x9E41E0 Offset: 0x9E27E0 VA: 0x1809E41E0
	private static void .cctor() { }

}

public class OcclusionCulling.BufferSet // TypeDefIndex: 11514
{	// Fields
	public ComputeBuffer inputBuffer; // 0x10
	public ComputeBuffer resultBuffer; // 0x18
	public int width; // 0x20
	public int height; // 0x24
	public int capacity; // 0x28
	public int count; // 0x2C
	public Texture2D inputTexture; // 0x30
	public RenderTexture resultTexture; // 0x38
	public Texture2D resultReadTexture; // 0x40
	public Color[] inputData; // 0x48
	public Color32[] resultData; // 0x50
	private OcclusionCulling culling; // 0x58
	private const int MaxAsyncGPUReadbackRequests = 10;
	private Queue<AsyncGPUReadbackRequest> asyncRequests; // 0x60
	public IntPtr readbackInst; // 0x68

	// Properties
	public bool Ready { get; }

	// Methods

	// RVA: 0x9D0B20 Offset: 0x9CF120 VA: 0x1809D0B20
	public bool get_Ready() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void Attach(OcclusionCulling culling) { }

	// RVA: 0x9D0350 Offset: 0x9CE950 VA: 0x1809D0350
	public void Dispose(bool data = True) { }

	// RVA: 0x9CFC80 Offset: 0x9CE280 VA: 0x1809CFC80
	public bool CheckResize(int count, int granularity) { }

	// RVA: 0x9D0A00 Offset: 0x9CF000 VA: 0x1809D0A00
	public void UploadData() { }

	// RVA: 0x9CFC70 Offset: 0x9CE270 VA: 0x1809CFC70
	private int AlignDispatchSize(int dispatchSize) { }

	// RVA: 0x9D0180 Offset: 0x9CE780 VA: 0x1809D0180
	public void Dispatch(int count) { }

	// RVA: 0x9D08B0 Offset: 0x9CEEB0 VA: 0x1809D08B0
	public void IssueRead() { }

	// RVA: 0x9D05C0 Offset: 0x9CEBC0 VA: 0x1809D05C0
	public void GetResults() { }

	// RVA: 0x9D0A70 Offset: 0x9CF070 VA: 0x1809D0A70
	public void .ctor() { }

}

public enum OcclusionCulling.DebugFilter // TypeDefIndex: 11515
{	// Fields
	public int value__; // 0x0
	public const OcclusionCulling.DebugFilter Off = 0;
	public const OcclusionCulling.DebugFilter Dynamic = 1;
	public const OcclusionCulling.DebugFilter Static = 2;
	public const OcclusionCulling.DebugFilter Grid = 3;
	public const OcclusionCulling.DebugFilter All = 4;

}

public enum OcclusionCulling.DebugMask // TypeDefIndex: 11516
{	// Fields
	public int value__; // 0x0
	public const OcclusionCulling.DebugMask Off = 0;
	public const OcclusionCulling.DebugMask Dynamic = 1;
	public const OcclusionCulling.DebugMask Static = 2;
	public const OcclusionCulling.DebugMask Grid = 4;
	public const OcclusionCulling.DebugMask All = 7;

}

public class OcclusionCulling.DebugSettings // TypeDefIndex: 11517
{	// Fields
	public bool log; // 0x10
	public bool showAllVisible; // 0x11
	public bool showMipChain; // 0x12
	public bool showMain; // 0x13
	public int showMainLod; // 0x14
	public bool showFallback; // 0x18
	public bool showStats; // 0x19
	public bool showScreenBounds; // 0x1A
	public OcclusionCulling.DebugMask showMask; // 0x1C
	public LayerMask layerFilter; // 0x20

	// Methods

	// RVA: 0x9D0DA0 Offset: 0x9CF3A0 VA: 0x1809D0DA0
	public void .ctor() { }

}

public class OcclusionCulling.HashedPoolValue // TypeDefIndex: 11518
{	// Fields
	public ulong hashedPoolKey; // 0x10
	public int hashedPoolIndex; // 0x18

	// Methods

	// RVA: 0x9D0D80 Offset: 0x9CF380 VA: 0x1809D0D80
	public void .ctor() { }

}

public class OcclusionCulling.HashedPool<ValueType> // TypeDefIndex: 11519
{	// Fields
	private int granularity; // 0x0
	private Dictionary<ulong, ValueType> dict; // 0x0
	private List<ValueType> pool; // 0x0
	private List<ValueType> list; // 0x0
	private Queue<ValueType> recycled; // 0x0

	// Properties
	public int Size { get; }
	public int Count { get; }
	public ValueType Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Size() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD57000 Offset: 0xD55600 VA: 0x180D57000
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Size
	|-OcclusionCulling.HashedPool<object>.get_Size
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56FA0 Offset: 0xD555A0 VA: 0x180D56FA0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Count
	|-OcclusionCulling.HashedPool<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public ValueType get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56FD0 Offset: 0xD555D0 VA: 0x180D56FD0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Item
	|-OcclusionCulling.HashedPool<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int i, ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD57030 Offset: 0xD55630 VA: 0x180D57030
	|-OcclusionCulling.HashedPool<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int granularity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56E00 Offset: 0xD55400 VA: 0x180D56E00
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>..ctor
	|-OcclusionCulling.HashedPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56C50 Offset: 0xD55250 VA: 0x180D56C50
	|-OcclusionCulling.HashedPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public ValueType Add(ulong key, int capacityGranularity = 16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56A60 Offset: 0xD55060 VA: 0x180D56A60
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Add
	|-OcclusionCulling.HashedPool<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56D20 Offset: 0xD55320 VA: 0x180D56D20
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Remove
	|-OcclusionCulling.HashedPool<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(ulong key, out ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56DD0 Offset: 0xD553D0 VA: 0x180D56DD0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.TryGetValue
	|-OcclusionCulling.HashedPool<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(ulong key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56CF0 Offset: 0xD552F0 VA: 0x180D56CF0
	|-OcclusionCulling.HashedPool<object>.ContainsKey
	*/

}

public class OcclusionCulling.SimpleList<T> // TypeDefIndex: 11520
{	// Fields
	private const int defaultCapacity = 16;
	private static readonly T[] emptyArray; // 0x0
	public T[] array; // 0x0
	public int count; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; set; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Count
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Count
	|-OcclusionCulling.SimpleList<int>.get_Count
	|-OcclusionCulling.SimpleList<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EBD30 Offset: 0x9EA330 VA: 0x1809EBD30
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Capacity
	|-OcclusionCulling.SimpleList<int>.get_Capacity
	|-OcclusionCulling.SimpleList<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63270 Offset: 0xD61870 VA: 0x180D63270
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Capacity
	|-OcclusionCulling.SimpleList<int>.set_Capacity
	|-OcclusionCulling.SimpleList<object>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63140 Offset: 0xD61740 VA: 0x180D63140
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Item
	|
	|-RVA: 0x9EBD90 Offset: 0x9EA390 VA: 0x1809EBD90
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Item
	|-OcclusionCulling.SimpleList<object>.get_Item
	|
	|-RVA: 0xD63230 Offset: 0xD61830 VA: 0x180D63230
	|-OcclusionCulling.SimpleList<int>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63470 Offset: 0xD61A70 VA: 0x180D63470
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Item
	|
	|-RVA: 0xD633E0 Offset: 0xD619E0 VA: 0x180D633E0
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Item
	|-OcclusionCulling.SimpleList<object>.set_Item
	|
	|-RVA: 0xD63430 Offset: 0xD61A30 VA: 0x180D63430
	|-OcclusionCulling.SimpleList<int>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62F20 Offset: 0xD61520 VA: 0x180D62F20
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63010 Offset: 0xD61610 VA: 0x180D63010
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<OccludeeState>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62880 Offset: 0xD60E80 VA: 0x180D62880
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Add
	|
	|-RVA: 0xD62630 Offset: 0xD60C30 VA: 0x180D62630
	|-OcclusionCulling.SimpleList<OccludeeState>.Add
	|-OcclusionCulling.SimpleList<object>.Add
	|
	|-RVA: 0xD626C0 Offset: 0xD60CC0 VA: 0x180D626C0
	|-OcclusionCulling.SimpleList<int>.Add
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62920 Offset: 0xD60F20 VA: 0x180D62920
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Clear
	|-OcclusionCulling.SimpleList<int>.Clear
	|-OcclusionCulling.SimpleList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62AB0 Offset: 0xD610B0 VA: 0x180D62AB0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Contains
	|
	|-RVA: 0xD62D10 Offset: 0xD61310 VA: 0x180D62D10
	|-OcclusionCulling.SimpleList<int>.Contains
	|
	|-RVA: 0xD62950 Offset: 0xD60F50 VA: 0x180D62950
	|-OcclusionCulling.SimpleList<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62DE0 Offset: 0xD613E0 VA: 0x180D62DE0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.CopyTo
	|-OcclusionCulling.SimpleList<int>.CopyTo
	|-OcclusionCulling.SimpleList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62E10 Offset: 0xD61410 VA: 0x180D62E10
	|-OcclusionCulling.SimpleList<OccludeeState.State>.EnsureCapacity
	|-OcclusionCulling.SimpleList<int>.EnsureCapacity
	|-OcclusionCulling.SimpleList<object>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62E70 Offset: 0xD61470 VA: 0x180D62E70
	|-OcclusionCulling.SimpleList<OccludeeState.State>..cctor
	|-OcclusionCulling.SimpleList<int>..cctor
	|-OcclusionCulling.SimpleList<object>..cctor
	*/

}

public class OcclusionCulling.SmartListValue // TypeDefIndex: 11521
{	// Fields
	public int hashedListIndex; // 0x10

	// Methods

	// RVA: 0x9D8410 Offset: 0x9D6A10 VA: 0x1809D8410
	public void .ctor() { }

}

public class OcclusionCulling.SmartList // TypeDefIndex: 11522
{	// Fields
	private const int defaultCapacity = 16;
	private static readonly OccludeeState[] emptyList; // 0x0
	private static readonly int[] emptySlots; // 0x8
	private OccludeeState[] list; // 0x10
	private int[] slots; // 0x18
	private Queue<int> recycled; // 0x20
	private int count; // 0x28

	// Properties
	public OccludeeState[] List { get; }
	public int[] Slots { get; }
	public int Size { get; }
	public int Count { get; }
	public OccludeeState Item { get; set; }
	public int Capacity { get; set; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public OccludeeState[] get_List() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public int[] get_Slots() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public int get_Size() { }

	// RVA: 0x9EBD50 Offset: 0x9EA350 VA: 0x1809EBD50
	public int get_Count() { }

	// RVA: 0x9EBD90 Offset: 0x9EA390 VA: 0x1809EBD90
	public OccludeeState get_Item(int i) { }

	// RVA: 0x9EBF10 Offset: 0x9EA510 VA: 0x1809EBF10
	public void set_Item(int i, OccludeeState value) { }

	// RVA: 0x9EBD30 Offset: 0x9EA330 VA: 0x1809EBD30
	public int get_Capacity() { }

	// RVA: 0x9EBDD0 Offset: 0x9EA3D0 VA: 0x1809EBDD0
	public void set_Capacity(int value) { }

	// RVA: 0x9EBC80 Offset: 0x9EA280 VA: 0x1809EBC80
	public void .ctor(int capacity) { }

	// RVA: 0x9EB660 Offset: 0x9E9C60 VA: 0x1809EB660
	public void Add(OccludeeState value, int capacityGranularity = 16) { }

	// RVA: 0x9EBB20 Offset: 0x9EA120 VA: 0x1809EBB20
	public void Remove(OccludeeState value) { }

	// RVA: 0x9EB960 Offset: 0x9E9F60 VA: 0x1809EB960
	public bool Contains(OccludeeState value) { }

	// RVA: 0x9EB9B0 Offset: 0x9E9FB0 VA: 0x1809EB9B0
	public void EnsureCapacity(int min) { }

	// RVA: 0x9EBC00 Offset: 0x9EA200 VA: 0x1809EBC00
	private static void .cctor() { }

}

public class OcclusionCulling.Cell : OcclusionCulling.HashedPoolValue // TypeDefIndex: 11523
{	// Fields
	public int x; // 0x20
	public int y; // 0x24
	public int z; // 0x28
	public Bounds bounds; // 0x2C
	public Vector4 sphereBounds; // 0x44
	public bool isVisible; // 0x54
	public OcclusionCulling.SmartList staticBucket; // 0x58
	public OcclusionCulling.SmartList dynamicBucket; // 0x60

	// Methods

	// RVA: 0x9D0CE0 Offset: 0x9CF2E0 VA: 0x1809D0CE0
	public void Reset() { }

	// RVA: 0x9D0B40 Offset: 0x9CF140 VA: 0x1809D0B40
	public OcclusionCulling.Cell Initialize(int x, int y, int z, Bounds bounds) { }

	// RVA: 0x9D0D80 Offset: 0x9CF380 VA: 0x1809D0D80
	public void .ctor() { }

}

public struct OcclusionCulling.Sphere // TypeDefIndex: 11524
{	// Fields
	public Vector3 position; // 0x0
	public float radius; // 0xC

	// Methods

	// RVA: 0xFB1F0 Offset: 0xFA5F0 VA: 0x1800FB1F0
	public bool IsValid() { }

	// RVA: 0xFB200 Offset: 0xFA600 VA: 0x1800FB200
	public void .ctor(Vector3 position, float radius) { }

}

public sealed class OcclusionCulling.OnVisibilityChanged : MulticastDelegate // TypeDefIndex: 11525
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E6940 Offset: 0x9E4F40 VA: 0x1809E6940 Slot: 12
	public virtual void Invoke(bool visible) { }

	// RVA: 0x9E68C0 Offset: 0x9E4EC0 VA: 0x1809E68C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(bool visible, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

