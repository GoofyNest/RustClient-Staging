public sealed class ComputeShader : Object // TypeDefIndex: 3550
{
	[NativeMethodAttribute] // RVA: 0xC9D60 Offset: 0xC9160 VA: 0x1800C9D60
	[RequiredByNativeCodeAttribute] // RVA: 0xC9D60 Offset: 0xC9160 VA: 0x1800C9D60
	public int FindKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9F30 Offset: 0xC9330 VA: 0x1800C9F30
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9FF0 Offset: 0xC93F0 VA: 0x1800C9FF0
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute] // RVA: 0xCA130 Offset: 0xC9530 VA: 0x1800CA130
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0xCA1A0 Offset: 0xC95A0 VA: 0x1800CA1A0
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute] // RVA: 0xCA2C0 Offset: 0xC96C0 VA: 0x1800CA2C0
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute] // RVA: 0xCA420 Offset: 0xC9820 VA: 0x1800CA420
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0xCA610 Offset: 0xC9A10 VA: 0x1800CA610
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute] // RVA: 0xCA6C0 Offset: 0xC9AC0 VA: 0x1800CA6C0
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	public void SetFloat(string name, float val) { }

	public void SetVector(string name, Vector4 val) { }

	public void SetFloats(string name, float[] values) { }

	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

