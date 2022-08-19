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

	// RVA: 0x1749740 Offset: 0x1747D40 VA: 0x181749740
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1749870 Offset: 0x1747E70 VA: 0x181749870
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x1749B10 Offset: 0x1748110 VA: 0x181749B10
	public string get_Filename() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_KeyValue() { }

	// RVA: 0x174A760 Offset: 0x1748D60 VA: 0x18174A760
	public void set_KeyValue(string value) { }

	// RVA: 0x1748FC0 Offset: 0x17475C0 VA: 0x181748FC0
	public bool Load() { }

	// RVA: 0x1749350 Offset: 0x1747950 VA: 0x181749350
	public void Save() { }

	// RVA: 0x1749330 Offset: 0x1747930 VA: 0x181749330
	public void Remove() { }

	// RVA: 0x174A230 Offset: 0x1748830 VA: 0x18174A230
	private static string get_UserPath() { }

	// RVA: 0x1749CC0 Offset: 0x17482C0 VA: 0x181749CC0
	private static string get_MachinePath() { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700
	internal static bool _CanSecure(string root) { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700
	internal static bool _ProtectUser(string path) { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700
	internal static bool _ProtectMachine(string path) { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700
	internal static bool _IsUserProtected(string path) { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700
	internal static bool _IsMachineProtected(string path) { }

	// RVA: 0x1748C20 Offset: 0x1747220 VA: 0x181748C20
	private static bool CanSecure(string path) { }

	// RVA: 0x17492A0 Offset: 0x17478A0 VA: 0x1817492A0
	private static bool ProtectUser(string path) { }

	// RVA: 0x1749210 Offset: 0x1747810 VA: 0x181749210
	private static bool ProtectMachine(string path) { }

	// RVA: 0x1748F30 Offset: 0x1747530 VA: 0x181748F30
	private static bool IsUserProtected(string path) { }

	// RVA: 0x1748EA0 Offset: 0x17474A0 VA: 0x181748EA0
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x17499A0 Offset: 0x1747FA0 VA: 0x1817499A0
	private bool get_CanChange() { }

	// RVA: 0x174A1F0 Offset: 0x17487F0 VA: 0x18174A1F0
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x174A210 Offset: 0x1748810 VA: 0x18174A210
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x17499B0 Offset: 0x1747FB0 VA: 0x1817499B0
	private string get_ContainerName() { }

	// RVA: 0x1748CD0 Offset: 0x17472D0 VA: 0x181748CD0
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x1748D80 Offset: 0x1747380 VA: 0x181748D80
	private void FromXml(string xml) { }

	// RVA: 0x1749530 Offset: 0x1747B30 VA: 0x181749530
	private string ToXml() { }

	// RVA: 0x17496E0 Offset: 0x1747CE0 VA: 0x1817496E0
	private static void .cctor() { }

}

