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
	|-RVA: 0x1A05630 Offset: 0x1A03C30 VA: 0x181A05630
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-RVA: 0x1A05720 Offset: 0x1A03D20 VA: 0x181A05720
	|-DefaultArrayPool.Bucket<object>..ctor
	*/

	internal int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA05A0 Offset: 0xB9EBA0 VA: 0x180BA05A0
	|-DefaultArrayPool.Bucket<byte>.get_Id
	|-DefaultArrayPool.Bucket<object>.get_Id
	*/

	internal T[] Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A05040 Offset: 0x1A03640 VA: 0x181A05040
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-RVA: 0x1A04DD0 Offset: 0x1A033D0 VA: 0x181A04DD0
	|-DefaultArrayPool.Bucket<object>.Rent
	*/

	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A052B0 Offset: 0x1A038B0 VA: 0x181A052B0
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-RVA: 0x1A05470 Offset: 0x1A03A70 VA: 0x181A05470
	|-DefaultArrayPool.Bucket<object>.Return
	*/

}

