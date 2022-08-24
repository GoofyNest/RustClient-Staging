public class CommandBuffer : IDisposable // TypeDefIndex: 3841
{	internal IntPtr m_Ptr; // 0x10

	public string name { get; set; }


	[FreeFunctionAttribute] // RVA: 0x753B0 Offset: 0x747B0 VA: 0x1800753B0
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x75560 Offset: 0x74960 VA: 0x180075560
	private static IntPtr InitBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x75650 Offset: 0x74A50 VA: 0x180075650
	private void ReleaseBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x75720 Offset: 0x74B20 VA: 0x180075720
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0x75A70 Offset: 0x74E70 VA: 0x180075A70
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunctionAttribute] // RVA: 0x75E30 Offset: 0x75230 VA: 0x180075E30
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x76050 Offset: 0x75450 VA: 0x180076050
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x76220 Offset: 0x75620 VA: 0x180076220
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethodAttribute] // RVA: 0x763B0 Offset: 0x757B0 VA: 0x1800763B0
	private void Internal_GenerateMips(RenderTexture rt) { }

	public string get_name() { }

	public void set_name(string value) { }

	[NativeMethodAttribute] // RVA: 0x76510 Offset: 0x75910 VA: 0x180076510
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x76600 Offset: 0x75A00 VA: 0x180076600
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethodAttribute] // RVA: 0x767D0 Offset: 0x75BD0 VA: 0x1800767D0
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[FreeFunctionAttribute] // RVA: 0x76A00 Offset: 0x75E00 VA: 0x180076A00
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76B20 Offset: 0x75F20 VA: 0x180076B20
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76C40 Offset: 0x76040 VA: 0x180076C40
	public void SetViewport(Rect pixelRect) { }

	[FreeFunctionAttribute] // RVA: 0x76E70 Offset: 0x76270 VA: 0x180076E70
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunctionAttribute] // RVA: 0x76FD0 Offset: 0x763D0 VA: 0x180076FD0
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x77130 Offset: 0x76530 VA: 0x180077130
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x77250 Offset: 0x76650 VA: 0x180077250
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

	[FreeFunctionAttribute] // RVA: 0x77340 Offset: 0x76740 VA: 0x180077340
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x77510 Offset: 0x76910 VA: 0x180077510
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunctionAttribute] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x776C0 Offset: 0x76AC0 VA: 0x1800776C0
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunctionAttribute] // RVA: 0x77810 Offset: 0x76C10 VA: 0x180077810
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunctionAttribute] // RVA: 0x77900 Offset: 0x76D00 VA: 0x180077900
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x77A10 Offset: 0x76E10 VA: 0x180077A10
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunctionAttribute] // RVA: 0x77AD0 Offset: 0x76ED0 VA: 0x180077AD0
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x77C10 Offset: 0x77010 VA: 0x180077C10
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77CB0 Offset: 0x770B0 VA: 0x180077CB0
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77E20 Offset: 0x77220 VA: 0x180077E20
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[FreeFunctionAttribute] // RVA: 0x77F80 Offset: 0x77380 VA: 0x180077F80
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunctionAttribute] // RVA: 0x780C0 Offset: 0x774C0 VA: 0x1800780C0
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x781F0 Offset: 0x775F0 VA: 0x1800781F0
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x78320 Offset: 0x77720 VA: 0x180078320
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x78500 Offset: 0x77900 VA: 0x180078500
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x78630 Offset: 0x77A30 VA: 0x180078630
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x787E0 Offset: 0x77BE0 VA: 0x1800787E0
	public void BeginSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x78910 Offset: 0x77D10 VA: 0x180078910
	public void EndSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x79FB0 Offset: 0x793B0 VA: 0x180079FB0
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

