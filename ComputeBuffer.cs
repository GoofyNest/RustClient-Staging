public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3549
{	internal IntPtr m_Ptr; // 0x10

	public int count { get; }


	protected override void Finalize() { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute] // RVA: 0xC97E0 Offset: 0xC8BE0 VA: 0x1800C97E0
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute] // RVA: 0xC9890 Offset: 0xC8C90 VA: 0x1800C9890
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
	|-ComputeBuffer.SetData<uint>
	|
	|-ComputeBuffer.SetData<Vector4>
	*/

	[FreeFunctionAttribute] // RVA: 0xC99E0 Offset: 0xC8DE0 VA: 0x1800C99E0
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunctionAttribute] // RVA: 0xC9B10 Offset: 0xC8F10 VA: 0x1800C9B10
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public void GetData(Array data) { }

	[FreeFunctionAttribute] // RVA: 0xC9BF0 Offset: 0xC8FF0 VA: 0x1800C9BF0
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) { }

	public IntPtr GetNativeBufferPtr() { }

}

