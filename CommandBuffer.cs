public class CommandBuffer : IDisposable // TypeDefIndex: 3841
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x752F0 Offset: 0x746F0 VA: 0x1800752F0
	// RVA: 0x19A8010 Offset: 0x19A6610 VA: 0x1819A8010
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x754A0 Offset: 0x748A0 VA: 0x1800754A0
	// RVA: 0x19A7C70 Offset: 0x19A6270 VA: 0x1819A7C70
	private static IntPtr InitBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x755D0 Offset: 0x749D0 VA: 0x1800755D0
	// RVA: 0x19A81B0 Offset: 0x19A67B0 VA: 0x1819A81B0
	private void ReleaseBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x756D0 Offset: 0x74AD0 VA: 0x1800756D0
	// RVA: 0x19A84E0 Offset: 0x19A6AE0 VA: 0x1819A84E0
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0x75A30 Offset: 0x74E30 VA: 0x180075A30
	// RVA: 0x19A7F30 Offset: 0x19A6530 VA: 0x1819A7F30
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunctionAttribute] // RVA: 0x75D90 Offset: 0x75190 VA: 0x180075D90
	// RVA: 0x19A7FA0 Offset: 0x19A65A0 VA: 0x1819A7FA0
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x75F60 Offset: 0x75360 VA: 0x180075F60
	// RVA: 0x19A82C0 Offset: 0x19A68C0 VA: 0x1819A82C0
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x761A0 Offset: 0x755A0 VA: 0x1800761A0
	// RVA: 0x19A62C0 Offset: 0x19A48C0 VA: 0x1819A62C0
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethodAttribute] // RVA: 0x762D0 Offset: 0x756D0 VA: 0x1800762D0
	// RVA: 0x19A7EE0 Offset: 0x19A64E0 VA: 0x1819A7EE0
	private void Internal_GenerateMips(RenderTexture rt) { }

	// RVA: 0x19A9F70 Offset: 0x19A8570 VA: 0x1819A9F70
	public string get_name() { }

	// RVA: 0x19A9FB0 Offset: 0x19A85B0 VA: 0x1819A9FB0
	public void set_name(string value) { }

	[NativeMethodAttribute] // RVA: 0x763F0 Offset: 0x757F0 VA: 0x1800763F0
	// RVA: 0x19A5F70 Offset: 0x19A4570 VA: 0x1819A5F70
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x76510 Offset: 0x75910 VA: 0x180076510
	// RVA: 0x19A7DF0 Offset: 0x19A63F0 VA: 0x1819A7DF0
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethodAttribute] // RVA: 0x76710 Offset: 0x75B10 VA: 0x180076710
	// RVA: 0x19A7E70 Offset: 0x19A6470 VA: 0x1819A7E70
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[FreeFunctionAttribute] // RVA: 0x769C0 Offset: 0x75DC0 VA: 0x1800769C0
	// RVA: 0x19A7D10 Offset: 0x19A6310 VA: 0x1819A7D10
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76A80 Offset: 0x75E80 VA: 0x180076A80
	// RVA: 0x19A7CA0 Offset: 0x19A62A0 VA: 0x1819A7CA0
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76BC0 Offset: 0x75FC0 VA: 0x180076BC0
	// RVA: 0x19A9E90 Offset: 0x19A8490 VA: 0x1819A9E90
	public void SetViewport(Rect pixelRect) { }

	[FreeFunctionAttribute] // RVA: 0x76DD0 Offset: 0x761D0 VA: 0x180076DD0
	// RVA: 0x19A5FB0 Offset: 0x19A45B0 VA: 0x1819A5FB0
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunctionAttribute] // RVA: 0x76EF0 Offset: 0x762F0 VA: 0x180076EF0
	// RVA: 0x19A5670 Offset: 0x19A3C70 VA: 0x1819A5670
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x77050 Offset: 0x76450 VA: 0x180077050
	// RVA: 0x19A5560 Offset: 0x19A3B60 VA: 0x1819A5560
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x771B0 Offset: 0x765B0 VA: 0x1800771B0
	// RVA: 0x19A7780 Offset: 0x19A5D80 VA: 0x1819A7780
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x19A7660 Offset: 0x19A5C60 VA: 0x1819A7660
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x19A7320 Offset: 0x19A5920 VA: 0x1819A7320
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	// RVA: 0x19A76E0 Offset: 0x19A5CE0 VA: 0x1819A76E0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0x19A7B90 Offset: 0x19A6190 VA: 0x1819A7B90
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x19A7590 Offset: 0x19A5B90 VA: 0x1819A7590
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x19A7A50 Offset: 0x19A6050 VA: 0x1819A7A50
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	// RVA: 0x19A7450 Offset: 0x19A5A50 VA: 0x1819A7450
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x19A7910 Offset: 0x19A5F10 VA: 0x1819A7910
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x19A7810 Offset: 0x19A5E10 VA: 0x1819A7810
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x19A7880 Offset: 0x19A5E80 VA: 0x1819A7880
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter) { }

	// RVA: 0x19A7510 Offset: 0x19A5B10 VA: 0x1819A7510
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer) { }

	// RVA: 0x19A79D0 Offset: 0x19A5FD0 VA: 0x1819A79D0
	public void GetTemporaryRT(int nameID, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x77290 Offset: 0x76690 VA: 0x180077290
	// RVA: 0x19A72C0 Offset: 0x19A58C0 VA: 0x1819A72C0
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A73D0 Offset: 0x19A59D0 VA: 0x1819A73D0
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A7B20 Offset: 0x19A6120 VA: 0x1819A7B20
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x77420 Offset: 0x76820 VA: 0x180077420
	// RVA: 0x19A81F0 Offset: 0x19A67F0 VA: 0x1819A81F0
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunctionAttribute] // RVA: 0x77530 Offset: 0x76930 VA: 0x180077530
	// RVA: 0x19A5E40 Offset: 0x19A4440 VA: 0x1819A5E40
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x19A5EC0 Offset: 0x19A44C0 VA: 0x1819A5EC0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x775E0 Offset: 0x769E0 VA: 0x1800775E0
	// RVA: 0x19A87F0 Offset: 0x19A6DF0 VA: 0x1819A87F0
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunctionAttribute] // RVA: 0x77760 Offset: 0x76B60 VA: 0x180077760
	// RVA: 0x19A88C0 Offset: 0x19A6EC0 VA: 0x1819A88C0
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunctionAttribute] // RVA: 0x77840 Offset: 0x76C40 VA: 0x180077840
	// RVA: 0x19A8F10 Offset: 0x19A7510 VA: 0x1819A8F10
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x779C0 Offset: 0x76DC0 VA: 0x1800779C0
	// RVA: 0x19A87A0 Offset: 0x19A6DA0 VA: 0x1819A87A0
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunctionAttribute] // RVA: 0x77A50 Offset: 0x76E50 VA: 0x180077A50
	// RVA: 0x19A8B50 Offset: 0x19A7150 VA: 0x1819A8B50
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	// RVA: 0x19A7000 Offset: 0x19A5600 VA: 0x1819A7000
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77C00 Offset: 0x77000 VA: 0x180077C00
	// RVA: 0x19A6270 Offset: 0x19A4870 VA: 0x1819A6270
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77D70 Offset: 0x77170 VA: 0x180077D70
	// RVA: 0x19A9DE0 Offset: 0x19A83E0 VA: 0x1819A9DE0
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[FreeFunctionAttribute] // RVA: 0x77EB0 Offset: 0x772B0 VA: 0x180077EB0
	// RVA: 0x19A9EE0 Offset: 0x19A84E0 VA: 0x1819A9EE0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunctionAttribute] // RVA: 0x78080 Offset: 0x77480 VA: 0x180078080
	// RVA: 0x19A8DE0 Offset: 0x19A73E0 VA: 0x1819A8DE0
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x781E0 Offset: 0x775E0 VA: 0x1800781E0
	// RVA: 0x19A8990 Offset: 0x19A6F90 VA: 0x1819A8990
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x78290 Offset: 0x77690 VA: 0x180078290
	// RVA: 0x19A8BA0 Offset: 0x19A71A0 VA: 0x1819A8BA0
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x78440 Offset: 0x77840 VA: 0x180078440
	// RVA: 0x19A85F0 Offset: 0x19A6BF0 VA: 0x1819A85F0
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x78570 Offset: 0x77970 VA: 0x180078570
	// RVA: 0x19A9CA0 Offset: 0x19A82A0 VA: 0x1819A9CA0
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x78710 Offset: 0x77B10 VA: 0x180078710
	// RVA: 0x19A54A0 Offset: 0x19A3AA0 VA: 0x1819A54A0
	public void BeginSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x78830 Offset: 0x77C30 VA: 0x180078830
	// RVA: 0x19A7050 Offset: 0x19A5650 VA: 0x1819A7050
	public void EndSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x79ED0 Offset: 0x792D0 VA: 0x180079ED0
	// RVA: 0x19A8050 Offset: 0x19A6650 VA: 0x1819A8050
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x19A9240 Offset: 0x19A7840 VA: 0x1819A9240
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x19A9500 Offset: 0x19A7B00 VA: 0x1819A9500
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	// RVA: 0x19A92E0 Offset: 0x19A78E0 VA: 0x1819A92E0
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x19A9610 Offset: 0x19A7C10 VA: 0x1819A9610
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x19A96F0 Offset: 0x19A7CF0 VA: 0x1819A96F0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x19A9930 Offset: 0x19A7F30 VA: 0x1819A9930
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A9AA0 Offset: 0x19A80A0 VA: 0x1819A9AA0
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	// RVA: 0x19A91C0 Offset: 0x19A77C0 VA: 0x1819A91C0
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8FD0 Offset: 0x19A75D0 VA: 0x1819A8FD0
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A90C0 Offset: 0x19A76C0 VA: 0x1819A90C0
	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A70A0 Offset: 0x19A56A0 VA: 0x1819A70A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19A6330 Offset: 0x19A4930 VA: 0x1819A6330 Slot: 4
	public void Dispose() { }

	// RVA: 0x19A63D0 Offset: 0x19A49D0 VA: 0x1819A63D0
	private void Dispose(bool disposing) { }

	// RVA: 0x19A9F30 Offset: 0x19A8530 VA: 0x1819A9F30
	public void .ctor() { }

	// RVA: 0x19A8550 Offset: 0x19A6B50 VA: 0x1819A8550
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	// RVA: 0x19A8330 Offset: 0x19A6930 VA: 0x1819A8330
	public void SetComputeFloatParams(ComputeShader computeShader, string name, float[] values) { }

	// RVA: 0x19A83C0 Offset: 0x19A69C0 VA: 0x1819A83C0
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	// RVA: 0x19A8230 Offset: 0x19A6830 VA: 0x1819A8230
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x19A62C0 Offset: 0x19A48C0 VA: 0x1819A62C0
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x19A7170 Offset: 0x19A5770 VA: 0x1819A7170
	public void GenerateMips(RenderTexture rt) { }

	// RVA: 0x19A6B20 Offset: 0x19A5120 VA: 0x1819A6B20
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x19A6A50 Offset: 0x19A5050 VA: 0x1819A6A50
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x19A6AC0 Offset: 0x19A50C0 VA: 0x1819A6AC0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x19A6DE0 Offset: 0x19A53E0 VA: 0x1819A6DE0
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x19A6DC0 Offset: 0x19A53C0 VA: 0x1819A6DC0
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x19A6FD0 Offset: 0x19A55D0 VA: 0x1819A6FD0
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x19A6680 Offset: 0x19A4C80 VA: 0x1819A6680
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	// RVA: 0x19A6430 Offset: 0x19A4A30 VA: 0x1819A6430
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	// RVA: 0x19A6100 Offset: 0x19A4700 VA: 0x1819A6100
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x19A61B0 Offset: 0x19A47B0 VA: 0x1819A61B0
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	// RVA: 0x19A6020 Offset: 0x19A4620 VA: 0x1819A6020
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) { }

	// RVA: 0x19A5830 Offset: 0x19A3E30 VA: 0x1819A5830
	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	// RVA: 0x19A5710 Offset: 0x19A3D10 VA: 0x1819A5710
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x19A5950 Offset: 0x19A3F50 VA: 0x1819A5950
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x19A5B90 Offset: 0x19A4190 VA: 0x1819A5B90
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x19A5CB0 Offset: 0x19A42B0 VA: 0x1819A5CB0
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x19A5A70 Offset: 0x19A4070 VA: 0x1819A5A70
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x19A8840 Offset: 0x19A6E40 VA: 0x1819A8840
	public void SetGlobalFloat(string name, float value) { }

	// RVA: 0x19A8910 Offset: 0x19A6F10 VA: 0x1819A8910
	public void SetGlobalInt(string name, int value) { }

	// RVA: 0x19A8E80 Offset: 0x19A7480 VA: 0x1819A8E80
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x19A8710 Offset: 0x19A6D10 VA: 0x1819A8710
	public void SetGlobalColor(string name, Color value) { }

	// RVA: 0x19A8AB0 Offset: 0x19A70B0 VA: 0x1819A8AB0
	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x19A8D60 Offset: 0x19A7360 VA: 0x1819A8D60
	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	// RVA: 0x19A89E0 Offset: 0x19A6FE0 VA: 0x1819A89E0
	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	// RVA: 0x19A8C60 Offset: 0x19A7260 VA: 0x1819A8C60
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	// RVA: 0x19A8C00 Offset: 0x19A7200 VA: 0x1819A8C00
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x19A8D00 Offset: 0x19A7300 VA: 0x1819A8D00
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0x19A8640 Offset: 0x19A6C40 VA: 0x1819A8640
	public void SetGlobalBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x19A9D00 Offset: 0x19A8300 VA: 0x1819A9D00
	public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	// RVA: 0x19A8010 Offset: 0x19A6610 VA: 0x1819A8010
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	// RVA: 0x19A80C0 Offset: 0x19A66C0 VA: 0x1819A80C0
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x19A8470 Offset: 0x19A6A70 VA: 0x1819A8470
	private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val) { }

	// RVA: 0x19A7D80 Offset: 0x19A6380 VA: 0x1819A7D80
	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x19A9E40 Offset: 0x19A8440 VA: 0x1819A9E40
	private void SetViewport_Injected(ref Rect pixelRect) { }

	// RVA: 0x19A5600 Offset: 0x19A3C00 VA: 0x1819A5600
	private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x19A54F0 Offset: 0x19A3AF0 VA: 0x1819A54F0
	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x19A7260 Offset: 0x19A5860 VA: 0x1819A7260
	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A5DD0 Offset: 0x19A43D0 VA: 0x1819A5DD0
	private void ClearRenderTarget_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x19A8E30 Offset: 0x19A7430 VA: 0x1819A8E30
	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	// RVA: 0x19A86C0 Offset: 0x19A6CC0 VA: 0x1819A86C0
	private void SetGlobalColor_Injected(int nameID, ref Color value) { }

	// RVA: 0x19A8A60 Offset: 0x19A7060 VA: 0x1819A8A60
	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) { }

	// RVA: 0x19A9D80 Offset: 0x19A8380 VA: 0x1819A9D80
	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	// RVA: 0x19A9150 Offset: 0x19A7750 VA: 0x1819A9150
	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8F60 Offset: 0x19A7560 VA: 0x1819A8F60
	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A9050 Offset: 0x19A7650 VA: 0x1819A9050
	private void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

}

