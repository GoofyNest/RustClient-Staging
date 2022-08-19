public class WaterDynamics : MonoBehaviour // TypeDefIndex: 10603
{	// Fields
	private const int maxRasterSize = 1024;
	private const int subStep = 256;
	private const int subShift = 8;
	private const int subMask = 255;
	private const float oneOverSubStep = 0,00390625;
	private const float interp_subStep = 65536;
	private const int interp_subShift = 16;
	private const int interp_subFracMask = 65535;
	private WaterDynamics.ImageDesc imageDesc; // 0x18
	private byte[] imagePixels; // 0x30
	private WaterDynamics.TargetDesc targetDesc; // 0x38
	private byte[] targetPixels; // 0x70
	private byte[] targetDrawTileTable; // 0x78
	private SimpleList<ushort> targetDrawTileList; // 0x80
	public bool ShowDebug; // 0x88
	private Material material; // 0x90
	private MaterialPropertyBlock block; // 0x98
	private Mesh mesh; // 0xA0
	private static Dictionary<Texture2D, WaterDynamics.InstanceBatch> Batches; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsInitialized>k__BackingField; // 0xA8
	public bool ForceFallback; // 0xA9
	private WaterDynamics.Target target; // 0xB0
	private bool useNativePath; // 0xB8
	private static HashSet<WaterInteraction> interactions; // 0x8

	// Properties
	public bool IsInitialized { get; set; }

	// Methods

	// RVA: 0x8061C0 Offset: 0x8047C0 VA: 0x1808061C0
	private void RasterBindImage(WaterDynamics.Image image) { }

	// RVA: 0x8062C0 Offset: 0x8048C0 VA: 0x1808062C0
	private void RasterBindTarget(WaterDynamics.Target target) { }

	// RVA: 0x8064C0 Offset: 0x804AC0 VA: 0x1808064C0
	private void RasterInteraction(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x805930 Offset: 0x803F30 VA: 0x180805930
	private float Frac(float x) { }

	// RVA: 0x807AF0 Offset: 0x8060F0 VA: 0x180807AF0
	private Vector2 Rotate2D(Vector2 v, float s, float c) { }

	// RVA: 0x805C30 Offset: 0x804230 VA: 0x180805C30
	private int Min3(int a, int b, int c) { }

	// RVA: 0x805BB0 Offset: 0x8041B0 VA: 0x180805BB0
	private int Max3(int a, int b, int c) { }

	// RVA: 0x8058F0 Offset: 0x803EF0 VA: 0x1808058F0
	private int EdgeFunction(WaterDynamics.Point2D a, WaterDynamics.Point2D b, WaterDynamics.Point2D c) { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	private bool IsTopLeft(WaterDynamics.Point2D a, WaterDynamics.Point2D b) { }

	// RVA: 0x8069E0 Offset: 0x804FE0 VA: 0x1808069E0
	private void RasterizeTriangle(WaterDynamics.Point2D p0, WaterDynamics.Point2D p1, WaterDynamics.Point2D p2, Vector2 uv0, Vector2 uv1, Vector2 uv2, byte disp, byte dist) { }

	// RVA: 0x806340 Offset: 0x804940 VA: 0x180806340
	private static extern void RasterClearTile_Native(ref byte pixels, int offset, int stride, int width, int height) { }

	// RVA: 0x806130 Offset: 0x804730 VA: 0x180806130
	private static extern void RasterBindImage_Native(ref WaterDynamics.ImageDesc desc, ref byte pixels) { }

	// RVA: 0x806200 Offset: 0x804800 VA: 0x180806200
	private static extern void RasterBindTarget_Native(ref WaterDynamics.TargetDesc desc, ref byte pixels, ref byte drawTileTable, ref ushort drawTileList, ref int drawTileCount) { }

	// RVA: 0x8063F0 Offset: 0x8049F0 VA: 0x1808063F0
	private static extern void RasterInteraction_Native(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x805950 Offset: 0x803F50 VA: 0x180805950
	public void InitializeRender() { }

	// RVA: 0x807B40 Offset: 0x806140 VA: 0x180807B40
	public void ShutdownRender() { }

	// RVA: 0x8056D0 Offset: 0x803CD0 VA: 0x1808056D0
	private Mesh CreateMesh() { }

	// RVA: 0x807780 Offset: 0x805D80 VA: 0x180807780
	private void RenderIssueBindTarget(WaterDynamics.Target target) { }

	// RVA: 0x8078B0 Offset: 0x805EB0 VA: 0x1808078B0
	private void RenderIssueInteraction(Texture2D texture, Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x8073D0 Offset: 0x8059D0 VA: 0x1808073D0
	private void RenderFlushInteractions() { }

	// RVA: -1 Offset: -1
	public static void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DA2E0 Offset: 0x5D88E0 VA: 0x1805DA2E0
	|-WaterDynamics.SafeDestroy<object>
	|-WaterDynamics.SafeDestroy<Material>
	|-WaterDynamics.SafeDestroy<Mesh>
	|-WaterDynamics.SafeDestroy<RenderTexture>
	*/

	// RVA: -1 Offset: -1
	public static T SafeDestroy<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BBBA0 Offset: 0x15BA1A0 VA: 0x1815BBBA0
	|-WaterDynamics.SafeDestroy<object>
	*/

	// RVA: -1 Offset: -1
	public static void SafeRelease<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DA380 Offset: 0x5D8980 VA: 0x1805DA380
	|-WaterDynamics.SafeRelease<object>
	|-WaterDynamics.SafeRelease<CommandBuffer>
	*/

	// RVA: -1 Offset: -1
	public static T SafeRelease<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BBC30 Offset: 0x15BA230 VA: 0x1815BBC30
	|-WaterDynamics.SafeRelease<object>
	|-WaterDynamics.SafeRelease<ComputeBuffer>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x808500 Offset: 0x806B00 VA: 0x180808500
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8084F0 Offset: 0x806AF0 VA: 0x1808084F0
	public bool get_IsInitialized() { }

	// RVA: 0x807350 Offset: 0x805950 VA: 0x180807350
	public static void RegisterInteraction(WaterInteraction interaction) { }

	// RVA: 0x8081E0 Offset: 0x8067E0 VA: 0x1808081E0
	public static void UnregisterInteraction(WaterInteraction interaction) { }

	// RVA: 0x807E00 Offset: 0x806400 VA: 0x180807E00
	private bool SupportsNativePath() { }

	// RVA: 0x805A20 Offset: 0x804020 VA: 0x180805A20
	public void Initialize(Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0x807F50 Offset: 0x806550 VA: 0x180807F50
	public bool TryInitialize() { }

	// RVA: 0x805CB0 Offset: 0x8042B0 VA: 0x180805CB0
	public void Shutdown() { }

	// RVA: 0x805E10 Offset: 0x804410 VA: 0x180805E10
	public void OnEnable() { }

	// RVA: 0x805CB0 Offset: 0x8042B0 VA: 0x180805CB0
	public void OnDisable() { }

	// RVA: 0x808260 Offset: 0x806860 VA: 0x180808260
	public void Update() { }

	// RVA: 0x805E20 Offset: 0x804420 VA: 0x180805E20
	private void ProcessInteractions() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0
	public float SampleHeight(Vector3 pos) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x808450 Offset: 0x806A50 VA: 0x180808450
	private static void .cctor() { }

}

public struct WaterDynamics.ImageDesc // TypeDefIndex: 10604
{	// Fields
	public int width; // 0x0
	public int height; // 0x4
	public int maxWidth; // 0x8
	public int maxHeight; // 0xC
	public int widthShift; // 0x10

	// Methods

	// RVA: 0xF8930 Offset: 0xF7D30 VA: 0x1800F8930
	public void .ctor(Texture2D tex) { }

	// RVA: 0xF8920 Offset: 0xF7D20 VA: 0x1800F8920
	public void Clear() { }

}

public class WaterDynamics.Image // TypeDefIndex: 10605
{	// Fields
	public WaterDynamics.ImageDesc desc; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Texture2D <texture>k__BackingField; // 0x28
	public byte[] pixels; // 0x30

	// Properties
	public Texture2D texture { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public Texture2D get_texture() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	private void set_texture(Texture2D value) { }

	// RVA: 0x7EE220 Offset: 0x7EC820 VA: 0x1807EE220
	public void .ctor(Texture2D tex) { }

	// RVA: 0x7EE130 Offset: 0x7EC730 VA: 0x1807EE130
	public void Destroy() { }

	// RVA: 0x7EE170 Offset: 0x7EC770 VA: 0x1807EE170
	private byte[] GetDisplacementPixelsFromTexture(Texture2D tex) { }

}

private struct WaterDynamics.Point2D // TypeDefIndex: 10606
{	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF8950 Offset: 0xF7D50 VA: 0x1800F8950
	public void .ctor(int x, int y) { }

	// RVA: 0xF8960 Offset: 0xF7D60 VA: 0x1800F8960
	public void .ctor(float x, float y) { }

}

public struct WaterDynamics.InstanceData // TypeDefIndex: 10607
{	// Fields
	public Vector4 PositionScale; // 0x0
	public Vector4 RotationDispDist; // 0x10

	// Methods

	// RVA: 0xF8940 Offset: 0xF7D40 VA: 0x1800F8940
	public void .ctor(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

}

private class WaterDynamics.InstanceBatch // TypeDefIndex: 10608
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Texture <Texture>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ComputeBuffer <ArgBuffer>k__BackingField; // 0x20
	private uint[] args; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ComputeBuffer <InstanceBuffer>k__BackingField; // 0x30
	private SimpleList<WaterDynamics.InstanceData> instances; // 0x38

	// Properties
	public Mesh Mesh { get; set; }
	public Texture Texture { get; set; }
	public ComputeBuffer ArgBuffer { get; set; }
	public ComputeBuffer InstanceBuffer { get; set; }
	public int Count { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Texture(Texture value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Texture get_Texture() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_ArgBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public ComputeBuffer get_ArgBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_InstanceBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ComputeBuffer get_InstanceBuffer() { }

	// RVA: 0x7EE8B0 Offset: 0x7ECEB0 VA: 0x1807EE8B0
	public int get_Count() { }

	// RVA: 0x7EE710 Offset: 0x7ECD10 VA: 0x1807EE710
	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x7EE410 Offset: 0x7ECA10 VA: 0x1807EE410
	public void Initialize(Mesh mesh, Texture texture) { }

	// RVA: 0x7EE630 Offset: 0x7ECC30 VA: 0x1807EE630
	public void Release() { }

	// RVA: 0x7EE3C0 Offset: 0x7EC9C0 VA: 0x1807EE3C0
	public void Clear() { }

	// RVA: 0x7EE350 Offset: 0x7EC950 VA: 0x1807EE350
	public void AddInstance(WaterDynamics.InstanceData data) { }

	// RVA: 0x7EE730 Offset: 0x7ECD30 VA: 0x1807EE730
	public void UpdateBuffers() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public struct WaterDynamics.TargetDesc // TypeDefIndex: 10609
{	// Fields
	public int size; // 0x0
	public int maxSize; // 0x4
	public int maxSizeSubStep; // 0x8
	public Vector2 areaOffset; // 0xC
	public Vector2 areaToMapUV; // 0x14
	public Vector2 areaToMapXY; // 0x1C
	public int tileSize; // 0x24
	public int tileSizeShift; // 0x28
	public int tileCount; // 0x2C
	public int tileMaxCount; // 0x30

	// Methods

	// RVA: 0xFEB60 Offset: 0xFDF60 VA: 0x1800FEB60
	public void .ctor(Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0xFE910 Offset: 0xFDD10 VA: 0x1800FE910
	public void Clear() { }

	// RVA: 0xFEA10 Offset: 0xFDE10 VA: 0x1800FEA10
	public ushort TileOffsetToXYOffset(ushort tileOffset, out int x, out int y, out int offset) { }

	// RVA: 0xFE9D0 Offset: 0xFDDD0 VA: 0x1800FE9D0
	public ushort TileOffsetToTileXYIndex(ushort tileOffset, out int tileX, out int tileY, out ushort tileIndex) { }

	// RVA: 0xFEA50 Offset: 0xFDE50 VA: 0x1800FEA50
	public Vector2 WorldToRaster(Vector2 pos) { }

	// RVA: 0xFEA80 Offset: 0xFDE80 VA: 0x1800FEA80
	public Vector3 WorldToRaster(Vector3 pos) { }

}

public class WaterDynamics.Target // TypeDefIndex: 10610
{	// Fields
	public WaterDynamics owner; // 0x10
	public WaterDynamics.TargetDesc desc; // 0x18
	private byte[] pixels; // 0x50
	private RenderTexture interactionTarget; // 0x58
	private RenderTexture combinedTarget; // 0x60
	private Camera commandBufferCamera; // 0x68
	private CommandBuffer commandBuffer; // 0x70
	private Material combineMaterial; // 0x78
	private byte[] clearTileTable; // 0x80
	private SimpleList<ushort> clearTileList; // 0x88
	private byte[] drawTileTable; // 0x90
	private SimpleList<ushort> drawTileList; // 0x98
	private const int MaxInteractionOffset = 100;
	private Vector3 prevCameraWorldPos; // 0xA0
	private Vector2i interactionOffset; // 0xAC

	// Properties
	public WaterDynamics.TargetDesc Desc { get; }
	public byte[] Pixels { get; }
	public RenderTexture InteractionTarget { get; }
	public RenderTexture CombinedTarget { get; }
	public CommandBuffer CommandBuffer { get; }
	public byte[] DrawTileTable { get; }
	public SimpleList<ushort> DrawTileList { get; }

	// Methods

	// RVA: 0x7EFC30 Offset: 0x7EE230 VA: 0x1807EFC30
	public WaterDynamics.TargetDesc get_Desc() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public byte[] get_Pixels() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public RenderTexture get_InteractionTarget() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public RenderTexture get_CombinedTarget() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public CommandBuffer get_CommandBuffer() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public byte[] get_DrawTileTable() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public SimpleList<ushort> get_DrawTileList() { }

	// RVA: 0x7EF9C0 Offset: 0x7EDFC0 VA: 0x1807EF9C0
	public void .ctor(WaterDynamics owner, Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0x7EED30 Offset: 0x7ED330 VA: 0x1807EED30
	public void Destroy() { }

	// RVA: 0x7EEBB0 Offset: 0x7ED1B0 VA: 0x1807EEBB0
	private Texture2D CreateDynamicTexture(int size) { }

	// RVA: 0x7EEC50 Offset: 0x7ED250 VA: 0x1807EEC50
	private RenderTexture CreateRenderTexture(int size) { }

	// RVA: 0x7EE990 Offset: 0x7ECF90 VA: 0x1807EE990
	public void ClearTiles() { }

	// RVA: 0x7EF2E0 Offset: 0x7ED8E0 VA: 0x1807EF2E0
	public void ProcessTiles() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void UpdateTiles() { }

	// RVA: 0x7EEE50 Offset: 0x7ED450 VA: 0x1807EEE50
	public void Prepare() { }

	// RVA: 0x7EF580 Offset: 0x7EDB80 VA: 0x1807EF580
	public void Update() { }

	// RVA: 0x7EF540 Offset: 0x7EDB40 VA: 0x1807EF540
	public void UpdateGlobalShaderProperties() { }

}

