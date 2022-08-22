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

	// RVA: 0x9DCA70 Offset: 0x9DB070 VA: 0x1809DCA70
	public static bool DebugFilterIsStatic(int filter) { }

	// RVA: 0x9DCA60 Offset: 0x9DB060 VA: 0x1809DCA60
	public static bool DebugFilterIsGrid(int filter) { }

	// RVA: 0x9DCA80 Offset: 0x9DB080 VA: 0x1809DCA80
	private void DebugInitialize() { }

	// RVA: 0x9DCB20 Offset: 0x9DB120 VA: 0x1809DCB20
	private void DebugShutdown() { }

	// RVA: 0x9DCBD0 Offset: 0x9DB1D0 VA: 0x1809DCBD0
	private void DebugUpdate() { }

	// RVA: 0x9DBB10 Offset: 0x9DA110 VA: 0x1809DBB10
	private void DebugDraw() { }

	// RVA: 0x9DE980 Offset: 0x9DCF80 VA: 0x1809DE980
	public static void NormalizePlane(ref Vector4 plane) { }

	// RVA: 0x9DCE30 Offset: 0x9DB430 VA: 0x1809DCE30
	public static void ExtractFrustum(Matrix4x4 viewProjMatrix, ref Vector4[] planes) { }

	// RVA: 0x9E40A0 Offset: 0x9E26A0 VA: 0x1809E40A0
	public bool get_HiZReady() { }

	// RVA: 0x9DB110 Offset: 0x9D9710 VA: 0x1809DB110
	public void CheckResizeHiZMap() { }

	// RVA: 0x9DE3E0 Offset: 0x9DC9E0 VA: 0x1809DE3E0
	private void InitializeHiZMap() { }

	// RVA: 0x9DD6F0 Offset: 0x9DBCF0 VA: 0x1809DD6F0
	private void FinalizeHiZMap() { }

	// RVA: 0x9DE120 Offset: 0x9DC720 VA: 0x1809DE120
	private void InitializeHiZMap(int width, int height) { }

	// RVA: 0x9DCC70 Offset: 0x9DB270 VA: 0x1809DCC70
	private void DestroyHiZMap() { }

	// RVA: 0x9DB4D0 Offset: 0x9D9AD0 VA: 0x1809DB4D0
	private RenderTexture CreateDepthTexture(string name, int width, int height, bool mips = False) { }

	// RVA: 0x9DB3F0 Offset: 0x9D99F0 VA: 0x1809DB3F0
	private RenderTexture CreateDepthTextureMip(string name, int width, int height, int mip) { }

	// RVA: 0x9DDFB0 Offset: 0x9DC5B0 VA: 0x1809DDFB0
	public void GrabDepthTexture() { }

	// RVA: 0x9DDA40 Offset: 0x9DC040 VA: 0x1809DDA40
	public void GenerateHiZMipChain() { }

	// RVA: 0x9DB5C0 Offset: 0x9D9BC0 VA: 0x1809DB5C0
	private void DebugDrawGizmos() { }

	// RVA: 0x9E3FC0 Offset: 0x9E25C0 VA: 0x1809E3FC0
	private static int floor(float x) { }

	// RVA: 0x9E1700 Offset: 0x9DFD00 VA: 0x1809E1700
	public static OcclusionCulling.Cell RegisterToGrid(OccludeeState occludee) { }

	// RVA: 0x9E3710 Offset: 0x9E1D10 VA: 0x1809E3710
	public static void UpdateInGrid(OccludeeState occludee) { }

	// RVA: 0x9E2650 Offset: 0x9E0C50 VA: 0x1809E2650
	public static void UnregisterFromGrid(OccludeeState occludee) { }

	// RVA: 0x9E3310 Offset: 0x9E1910 VA: 0x1809E3310
	public void UpdateGridBuffers() { }

	// RVA: 0x9E4120 Offset: 0x9E2720 VA: 0x1809E4120
	public static OcclusionCulling get_Instance() { }

	// RVA: 0x9E41E0 Offset: 0x9E27E0 VA: 0x1809E41E0
	public static bool get_Supported() { }

	// RVA: 0x9E4040 Offset: 0x9E2640 VA: 0x1809E4040
	public static bool get_Enabled() { }

	// RVA: 0x9E42C0 Offset: 0x9E28C0 VA: 0x1809E42C0
	public static void set_Enabled(bool value) { }

	// RVA: 0x9E4180 Offset: 0x9E2780 VA: 0x1809E4180
	public static bool get_SafeMode() { }

	// RVA: 0x9E43C0 Offset: 0x9E29C0 VA: 0x1809E43C0
	public static void set_SafeMode(bool value) { }

	// RVA: 0x9E3FE0 Offset: 0x9E25E0 VA: 0x1809E3FE0
	public static OcclusionCulling.DebugFilter get_DebugShow() { }

	// RVA: 0x9E4260 Offset: 0x9E2860 VA: 0x1809E4260
	public static void set_DebugShow(OcclusionCulling.DebugFilter value) { }

	// RVA: 0x9DE060 Offset: 0x9DC660 VA: 0x1809DE060
	private static void GrowStatePool() { }

	// RVA: 0x9D9CE0 Offset: 0x9D82E0 VA: 0x1809D9CE0
	private static OccludeeState Allocate() { }

	// RVA: 0x9E1D30 Offset: 0x9E0330 VA: 0x1809E1D30
	private static void Release(OccludeeState state) { }

	// RVA: 0x9DAFD0 Offset: 0x9D95D0 VA: 0x1809DAFD0
	private void Awake() { }

	// RVA: 0x9DED30 Offset: 0x9DD330 VA: 0x1809DED30
	private void OnEnable() { }

	// RVA: 0x9E2490 Offset: 0x9E0A90 VA: 0x1809E2490
	private bool SupportsNativePath() { }

	// RVA: 0x9DEA60 Offset: 0x9DD060 VA: 0x1809DEA60
	private void OnDisable() { }

	// RVA: 0x9DE6A0 Offset: 0x9DCCA0 VA: 0x1809DE6A0
	public static void MakeAllVisible() { }

	// RVA: 0x9E38C0 Offset: 0x9E1EC0 VA: 0x1809E38C0
	private void Update() { }

	// RVA: -1 Offset: -1
	public static void RecursiveAddOccludees<T>(Transform transform, float minTimeVisible = 0,1, bool isStatic = True, bool stickyGizmos = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFE4D0 Offset: 0xCFCAD0 VA: 0x180CFE4D0
	|-OcclusionCulling.RecursiveAddOccludees<object>
	*/

	// RVA: 0x9DD820 Offset: 0x9DBE20 VA: 0x1809DD820
	private static int FindFreeSlot(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled) { }

	// RVA: 0x9DDEE0 Offset: 0x9DC4E0 VA: 0x1809DDEE0
	public static OccludeeState GetStateById(int id) { }

	// RVA: 0x9E0F90 Offset: 0x9DF590 VA: 0x1809E0F90
	public static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	// RVA: 0x9E1160 Offset: 0x9DF760 VA: 0x1809E1160
	private static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged, OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled, List<int> changed, OcclusionCulling.BufferSet set, OcclusionCulling.SimpleList<int> visibilityChanged) { }

	// RVA: 0x9E2940 Offset: 0x9E0F40 VA: 0x1809E2940
	public static void UnregisterOccludee(int id) { }

	// RVA: 0x9E2A20 Offset: 0x9E1020 VA: 0x1809E2A20
	private static void UnregisterOccludee(int slot, OcclusionCulling.SimpleList<OccludeeState> occludees, Queue<int> recycled, List<int> changed) { }

	// RVA: 0x9E31C0 Offset: 0x9E17C0 VA: 0x1809E31C0
	public static void UpdateDynamicOccludee(int id, Vector3 center, float radius) { }

	// RVA: 0x9E2C20 Offset: 0x9E1220 VA: 0x1809E2C20
	private void UpdateBuffers(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, List<int> changed, bool isStatic) { }

	// RVA: 0x9E2E70 Offset: 0x9E1470 VA: 0x1809E2E70
	private void UpdateCameraMatrices(bool starting = False) { }

	// RVA: 0x9DF530 Offset: 0x9DDB30 VA: 0x1809DF530
	private void OnPreCull() { }

	// RVA: 0x9DF3D0 Offset: 0x9DD9D0 VA: 0x1809DF3D0
	private void OnPostRender() { }

	// RVA: 0x9DE8C0 Offset: 0x9DCEC0 VA: 0x1809DE8C0
	private float[] MatrixToFloatArray(Matrix4x4 m) { }

	// RVA: 0x9DF890 Offset: 0x9DDE90 VA: 0x1809DF890
	private void PrepareAndDispatch() { }

	// RVA: 0x9DE4E0 Offset: 0x9DCAE0 VA: 0x1809DE4E0
	private void IssueRead() { }

	// RVA: 0x9E1DB0 Offset: 0x9E03B0 VA: 0x1809E1DB0
	public void ResetTiming(OcclusionCulling.SmartList bucket) { }

	// RVA: 0x9E1E40 Offset: 0x9E0440 VA: 0x1809E1E40
	public void ResetTiming() { }

	// RVA: 0x9DD9A0 Offset: 0x9DBFA0 VA: 0x1809DD9A0
	private static bool FrustumCull(Vector4[] planes, Vector4 testSphere) { }

	// RVA: 0x9E0C50 Offset: 0x9DF250 VA: 0x1809E0C50
	private static int ProcessOccludees_Safe(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SmartList bucket, Color32[] results, OcclusionCulling.SimpleList<int> changed, Vector4[] frustumPlanes, float time, uint frame) { }

	// RVA: 0x9E07D0 Offset: 0x9DEDD0 VA: 0x1809E07D0
	private static int ProcessOccludees_Fast(OccludeeState.State[] states, int[] bucket, int bucketCount, Color32[] results, int resultCount, int[] changed, ref int changedCount, Vector4[] frustumPlanes, float time, uint frame) { }

	// RVA: 0x9E0B50 Offset: 0x9DF150 VA: 0x1809E0B50
	private static extern int ProcessOccludees_Native(ref OccludeeState.State states, ref int bucket, int bucketCount, ref Color32 results, int resultCount, ref int changed, ref int changedCount, ref Vector4 frustumPlanes, float time, uint frame) { }

	// RVA: 0x9DAB00 Offset: 0x9D9100 VA: 0x1809DAB00
	private void ApplyVisibility_Safe(float time, uint frame) { }

	// RVA: 0x9D9E70 Offset: 0x9D8470 VA: 0x1809D9E70
	private void ApplyVisibility_Fast(float time, uint frame) { }

	// RVA: 0x9DA400 Offset: 0x9D8A00 VA: 0x1809DA400
	private void ApplyVisibility_Native(float time, uint frame) { }

	// RVA: 0x9E05D0 Offset: 0x9DEBD0 VA: 0x1809E05D0
	private void ProcessCallbacks(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SimpleList<int> changed) { }

	// RVA: 0x9E1F50 Offset: 0x9E0550 VA: 0x1809E1F50
	public void RetrieveAndApplyVisibility() { }

	// RVA: 0x9E3ED0 Offset: 0x9E24D0 VA: 0x1809E3ED0
	public void .ctor() { }

	// RVA: 0x9E3A30 Offset: 0x9E2030 VA: 0x1809E3A30
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

	// RVA: 0x9D0370 Offset: 0x9CE970 VA: 0x1809D0370
	public bool get_Ready() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void Attach(OcclusionCulling culling) { }

	// RVA: 0x9CFBA0 Offset: 0x9CE1A0 VA: 0x1809CFBA0
	public void Dispose(bool data = True) { }

	// RVA: 0x9CF4D0 Offset: 0x9CDAD0 VA: 0x1809CF4D0
	public bool CheckResize(int count, int granularity) { }

	// RVA: 0x9D0250 Offset: 0x9CE850 VA: 0x1809D0250
	public void UploadData() { }

	// RVA: 0x9CF4C0 Offset: 0x9CDAC0 VA: 0x1809CF4C0
	private int AlignDispatchSize(int dispatchSize) { }

	// RVA: 0x9CF9D0 Offset: 0x9CDFD0 VA: 0x1809CF9D0
	public void Dispatch(int count) { }

	// RVA: 0x9D0100 Offset: 0x9CE700 VA: 0x1809D0100
	public void IssueRead() { }

	// RVA: 0x9CFE10 Offset: 0x9CE410 VA: 0x1809CFE10
	public void GetResults() { }

	// RVA: 0x9D02C0 Offset: 0x9CE8C0 VA: 0x1809D02C0
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

	// RVA: 0x9D05F0 Offset: 0x9CEBF0 VA: 0x1809D05F0
	public void .ctor() { }

}

public class OcclusionCulling.HashedPoolValue // TypeDefIndex: 11518
{	// Fields
	public ulong hashedPoolKey; // 0x10
	public int hashedPoolIndex; // 0x18

	// Methods

	// RVA: 0x9D05D0 Offset: 0x9CEBD0 VA: 0x1809D05D0
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
	|-RVA: 0xD55F00 Offset: 0xD54500 VA: 0x180D55F00
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Size
	|-OcclusionCulling.HashedPool<object>.get_Size
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55EA0 Offset: 0xD544A0 VA: 0x180D55EA0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Count
	|-OcclusionCulling.HashedPool<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public ValueType get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55ED0 Offset: 0xD544D0 VA: 0x180D55ED0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Item
	|-OcclusionCulling.HashedPool<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int i, ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55F30 Offset: 0xD54530 VA: 0x180D55F30
	|-OcclusionCulling.HashedPool<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int granularity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55D00 Offset: 0xD54300 VA: 0x180D55D00
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>..ctor
	|-OcclusionCulling.HashedPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55B50 Offset: 0xD54150 VA: 0x180D55B50
	|-OcclusionCulling.HashedPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public ValueType Add(ulong key, int capacityGranularity = 16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55960 Offset: 0xD53F60 VA: 0x180D55960
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Add
	|-OcclusionCulling.HashedPool<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55C20 Offset: 0xD54220 VA: 0x180D55C20
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Remove
	|-OcclusionCulling.HashedPool<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(ulong key, out ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55CD0 Offset: 0xD542D0 VA: 0x180D55CD0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.TryGetValue
	|-OcclusionCulling.HashedPool<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(ulong key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55BF0 Offset: 0xD541F0 VA: 0x180D55BF0
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
	|-RVA: 0x9EB580 Offset: 0x9E9B80 VA: 0x1809EB580
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Capacity
	|-OcclusionCulling.SimpleList<int>.get_Capacity
	|-OcclusionCulling.SimpleList<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62500 Offset: 0xD60B00 VA: 0x180D62500
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Capacity
	|-OcclusionCulling.SimpleList<int>.set_Capacity
	|-OcclusionCulling.SimpleList<object>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD623D0 Offset: 0xD609D0 VA: 0x180D623D0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Item
	|
	|-RVA: 0x9EB5E0 Offset: 0x9E9BE0 VA: 0x1809EB5E0
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Item
	|-OcclusionCulling.SimpleList<object>.get_Item
	|
	|-RVA: 0xD624C0 Offset: 0xD60AC0 VA: 0x180D624C0
	|-OcclusionCulling.SimpleList<int>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62700 Offset: 0xD60D00 VA: 0x180D62700
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Item
	|
	|-RVA: 0xD62670 Offset: 0xD60C70 VA: 0x180D62670
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Item
	|-OcclusionCulling.SimpleList<object>.set_Item
	|
	|-RVA: 0xD626C0 Offset: 0xD60CC0 VA: 0x180D626C0
	|-OcclusionCulling.SimpleList<int>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD621B0 Offset: 0xD607B0 VA: 0x180D621B0
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD622A0 Offset: 0xD608A0 VA: 0x180D622A0
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<OccludeeState>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD61B10 Offset: 0xD60110 VA: 0x180D61B10
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Add
	|
	|-RVA: 0xD618C0 Offset: 0xD5FEC0 VA: 0x180D618C0
	|-OcclusionCulling.SimpleList<OccludeeState>.Add
	|-OcclusionCulling.SimpleList<object>.Add
	|
	|-RVA: 0xD61950 Offset: 0xD5FF50 VA: 0x180D61950
	|-OcclusionCulling.SimpleList<int>.Add
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD61BB0 Offset: 0xD601B0 VA: 0x180D61BB0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Clear
	|-OcclusionCulling.SimpleList<int>.Clear
	|-OcclusionCulling.SimpleList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD61D40 Offset: 0xD60340 VA: 0x180D61D40
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Contains
	|
	|-RVA: 0xD61FA0 Offset: 0xD605A0 VA: 0x180D61FA0
	|-OcclusionCulling.SimpleList<int>.Contains
	|
	|-RVA: 0xD61BE0 Offset: 0xD601E0 VA: 0x180D61BE0
	|-OcclusionCulling.SimpleList<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62070 Offset: 0xD60670 VA: 0x180D62070
	|-OcclusionCulling.SimpleList<OccludeeState.State>.CopyTo
	|-OcclusionCulling.SimpleList<int>.CopyTo
	|-OcclusionCulling.SimpleList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD620A0 Offset: 0xD606A0 VA: 0x180D620A0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.EnsureCapacity
	|-OcclusionCulling.SimpleList<int>.EnsureCapacity
	|-OcclusionCulling.SimpleList<object>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62100 Offset: 0xD60700 VA: 0x180D62100
	|-OcclusionCulling.SimpleList<OccludeeState.State>..cctor
	|-OcclusionCulling.SimpleList<int>..cctor
	|-OcclusionCulling.SimpleList<object>..cctor
	*/

}

public class OcclusionCulling.SmartListValue // TypeDefIndex: 11521
{	// Fields
	public int hashedListIndex; // 0x10

	// Methods

	// RVA: 0x9D7C60 Offset: 0x9D6260 VA: 0x1809D7C60
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

	// RVA: 0x9EB5A0 Offset: 0x9E9BA0 VA: 0x1809EB5A0
	public int get_Count() { }

	// RVA: 0x9EB5E0 Offset: 0x9E9BE0 VA: 0x1809EB5E0
	public OccludeeState get_Item(int i) { }

	// RVA: 0x9EB760 Offset: 0x9E9D60 VA: 0x1809EB760
	public void set_Item(int i, OccludeeState value) { }

	// RVA: 0x9EB580 Offset: 0x9E9B80 VA: 0x1809EB580
	public int get_Capacity() { }

	// RVA: 0x9EB620 Offset: 0x9E9C20 VA: 0x1809EB620
	public void set_Capacity(int value) { }

	// RVA: 0x9EB4D0 Offset: 0x9E9AD0 VA: 0x1809EB4D0
	public void .ctor(int capacity) { }

	// RVA: 0x9EAEB0 Offset: 0x9E94B0 VA: 0x1809EAEB0
	public void Add(OccludeeState value, int capacityGranularity = 16) { }

	// RVA: 0x9EB370 Offset: 0x9E9970 VA: 0x1809EB370
	public void Remove(OccludeeState value) { }

	// RVA: 0x9EB1B0 Offset: 0x9E97B0 VA: 0x1809EB1B0
	public bool Contains(OccludeeState value) { }

	// RVA: 0x9EB200 Offset: 0x9E9800 VA: 0x1809EB200
	public void EnsureCapacity(int min) { }

	// RVA: 0x9EB450 Offset: 0x9E9A50 VA: 0x1809EB450
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

	// RVA: 0x9D0530 Offset: 0x9CEB30 VA: 0x1809D0530
	public void Reset() { }

	// RVA: 0x9D0390 Offset: 0x9CE990 VA: 0x1809D0390
	public OcclusionCulling.Cell Initialize(int x, int y, int z, Bounds bounds) { }

	// RVA: 0x9D05D0 Offset: 0x9CEBD0 VA: 0x1809D05D0
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

	// RVA: 0x9E6190 Offset: 0x9E4790 VA: 0x1809E6190 Slot: 12
	public virtual void Invoke(bool visible) { }

	// RVA: 0x9E6110 Offset: 0x9E4710 VA: 0x1809E6110 Slot: 13
	public virtual IAsyncResult BeginInvoke(bool visible, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

