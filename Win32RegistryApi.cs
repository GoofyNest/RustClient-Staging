internal class Win32RegistryApi : IRegistryApi // TypeDefIndex: 110
{	// Fields
	private readonly int NativeBytesPerCharacter; // 0x10

	// Methods

	// RVA: 0x16538E0 Offset: 0x1651EE0 VA: 0x1816538E0
	private static extern int RegCloseKey(IntPtr keyHandle) { }

	// RVA: 0x1653A90 Offset: 0x1652090 VA: 0x181653A90
	private static extern int RegFlushKey(IntPtr keyHandle) { }

	// RVA: 0x1653B10 Offset: 0x1652110 VA: 0x181653B10
	private static extern int RegOpenKeyEx(IntPtr keyBase, string keyName, IntPtr reserved, int access, out IntPtr keyHandle) { }

	// RVA: 0x1653960 Offset: 0x1651F60 VA: 0x181653960
	internal static extern int RegEnumKeyEx(IntPtr keyHandle, int dwIndex, char* lpName, ref int lpcbName, int[] lpReserved, [Out] StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime) { }

	// RVA: 0x1654040 Offset: 0x1652640 VA: 0x181654040
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, IntPtr zero, ref int dataSize) { }

	// RVA: 0x1653D60 Offset: 0x1652360 VA: 0x181653D60
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, [Out] byte[] data, ref int dataSize) { }

	// RVA: 0x1653EA0 Offset: 0x16524A0 VA: 0x181653EA0
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref int data, ref int dataSize) { }

	// RVA: 0x1653F70 Offset: 0x1652570 VA: 0x181653F70
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref long data, ref int dataSize) { }

	// RVA: 0x1653BD0 Offset: 0x16521D0 VA: 0x181653BD0
	internal static extern int RegQueryInfoKey(IntPtr hKey, [Out] StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime) { }

	// RVA: 0x1652D90 Offset: 0x1651390 VA: 0x181652D90 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x16536B0 Offset: 0x1651CB0 VA: 0x1816536B0
	private static bool IsHandleValid(RegistryKey key) { }

	// RVA: 0x16531C0 Offset: 0x16517C0 VA: 0x1816531C0 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object defaultValue, RegistryValueOptions options) { }

	// RVA: 0x1652BA0 Offset: 0x16511A0 VA: 0x181652BA0
	private int GetBinaryValue(RegistryKey rkey, string name, RegistryValueKind type, out byte[] data, int size) { }

	// RVA: 0x1654110 Offset: 0x1652710 VA: 0x181654110 Slot: 11
	public int SubKeyCount(RegistryKey rkey) { }

	// RVA: 0x16536D0 Offset: 0x1651CD0 VA: 0x1816536D0 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyName, bool writable) { }

	// RVA: 0x1652900 Offset: 0x1650F00 VA: 0x181652900 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x1652790 Offset: 0x1650D90 VA: 0x181652790 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x1652E00 Offset: 0x1651400 VA: 0x181652E00 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x16529F0 Offset: 0x1650FF0 VA: 0x1816529F0
	private void GenerateException(int errorCode) { }

	// RVA: 0x13F4C10 Offset: 0x13F3210 VA: 0x1813F4C10 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x16528A0 Offset: 0x1650EA0 VA: 0x1816528A0
	internal static string CombineName(RegistryKey rkey, string localName) { }

	// RVA: 0x16542C0 Offset: 0x16528C0 VA: 0x1816542C0
	public void .ctor() { }

}

