public class CommandBuffer : IDisposable // TypeDefIndex: 3841
{	internal IntPtr m_Ptr; // 0x10

	public string name { get; set; }


	[FreeFunctionAttribute] // RVA: 0x754A0 Offset: 0x748A0 VA: 0x1800754A0
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x75620 Offset: 0x74A20 VA: 0x180075620
	private static IntPtr InitBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x75700 Offset: 0x74B00 VA: 0x180075700
	private void ReleaseBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x75800 Offset: 0x74C00 VA: 0x180075800
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0x75AD0 Offset: 0x74ED0 VA: 0x180075AD0
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunctionAttribute] // RVA: 0x75E40 Offset: 0x75240 VA: 0x180075E40
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x76010 Offset: 0x75410 VA: 0x180076010
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x76210 Offset: 0x75610 VA: 0x180076210
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethodAttribute] // RVA: 0x76380 Offset: 0x75780 VA: 0x180076380
	private void Internal_GenerateMips(RenderTexture rt) { }

	public string get_name() { }

	public void set_name(string value) { }

	[NativeMethodAttribute] // RVA: 0x76500 Offset: 0x75900 VA: 0x180076500
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x76650 Offset: 0x75A50 VA: 0x180076650
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethodAttribute] // RVA: 0x76870 Offset: 0x75C70 VA: 0x180076870
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[FreeFunctionAttribute] // RVA: 0x76A80 Offset: 0x75E80 VA: 0x180076A80
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76B80 Offset: 0x75F80 VA: 0x180076B80
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76C50 Offset: 0x76050 VA: 0x180076C50
	public void SetViewport(Rect pixelRect) { }

	[FreeFunctionAttribute] // RVA: 0x76E20 Offset: 0x76220 VA: 0x180076E20
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunctionAttribute] // RVA: 0x76F40 Offset: 0x76340 VA: 0x180076F40
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x770A0 Offset: 0x764A0 VA: 0x1800770A0
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x771F0 Offset: 0x765F0 VA: 0x1800771F0
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

	[FreeFunctionAttribute] // RVA: 0x772D0 Offset: 0x766D0 VA: 0x1800772D0
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x77500 Offset: 0x76900 VA: 0x180077500
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunctionAttribute] // RVA: 0x77640 Offset: 0x76A40 VA: 0x180077640
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x77720 Offset: 0x76B20 VA: 0x180077720
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunctionAttribute] // RVA: 0x778E0 Offset: 0x76CE0 VA: 0x1800778E0
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunctionAttribute] // RVA: 0x779E0 Offset: 0x76DE0 VA: 0x1800779E0
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x77AE0 Offset: 0x76EE0 VA: 0x180077AE0
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunctionAttribute] // RVA: 0x77C30 Offset: 0x77030 VA: 0x180077C30
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x77D60 Offset: 0x77160 VA: 0x180077D60
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77E30 Offset: 0x77230 VA: 0x180077E30
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77F90 Offset: 0x77390 VA: 0x180077F90
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[FreeFunctionAttribute] // RVA: 0x780D0 Offset: 0x774D0 VA: 0x1800780D0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunctionAttribute] // RVA: 0x78200 Offset: 0x77600 VA: 0x180078200
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x78350 Offset: 0x77750 VA: 0x180078350
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x783F0 Offset: 0x777F0 VA: 0x1800783F0
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x78570 Offset: 0x77970 VA: 0x180078570
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x78670 Offset: 0x77A70 VA: 0x180078670
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x78800 Offset: 0x77C00 VA: 0x180078800
	public void BeginSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x78910 Offset: 0x77D10 VA: 0x180078910
	public void EndSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x79FA0 Offset: 0x793A0 VA: 0x180079FA0
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

