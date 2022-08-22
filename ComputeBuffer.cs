public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3549
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public int count { get; }

	// Methods

	// RVA: 0x1825910 Offset: 0x1823F10 VA: 0x181825910 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18256F0 Offset: 0x1823CF0 VA: 0x1818256F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1825790 Offset: 0x1823D90 VA: 0x181825790
	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute] // RVA: 0xC9780 Offset: 0xC8B80 VA: 0x1800C9780
	// RVA: 0x1825BC0 Offset: 0x18241C0 VA: 0x181825BC0
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute] // RVA: 0xC9830 Offset: 0xC8C30 VA: 0x1800C9830
	// RVA: 0x18256B0 Offset: 0x1823CB0 VA: 0x1818256B0
	private static void DestroyBuffer(ComputeBuffer buf) { }

	// RVA: 0x1826300 Offset: 0x1824900 VA: 0x181826300
	public void .ctor(int count, int stride) { }

	// RVA: 0x1826330 Offset: 0x1824930 VA: 0x181826330
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x18261F0 Offset: 0x18247F0 VA: 0x1818261F0
	internal void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	// RVA: 0x18256F0 Offset: 0x1823CF0 VA: 0x1818256F0
	public void Release() { }

	// RVA: 0x1826360 Offset: 0x1824960 VA: 0x181826360
	public int get_count() { }

	// RVA: 0x1825D70 Offset: 0x1824370 VA: 0x181825D70
	public void SetData(Array data) { }

	// RVA: 0x1825F50 Offset: 0x1824550 VA: 0x181825F50
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
	// RVA: 0x1825D00 Offset: 0x1824300 VA: 0x181825D00
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunctionAttribute] // RVA: 0xC9A10 Offset: 0xC8E10 VA: 0x1800C9A10
	// RVA: 0x1825C90 Offset: 0x1824290 VA: 0x181825C90
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x18259A0 Offset: 0x1823FA0 VA: 0x1818259A0
	public void GetData(Array data) { }

	[FreeFunctionAttribute] // RVA: 0xC9AA0 Offset: 0xC8EA0 VA: 0x1800C9AA0
	// RVA: 0x1825C20 Offset: 0x1824220 VA: 0x181825C20
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x1825650 Offset: 0x1823C50 VA: 0x181825650
	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) { }

	// RVA: 0x1825B80 Offset: 0x1824180 VA: 0x181825B80
	public IntPtr GetNativeBufferPtr() { }

}

