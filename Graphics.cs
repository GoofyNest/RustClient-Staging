public class Graphics // TypeDefIndex: 3389
{	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x146E0

	// Properties
	public static RenderBuffer activeColorBuffer { get; }
	public static RenderBuffer activeDepthBuffer { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	// RVA: 0x182F220 Offset: 0x182D820 VA: 0x18182F220
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunctionAttribute] // RVA: 0x84750 Offset: 0x83B50 VA: 0x180084750
	// RVA: 0x182EB70 Offset: 0x182D170 VA: 0x18182EB70
	private static RenderBuffer GetActiveColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x84800 Offset: 0x83C00 VA: 0x180084800
	// RVA: 0x182EC30 Offset: 0x182D230 VA: 0x18182EC30
	private static RenderBuffer GetActiveDepthBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x848E0 Offset: 0x83CE0 VA: 0x1800848E0
	// RVA: 0x182F250 Offset: 0x182D850 VA: 0x18182F250
	private static void Internal_SetNullRT() { }

	[NativeMethodAttribute] // RVA: 0x84AA0 Offset: 0x83EA0 VA: 0x180084AA0
	// RVA: 0x182F2F0 Offset: 0x182D8F0 VA: 0x18182F2F0
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x84B30 Offset: 0x83F30 VA: 0x180084B30
	// RVA: 0x182F3A0 Offset: 0x182D9A0 VA: 0x18182F3A0
	private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[StaticAccessorAttribute] // RVA: 0x84D30 Offset: 0x84130 VA: 0x180084D30
	// RVA: 0x182D220 Offset: 0x182B820 VA: 0x18182D220
	public static void ClearRandomWriteTargets() { }

	[FreeFunctionAttribute] // RVA: 0x84EC0 Offset: 0x842C0 VA: 0x180084EC0
	// RVA: 0x182EF70 Offset: 0x182D570 VA: 0x18182EF70
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x84FE0 Offset: 0x843E0 VA: 0x180084FE0
	[FreeFunctionAttribute] // RVA: 0x84FE0 Offset: 0x843E0 VA: 0x180084FE0
	// RVA: 0x182F1E0 Offset: 0x182D7E0 VA: 0x18182F1E0
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunctionAttribute] // RVA: 0x85470 Offset: 0x84870 VA: 0x180085470
	// RVA: 0x182F080 Offset: 0x182D680 VA: 0x18182F080
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x85620 Offset: 0x84A20 VA: 0x180085620
	// RVA: 0x182EE10 Offset: 0x182D410 VA: 0x18182EE10
	private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x85750 Offset: 0x84B50 VA: 0x180085750
	// RVA: 0x182F190 Offset: 0x182D790 VA: 0x18182F190
	private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[FreeFunctionAttribute] // RVA: 0x85820 Offset: 0x84C20 VA: 0x180085820
	// RVA: 0x182ECB0 Offset: 0x182D2B0 VA: 0x18182ECB0
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunctionAttribute] // RVA: 0x85A50 Offset: 0x84E50 VA: 0x180085A50
	// RVA: 0x182ED20 Offset: 0x182D320 VA: 0x18182ED20
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[FreeFunctionAttribute] // RVA: 0x85C90 Offset: 0x85090 VA: 0x180085C90
	// RVA: 0x182CD70 Offset: 0x182B370 VA: 0x18182CD70
	private static void Blit2(Texture source, RenderTexture dest) { }

	[NativeMethodAttribute] // RVA: 0x85DA0 Offset: 0x851A0 VA: 0x180085DA0
	// RVA: 0x182EAF0 Offset: 0x182D0F0 VA: 0x18182EAF0
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0x182F740 Offset: 0x182DD40 VA: 0x18182F740
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182F840 Offset: 0x182DE40 VA: 0x18182F840
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182FB00 Offset: 0x182E100 VA: 0x18182FB00
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182FC90 Offset: 0x182E290 VA: 0x18182FC90
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182FF10 Offset: 0x182E510 VA: 0x18182FF10
	public static RenderBuffer get_activeColorBuffer() { }

	// RVA: 0x182FFE0 Offset: 0x182E5E0 VA: 0x18182FFE0
	public static RenderBuffer get_activeDepthBuffer() { }

	// RVA: 0x182F400 Offset: 0x182DA00 VA: 0x18182F400
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	// RVA: 0x182E400 Offset: 0x182CA00 VA: 0x18182E400
	private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass) { }

	// RVA: 0x182E690 Offset: 0x182CC90 VA: 0x18182E690
	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	// RVA: 0x182E580 Offset: 0x182CB80 VA: 0x18182E580
	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	// RVA: 0x182E860 Offset: 0x182CE60 VA: 0x18182E860
	public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass) { }

	// RVA: 0x182D710 Offset: 0x182BD10 VA: 0x18182D710
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x182D870 Offset: 0x182BE70 VA: 0x18182D870
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x182E150 Offset: 0x182C750 VA: 0x18182E150
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x182D360 Offset: 0x182B960 VA: 0x18182D360
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x182E340 Offset: 0x182C940 VA: 0x18182E340
	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0) { }

	// RVA: 0x182D0C0 Offset: 0x182B6C0 VA: 0x18182D0C0
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x182D020 Offset: 0x182B620 VA: 0x18182D020
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x182D140 Offset: 0x182B740 VA: 0x18182D140
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x182CF80 Offset: 0x182B580 VA: 0x18182CF80
	public static void Blit(Texture source, Material mat, int pass) { }

	// RVA: 0x182CEB0 Offset: 0x182B4B0 VA: 0x18182CEB0
	public static void Blit(Texture source, Material mat) { }

	// RVA: 0x182CDC0 Offset: 0x182B3C0 VA: 0x18182CDC0
	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182DEC0 Offset: 0x182C4C0 VA: 0x18182DEC0
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182DD40 Offset: 0x182C340 VA: 0x18182DD40
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182DA00 Offset: 0x182C000 VA: 0x18182DA00
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182DB90 Offset: 0x182C190 VA: 0x18182DB90
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182D250 Offset: 0x182B850 VA: 0x18182D250
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182E990 Offset: 0x182CF90 VA: 0x18182E990
	public static void DrawTexture(Rect screenRect, Texture texture) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182FDD0 Offset: 0x182E3D0 VA: 0x18182FDD0
	public static void SetRenderTarget(RenderTexture rt) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182FE40 Offset: 0x182E440 VA: 0x18182FE40
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182F9A0 Offset: 0x182DFA0 VA: 0x18182F9A0
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182F590 Offset: 0x182DB90 VA: 0x18182F590
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav) { }

	// RVA: 0x182FEB0 Offset: 0x182E4B0 VA: 0x18182FEB0
	private static void .cctor() { }

	// RVA: 0x182EB30 Offset: 0x182D130 VA: 0x18182EB30
	private static void GetActiveColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x182EBF0 Offset: 0x182D1F0 VA: 0x18182EBF0
	private static void GetActiveDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x182F280 Offset: 0x182D880 VA: 0x18182F280
	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x182EF20 Offset: 0x182D520 VA: 0x18182EF20
	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

	// RVA: 0x182F000 Offset: 0x182D600 VA: 0x18182F000
	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x182ED90 Offset: 0x182D390 VA: 0x18182ED90
	private static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

}

public static class Graphics // TypeDefIndex: 8219
{	// Methods

	// RVA: 0x106CAC0 Offset: 0x106B0C0 VA: 0x18106CAC0
	public static extern IntPtr GetRenderEventFunc() { }

}

public static class Graphics.BufferReadback // TypeDefIndex: 8220
{	// Methods

	// RVA: 0x10684A0 Offset: 0x1066AA0 VA: 0x1810684A0
	public static extern IntPtr CreateForTexture(IntPtr tex, uint width, uint height, uint format) { }

	// RVA: 0x1068410 Offset: 0x1066A10 VA: 0x181068410
	public static extern IntPtr CreateForBuffer(IntPtr buf, uint size) { }

	// RVA: 0x1068540 Offset: 0x1066B40 VA: 0x181068540
	public static extern void Destroy(IntPtr inst) { }

	// RVA: 0x1068870 Offset: 0x1066E70 VA: 0x181068870
	public static extern void IssueRead(IntPtr inst) { }

	// RVA: 0x10685C0 Offset: 0x1066BC0 VA: 0x1810685C0
	public static extern uint GetDataSize(IntPtr inst) { }

	// RVA: 0x1068640 Offset: 0x1066C40 VA: 0x181068640
	public static extern uint GetDataStride(IntPtr inst) { }

	// RVA: 0x10687E0 Offset: 0x1066DE0 VA: 0x1810687E0
	public static extern void GetData(IntPtr inst, ref byte data) { }

	// RVA: 0x1068750 Offset: 0x1066D50 VA: 0x181068750
	public static extern void GetData(IntPtr inst, ref Color32 data) { }

	// RVA: 0x10686C0 Offset: 0x1066CC0 VA: 0x1810686C0
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

	// RVA: 0x6E5760 Offset: 0x6E3D60 VA: 0x1806E5760
	public static int get_quality() { }

	// RVA: 0x6E6480 Offset: 0x6E4A80 VA: 0x1806E6480
	public static void set_quality(int value) { }

	// RVA: 0x6E4170 Offset: 0x6E2770 VA: 0x1806E4170
	public static float EnforceShadowDistanceBounds(float distance) { }

	// RVA: 0x6E58B0 Offset: 0x6E3EB0 VA: 0x1806E58B0
	public static float get_shadowdistance() { }

	// RVA: 0x6E6AB0 Offset: 0x6E50B0 VA: 0x1806E6AB0
	public static void set_shadowdistance(float value) { }

	// RVA: 0x6E58A0 Offset: 0x6E3EA0 VA: 0x1806E58A0
	public static int get_shadowcascades() { }

	// RVA: 0x6E69F0 Offset: 0x6E4FF0 VA: 0x1806E69F0
	public static void set_shadowcascades(int value) { }

	// RVA: 0x6E5910 Offset: 0x6E3F10 VA: 0x1806E5910
	public static int get_shadowquality() { }

	// RVA: 0x6E6B30 Offset: 0x6E5130 VA: 0x1806E6B30
	public static void set_shadowquality(int value) { }

	// RVA: 0x6E5500 Offset: 0x6E3B00 VA: 0x1806E5500
	public static float get_fov() { }

	// RVA: 0x6E60F0 Offset: 0x6E46F0 VA: 0x1806E60F0
	public static void set_fov(float value) { }

	// RVA: 0x6E56E0 Offset: 0x6E3CE0 VA: 0x1806E56E0
	public static float get_lodbias() { }

	// RVA: 0x6E6360 Offset: 0x6E4960 VA: 0x1806E6360
	public static void set_lodbias(float value) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6E5170 Offset: 0x6E3770 VA: 0x1806E5170
	public static void dof_focus_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E5360 Offset: 0x6E3960 VA: 0x1806E5360
	public static void dof_nudge(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E5890 Offset: 0x6E3E90 VA: 0x1806E5890
	public static int get_shaderlod() { }

	// RVA: 0x6E6980 Offset: 0x6E4F80 VA: 0x1806E6980
	public static void set_shaderlod(int value) { }

	// RVA: 0x6E5B70 Offset: 0x6E4170 VA: 0x1806E5B70
	public static int get_vsync() { }

	// RVA: 0x6E6E00 Offset: 0x6E5400 VA: 0x1806E6E00
	public static void set_vsync(int value) { }

	[ClientVar] // RVA: 0xA33C0 Offset: 0xA27C0 VA: 0x1800A33C0
	// RVA: 0x6E5BE0 Offset: 0x6E41E0 VA: 0x1806E5BE0
	public static void resolutions(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E57D0 Offset: 0x6E3DD0 VA: 0x1806E57D0
	public static int get_resolution() { }

	// RVA: 0x6E6650 Offset: 0x6E4C50 VA: 0x1806E6650
	public static void set_resolution(int value) { }

	// RVA: 0x6E42C0 Offset: 0x6E28C0 VA: 0x1806E42C0
	public static List<Resolution> GetUniqueResolutions() { }

	// RVA: 0x6E3DF0 Offset: 0x6E23F0 VA: 0x1806E3DF0
	private static void CacheResolutions() { }

	// RVA: 0x6E5830 Offset: 0x6E3E30 VA: 0x1806E5830
	public static int get_screenmode() { }

	// RVA: 0x6E68F0 Offset: 0x6E4EF0 VA: 0x1806E68F0
	public static void set_screenmode(int value) { }

	// RVA: 0x6E3C40 Offset: 0x6E2240 VA: 0x1806E3C40
	private static void ApplyScreenSettings() { }

	// RVA: 0x6E4240 Offset: 0x6E2840 VA: 0x1806E4240
	private static FullScreenMode GetScreenMode() { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6E50D0 Offset: 0x6E36D0 VA: 0x1806E50D0
	public static void dof_focus_lookingat(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E5B10 Offset: 0x6E4110 VA: 0x1806E5B10
	public static float get_uiscale() { }

	// RVA: 0x6E6D40 Offset: 0x6E5340 VA: 0x1806E6D40
	public static void set_uiscale(float value) { }

	// RVA: 0x6E5440 Offset: 0x6E3A40 VA: 0x1806E5440
	public static int get_af() { }

	// RVA: 0x6E5DD0 Offset: 0x6E43D0 VA: 0x1806E5DD0
	public static void set_af(int value) { }

	// RVA: 0x6E5700 Offset: 0x6E3D00 VA: 0x1806E5700
	public static int get_parallax() { }

	// RVA: 0x6E63E0 Offset: 0x6E49E0 VA: 0x1806E63E0
	public static void set_parallax(int value) { }

	// RVA: 0x6E55C0 Offset: 0x6E3BC0 VA: 0x1806E55C0
	public static bool get_itemskins() { }

	// RVA: 0x6E6230 Offset: 0x6E4830 VA: 0x1806E6230
	public static void set_itemskins(bool value) { }

	// RVA: 0x6E5680 Offset: 0x6E3C80 VA: 0x1806E5680
	public static bool get_itemskinunload() { }

	// RVA: 0x6E6300 Offset: 0x6E4900 VA: 0x1806E6300
	public static void set_itemskinunload(bool value) { }

	// RVA: 0x6E5620 Offset: 0x6E3C20 VA: 0x1806E5620
	public static float get_itemskintimeout() { }

	// RVA: 0x6E6290 Offset: 0x6E4890 VA: 0x1806E6290
	public static void set_itemskintimeout(float value) { }

	// RVA: 0x6E5560 Offset: 0x6E3B60 VA: 0x1806E5560
	public static bool get_impostorshadows() { }

	// RVA: 0x6E61B0 Offset: 0x6E47B0 VA: 0x1806E61B0
	public static void set_impostorshadows(bool value) { }

	// RVA: 0x6E5970 Offset: 0x6E3F70 VA: 0x1806E5970
	public static int get_showtexeldensity() { }

	// RVA: 0x6E6CA0 Offset: 0x6E52A0 VA: 0x1806E6CA0
	public static void set_showtexeldensity(int value) { }

	// RVA: 0x6E5B80 Offset: 0x6E4180 VA: 0x1806E5B80
	public static bool get_waves() { }

	// RVA: 0x6E6E10 Offset: 0x6E5410 VA: 0x1806E6E10
	public static void set_waves(bool value) { }

	// RVA: 0x6E56F0 Offset: 0x6E3CF0 VA: 0x1806E56F0
	public static int get_maxQueuedFrames() { }

	// RVA: 0x6E63D0 Offset: 0x6E49D0 VA: 0x1806E63D0
	public static void set_maxQueuedFrames(int value) { }

	// RVA: 0x6E5770 Offset: 0x6E3D70 VA: 0x1806E5770
	public static float get_renderScale() { }

	// RVA: 0x6E6590 Offset: 0x6E4B90 VA: 0x1806E6590
	public static void set_renderScale(float value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E4C10 Offset: 0x6E3210 VA: 0x1806E4C10
	public static void SetMipMapBias(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6E4B80 Offset: 0x6E3180 VA: 0x1806E4B80
	public static void ResetMipMapBias() { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6E46F0 Offset: 0x6E2CF0 VA: 0x1806E46F0
	public static void ReportShadowCasters(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6E4380 Offset: 0x6E2980 VA: 0x1806E4380
	public static void ReportParticleSystems(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E54A0 Offset: 0x6E3AA0 VA: 0x1806E54A0
	public static bool get_aggressiveShadowLodWearable() { }

	// RVA: 0x6E5EF0 Offset: 0x6E44F0 VA: 0x1806E5EF0
	public static void set_aggressiveShadowLodWearable(bool value) { }

	// RVA: 0x6E5070 Offset: 0x6E3670 VA: 0x1806E5070
	public void .ctor() { }

	// RVA: 0x6E4D00 Offset: 0x6E3300 VA: 0x1806E4D00
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

