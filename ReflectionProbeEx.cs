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

	// RVA: 0x943870 Offset: 0x941E70 VA: 0x180943870
	private Vector2 Hammersley(uint index, uint numSamples) { }

	// RVA: 0x943110 Offset: 0x941710 VA: 0x180943110
	private float D_GGX(float roughness, float NdotH) { }

	// RVA: 0x943940 Offset: 0x941F40 VA: 0x180943940
	private Vector3 ImportanceSampleGGX(Vector2 Xi, float roughness) { }

	// RVA: 0x93FF40 Offset: 0x93E540 VA: 0x18093FF40
	private void ApplyConvolution(Texture target) { }

	// RVA: 0x942090 Offset: 0x940690 VA: 0x180942090
	private void CreateMeshes() { }

	// RVA: 0x943220 Offset: 0x941820 VA: 0x180943220
	private void DestroyMeshes() { }

	// RVA: 0x941990 Offset: 0x93FF90 VA: 0x180941990
	private static Mesh CreateBlitMesh() { }

	// RVA: 0x946D40 Offset: 0x945340 VA: 0x180946D40
	private static ReflectionProbeEx.CubemapSkyboxVertex SubDivVert(ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2) { }

	// RVA: 0x9474F0 Offset: 0x945AF0 VA: 0x1809474F0
	private static void Subdivide(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	// RVA: 0x946ED0 Offset: 0x9454D0 VA: 0x180946ED0
	private static void SubdivideYOnly(List<ReflectionProbeEx.CubemapSkyboxVertex> destArray, ReflectionProbeEx.CubemapSkyboxVertex v1, ReflectionProbeEx.CubemapSkyboxVertex v2, ReflectionProbeEx.CubemapSkyboxVertex v3) { }

	// RVA: 0x9421A0 Offset: 0x9407A0 VA: 0x1809421A0
	private static Mesh CreateSkyboxMesh() { }

	// RVA: 0x943A40 Offset: 0x942040 VA: 0x180943A40
	private bool InitializeCubemapFaceMatrices() { }

	// RVA: 0x942C10 Offset: 0x941210 VA: 0x180942C10
	private void CreateTextures() { }

	// RVA: 0x943350 Offset: 0x941950 VA: 0x180943350
	private void DestroyTextures() { }

	// RVA: 0x945550 Offset: 0x943B50 VA: 0x180945550
	private Material RegisterMaterialReplacement(Material material) { }

	// RVA: 0x943780 Offset: 0x941D80 VA: 0x180943780
	private Material FindMaterialReplacement(Material material) { }

	// RVA: 0x941D90 Offset: 0x940390 VA: 0x180941D90
	private void CreateMaterials() { }

	// RVA: 0x9431B0 Offset: 0x9417B0 VA: 0x1809431B0
	private void DestroyMaterials() { }

	// RVA: 0x941CF0 Offset: 0x9402F0 VA: 0x180941CF0
	private void CreateCommandBuffers() { }

	// RVA: 0x943150 Offset: 0x941750 VA: 0x180943150
	private void DestroyCommandBuffers() { }

	// RVA: 0x9418A0 Offset: 0x93FEA0 VA: 0x1809418A0
	private void ClearCommandBuffers() { }

	// RVA: 0x9406E0 Offset: 0x93ECE0 VA: 0x1809406E0
	private void AttachToLight() { }

	// RVA: 0x943400 Offset: 0x941A00 VA: 0x180943400
	private void DetachFromLight() { }

	// RVA: 0x943610 Offset: 0x941C10 VA: 0x180943610
	private void FindEnvironmentReflection() { }

	// RVA: 0x941550 Offset: 0x93FB50 VA: 0x180941550
	private void BindGlobalProperties() { }

	// RVA: 0x9410C0 Offset: 0x93F6C0 VA: 0x1809410C0
	private void BindGlobalLight() { }

	// RVA: 0x940800 Offset: 0x93EE00 VA: 0x180940800
	private void BindGlobalAmbient() { }

	// RVA: 0x941650 Offset: 0x93FC50 VA: 0x180941650
	private void BindGlobalReflection() { }

	// RVA: 0x945930 Offset: 0x943F30 VA: 0x180945930
	private void RenderObjects() { }

	// RVA: 0x946280 Offset: 0x944880 VA: 0x180946280
	private void RenderSkybox() { }

	// RVA: 0x943FB0 Offset: 0x9425B0 VA: 0x180943FB0
	private void IssueRender() { }

	// RVA: 0x943ED0 Offset: 0x9424D0 VA: 0x180943ED0
	private void IssueGenerateMips() { }

	// RVA: 0x943BB0 Offset: 0x9421B0 VA: 0x180943BB0
	private void IssueConvolution() { }

	// RVA: 0x9441E0 Offset: 0x9427E0 VA: 0x1809441E0
	private void IssueShadow() { }

	// RVA: 0x945340 Offset: 0x943940 VA: 0x180945340
	private void PrepareFullRender() { }

	// RVA: 0x945420 Offset: 0x943A20 VA: 0x180945420
	private void PrepareTimeSlicedRender(ReflectionProbeEx.TimeSlicingState state) { }

	// RVA: 0x9434D0 Offset: 0x941AD0 VA: 0x1809434D0
	private void ExecuteRender() { }

	// RVA: 0x943560 Offset: 0x941B60 VA: 0x180943560
	private int FastLog2(int value) { }

	// RVA: 0x9468B0 Offset: 0x944EB0 VA: 0x1809468B0
	private uint ReverseBits(uint bits) { }

	// RVA: 0x946CA0 Offset: 0x9452A0 VA: 0x180946CA0
	private void SafeCreateMaterial(ref Material mat, Shader shader) { }

	// RVA: 0x946BA0 Offset: 0x9451A0 VA: 0x180946BA0
	private void SafeCreateMaterial(ref Material mat, string shaderName) { }

	// RVA: 0x9469B0 Offset: 0x944FB0 VA: 0x1809469B0
	private void SafeCreateCubeRT(ref RenderTexture rt, string name, int size, int depth, bool mips, TextureDimension dim, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite = 1) { }

	// RVA: 0x946920 Offset: 0x944F20 VA: 0x180946920
	private void SafeCreateCB(ref CommandBuffer cb, string name) { }

	// RVA: -1 Offset: -1
	private void SafeDestroy<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFF180 Offset: 0xCFD780 VA: 0x180CFF180
	|-ReflectionProbeEx.SafeDestroy<object>
	|-ReflectionProbeEx.SafeDestroy<Material>
	|-ReflectionProbeEx.SafeDestroy<RenderTexture>
	*/

	// RVA: -1 Offset: -1
	private void SafeDispose<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFF220 Offset: 0xCFD820 VA: 0x180CFF220
	|-ReflectionProbeEx.SafeDispose<object>
	|-ReflectionProbeEx.SafeDispose<CommandBuffer>
	*/

	// RVA: 0x7A9690 Offset: 0x7A7C90 VA: 0x1807A9690
	public RenderTexture get_Texture() { }

	// RVA: 0x941940 Offset: 0x93FF40 VA: 0x180941940
	public void ClearRenderList() { }

	// RVA: 0x93FE80 Offset: 0x93E480 VA: 0x18093FE80
	public void AddToRenderList(Renderer renderer, bool alwaysEnabled = False) { }

	// RVA: 0x9407B0 Offset: 0x93EDB0 VA: 0x1809407B0
	private void Awake() { }

	// RVA: 0x944E50 Offset: 0x943450 VA: 0x180944E50
	private void OnEnable() { }

	// RVA: 0x944B30 Offset: 0x943130 VA: 0x180944B30
	private void OnDisable() { }

	// RVA: 0x944680 Offset: 0x942C80 VA: 0x180944680
	private void OnCameraPreRender(Camera cam) { }

	// RVA: 0x946260 Offset: 0x944860 VA: 0x180946260
	public void RenderProbe() { }

	// RVA: 0x943B90 Offset: 0x942190 VA: 0x180943B90
	public bool IsFinishedRendering() { }

	// RVA: 0x944560 Offset: 0x942B60 VA: 0x180944560
	private void ModifyProbeProperties() { }

	// RVA: 0x9467F0 Offset: 0x944DF0 VA: 0x1809467F0
	private void RestoreProbeSettings() { }

	// RVA: 0x9478F0 Offset: 0x945EF0 VA: 0x1809478F0
	private bool UpdateProperties() { }

	// RVA: 0x949C20 Offset: 0x948220 VA: 0x180949C20
	public void .ctor() { }

	// RVA: 0x947BD0 Offset: 0x9461D0 VA: 0x180947BD0
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

