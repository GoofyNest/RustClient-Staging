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

	// RVA: 0x4BCCB0 Offset: 0x4BB2B0 VA: 0x1804BCCB0
	public static bool DebugFilterIsDynamic(int filter) { }

	// RVA: 0x9DCD30 Offset: 0x9DB330 VA: 0x1809DCD30
	public static bool DebugFilterIsStatic(int filter) { }

	// RVA: 0x9DCD20 Offset: 0x9DB320 VA: 0x1809DCD20
	public static bool DebugFilterIsGrid(int filter) { }

	// RVA: 0x9DCD40 Offset: 0x9DB340 VA: 0x1809DCD40
	private void DebugInitialize() { }

	// RVA: 0x9DCDE0 Offset: 0x9DB3E0 VA: 0x1809DCDE0
	private void DebugShutdown() { }

	// RVA: 0x9DCE90 Offset: 0x9DB490 VA: 0x1809DCE90
	private void DebugUpdate() { }

	// RVA: 0x9DBDD0 Offset: 0x9DA3D0 VA: 0x1809DBDD0
	private void DebugDraw() { }

	// RVA: 0x9DEC40 Offset: 0x9DD240 VA: 0x1809DEC40
	public static void NormalizePlane(ref Vector4 plane) { }

	// RVA: 0x9DD0F0 Offset: 0x9DB6F0 VA: 0x1809DD0F0
	public static void ExtractFrustum(Matrix4x4 viewProjMatrix, ref Vector4[] planes) { }

	// RVA: 0x9E4360 Offset: 0x9E2960 VA: 0x1809E4360
	public bool get_HiZReady() { }

	// RVA: 0x9DB3D0 Offset: 0x9D99D0 VA: 0x1809DB3D0
	public void CheckResizeHiZMap() { }

	// RVA: 0x9DE6A0 Offset: 0x9DCCA0 VA: 0x1809DE6A0
	private void InitializeHiZMap() { }

	// RVA: 0x9DD9B0 Offset: 0x9DBFB0 VA: 0x1809DD9B0
	private void FinalizeHiZMap() { }

	// RVA: 0x9DE3E0 Offset: 0x9DC9E0 VA: 0x1809DE3E0
	private void InitializeHiZMap(int width, int height) { }

	// RVA: 0x9DCF30 Offset: 0x9DB530 VA: 0x1809DCF30
	private void DestroyHiZMap() { }

	// RVA: 0x9DB790 Offset: 0x9D9D90 VA: 0x1809DB790
	private RenderTexture CreateDepthTexture(string name, int width, int height, bool mips = False) { }

	// RVA: 0x9DB6B0 Offset: 0x9D9CB0 VA: 0x1809DB6B0
	private RenderTexture CreateDepthTextureMip(string name, int width, int height, int mip) { }

	// RVA: 0x9DE270 Offset: 0x9DC870 VA: 0x1809DE270
	public void GrabDepthTexture() { }

	// RVA: 0x9DDD00 Offset: 0x9DC300 VA: 0x1809DDD00
	public void GenerateHiZMipChain() { }

	// RVA: 0x9DB880 Offset: 0x9D9E80 VA: 0x1809DB880
	private void DebugDrawGizmos() { }

	// RVA: 0x9E4280 Offset: 0x9E2880 VA: 0x1809E4280
	private static int floor(float x) { }

	// RVA: 0x9E19C0 Offset: 0x9DFFC0 VA: 0x1809E19C0
	public static OcclusionCulling.Cell RegisterToGrid(OccludeeState occludee) { }

	// RVA: 0x9E39D0 Offset: 0x9E1FD0 VA: 0x1809E39D0
	public static void UpdateInGrid(OccludeeState occludee) { }

	// RVA: 0x9E2910 Offset: 0x9E0F10 VA: 0x1809E2910
	public static void UnregisterFromGrid(OccludeeState occludee) { }

	// RVA: 0x9E35D0 Offset: 0x9E1BD0 VA: 0x1809E35D0
	public void UpdateGridBuffers() { }

	// RVA: 0x9E43E0 Offset: 0x9E29E0 VA: 0x1809E43E0
	public static OcclusionCulling get_Instance() { }

	// RVA: 0x9E44A0 Offset: 0x9E2AA0 VA: 0x1809E44A0
	public static bool get_Supported() { }

	// RVA: 0x9E4300 Offset: 0x9E2900 VA: 0x1809E4300
	public static bool get_Enabled() { }

	// RVA: 0x9E4580 Offset: 0x9E2B80 VA: 0x1809E4580
	public static void set_Enabled(bool value) { }

	// RVA: 0x9E4440 Offset: 0x9E2A40 VA: 0x1809E4440
	public static bool get_SafeMode() { }

	// RVA: 0x9E4680 Offset: 0x9E2C80 VA: 0x1809E4680
	public static void set_SafeMode(bool value) { }

	// RVA: 0x9E42A0 Offset: 0x9E28A0 VA: 0x1809E42A0
	public static OcclusionCulling.DebugFilter get_DebugShow() { }

	// RVA: 0x9E4520 Offset: 0x9E2B20 VA: 0x1809E4520
	public static void set_DebugShow(OcclusionCulling.DebugFilter value) { }

	// RVA: 0x9DE320 Offset: 0x9DC920 VA: 0x1809DE320
	private static void GrowStatePool() { }

	// RVA: 0x9D9FA0 Offset: 0x9D85A0 VA: 0x1809D9FA0
	private static OccludeeState Allocate() { }

	// RVA: 0x9E1FF0 Offset: 0x9E05F0 VA: 0x1809E1FF0
	private static void Release(OccludeeState state) { }

	// RVA: 0x9DB290 Offset: 0x9D9890 VA: 0x1809DB290
	private void Awake() { }

	// RVA: 0x9DEFF0 Offset: 0x9DD5F0 VA: 0x1809DEFF0
	private void OnEnable() { }

	// RVA: 0x9E2750 Offset: 0x9E0D50 VA: 0x1809E2750
	private bool SupportsNativePath() { }

	// RVA: 0x9DED20 Offset: 0x9DD320 VA: 0x1809DED20
	private void OnDisable() { }

	// RVA: 0x9DE960 Offset: 0x9DCF60 VA: 0x1809DE960
	public static void MakeAllVisible() { }

	// RVA: 0x9E3B80 Offset: 0x9E2180 VA: 0x1809E3B80
	private void Update() { }

	// RVA: -1 Offset: -1
	public static void RecursiveAddOccludees<T>(Transform transform, float minTimeVisible = 0,1, bool isStatic = True, bool stickyGizmos = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFE790 Offset: 0xCFCD90 VA: 0x180CFE790
	|-OcclusionCulling.RecursiveAddOccludees<object>
	*/

	// RVA: 0x9DDAE0 Offset: 0x9DC0E0 VA: 0x1809DDAE0
	private static int FindFreeSlot(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled) { }

	// RVA: 0x9DE1A0 Offset: 0x9DC7A0 VA: 0x1809DE1A0
	public static OccludeeState GetStateById(int id) { }

	// RVA: 0x9E1250 Offset: 0x9DF850 VA: 0x1809E1250
	public static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	// RVA: 0x9E1420 Offset: 0x9DFA20 VA: 0x1809E1420
	private static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged, OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled, List<int> changed, OcclusionCulling.BufferSet set, OcclusionCulling.SimpleList<int> visibilityChanged) { }

	// RVA: 0x9E2C00 Offset: 0x9E1200 VA: 0x1809E2C00
	public static void UnregisterOccludee(int id) { }

	// RVA: 0x9E2CE0 Offset: 0x9E12E0 VA: 0x1809E2CE0
	private static void UnregisterOccludee(int slot, OcclusionCulling.SimpleList<OccludeeState> occludees, Queue<int> recycled, List<int> changed) { }

	// RVA: 0x9E3480 Offset: 0x9E1A80 VA: 0x1809E3480
	public static void UpdateDynamicOccludee(int id, Vector3 center, float radius) { }

	// RVA: 0x9E2EE0 Offset: 0x9E14E0 VA: 0x1809E2EE0
	private void UpdateBuffers(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, List<int> changed, bool isStatic) { }

	// RVA: 0x9E3130 Offset: 0x9E1730 VA: 0x1809E3130
	private void UpdateCameraMatrices(bool starting = False) { }

	// RVA: 0x9DF7F0 Offset: 0x9DDDF0 VA: 0x1809DF7F0
	private void OnPreCull() { }

	// RVA: 0x9DF690 Offset: 0x9DDC90 VA: 0x1809DF690
	private void OnPostRender() { }

	// RVA: 0x9DEB80 Offset: 0x9DD180 VA: 0x1809DEB80
	private float[] MatrixToFloatArray(Matrix4x4 m) { }

	// RVA: 0x9DFB50 Offset: 0x9DE150 VA: 0x1809DFB50
	private void PrepareAndDispatch() { }

	// RVA: 0x9DE7A0 Offset: 0x9DCDA0 VA: 0x1809DE7A0
	private void IssueRead() { }

	// RVA: 0x9E2070 Offset: 0x9E0670 VA: 0x1809E2070
	public void ResetTiming(OcclusionCulling.SmartList bucket) { }

	// RVA: 0x9E2100 Offset: 0x9E0700 VA: 0x1809E2100
	public void ResetTiming() { }

	// RVA: 0x9DDC60 Offset: 0x9DC260 VA: 0x1809DDC60
	private static bool FrustumCull(Vector4[] planes, Vector4 testSphere) { }

	// RVA: 0x9E0F10 Offset: 0x9DF510 VA: 0x1809E0F10
	private static int ProcessOccludees_Safe(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SmartList bucket, Color32[] results, OcclusionCulling.SimpleList<int> changed, Vector4[] frustumPlanes, float time, uint frame) { }

	// RVA: 0x9E0A90 Offset: 0x9DF090 VA: 0x1809E0A90
	private static int ProcessOccludees_Fast(OccludeeState.State[] states, int[] bucket, int bucketCount, Color32[] results, int resultCount, int[] changed, ref int changedCount, Vector4[] frustumPlanes, float time, uint frame) { }

	// RVA: 0x9E0E10 Offset: 0x9DF410 VA: 0x1809E0E10
	private static extern int ProcessOccludees_Native(ref OccludeeState.State states, ref int bucket, int bucketCount, ref Color32 results, int resultCount, ref int changed, ref int changedCount, ref Vector4 frustumPlanes, float time, uint frame) { }

	// RVA: 0x9DADC0 Offset: 0x9D93C0 VA: 0x1809DADC0
	private void ApplyVisibility_Safe(float time, uint frame) { }

	// RVA: 0x9DA130 Offset: 0x9D8730 VA: 0x1809DA130
	private void ApplyVisibility_Fast(float time, uint frame) { }

	// RVA: 0x9DA6C0 Offset: 0x9D8CC0 VA: 0x1809DA6C0
	private void ApplyVisibility_Native(float time, uint frame) { }

	// RVA: 0x9E0890 Offset: 0x9DEE90 VA: 0x1809E0890
	private void ProcessCallbacks(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SimpleList<int> changed) { }

	// RVA: 0x9E2210 Offset: 0x9E0810 VA: 0x1809E2210
	public void RetrieveAndApplyVisibility() { }

	// RVA: 0x9E4190 Offset: 0x9E2790 VA: 0x1809E4190
	public void .ctor() { }

	// RVA: 0x9E3CF0 Offset: 0x9E22F0 VA: 0x1809E3CF0
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

	// RVA: 0x9D0630 Offset: 0x9CEC30 VA: 0x1809D0630
	public bool get_Ready() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void Attach(OcclusionCulling culling) { }

	// RVA: 0x9CFE60 Offset: 0x9CE460 VA: 0x1809CFE60
	public void Dispose(bool data = True) { }

	// RVA: 0x9CF790 Offset: 0x9CDD90 VA: 0x1809CF790
	public bool CheckResize(int count, int granularity) { }

	// RVA: 0x9D0510 Offset: 0x9CEB10 VA: 0x1809D0510
	public void UploadData() { }

	// RVA: 0x9CF780 Offset: 0x9CDD80 VA: 0x1809CF780
	private int AlignDispatchSize(int dispatchSize) { }

	// RVA: 0x9CFC90 Offset: 0x9CE290 VA: 0x1809CFC90
	public void Dispatch(int count) { }

	// RVA: 0x9D03C0 Offset: 0x9CE9C0 VA: 0x1809D03C0
	public void IssueRead() { }

	// RVA: 0x9D00D0 Offset: 0x9CE6D0 VA: 0x1809D00D0
	public void GetResults() { }

	// RVA: 0x9D0580 Offset: 0x9CEB80 VA: 0x1809D0580
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

	// RVA: 0x9D08B0 Offset: 0x9CEEB0 VA: 0x1809D08B0
	public void .ctor() { }

}

public class OcclusionCulling.HashedPoolValue // TypeDefIndex: 11518
{	// Fields
	public ulong hashedPoolKey; // 0x10
	public int hashedPoolIndex; // 0x18

	// Methods

	// RVA: 0x9D0890 Offset: 0x9CEE90 VA: 0x1809D0890
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
	|-RVA: 0xD561C0 Offset: 0xD547C0 VA: 0x180D561C0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Size
	|-OcclusionCulling.HashedPool<object>.get_Size
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56160 Offset: 0xD54760 VA: 0x180D56160
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Count
	|-OcclusionCulling.HashedPool<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public ValueType get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD56190 Offset: 0xD54790 VA: 0x180D56190
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Item
	|-OcclusionCulling.HashedPool<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int i, ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD561F0 Offset: 0xD547F0 VA: 0x180D561F0
	|-OcclusionCulling.HashedPool<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int granularity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55FC0 Offset: 0xD545C0 VA: 0x180D55FC0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>..ctor
	|-OcclusionCulling.HashedPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55E10 Offset: 0xD54410 VA: 0x180D55E10
	|-OcclusionCulling.HashedPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public ValueType Add(ulong key, int capacityGranularity = 16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55C20 Offset: 0xD54220 VA: 0x180D55C20
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Add
	|-OcclusionCulling.HashedPool<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55EE0 Offset: 0xD544E0 VA: 0x180D55EE0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Remove
	|-OcclusionCulling.HashedPool<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(ulong key, out ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55F90 Offset: 0xD54590 VA: 0x180D55F90
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.TryGetValue
	|-OcclusionCulling.HashedPool<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(ulong key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55EB0 Offset: 0xD544B0 VA: 0x180D55EB0
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
	|-RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Count
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Count
	|-OcclusionCulling.SimpleList<int>.get_Count
	|-OcclusionCulling.SimpleList<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EB840 Offset: 0x9E9E40 VA: 0x1809EB840
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Capacity
	|-OcclusionCulling.SimpleList<int>.get_Capacity
	|-OcclusionCulling.SimpleList<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD627C0 Offset: 0xD60DC0 VA: 0x180D627C0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Capacity
	|-OcclusionCulling.SimpleList<int>.set_Capacity
	|-OcclusionCulling.SimpleList<object>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62690 Offset: 0xD60C90 VA: 0x180D62690
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Item
	|
	|-RVA: 0x9EB8A0 Offset: 0x9E9EA0 VA: 0x1809EB8A0
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Item
	|-OcclusionCulling.SimpleList<object>.get_Item
	|
	|-RVA: 0xD62780 Offset: 0xD60D80 VA: 0x180D62780
	|-OcclusionCulling.SimpleList<int>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD629C0 Offset: 0xD60FC0 VA: 0x180D629C0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Item
	|
	|-RVA: 0xD62930 Offset: 0xD60F30 VA: 0x180D62930
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Item
	|-OcclusionCulling.SimpleList<object>.set_Item
	|
	|-RVA: 0xD62980 Offset: 0xD60F80 VA: 0x180D62980
	|-OcclusionCulling.SimpleList<int>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62470 Offset: 0xD60A70 VA: 0x180D62470
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62560 Offset: 0xD60B60 VA: 0x180D62560
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<OccludeeState>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD61DD0 Offset: 0xD603D0 VA: 0x180D61DD0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Add
	|
	|-RVA: 0xD61B80 Offset: 0xD60180 VA: 0x180D61B80
	|-OcclusionCulling.SimpleList<OccludeeState>.Add
	|-OcclusionCulling.SimpleList<object>.Add
	|
	|-RVA: 0xD61C10 Offset: 0xD60210 VA: 0x180D61C10
	|-OcclusionCulling.SimpleList<int>.Add
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD61E70 Offset: 0xD60470 VA: 0x180D61E70
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Clear
	|-OcclusionCulling.SimpleList<int>.Clear
	|-OcclusionCulling.SimpleList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62000 Offset: 0xD60600 VA: 0x180D62000
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Contains
	|
	|-RVA: 0xD62260 Offset: 0xD60860 VA: 0x180D62260
	|-OcclusionCulling.SimpleList<int>.Contains
	|
	|-RVA: 0xD61EA0 Offset: 0xD604A0 VA: 0x180D61EA0
	|-OcclusionCulling.SimpleList<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62330 Offset: 0xD60930 VA: 0x180D62330
	|-OcclusionCulling.SimpleList<OccludeeState.State>.CopyTo
	|-OcclusionCulling.SimpleList<int>.CopyTo
	|-OcclusionCulling.SimpleList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62360 Offset: 0xD60960 VA: 0x180D62360
	|-OcclusionCulling.SimpleList<OccludeeState.State>.EnsureCapacity
	|-OcclusionCulling.SimpleList<int>.EnsureCapacity
	|-OcclusionCulling.SimpleList<object>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD623C0 Offset: 0xD609C0 VA: 0x180D623C0
	|-OcclusionCulling.SimpleList<OccludeeState.State>..cctor
	|-OcclusionCulling.SimpleList<int>..cctor
	|-OcclusionCulling.SimpleList<object>..cctor
	*/

}

public class OcclusionCulling.SmartListValue // TypeDefIndex: 11521
{	// Fields
	public int hashedListIndex; // 0x10

	// Methods

	// RVA: 0x9D7F20 Offset: 0x9D6520 VA: 0x1809D7F20
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

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public OccludeeState[] get_List() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public int[] get_Slots() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_Size() { }

	// RVA: 0x9EB860 Offset: 0x9E9E60 VA: 0x1809EB860
	public int get_Count() { }

	// RVA: 0x9EB8A0 Offset: 0x9E9EA0 VA: 0x1809EB8A0
	public OccludeeState get_Item(int i) { }

	// RVA: 0x9EBA20 Offset: 0x9EA020 VA: 0x1809EBA20
	public void set_Item(int i, OccludeeState value) { }

	// RVA: 0x9EB840 Offset: 0x9E9E40 VA: 0x1809EB840
	public int get_Capacity() { }

	// RVA: 0x9EB8E0 Offset: 0x9E9EE0 VA: 0x1809EB8E0
	public void set_Capacity(int value) { }

	// RVA: 0x9EB790 Offset: 0x9E9D90 VA: 0x1809EB790
	public void .ctor(int capacity) { }

	// RVA: 0x9EB170 Offset: 0x9E9770 VA: 0x1809EB170
	public void Add(OccludeeState value, int capacityGranularity = 16) { }

	// RVA: 0x9EB630 Offset: 0x9E9C30 VA: 0x1809EB630
	public void Remove(OccludeeState value) { }

	// RVA: 0x9EB470 Offset: 0x9E9A70 VA: 0x1809EB470
	public bool Contains(OccludeeState value) { }

	// RVA: 0x9EB4C0 Offset: 0x9E9AC0 VA: 0x1809EB4C0
	public void EnsureCapacity(int min) { }

	// RVA: 0x9EB710 Offset: 0x9E9D10 VA: 0x1809EB710
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

	// RVA: 0x9D07F0 Offset: 0x9CEDF0 VA: 0x1809D07F0
	public void Reset() { }

	// RVA: 0x9D0650 Offset: 0x9CEC50 VA: 0x1809D0650
	public OcclusionCulling.Cell Initialize(int x, int y, int z, Bounds bounds) { }

	// RVA: 0x9D0890 Offset: 0x9CEE90 VA: 0x1809D0890
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

	// RVA: 0x9E6450 Offset: 0x9E4A50 VA: 0x1809E6450 Slot: 12
	public virtual void Invoke(bool visible) { }

	// RVA: 0x9E63D0 Offset: 0x9E49D0 VA: 0x1809E63D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(bool visible, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

