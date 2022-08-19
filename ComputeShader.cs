public sealed class ComputeShader : Object // TypeDefIndex: 3550
{	// Methods

	[NativeMethodAttribute] // RVA: 0xC9D20 Offset: 0xC9120 VA: 0x1800C9D20
	[RequiredByNativeCodeAttribute] // RVA: 0xC9D20 Offset: 0xC9120 VA: 0x1800C9D20
	// RVA: 0x1826400 Offset: 0x1824A00 VA: 0x181826400
	public int FindKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9EF0 Offset: 0xC92F0 VA: 0x1800C9EF0
	// RVA: 0x18264B0 Offset: 0x1824AB0 VA: 0x1818264B0
	public bool HasKernel(string name) { }

	[FreeFunctionAttribute] // RVA: 0xC9F60 Offset: 0xC9360 VA: 0x1800C9F60
	// RVA: 0x1826680 Offset: 0x1824C80 VA: 0x181826680
	public void SetFloat(int nameID, float val) { }

	[FreeFunctionAttribute] // RVA: 0xCA0A0 Offset: 0xC94A0 VA: 0x1800CA0A0
	// RVA: 0x1826860 Offset: 0x1824E60 VA: 0x181826860
	public void SetVector(int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0xCA110 Offset: 0xC9510 VA: 0x1800CA110
	// RVA: 0x18265D0 Offset: 0x1824BD0 VA: 0x1818265D0
	private void SetFloatArray(int nameID, float[] values) { }

	[NativeMethodAttribute] // RVA: 0xCA230 Offset: 0xC9630 VA: 0x1800CA230
	// RVA: 0x18267B0 Offset: 0x1824DB0 VA: 0x1818267B0
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[FreeFunctionAttribute] // RVA: 0xCA390 Offset: 0xC9790 VA: 0x1800CA390
	// RVA: 0x1826500 Offset: 0x1824B00 VA: 0x181826500
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[NativeMethodAttribute] // RVA: 0xCA580 Offset: 0xC9980 VA: 0x1800CA580
	// RVA: 0x1826450 Offset: 0x1824A50 VA: 0x181826450
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[NativeNameAttribute] // RVA: 0xCA680 Offset: 0xC9A80 VA: 0x1800CA680
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

