public sealed class ComputeShader : Object // TypeDefIndex: 3550
{	// Methods

	[NativeMethodAttribute] // RVA: 0xC9D60 Offset: 0xC9160 VA: 0x1800C9D60
	[RequiredByNativeCodeAttribute] // RVA: 0xC9D60 Offset: 0xC9160 VA: 0x1800C9D60
	// RVA: 0x1826400 Offset: 0x1824A00 VA: 0x181826400
	public int FindKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9F30 Offset: 0xC9330 VA: 0x1800C9F30
	// RVA: 0x18264B0 Offset: 0x1824AB0 VA: 0x1818264B0
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9FF0 Offset: 0xC93F0 VA: 0x1800C9FF0
	// RVA: 0x1826680 Offset: 0x1824C80 VA: 0x181826680
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute] // RVA: 0xCA130 Offset: 0xC9530 VA: 0x1800CA130
	// RVA: 0x1826860 Offset: 0x1824E60 VA: 0x181826860
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0xCA1A0 Offset: 0xC95A0 VA: 0x1800CA1A0
	// RVA: 0x18265D0 Offset: 0x1824BD0 VA: 0x1818265D0
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute] // RVA: 0xCA2C0 Offset: 0xC96C0 VA: 0x1800CA2C0
	// RVA: 0x18267B0 Offset: 0x1824DB0 VA: 0x1818267B0
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute] // RVA: 0xCA420 Offset: 0xC9820 VA: 0x1800CA420
	// RVA: 0x1826500 Offset: 0x1824B00 VA: 0x181826500
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0xCA610 Offset: 0xC9A10 VA: 0x1800CA610
	// RVA: 0x1826450 Offset: 0x1824A50 VA: 0x181826450
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute] // RVA: 0xCA6C0 Offset: 0xC9AC0 VA: 0x1800CA6C0
	// RVA: 0x18263A0 Offset: 0x18249A0 VA: 0x1818263A0
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x1826620 Offset: 0x1824C20 VA: 0x181826620
	public void SetFloat(string name, float val) { }

	// RVA: 0x18268B0 Offset: 0x1824EB0 VA: 0x1818268B0
	public void SetVector(string name, Vector4 val) { }

	// RVA: 0x18266D0 Offset: 0x1824CD0 VA: 0x1818266D0
	public void SetFloats(string name, float[] values) { }

	// RVA: 0x1826730 Offset: 0x1824D30 VA: 0x181826730
	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	// RVA: 0x1826560 Offset: 0x1824B60 VA: 0x181826560
	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x1826810 Offset: 0x1824E10 VA: 0x181826810
	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}

