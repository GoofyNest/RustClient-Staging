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

	// RVA: 0x16436F0 Offset: 0x1641CF0 VA: 0x1816436F0
	private static void .cctor() { }

	// RVA: 0x1643980 Offset: 0x1641F80 VA: 0x181643980
	private void .ctor(RegistryKey rkey, string basedir) { }

	// RVA: 0x16437F0 Offset: 0x1641DF0 VA: 0x1816437F0
	private void .ctor(RegistryKey rkey, string basedir, bool is_volatile) { }

	// RVA: 0x1641CA0 Offset: 0x16402A0 VA: 0x181641CA0
	public void Load() { }

	// RVA: 0x16417E0 Offset: 0x163FDE0 VA: 0x1816417E0
	private void LoadKey(SecurityElement se) { }

	// RVA: 0x1640540 Offset: 0x163EB40 VA: 0x181640540
	public RegistryKey Ensure(RegistryKey rkey, string extra, bool writable, bool is_volatile) { }

	// RVA: 0x16425F0 Offset: 0x1640BF0 VA: 0x1816425F0
	public RegistryKey Probe(RegistryKey rkey, string extra, bool writable) { }

	// RVA: 0x1640070 Offset: 0x163E670 VA: 0x181640070
	private static string CombineName(RegistryKey rkey, string extra) { }

	// RVA: 0x1641250 Offset: 0x163F850 VA: 0x181641250
	private static long GetSystemBootTime() { }

	// RVA: 0x1640A50 Offset: 0x163F050 VA: 0x181640A50
	private static long GetRegisteredBootTime(string path) { }

	// RVA: 0x1642AB0 Offset: 0x16410B0 VA: 0x181642AB0
	private static void SaveRegisteredBootTime(string path, long btime) { }

	// RVA: 0x163FE00 Offset: 0x163E400 VA: 0x18163FE00
	private static void CleanVolatileKeys() { }

	// RVA: 0x16434B0 Offset: 0x1641AB0 VA: 0x1816434B0
	public static bool VolatileKeyExists(string dir) { }

	// RVA: 0x1641610 Offset: 0x163FC10 VA: 0x181641610
	public static string GetVolatileDir(string dir) { }

	// RVA: 0x16420A0 Offset: 0x16406A0 VA: 0x1816420A0
	public static KeyHandler Lookup(RegistryKey rkey, bool createNonExisting) { }

	// RVA: 0x1640C30 Offset: 0x163F230 VA: 0x181640C30
	private static string GetRootFromDir(string dir) { }

	// RVA: 0x1640100 Offset: 0x163E700 VA: 0x181640100
	public static void Drop(RegistryKey rkey) { }

	// RVA: 0x1641450 Offset: 0x163FA50 VA: 0x181641450
	public object GetValue(string name, RegistryValueOptions options) { }

	// RVA: 0x1640D70 Offset: 0x163F370 VA: 0x181640D70
	public string[] GetSubKeyNames() { }

	// RVA: 0x1640940 Offset: 0x163EF40 VA: 0x181640940
	public void Flush() { }

	// RVA: 0x1643390 Offset: 0x1641990 VA: 0x181643390
	public bool ValueExists(string name) { }

	// RVA: 0x16439A0 Offset: 0x1641FA0 VA: 0x1816439A0
	public bool get_IsMarkedForDeletion() { }

	// RVA: 0x16408B0 Offset: 0x163EEB0 VA: 0x1816408B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1642BD0 Offset: 0x16411D0 VA: 0x181642BD0
	private void Save() { }

	// RVA: 0x1643BF0 Offset: 0x16421F0 VA: 0x181643BF0
	private static string get_UserStore() { }

	// RVA: 0x1643A30 Offset: 0x1642030 VA: 0x181643A30
	private static string get_MachineStore() { }

}

