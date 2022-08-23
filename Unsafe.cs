internal static class Unsafe // TypeDefIndex: 1318
{
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAD20 Offset: 0x15B9320 VA: 0x1815BAD20
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x15BAD30 Offset: 0x15B9330 VA: 0x1815BAD30
	|-Unsafe.Add<char>
	|
	|-RVA: 0x15BAD40 Offset: 0x15B9340 VA: 0x1815BAD40
	|-Unsafe.Add<object>
	*/

	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAD10 Offset: 0x15B9310 VA: 0x1815BAD10
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<object>
	*/

	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-Unsafe.As<object>
	*/

	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<object>
	*/

	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA620 Offset: 0xED8C20 VA: 0x180EDA620
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<object>
	*/

}

public static class Unsafe // TypeDefIndex: 6664
{
public static class Unsafe // TypeDefIndex: 6664

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B1940 Offset: 0x5AFF40 VA: 0x1805B1940
	|-Unsafe.SizeOf<byte>
	|
	|-RVA: 0x514710 Offset: 0x512D10 VA: 0x180514710
	|-Unsafe.SizeOf<short>
	|
	|-RVA: 0x8C13F0 Offset: 0x8BF9F0 VA: 0x1808C13F0
	|-Unsafe.SizeOf<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-Unsafe.As<Pinnable<char>>
	|-Unsafe.As<IValueTaskSource>
	|-Unsafe.As<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<short>
	|-Unsafe.AsRef<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-Unsafe.As<byte, byte>
	|-Unsafe.As<byte, char>
	|-Unsafe.As<short, byte>
	|-Unsafe.As<short, char>
	|-Unsafe.As<object, byte>
	|-Unsafe.As<object, char>
	|-Unsafe.As<object, object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAD20 Offset: 0x15B9320 VA: 0x1815BAD20
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x15BAD30 Offset: 0x15B9330 VA: 0x1815BAD30
	|-Unsafe.Add<short>
	|
	|-RVA: 0x15BAD40 Offset: 0x15B9340 VA: 0x1815BAD40
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAD10 Offset: 0x15B9310 VA: 0x1815BAD10
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x15BAD50 Offset: 0x15B9350 VA: 0x1815BAD50
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAD10 Offset: 0x15B9310 VA: 0x1815BAD10
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<short>
	|-Unsafe.AddByteOffset<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA620 Offset: 0xED8C20 VA: 0x180EDA620
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<short>
	|-Unsafe.ByteOffset<object>
	*/

}

