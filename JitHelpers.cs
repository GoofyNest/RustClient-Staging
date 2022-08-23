internal static class JitHelpers // TypeDefIndex: 1313
{
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0750 Offset: 0xBDED50 VA: 0x180BE0750
	|-JitHelpers.UnsafeCast<object>
	*/

	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0750 Offset: 0xBDED50 VA: 0x180BE0750
	|-JitHelpers.UnsafeEnumCast<ByteEnum>
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	*/

	internal static long UnsafeEnumCastLong<T>(T val) { }

}

