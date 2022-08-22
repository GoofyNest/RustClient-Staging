internal class UnityLogWriter : TextWriter // TypeDefIndex: 3459
{	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21814C0 Offset: 0x217FAC0 VA: 0x1821814C0
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x2181480 Offset: 0x217FA80 VA: 0x182181480
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x21813E0 Offset: 0x217F9E0 VA: 0x1821813E0
	public static void Init() { }

	// RVA: 0x2181640 Offset: 0x217FC40 VA: 0x182181640 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x2181500 Offset: 0x217FB00 VA: 0x182181500 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x21815A0 Offset: 0x217FBA0 VA: 0x1821815A0 Slot: 15
	public override void Write(string s) { }

	// RVA: 0x2181550 Offset: 0x217FB50 VA: 0x182181550 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x21815E0 Offset: 0x217FBE0 VA: 0x1821815E0
	public void .ctor() { }

}

