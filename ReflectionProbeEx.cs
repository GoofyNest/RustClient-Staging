public class ReflectionProbeEx : MonoBehaviour // TypeDefIndex: 10690
{	// Fields
	private static readonly uint[,] qualitySamples; // 0x0
	private static Vector4[] sampleData; // 0x8
	private Mesh blitMesh; // 0x18
	private Mesh skyboxMesh; // 0x20
	private static float[] octaVerts; // 0x10
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] cubemapFaceMatrices; // 0x18
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] cubemapFaceMatricesD3D11; // 0x20
	private static readonly ReflectionProbeEx.CubemapFaceMatrices[] shadowCubemapFaceMatrices; // 0x28
	private ReflectionProbeEx.CubemapFaceMatrices[] platformCubemapFaceMatrices; // 0x28
	private static readonly HashSet<string> supportedShaderNames; // 0x30
	private static Dictionary<Shader, Shader> supportedShaders; // 0x38
	private static Dictionary<Material, Material> matchingMaterials; // 0x40
	private RenderTexture probeTempTexture; // 0x30
	private RenderTexture probeShadowTexture; // 0x38
	private RenderTexture arrayTexture; // 0x40
	private RenderTexture arrayTempTexture; // 0x48
	private RenderTexture arrayDepthTexture; // 0x50
	private int mipmapCount; // 0x58
	private Material blitMaterial; // 0x60
	private Material filterMaterial; // 0x68
	private Material shadowMaterial; // 0x70
	private CommandBuffer forwardCB; // 0x78
	private CommandBuffer shadowCB; // 0x80
	private Matrix4x4[] viewProjMatrixArray; // 0x88
	private Matrix4x4[] objectToWorldArray; // 0x90
	private Matrix4x4[] cameraToWorldArray; // 0x98
	private bool useGeometryShader; // 0xA0
	private int PassCount; // 0xA4
	private static readonly int[] tab32; // 0x48
	public ReflectionProbeRefreshMode refreshMode; // 0xA8
	public bool timeSlicing; // 0xAC
	public int resolution; // 0xB0
	[InspectorNameAttribute] // RVA: 0x71950 Offset: 0x70D50 VA: 0x180071950
	public bool hdr; // 0xB4
	public float shadowDistance; // 0xB8
	public ReflectionProbeClearFlags clearFlags; // 0xBC
	public Color background; // 0xC0
	public float nearClip; // 0xD0
	public float farClip; // 0xD4
	public Transform attachToTarget; // 0xD8
	public Light directionalLight; // 0xE0
	public float textureMipBias; // 0xE8
	public bool highPrecision; // 0xEC
	public bool enableShadows; // 0xED
	public ReflectionProbeEx.ConvolutionQuality convolutionQuality; // 0xF0
	public List<ReflectionProbeEx.RenderListEntry> staticRenderList; // 0xF8
	public Cubemap reflectionCubemap; // 0x100
	public float reflectionIntensity; // 0x108
	private List<ReflectionProbeEx.RenderListEntry> dynamicRenderList; // 0x110
	private ReflectionProbe probe; // 0x118
	private RenderTexture probeTexture; // 0x120
	private int probeResolution; // 0x128
	private bool probeHdr; // 0x12C
	private float probeShadowDistance; // 0x130
	private float probeNearClip; // 0x134
	private float probeFarClip; // 0x138
	private const int probeDepth = 24;
	private bool probeHighPrecision; // 0x13C
	private ReflectionProbeEx.TimeSlicingState timeSlicedRenderState; // 0x140
	private bool scriptingRenderQueued; // 0x144
	private Matrix4x4 faceProjMatrix; // 0x148
	private Matrix4x4 faceProjInvMatrix; // 0x188
	private int prevFrame; // 0x1C8
	private ReflectionProbeRefreshMode savedProbeRefresh; // 0x1CC
	private ReflectionProbeMode savedProbeMode; // 0x1D0
	private Texture savedProbeCustomTexture; // 0x1D8

	// Properties
	public RenderTexture Texture { get; }

	// Methods

	// RVA: 0x943250 Offset: 0x941850 VA: 0x180943250
	private Vector2 Hammersley(uint index, uint numSamples) { }

	// RVA: 0x942AF0 Offset: 0x9410F0 VA: 0x180942AF0
	private float D_GGX(float roughness, float NdotH) { }

	// RVA: 0x943320 Offset: 0x941920 VA: 0x180943320
	private Vector3 ImportanceSampleGGX(Vector2 Xi, float roughness) { }

	// RVA: 0x93F920 Offset: 0x93DF20 VA: 0x18093F920
	private void ApplyConvolution(Texture target) { }

	// RVA: 0x941A70 Offset: 0x940070 VA: 0x180941A70
	private void CreateMeshes() { }

	// RVA: 0x942C00 Offset: 0x941200 VA: 0x180942C00
	private void DestroyMeshes() { }

	// RVA: 0x941370 Offset: 0x93F970 VA: 0x180941370
	private static Mesh CreateBlitMesh() { }

	// RVA: 0x946720 Offset: 0x944D20 VA: 0x180946720
	private static ReflectionProbeEx.CubemapSkyboxVertex SubDivVert(ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2) { }

	// RVA: 0x946ED0 Offset: 0x9454D0 VA: 0x180946ED0
	private static void Subdivide(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	// RVA: 0x9468B0 Offset: 0x944EB0 VA: 0x1809468B0
	private static void SubdivideYOnly(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	// RVA: 0x941B80 Offset: 0x940180 VA: 0x180941B80
	private static Mesh CreateSkyboxMesh() { }

	// RVA: 0x943420 Offset: 0x941A20 VA: 0x180943420
	private bool InitializeCubemapFaceMatrices() { }

	// RVA: 0x9425F0 Offset: 0x940BF0 VA: 0x1809425F0
	private void CreateTextures() { }

	// RVA: 0x942D30 Offset: 0x941330 VA: 0x180942D30
	private void DestroyTextures() { }

	// RVA: 0x944F30 Offset: 0x943530 VA: 0x180944F30
	private Material RegisterMaterialReplacement(Material material) { }

	// RVA: 0x943160 Offset: 0x941760 VA: 0x180943160
	private Material FindMaterialReplacement(Material material) { }

	// RVA: 0x941770 Offset: 0x93FD70 VA: 0x180941770
	private void CreateMaterials() { }

	// RVA: 0x942B90 Offset: 0x941190 VA: 0x180942B90
	private void DestroyMaterials() { }

	// RVA: 0x9416D0 Offset: 0x93FCD0 VA: 0x1809416D0
	private void CreateCommandBuffers() { }

	// RVA: 0x942B30 Offset: 0x941130 VA: 0x180942B30
	private void DestroyCommandBuffers() { }

	// RVA: 0x941280 Offset: 0x93F880 VA: 0x180941280
	private void ClearCommandBuffers() { }

	// RVA: 0x9400C0 Offset: 0x93E6C0 VA: 0x1809400C0
	private void AttachToLight() { }

	// RVA: 0x942DE0 Offset: 0x9413E0 VA: 0x180942DE0
	private void DetachFromLight() { }

	// RVA: 0x942FF0 Offset: 0x9415F0 VA: 0x180942FF0
	private void FindEnvironmentReflection() { }

	// RVA: 0x940F30 Offset: 0x93F530 VA: 0x180940F30
	private void BindGlobalProperties() { }

	// RVA: 0x940AA0 Offset: 0x93F0A0 VA: 0x180940AA0
	private void BindGlobalLight() { }

	// RVA: 0x9401E0 Offset: 0x93E7E0 VA: 0x1809401E0
	private void BindGlobalAmbient() { }

	// RVA: 0x941030 Offset: 0x93F630 VA: 0x180941030
	private void BindGlobalReflection() { }

	// RVA: 0x945310 Offset: 0x943910 VA: 0x180945310
	private void RenderObjects() { }

	// RVA: 0x945C60 Offset: 0x944260 VA: 0x180945C60
	private void RenderSkybox() { }

	// RVA: 0x943990 Offset: 0x941F90 VA: 0x180943990
	private void IssueRender() { }

	// RVA: 0x9438B0 Offset: 0x941EB0 VA: 0x1809438B0
	private void IssueGenerateMips() { }

	// RVA: 0x943590 Offset: 0x941B90 VA: 0x180943590
	private void IssueConvolution() { }

	// RVA: 0x943BC0 Offset: 0x9421C0 VA: 0x180943BC0
	private void IssueShadow() { }

	// RVA: 0x944D20 Offset: 0x943320 VA: 0x180944D20
	private void PrepareFullRender() { }

	// RVA: 0x944E00 Offset: 0x943400 VA: 0x180944E00
	private void PrepareTimeSlicedRender(ReflectionProbeEx.TimeSlicingState state) { }

	// RVA: 0x942EB0 Offset: 0x9414B0 VA: 0x180942EB0
	private void ExecuteRender() { }

	// RVA: 0x942F40 Offset: 0x941540 VA: 0x180942F40
	private int FastLog2(int value) { }

	// RVA: 0x946290 Offset: 0x944890 VA: 0x180946290
	private uint ReverseBits(uint bits) { }

	// RVA: 0x946680 Offset: 0x944C80 VA: 0x180946680
	private void SafeCreateMaterial(ref Material mat, Shader shader) { }

	// RVA: 0x946580 Offset: 0x944B80 VA: 0x180946580
	private void SafeCreateMaterial(ref Material mat, string shaderName) { }

	// RVA: 0x946390 Offset: 0x944990 VA: 0x180946390
	private void SafeCreateCubeRT(ref RenderTexture rt, string name, int size, int depth, bool mips, TextureDimension dim, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite = 1) { }

	// RVA: 0x946300 Offset: 0x944900 VA: 0x180946300
	private void SafeCreateCB(ref CommandBuffer cb, string name) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFEA20 Offset: 0xCFD020 VA: 0x180CFEA20
	|-ReflectionProbeEx.SafeDestroy<object>
	|-ReflectionProbeEx.SafeDestroy<Material>
	|-ReflectionProbeEx.SafeDestroy<RenderTexture>
	*/

	// RVA: -1 Offset: -1
	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFEAC0 Offset: 0xCFD0C0 VA: 0x180CFEAC0
	|-ReflectionProbeEx.SafeDispose<object>
	|-ReflectionProbeEx.SafeDispose<CommandBuffer>
	*/

	// RVA: 0x7DDC60 Offset: 0x7DC260 VA: 0x1807DDC60
	public RenderTexture get_Texture() { }

	// RVA: 0x941320 Offset: 0x93F920 VA: 0x180941320
	public void ClearRenderList() { }

	// RVA: 0x93F860 Offset: 0x93DE60 VA: 0x18093F860
	public void AddToRenderList(Renderer renderer, bool alwaysEnabled = False) { }

	// RVA: 0x940190 Offset: 0x93E790 VA: 0x180940190
	private void Awake() { }

	// RVA: 0x944830 Offset: 0x942E30 VA: 0x180944830
	private void OnEnable() { }

	// RVA: 0x944510 Offset: 0x942B10 VA: 0x180944510
	private void OnDisable() { }

	// RVA: 0x944060 Offset: 0x942660 VA: 0x180944060
	private void OnCameraPreRender(Camera cam) { }

	// RVA: 0x945C40 Offset: 0x944240 VA: 0x180945C40
	public void RenderProbe() { }

	// RVA: 0x943570 Offset: 0x941B70 VA: 0x180943570
	public bool IsFinishedRendering() { }

	// RVA: 0x943F40 Offset: 0x942540 VA: 0x180943F40
	private void ModifyProbeProperties() { }

	// RVA: 0x9461D0 Offset: 0x9447D0 VA: 0x1809461D0
	private void RestoreProbeSettings() { }

	// RVA: 0x9472D0 Offset: 0x9458D0 VA: 0x1809472D0
	private bool UpdateProperties() { }

	// RVA: 0x949600 Offset: 0x947C00 VA: 0x180949600
	public void .ctor() { }

	// RVA: 0x9475B0 Offset: 0x945BB0 VA: 0x1809475B0
	private static void .cctor() { }

}

private struct ReflectionProbeEx.CubemapSkyboxVertex // TypeDefIndex: 10691
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public Color color; // 0xC
	public float tu; // 0x1C
	public float tv; // 0x20
	public float tw; // 0x24

}

private struct ReflectionProbeEx.CubemapFaceMatrices // TypeDefIndex: 10692
{	// Fields
	public Matrix4x4 worldToView; // 0x0
	public Matrix4x4 viewToWorld; // 0x40

	// Methods

	// RVA: 0xFA380 Offset: 0xF9780 VA: 0x1800FA380
	public void .ctor(Vector3 x, Vector3 y, Vector3 z) { }

}

public enum ReflectionProbeEx.ConvolutionQuality // TypeDefIndex: 10693
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbeEx.ConvolutionQuality Lowest = 0;
	public const ReflectionProbeEx.ConvolutionQuality Low = 1;
	public const ReflectionProbeEx.ConvolutionQuality Medium = 2;
	public const ReflectionProbeEx.ConvolutionQuality High = 3;
	public const ReflectionProbeEx.ConvolutionQuality VeryHigh = 4;

}

public struct ReflectionProbeEx.RenderListEntry // TypeDefIndex: 10694
{	// Fields
	public Renderer renderer; // 0x0
	public bool alwaysEnabled; // 0x8

	// Methods

	// RVA: 0xFA3F0 Offset: 0xF97F0 VA: 0x1800FA3F0
	public void .ctor(Renderer renderer, bool alwaysEnabled) { }

}

private enum ReflectionProbeEx.TimeSlicingState // TypeDefIndex: 10695
{	// Fields
	public int value__; // 0x0
	public const ReflectionProbeEx.TimeSlicingState Shadow = 0;
	public const ReflectionProbeEx.TimeSlicingState Render = 1;
	public const ReflectionProbeEx.TimeSlicingState GenerateMips = 2;
	public const ReflectionProbeEx.TimeSlicingState Convolution = 3;
	public const ReflectionProbeEx.TimeSlicingState Finished = 4;

}

