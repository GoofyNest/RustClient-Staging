public sealed class ComputeShader : Object // TypeDefIndex: 3550
{	// Methods

	[NativeMethodAttribute] // RVA: 0xC9D60 Offset: 0xC9160 VA: 0x1800C9D60
	[RequiredByNativeCodeAttribute] // RVA: 0xC9D60 Offset: 0xC9160 VA: 0x1800C9D60
	// RVA: 0x18266C0 Offset: 0x1824CC0 VA: 0x1818266C0
	public int FindKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9F30 Offset: 0xC9330 VA: 0x1800C9F30
	// RVA: 0x1826770 Offset: 0x1824D70 VA: 0x181826770
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9FF0 Offset: 0xC93F0 VA: 0x1800C9FF0
	// RVA: 0x1826940 Offset: 0x1824F40 VA: 0x181826940
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute] // RVA: 0xCA130 Offset: 0xC9530 VA: 0x1800CA130
	// RVA: 0x1826B20 Offset: 0x1825120 VA: 0x181826B20
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0xCA1A0 Offset: 0xC95A0 VA: 0x1800CA1A0
	// RVA: 0x1826890 Offset: 0x1824E90 VA: 0x181826890
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute] // RVA: 0xCA2C0 Offset: 0xC96C0 VA: 0x1800CA2C0
	// RVA: 0x1826A70 Offset: 0x1825070 VA: 0x181826A70
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute] // RVA: 0xCA420 Offset: 0xC9820 VA: 0x1800CA420
	// RVA: 0x18267C0 Offset: 0x1824DC0 VA: 0x1818267C0
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0xCA610 Offset: 0xC9A10 VA: 0x1800CA610
	// RVA: 0x1826710 Offset: 0x1824D10 VA: 0x181826710
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute] // RVA: 0xCA6C0 Offset: 0xC9AC0 VA: 0x1800CA6C0
	// RVA: 0x1826660 Offset: 0x1824C60 VA: 0x181826660
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x18268E0 Offset: 0x1824EE0 VA: 0x1818268E0
	public void SetFloat(string name, float val) { }

	// RVA: 0x1826B70 Offset: 0x1825170 VA: 0x181826B70
	public void SetVector(string name, Vector4 val) { }

	// RVA: 0x1826990 Offset: 0x1824F90 VA: 0x181826990
	public void SetFloats(string name, float[] values) { }

	// RVA: 0x18269F0 Offset: 0x1824FF0 VA: 0x1818269F0
	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	// RVA: 0x1826820 Offset: 0x1824E20 VA: 0x181826820
	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x1826AD0 Offset: 0x18250D0 VA: 0x181826AD0
	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

