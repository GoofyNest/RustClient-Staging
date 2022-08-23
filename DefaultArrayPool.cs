private sealed class DefaultArrayPool.Bucket<T> // TypeDefIndex: 6271
{	internal readonly int _bufferLength; // 0x0
	private readonly T[][] _buffers; // 0x0
	private readonly int _poolId; // 0x0
	private SpinLock _lock; // 0x0
	private int _index; // 0x0

	internal int Id { get; }


	internal void .ctor(int bufferLength, int numberOfBuffers, int poolId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A05670 Offset: 0x1A03C70 VA: 0x181A05670
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-RVA: 0x1A05760 Offset: 0x1A03D60 VA: 0x181A05760
	|-DefaultArrayPool.Bucket<object>..ctor
	*/

	internal int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA06E0 Offset: 0xB9ECE0 VA: 0x180BA06E0
	|-DefaultArrayPool.Bucket<byte>.get_Id
	|-DefaultArrayPool.Bucket<object>.get_Id
	*/

	internal T[] Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A05080 Offset: 0x1A03680 VA: 0x181A05080
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-RVA: 0x1A04E10 Offset: 0x1A03410 VA: 0x181A04E10
	|-DefaultArrayPool.Bucket<object>.Rent
	*/

	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A052F0 Offset: 0x1A038F0 VA: 0x181A052F0
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-RVA: 0x1A054B0 Offset: 0x1A03AB0 VA: 0x181A054B0
	|-DefaultArrayPool.Bucket<object>.Return
	*/

}

