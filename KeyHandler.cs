internal class KeyHandler // TypeDefIndex: 108
{
	private static Hashtable key_to_handler; 
	private static Hashtable dir_to_handler; 
	public string Dir; 
	private string ActualDir; 
	public bool IsVolatile; 
	private Hashtable values; 
	private string file; 
	private bool dirty; 
	private static string user_store; 
	private static string machine_store; 

	public bool IsMarkedForDeletion { get; }
	private static string UserStore { get; }
	private static string MachineStore { get; }


	private static void .cctor() { }

	private void .ctor(RegistryKey rkey, string basedir) { }

	private void .ctor(RegistryKey rkey, string basedir, bool is_volatile) { }

	public void Load() { }

	private void LoadKey(SecurityElement se) { }

	public RegistryKey Ensure(RegistryKey rkey, string extra, bool writable, bool is_volatile) { }

	public RegistryKey Probe(RegistryKey rkey, string extra, bool writable) { }

	private static string CombineName(RegistryKey rkey, string extra) { }

	private static long GetSystemBootTime() { }

	private static long GetRegisteredBootTime(string path) { }

	private static void SaveRegisteredBootTime(string path, long btime) { }

	private static void CleanVolatileKeys() { }

	public static bool VolatileKeyExists(string dir) { }

	public static string GetVolatileDir(string dir) { }

	public static KeyHandler Lookup(RegistryKey rkey, bool createNonExisting) { }

	private static string GetRootFromDir(string dir) { }

	public static void Drop(RegistryKey rkey) { }

	public object GetValue(string name, RegistryValueOptions options) { }

	public string[] GetSubKeyNames() { }

	public void Flush() { }

	public bool ValueExists(string name) { }

	public bool get_IsMarkedForDeletion() { }

	protected override void Finalize() { }

	private void Save() { }

	private static string get_UserStore() { }

	private static string get_MachineStore() { }

}

