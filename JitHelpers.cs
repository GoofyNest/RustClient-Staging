internal static class JitHelpers // TypeDefIndex: 1313
{
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0710 Offset: 0xBDED10 VA: 0x180BE0710
	|-JitHelpers.UnsafeCast<object>
	*/

	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0710 Offset: 0xBDED10 VA: 0x180BE0710
	|-JitHelpers.UnsafeEnumCast<ByteEnum>
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	*/

	internal static long UnsafeEnumCastLong<T>(T val) { }

}

