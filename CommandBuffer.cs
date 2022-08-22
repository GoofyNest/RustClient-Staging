public class CommandBuffer : IDisposable // TypeDefIndex: 3841
{	internal IntPtr m_Ptr; // 0x10

	public string name { get; set; }


	[FreeFunctionAttribute] // RVA: 0x752F0 Offset: 0x746F0 VA: 0x1800752F0
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x754A0 Offset: 0x748A0 VA: 0x1800754A0
	private static IntPtr InitBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x755D0 Offset: 0x749D0 VA: 0x1800755D0
	private void ReleaseBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x756D0 Offset: 0x74AD0 VA: 0x1800756D0
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0x75A30 Offset: 0x74E30 VA: 0x180075A30
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunctionAttribute] // RVA: 0x75D90 Offset: 0x75190 VA: 0x180075D90
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x75F60 Offset: 0x75360 VA: 0x180075F60
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x761A0 Offset: 0x755A0 VA: 0x1800761A0
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethodAttribute] // RVA: 0x762D0 Offset: 0x756D0 VA: 0x1800762D0
	private void Internal_GenerateMips(RenderTexture rt) { }

	public string get_name() { }

	public void set_name(string value) { }

	[NativeMethodAttribute] // RVA: 0x763F0 Offset: 0x757F0 VA: 0x1800763F0
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x76510 Offset: 0x75910 VA: 0x180076510
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethodAttribute] // RVA: 0x76710 Offset: 0x75B10 VA: 0x180076710
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[FreeFunctionAttribute] // RVA: 0x769C0 Offset: 0x75DC0 VA: 0x1800769C0
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76A80 Offset: 0x75E80 VA: 0x180076A80
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76BC0 Offset: 0x75FC0 VA: 0x180076BC0
	public void SetViewport(Rect pixelRect) { }

	[FreeFunctionAttribute] // RVA: 0x76DD0 Offset: 0x761D0 VA: 0x180076DD0
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunctionAttribute] // RVA: 0x76EF0 Offset: 0x762F0 VA: 0x180076EF0
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x77050 Offset: 0x76450 VA: 0x180077050
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x771B0 Offset: 0x765B0 VA: 0x1800771B0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter) { }

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer) { }

	public void GetTemporaryRT(int nameID, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x77290 Offset: 0x76690 VA: 0x180077290
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x77420 Offset: 0x76820 VA: 0x180077420
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunctionAttribute] // RVA: 0x77530 Offset: 0x76930 VA: 0x180077530
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x775E0 Offset: 0x769E0 VA: 0x1800775E0
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunctionAttribute] // RVA: 0x77760 Offset: 0x76B60 VA: 0x180077760
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunctionAttribute] // RVA: 0x77840 Offset: 0x76C40 VA: 0x180077840
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x779C0 Offset: 0x76DC0 VA: 0x1800779C0
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunctionAttribute] // RVA: 0x77A50 Offset: 0x76E50 VA: 0x180077A50
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77C00 Offset: 0x77000 VA: 0x180077C00
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77D70 Offset: 0x77170 VA: 0x180077D70
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[FreeFunctionAttribute] // RVA: 0x77EB0 Offset: 0x772B0 VA: 0x180077EB0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunctionAttribute] // RVA: 0x78080 Offset: 0x77480 VA: 0x180078080
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x781E0 Offset: 0x775E0 VA: 0x1800781E0
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x78290 Offset: 0x77690 VA: 0x180078290
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x78440 Offset: 0x77840 VA: 0x180078440
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x78570 Offset: 0x77970 VA: 0x180078570
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x78710 Offset: 0x77B10 VA: 0x180078710
	public void BeginSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x78830 Offset: 0x77C30 VA: 0x180078830
	public void EndSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x79ED0 Offset: 0x792D0 VA: 0x180079ED0
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	protected override void Finalize() { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	public void .ctor() { }

	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	public void SetComputeFloatParams(ComputeShader computeShader, string name, float[] values) { }

	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	public void GenerateMips(RenderTexture rt) { }

	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	public void DrawRenderer(Renderer renderer, Material material) { }

	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) { }

	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	public void SetGlobalFloat(string name, float value) { }

	public void SetGlobalInt(string name, int value) { }

	public void SetGlobalVector(string name, Vector4 value) { }

	public void SetGlobalColor(string name, Color value) { }

	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	public void SetGlobalBuffer(string name, ComputeBuffer value) { }

	public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val) { }

	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	private void SetViewport_Injected(ref Rect pixelRect) { }

	private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	private void ClearRenderTarget_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	private void SetGlobalColor_Injected(int nameID, ref Color value) { }

	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) { }

	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	private void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

}

