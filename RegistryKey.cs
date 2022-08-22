public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 103
{	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[MonoTODOAttribute] // RVA: 0xE7D10 Offset: 0xE7110 VA: 0x1800E7D10
	[ComVisibleAttribute] // RVA: 0xE7D10 Offset: 0xE7110 VA: 0x1800E7D10
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x1649950 Offset: 0x1647F50 VA: 0x181649950
	private static void .cctor() { }

	// RVA: 0x1649C90 Offset: 0x1648290 VA: 0x181649C90
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1649AB0 Offset: 0x16480B0 VA: 0x181649AB0
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1649A50 Offset: 0x1648050 VA: 0x181649A50
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x1649590 Offset: 0x1647B90 VA: 0x181649590
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x1648E30 Offset: 0x1647430 VA: 0x181648E30 Slot: 6
	public void Dispose() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Name() { }

	// RVA: 0x1648F90 Offset: 0x1647590 VA: 0x181648F90
	public void Flush() { }

	// RVA: 0x1648C10 Offset: 0x1647210 VA: 0x181648C10
	public void Close() { }

	// RVA: 0x1649E80 Offset: 0x1648480 VA: 0x181649E80
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x1649610 Offset: 0x1647C10 VA: 0x181649610
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x1649620 Offset: 0x1647C20 VA: 0x181649620
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x1649420 Offset: 0x1647A20 VA: 0x181649420
	public object GetValue(string name) { }

	// RVA: 0x16492A0 Offset: 0x16478A0 VA: 0x1816492A0
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x1649160 Offset: 0x1647760 VA: 0x181649160
	public string[] GetSubKeyNames() { }

	// RVA: 0x1649810 Offset: 0x1647E10 VA: 0x181649810 Slot: 3
	public override string ToString() { }

	// RVA: 0x117C270 Offset: 0x117A870 VA: 0x18117C270
	internal bool get_IsRoot() { }

	// RVA: 0x164A030 Offset: 0x1648630 VA: 0x18164A030
	internal RegistryHive get_Hive() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal object get_InternalHandle() { }

	// RVA: 0x1648BA0 Offset: 0x16471A0 VA: 0x181648BA0
	private void AssertKeyStillValid() { }

	// RVA: 0x1648B30 Offset: 0x1647130 VA: 0x181648B30
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x1648D90 Offset: 0x1647390 VA: 0x181648D90
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x1648D30 Offset: 0x1647330 VA: 0x181648D30
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x1649010 Offset: 0x1647610 VA: 0x181649010
	private static string GetHiveName(RegistryHive hive) { }

}

