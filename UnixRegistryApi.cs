internal class UnixRegistryApi : IRegistryApi // TypeDefIndex: 109
{	// Methods

	// RVA: 0x1652390 Offset: 0x1650990 VA: 0x181652390
	private static string ToUnix(string keyname) { }

	// RVA: 0x1651F00 Offset: 0x1650500 VA: 0x181651F00
	private static bool IsWellKnownKey(string parentKeyName, string keyname) { }

	// RVA: 0x1652030 Offset: 0x1650630 VA: 0x181652030 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x1651D20 Offset: 0x1650320 VA: 0x181651D20 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x1651990 Offset: 0x164FF90 VA: 0x181651990 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x1651E50 Offset: 0x1650450 VA: 0x181651E50 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	// RVA: 0x1651DE0 Offset: 0x16503E0 VA: 0x181651DE0 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x13F4950 Offset: 0x13F2F50 VA: 0x1813F4950 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x1651B90 Offset: 0x1650190 VA: 0x181651B90
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x16519F0 Offset: 0x164FFF0 VA: 0x1816519F0
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable, bool is_volatile) { }

	// RVA: 0x1651D90 Offset: 0x1650390 VA: 0x181651D90 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

