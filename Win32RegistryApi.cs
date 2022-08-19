internal class Win32RegistryApi : IRegistryApi // TypeDefIndex: 110
{	// Fields
	private readonly int NativeBytesPerCharacter; // 0x10

	// Methods

	// RVA: 0x1653620 Offset: 0x1651C20 VA: 0x181653620
	private static extern int RegCloseKey(IntPtr keyHandle) { }

	// RVA: 0x16537D0 Offset: 0x1651DD0 VA: 0x1816537D0
	private static extern int RegFlushKey(IntPtr keyHandle) { }

	// RVA: 0x1653850 Offset: 0x1651E50 VA: 0x181653850
	private static extern int RegOpenKeyEx(IntPtr keyBase, string keyName, IntPtr reserved, int access, out IntPtr keyHandle) { }

	// RVA: 0x16536A0 Offset: 0x1651CA0 VA: 0x1816536A0
	internal static extern int RegEnumKeyEx(IntPtr keyHandle, int dwIndex, char* lpName, ref int lpcbName, int[] lpReserved, [Out] StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime) { }

	// RVA: 0x1653D80 Offset: 0x1652380 VA: 0x181653D80
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, IntPtr zero, ref int dataSize) { }

	// RVA: 0x1653AA0 Offset: 0x16520A0 VA: 0x181653AA0
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, [Out] byte[] data, ref int dataSize) { }

	// RVA: 0x1653BE0 Offset: 0x16521E0 VA: 0x181653BE0
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref int data, ref int dataSize) { }

	// RVA: 0x1653CB0 Offset: 0x16522B0 VA: 0x181653CB0
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref long data, ref int dataSize) { }

	// RVA: 0x1653910 Offset: 0x1651F10 VA: 0x181653910
	internal static extern int RegQueryInfoKey(IntPtr hKey, [Out] StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime) { }

	// RVA: 0x1652AD0 Offset: 0x16510D0 VA: 0x181652AD0 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x16533F0 Offset: 0x16519F0 VA: 0x1816533F0
	private static bool IsHandleValid(RegistryKey key) { }

	// RVA: 0x1652F00 Offset: 0x1651500 VA: 0x181652F00 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object defaultValue, RegistryValueOptions options) { }

	// RVA: 0x16528E0 Offset: 0x1650EE0 VA: 0x1816528E0
	private int GetBinaryValue(RegistryKey rkey, string name, RegistryValueKind type, out byte[] data, int size) { }

	// RVA: 0x1653E50 Offset: 0x1652450 VA: 0x181653E50 Slot: 11
	public int SubKeyCount(RegistryKey rkey) { }

	// RVA: 0x1653410 Offset: 0x1651A10 VA: 0x181653410 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyName, bool writable) { }

	// RVA: 0x1652640 Offset: 0x1650C40 VA: 0x181652640 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x16524D0 Offset: 0x1650AD0 VA: 0x1816524D0 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x1652B40 Offset: 0x1651140 VA: 0x181652B40 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x1652730 Offset: 0x1650D30 VA: 0x181652730
	private void GenerateException(int errorCode) { }

	// RVA: 0x13F4950 Offset: 0x13F2F50 VA: 0x1813F4950 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x16525E0 Offset: 0x1650BE0 VA: 0x1816525E0
	internal static string CombineName(RegistryKey rkey, string localName) { }

	// RVA: 0x1654000 Offset: 0x1652600 VA: 0x181654000
	public void .ctor() { }

}

