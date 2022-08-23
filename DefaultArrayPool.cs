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
	|-RVA: 0x1A05770 Offset: 0x1A03D70 VA: 0x181A05770
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-RVA: 0x1A05860 Offset: 0x1A03E60 VA: 0x181A05860
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
	|-RVA: 0x1A05180 Offset: 0x1A03780 VA: 0x181A05180
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-RVA: 0x1A04F10 Offset: 0x1A03510 VA: 0x181A04F10
	|-DefaultArrayPool.Bucket<object>.Rent
	*/

	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A053F0 Offset: 0x1A039F0 VA: 0x181A053F0
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-RVA: 0x1A055B0 Offset: 0x1A03BB0 VA: 0x181A055B0
	|-DefaultArrayPool.Bucket<object>.Return
	*/

}

