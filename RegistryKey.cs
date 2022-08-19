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

	// RVA: 0x1649690 Offset: 0x1647C90 VA: 0x181649690
	private static void .cctor() { }

	// RVA: 0x16499D0 Offset: 0x1647FD0 VA: 0x1816499D0
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x16497F0 Offset: 0x1647DF0 VA: 0x1816497F0
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1649790 Offset: 0x1647D90 VA: 0x181649790
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x16492D0 Offset: 0x16478D0 VA: 0x1816492D0
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x1648B70 Offset: 0x1647170 VA: 0x181648B70 Slot: 6
	public void Dispose() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_Name() { }

	// RVA: 0x1648CD0 Offset: 0x16472D0 VA: 0x181648CD0
	public void Flush() { }

	// RVA: 0x1648950 Offset: 0x1646F50 VA: 0x181648950
	public void Close() { }

	// RVA: 0x1649BC0 Offset: 0x16481C0 VA: 0x181649BC0
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x1649350 Offset: 0x1647950 VA: 0x181649350
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x1649360 Offset: 0x1647960 VA: 0x181649360
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x1649160 Offset: 0x1647760 VA: 0x181649160
	public object GetValue(string name) { }

	// RVA: 0x1648FE0 Offset: 0x16475E0 VA: 0x181648FE0
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x1648EA0 Offset: 0x16474A0 VA: 0x181648EA0
	public string[] GetSubKeyNames() { }

	// RVA: 0x1649550 Offset: 0x1647B50 VA: 0x181649550 Slot: 3
	public override string ToString() { }

	// RVA: 0x117BFB0 Offset: 0x117A5B0 VA: 0x18117BFB0
	internal bool get_IsRoot() { }

	// RVA: 0x1649D70 Offset: 0x1648370 VA: 0x181649D70
	internal RegistryHive get_Hive() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal object get_InternalHandle() { }

	// RVA: 0x16488E0 Offset: 0x1646EE0 VA: 0x1816488E0
	private void AssertKeyStillValid() { }

	// RVA: 0x1648870 Offset: 0x1646E70 VA: 0x181648870
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x1648AD0 Offset: 0x16470D0 VA: 0x181648AD0
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x1648A70 Offset: 0x1647070 VA: 0x181648A70
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x1648D50 Offset: 0x1647350 VA: 0x181648D50
	private static string GetHiveName(RegistryHive hive) { }

}

