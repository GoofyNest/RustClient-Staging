public class CommandBuffer : IDisposable // TypeDefIndex: 3841
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x752F0 Offset: 0x746F0 VA: 0x1800752F0
	// RVA: 0x1995410 Offset: 0x1993A10 VA: 0x181995410
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x754A0 Offset: 0x748A0 VA: 0x1800754A0
	// RVA: 0x1995070 Offset: 0x1993670 VA: 0x181995070
	private static IntPtr InitBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x755D0 Offset: 0x749D0 VA: 0x1800755D0
	// RVA: 0x19955B0 Offset: 0x1993BB0 VA: 0x1819955B0
	private void ReleaseBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x756D0 Offset: 0x74AD0 VA: 0x1800756D0
	// RVA: 0x19958E0 Offset: 0x1993EE0 VA: 0x1819958E0
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0x75A30 Offset: 0x74E30 VA: 0x180075A30
	// RVA: 0x1995330 Offset: 0x1993930 VA: 0x181995330
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunctionAttribute] // RVA: 0x75D90 Offset: 0x75190 VA: 0x180075D90
	// RVA: 0x19953A0 Offset: 0x19939A0 VA: 0x1819953A0
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x75F60 Offset: 0x75360 VA: 0x180075F60
	// RVA: 0x19956C0 Offset: 0x1993CC0 VA: 0x1819956C0
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x761A0 Offset: 0x755A0 VA: 0x1800761A0
	// RVA: 0x19936C0 Offset: 0x1991CC0 VA: 0x1819936C0
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethodAttribute] // RVA: 0x762D0 Offset: 0x756D0 VA: 0x1800762D0
	// RVA: 0x19952E0 Offset: 0x19938E0 VA: 0x1819952E0
	private void Internal_GenerateMips(RenderTexture rt) { }

	// RVA: 0x1997370 Offset: 0x1995970 VA: 0x181997370
	public string get_name() { }

	// RVA: 0x19973B0 Offset: 0x19959B0 VA: 0x1819973B0
	public void set_name(string value) { }

	[NativeMethodAttribute] // RVA: 0x763F0 Offset: 0x757F0 VA: 0x1800763F0
	// RVA: 0x1993370 Offset: 0x1991970 VA: 0x181993370
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x76510 Offset: 0x75910 VA: 0x180076510
	// RVA: 0x19951F0 Offset: 0x19937F0 VA: 0x1819951F0
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethodAttribute] // RVA: 0x76710 Offset: 0x75B10 VA: 0x180076710
	// RVA: 0x1995270 Offset: 0x1993870 VA: 0x181995270
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[FreeFunctionAttribute] // RVA: 0x769C0 Offset: 0x75DC0 VA: 0x1800769C0
	// RVA: 0x1995110 Offset: 0x1993710 VA: 0x181995110
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76A80 Offset: 0x75E80 VA: 0x180076A80
	// RVA: 0x19950A0 Offset: 0x19936A0 VA: 0x1819950A0
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76BC0 Offset: 0x75FC0 VA: 0x180076BC0
	// RVA: 0x1997290 Offset: 0x1995890 VA: 0x181997290
	public void SetViewport(Rect pixelRect) { }

	[FreeFunctionAttribute] // RVA: 0x76DD0 Offset: 0x761D0 VA: 0x180076DD0
	// RVA: 0x19933B0 Offset: 0x19919B0 VA: 0x1819933B0
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunctionAttribute] // RVA: 0x76EF0 Offset: 0x762F0 VA: 0x180076EF0
	// RVA: 0x1992A70 Offset: 0x1991070 VA: 0x181992A70
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x77050 Offset: 0x76450 VA: 0x180077050
	// RVA: 0x1992960 Offset: 0x1990F60 VA: 0x181992960
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x771B0 Offset: 0x765B0 VA: 0x1800771B0
	// RVA: 0x1994B80 Offset: 0x1993180 VA: 0x181994B80
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x1994A60 Offset: 0x1993060 VA: 0x181994A60
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x1994720 Offset: 0x1992D20 VA: 0x181994720
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	// RVA: 0x1994AE0 Offset: 0x19930E0 VA: 0x181994AE0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0x1994F90 Offset: 0x1993590 VA: 0x181994F90
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x1994990 Offset: 0x1992F90 VA: 0x181994990
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x1994E50 Offset: 0x1993450 VA: 0x181994E50
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	// RVA: 0x1994850 Offset: 0x1992E50 VA: 0x181994850
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x1994D10 Offset: 0x1993310 VA: 0x181994D10
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x1994C10 Offset: 0x1993210 VA: 0x181994C10
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x1994C80 Offset: 0x1993280 VA: 0x181994C80
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter) { }

	// RVA: 0x1994910 Offset: 0x1992F10 VA: 0x181994910
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer) { }

	// RVA: 0x1994DD0 Offset: 0x19933D0 VA: 0x181994DD0
	public void GetTemporaryRT(int nameID, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x77290 Offset: 0x76690 VA: 0x180077290
	// RVA: 0x19946C0 Offset: 0x1992CC0 VA: 0x1819946C0
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19947D0 Offset: 0x1992DD0 VA: 0x1819947D0
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x1994F20 Offset: 0x1993520 VA: 0x181994F20
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x77420 Offset: 0x76820 VA: 0x180077420
	// RVA: 0x19955F0 Offset: 0x1993BF0 VA: 0x1819955F0
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunctionAttribute] // RVA: 0x77530 Offset: 0x76930 VA: 0x180077530
	// RVA: 0x1993240 Offset: 0x1991840 VA: 0x181993240
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x19932C0 Offset: 0x19918C0 VA: 0x1819932C0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x775E0 Offset: 0x769E0 VA: 0x1800775E0
	// RVA: 0x1995BF0 Offset: 0x19941F0 VA: 0x181995BF0
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunctionAttribute] // RVA: 0x77760 Offset: 0x76B60 VA: 0x180077760
	// RVA: 0x1995CC0 Offset: 0x19942C0 VA: 0x181995CC0
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunctionAttribute] // RVA: 0x77840 Offset: 0x76C40 VA: 0x180077840
	// RVA: 0x1996310 Offset: 0x1994910 VA: 0x181996310
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x779C0 Offset: 0x76DC0 VA: 0x1800779C0
	// RVA: 0x1995BA0 Offset: 0x19941A0 VA: 0x181995BA0
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunctionAttribute] // RVA: 0x77A50 Offset: 0x76E50 VA: 0x180077A50
	// RVA: 0x1995F50 Offset: 0x1994550 VA: 0x181995F50
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	// RVA: 0x1994400 Offset: 0x1992A00 VA: 0x181994400
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77C00 Offset: 0x77000 VA: 0x180077C00
	// RVA: 0x1993670 Offset: 0x1991C70 VA: 0x181993670
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77D70 Offset: 0x77170 VA: 0x180077D70
	// RVA: 0x19971E0 Offset: 0x19957E0 VA: 0x1819971E0
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[FreeFunctionAttribute] // RVA: 0x77EB0 Offset: 0x772B0 VA: 0x180077EB0
	// RVA: 0x19972E0 Offset: 0x19958E0 VA: 0x1819972E0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunctionAttribute] // RVA: 0x78080 Offset: 0x77480 VA: 0x180078080
	// RVA: 0x19961E0 Offset: 0x19947E0 VA: 0x1819961E0
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x781E0 Offset: 0x775E0 VA: 0x1800781E0
	// RVA: 0x1995D90 Offset: 0x1994390 VA: 0x181995D90
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x78290 Offset: 0x77690 VA: 0x180078290
	// RVA: 0x1995FA0 Offset: 0x19945A0 VA: 0x181995FA0
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x78440 Offset: 0x77840 VA: 0x180078440
	// RVA: 0x19959F0 Offset: 0x1993FF0 VA: 0x1819959F0
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x78570 Offset: 0x77970 VA: 0x180078570
	// RVA: 0x19970A0 Offset: 0x19956A0 VA: 0x1819970A0
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x78710 Offset: 0x77B10 VA: 0x180078710
	// RVA: 0x19928A0 Offset: 0x1990EA0 VA: 0x1819928A0
	public void BeginSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x78830 Offset: 0x77C30 VA: 0x180078830
	// RVA: 0x1994450 Offset: 0x1992A50 VA: 0x181994450
	public void EndSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x79ED0 Offset: 0x792D0 VA: 0x180079ED0
	// RVA: 0x1995450 Offset: 0x1993A50 VA: 0x181995450
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x1996640 Offset: 0x1994C40 VA: 0x181996640
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x1996900 Offset: 0x1994F00 VA: 0x181996900
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	// RVA: 0x19966E0 Offset: 0x1994CE0 VA: 0x1819966E0
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x1996A10 Offset: 0x1995010 VA: 0x181996A10
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x1996AF0 Offset: 0x19950F0 VA: 0x181996AF0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x1996D30 Offset: 0x1995330 VA: 0x181996D30
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x1996EA0 Offset: 0x19954A0 VA: 0x181996EA0
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	// RVA: 0x19965C0 Offset: 0x1994BC0 VA: 0x1819965C0
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19963D0 Offset: 0x19949D0 VA: 0x1819963D0
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19964C0 Offset: 0x1994AC0 VA: 0x1819964C0
	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19944A0 Offset: 0x1992AA0 VA: 0x1819944A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1993730 Offset: 0x1991D30 VA: 0x181993730 Slot: 4
	public void Dispose() { }

	// RVA: 0x19937D0 Offset: 0x1991DD0 VA: 0x1819937D0
	private void Dispose(bool disposing) { }

	// RVA: 0x1997330 Offset: 0x1995930 VA: 0x181997330
	public void .ctor() { }

	// RVA: 0x1995950 Offset: 0x1993F50 VA: 0x181995950
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	// RVA: 0x1995730 Offset: 0x1993D30 VA: 0x181995730
	public void SetComputeFloatParams(ComputeShader computeShader, string name, float[] values) { }

	// RVA: 0x19957C0 Offset: 0x1993DC0 VA: 0x1819957C0
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	// RVA: 0x1995630 Offset: 0x1993C30 VA: 0x181995630
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x19936C0 Offset: 0x1991CC0 VA: 0x1819936C0
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x1994570 Offset: 0x1992B70 VA: 0x181994570
	public void GenerateMips(RenderTexture rt) { }

	// RVA: 0x1993F20 Offset: 0x1992520 VA: 0x181993F20
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x1993E50 Offset: 0x1992450 VA: 0x181993E50
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x1993EC0 Offset: 0x19924C0 VA: 0x181993EC0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x19941E0 Offset: 0x19927E0 VA: 0x1819941E0
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x19941C0 Offset: 0x19927C0 VA: 0x1819941C0
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x19943D0 Offset: 0x19929D0 VA: 0x1819943D0
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x1993A80 Offset: 0x1992080 VA: 0x181993A80
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	// RVA: 0x1993830 Offset: 0x1991E30 VA: 0x181993830
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	// RVA: 0x1993500 Offset: 0x1991B00 VA: 0x181993500
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x19935B0 Offset: 0x1991BB0 VA: 0x1819935B0
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	// RVA: 0x1993420 Offset: 0x1991A20 VA: 0x181993420
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) { }

	// RVA: 0x1992C30 Offset: 0x1991230 VA: 0x181992C30
	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	// RVA: 0x1992B10 Offset: 0x1991110 VA: 0x181992B10
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x1992D50 Offset: 0x1991350 VA: 0x181992D50
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x1992F90 Offset: 0x1991590 VA: 0x181992F90
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x19930B0 Offset: 0x19916B0 VA: 0x1819930B0
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x1992E70 Offset: 0x1991470 VA: 0x181992E70
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x1995C40 Offset: 0x1994240 VA: 0x181995C40
	public void SetGlobalFloat(string name, float value) { }

	// RVA: 0x1995D10 Offset: 0x1994310 VA: 0x181995D10
	public void SetGlobalInt(string name, int value) { }

	// RVA: 0x1996280 Offset: 0x1994880 VA: 0x181996280
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x1995B10 Offset: 0x1994110 VA: 0x181995B10
	public void SetGlobalColor(string name, Color value) { }

	// RVA: 0x1995EB0 Offset: 0x19944B0 VA: 0x181995EB0
	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x1996160 Offset: 0x1994760 VA: 0x181996160
	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	// RVA: 0x1995DE0 Offset: 0x19943E0 VA: 0x181995DE0
	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	// RVA: 0x1996060 Offset: 0x1994660 VA: 0x181996060
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	// RVA: 0x1996000 Offset: 0x1994600 VA: 0x181996000
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x1996100 Offset: 0x1994700 VA: 0x181996100
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0x1995A40 Offset: 0x1994040 VA: 0x181995A40
	public void SetGlobalBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x1997100 Offset: 0x1995700 VA: 0x181997100
	public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	// RVA: 0x1995410 Offset: 0x1993A10 VA: 0x181995410
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	// RVA: 0x19954C0 Offset: 0x1993AC0 VA: 0x1819954C0
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x1995870 Offset: 0x1993E70 VA: 0x181995870
	private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val) { }

	// RVA: 0x1995180 Offset: 0x1993780 VA: 0x181995180
	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x1997240 Offset: 0x1995840 VA: 0x181997240
	private void SetViewport_Injected(ref Rect pixelRect) { }

	// RVA: 0x1992A00 Offset: 0x1991000 VA: 0x181992A00
	private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x19928F0 Offset: 0x1990EF0 VA: 0x1819928F0
	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x1994660 Offset: 0x1992C60 VA: 0x181994660
	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19931D0 Offset: 0x19917D0 VA: 0x1819931D0
	private void ClearRenderTarget_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x1996230 Offset: 0x1994830 VA: 0x181996230
	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	// RVA: 0x1995AC0 Offset: 0x19940C0 VA: 0x181995AC0
	private void SetGlobalColor_Injected(int nameID, ref Color value) { }

	// RVA: 0x1995E60 Offset: 0x1994460 VA: 0x181995E60
	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) { }

	// RVA: 0x1997180 Offset: 0x1995780 VA: 0x181997180
	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	// RVA: 0x1996550 Offset: 0x1994B50 VA: 0x181996550
	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x1996360 Offset: 0x1994960 VA: 0x181996360
	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x1996450 Offset: 0x1994A50 VA: 0x181996450
	private void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

}

