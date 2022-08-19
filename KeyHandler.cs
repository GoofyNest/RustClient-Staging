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

	// RVA: 0x1643430 Offset: 0x1641A30 VA: 0x181643430
	private static void .cctor() { }

	// RVA: 0x16436C0 Offset: 0x1641CC0 VA: 0x1816436C0
	private void .ctor(RegistryKey rkey, string basedir) { }

	// RVA: 0x1643530 Offset: 0x1641B30 VA: 0x181643530
	private void .ctor(RegistryKey rkey, string basedir, bool is_volatile) { }

	// RVA: 0x16419E0 Offset: 0x163FFE0 VA: 0x1816419E0
	public void Load() { }

	// RVA: 0x1641520 Offset: 0x163FB20 VA: 0x181641520
	private void LoadKey(SecurityElement se) { }

	// RVA: 0x1640280 Offset: 0x163E880 VA: 0x181640280
	public RegistryKey Ensure(RegistryKey rkey, string extra, bool writable, bool is_volatile) { }

	// RVA: 0x1642330 Offset: 0x1640930 VA: 0x181642330
	public RegistryKey Probe(RegistryKey rkey, string extra, bool writable) { }

	// RVA: 0x163FDB0 Offset: 0x163E3B0 VA: 0x18163FDB0
	private static string CombineName(RegistryKey rkey, string extra) { }

	// RVA: 0x1640F90 Offset: 0x163F590 VA: 0x181640F90
	private static long GetSystemBootTime() { }

	// RVA: 0x1640790 Offset: 0x163ED90 VA: 0x181640790
	private static long GetRegisteredBootTime(string path) { }

	// RVA: 0x16427F0 Offset: 0x1640DF0 VA: 0x1816427F0
	private static void SaveRegisteredBootTime(string path, long btime) { }

	// RVA: 0x163FB40 Offset: 0x163E140 VA: 0x18163FB40
	private static void CleanVolatileKeys() { }

	// RVA: 0x16431F0 Offset: 0x16417F0 VA: 0x1816431F0
	public static bool VolatileKeyExists(string dir) { }

	// RVA: 0x1641350 Offset: 0x163F950 VA: 0x181641350
	public static string GetVolatileDir(string dir) { }

	// RVA: 0x1641DE0 Offset: 0x16403E0 VA: 0x181641DE0
	public static KeyHandler Lookup(RegistryKey rkey, bool createNonExisting) { }

	// RVA: 0x1640970 Offset: 0x163EF70 VA: 0x181640970
	private static string GetRootFromDir(string dir) { }

	// RVA: 0x163FE40 Offset: 0x163E440 VA: 0x18163FE40
	public static void Drop(RegistryKey rkey) { }

	// RVA: 0x1641190 Offset: 0x163F790 VA: 0x181641190
	public object GetValue(string name, RegistryValueOptions options) { }

	// RVA: 0x1640AB0 Offset: 0x163F0B0 VA: 0x181640AB0
	public string[] GetSubKeyNames() { }

	// RVA: 0x1640680 Offset: 0x163EC80 VA: 0x181640680
	public void Flush() { }

	// RVA: 0x16430D0 Offset: 0x16416D0 VA: 0x1816430D0
	public bool ValueExists(string name) { }

	// RVA: 0x16436E0 Offset: 0x1641CE0 VA: 0x1816436E0
	public bool get_IsMarkedForDeletion() { }

	// RVA: 0x16405F0 Offset: 0x163EBF0 VA: 0x1816405F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1642910 Offset: 0x1640F10 VA: 0x181642910
	private void Save() { }

	// RVA: 0x1643930 Offset: 0x1641F30 VA: 0x181643930
	private static string get_UserStore() { }

	// RVA: 0x1643770 Offset: 0x1641D70 VA: 0x181643770
	private static string get_MachineStore() { }

}

