internal static class Unsafe // TypeDefIndex: 1318
{	// Methods

	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAC20 Offset: 0x15B9220 VA: 0x1815BAC20
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x15BAC30 Offset: 0x15B9230 VA: 0x1815BAC30
	|-Unsafe.Add<char>
	|
	|-RVA: 0x15BAC40 Offset: 0x15B9240 VA: 0x1815BAC40
	|-Unsafe.Add<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAC10 Offset: 0x15B9210 VA: 0x1815BAC10
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<object>
	*/

	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-Unsafe.As<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<object>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA520 Offset: 0xED8B20 VA: 0x180EDA520
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<object>
	*/

}

public static class Unsafe // TypeDefIndex: 6664
{
// Namespace: System.Runtime.CompilerServices
public static class Unsafe // TypeDefIndex: 6664
	// Methods

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870
	|-Unsafe.SizeOf<byte>
	|
	|-RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20
	|-Unsafe.SizeOf<short>
	|
	|-RVA: 0x8C1310 Offset: 0x8BF910 VA: 0x1808C1310
	|-Unsafe.SizeOf<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2323C90 Offset: 0x2322290 VA: 0x182323C90
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	|-Unsafe.As<Pinnable<char>>
	|-Unsafe.As<IValueTaskSource>
	|-Unsafe.As<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
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
	// RVA: -1 Offset: -1
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
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAC20 Offset: 0x15B9220 VA: 0x1815BAC20
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x15BAC30 Offset: 0x15B9230 VA: 0x1815BAC30
	|-Unsafe.Add<short>
	|
	|-RVA: 0x15BAC40 Offset: 0x15B9240 VA: 0x1815BAC40
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAC10 Offset: 0x15B9210 VA: 0x1815BAC10
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x15BAC50 Offset: 0x15B9250 VA: 0x1815BAC50
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAC10 Offset: 0x15B9210 VA: 0x1815BAC10
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<short>
	|-Unsafe.AddByteOffset<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA520 Offset: 0xED8B20 VA: 0x180EDA520
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<short>
	|-Unsafe.ByteOffset<object>
	*/

}

