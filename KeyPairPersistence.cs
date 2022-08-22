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

	// RVA: 0x17475C0 Offset: 0x1745BC0 VA: 0x1817475C0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x17476F0 Offset: 0x1745CF0 VA: 0x1817476F0
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x1747990 Offset: 0x1745F90 VA: 0x181747990
	public string get_Filename() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_KeyValue() { }

	// RVA: 0x17485E0 Offset: 0x1746BE0 VA: 0x1817485E0
	public void set_KeyValue(string value) { }

	// RVA: 0x1746E40 Offset: 0x1745440 VA: 0x181746E40
	public bool Load() { }

	// RVA: 0x17471D0 Offset: 0x17457D0 VA: 0x1817471D0
	public void Save() { }

	// RVA: 0x17471B0 Offset: 0x17457B0 VA: 0x1817471B0
	public void Remove() { }

	// RVA: 0x17480B0 Offset: 0x17466B0 VA: 0x1817480B0
	private static string get_UserPath() { }

	// RVA: 0x1747B40 Offset: 0x1746140 VA: 0x181747B40
	private static string get_MachinePath() { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470
	internal static bool _CanSecure(string root) { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470
	internal static bool _ProtectUser(string path) { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470
	internal static bool _ProtectMachine(string path) { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470
	internal static bool _IsUserProtected(string path) { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470
	internal static bool _IsMachineProtected(string path) { }

	// RVA: 0x1746AA0 Offset: 0x17450A0 VA: 0x181746AA0
	private static bool CanSecure(string path) { }

	// RVA: 0x1747120 Offset: 0x1745720 VA: 0x181747120
	private static bool ProtectUser(string path) { }

	// RVA: 0x1747090 Offset: 0x1745690 VA: 0x181747090
	private static bool ProtectMachine(string path) { }

	// RVA: 0x1746DB0 Offset: 0x17453B0 VA: 0x181746DB0
	private static bool IsUserProtected(string path) { }

	// RVA: 0x1746D20 Offset: 0x1745320 VA: 0x181746D20
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x1747820 Offset: 0x1745E20 VA: 0x181747820
	private bool get_CanChange() { }

	// RVA: 0x1748070 Offset: 0x1746670 VA: 0x181748070
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x1748090 Offset: 0x1746690 VA: 0x181748090
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x1747830 Offset: 0x1745E30 VA: 0x181747830
	private string get_ContainerName() { }

	// RVA: 0x1746B50 Offset: 0x1745150 VA: 0x181746B50
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x1746C00 Offset: 0x1745200 VA: 0x181746C00
	private void FromXml(string xml) { }

	// RVA: 0x17473B0 Offset: 0x17459B0 VA: 0x1817473B0
	private string ToXml() { }

	// RVA: 0x1747560 Offset: 0x1745B60 VA: 0x181747560
	private static void .cctor() { }

}

