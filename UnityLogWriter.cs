internal class UnityLogWriter : TextWriter // TypeDefIndex: 3459
{	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2180CA0 Offset: 0x217F2A0 VA: 0x182180CA0
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x2180C60 Offset: 0x217F260 VA: 0x182180C60
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x2180BC0 Offset: 0x217F1C0 VA: 0x182180BC0
	public static void Init() { }

	// RVA: 0x2180E20 Offset: 0x217F420 VA: 0x182180E20 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x2180CE0 Offset: 0x217F2E0 VA: 0x182180CE0 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x2180D80 Offset: 0x217F380 VA: 0x182180D80 Slot: 15
	public override void Write(string s) { }

	// RVA: 0x2180D30 Offset: 0x217F330 VA: 0x182180D30 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2180DC0 Offset: 0x217F3C0 VA: 0x182180DC0
	public void .ctor() { }

}

