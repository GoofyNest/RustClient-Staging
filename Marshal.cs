public static class Marshal // TypeDefIndex: 1355
{	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4

	// Methods

	// RVA: 0xFE9F90 Offset: 0xFE8590 VA: 0x180FE9F90
	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFE9FA0 Offset: 0xFE85A0 VA: 0x180FE9FA0
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFE9FB0 Offset: 0xFE85B0 VA: 0x180FE9FB0
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0xFEAEA0 Offset: 0xFE94A0 VA: 0x180FEAEA0
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFEAE90 Offset: 0xFE9490 VA: 0x180FEAE90
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0xFEA120 Offset: 0xFE8720 VA: 0x180FEA120
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFEA3A0 Offset: 0xFE89A0 VA: 0x180FEA3A0
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFEA320 Offset: 0xFE8920 VA: 0x180FEA320
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0xFEA2A0 Offset: 0xFE88A0 VA: 0x180FEA2A0
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0xFEA220 Offset: 0xFE8820 VA: 0x180FEA220
	public static void Copy(IntPtr source, float[] destination, int startIndex, int length) { }

	// RVA: 0xFEA1A0 Offset: 0xFE87A0 VA: 0x180FEA1A0
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	// RVA: 0xFEA420 Offset: 0xFE8A20 VA: 0x180FEA420
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA430 Offset: 0xFE8A30 VA: 0x180FEA430
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0xFEA010 Offset: 0xFE8610 VA: 0x180FEA010
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0xFEACD0 Offset: 0xFE92D0 VA: 0x180FEACD0
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0xFEA450 Offset: 0xFE8A50 VA: 0x180FEA450
	public static int GetHRForException(Exception e) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA460 Offset: 0xFE8A60 VA: 0x180FEA460
	public static int GetLastWin32Error() { }

	// RVA: 0xFEA470 Offset: 0xFE8A70 VA: 0x180FEA470
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0xFEA490 Offset: 0xFE8A90 VA: 0x180FEA490
	public static string PtrToStringUni(IntPtr ptr) { }

	// RVA: 0xFEA480 Offset: 0xFE8A80 VA: 0x180FEA480
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0xFEA4A0 Offset: 0xFE8AA0 VA: 0x180FEA4A0
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0130 Offset: 0xBDE730 VA: 0x180BE0130
	|-Marshal.PtrToStructure<UnityTls.unitytls_interface_struct>
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0xBDFFB0 Offset: 0xBDE5B0 VA: 0x180BDFFB0
	|-Marshal.PtrToStructure<NetMsg>
	|
	|-RVA: 0xBE0210 Offset: 0xBDE810 VA: 0x180BE0210
	|-Marshal.PtrToStructure<Win32_FIXED_INFO>
	*/

	// RVA: 0xFEA4B0 Offset: 0xFE8AB0 VA: 0x180FEA4B0
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0xFEA4D0 Offset: 0xFE8AD0 VA: 0x180FEA4D0
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA520 Offset: 0xFE8B20 VA: 0x180FEA520
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA560 Offset: 0xFE8B60 VA: 0x180FEA560
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA600 Offset: 0xFE8C00 VA: 0x180FEA600
	public static long ReadInt64(IntPtr ptr) { }

	// RVA: 0xFEA5B0 Offset: 0xFE8BB0 VA: 0x180FEA5B0
	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA770 Offset: 0xFE8D70 VA: 0x180FEA770
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA650 Offset: 0xFE8C50 VA: 0x180FEA650
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA880 Offset: 0xFE8E80 VA: 0x180FEA880
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA890 Offset: 0xFE8E90 VA: 0x180FEA890
	public static int Release(IntPtr pUnk) { }

	// RVA: 0xFEAC40 Offset: 0xFE9240 VA: 0x180FEAC40
	public static int SizeOf(Type t) { }

	// RVA: -1 Offset: -1
	public static int SizeOf<T>(T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED63F0 Offset: 0xED49F0 VA: 0x180ED63F0
	|-Marshal.SizeOf<Os.SECURITY_ATTRIBUTES>
	|
	|-RVA: 0xED6380 Offset: 0xED4980 VA: 0x180ED6380
	|-Marshal.SizeOf<object>
	*/

	// RVA: 0xFEAC50 Offset: 0xFE9250 VA: 0x180FEAC50
	public static IntPtr StringToHGlobalAnsi(string s) { }

	// RVA: 0xFEA930 Offset: 0xFE8F30 VA: 0x180FEA930
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	// RVA: 0xFEABB0 Offset: 0xFE91B0 VA: 0x180FEABB0
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisibleAttribute] // RVA: 0xE0D30 Offset: 0xE0130 VA: 0x1800E0D30
	[ReliabilityContractAttribute] // RVA: 0xE0D30 Offset: 0xE0130 VA: 0x1800E0D30
	// RVA: 0xFEAC60 Offset: 0xFE9260 VA: 0x180FEAC60
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF088F0 Offset: 0xF06EF0 VA: 0x180F088F0
	|-Marshal.StructureToPtr<object>
	*/

	// RVA: 0xFEAC70 Offset: 0xFE9270 VA: 0x180FEAC70
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED64B0 Offset: 0xED4AB0 VA: 0x180ED64B0
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0xED6510 Offset: 0xED4B10 VA: 0x180ED6510
	|-Marshal.UnsafeAddrOfPinnedArrayElement<object>
	*/

	// RVA: 0xFEAC80 Offset: 0xFE9280 VA: 0x180FEAC80
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0xFEA440 Offset: 0xFE8A40 VA: 0x180FEA440
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED62C0 Offset: 0xED48C0 VA: 0x180ED62C0
	|-Marshal.GetFunctionPointerForDelegate<BufferManager.FreeFn>
	|-Marshal.GetFunctionPointerForDelegate<object>
	|-Marshal.GetFunctionPointerForDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>
	*/

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void SetLastWin32Error(int error) { }

	// RVA: 0xFEAE30 Offset: 0xFE9430 VA: 0x180FEAE30
	private static void .cctor() { }

}

