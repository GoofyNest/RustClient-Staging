public static class ByteExtensions // TypeDefIndex: 4841
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T ReadUnsafe<T>(byte[] buffer, int iOffset = 0) { }
	/* GenericInstMethod :
	|
	|-ByteExtensions.ReadUnsafe<double>
	|
	|-ByteExtensions.ReadUnsafe<float>
	|
	|-ByteExtensions.ReadUnsafe<byte>
	|-ByteExtensions.ReadUnsafe<sbyte>
	|
	|-ByteExtensions.ReadUnsafe<short>
	|-ByteExtensions.ReadUnsafe<ushort>
	|
	|-ByteExtensions.ReadUnsafe<int>
	|-ByteExtensions.ReadUnsafe<uint>
	|
	|-ByteExtensions.ReadUnsafe<long>
	|-ByteExtensions.ReadUnsafe<ulong>
	|
	|-ByteExtensions.ReadUnsafe<Color>
	|-ByteExtensions.ReadUnsafe<Quaternion>
	|
	|-ByteExtensions.ReadUnsafe<Ray>
	|
	|-ByteExtensions.ReadUnsafe<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void WriteUnsafe<T>(byte[] buffer, in T value, int iOffset = 0) { }
	/* GenericInstMethod :
	|
	|-ByteExtensions.WriteUnsafe<byte>
	|-ByteExtensions.WriteUnsafe<sbyte>
	|
	|-ByteExtensions.WriteUnsafe<double>
	|-ByteExtensions.WriteUnsafe<long>
	|-ByteExtensions.WriteUnsafe<ulong>
	|
	|-ByteExtensions.WriteUnsafe<short>
	|-ByteExtensions.WriteUnsafe<ushort>
	|
	|-ByteExtensions.WriteUnsafe<int>
	|-ByteExtensions.WriteUnsafe<float>
	|-ByteExtensions.WriteUnsafe<uint>
	*/

}

