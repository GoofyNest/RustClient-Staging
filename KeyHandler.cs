internal class KeyHandler // TypeDefIndex: 108
{	// Fields
	private static Hashtable key_to_handler; // 0x0
	private static Hashtable dir_to_handler; // 0x8
	public string Dir; // 0x10
	private string ActualDir; // 0x18
	public bool IsVolatile; // 0x20
	private Hashtable values; // 0x28
	private string file; // 0x30
	private bool dirty; // 0x38
	private static string user_store; // 0x10
	private static string machine_store; // 0x18

	// Properties
	public bool IsMarkedForDeletion { get; }
	private static string UserStore { get; }
	private static string MachineStore { get; }

	// Methods

	// RVA: 0x1630A10 Offset: 0x162F010 VA: 0x181630A10
	private static void .cctor() { }

	// RVA: 0x1630CA0 Offset: 0x162F2A0 VA: 0x181630CA0
	private void .ctor(RegistryKey rkey, string basedir) { }

	// RVA: 0x1630B10 Offset: 0x162F110 VA: 0x181630B10
	private void .ctor(RegistryKey rkey, string basedir, bool is_volatile) { }

	// RVA: 0x162EFC0 Offset: 0x162D5C0 VA: 0x18162EFC0
	public void Load() { }

	// RVA: 0x162EB00 Offset: 0x162D100 VA: 0x18162EB00
	private void LoadKey(SecurityElement se) { }

	// RVA: 0x162D860 Offset: 0x162BE60 VA: 0x18162D860
	public RegistryKey Ensure(RegistryKey rkey, string extra, bool writable, bool is_volatile) { }

	// RVA: 0x162F910 Offset: 0x162DF10 VA: 0x18162F910
	public RegistryKey Probe(RegistryKey rkey, string extra, bool writable) { }

	// RVA: 0x162D390 Offset: 0x162B990 VA: 0x18162D390
	private static string CombineName(RegistryKey rkey, string extra) { }

	// RVA: 0x162E570 Offset: 0x162CB70 VA: 0x18162E570
	private static long GetSystemBootTime() { }

	// RVA: 0x162DD70 Offset: 0x162C370 VA: 0x18162DD70
	private static long GetRegisteredBootTime(string path) { }

	// RVA: 0x162FDD0 Offset: 0x162E3D0 VA: 0x18162FDD0
	private static void SaveRegisteredBootTime(string path, long btime) { }

	// RVA: 0x162D120 Offset: 0x162B720 VA: 0x18162D120
	private static void CleanVolatileKeys() { }

	// RVA: 0x16307D0 Offset: 0x162EDD0 VA: 0x1816307D0
	public static bool VolatileKeyExists(string dir) { }

	// RVA: 0x162E930 Offset: 0x162CF30 VA: 0x18162E930
	public static string GetVolatileDir(string dir) { }

	// RVA: 0x162F3C0 Offset: 0x162D9C0 VA: 0x18162F3C0
	public static KeyHandler Lookup(RegistryKey rkey, bool createNonExisting) { }

	// RVA: 0x162DF50 Offset: 0x162C550 VA: 0x18162DF50
	private static string GetRootFromDir(string dir) { }

	// RVA: 0x162D420 Offset: 0x162BA20 VA: 0x18162D420
	public static void Drop(RegistryKey rkey) { }

	// RVA: 0x162E770 Offset: 0x162CD70 VA: 0x18162E770
	public object GetValue(string name, RegistryValueOptions options) { }

	// RVA: 0x162E090 Offset: 0x162C690 VA: 0x18162E090
	public string[] GetSubKeyNames() { }

	// RVA: 0x162DC60 Offset: 0x162C260 VA: 0x18162DC60
	public void Flush() { }

	// RVA: 0x16306B0 Offset: 0x162ECB0 VA: 0x1816306B0
	public bool ValueExists(string name) { }

	// RVA: 0x1630CC0 Offset: 0x162F2C0 VA: 0x181630CC0
	public bool get_IsMarkedForDeletion() { }

	// RVA: 0x162DBD0 Offset: 0x162C1D0 VA: 0x18162DBD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x162FEF0 Offset: 0x162E4F0 VA: 0x18162FEF0
	private void Save() { }

	// RVA: 0x1630F10 Offset: 0x162F510 VA: 0x181630F10
	private static string get_UserStore() { }

	// RVA: 0x1630D50 Offset: 0x162F350 VA: 0x181630D50
	private static string get_MachineStore() { }

}

