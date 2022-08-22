internal static class JitHelpers // TypeDefIndex: 1313
{
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0610 Offset: 0xBDEC10 VA: 0x180BE0610
	|-JitHelpers.UnsafeCast<object>
	*/

	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0610 Offset: 0xBDEC10 VA: 0x180BE0610
	|-JitHelpers.UnsafeEnumCast<ByteEnum>
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	*/

	internal static long UnsafeEnumCastLong<T>(T val) { }

}

