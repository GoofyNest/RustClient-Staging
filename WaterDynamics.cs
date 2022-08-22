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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsInitialized>k__BackingField; // 0xA8
	public bool ForceFallback; // 0xA9
	private WaterDynamics.Target target; // 0xB0
	private bool useNativePath; // 0xB8
	private static HashSet<WaterInteraction> interactions; // 0x8

	// Properties
	public bool IsInitialized { get; set; }

	// Methods

	// RVA: 0x806860 Offset: 0x804E60 VA: 0x180806860
	private void RasterBindImage(WaterDynamics.Image image) { }

	// RVA: 0x806960 Offset: 0x804F60 VA: 0x180806960
	private void RasterBindTarget(WaterDynamics.Target target) { }

	// RVA: 0x806B60 Offset: 0x805160 VA: 0x180806B60
	private void RasterInteraction(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x805FD0 Offset: 0x8045D0 VA: 0x180805FD0
	private float Frac(float x) { }

	// RVA: 0x808190 Offset: 0x806790 VA: 0x180808190
	private Vector2 Rotate2D(Vector2 v, float s, float c) { }

	// RVA: 0x8062D0 Offset: 0x8048D0 VA: 0x1808062D0
	private int Min3(int a, int b, int c) { }

	// RVA: 0x806250 Offset: 0x804850 VA: 0x180806250
	private int Max3(int a, int b, int c) { }

	// RVA: 0x805F90 Offset: 0x804590 VA: 0x180805F90
	private int EdgeFunction(WaterDynamics.Point2D a, WaterDynamics.Point2D b, WaterDynamics.Point2D c) { }

	// RVA: 0x806230 Offset: 0x804830 VA: 0x180806230
	private bool IsTopLeft(WaterDynamics.Point2D a, WaterDynamics.Point2D b) { }

	// RVA: 0x807080 Offset: 0x805680 VA: 0x180807080
	private void RasterizeTriangle(WaterDynamics.Point2D p0, WaterDynamics.Point2D p1, WaterDynamics.Point2D p2, Vector2 uv0, Vector2 uv1, Vector2 uv2, byte disp, byte dist) { }

	// RVA: 0x8069E0 Offset: 0x804FE0 VA: 0x1808069E0
	private static extern void RasterClearTile_Native(ref byte pixels, int offset, int stride, int width, int height) { }

	// RVA: 0x8067D0 Offset: 0x804DD0 VA: 0x1808067D0
	private static extern void RasterBindImage_Native(ref WaterDynamics.ImageDesc desc, ref byte pixels) { }

	// RVA: 0x8068A0 Offset: 0x804EA0 VA: 0x1808068A0
	private static extern void RasterBindTarget_Native(ref WaterDynamics.TargetDesc desc, ref byte pixels, ref byte drawTileTable, ref ushort drawTileList, ref int drawTileCount) { }

	// RVA: 0x806A90 Offset: 0x805090 VA: 0x180806A90
	private static extern void RasterInteraction_Native(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x805FF0 Offset: 0x8045F0 VA: 0x180805FF0
	public void InitializeRender() { }

	// RVA: 0x8081E0 Offset: 0x8067E0 VA: 0x1808081E0
	public void ShutdownRender() { }

	// RVA: 0x805D70 Offset: 0x804370 VA: 0x180805D70
	private Mesh CreateMesh() { }

	// RVA: 0x807E20 Offset: 0x806420 VA: 0x180807E20
	private void RenderIssueBindTarget(WaterDynamics.Target target) { }

	// RVA: 0x807F50 Offset: 0x806550 VA: 0x180807F50
	private void RenderIssueInteraction(Texture2D texture, Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x807A70 Offset: 0x806070 VA: 0x180807A70
	private void RenderFlushInteractions() { }

	// RVA: -1 Offset: -1
	public static void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DA270 Offset: 0x5D8870 VA: 0x1805DA270
	|-WaterDynamics.SafeDestroy<object>
	|-WaterDynamics.SafeDestroy<Material>
	|-WaterDynamics.SafeDestroy<Mesh>
	|-WaterDynamics.SafeDestroy<RenderTexture>
	*/

	// RVA: -1 Offset: -1
	public static T SafeDestroy<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAF30 Offset: 0x15B9530 VA: 0x1815BAF30
	|-WaterDynamics.SafeDestroy<object>
	*/

	// RVA: -1 Offset: -1
	public static void SafeRelease<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DA310 Offset: 0x5D8910 VA: 0x1805DA310
	|-WaterDynamics.SafeRelease<object>
	|-WaterDynamics.SafeRelease<CommandBuffer>
	*/

	// RVA: -1 Offset: -1
	public static T SafeRelease<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAFC0 Offset: 0x15B95C0 VA: 0x1815BAFC0
	|-WaterDynamics.SafeRelease<object>
	|-WaterDynamics.SafeRelease<ComputeBuffer>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x808BA0 Offset: 0x8071A0 VA: 0x180808BA0
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x808B90 Offset: 0x807190 VA: 0x180808B90
	public bool get_IsInitialized() { }

	// RVA: 0x8079F0 Offset: 0x805FF0 VA: 0x1808079F0
	public static void RegisterInteraction(WaterInteraction interaction) { }

	// RVA: 0x808880 Offset: 0x806E80 VA: 0x180808880
	public static void UnregisterInteraction(WaterInteraction interaction) { }

	// RVA: 0x8084A0 Offset: 0x806AA0 VA: 0x1808084A0
	private bool SupportsNativePath() { }

	// RVA: 0x8060C0 Offset: 0x8046C0 VA: 0x1808060C0
	public void Initialize(Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0x8085F0 Offset: 0x806BF0 VA: 0x1808085F0
	public bool TryInitialize() { }

	// RVA: 0x806350 Offset: 0x804950 VA: 0x180806350
	public void Shutdown() { }

	// RVA: 0x8064B0 Offset: 0x804AB0 VA: 0x1808064B0
	public void OnEnable() { }

	// RVA: 0x806350 Offset: 0x804950 VA: 0x180806350
	public void OnDisable() { }

	// RVA: 0x808900 Offset: 0x806F00 VA: 0x180808900
	public void Update() { }

	// RVA: 0x8064C0 Offset: 0x804AC0 VA: 0x1808064C0
	private void ProcessInteractions() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670
	public float SampleHeight(Vector3 pos) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x808AF0 Offset: 0x8070F0 VA: 0x180808AF0
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

	// RVA: 0xF88B0 Offset: 0xF7CB0 VA: 0x1800F88B0
	public void .ctor(Texture2D tex) { }

	// RVA: 0xF88A0 Offset: 0xF7CA0 VA: 0x1800F88A0
	public void Clear() { }

}

public class WaterDynamics.Image // TypeDefIndex: 10605
{	// Fields
	public WaterDynamics.ImageDesc desc; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Texture2D <texture>k__BackingField; // 0x28
	public byte[] pixels; // 0x30

	// Properties
	public Texture2D texture { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public Texture2D get_texture() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	private void set_texture(Texture2D value) { }

	// RVA: 0x7EE8C0 Offset: 0x7ECEC0 VA: 0x1807EE8C0
	public void .ctor(Texture2D tex) { }

	// RVA: 0x7EE7D0 Offset: 0x7ECDD0 VA: 0x1807EE7D0
	public void Destroy() { }

	// RVA: 0x7EE810 Offset: 0x7ECE10 VA: 0x1807EE810
	private byte[] GetDisplacementPixelsFromTexture(Texture2D tex) { }

}

private struct WaterDynamics.Point2D // TypeDefIndex: 10606
{	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
	public void .ctor(int x, int y) { }

	// RVA: 0xF88E0 Offset: 0xF7CE0 VA: 0x1800F88E0
	public void .ctor(float x, float y) { }

}

public struct WaterDynamics.InstanceData // TypeDefIndex: 10607
{	// Fields
	public Vector4 PositionScale; // 0x0
	public Vector4 RotationDispDist; // 0x10

	// Methods

	// RVA: 0xF88C0 Offset: 0xF7CC0 VA: 0x1800F88C0
	public void .ctor(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

}

private class WaterDynamics.InstanceBatch // TypeDefIndex: 10608
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Texture <Texture>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ComputeBuffer <ArgBuffer>k__BackingField; // 0x20
	private uint[] args; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ComputeBuffer <InstanceBuffer>k__BackingField; // 0x30
	private SimpleList<WaterDynamics.InstanceData> instances; // 0x38

	// Properties
	public Mesh Mesh { get; set; }
	public Texture Texture { get; set; }
	public ComputeBuffer ArgBuffer { get; set; }
	public ComputeBuffer InstanceBuffer { get; set; }
	public int Count { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Texture(Texture value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Texture get_Texture() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_ArgBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public ComputeBuffer get_ArgBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_InstanceBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public ComputeBuffer get_InstanceBuffer() { }

	// RVA: 0x7EEF50 Offset: 0x7ED550 VA: 0x1807EEF50
	public int get_Count() { }

	// RVA: 0x7EEDB0 Offset: 0x7ED3B0 VA: 0x1807EEDB0
	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x7EEAB0 Offset: 0x7ED0B0 VA: 0x1807EEAB0
	public void Initialize(Mesh mesh, Texture texture) { }

	// RVA: 0x7EECD0 Offset: 0x7ED2D0 VA: 0x1807EECD0
	public void Release() { }

	// RVA: 0x7EEA60 Offset: 0x7ED060 VA: 0x1807EEA60
	public void Clear() { }

	// RVA: 0x7EE9F0 Offset: 0x7ECFF0 VA: 0x1807EE9F0
	public void AddInstance(WaterDynamics.InstanceData data) { }

	// RVA: 0x7EEDD0 Offset: 0x7ED3D0 VA: 0x1807EEDD0
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

	// RVA: 0xFEAE0 Offset: 0xFDEE0 VA: 0x1800FEAE0
	public void .ctor(Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0xFE890 Offset: 0xFDC90 VA: 0x1800FE890
	public void Clear() { }

	// RVA: 0xFE990 Offset: 0xFDD90 VA: 0x1800FE990
	public ushort TileOffsetToXYOffset(ushort tileOffset, out int x, out int y, out int offset) { }

	// RVA: 0xFE950 Offset: 0xFDD50 VA: 0x1800FE950
	public ushort TileOffsetToTileXYIndex(ushort tileOffset, out int tileX, out int tileY, out ushort tileIndex) { }

	// RVA: 0xFE9D0 Offset: 0xFDDD0 VA: 0x1800FE9D0
	public Vector2 WorldToRaster(Vector2 pos) { }

	// RVA: 0xFEA00 Offset: 0xFDE00 VA: 0x1800FEA00
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

	// RVA: 0x7F02D0 Offset: 0x7EE8D0 VA: 0x1807F02D0
	public WaterDynamics.TargetDesc get_Desc() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public byte[] get_Pixels() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public RenderTexture get_InteractionTarget() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public RenderTexture get_CombinedTarget() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public CommandBuffer get_CommandBuffer() { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public byte[] get_DrawTileTable() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public SimpleList<ushort> get_DrawTileList() { }

	// RVA: 0x7F0060 Offset: 0x7EE660 VA: 0x1807F0060
	public void .ctor(WaterDynamics owner, Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0x7EF3D0 Offset: 0x7ED9D0 VA: 0x1807EF3D0
	public void Destroy() { }

	// RVA: 0x7EF250 Offset: 0x7ED850 VA: 0x1807EF250
	private Texture2D CreateDynamicTexture(int size) { }

	// RVA: 0x7EF2F0 Offset: 0x7ED8F0 VA: 0x1807EF2F0
	private RenderTexture CreateRenderTexture(int size) { }

	// RVA: 0x7EF030 Offset: 0x7ED630 VA: 0x1807EF030
	public void ClearTiles() { }

	// RVA: 0x7EF980 Offset: 0x7EDF80 VA: 0x1807EF980
	public void ProcessTiles() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void UpdateTiles() { }

	// RVA: 0x7EF4F0 Offset: 0x7EDAF0 VA: 0x1807EF4F0
	public void Prepare() { }

	// RVA: 0x7EFC20 Offset: 0x7EE220 VA: 0x1807EFC20
	public void Update() { }

	// RVA: 0x7EFBE0 Offset: 0x7EE1E0 VA: 0x1807EFBE0
	public void UpdateGlobalShaderProperties() { }

}

