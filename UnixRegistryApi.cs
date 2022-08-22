internal class UnixRegistryApi : IRegistryApi // TypeDefIndex: 109
{	// Methods

	// RVA: 0x1652650 Offset: 0x1650C50 VA: 0x181652650
	private static string ToUnix(string keyname) { }

	// RVA: 0x16521C0 Offset: 0x16507C0 VA: 0x1816521C0
	private static bool IsWellKnownKey(string parentKeyName, string keyname) { }

	// RVA: 0x16522F0 Offset: 0x16508F0 VA: 0x1816522F0 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x1651FE0 Offset: 0x16505E0 VA: 0x181651FE0 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x1651C50 Offset: 0x1650250 VA: 0x181651C50 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x1652110 Offset: 0x1650710 VA: 0x181652110 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	// RVA: 0x16520A0 Offset: 0x16506A0 VA: 0x1816520A0 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x13F4C10 Offset: 0x13F3210 VA: 0x1813F4C10 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x1651E50 Offset: 0x1650450 VA: 0x181651E50
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x1651CB0 Offset: 0x16502B0 VA: 0x181651CB0
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable, bool is_volatile) { }

	// RVA: 0x1652050 Offset: 0x1650650 VA: 0x181652050 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

