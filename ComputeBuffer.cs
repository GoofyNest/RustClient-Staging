public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3549
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public int count { get; }

	// Methods

	// RVA: 0x1825BD0 Offset: 0x18241D0 VA: 0x181825BD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18259B0 Offset: 0x1823FB0 VA: 0x1818259B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1825A50 Offset: 0x1824050 VA: 0x181825A50
	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute] // RVA: 0xC9780 Offset: 0xC8B80 VA: 0x1800C9780
	// RVA: 0x1825E80 Offset: 0x1824480 VA: 0x181825E80
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute] // RVA: 0xC9830 Offset: 0xC8C30 VA: 0x1800C9830
	// RVA: 0x1825970 Offset: 0x1823F70 VA: 0x181825970
	private static void DestroyBuffer(ComputeBuffer buf) { }

	// RVA: 0x18265C0 Offset: 0x1824BC0 VA: 0x1818265C0
	public void .ctor(int count, int stride) { }

	// RVA: 0x18265F0 Offset: 0x1824BF0 VA: 0x1818265F0
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x18264B0 Offset: 0x1824AB0 VA: 0x1818264B0
	internal void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	// RVA: 0x18259B0 Offset: 0x1823FB0 VA: 0x1818259B0
	public void Release() { }

	// RVA: 0x1826620 Offset: 0x1824C20 VA: 0x181826620
	public int get_count() { }

	// RVA: 0x1826030 Offset: 0x1824630 VA: 0x181826030
	public void SetData(Array data) { }

	// RVA: 0x1826210 Offset: 0x1824810 VA: 0x181826210
	public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

	// RVA: -1 Offset: -1
	public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB630 Offset: 0x5C9C30 VA: 0x1805CB630
	|-ComputeBuffer.SetData<uint>
	|
	|-RVA: 0x5CB7C0 Offset: 0x5C9DC0 VA: 0x1805CB7C0
	|-ComputeBuffer.SetData<Vector4>
	*/

	[FreeFunctionAttribute] // RVA: 0xC9930 Offset: 0xC8D30 VA: 0x1800C9930
	// RVA: 0x1825FC0 Offset: 0x18245C0 VA: 0x181825FC0
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunctionAttribute] // RVA: 0xC9A10 Offset: 0xC8E10 VA: 0x1800C9A10
	// RVA: 0x1825F50 Offset: 0x1824550 VA: 0x181825F50
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x1825C60 Offset: 0x1824260 VA: 0x181825C60
	public void GetData(Array data) { }

	[FreeFunctionAttribute] // RVA: 0xC9AA0 Offset: 0xC8EA0 VA: 0x1800C9AA0
	// RVA: 0x1825EE0 Offset: 0x18244E0 VA: 0x181825EE0
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x1825910 Offset: 0x1823F10 VA: 0x181825910
	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) { }

	// RVA: 0x1825E40 Offset: 0x1824440 VA: 0x181825E40
	public IntPtr GetNativeBufferPtr() { }

}

