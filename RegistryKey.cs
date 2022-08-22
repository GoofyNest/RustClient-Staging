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

	// RVA: 0x1636C70 Offset: 0x1635270 VA: 0x181636C70
	private static void .cctor() { }

	// RVA: 0x1636FB0 Offset: 0x16355B0 VA: 0x181636FB0
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x1636DD0 Offset: 0x16353D0 VA: 0x181636DD0
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x1636D70 Offset: 0x1635370 VA: 0x181636D70
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x16368B0 Offset: 0x1634EB0 VA: 0x1816368B0
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x1636150 Offset: 0x1634750 VA: 0x181636150 Slot: 6
	public void Dispose() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_Name() { }

	// RVA: 0x16362B0 Offset: 0x16348B0 VA: 0x1816362B0
	public void Flush() { }

	// RVA: 0x1635F30 Offset: 0x1634530 VA: 0x181635F30
	public void Close() { }

	// RVA: 0x16371A0 Offset: 0x16357A0 VA: 0x1816371A0
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x1636930 Offset: 0x1634F30 VA: 0x181636930
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x1636940 Offset: 0x1634F40 VA: 0x181636940
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x1636740 Offset: 0x1634D40 VA: 0x181636740
	public object GetValue(string name) { }

	// RVA: 0x16365C0 Offset: 0x1634BC0 VA: 0x1816365C0
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x1636480 Offset: 0x1634A80 VA: 0x181636480
	public string[] GetSubKeyNames() { }

	// RVA: 0x1636B30 Offset: 0x1635130 VA: 0x181636B30 Slot: 3
	public override string ToString() { }

	// RVA: 0x1180B90 Offset: 0x117F190 VA: 0x181180B90
	internal bool get_IsRoot() { }

	// RVA: 0x1637350 Offset: 0x1635950 VA: 0x181637350
	internal RegistryHive get_Hive() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal object get_InternalHandle() { }

	// RVA: 0x1635EC0 Offset: 0x16344C0 VA: 0x181635EC0
	private void AssertKeyStillValid() { }

	// RVA: 0x1635E50 Offset: 0x1634450 VA: 0x181635E50
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x16360B0 Offset: 0x16346B0 VA: 0x1816360B0
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x1636050 Offset: 0x1634650 VA: 0x181636050
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x1636330 Offset: 0x1634930 VA: 0x181636330
	private static string GetHiveName(RegistryHive hive) { }

}

