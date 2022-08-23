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
	|-RVA: 0x1A05730 Offset: 0x1A03D30 VA: 0x181A05730
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-RVA: 0x1A05820 Offset: 0x1A03E20 VA: 0x181A05820
	|-DefaultArrayPool.Bucket<object>..ctor
	*/

	internal int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA06A0 Offset: 0xB9ECA0 VA: 0x180BA06A0
	|-DefaultArrayPool.Bucket<byte>.get_Id
	|-DefaultArrayPool.Bucket<object>.get_Id
	*/

	internal T[] Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A05140 Offset: 0x1A03740 VA: 0x181A05140
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-RVA: 0x1A04ED0 Offset: 0x1A034D0 VA: 0x181A04ED0
	|-DefaultArrayPool.Bucket<object>.Rent
	*/

	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A053B0 Offset: 0x1A039B0 VA: 0x181A053B0
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-RVA: 0x1A05570 Offset: 0x1A03B70 VA: 0x181A05570
	|-DefaultArrayPool.Bucket<object>.Return
	*/

}

