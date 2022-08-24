public sealed class ComputeShader : Object // TypeDefIndex: 3550
{
	[NativeMethodAttribute] // RVA: 0xC9E50 Offset: 0xC9250 VA: 0x1800C9E50
	[RequiredByNativeCodeAttribute] // RVA: 0xC9E50 Offset: 0xC9250 VA: 0x1800C9E50
	public int FindKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9FD0 Offset: 0xC93D0 VA: 0x1800C9FD0
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCA040 Offset: 0xC9440 VA: 0x1800CA040
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute] // RVA: 0xCA130 Offset: 0xC9530 VA: 0x1800CA130
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0xCA1F0 Offset: 0xC95F0 VA: 0x1800CA1F0
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute] // RVA: 0xCA360 Offset: 0xC9760 VA: 0x1800CA360
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute] // RVA: 0xCA4C0 Offset: 0xC98C0 VA: 0x1800CA4C0
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0xCA660 Offset: 0xC9A60 VA: 0x1800CA660
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute] // RVA: 0xCA710 Offset: 0xC9B10 VA: 0x1800CA710
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	public void SetFloat(string name, float val) { }

	public void SetVector(string name, Vector4 val) { }

	public void SetFloats(string name, float[] values) { }

	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

