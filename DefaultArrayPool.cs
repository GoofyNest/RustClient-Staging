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
	|-RVA: 0x192E620 Offset: 0x192CC20 VA: 0x18192E620
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-RVA: 0x192E710 Offset: 0x192CD10 VA: 0x18192E710
	|-DefaultArrayPool.Bucket<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9FE10 Offset: 0xB9E410 VA: 0x180B9FE10
	|-DefaultArrayPool.Bucket<byte>.get_Id
	|-DefaultArrayPool.Bucket<object>.get_Id
	*/

	// RVA: -1 Offset: -1
	internal T[] Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x192E030 Offset: 0x192C630 VA: 0x18192E030
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-RVA: 0x192DDC0 Offset: 0x192C3C0 VA: 0x18192DDC0
	|-DefaultArrayPool.Bucket<object>.Rent
	*/

	// RVA: -1 Offset: -1
	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x192E2A0 Offset: 0x192C8A0 VA: 0x18192E2A0
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-RVA: 0x192E460 Offset: 0x192CA60 VA: 0x18192E460
	|-DefaultArrayPool.Bucket<object>.Return
	*/

}

