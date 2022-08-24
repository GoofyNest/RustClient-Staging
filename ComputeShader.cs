public sealed class ComputeShader : Object // TypeDefIndex: 3550
{
	[NativeMethodAttribute] // RVA: 0xC9E40 Offset: 0xC9240 VA: 0x1800C9E40
	[RequiredByNativeCodeAttribute] // RVA: 0xC9E40 Offset: 0xC9240 VA: 0x1800C9E40
	public int FindKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCA010 Offset: 0xC9410 VA: 0x1800CA010
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCA0D0 Offset: 0xC94D0 VA: 0x1800CA0D0
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute] // RVA: 0xCA210 Offset: 0xC9610 VA: 0x1800CA210
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0xCA280 Offset: 0xC9680 VA: 0x1800CA280
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute] // RVA: 0xCA3F0 Offset: 0xC97F0 VA: 0x1800CA3F0
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute] // RVA: 0xCA550 Offset: 0xC9950 VA: 0x1800CA550
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0xCA6F0 Offset: 0xC9AF0 VA: 0x1800CA6F0
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute] // RVA: 0xCA7A0 Offset: 0xC9BA0 VA: 0x1800CA7A0
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	public void SetFloat(string name, float val) { }

	public void SetVector(string name, Vector4 val) { }

	public void SetFloats(string name, float[] values) { }

	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

