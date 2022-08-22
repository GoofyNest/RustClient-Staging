public static class Marshal // TypeDefIndex: 1355
{	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4

	// Methods

	// RVA: 0xFEA250 Offset: 0xFE8850 VA: 0x180FEA250
	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFEA260 Offset: 0xFE8860 VA: 0x180FEA260
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFEA270 Offset: 0xFE8870 VA: 0x180FEA270
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0xFEB160 Offset: 0xFE9760 VA: 0x180FEB160
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFEB150 Offset: 0xFE9750 VA: 0x180FEB150
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0xFEA3E0 Offset: 0xFE89E0 VA: 0x180FEA3E0
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFEA660 Offset: 0xFE8C60 VA: 0x180FEA660
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFEA5E0 Offset: 0xFE8BE0 VA: 0x180FEA5E0
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0xFEA560 Offset: 0xFE8B60 VA: 0x180FEA560
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0xFEA4E0 Offset: 0xFE8AE0 VA: 0x180FEA4E0
	public static void Copy(IntPtr source, float[] destination, int startIndex, int length) { }

	// RVA: 0xFEA460 Offset: 0xFE8A60 VA: 0x180FEA460
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	// RVA: 0xFEA6E0 Offset: 0xFE8CE0 VA: 0x180FEA6E0
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA6F0 Offset: 0xFE8CF0 VA: 0x180FEA6F0
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0xFEA2D0 Offset: 0xFE88D0 VA: 0x180FEA2D0
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0xFEAF90 Offset: 0xFE9590 VA: 0x180FEAF90
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0xFEA710 Offset: 0xFE8D10 VA: 0x180FEA710
	public static int GetHRForException(Exception e) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA720 Offset: 0xFE8D20 VA: 0x180FEA720
	public static int GetLastWin32Error() { }

	// RVA: 0xFEA730 Offset: 0xFE8D30 VA: 0x180FEA730
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0xFEA750 Offset: 0xFE8D50 VA: 0x180FEA750
	public static string PtrToStringUni(IntPtr ptr) { }

	// RVA: 0xFEA740 Offset: 0xFE8D40 VA: 0x180FEA740
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0xFEA760 Offset: 0xFE8D60 VA: 0x180FEA760
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE03F0 Offset: 0xBDE9F0 VA: 0x180BE03F0
	|-Marshal.PtrToStructure<UnityTls.unitytls_interface_struct>
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0xBE0270 Offset: 0xBDE870 VA: 0x180BE0270
	|-Marshal.PtrToStructure<NetMsg>
	|
	|-RVA: 0xBE04D0 Offset: 0xBDEAD0 VA: 0x180BE04D0
	|-Marshal.PtrToStructure<Win32_FIXED_INFO>
	*/

	// RVA: 0xFEA770 Offset: 0xFE8D70 VA: 0x180FEA770
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0xFEA790 Offset: 0xFE8D90 VA: 0x180FEA790
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA7E0 Offset: 0xFE8DE0 VA: 0x180FEA7E0
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA820 Offset: 0xFE8E20 VA: 0x180FEA820
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA8C0 Offset: 0xFE8EC0 VA: 0x180FEA8C0
	public static long ReadInt64(IntPtr ptr) { }

	// RVA: 0xFEA870 Offset: 0xFE8E70 VA: 0x180FEA870
	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEAA30 Offset: 0xFE9030 VA: 0x180FEAA30
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEA910 Offset: 0xFE8F10 VA: 0x180FEA910
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEAB40 Offset: 0xFE9140 VA: 0x180FEAB40
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEAB50 Offset: 0xFE9150 VA: 0x180FEAB50
	public static int Release(IntPtr pUnk) { }

	// RVA: 0xFEAF00 Offset: 0xFE9500 VA: 0x180FEAF00
	public static int SizeOf(Type t) { }

	// RVA: -1 Offset: -1
	public static int SizeOf<T>(T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED66B0 Offset: 0xED4CB0 VA: 0x180ED66B0
	|-Marshal.SizeOf<Os.SECURITY_ATTRIBUTES>
	|
	|-RVA: 0xED6640 Offset: 0xED4C40 VA: 0x180ED6640
	|-Marshal.SizeOf<object>
	*/

	// RVA: 0xFEAF10 Offset: 0xFE9510 VA: 0x180FEAF10
	public static IntPtr StringToHGlobalAnsi(string s) { }

	// RVA: 0xFEABF0 Offset: 0xFE91F0 VA: 0x180FEABF0
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	// RVA: 0xFEAE70 Offset: 0xFE9470 VA: 0x180FEAE70
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisibleAttribute] // RVA: 0xE0D30 Offset: 0xE0130 VA: 0x1800E0D30
	[ReliabilityContractAttribute] // RVA: 0xE0D30 Offset: 0xE0130 VA: 0x1800E0D30
	// RVA: 0xFEAF20 Offset: 0xFE9520 VA: 0x180FEAF20
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08BB0 Offset: 0xF071B0 VA: 0x180F08BB0
	|-Marshal.StructureToPtr<object>
	*/

	// RVA: 0xFEAF30 Offset: 0xFE9530 VA: 0x180FEAF30
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6770 Offset: 0xED4D70 VA: 0x180ED6770
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0xED67D0 Offset: 0xED4DD0 VA: 0x180ED67D0
	|-Marshal.UnsafeAddrOfPinnedArrayElement<object>
	*/

	// RVA: 0xFEAF40 Offset: 0xFE9540 VA: 0x180FEAF40
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0xFEA700 Offset: 0xFE8D00 VA: 0x180FEA700
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6580 Offset: 0xED4B80 VA: 0x180ED6580
	|-Marshal.GetFunctionPointerForDelegate<BufferManager.FreeFn>
	|-Marshal.GetFunctionPointerForDelegate<object>
	|-Marshal.GetFunctionPointerForDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>
	*/

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void SetLastWin32Error(int error) { }

	// RVA: 0xFEB0F0 Offset: 0xFE96F0 VA: 0x180FEB0F0
	private static void .cctor() { }

}

