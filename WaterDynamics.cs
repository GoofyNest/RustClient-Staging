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

	// RVA: 0x8062D0 Offset: 0x8048D0 VA: 0x1808062D0
	private void RasterBindImage(WaterDynamics.Image image) { }

	// RVA: 0x8063D0 Offset: 0x8049D0 VA: 0x1808063D0
	private void RasterBindTarget(WaterDynamics.Target target) { }

	// RVA: 0x8065D0 Offset: 0x804BD0 VA: 0x1808065D0
	private void RasterInteraction(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x805A40 Offset: 0x804040 VA: 0x180805A40
	private float Frac(float x) { }

	// RVA: 0x807C00 Offset: 0x806200 VA: 0x180807C00
	private Vector2 Rotate2D(Vector2 v, float s, float c) { }

	// RVA: 0x805D40 Offset: 0x804340 VA: 0x180805D40
	private int Min3(int a, int b, int c) { }

	// RVA: 0x805CC0 Offset: 0x8042C0 VA: 0x180805CC0
	private int Max3(int a, int b, int c) { }

	// RVA: 0x805A00 Offset: 0x804000 VA: 0x180805A00
	private int EdgeFunction(WaterDynamics.Point2D a, WaterDynamics.Point2D b, WaterDynamics.Point2D c) { }

	// RVA: 0x805CA0 Offset: 0x8042A0 VA: 0x180805CA0
	private bool IsTopLeft(WaterDynamics.Point2D a, WaterDynamics.Point2D b) { }

	// RVA: 0x806AF0 Offset: 0x8050F0 VA: 0x180806AF0
	private void RasterizeTriangle(WaterDynamics.Point2D p0, WaterDynamics.Point2D p1, WaterDynamics.Point2D p2, Vector2 uv0, Vector2 uv1, Vector2 uv2, byte disp, byte dist) { }

	// RVA: 0x806450 Offset: 0x804A50 VA: 0x180806450
	private static extern void RasterClearTile_Native(ref byte pixels, int offset, int stride, int width, int height) { }

	// RVA: 0x806240 Offset: 0x804840 VA: 0x180806240
	private static extern void RasterBindImage_Native(ref WaterDynamics.ImageDesc desc, ref byte pixels) { }

	// RVA: 0x806310 Offset: 0x804910 VA: 0x180806310
	private static extern void RasterBindTarget_Native(ref WaterDynamics.TargetDesc desc, ref byte pixels, ref byte drawTileTable, ref ushort drawTileList, ref int drawTileCount) { }

	// RVA: 0x806500 Offset: 0x804B00 VA: 0x180806500
	private static extern void RasterInteraction_Native(Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x805A60 Offset: 0x804060 VA: 0x180805A60
	public void InitializeRender() { }

	// RVA: 0x807C50 Offset: 0x806250 VA: 0x180807C50
	public void ShutdownRender() { }

	// RVA: 0x8057E0 Offset: 0x803DE0 VA: 0x1808057E0
	private Mesh CreateMesh() { }

	// RVA: 0x807890 Offset: 0x805E90 VA: 0x180807890
	private void RenderIssueBindTarget(WaterDynamics.Target target) { }

	// RVA: 0x8079C0 Offset: 0x805FC0 VA: 0x1808079C0
	private void RenderIssueInteraction(Texture2D texture, Vector2 pos, Vector2 scale, float rotation, float disp, float dist) { }

	// RVA: 0x8074E0 Offset: 0x805AE0 VA: 0x1808074E0
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
	|-RVA: 0x15BBE60 Offset: 0x15BA460 VA: 0x1815BBE60
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
	|-RVA: 0x15BBEF0 Offset: 0x15BA4F0 VA: 0x1815BBEF0
	|-WaterDynamics.SafeRelease<object>
	|-WaterDynamics.SafeRelease<ComputeBuffer>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x808610 Offset: 0x806C10 VA: 0x180808610
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x808600 Offset: 0x806C00 VA: 0x180808600
	public bool get_IsInitialized() { }

	// RVA: 0x807460 Offset: 0x805A60 VA: 0x180807460
	public static void RegisterInteraction(WaterInteraction interaction) { }

	// RVA: 0x8082F0 Offset: 0x8068F0 VA: 0x1808082F0
	public static void UnregisterInteraction(WaterInteraction interaction) { }

	// RVA: 0x807F10 Offset: 0x806510 VA: 0x180807F10
	private bool SupportsNativePath() { }

	// RVA: 0x805B30 Offset: 0x804130 VA: 0x180805B30
	public void Initialize(Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0x808060 Offset: 0x806660 VA: 0x180808060
	public bool TryInitialize() { }

	// RVA: 0x805DC0 Offset: 0x8043C0 VA: 0x180805DC0
	public void Shutdown() { }

	// RVA: 0x805F20 Offset: 0x804520 VA: 0x180805F20
	public void OnEnable() { }

	// RVA: 0x805DC0 Offset: 0x8043C0 VA: 0x180805DC0
	public void OnDisable() { }

	// RVA: 0x808370 Offset: 0x806970 VA: 0x180808370
	public void Update() { }

	// RVA: 0x805F30 Offset: 0x804530 VA: 0x180805F30
	private void ProcessInteractions() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0
	public float SampleHeight(Vector3 pos) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x808560 Offset: 0x806B60 VA: 0x180808560
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
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public Texture2D get_texture() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	private void set_texture(Texture2D value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public void .ctor(Texture2D tex) { }

	// RVA: 0x7EE240 Offset: 0x7EC840 VA: 0x1807EE240
	public void Destroy() { }

	// RVA: 0x7EE280 Offset: 0x7EC880 VA: 0x1807EE280
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
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
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
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_InstanceBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ComputeBuffer get_InstanceBuffer() { }

	// RVA: 0x7EE9C0 Offset: 0x7ECFC0 VA: 0x1807EE9C0
	public int get_Count() { }

	// RVA: 0x7EE820 Offset: 0x7ECE20 VA: 0x1807EE820
	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x7EE520 Offset: 0x7ECB20 VA: 0x1807EE520
	public void Initialize(Mesh mesh, Texture texture) { }

	// RVA: 0x7EE740 Offset: 0x7ECD40 VA: 0x1807EE740
	public void Release() { }

	// RVA: 0x7EE4D0 Offset: 0x7ECAD0 VA: 0x1807EE4D0
	public void Clear() { }

	// RVA: 0x7EE460 Offset: 0x7ECA60 VA: 0x1807EE460
	public void AddInstance(WaterDynamics.InstanceData data) { }

	// RVA: 0x7EE840 Offset: 0x7ECE40 VA: 0x1807EE840
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

	// RVA: 0x7EFD40 Offset: 0x7EE340 VA: 0x1807EFD40
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

	// RVA: 0x7EFAD0 Offset: 0x7EE0D0 VA: 0x1807EFAD0
	public void .ctor(WaterDynamics owner, Vector3 areaPosition, Vector3 areaSize) { }

	// RVA: 0x7EEE40 Offset: 0x7ED440 VA: 0x1807EEE40
	public void Destroy() { }

	// RVA: 0x7EECC0 Offset: 0x7ED2C0 VA: 0x1807EECC0
	private Texture2D CreateDynamicTexture(int size) { }

	// RVA: 0x7EED60 Offset: 0x7ED360 VA: 0x1807EED60
	private RenderTexture CreateRenderTexture(int size) { }

	// RVA: 0x7EEAA0 Offset: 0x7ED0A0 VA: 0x1807EEAA0
	public void ClearTiles() { }

	// RVA: 0x7EF3F0 Offset: 0x7ED9F0 VA: 0x1807EF3F0
	public void ProcessTiles() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void UpdateTiles() { }

	// RVA: 0x7EEF60 Offset: 0x7ED560 VA: 0x1807EEF60
	public void Prepare() { }

	// RVA: 0x7EF690 Offset: 0x7EDC90 VA: 0x1807EF690
	public void Update() { }

	// RVA: 0x7EF650 Offset: 0x7EDC50 VA: 0x1807EF650
	public void UpdateGlobalShaderProperties() { }

}

