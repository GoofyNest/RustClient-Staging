internal class UnixRegistryApi : IRegistryApi // TypeDefIndex: 109
{	// Methods

	// RVA: 0x163F970 Offset: 0x163DF70 VA: 0x18163F970
	private static string ToUnix(string keyname) { }

	// RVA: 0x163F4E0 Offset: 0x163DAE0 VA: 0x18163F4E0
	private static bool IsWellKnownKey(string parentKeyName, string keyname) { }

	// RVA: 0x163F610 Offset: 0x163DC10 VA: 0x18163F610 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x163F300 Offset: 0x163D900 VA: 0x18163F300 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x163EF70 Offset: 0x163D570 VA: 0x18163EF70 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x163F430 Offset: 0x163DA30 VA: 0x18163F430 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	// RVA: 0x163F3C0 Offset: 0x163D9C0 VA: 0x18163F3C0 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x13F3CF0 Offset: 0x13F22F0 VA: 0x1813F3CF0 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x163F170 Offset: 0x163D770 VA: 0x18163F170
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x163EFD0 Offset: 0x163D5D0 VA: 0x18163EFD0
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable, bool is_volatile) { }

	// RVA: 0x163F370 Offset: 0x163D970 VA: 0x18163F370 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

