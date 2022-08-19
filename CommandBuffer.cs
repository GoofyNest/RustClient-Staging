public class CommandBuffer : IDisposable // TypeDefIndex: 3841
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x75280 Offset: 0x74680 VA: 0x180075280
	// RVA: 0x19A7D90 Offset: 0x19A6390 VA: 0x1819A7D90
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x753D0 Offset: 0x747D0 VA: 0x1800753D0
	// RVA: 0x19A79F0 Offset: 0x19A5FF0 VA: 0x1819A79F0
	private static IntPtr InitBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x75500 Offset: 0x74900 VA: 0x180075500
	// RVA: 0x19A7F30 Offset: 0x19A6530 VA: 0x1819A7F30
	private void ReleaseBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x75630 Offset: 0x74A30 VA: 0x180075630
	// RVA: 0x19A8260 Offset: 0x19A6860 VA: 0x1819A8260
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0x75930 Offset: 0x74D30 VA: 0x180075930
	// RVA: 0x19A7CB0 Offset: 0x19A62B0 VA: 0x1819A7CB0
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunctionAttribute] // RVA: 0x75B50 Offset: 0x74F50 VA: 0x180075B50
	// RVA: 0x19A7D20 Offset: 0x19A6320 VA: 0x1819A7D20
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x75E90 Offset: 0x75290 VA: 0x180075E90
	// RVA: 0x19A8040 Offset: 0x19A6640 VA: 0x1819A8040
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x760D0 Offset: 0x754D0 VA: 0x1800760D0
	// RVA: 0x19A6040 Offset: 0x19A4640 VA: 0x1819A6040
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethodAttribute] // RVA: 0x76200 Offset: 0x75600 VA: 0x180076200
	// RVA: 0x19A7C60 Offset: 0x19A6260 VA: 0x1819A7C60
	private void Internal_GenerateMips(RenderTexture rt) { }

	// RVA: 0x19A9CF0 Offset: 0x19A82F0 VA: 0x1819A9CF0
	public string get_name() { }

	// RVA: 0x19A9D30 Offset: 0x19A8330 VA: 0x1819A9D30
	public void set_name(string value) { }

	[NativeMethodAttribute] // RVA: 0x76320 Offset: 0x75720 VA: 0x180076320
	// RVA: 0x19A5CF0 Offset: 0x19A42F0 VA: 0x1819A5CF0
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x76410 Offset: 0x75810 VA: 0x180076410
	// RVA: 0x19A7B70 Offset: 0x19A6170 VA: 0x1819A7B70
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethodAttribute] // RVA: 0x76600 Offset: 0x75A00 VA: 0x180076600
	// RVA: 0x19A7BF0 Offset: 0x19A61F0 VA: 0x1819A7BF0
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[FreeFunctionAttribute] // RVA: 0x76880 Offset: 0x75C80 VA: 0x180076880
	// RVA: 0x19A7A90 Offset: 0x19A6090 VA: 0x1819A7A90
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x769E0 Offset: 0x75DE0 VA: 0x1800769E0
	// RVA: 0x19A7A20 Offset: 0x19A6020 VA: 0x1819A7A20
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x76AC0 Offset: 0x75EC0 VA: 0x180076AC0
	// RVA: 0x19A9C10 Offset: 0x19A8210 VA: 0x1819A9C10
	public void SetViewport(Rect pixelRect) { }

	[FreeFunctionAttribute] // RVA: 0x76CA0 Offset: 0x760A0 VA: 0x180076CA0
	// RVA: 0x19A5D30 Offset: 0x19A4330 VA: 0x1819A5D30
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunctionAttribute] // RVA: 0x76DF0 Offset: 0x761F0 VA: 0x180076DF0
	// RVA: 0x19A53F0 Offset: 0x19A39F0 VA: 0x1819A53F0
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x76F00 Offset: 0x76300 VA: 0x180076F00
	// RVA: 0x19A52E0 Offset: 0x19A38E0 VA: 0x1819A52E0
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x770E0 Offset: 0x764E0 VA: 0x1800770E0
	// RVA: 0x19A7500 Offset: 0x19A5B00 VA: 0x1819A7500
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x19A73E0 Offset: 0x19A59E0 VA: 0x1819A73E0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x19A70A0 Offset: 0x19A56A0 VA: 0x1819A70A0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	// RVA: 0x19A7460 Offset: 0x19A5A60 VA: 0x1819A7460
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0x19A7910 Offset: 0x19A5F10 VA: 0x1819A7910
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x19A7310 Offset: 0x19A5910 VA: 0x1819A7310
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x19A77D0 Offset: 0x19A5DD0 VA: 0x1819A77D0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	// RVA: 0x19A71D0 Offset: 0x19A57D0 VA: 0x1819A71D0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x19A7690 Offset: 0x19A5C90 VA: 0x1819A7690
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x19A7590 Offset: 0x19A5B90 VA: 0x1819A7590
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x19A7600 Offset: 0x19A5C00 VA: 0x1819A7600
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter) { }

	// RVA: 0x19A7290 Offset: 0x19A5890 VA: 0x1819A7290
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer) { }

	// RVA: 0x19A7750 Offset: 0x19A5D50 VA: 0x1819A7750
	public void GetTemporaryRT(int nameID, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x771C0 Offset: 0x765C0 VA: 0x1800771C0
	// RVA: 0x19A7040 Offset: 0x19A5640 VA: 0x1819A7040
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A7150 Offset: 0x19A5750 VA: 0x1819A7150
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A78A0 Offset: 0x19A5EA0 VA: 0x1819A78A0
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x77350 Offset: 0x76750 VA: 0x180077350
	// RVA: 0x19A7F70 Offset: 0x19A6570 VA: 0x1819A7F70
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunctionAttribute] // RVA: 0x77460 Offset: 0x76860 VA: 0x180077460
	// RVA: 0x19A5BC0 Offset: 0x19A41C0 VA: 0x1819A5BC0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x19A5C40 Offset: 0x19A4240 VA: 0x1819A5C40
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x77510 Offset: 0x76910 VA: 0x180077510
	// RVA: 0x19A8570 Offset: 0x19A6B70 VA: 0x1819A8570
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunctionAttribute] // RVA: 0x77660 Offset: 0x76A60 VA: 0x180077660
	// RVA: 0x19A8640 Offset: 0x19A6C40 VA: 0x1819A8640
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunctionAttribute] // RVA: 0x77770 Offset: 0x76B70 VA: 0x180077770
	// RVA: 0x19A8C90 Offset: 0x19A7290 VA: 0x1819A8C90
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x778B0 Offset: 0x76CB0 VA: 0x1800778B0
	// RVA: 0x19A8520 Offset: 0x19A6B20 VA: 0x1819A8520
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunctionAttribute] // RVA: 0x779B0 Offset: 0x76DB0 VA: 0x1800779B0
	// RVA: 0x19A88D0 Offset: 0x19A6ED0 VA: 0x1819A88D0
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x77AC0 Offset: 0x76EC0 VA: 0x180077AC0
	// RVA: 0x19A6D80 Offset: 0x19A5380 VA: 0x1819A6D80
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77BA0 Offset: 0x76FA0 VA: 0x180077BA0
	// RVA: 0x19A5FF0 Offset: 0x19A45F0 VA: 0x1819A5FF0
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77CC0 Offset: 0x770C0 VA: 0x180077CC0
	// RVA: 0x19A9B60 Offset: 0x19A8160 VA: 0x1819A9B60
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[FreeFunctionAttribute] // RVA: 0x77DD0 Offset: 0x771D0 VA: 0x180077DD0
	// RVA: 0x19A9C60 Offset: 0x19A8260 VA: 0x1819A9C60
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunctionAttribute] // RVA: 0x77F80 Offset: 0x77380 VA: 0x180077F80
	// RVA: 0x19A8B60 Offset: 0x19A7160 VA: 0x1819A8B60
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x78120 Offset: 0x77520 VA: 0x180078120
	// RVA: 0x19A8710 Offset: 0x19A6D10 VA: 0x1819A8710
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x781F0 Offset: 0x775F0 VA: 0x1800781F0
	// RVA: 0x19A8920 Offset: 0x19A6F20 VA: 0x1819A8920
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x783A0 Offset: 0x777A0 VA: 0x1800783A0
	// RVA: 0x19A8370 Offset: 0x19A6970 VA: 0x1819A8370
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x784C0 Offset: 0x778C0 VA: 0x1800784C0
	// RVA: 0x19A9A20 Offset: 0x19A8020 VA: 0x1819A9A20
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x78650 Offset: 0x77A50 VA: 0x180078650
	// RVA: 0x19A5220 Offset: 0x19A3820 VA: 0x1819A5220
	public void BeginSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x78760 Offset: 0x77B60 VA: 0x180078760
	// RVA: 0x19A6DD0 Offset: 0x19A53D0 VA: 0x1819A6DD0
	public void EndSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x79BE0 Offset: 0x78FE0 VA: 0x180079BE0
	// RVA: 0x19A7DD0 Offset: 0x19A63D0 VA: 0x1819A7DD0
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x19A8FC0 Offset: 0x19A75C0 VA: 0x1819A8FC0
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x19A9280 Offset: 0x19A7880 VA: 0x1819A9280
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	// RVA: 0x19A9060 Offset: 0x19A7660 VA: 0x1819A9060
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x19A9390 Offset: 0x19A7990 VA: 0x1819A9390
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x19A9470 Offset: 0x19A7A70 VA: 0x1819A9470
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x19A96B0 Offset: 0x19A7CB0 VA: 0x1819A96B0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A9820 Offset: 0x19A7E20 VA: 0x1819A9820
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	// RVA: 0x19A8F40 Offset: 0x19A7540 VA: 0x1819A8F40
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8D50 Offset: 0x19A7350 VA: 0x1819A8D50
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8E40 Offset: 0x19A7440 VA: 0x1819A8E40
	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A6E20 Offset: 0x19A5420 VA: 0x1819A6E20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19A60B0 Offset: 0x19A46B0 VA: 0x1819A60B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x19A6150 Offset: 0x19A4750 VA: 0x1819A6150
	private void Dispose(bool disposing) { }

	// RVA: 0x19A9CB0 Offset: 0x19A82B0 VA: 0x1819A9CB0
	public void .ctor() { }

	// RVA: 0x19A82D0 Offset: 0x19A68D0 VA: 0x1819A82D0
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	// RVA: 0x19A80B0 Offset: 0x19A66B0 VA: 0x1819A80B0
	public void SetComputeFloatParams(ComputeShader computeShader, string name, float[] values) { }

	// RVA: 0x19A8140 Offset: 0x19A6740 VA: 0x1819A8140
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	// RVA: 0x19A7FB0 Offset: 0x19A65B0 VA: 0x1819A7FB0
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x19A6040 Offset: 0x19A4640 VA: 0x1819A6040
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x19A6EF0 Offset: 0x19A54F0 VA: 0x1819A6EF0
	public void GenerateMips(RenderTexture rt) { }

	// RVA: 0x19A68A0 Offset: 0x19A4EA0 VA: 0x1819A68A0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x19A67D0 Offset: 0x19A4DD0 VA: 0x1819A67D0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x19A6840 Offset: 0x19A4E40 VA: 0x1819A6840
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x19A6B60 Offset: 0x19A5160 VA: 0x1819A6B60
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x19A6B40 Offset: 0x19A5140 VA: 0x1819A6B40
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x19A6D50 Offset: 0x19A5350 VA: 0x1819A6D50
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x19A6400 Offset: 0x19A4A00 VA: 0x1819A6400
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	// RVA: 0x19A61B0 Offset: 0x19A47B0 VA: 0x1819A61B0
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	// RVA: 0x19A5E80 Offset: 0x19A4480 VA: 0x1819A5E80
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x19A5F30 Offset: 0x19A4530 VA: 0x1819A5F30
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	// RVA: 0x19A5DA0 Offset: 0x19A43A0 VA: 0x1819A5DA0
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) { }

	// RVA: 0x19A55B0 Offset: 0x19A3BB0 VA: 0x1819A55B0
	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	// RVA: 0x19A5490 Offset: 0x19A3A90 VA: 0x1819A5490
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x19A56D0 Offset: 0x19A3CD0 VA: 0x1819A56D0
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x19A5910 Offset: 0x19A3F10 VA: 0x1819A5910
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x19A5A30 Offset: 0x19A4030 VA: 0x1819A5A30
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x19A57F0 Offset: 0x19A3DF0 VA: 0x1819A57F0
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x19A85C0 Offset: 0x19A6BC0 VA: 0x1819A85C0
	public void SetGlobalFloat(string name, float value) { }

	// RVA: 0x19A8690 Offset: 0x19A6C90 VA: 0x1819A8690
	public void SetGlobalInt(string name, int value) { }

	// RVA: 0x19A8C00 Offset: 0x19A7200 VA: 0x1819A8C00
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x19A8490 Offset: 0x19A6A90 VA: 0x1819A8490
	public void SetGlobalColor(string name, Color value) { }

	// RVA: 0x19A8830 Offset: 0x19A6E30 VA: 0x1819A8830
	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x19A8AE0 Offset: 0x19A70E0 VA: 0x1819A8AE0
	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	// RVA: 0x19A8760 Offset: 0x19A6D60 VA: 0x1819A8760
	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	// RVA: 0x19A89E0 Offset: 0x19A6FE0 VA: 0x1819A89E0
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	// RVA: 0x19A8980 Offset: 0x19A6F80 VA: 0x1819A8980
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x19A8A80 Offset: 0x19A7080 VA: 0x1819A8A80
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0x19A83C0 Offset: 0x19A69C0 VA: 0x1819A83C0
	public void SetGlobalBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x19A9A80 Offset: 0x19A8080 VA: 0x1819A9A80
	public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	// RVA: 0x19A7D90 Offset: 0x19A6390 VA: 0x1819A7D90
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	// RVA: 0x19A7E40 Offset: 0x19A6440 VA: 0x1819A7E40
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x19A81F0 Offset: 0x19A67F0 VA: 0x1819A81F0
	private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val) { }

	// RVA: 0x19A7B00 Offset: 0x19A6100 VA: 0x1819A7B00
	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x19A9BC0 Offset: 0x19A81C0 VA: 0x1819A9BC0
	private void SetViewport_Injected(ref Rect pixelRect) { }

	// RVA: 0x19A5380 Offset: 0x19A3980 VA: 0x1819A5380
	private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x19A5270 Offset: 0x19A3870 VA: 0x1819A5270
	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x19A6FE0 Offset: 0x19A55E0 VA: 0x1819A6FE0
	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A5B50 Offset: 0x19A4150 VA: 0x1819A5B50
	private void ClearRenderTarget_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x19A8BB0 Offset: 0x19A71B0 VA: 0x1819A8BB0
	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	// RVA: 0x19A8440 Offset: 0x19A6A40 VA: 0x1819A8440
	private void SetGlobalColor_Injected(int nameID, ref Color value) { }

	// RVA: 0x19A87E0 Offset: 0x19A6DE0 VA: 0x1819A87E0
	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) { }

	// RVA: 0x19A9B00 Offset: 0x19A8100 VA: 0x1819A9B00
	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	// RVA: 0x19A8ED0 Offset: 0x19A74D0 VA: 0x1819A8ED0
	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8CE0 Offset: 0x19A72E0 VA: 0x1819A8CE0
	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A8DD0 Offset: 0x19A73D0 VA: 0x1819A8DD0
	private void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

}

