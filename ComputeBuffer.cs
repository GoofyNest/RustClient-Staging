public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3549
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public int count { get; }

	// Methods

	// RVA: 0x1813010 Offset: 0x1811610 VA: 0x181813010 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1812DF0 Offset: 0x18113F0 VA: 0x181812DF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1812E90 Offset: 0x1811490 VA: 0x181812E90
	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute] // RVA: 0xC9780 Offset: 0xC8B80 VA: 0x1800C9780
	// RVA: 0x18132C0 Offset: 0x18118C0 VA: 0x1818132C0
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute] // RVA: 0xC9830 Offset: 0xC8C30 VA: 0x1800C9830
	// RVA: 0x1812DB0 Offset: 0x18113B0 VA: 0x181812DB0
	private static void DestroyBuffer(ComputeBuffer buf) { }

	// RVA: 0x1813A00 Offset: 0x1812000 VA: 0x181813A00
	public void .ctor(int count, int stride) { }

	// RVA: 0x1813A30 Offset: 0x1812030 VA: 0x181813A30
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x18138F0 Offset: 0x1811EF0 VA: 0x1818138F0
	internal void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	// RVA: 0x1812DF0 Offset: 0x18113F0 VA: 0x181812DF0
	public void Release() { }

	// RVA: 0x1813A60 Offset: 0x1812060 VA: 0x181813A60
	public int get_count() { }

	// RVA: 0x1813470 Offset: 0x1811A70 VA: 0x181813470
	public void SetData(Array data) { }

	// RVA: 0x1813650 Offset: 0x1811C50 VA: 0x181813650
	public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

	// RVA: -1 Offset: -1
	public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB5C0 Offset: 0x5C9BC0 VA: 0x1805CB5C0
	|-ComputeBuffer.SetData<uint>
	|
	|-RVA: 0x5CB750 Offset: 0x5C9D50 VA: 0x1805CB750
	|-ComputeBuffer.SetData<Vector4>
	*/

	[FreeFunctionAttribute] // RVA: 0xC9930 Offset: 0xC8D30 VA: 0x1800C9930
	// RVA: 0x1813400 Offset: 0x1811A00 VA: 0x181813400
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunctionAttribute] // RVA: 0xC9A10 Offset: 0xC8E10 VA: 0x1800C9A10
	// RVA: 0x1813390 Offset: 0x1811990 VA: 0x181813390
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x18130A0 Offset: 0x18116A0 VA: 0x1818130A0
	public void GetData(Array data) { }

	[FreeFunctionAttribute] // RVA: 0xC9AA0 Offset: 0xC8EA0 VA: 0x1800C9AA0
	// RVA: 0x1813320 Offset: 0x1811920 VA: 0x181813320
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x1812D50 Offset: 0x1811350 VA: 0x181812D50
	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) { }

	// RVA: 0x1813280 Offset: 0x1811880 VA: 0x181813280
	public IntPtr GetNativeBufferPtr() { }

}

