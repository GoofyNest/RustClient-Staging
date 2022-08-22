public class Graphics // TypeDefIndex: 3389
{	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x2B1083C

	// Properties
	public static RenderBuffer activeColorBuffer { get; }
	public static RenderBuffer activeDepthBuffer { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	// RVA: 0x181C660 Offset: 0x181AC60 VA: 0x18181C660
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunctionAttribute] // RVA: 0x84750 Offset: 0x83B50 VA: 0x180084750
	// RVA: 0x181BFB0 Offset: 0x181A5B0 VA: 0x18181BFB0
	private static RenderBuffer GetActiveColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x84800 Offset: 0x83C00 VA: 0x180084800
	// RVA: 0x181C070 Offset: 0x181A670 VA: 0x18181C070
	private static RenderBuffer GetActiveDepthBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x848E0 Offset: 0x83CE0 VA: 0x1800848E0
	// RVA: 0x181C690 Offset: 0x181AC90 VA: 0x18181C690
	private static void Internal_SetNullRT() { }

	[NativeMethodAttribute] // RVA: 0x84AA0 Offset: 0x83EA0 VA: 0x180084AA0
	// RVA: 0x181C730 Offset: 0x181AD30 VA: 0x18181C730
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x84B30 Offset: 0x83F30 VA: 0x180084B30
	// RVA: 0x181C7E0 Offset: 0x181ADE0 VA: 0x18181C7E0
	private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[StaticAccessorAttribute] // RVA: 0x84D30 Offset: 0x84130 VA: 0x180084D30
	// RVA: 0x181A660 Offset: 0x1818C60 VA: 0x18181A660
	public static void ClearRandomWriteTargets() { }

	[FreeFunctionAttribute] // RVA: 0x84EC0 Offset: 0x842C0 VA: 0x180084EC0
	// RVA: 0x181C3B0 Offset: 0x181A9B0 VA: 0x18181C3B0
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x84FE0 Offset: 0x843E0 VA: 0x180084FE0
	[FreeFunctionAttribute] // RVA: 0x84FE0 Offset: 0x843E0 VA: 0x180084FE0
	// RVA: 0x181C620 Offset: 0x181AC20 VA: 0x18181C620
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunctionAttribute] // RVA: 0x85470 Offset: 0x84870 VA: 0x180085470
	// RVA: 0x181C4C0 Offset: 0x181AAC0 VA: 0x18181C4C0
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x85620 Offset: 0x84A20 VA: 0x180085620
	// RVA: 0x181C250 Offset: 0x181A850 VA: 0x18181C250
	private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x85750 Offset: 0x84B50 VA: 0x180085750
	// RVA: 0x181C5D0 Offset: 0x181ABD0 VA: 0x18181C5D0
	private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[FreeFunctionAttribute] // RVA: 0x85820 Offset: 0x84C20 VA: 0x180085820
	// RVA: 0x181C0F0 Offset: 0x181A6F0 VA: 0x18181C0F0
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunctionAttribute] // RVA: 0x85A50 Offset: 0x84E50 VA: 0x180085A50
	// RVA: 0x181C160 Offset: 0x181A760 VA: 0x18181C160
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[FreeFunctionAttribute] // RVA: 0x85C90 Offset: 0x85090 VA: 0x180085C90
	// RVA: 0x181A1B0 Offset: 0x18187B0 VA: 0x18181A1B0
	private static void Blit2(Texture source, RenderTexture dest) { }

	[NativeMethodAttribute] // RVA: 0x85DA0 Offset: 0x851A0 VA: 0x180085DA0
	// RVA: 0x181BF30 Offset: 0x181A530 VA: 0x18181BF30
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0x181CB80 Offset: 0x181B180 VA: 0x18181CB80
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x181CC80 Offset: 0x181B280 VA: 0x18181CC80
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x181CF40 Offset: 0x181B540 VA: 0x18181CF40
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x181D0D0 Offset: 0x181B6D0 VA: 0x18181D0D0
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x181D350 Offset: 0x181B950 VA: 0x18181D350
	public static RenderBuffer get_activeColorBuffer() { }

	// RVA: 0x181D420 Offset: 0x181BA20 VA: 0x18181D420
	public static RenderBuffer get_activeDepthBuffer() { }

	// RVA: 0x181C840 Offset: 0x181AE40 VA: 0x18181C840
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	// RVA: 0x181B840 Offset: 0x1819E40 VA: 0x18181B840
	private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass) { }

	// RVA: 0x181BAD0 Offset: 0x181A0D0 VA: 0x18181BAD0
	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	// RVA: 0x181B9C0 Offset: 0x1819FC0 VA: 0x18181B9C0
	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	// RVA: 0x181BCA0 Offset: 0x181A2A0 VA: 0x18181BCA0
	public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass) { }

	// RVA: 0x181AB50 Offset: 0x1819150 VA: 0x18181AB50
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x181ACB0 Offset: 0x18192B0 VA: 0x18181ACB0
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x181B590 Offset: 0x1819B90 VA: 0x18181B590
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x181A7A0 Offset: 0x1818DA0 VA: 0x18181A7A0
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x181B780 Offset: 0x1819D80 VA: 0x18181B780
	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0) { }

	// RVA: 0x181A500 Offset: 0x1818B00 VA: 0x18181A500
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x181A460 Offset: 0x1818A60 VA: 0x18181A460
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x181A580 Offset: 0x1818B80 VA: 0x18181A580
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x181A3C0 Offset: 0x18189C0 VA: 0x18181A3C0
	public static void Blit(Texture source, Material mat, int pass) { }

	// RVA: 0x181A2F0 Offset: 0x18188F0 VA: 0x18181A2F0
	public static void Blit(Texture source, Material mat) { }

	// RVA: 0x181A200 Offset: 0x1818800 VA: 0x18181A200
	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181B300 Offset: 0x1819900 VA: 0x18181B300
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181B180 Offset: 0x1819780 VA: 0x18181B180
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181AE40 Offset: 0x1819440 VA: 0x18181AE40
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181AFD0 Offset: 0x18195D0 VA: 0x18181AFD0
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181A690 Offset: 0x1818C90 VA: 0x18181A690
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181BDD0 Offset: 0x181A3D0 VA: 0x18181BDD0
	public static void DrawTexture(Rect screenRect, Texture texture) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D210 Offset: 0x181B810 VA: 0x18181D210
	public static void SetRenderTarget(RenderTexture rt) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181D280 Offset: 0x181B880 VA: 0x18181D280
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181CDE0 Offset: 0x181B3E0 VA: 0x18181CDE0
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181C9D0 Offset: 0x181AFD0 VA: 0x18181C9D0
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav) { }

	// RVA: 0x181D2F0 Offset: 0x181B8F0 VA: 0x18181D2F0
	private static void .cctor() { }

	// RVA: 0x181BF70 Offset: 0x181A570 VA: 0x18181BF70
	private static void GetActiveColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x181C030 Offset: 0x181A630 VA: 0x18181C030
	private static void GetActiveDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x181C6C0 Offset: 0x181ACC0 VA: 0x18181C6C0
	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x181C360 Offset: 0x181A960 VA: 0x18181C360
	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

	// RVA: 0x181C440 Offset: 0x181AA40 VA: 0x18181C440
	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x181C1D0 Offset: 0x181A7D0 VA: 0x18181C1D0
	private static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

}

public static class Graphics // TypeDefIndex: 8219
{	// Methods

	// RVA: 0x106D530 Offset: 0x106BB30 VA: 0x18106D530
	public static extern IntPtr GetRenderEventFunc() { }

}

public static class Graphics.BufferReadback // TypeDefIndex: 8220
{	// Methods

	// RVA: 0x1068F10 Offset: 0x1067510 VA: 0x181068F10
	public static extern IntPtr CreateForTexture(IntPtr tex, uint width, uint height, uint format) { }

	// RVA: 0x1068E80 Offset: 0x1067480 VA: 0x181068E80
	public static extern IntPtr CreateForBuffer(IntPtr buf, uint size) { }

	// RVA: 0x1068FB0 Offset: 0x10675B0 VA: 0x181068FB0
	public static extern void Destroy(IntPtr inst) { }

	// RVA: 0x10692E0 Offset: 0x10678E0 VA: 0x1810692E0
	public static extern void IssueRead(IntPtr inst) { }

	// RVA: 0x1069030 Offset: 0x1067630 VA: 0x181069030
	public static extern uint GetDataSize(IntPtr inst) { }

	// RVA: 0x10690B0 Offset: 0x10676B0 VA: 0x1810690B0
	public static extern uint GetDataStride(IntPtr inst) { }

	// RVA: 0x1069250 Offset: 0x1067850 VA: 0x181069250
	public static extern void GetData(IntPtr inst, ref byte data) { }

	// RVA: 0x10691C0 Offset: 0x10677C0 VA: 0x1810691C0
	public static extern void GetData(IntPtr inst, ref Color32 data) { }

	// RVA: 0x1069130 Offset: 0x1067730 VA: 0x181069130
	public static extern void GetData(IntPtr inst, ref float data) { }

}

public class Graphics : ConsoleSystem // TypeDefIndex: 11928
{	// Fields
	private const float MinShadowDistance = 100;
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

	// Properties
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

	// Methods

	// RVA: 0x6E56F0 Offset: 0x6E3CF0 VA: 0x1806E56F0
	public static int get_quality() { }

	// RVA: 0x6E6410 Offset: 0x6E4A10 VA: 0x1806E6410
	public static void set_quality(int value) { }

	// RVA: 0x6E4100 Offset: 0x6E2700 VA: 0x1806E4100
	public static float EnforceShadowDistanceBounds(float distance) { }

	// RVA: 0x6E5840 Offset: 0x6E3E40 VA: 0x1806E5840
	public static float get_shadowdistance() { }

	// RVA: 0x6E6A40 Offset: 0x6E5040 VA: 0x1806E6A40
	public static void set_shadowdistance(float value) { }

	// RVA: 0x6E5830 Offset: 0x6E3E30 VA: 0x1806E5830
	public static int get_shadowcascades() { }

	// RVA: 0x6E6980 Offset: 0x6E4F80 VA: 0x1806E6980
	public static void set_shadowcascades(int value) { }

	// RVA: 0x6E58A0 Offset: 0x6E3EA0 VA: 0x1806E58A0
	public static int get_shadowquality() { }

	// RVA: 0x6E6AC0 Offset: 0x6E50C0 VA: 0x1806E6AC0
	public static void set_shadowquality(int value) { }

	// RVA: 0x6E5490 Offset: 0x6E3A90 VA: 0x1806E5490
	public static float get_fov() { }

	// RVA: 0x6E6080 Offset: 0x6E4680 VA: 0x1806E6080
	public static void set_fov(float value) { }

	// RVA: 0x6E5670 Offset: 0x6E3C70 VA: 0x1806E5670
	public static float get_lodbias() { }

	// RVA: 0x6E62F0 Offset: 0x6E48F0 VA: 0x1806E62F0
	public static void set_lodbias(float value) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6E5100 Offset: 0x6E3700 VA: 0x1806E5100
	public static void dof_focus_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E52F0 Offset: 0x6E38F0 VA: 0x1806E52F0
	public static void dof_nudge(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E5820 Offset: 0x6E3E20 VA: 0x1806E5820
	public static int get_shaderlod() { }

	// RVA: 0x6E6910 Offset: 0x6E4F10 VA: 0x1806E6910
	public static void set_shaderlod(int value) { }

	// RVA: 0x6E5B00 Offset: 0x6E4100 VA: 0x1806E5B00
	public static int get_vsync() { }

	// RVA: 0x6E6D90 Offset: 0x6E5390 VA: 0x1806E6D90
	public static void set_vsync(int value) { }

	[ClientVar] // RVA: 0xA33C0 Offset: 0xA27C0 VA: 0x1800A33C0
	// RVA: 0x6E5B70 Offset: 0x6E4170 VA: 0x1806E5B70
	public static void resolutions(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E5760 Offset: 0x6E3D60 VA: 0x1806E5760
	public static int get_resolution() { }

	// RVA: 0x6E65E0 Offset: 0x6E4BE0 VA: 0x1806E65E0
	public static void set_resolution(int value) { }

	// RVA: 0x6E4250 Offset: 0x6E2850 VA: 0x1806E4250
	public static List<Resolution> GetUniqueResolutions() { }

	// RVA: 0x6E3D80 Offset: 0x6E2380 VA: 0x1806E3D80
	private static void CacheResolutions() { }

	// RVA: 0x6E57C0 Offset: 0x6E3DC0 VA: 0x1806E57C0
	public static int get_screenmode() { }

	// RVA: 0x6E6880 Offset: 0x6E4E80 VA: 0x1806E6880
	public static void set_screenmode(int value) { }

	// RVA: 0x6E3BD0 Offset: 0x6E21D0 VA: 0x1806E3BD0
	private static void ApplyScreenSettings() { }

	// RVA: 0x6E41D0 Offset: 0x6E27D0 VA: 0x1806E41D0
	private static FullScreenMode GetScreenMode() { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6E5060 Offset: 0x6E3660 VA: 0x1806E5060
	public static void dof_focus_lookingat(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E5AA0 Offset: 0x6E40A0 VA: 0x1806E5AA0
	public static float get_uiscale() { }

	// RVA: 0x6E6CD0 Offset: 0x6E52D0 VA: 0x1806E6CD0
	public static void set_uiscale(float value) { }

	// RVA: 0x6E53D0 Offset: 0x6E39D0 VA: 0x1806E53D0
	public static int get_af() { }

	// RVA: 0x6E5D60 Offset: 0x6E4360 VA: 0x1806E5D60
	public static void set_af(int value) { }

	// RVA: 0x6E5690 Offset: 0x6E3C90 VA: 0x1806E5690
	public static int get_parallax() { }

	// RVA: 0x6E6370 Offset: 0x6E4970 VA: 0x1806E6370
	public static void set_parallax(int value) { }

	// RVA: 0x6E5550 Offset: 0x6E3B50 VA: 0x1806E5550
	public static bool get_itemskins() { }

	// RVA: 0x6E61C0 Offset: 0x6E47C0 VA: 0x1806E61C0
	public static void set_itemskins(bool value) { }

	// RVA: 0x6E5610 Offset: 0x6E3C10 VA: 0x1806E5610
	public static bool get_itemskinunload() { }

	// RVA: 0x6E6290 Offset: 0x6E4890 VA: 0x1806E6290
	public static void set_itemskinunload(bool value) { }

	// RVA: 0x6E55B0 Offset: 0x6E3BB0 VA: 0x1806E55B0
	public static float get_itemskintimeout() { }

	// RVA: 0x6E6220 Offset: 0x6E4820 VA: 0x1806E6220
	public static void set_itemskintimeout(float value) { }

	// RVA: 0x6E54F0 Offset: 0x6E3AF0 VA: 0x1806E54F0
	public static bool get_impostorshadows() { }

	// RVA: 0x6E6140 Offset: 0x6E4740 VA: 0x1806E6140
	public static void set_impostorshadows(bool value) { }

	// RVA: 0x6E5900 Offset: 0x6E3F00 VA: 0x1806E5900
	public static int get_showtexeldensity() { }

	// RVA: 0x6E6C30 Offset: 0x6E5230 VA: 0x1806E6C30
	public static void set_showtexeldensity(int value) { }

	// RVA: 0x6E5B10 Offset: 0x6E4110 VA: 0x1806E5B10
	public static bool get_waves() { }

	// RVA: 0x6E6DA0 Offset: 0x6E53A0 VA: 0x1806E6DA0
	public static void set_waves(bool value) { }

	// RVA: 0x6E5680 Offset: 0x6E3C80 VA: 0x1806E5680
	public static int get_maxQueuedFrames() { }

	// RVA: 0x6E6360 Offset: 0x6E4960 VA: 0x1806E6360
	public static void set_maxQueuedFrames(int value) { }

	// RVA: 0x6E5700 Offset: 0x6E3D00 VA: 0x1806E5700
	public static float get_renderScale() { }

	// RVA: 0x6E6520 Offset: 0x6E4B20 VA: 0x1806E6520
	public static void set_renderScale(float value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E4BA0 Offset: 0x6E31A0 VA: 0x1806E4BA0
	public static void SetMipMapBias(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E4B10 Offset: 0x6E3110 VA: 0x1806E4B10
	public static void ResetMipMapBias() { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6E4680 Offset: 0x6E2C80 VA: 0x1806E4680
	public static void ReportShadowCasters(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6E4310 Offset: 0x6E2910 VA: 0x1806E4310
	public static void ReportParticleSystems(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E5430 Offset: 0x6E3A30 VA: 0x1806E5430
	public static bool get_aggressiveShadowLodWearable() { }

	// RVA: 0x6E5E80 Offset: 0x6E4480 VA: 0x1806E5E80
	public static void set_aggressiveShadowLodWearable(bool value) { }

	// RVA: 0x6E5000 Offset: 0x6E3600 VA: 0x1806E5000
	public void .ctor() { }

	// RVA: 0x6E4C90 Offset: 0x6E3290 VA: 0x1806E4C90
	private static void .cctor() { }

}

private sealed class Graphics.<>c // TypeDefIndex: 11929
{	// Fields
	public static readonly Graphics.<>c <>9; // 0x0
	public static Func<Resolution, Vector2Int> <>9__60_0; // 0x8
	public static Func<Resolution, int> <>9__60_4; // 0x10
	public static Func<IGrouping<Vector2Int, Resolution>, Resolution> <>9__60_1; // 0x18
	public static Func<Resolution, int> <>9__60_2; // 0x20
	public static Func<Resolution, int> <>9__60_3; // 0x28

	// Methods

	// RVA: 0x36D680 Offset: 0x36BC80 VA: 0x18036D680
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x36D1E0 Offset: 0x36B7E0 VA: 0x18036D1E0
	internal Vector2Int <CacheResolutions>b__60_0(Resolution r) { }

	// RVA: 0x36D230 Offset: 0x36B830 VA: 0x18036D230
	internal Resolution <CacheResolutions>b__60_1(IGrouping<Vector2Int, Resolution> g) { }

	// RVA: 0x36D3A0 Offset: 0x36B9A0 VA: 0x18036D3A0
	internal int <CacheResolutions>b__60_4(Resolution r) { }

	// RVA: 0x36D360 Offset: 0x36B960 VA: 0x18036D360
	internal int <CacheResolutions>b__60_2(Resolution r) { }

	// RVA: 0x36D380 Offset: 0x36B980 VA: 0x18036D380
	internal int <CacheResolutions>b__60_3(Resolution r) { }

}

