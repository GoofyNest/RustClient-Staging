private sealed class DefaultArrayPool.Bucket<T> // TypeDefIndex: 6271
{	// Fields
	internal readonly int _bufferLength; // 0x0
	private readonly T[][] _buffers; // 0x0
	private readonly int _poolId; // 0x0
	private SpinLock _lock; // 0x0
	private int _index; // 0x0

	// Properties
	internal int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int bufferLength, int numberOfBuffers, int poolId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x192E8E0 Offset: 0x192CEE0 VA: 0x18192E8E0
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-RVA: 0x192E9D0 Offset: 0x192CFD0 VA: 0x18192E9D0
	|-DefaultArrayPool.Bucket<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA00D0 Offset: 0xB9E6D0 VA: 0x180BA00D0
	|-DefaultArrayPool.Bucket<byte>.get_Id
	|-DefaultArrayPool.Bucket<object>.get_Id
	*/

	// RVA: -1 Offset: -1
	internal T[] Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x192E2F0 Offset: 0x192C8F0 VA: 0x18192E2F0
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-RVA: 0x192E080 Offset: 0x192C680 VA: 0x18192E080
	|-DefaultArrayPool.Bucket<object>.Rent
	*/

	// RVA: -1 Offset: -1
	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x192E560 Offset: 0x192CB60 VA: 0x18192E560
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-RVA: 0x192E720 Offset: 0x192CD20 VA: 0x18192E720
	|-DefaultArrayPool.Bucket<object>.Return
	*/

}

