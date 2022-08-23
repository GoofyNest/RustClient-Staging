public static class Marshal // TypeDefIndex: 1355
{	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4


	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	public static IntPtr AllocHGlobal(int cb) { }

	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, float[] destination, int startIndex, int length) { }

	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static void FreeHGlobal(IntPtr hglobal) { }

	private static void ClearUnicode(IntPtr ptr) { }

	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	public static int GetHRForException(Exception e) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int GetLastWin32Error() { }

	public static string PtrToStringAnsi(IntPtr ptr) { }

	public static string PtrToStringUni(IntPtr ptr) { }

	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE09C0 Offset: 0xBDEFC0 VA: 0x180BE09C0
	|-Marshal.PtrToStructure<UnityTls.unitytls_interface_struct>
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0xBE0840 Offset: 0xBDEE40 VA: 0x180BE0840
	|-Marshal.PtrToStructure<NetMsg>
	|
	|-RVA: 0xBE0AA0 Offset: 0xBDF0A0 VA: 0x180BE0AA0
	|-Marshal.PtrToStructure<Win32_FIXED_INFO>
	*/

	public static byte ReadByte(IntPtr ptr, int ofs) { }

	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static long ReadInt64(IntPtr ptr) { }

	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int Release(IntPtr pUnk) { }

	public static int SizeOf(Type t) { }

	public static int SizeOf<T>(T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7260 Offset: 0xED5860 VA: 0x180ED7260
	|-Marshal.SizeOf<Os.SECURITY_ATTRIBUTES>
	|
	|-RVA: 0xED71F0 Offset: 0xED57F0 VA: 0x180ED71F0
	|-Marshal.SizeOf<object>
	*/

	public static IntPtr StringToHGlobalAnsi(string s) { }

	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisibleAttribute] // RVA: 0xE0D30 Offset: 0xE0130 VA: 0x1800E0D30
	[ReliabilityContractAttribute] // RVA: 0xE0D30 Offset: 0xE0130 VA: 0x1800E0D30
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09750 Offset: 0xF07D50 VA: 0x180F09750
	|-Marshal.StructureToPtr<object>
	*/

	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7320 Offset: 0xED5920 VA: 0x180ED7320
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0xED7380 Offset: 0xED5980 VA: 0x180ED7380
	|-Marshal.UnsafeAddrOfPinnedArrayElement<object>
	*/

	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7130 Offset: 0xED5730 VA: 0x180ED7130
	|-Marshal.GetFunctionPointerForDelegate<BufferManager.FreeFn>
	|-Marshal.GetFunctionPointerForDelegate<object>
	|-Marshal.GetFunctionPointerForDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>
	*/

	internal static void SetLastWin32Error(int error) { }

	private static void .cctor() { }

}

