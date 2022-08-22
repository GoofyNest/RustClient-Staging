public sealed class ComputeShader : Object // TypeDefIndex: 3550
{	// Methods

	[NativeMethodAttribute] // RVA: 0xC9D60 Offset: 0xC9160 VA: 0x1800C9D60
	[RequiredByNativeCodeAttribute] // RVA: 0xC9D60 Offset: 0xC9160 VA: 0x1800C9D60
	// RVA: 0x1813B00 Offset: 0x1812100 VA: 0x181813B00
	public int FindKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9F30 Offset: 0xC9330 VA: 0x1800C9F30
	// RVA: 0x1813BB0 Offset: 0x18121B0 VA: 0x181813BB0
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9FF0 Offset: 0xC93F0 VA: 0x1800C9FF0
	// RVA: 0x1813D80 Offset: 0x1812380 VA: 0x181813D80
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute] // RVA: 0xCA130 Offset: 0xC9530 VA: 0x1800CA130
	// RVA: 0x1813F60 Offset: 0x1812560 VA: 0x181813F60
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0xCA1A0 Offset: 0xC95A0 VA: 0x1800CA1A0
	// RVA: 0x1813CD0 Offset: 0x18122D0 VA: 0x181813CD0
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute] // RVA: 0xCA2C0 Offset: 0xC96C0 VA: 0x1800CA2C0
	// RVA: 0x1813EB0 Offset: 0x18124B0 VA: 0x181813EB0
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute] // RVA: 0xCA420 Offset: 0xC9820 VA: 0x1800CA420
	// RVA: 0x1813C00 Offset: 0x1812200 VA: 0x181813C00
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0xCA610 Offset: 0xC9A10 VA: 0x1800CA610
	// RVA: 0x1813B50 Offset: 0x1812150 VA: 0x181813B50
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute] // RVA: 0xCA6C0 Offset: 0xC9AC0 VA: 0x1800CA6C0
	// RVA: 0x1813AA0 Offset: 0x18120A0 VA: 0x181813AA0
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x1813D20 Offset: 0x1812320 VA: 0x181813D20
	public void SetFloat(string name, float val) { }

	// RVA: 0x1813FB0 Offset: 0x18125B0 VA: 0x181813FB0
	public void SetVector(string name, Vector4 val) { }

	// RVA: 0x1813DD0 Offset: 0x18123D0 VA: 0x181813DD0
	public void SetFloats(string name, float[] values) { }

	// RVA: 0x1813E30 Offset: 0x1812430 VA: 0x181813E30
	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	// RVA: 0x1813C60 Offset: 0x1812260 VA: 0x181813C60
	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x1813F10 Offset: 0x1812510 VA: 0x181813F10
	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

