internal class Win32RegistryApi : IRegistryApi // TypeDefIndex: 110
{	// Fields
	private readonly int NativeBytesPerCharacter; // 0x10

	// Methods

	// RVA: 0x1640C00 Offset: 0x163F200 VA: 0x181640C00
	private static extern int RegCloseKey(IntPtr keyHandle) { }

	// RVA: 0x1640DB0 Offset: 0x163F3B0 VA: 0x181640DB0
	private static extern int RegFlushKey(IntPtr keyHandle) { }

	// RVA: 0x1640E30 Offset: 0x163F430 VA: 0x181640E30
	private static extern int RegOpenKeyEx(IntPtr keyBase, string keyName, IntPtr reserved, int access, out IntPtr keyHandle) { }

	// RVA: 0x1640C80 Offset: 0x163F280 VA: 0x181640C80
	internal static extern int RegEnumKeyEx(IntPtr keyHandle, int dwIndex, char* lpName, ref int lpcbName, int[] lpReserved, [Out] StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime) { }

	// RVA: 0x1641360 Offset: 0x163F960 VA: 0x181641360
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, IntPtr zero, ref int dataSize) { }

	// RVA: 0x1641080 Offset: 0x163F680 VA: 0x181641080
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, [Out] byte[] data, ref int dataSize) { }

	// RVA: 0x16411C0 Offset: 0x163F7C0 VA: 0x1816411C0
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref int data, ref int dataSize) { }

	// RVA: 0x1641290 Offset: 0x163F890 VA: 0x181641290
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref long data, ref int dataSize) { }

	// RVA: 0x1640EF0 Offset: 0x163F4F0 VA: 0x181640EF0
	internal static extern int RegQueryInfoKey(IntPtr hKey, [Out] StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime) { }

	// RVA: 0x16400B0 Offset: 0x163E6B0 VA: 0x1816400B0 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x16409D0 Offset: 0x163EFD0 VA: 0x1816409D0
	private static bool IsHandleValid(RegistryKey key) { }

	// RVA: 0x16404E0 Offset: 0x163EAE0 VA: 0x1816404E0 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object defaultValue, RegistryValueOptions options) { }

	// RVA: 0x163FEC0 Offset: 0x163E4C0 VA: 0x18163FEC0
	private int GetBinaryValue(RegistryKey rkey, string name, RegistryValueKind type, out byte[] data, int size) { }

	// RVA: 0x1641430 Offset: 0x163FA30 VA: 0x181641430 Slot: 11
	public int SubKeyCount(RegistryKey rkey) { }

	// RVA: 0x16409F0 Offset: 0x163EFF0 VA: 0x1816409F0 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyName, bool writable) { }

	// RVA: 0x163FC20 Offset: 0x163E220 VA: 0x18163FC20 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x163FAB0 Offset: 0x163E0B0 VA: 0x18163FAB0 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x1640120 Offset: 0x163E720 VA: 0x181640120 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x163FD10 Offset: 0x163E310 VA: 0x18163FD10
	private void GenerateException(int errorCode) { }

	// RVA: 0x13F3CF0 Offset: 0x13F22F0 VA: 0x1813F3CF0 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x163FBC0 Offset: 0x163E1C0 VA: 0x18163FBC0
	internal static string CombineName(RegistryKey rkey, string localName) { }

	// RVA: 0x16415E0 Offset: 0x163FBE0 VA: 0x1816415E0
	public void .ctor() { }

}

