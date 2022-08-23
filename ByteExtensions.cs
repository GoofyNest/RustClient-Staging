public static class ByteExtensions // TypeDefIndex: 4841
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T ReadUnsafe<T>(byte[] buffer, int iOffset = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB2A0 Offset: 0x5C98A0 VA: 0x1805CB2A0
	|-ByteExtensions.ReadUnsafe<double>
	|
	|-RVA: 0x5CB3A0 Offset: 0x5C99A0 VA: 0x1805CB3A0
	|-ByteExtensions.ReadUnsafe<float>
	|
	|-RVA: 0x5CB230 Offset: 0x5C9830 VA: 0x1805CB230
	|-ByteExtensions.ReadUnsafe<byte>
	|-ByteExtensions.ReadUnsafe<sbyte>
	|
	|-RVA: 0x5CB2D0 Offset: 0x5C98D0 VA: 0x1805CB2D0
	|-ByteExtensions.ReadUnsafe<short>
	|-ByteExtensions.ReadUnsafe<ushort>
	|
	|-RVA: 0x5CB300 Offset: 0x5C9900 VA: 0x1805CB300
	|-ByteExtensions.ReadUnsafe<int>
	|-ByteExtensions.ReadUnsafe<uint>
	|
	|-RVA: 0x5CB330 Offset: 0x5C9930 VA: 0x1805CB330
	|-ByteExtensions.ReadUnsafe<long>
	|-ByteExtensions.ReadUnsafe<ulong>
	|
	|-RVA: 0x5CB260 Offset: 0x5C9860 VA: 0x1805CB260
	|-ByteExtensions.ReadUnsafe<Color>
	|-ByteExtensions.ReadUnsafe<Quaternion>
	|
	|-RVA: 0x5CB360 Offset: 0x5C9960 VA: 0x1805CB360
	|-ByteExtensions.ReadUnsafe<Ray>
	|
	|-RVA: 0x5CB3D0 Offset: 0x5C99D0 VA: 0x1805CB3D0
	|-ByteExtensions.ReadUnsafe<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void WriteUnsafe<T>(byte[] buffer, in T value, int iOffset = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1570830 Offset: 0x156EE30 VA: 0x181570830
	|-ByteExtensions.WriteUnsafe<byte>
	|-ByteExtensions.WriteUnsafe<sbyte>
	|
	|-RVA: 0x1570870 Offset: 0x156EE70 VA: 0x181570870
	|-ByteExtensions.WriteUnsafe<double>
	|-ByteExtensions.WriteUnsafe<long>
	|-ByteExtensions.WriteUnsafe<ulong>
	|
	|-RVA: 0x15708B0 Offset: 0x156EEB0 VA: 0x1815708B0
	|-ByteExtensions.WriteUnsafe<short>
	|-ByteExtensions.WriteUnsafe<ushort>
	|
	|-RVA: 0x15708F0 Offset: 0x156EEF0 VA: 0x1815708F0
	|-ByteExtensions.WriteUnsafe<int>
	|-ByteExtensions.WriteUnsafe<float>
	|-ByteExtensions.WriteUnsafe<uint>
	*/

}

