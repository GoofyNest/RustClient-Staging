public class Graphics // TypeDefIndex: 3389
{	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x146E0

	// Properties
	public static RenderBuffer activeColorBuffer { get; }
	public static RenderBuffer activeDepthBuffer { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x84580 Offset: 0x83980 VA: 0x180084580
	// RVA: 0x182EFA0 Offset: 0x182D5A0 VA: 0x18182EFA0
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunctionAttribute] // RVA: 0x846F0 Offset: 0x83AF0 VA: 0x1800846F0
	// RVA: 0x182E8F0 Offset: 0x182CEF0 VA: 0x18182E8F0
	private static RenderBuffer GetActiveColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x847C0 Offset: 0x83BC0 VA: 0x1800847C0
	// RVA: 0x182E9B0 Offset: 0x182CFB0 VA: 0x18182E9B0
	private static RenderBuffer GetActiveDepthBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x84870 Offset: 0x83C70 VA: 0x180084870
	// RVA: 0x182EFD0 Offset: 0x182D5D0 VA: 0x18182EFD0
	private static void Internal_SetNullRT() { }

	[NativeMethodAttribute] // RVA: 0x84A30 Offset: 0x83E30 VA: 0x180084A30
	// RVA: 0x182F070 Offset: 0x182D670 VA: 0x18182F070
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x84A90 Offset: 0x83E90 VA: 0x180084A90
	// RVA: 0x182F120 Offset: 0x182D720 VA: 0x18182F120
	private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[StaticAccessorAttribute] // RVA: 0x84D20 Offset: 0x84120 VA: 0x180084D20
	// RVA: 0x182CFA0 Offset: 0x182B5A0 VA: 0x18182CFA0
	public static void ClearRandomWriteTargets() { }

	[FreeFunctionAttribute] // RVA: 0x84EB0 Offset: 0x842B0 VA: 0x180084EB0
	// RVA: 0x182ECF0 Offset: 0x182D2F0 VA: 0x18182ECF0
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[FreeFunctionAttribute] // RVA: 0x84FD0 Offset: 0x843D0 VA: 0x180084FD0
	[VisibleToOtherModulesAttribute] // RVA: 0x84FD0 Offset: 0x843D0 VA: 0x180084FD0
	// RVA: 0x182EF60 Offset: 0x182D560 VA: 0x18182EF60
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunctionAttribute] // RVA: 0x853D0 Offset: 0x847D0 VA: 0x1800853D0
	// RVA: 0x182EE00 Offset: 0x182D400 VA: 0x18182EE00
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x855B0 Offset: 0x849B0 VA: 0x1800855B0
	// RVA: 0x182EB90 Offset: 0x182D190 VA: 0x18182EB90
	private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x856E0 Offset: 0x84AE0 VA: 0x1800856E0
	// RVA: 0x182EF10 Offset: 0x182D510 VA: 0x18182EF10
	private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[FreeFunctionAttribute] // RVA: 0x857C0 Offset: 0x84BC0 VA: 0x1800857C0
	// RVA: 0x182EA30 Offset: 0x182D030 VA: 0x18182EA30
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunctionAttribute] // RVA: 0x85960 Offset: 0x84D60 VA: 0x180085960
	// RVA: 0x182EAA0 Offset: 0x182D0A0 VA: 0x18182EAA0
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[FreeFunctionAttribute] // RVA: 0x85C20 Offset: 0x85020 VA: 0x180085C20
	// RVA: 0x182CAF0 Offset: 0x182B0F0 VA: 0x18182CAF0
	private static void Blit2(Texture source, RenderTexture dest) { }

	[NativeMethodAttribute] // RVA: 0x85D10 Offset: 0x85110 VA: 0x180085D10
	// RVA: 0x182E870 Offset: 0x182CE70 VA: 0x18182E870
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0x182F4C0 Offset: 0x182DAC0 VA: 0x18182F4C0
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182F5C0 Offset: 0x182DBC0 VA: 0x18182F5C0
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182F880 Offset: 0x182DE80 VA: 0x18182F880
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182FA10 Offset: 0x182E010 VA: 0x18182FA10
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182FC90 Offset: 0x182E290 VA: 0x18182FC90
	public static RenderBuffer get_activeColorBuffer() { }

	// RVA: 0x182FD60 Offset: 0x182E360 VA: 0x18182FD60
	public static RenderBuffer get_activeDepthBuffer() { }

	// RVA: 0x182F180 Offset: 0x182D780 VA: 0x18182F180
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	// RVA: 0x182E180 Offset: 0x182C780 VA: 0x18182E180
	private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass) { }

	// RVA: 0x182E410 Offset: 0x182CA10 VA: 0x18182E410
	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	// RVA: 0x182E300 Offset: 0x182C900 VA: 0x18182E300
	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	// RVA: 0x182E5E0 Offset: 0x182CBE0 VA: 0x18182E5E0
	public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass) { }

	// RVA: 0x182D490 Offset: 0x182BA90 VA: 0x18182D490
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x182D5F0 Offset: 0x182BBF0 VA: 0x18182D5F0
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x182DED0 Offset: 0x182C4D0 VA: 0x18182DED0
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x182D0E0 Offset: 0x182B6E0 VA: 0x18182D0E0
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x182E0C0 Offset: 0x182C6C0 VA: 0x18182E0C0
	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0) { }

	// RVA: 0x182CE40 Offset: 0x182B440 VA: 0x18182CE40
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x182CDA0 Offset: 0x182B3A0 VA: 0x18182CDA0
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x182CEC0 Offset: 0x182B4C0 VA: 0x18182CEC0
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x182CD00 Offset: 0x182B300 VA: 0x18182CD00
	public static void Blit(Texture source, Material mat, int pass) { }

	// RVA: 0x182CC30 Offset: 0x182B230 VA: 0x18182CC30
	public static void Blit(Texture source, Material mat) { }

	// RVA: 0x182CB40 Offset: 0x182B140 VA: 0x18182CB40
	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182DC40 Offset: 0x182C240 VA: 0x18182DC40
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182DAC0 Offset: 0x182C0C0 VA: 0x18182DAC0
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182D780 Offset: 0x182BD80 VA: 0x18182D780
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182D910 Offset: 0x182BF10 VA: 0x18182D910
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182CFD0 Offset: 0x182B5D0 VA: 0x18182CFD0
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182E710 Offset: 0x182CD10 VA: 0x18182E710
	public static void DrawTexture(Rect screenRect, Texture texture) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182FB50 Offset: 0x182E150 VA: 0x18182FB50
	public static void SetRenderTarget(RenderTexture rt) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182FBC0 Offset: 0x182E1C0 VA: 0x18182FBC0
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182F720 Offset: 0x182DD20 VA: 0x18182F720
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x182F310 Offset: 0x182D910 VA: 0x18182F310
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav) { }

	// RVA: 0x182FC30 Offset: 0x182E230 VA: 0x18182FC30
	private static void .cctor() { }

	// RVA: 0x182E8B0 Offset: 0x182CEB0 VA: 0x18182E8B0
	private static void GetActiveColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x182E970 Offset: 0x182CF70 VA: 0x18182E970
	private static void GetActiveDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x182F000 Offset: 0x182D600 VA: 0x18182F000
	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x182ECA0 Offset: 0x182D2A0 VA: 0x18182ECA0
	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

	// RVA: 0x182ED80 Offset: 0x182D380 VA: 0x18182ED80
	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x182EB10 Offset: 0x182D110 VA: 0x18182EB10
	private static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

}

public static class Graphics // TypeDefIndex: 8219
{	// Methods

	// RVA: 0x106C800 Offset: 0x106AE00 VA: 0x18106C800
	public static extern IntPtr GetRenderEventFunc() { }

}

public static class Graphics.BufferReadback // TypeDefIndex: 8220
{	// Methods

	// RVA: 0x10681E0 Offset: 0x10667E0 VA: 0x1810681E0
	public static extern IntPtr CreateForTexture(IntPtr tex, uint width, uint height, uint format) { }

	// RVA: 0x1068150 Offset: 0x1066750 VA: 0x181068150
	public static extern IntPtr CreateForBuffer(IntPtr buf, uint size) { }

	// RVA: 0x1068280 Offset: 0x1066880 VA: 0x181068280
	public static extern void Destroy(IntPtr inst) { }

	// RVA: 0x10685B0 Offset: 0x1066BB0 VA: 0x1810685B0
	public static extern void IssueRead(IntPtr inst) { }

	// RVA: 0x1068300 Offset: 0x1066900 VA: 0x181068300
	public static extern uint GetDataSize(IntPtr inst) { }

	// RVA: 0x1068380 Offset: 0x1066980 VA: 0x181068380
	public static extern uint GetDataStride(IntPtr inst) { }

	// RVA: 0x1068520 Offset: 0x1066B20 VA: 0x181068520
	public static extern void GetData(IntPtr inst, ref byte data) { }

	// RVA: 0x1068490 Offset: 0x1066A90 VA: 0x181068490
	public static extern void GetData(IntPtr inst, ref Color32 data) { }

	// RVA: 0x1068400 Offset: 0x1066A00 VA: 0x181068400
	public static extern void GetData(IntPtr inst, ref float data) { }

}

public class Graphics : ConsoleSystem // TypeDefIndex: 11928
{	// Fields
	private const float MinShadowDistance = 100;
	private const float MaxShadowDistance2Split = 600;
	private const float MaxShadowDistance4Split = 1000;
	private static float _shadowdistance; // 0x0
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int shadowmode; // 0x4
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int shadowlights; // 0x8
	private static int _shadowquality; // 0xC
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool grassshadows; // 0x10
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool contactshadows; // 0x11
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float drawdistance; // 0x14
	private static float _fov; // 0x18
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool hud; // 0x1C
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool chat; // 0x1D
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool branding; // 0x1E
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int compass; // 0x20
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool dof; // 0x24
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float dof_aper; // 0x28
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float dof_blur; // 0x2C
	[ClientVar] // RVA: 0xA2840 Offset: 0xA1C40 VA: 0x1800A2840
	public static int dof_mode; // 0x30
	[ClientVar] // RVA: 0xA2900 Offset: 0xA1D00 VA: 0x1800A2900
	public static float dof_focus_dist; // 0x34
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float dof_focus_time; // 0x38
	[ClientVar] // RVA: 0xA2970 Offset: 0xA1D70 VA: 0x1800A2970
	public static bool dof_debug; // 0x3C
	public static BaseEntity dof_focus_target_entity; // 0x40
	[ClientVar] // RVA: 0xA2A20 Offset: 0xA1E20 VA: 0x1800A2A20
	public static bool vm_fov_scale; // 0x48
	[ClientVar] // RVA: 0xA2B20 Offset: 0xA1F20 VA: 0x1800A2B20
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
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool viewModelCamera; // 0x75
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool viewModelDepth; // 0x76
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int reflexMode; // 0x78
	[ClientVar] // RVA: 0xA2D30 Offset: 0xA2130 VA: 0x1800A2D30
	public static int reflexIntervalUs; // 0x7C
	[ClientVar] // RVA: 0x891C0 Offset: 0x885C0 VA: 0x1800891C0
	public static bool reflexLatencyMarker; // 0x80
	[ClientVar] // RVA: 0x891C0 Offset: 0x885C0 VA: 0x1800891C0
	public static bool useMarkersToOptimize; // 0x81
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int dlss; // 0x84
	private static float _renderScale; // 0x88
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float jitterSpread; // 0x8C
	[ClientVar] // RVA: 0xA2F50 Offset: 0xA2350 VA: 0x1800A2F50
	public static bool disableLightLod; // 0x90
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool aggressiveShadowLod; // 0x91
	private static bool _aggressiveShadowLodWearable; // 0x92

	// Properties
	[ClientVar] // RVA: 0xA35E0 Offset: 0xA29E0 VA: 0x1800A35E0
	public static int quality { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float shadowdistance { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int shadowcascades { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int shadowquality { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float fov { get; set; }
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static float lodbias { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int shaderlod { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int vsync { get; set; }
	[ClientVar] // RVA: 0xA3B00 Offset: 0xA2F00 VA: 0x1800A3B00
	public static int resolution { get; set; }
	[ClientVar] // RVA: 0xA3BA0 Offset: 0xA2FA0 VA: 0x1800A3BA0
	public static int screenmode { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float uiscale { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int af { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static int parallax { get; set; }
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool itemskins { get; set; }
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool itemskinunload { get; set; }
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static float itemskintimeout { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool impostorshadows { get; set; }
	[ClientVar] // RVA: 0xA4340 Offset: 0xA3740 VA: 0x1800A4340
	public static int showtexeldensity { get; set; }
	[ClientVar] // RVA: 0xA4560 Offset: 0xA3960 VA: 0x1800A4560
	public static bool waves { get; set; }
	[ClientVar] // RVA: 0xA4690 Offset: 0xA3A90 VA: 0x1800A4690
	public static int maxQueuedFrames { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float renderScale { get; set; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool aggressiveShadowLodWearable { get; set; }

	// Methods

	// RVA: 0x6E5650 Offset: 0x6E3C50 VA: 0x1806E5650
	public static int get_quality() { }

	// RVA: 0x6E6370 Offset: 0x6E4970 VA: 0x1806E6370
	public static void set_quality(int value) { }

	// RVA: 0x6E4060 Offset: 0x6E2660 VA: 0x1806E4060
	public static float EnforceShadowDistanceBounds(float distance) { }

	// RVA: 0x6E57A0 Offset: 0x6E3DA0 VA: 0x1806E57A0
	public static float get_shadowdistance() { }

	// RVA: 0x6E69A0 Offset: 0x6E4FA0 VA: 0x1806E69A0
	public static void set_shadowdistance(float value) { }

	// RVA: 0x6E5790 Offset: 0x6E3D90 VA: 0x1806E5790
	public static int get_shadowcascades() { }

	// RVA: 0x6E68E0 Offset: 0x6E4EE0 VA: 0x1806E68E0
	public static void set_shadowcascades(int value) { }

	// RVA: 0x6E5800 Offset: 0x6E3E00 VA: 0x1806E5800
	public static int get_shadowquality() { }

	// RVA: 0x6E6A20 Offset: 0x6E5020 VA: 0x1806E6A20
	public static void set_shadowquality(int value) { }

	// RVA: 0x6E53F0 Offset: 0x6E39F0 VA: 0x1806E53F0
	public static float get_fov() { }

	// RVA: 0x6E5FE0 Offset: 0x6E45E0 VA: 0x1806E5FE0
	public static void set_fov(float value) { }

	// RVA: 0x6E55D0 Offset: 0x6E3BD0 VA: 0x1806E55D0
	public static float get_lodbias() { }

	// RVA: 0x6E6250 Offset: 0x6E4850 VA: 0x1806E6250
	public static void set_lodbias(float value) { }

	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	// RVA: 0x6E5060 Offset: 0x6E3660 VA: 0x1806E5060
	public static void dof_focus_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6E5250 Offset: 0x6E3850 VA: 0x1806E5250
	public static void dof_nudge(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E5780 Offset: 0x6E3D80 VA: 0x1806E5780
	public static int get_shaderlod() { }

	// RVA: 0x6E6870 Offset: 0x6E4E70 VA: 0x1806E6870
	public static void set_shaderlod(int value) { }

	// RVA: 0x6E5A60 Offset: 0x6E4060 VA: 0x1806E5A60
	public static int get_vsync() { }

	// RVA: 0x6E6CF0 Offset: 0x6E52F0 VA: 0x1806E6CF0
	public static void set_vsync(int value) { }

	[ClientVar] // RVA: 0xA32E0 Offset: 0xA26E0 VA: 0x1800A32E0
	// RVA: 0x6E5AD0 Offset: 0x6E40D0 VA: 0x1806E5AD0
	public static void resolutions(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E56C0 Offset: 0x6E3CC0 VA: 0x1806E56C0
	public static int get_resolution() { }

	// RVA: 0x6E6540 Offset: 0x6E4B40 VA: 0x1806E6540
	public static void set_resolution(int value) { }

	// RVA: 0x6E41B0 Offset: 0x6E27B0 VA: 0x1806E41B0
	public static List<Resolution> GetUniqueResolutions() { }

	// RVA: 0x6E3CE0 Offset: 0x6E22E0 VA: 0x1806E3CE0
	private static void CacheResolutions() { }

	// RVA: 0x6E5720 Offset: 0x6E3D20 VA: 0x1806E5720
	public static int get_screenmode() { }

	// RVA: 0x6E67E0 Offset: 0x6E4DE0 VA: 0x1806E67E0
	public static void set_screenmode(int value) { }

	// RVA: 0x6E3B30 Offset: 0x6E2130 VA: 0x1806E3B30
	private static void ApplyScreenSettings() { }

	// RVA: 0x6E4130 Offset: 0x6E2730 VA: 0x1806E4130
	private static FullScreenMode GetScreenMode() { }

	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	// RVA: 0x6E4FC0 Offset: 0x6E35C0 VA: 0x1806E4FC0
	public static void dof_focus_lookingat(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E5A00 Offset: 0x6E4000 VA: 0x1806E5A00
	public static float get_uiscale() { }

	// RVA: 0x6E6C30 Offset: 0x6E5230 VA: 0x1806E6C30
	public static void set_uiscale(float value) { }

	// RVA: 0x6E5330 Offset: 0x6E3930 VA: 0x1806E5330
	public static int get_af() { }

	// RVA: 0x6E5CC0 Offset: 0x6E42C0 VA: 0x1806E5CC0
	public static void set_af(int value) { }

	// RVA: 0x6E55F0 Offset: 0x6E3BF0 VA: 0x1806E55F0
	public static int get_parallax() { }

	// RVA: 0x6E62D0 Offset: 0x6E48D0 VA: 0x1806E62D0
	public static void set_parallax(int value) { }

	// RVA: 0x6E54B0 Offset: 0x6E3AB0 VA: 0x1806E54B0
	public static bool get_itemskins() { }

	// RVA: 0x6E6120 Offset: 0x6E4720 VA: 0x1806E6120
	public static void set_itemskins(bool value) { }

	// RVA: 0x6E5570 Offset: 0x6E3B70 VA: 0x1806E5570
	public static bool get_itemskinunload() { }

	// RVA: 0x6E61F0 Offset: 0x6E47F0 VA: 0x1806E61F0
	public static void set_itemskinunload(bool value) { }

	// RVA: 0x6E5510 Offset: 0x6E3B10 VA: 0x1806E5510
	public static float get_itemskintimeout() { }

	// RVA: 0x6E6180 Offset: 0x6E4780 VA: 0x1806E6180
	public static void set_itemskintimeout(float value) { }

	// RVA: 0x6E5450 Offset: 0x6E3A50 VA: 0x1806E5450
	public static bool get_impostorshadows() { }

	// RVA: 0x6E60A0 Offset: 0x6E46A0 VA: 0x1806E60A0
	public static void set_impostorshadows(bool value) { }

	// RVA: 0x6E5860 Offset: 0x6E3E60 VA: 0x1806E5860
	public static int get_showtexeldensity() { }

	// RVA: 0x6E6B90 Offset: 0x6E5190 VA: 0x1806E6B90
	public static void set_showtexeldensity(int value) { }

	// RVA: 0x6E5A70 Offset: 0x6E4070 VA: 0x1806E5A70
	public static bool get_waves() { }

	// RVA: 0x6E6D00 Offset: 0x6E5300 VA: 0x1806E6D00
	public static void set_waves(bool value) { }

	// RVA: 0x6E55E0 Offset: 0x6E3BE0 VA: 0x1806E55E0
	public static int get_maxQueuedFrames() { }

	// RVA: 0x6E62C0 Offset: 0x6E48C0 VA: 0x1806E62C0
	public static void set_maxQueuedFrames(int value) { }

	// RVA: 0x6E5660 Offset: 0x6E3C60 VA: 0x1806E5660
	public static float get_renderScale() { }

	// RVA: 0x6E6480 Offset: 0x6E4A80 VA: 0x1806E6480
	public static void set_renderScale(float value) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6E4B00 Offset: 0x6E3100 VA: 0x1806E4B00
	public static void SetMipMapBias(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6E4A70 Offset: 0x6E3070 VA: 0x1806E4A70
	public static void ResetMipMapBias() { }

	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	// RVA: 0x6E45E0 Offset: 0x6E2BE0 VA: 0x1806E45E0
	public static void ReportShadowCasters(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	// RVA: 0x6E4270 Offset: 0x6E2870 VA: 0x1806E4270
	public static void ReportParticleSystems(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E5390 Offset: 0x6E3990 VA: 0x1806E5390
	public static bool get_aggressiveShadowLodWearable() { }

	// RVA: 0x6E5DE0 Offset: 0x6E43E0 VA: 0x1806E5DE0
	public static void set_aggressiveShadowLodWearable(bool value) { }

	// RVA: 0x6E4F60 Offset: 0x6E3560 VA: 0x1806E4F60
	public void .ctor() { }

	// RVA: 0x6E4BF0 Offset: 0x6E31F0 VA: 0x1806E4BF0
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

