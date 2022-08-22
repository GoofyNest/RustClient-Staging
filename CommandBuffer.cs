public class CommandBuffer : IDisposable // TypeDefIndex: 3841
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x752F0 Offset: 0x746F0 VA: 0x1800752F0
	// RVA: 0x19A7D50 Offset: 0x19A6350 VA: 0x1819A7D50
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x754A0 Offset: 0x748A0 VA: 0x1800754A0
	// RVA: 0x19A79B0 Offset: 0x19A5FB0 VA: 0x1819A79B0
	private static IntPtr InitBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x755D0 Offset: 0x749D0 VA: 0x1800755D0
	// RVA: 0x19A7EF0 Offset: 0x19A64F0 VA: 0x1819A7EF0
	private void ReleaseBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x756D0 Offset: 0x74AD0 VA: 0x1800756D0
	// RVA: 0x19A8220 Offset: 0x19A6820 VA: 0x1819A8220
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0x75A30 Offset: 0x74E30 VA: 0x180075A30
	// RVA: 0x19A7C70 Offset: 0x19A6270 VA: 0x1819A7C70
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunctionAttribute] // RVA: 0x75D90 Offset: 0x75190 VA: 0x180075D90
	// RVA: 0x19A7CE0 Offset: 0x19A62E0 VA: 0x1819A7CE0
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x75F60 Offset: 0x75360 VA: 0x180075F60
	// RVA: 0x19A8000 Offset: 0x19A6600 VA: 0x1819A8000
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x761A0 Offset: 0x755A0 VA: 0x1800761A0
	// RVA: 0x19A6000 Offset: 0x19A4600 VA: 0x1819A6000
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethodAttribute] // RVA: 0x762D0 Offset: 0x756D0 VA: 0x1800762D0
	// RVA: 0x19A7C20 Offset: 0x19A6220 VA: 0x1819A7C20
	private void Internal_GenerateMips(RenderTexture rt) { }

	// RVA: 0x19A9CB0 Offset: 0x19A82B0 VA: 0x1819A9CB0
	public string get_name() { }

	// RVA: 0x19A9CF0 Offset: 0x19A82F0 VA: 0x1819A9CF0
	public void set_name(string value) { }

	[NativeMethodAttribute] // RVA: 0x763F0 Offset: 0x757F0 VA: 0x1800763F0
	// RVA: 0x19A5CB0 Offset: 0x19A42B0 VA: 0x1819A5CB0
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x76510 Offset: 0x75910 VA: 0x180076510
	// RVA: 0x19A7B30 Offset: 0x19A6130 VA: 0x1819A7B30
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethodAttribute] // RVA: 0x76710 Offset: 0x75B10 VA: 0x180076710
	// RVA: 0x19A7BB0 Offset: 0x19A61B0 VA: 0x1819A7BB0
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[FreeFunctionAttribute] // RVA: 0x769C0 Offset: 0x75DC0 VA: 0x1800769C0
	// RVA: 0x19A7A50 Offset: 0x19A6050 VA: 0x1819A7A50
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76A80 Offset: 0x75E80 VA: 0x180076A80
	// RVA: 0x19A79E0 Offset: 0x19A5FE0 VA: 0x1819A79E0
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76BC0 Offset: 0x75FC0 VA: 0x180076BC0
	// RVA: 0x19A9BD0 Offset: 0x19A81D0 VA: 0x1819A9BD0
	public void SetViewport(Rect pixelRect) { }

	[FreeFunctionAttribute] // RVA: 0x76DD0 Offset: 0x761D0 VA: 0x180076DD0
	// RVA: 0x19A5CF0 Offset: 0x19A42F0 VA: 0x1819A5CF0
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunctionAttribute] // RVA: 0x76EF0 Offset: 0x762F0 VA: 0x180076EF0
	// RVA: 0x19A53B0 Offset: 0x19A39B0 VA: 0x1819A53B0
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x77050 Offset: 0x76450 VA: 0x180077050
	// RVA: 0x19A52A0 Offset: 0x19A38A0 VA: 0x1819A52A0
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x771B0 Offset: 0x765B0 VA: 0x1800771B0
	// RVA: 0x19A74C0 Offset: 0x19A5AC0 VA: 0x1819A74C0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x19A73A0 Offset: 0x19A59A0 VA: 0x1819A73A0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x19A7060 Offset: 0x19A5660 VA: 0x1819A7060
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	// RVA: 0x19A7420 Offset: 0x19A5A20 VA: 0x1819A7420
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0x19A78D0 Offset: 0x19A5ED0 VA: 0x1819A78D0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x19A72D0 Offset: 0x19A58D0 VA: 0x1819A72D0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x19A7790 Offset: 0x19A5D90 VA: 0x1819A7790
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	// RVA: 0x19A7190 Offset: 0x19A5790 VA: 0x1819A7190
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x19A7650 Offset: 0x19A5C50 VA: 0x1819A7650
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x19A7550 Offset: 0x19A5B50 VA: 0x1819A7550
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x19A75C0 Offset: 0x19A5BC0 VA: 0x1819A75C0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter) { }

	// RVA: 0x19A7250 Offset: 0x19A5850 VA: 0x1819A7250
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer) { }

	// RVA: 0x19A7710 Offset: 0x19A5D10 VA: 0x1819A7710
	public void GetTemporaryRT(int nameID, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x77290 Offset: 0x76690 VA: 0x180077290
	// RVA: 0x19A7000 Offset: 0x19A5600 VA: 0x1819A7000
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A7110 Offset: 0x19A5710 VA: 0x1819A7110
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A7860 Offset: 0x19A5E60 VA: 0x1819A7860
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x77420 Offset: 0x76820 VA: 0x180077420
	// RVA: 0x19A7F30 Offset: 0x19A6530 VA: 0x1819A7F30
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunctionAttribute] // RVA: 0x77530 Offset: 0x76930 VA: 0x180077530
	// RVA: 0x19A5B80 Offset: 0x19A4180 VA: 0x1819A5B80
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x19A5C00 Offset: 0x19A4200 VA: 0x1819A5C00
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x775E0 Offset: 0x769E0 VA: 0x1800775E0
	// RVA: 0x19A8530 Offset: 0x19A6B30 VA: 0x1819A8530
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunctionAttribute] // RVA: 0x77760 Offset: 0x76B60 VA: 0x180077760
	// RVA: 0x19A8600 Offset: 0x19A6C00 VA: 0x1819A8600
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunctionAttribute] // RVA: 0x77840 Offset: 0x76C40 VA: 0x180077840
	// RVA: 0x19A8C50 Offset: 0x19A7250 VA: 0x1819A8C50
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x779C0 Offset: 0x76DC0 VA: 0x1800779C0
	// RVA: 0x19A84E0 Offset: 0x19A6AE0 VA: 0x1819A84E0
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunctionAttribute] // RVA: 0x77A50 Offset: 0x76E50 VA: 0x180077A50
	// RVA: 0x19A8890 Offset: 0x19A6E90 VA: 0x1819A8890
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	// RVA: 0x19A6D40 Offset: 0x19A5340 VA: 0x1819A6D40
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77C00 Offset: 0x77000 VA: 0x180077C00
	// RVA: 0x19A5FB0 Offset: 0x19A45B0 VA: 0x1819A5FB0
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77D70 Offset: 0x77170 VA: 0x180077D70
	// RVA: 0x19A9B20 Offset: 0x19A8120 VA: 0x1819A9B20
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[FreeFunctionAttribute] // RVA: 0x77EB0 Offset: 0x772B0 VA: 0x180077EB0
	// RVA: 0x19A9C20 Offset: 0x19A8220 VA: 0x1819A9C20
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunctionAttribute] // RVA: 0x78080 Offset: 0x77480 VA: 0x180078080
	// RVA: 0x19A8B20 Offset: 0x19A7120 VA: 0x1819A8B20
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x781E0 Offset: 0x775E0 VA: 0x1800781E0
	// RVA: 0x19A86D0 Offset: 0x19A6CD0 VA: 0x1819A86D0
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x78290 Offset: 0x77690 VA: 0x180078290
	// RVA: 0x19A88E0 Offset: 0x19A6EE0 VA: 0x1819A88E0
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x78440 Offset: 0x77840 VA: 0x180078440
	// RVA: 0x19A8330 Offset: 0x19A6930 VA: 0x1819A8330
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x78570 Offset: 0x77970 VA: 0x180078570
	// RVA: 0x19A99E0 Offset: 0x19A7FE0 VA: 0x1819A99E0
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x78710 Offset: 0x77B10 VA: 0x180078710
	// RVA: 0x19A51E0 Offset: 0x19A37E0 VA: 0x1819A51E0
	public void BeginSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x78830 Offset: 0x77C30 VA: 0x180078830
	// RVA: 0x19A6D90 Offset: 0x19A5390 VA: 0x1819A6D90
	public void EndSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x79ED0 Offset: 0x792D0 VA: 0x180079ED0
	// RVA: 0x19A7D90 Offset: 0x19A6390 VA: 0x1819A7D90
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x19A8F80 Offset: 0x19A7580 VA: 0x1819A8F80
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x19A9240 Offset: 0x19A7840 VA: 0x1819A9240
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	// RVA: 0x19A9020 Offset: 0x19A7620 VA: 0x1819A9020
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x19A9350 Offset: 0x19A7950 VA: 0x1819A9350
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x19A9430 Offset: 0x19A7A30 VA: 0x1819A9430
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x19A9670 Offset: 0x19A7C70 VA: 0x1819A9670
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A97E0 Offset: 0x19A7DE0 VA: 0x1819A97E0
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	// RVA: 0x19A8F00 Offset: 0x19A7500 VA: 0x1819A8F00
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8D10 Offset: 0x19A7310 VA: 0x1819A8D10
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8E00 Offset: 0x19A7400 VA: 0x1819A8E00
	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A6DE0 Offset: 0x19A53E0 VA: 0x1819A6DE0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19A6070 Offset: 0x19A4670 VA: 0x1819A6070 Slot: 4
	public void Dispose() { }

	// RVA: 0x19A6110 Offset: 0x19A4710 VA: 0x1819A6110
	private void Dispose(bool disposing) { }

	// RVA: 0x19A9C70 Offset: 0x19A8270 VA: 0x1819A9C70
	public void .ctor() { }

	// RVA: 0x19A8290 Offset: 0x19A6890 VA: 0x1819A8290
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	// RVA: 0x19A8070 Offset: 0x19A6670 VA: 0x1819A8070
	public void SetComputeFloatParams(ComputeShader computeShader, string name, float[] values) { }

	// RVA: 0x19A8100 Offset: 0x19A6700 VA: 0x1819A8100
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	// RVA: 0x19A7F70 Offset: 0x19A6570 VA: 0x1819A7F70
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x19A6000 Offset: 0x19A4600 VA: 0x1819A6000
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x19A6EB0 Offset: 0x19A54B0 VA: 0x1819A6EB0
	public void GenerateMips(RenderTexture rt) { }

	// RVA: 0x19A6860 Offset: 0x19A4E60 VA: 0x1819A6860
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x19A6790 Offset: 0x19A4D90 VA: 0x1819A6790
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x19A6800 Offset: 0x19A4E00 VA: 0x1819A6800
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x19A6B20 Offset: 0x19A5120 VA: 0x1819A6B20
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x19A6B00 Offset: 0x19A5100 VA: 0x1819A6B00
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x19A6D10 Offset: 0x19A5310 VA: 0x1819A6D10
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x19A63C0 Offset: 0x19A49C0 VA: 0x1819A63C0
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	// RVA: 0x19A6170 Offset: 0x19A4770 VA: 0x1819A6170
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	// RVA: 0x19A5E40 Offset: 0x19A4440 VA: 0x1819A5E40
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x19A5EF0 Offset: 0x19A44F0 VA: 0x1819A5EF0
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	// RVA: 0x19A5D60 Offset: 0x19A4360 VA: 0x1819A5D60
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) { }

	// RVA: 0x19A5570 Offset: 0x19A3B70 VA: 0x1819A5570
	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	// RVA: 0x19A5450 Offset: 0x19A3A50 VA: 0x1819A5450
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x19A5690 Offset: 0x19A3C90 VA: 0x1819A5690
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x19A58D0 Offset: 0x19A3ED0 VA: 0x1819A58D0
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x19A59F0 Offset: 0x19A3FF0 VA: 0x1819A59F0
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x19A57B0 Offset: 0x19A3DB0 VA: 0x1819A57B0
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x19A8580 Offset: 0x19A6B80 VA: 0x1819A8580
	public void SetGlobalFloat(string name, float value) { }

	// RVA: 0x19A8650 Offset: 0x19A6C50 VA: 0x1819A8650
	public void SetGlobalInt(string name, int value) { }

	// RVA: 0x19A8BC0 Offset: 0x19A71C0 VA: 0x1819A8BC0
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x19A8450 Offset: 0x19A6A50 VA: 0x1819A8450
	public void SetGlobalColor(string name, Color value) { }

	// RVA: 0x19A87F0 Offset: 0x19A6DF0 VA: 0x1819A87F0
	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x19A8AA0 Offset: 0x19A70A0 VA: 0x1819A8AA0
	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	// RVA: 0x19A8720 Offset: 0x19A6D20 VA: 0x1819A8720
	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	// RVA: 0x19A89A0 Offset: 0x19A6FA0 VA: 0x1819A89A0
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	// RVA: 0x19A8940 Offset: 0x19A6F40 VA: 0x1819A8940
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x19A8A40 Offset: 0x19A7040 VA: 0x1819A8A40
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0x19A8380 Offset: 0x19A6980 VA: 0x1819A8380
	public void SetGlobalBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x19A9A40 Offset: 0x19A8040 VA: 0x1819A9A40
	public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	// RVA: 0x19A7D50 Offset: 0x19A6350 VA: 0x1819A7D50
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	// RVA: 0x19A7E00 Offset: 0x19A6400 VA: 0x1819A7E00
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x19A81B0 Offset: 0x19A67B0 VA: 0x1819A81B0
	private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val) { }

	// RVA: 0x19A7AC0 Offset: 0x19A60C0 VA: 0x1819A7AC0
	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x19A9B80 Offset: 0x19A8180 VA: 0x1819A9B80
	private void SetViewport_Injected(ref Rect pixelRect) { }

	// RVA: 0x19A5340 Offset: 0x19A3940 VA: 0x1819A5340
	private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x19A5230 Offset: 0x19A3830 VA: 0x1819A5230
	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x19A6FA0 Offset: 0x19A55A0 VA: 0x1819A6FA0
	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A5B10 Offset: 0x19A4110 VA: 0x1819A5B10
	private void ClearRenderTarget_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x19A8B70 Offset: 0x19A7170 VA: 0x1819A8B70
	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	// RVA: 0x19A8400 Offset: 0x19A6A00 VA: 0x1819A8400
	private void SetGlobalColor_Injected(int nameID, ref Color value) { }

	// RVA: 0x19A87A0 Offset: 0x19A6DA0 VA: 0x1819A87A0
	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) { }

	// RVA: 0x19A9AC0 Offset: 0x19A80C0 VA: 0x1819A9AC0
	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	// RVA: 0x19A8E90 Offset: 0x19A7490 VA: 0x1819A8E90
	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8CA0 Offset: 0x19A72A0 VA: 0x1819A8CA0
	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8D90 Offset: 0x19A7390 VA: 0x1819A8D90
	private void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

}

