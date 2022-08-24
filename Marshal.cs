public static class Marshal // TypeDefIndex: 1355
{
	public static readonly int SystemMaxDBCSCharSize; 
	public static readonly int SystemDefaultCharSize; 


	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContractAttribute] 
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContractAttribute] 
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

	[ReliabilityContractAttribute] 
	public static void FreeHGlobal(IntPtr hglobal) { }

	private static void ClearUnicode(IntPtr ptr) { }

	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	public static int GetHRForException(Exception e) { }

	[ReliabilityContractAttribute] 
	public static int GetLastWin32Error() { }

	public static string PtrToStringAnsi(IntPtr ptr) { }

	public static string PtrToStringUni(IntPtr ptr) { }

	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisibleAttribute] 
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-Marshal.PtrToStructure<UnityTls.unitytls_interface_struct>
	|-Marshal.PtrToStructure<object>
	|
	|-Marshal.PtrToStructure<NetMsg>
	|
	|-Marshal.PtrToStructure<Win32_FIXED_INFO>
	*/

	public static byte ReadByte(IntPtr ptr, int ofs) { }

	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] 
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContractAttribute] 
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] 
	public static long ReadInt64(IntPtr ptr) { }

	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] 
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContractAttribute] 
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] 
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContractAttribute] 
	public static int Release(IntPtr pUnk) { }

	public static int SizeOf(Type t) { }

	public static int SizeOf<T>(T structure) { }
	/* GenericInstMethod :
	|
	|-Marshal.SizeOf<Os.SECURITY_ATTRIBUTES>
	|
	|-Marshal.SizeOf<object>
	*/

	public static IntPtr StringToHGlobalAnsi(string s) { }

	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisibleAttribute] 
	[ReliabilityContractAttribute] 
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-Marshal.StructureToPtr<object>
	*/

	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-Marshal.UnsafeAddrOfPinnedArrayElement<object>
	*/

	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-Marshal.GetFunctionPointerForDelegate<BufferManager.FreeFn>
	|-Marshal.GetFunctionPointerForDelegate<object>
	|-Marshal.GetFunctionPointerForDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>
	*/

	internal static void SetLastWin32Error(int error) { }

	private static void .cctor() { }

}

