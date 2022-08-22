public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3549
{	internal IntPtr m_Ptr; // 0x10

	public int count { get; }


	protected override void Finalize() { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute] // RVA: 0xC9780 Offset: 0xC8B80 VA: 0x1800C9780
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute] // RVA: 0xC9830 Offset: 0xC8C30 VA: 0x1800C9830
	private static void DestroyBuffer(ComputeBuffer buf) { }

	public void .ctor(int count, int stride) { }

	public void .ctor(int count, int stride, ComputeBufferType type) { }

	internal void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	public void Release() { }

	public int get_count() { }

	public void SetData(Array data) { }

	public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

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
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunctionAttribute] // RVA: 0xC9A10 Offset: 0xC8E10 VA: 0x1800C9A10
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public void GetData(Array data) { }

	[FreeFunctionAttribute] // RVA: 0xC9AA0 Offset: 0xC8EA0 VA: 0x1800C9AA0
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) { }

	public IntPtr GetNativeBufferPtr() { }

}

