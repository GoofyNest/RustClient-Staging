internal class KeyPairPersistence // TypeDefIndex: 65
{	// Fields
	private static bool _userPathExists; // 0x0
	private static string _userPath; // 0x8
	private static bool _machinePathExists; // 0x10
	private static string _machinePath; // 0x18
	private CspParameters _params; // 0x10
	private string _keyvalue; // 0x18
	private string _filename; // 0x20
	private string _container; // 0x28
	private static object lockobj; // 0x20

	// Properties
	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }

	// Methods

	// RVA: 0x1749A00 Offset: 0x1748000 VA: 0x181749A00
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1749B30 Offset: 0x1748130 VA: 0x181749B30
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x1749DD0 Offset: 0x17483D0 VA: 0x181749DD0
	public string get_Filename() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_KeyValue() { }

	// RVA: 0x174AA20 Offset: 0x1749020 VA: 0x18174AA20
	public void set_KeyValue(string value) { }

	// RVA: 0x1749280 Offset: 0x1747880 VA: 0x181749280
	public bool Load() { }

	// RVA: 0x1749610 Offset: 0x1747C10 VA: 0x181749610
	public void Save() { }

	// RVA: 0x17495F0 Offset: 0x1747BF0 VA: 0x1817495F0
	public void Remove() { }

	// RVA: 0x174A4F0 Offset: 0x1748AF0 VA: 0x18174A4F0
	private static string get_UserPath() { }

	// RVA: 0x1749F80 Offset: 0x1748580 VA: 0x181749F80
	private static string get_MachinePath() { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0
	internal static bool _CanSecure(string root) { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0
	internal static bool _ProtectUser(string path) { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0
	internal static bool _ProtectMachine(string path) { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0
	internal static bool _IsUserProtected(string path) { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0
	internal static bool _IsMachineProtected(string path) { }

	// RVA: 0x1748EE0 Offset: 0x17474E0 VA: 0x181748EE0
	private static bool CanSecure(string path) { }

	// RVA: 0x1749560 Offset: 0x1747B60 VA: 0x181749560
	private static bool ProtectUser(string path) { }

	// RVA: 0x17494D0 Offset: 0x1747AD0 VA: 0x1817494D0
	private static bool ProtectMachine(string path) { }

	// RVA: 0x17491F0 Offset: 0x17477F0 VA: 0x1817491F0
	private static bool IsUserProtected(string path) { }

	// RVA: 0x1749160 Offset: 0x1747760 VA: 0x181749160
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x1749C60 Offset: 0x1748260 VA: 0x181749C60
	private bool get_CanChange() { }

	// RVA: 0x174A4B0 Offset: 0x1748AB0 VA: 0x18174A4B0
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x174A4D0 Offset: 0x1748AD0 VA: 0x18174A4D0
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x1749C70 Offset: 0x1748270 VA: 0x181749C70
	private string get_ContainerName() { }

	// RVA: 0x1748F90 Offset: 0x1747590 VA: 0x181748F90
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x1749040 Offset: 0x1747640 VA: 0x181749040
	private void FromXml(string xml) { }

	// RVA: 0x17497F0 Offset: 0x1747DF0 VA: 0x1817497F0
	private string ToXml() { }

	// RVA: 0x17499A0 Offset: 0x1747FA0 VA: 0x1817499A0
	private static void .cctor() { }

}

