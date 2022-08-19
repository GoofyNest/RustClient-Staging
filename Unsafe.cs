internal static class Unsafe // TypeDefIndex: 1318
{	// Methods

	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB890 Offset: 0x15B9E90 VA: 0x1815BB890
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x15BB8A0 Offset: 0x15B9EA0 VA: 0x1815BB8A0
	|-Unsafe.Add<char>
	|
	|-RVA: 0x15BB8B0 Offset: 0x15B9EB0 VA: 0x1815BB8B0
	|-Unsafe.Add<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB880 Offset: 0x15B9E80 VA: 0x1815BB880
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<object>
	*/

	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	|-Unsafe.As<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<object>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED97B0 Offset: 0xED7DB0 VA: 0x180ED97B0
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

	[NonVersionableAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	|-Unsafe.SizeOf<byte>
	|
	|-RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90
	|-Unsafe.SizeOf<short>
	|
	|-RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0
	|-Unsafe.SizeOf<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2323370 Offset: 0x2321970 VA: 0x182323370
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionableAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	|-Unsafe.As<Pinnable<char>>
	|-Unsafe.As<IValueTaskSource>
	|-Unsafe.As<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<short>
	|-Unsafe.AsRef<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	|-Unsafe.As<byte, byte>
	|-Unsafe.As<byte, char>
	|-Unsafe.As<short, byte>
	|-Unsafe.As<short, char>
	|-Unsafe.As<object, byte>
	|-Unsafe.As<object, char>
	|-Unsafe.As<object, object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB890 Offset: 0x15B9E90 VA: 0x1815BB890
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x15BB8A0 Offset: 0x15B9EA0 VA: 0x1815BB8A0
	|-Unsafe.Add<short>
	|
	|-RVA: 0x15BB8B0 Offset: 0x15B9EB0 VA: 0x1815BB8B0
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB880 Offset: 0x15B9E80 VA: 0x1815BB880
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x15BB8C0 Offset: 0x15B9EC0 VA: 0x1815BB8C0
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB880 Offset: 0x15B9E80 VA: 0x1815BB880
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<short>
	|-Unsafe.AddByteOffset<object>
	*/

	[NonVersionableAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED97B0 Offset: 0xED7DB0 VA: 0x180ED97B0
	|-Unsafe.ByteOffset<byte>
	|-Unsafe.ByteOffset<char>
	|-Unsafe.ByteOffset<short>
	|-Unsafe.ByteOffset<object>
	*/

}

