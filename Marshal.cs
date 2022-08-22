public static class Marshal // TypeDefIndex: 1355
{	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4

	// Methods

	// RVA: 0xFEACF0 Offset: 0xFE92F0 VA: 0x180FEACF0
	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFEAD00 Offset: 0xFE9300 VA: 0x180FEAD00
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0xFEAD10 Offset: 0xFE9310 VA: 0x180FEAD10
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0xFEBC00 Offset: 0xFEA200 VA: 0x180FEBC00
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFEBBF0 Offset: 0xFEA1F0 VA: 0x180FEBBF0
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0xFEAE80 Offset: 0xFE9480 VA: 0x180FEAE80
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFEB100 Offset: 0xFE9700 VA: 0x180FEB100
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0xFEB080 Offset: 0xFE9680 VA: 0x180FEB080
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0xFEB000 Offset: 0xFE9600 VA: 0x180FEB000
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0xFEAF80 Offset: 0xFE9580 VA: 0x180FEAF80
	public static void Copy(IntPtr source, float[] destination, int startIndex, int length) { }

	// RVA: 0xFEAF00 Offset: 0xFE9500 VA: 0x180FEAF00
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	// RVA: 0xFEB180 Offset: 0xFE9780 VA: 0x180FEB180
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEB190 Offset: 0xFE9790 VA: 0x180FEB190
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0xFEAD70 Offset: 0xFE9370 VA: 0x180FEAD70
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0xFEBA30 Offset: 0xFEA030 VA: 0x180FEBA30
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0xFEB1B0 Offset: 0xFE97B0 VA: 0x180FEB1B0
	public static int GetHRForException(Exception e) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEB1C0 Offset: 0xFE97C0 VA: 0x180FEB1C0
	public static int GetLastWin32Error() { }

	// RVA: 0xFEB1D0 Offset: 0xFE97D0 VA: 0x180FEB1D0
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0xFEB1F0 Offset: 0xFE97F0 VA: 0x180FEB1F0
	public static string PtrToStringUni(IntPtr ptr) { }

	// RVA: 0xFEB1E0 Offset: 0xFE97E0 VA: 0x180FEB1E0
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0xFEB200 Offset: 0xFE9800 VA: 0x180FEB200
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE08C0 Offset: 0xBDEEC0 VA: 0x180BE08C0
	|-Marshal.PtrToStructure<UnityTls.unitytls_interface_struct>
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0xBE0740 Offset: 0xBDED40 VA: 0x180BE0740
	|-Marshal.PtrToStructure<NetMsg>
	|
	|-RVA: 0xBE09A0 Offset: 0xBDEFA0 VA: 0x180BE09A0
	|-Marshal.PtrToStructure<Win32_FIXED_INFO>
	*/

	// RVA: 0xFEB210 Offset: 0xFE9810 VA: 0x180FEB210
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0xFEB230 Offset: 0xFE9830 VA: 0x180FEB230
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEB280 Offset: 0xFE9880 VA: 0x180FEB280
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEB2C0 Offset: 0xFE98C0 VA: 0x180FEB2C0
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEB360 Offset: 0xFE9960 VA: 0x180FEB360
	public static long ReadInt64(IntPtr ptr) { }

	// RVA: 0xFEB310 Offset: 0xFE9910 VA: 0x180FEB310
	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEB4D0 Offset: 0xFE9AD0 VA: 0x180FEB4D0
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEB3B0 Offset: 0xFE99B0 VA: 0x180FEB3B0
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEB5E0 Offset: 0xFE9BE0 VA: 0x180FEB5E0
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0xFEB5F0 Offset: 0xFE9BF0 VA: 0x180FEB5F0
	public static int Release(IntPtr pUnk) { }

	// RVA: 0xFEB9A0 Offset: 0xFE9FA0 VA: 0x180FEB9A0
	public static int SizeOf(Type t) { }

	// RVA: -1 Offset: -1
	public static int SizeOf<T>(T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7160 Offset: 0xED5760 VA: 0x180ED7160
	|-Marshal.SizeOf<Os.SECURITY_ATTRIBUTES>
	|
	|-RVA: 0xED70F0 Offset: 0xED56F0 VA: 0x180ED70F0
	|-Marshal.SizeOf<object>
	*/

	// RVA: 0xFEB9B0 Offset: 0xFE9FB0 VA: 0x180FEB9B0
	public static IntPtr StringToHGlobalAnsi(string s) { }

	// RVA: 0xFEB690 Offset: 0xFE9C90 VA: 0x180FEB690
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	// RVA: 0xFEB910 Offset: 0xFE9F10 VA: 0x180FEB910
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisibleAttribute] // RVA: 0xE0D30 Offset: 0xE0130 VA: 0x1800E0D30
	[ReliabilityContractAttribute] // RVA: 0xE0D30 Offset: 0xE0130 VA: 0x1800E0D30
	// RVA: 0xFEB9C0 Offset: 0xFE9FC0 VA: 0x180FEB9C0
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09650 Offset: 0xF07C50 VA: 0x180F09650
	|-Marshal.StructureToPtr<object>
	*/

	// RVA: 0xFEB9D0 Offset: 0xFE9FD0 VA: 0x180FEB9D0
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7220 Offset: 0xED5820 VA: 0x180ED7220
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0xED7280 Offset: 0xED5880 VA: 0x180ED7280
	|-Marshal.UnsafeAddrOfPinnedArrayElement<object>
	*/

	// RVA: 0xFEB9E0 Offset: 0xFE9FE0 VA: 0x180FEB9E0
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0xFEB1A0 Offset: 0xFE97A0 VA: 0x180FEB1A0
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7030 Offset: 0xED5630 VA: 0x180ED7030
	|-Marshal.GetFunctionPointerForDelegate<BufferManager.FreeFn>
	|-Marshal.GetFunctionPointerForDelegate<object>
	|-Marshal.GetFunctionPointerForDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>
	*/

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void SetLastWin32Error(int error) { }

	// RVA: 0xFEBB90 Offset: 0xFEA190 VA: 0x180FEBB90
	private static void .cctor() { }

}

