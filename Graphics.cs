public class Graphics // TypeDefIndex: 3389
{	internal static readonly int kMaxDrawMeshInstanceCount; // 0x2B1083C

	public static RenderBuffer activeColorBuffer { get; }
	public static RenderBuffer activeDepthBuffer { get; }


	[FreeFunctionAttribute] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunctionAttribute] // RVA: 0x84750 Offset: 0x83B50 VA: 0x180084750
	private static RenderBuffer GetActiveColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x84800 Offset: 0x83C00 VA: 0x180084800
	private static RenderBuffer GetActiveDepthBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x848E0 Offset: 0x83CE0 VA: 0x1800848E0
	private static void Internal_SetNullRT() { }

	[NativeMethodAttribute] // RVA: 0x84AA0 Offset: 0x83EA0 VA: 0x180084AA0
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x84B30 Offset: 0x83F30 VA: 0x180084B30
	private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[StaticAccessorAttribute] // RVA: 0x84D30 Offset: 0x84130 VA: 0x180084D30
	public static void ClearRandomWriteTargets() { }

	[FreeFunctionAttribute] // RVA: 0x84EC0 Offset: 0x842C0 VA: 0x180084EC0
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x84FE0 Offset: 0x843E0 VA: 0x180084FE0
	[FreeFunctionAttribute] // RVA: 0x84FE0 Offset: 0x843E0 VA: 0x180084FE0
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunctionAttribute] // RVA: 0x85470 Offset: 0x84870 VA: 0x180085470
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x85620 Offset: 0x84A20 VA: 0x180085620
	private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x85750 Offset: 0x84B50 VA: 0x180085750
	private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[FreeFunctionAttribute] // RVA: 0x85820 Offset: 0x84C20 VA: 0x180085820
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunctionAttribute] // RVA: 0x85A50 Offset: 0x84E50 VA: 0x180085A50
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[FreeFunctionAttribute] // RVA: 0x85C90 Offset: 0x85090 VA: 0x180085C90
	private static void Blit2(Texture source, RenderTexture dest) { }

	[NativeMethodAttribute] // RVA: 0x85DA0 Offset: 0x851A0 VA: 0x180085DA0
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	public static RenderBuffer get_activeColorBuffer() { }

	public static RenderBuffer get_activeDepthBuffer() { }

	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass) { }

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass) { }

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0) { }

	public static void Blit(Texture source, RenderTexture dest) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	public static void Blit(Texture source, Material mat, int pass) { }

	public static void Blit(Texture source, Material mat) { }

	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DrawTexture(Rect screenRect, Texture texture) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetRenderTarget(RenderTexture rt) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav) { }

	private static void .cctor() { }

	private static void GetActiveColorBuffer_Injected(out RenderBuffer ret) { }

	private static void GetActiveDepthBuffer_Injected(out RenderBuffer ret) { }

	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	private static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

}

public static class Graphics // TypeDefIndex: 8219
{
	public static extern IntPtr GetRenderEventFunc() { }

}

public static class Graphics.BufferReadback // TypeDefIndex: 8220
{
	public static extern IntPtr CreateForTexture(IntPtr tex, uint width, uint height, uint format) { }

	public static extern IntPtr CreateForBuffer(IntPtr buf, uint size) { }

	public static extern void Destroy(IntPtr inst) { }

	public static extern void IssueRead(IntPtr inst) { }

	public static extern uint GetDataSize(IntPtr inst) { }

	public static extern uint GetDataStride(IntPtr inst) { }

	public static extern void GetData(IntPtr inst, ref byte data) { }

	public static extern void GetData(IntPtr inst, ref Color32 data) { }

	public static extern void GetData(IntPtr inst, ref float data) { }

}

public class Graphics : ConsoleSystem // TypeDefIndex: 11928
{	private const float MinShadowDistance = 100;
	private const float MaxShadowDistance2Split = 600;
	private const float MaxShadowDistance4Split = 1000;
	private static float _shadowdistance; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int shadowmode; // 0x4
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int shadowlights; // 0x8
	private static int _shadowquality; // 0xC
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool grassshadows; // 0x10
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool contactshadows; // 0x11
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float drawdistance; // 0x14
	private static float _fov; // 0x18
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool hud; // 0x1C
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool chat; // 0x1D
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool branding; // 0x1E
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int compass; // 0x20
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool dof; // 0x24
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float dof_aper; // 0x28
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float dof_blur; // 0x2C
	[ClientVar] // RVA: 0xA28D0 Offset: 0xA1CD0 VA: 0x1800A28D0
	public static int dof_mode; // 0x30
	[ClientVar] // RVA: 0xA29C0 Offset: 0xA1DC0 VA: 0x1800A29C0
	public static float dof_focus_dist; // 0x34
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float dof_focus_time; // 0x38
	[ClientVar] // RVA: 0xA2A30 Offset: 0xA1E30 VA: 0x1800A2A30
	public static bool dof_debug; // 0x3C
	public static BaseEntity dof_focus_target_entity; // 0x40
	[ClientVar] // RVA: 0xA2B00 Offset: 0xA1F00 VA: 0x1800A2B00
	public static bool vm_fov_scale; // 0x48
	[ClientVar] // RVA: 0xA2C30 Offset: 0xA2030 VA: 0x1800A2C30
	public static bool vm_horizontal_flip; // 0x49
	private static int _resolution; // 0x4C
	private static List<Resolution> uniqueResolutions; // 0x50
	private static bool firstResolutionSet; // 0x58
	private static int _screenmode; // 0x5C
	private static float _uiscale; // 0x60
	private static int _anisotropic; // 0x64
	private static int _parallax; // 0x68
	private static bool _impostorshadows; // 0x6C
	private static int _showtexeldensity; // 0x70
	private static bool _waves; // 0x74
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool viewModelCamera; // 0x75
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool viewModelDepth; // 0x76
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int reflexMode; // 0x78
	[ClientVar] // RVA: 0xA2DF0 Offset: 0xA21F0 VA: 0x1800A2DF0
	public static int reflexIntervalUs; // 0x7C
	[ClientVar] // RVA: 0x89230 Offset: 0x88630 VA: 0x180089230
	public static bool reflexLatencyMarker; // 0x80
	[ClientVar] // RVA: 0x89230 Offset: 0x88630 VA: 0x180089230
	public static bool useMarkersToOptimize; // 0x81
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int dlss; // 0x84
	private static float _renderScale; // 0x88
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float jitterSpread; // 0x8C
	[ClientVar] // RVA: 0xA2FE0 Offset: 0xA23E0 VA: 0x1800A2FE0
	public static bool disableLightLod; // 0x90
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool aggressiveShadowLod; // 0x91
	private static bool _aggressiveShadowLodWearable; // 0x92

	[ClientVar] // RVA: 0xA36C0 Offset: 0xA2AC0 VA: 0x1800A36C0
	public static int quality { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float shadowdistance { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int shadowcascades { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int shadowquality { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float fov { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float lodbias { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int shaderlod { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int vsync { get; set; }
	[ClientVar] // RVA: 0xA3B90 Offset: 0xA2F90 VA: 0x1800A3B90
	public static int resolution { get; set; }
	[ClientVar] // RVA: 0xA3C30 Offset: 0xA3030 VA: 0x1800A3C30
	public static int screenmode { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float uiscale { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int af { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int parallax { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool itemskins { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool itemskinunload { get; set; }
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float itemskintimeout { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool impostorshadows { get; set; }
	[ClientVar] // RVA: 0xA44C0 Offset: 0xA38C0 VA: 0x1800A44C0
	public static int showtexeldensity { get; set; }
	[ClientVar] // RVA: 0xA4620 Offset: 0xA3A20 VA: 0x1800A4620
	public static bool waves { get; set; }
	[ClientVar] // RVA: 0xA4750 Offset: 0xA3B50 VA: 0x1800A4750
	public static int maxQueuedFrames { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float renderScale { get; set; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool aggressiveShadowLodWearable { get; set; }


	public static int get_quality() { }

	public static void set_quality(int value) { }

	public static float EnforceShadowDistanceBounds(float distance) { }

	public static float get_shadowdistance() { }

	public static void set_shadowdistance(float value) { }

	public static int get_shadowcascades() { }

	public static void set_shadowcascades(int value) { }

	public static int get_shadowquality() { }

	public static void set_shadowquality(int value) { }

	public static float get_fov() { }

	public static void set_fov(float value) { }

	public static float get_lodbias() { }

	public static void set_lodbias(float value) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static void dof_focus_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void dof_nudge(ConsoleSystem.Arg arg) { }

	public static int get_shaderlod() { }

	public static void set_shaderlod(int value) { }

	public static int get_vsync() { }

	public static void set_vsync(int value) { }

	[ClientVar] // RVA: 0xA33C0 Offset: 0xA27C0 VA: 0x1800A33C0
	public static void resolutions(ConsoleSystem.Arg arg) { }

	public static int get_resolution() { }

	public static void set_resolution(int value) { }

	public static List<Resolution> GetUniqueResolutions() { }

	private static void CacheResolutions() { }

	public static int get_screenmode() { }

	public static void set_screenmode(int value) { }

	private static void ApplyScreenSettings() { }

	private static FullScreenMode GetScreenMode() { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static void dof_focus_lookingat(ConsoleSystem.Arg arg) { }

	public static float get_uiscale() { }

	public static void set_uiscale(float value) { }

	public static int get_af() { }

	public static void set_af(int value) { }

	public static int get_parallax() { }

	public static void set_parallax(int value) { }

	public static bool get_itemskins() { }

	public static void set_itemskins(bool value) { }

	public static bool get_itemskinunload() { }

	public static void set_itemskinunload(bool value) { }

	public static float get_itemskintimeout() { }

	public static void set_itemskintimeout(float value) { }

	public static bool get_impostorshadows() { }

	public static void set_impostorshadows(bool value) { }

	public static int get_showtexeldensity() { }

	public static void set_showtexeldensity(int value) { }

	public static bool get_waves() { }

	public static void set_waves(bool value) { }

	public static int get_maxQueuedFrames() { }

	public static void set_maxQueuedFrames(int value) { }

	public static float get_renderScale() { }

	public static void set_renderScale(float value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void SetMipMapBias(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static void ResetMipMapBias() { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static void ReportShadowCasters(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static void ReportParticleSystems(ConsoleSystem.Arg arg) { }

	public static bool get_aggressiveShadowLodWearable() { }

	public static void set_aggressiveShadowLodWearable(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Graphics.<>c // TypeDefIndex: 11929
{	public static readonly Graphics.<>c <>9; // 0x0
	public static Func<Resolution, Vector2Int> <>9__60_0; // 0x8
	public static Func<Resolution, int> <>9__60_4; // 0x10
	public static Func<IGrouping<Vector2Int, Resolution>, Resolution> <>9__60_1; // 0x18
	public static Func<Resolution, int> <>9__60_2; // 0x20
	public static Func<Resolution, int> <>9__60_3; // 0x28


	private static void .cctor() { }

	public void .ctor() { }

	internal Vector2Int <CacheResolutions>b__60_0(Resolution r) { }

	internal Resolution <CacheResolutions>b__60_1(IGrouping<Vector2Int, Resolution> g) { }

	internal int <CacheResolutions>b__60_4(Resolution r) { }

	internal int <CacheResolutions>b__60_2(Resolution r) { }

	internal int <CacheResolutions>b__60_3(Resolution r) { }

}

