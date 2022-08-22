internal class UnityLogWriter : TextWriter // TypeDefIndex: 3459
{	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21809E0 Offset: 0x217EFE0 VA: 0x1821809E0
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunctionAttribute] // RVA: 0x855F0 Offset: 0x849F0 VA: 0x1800855F0
	// RVA: 0x21809A0 Offset: 0x217EFA0 VA: 0x1821809A0
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x2180900 Offset: 0x217EF00 VA: 0x182180900
	public static void Init() { }

	// RVA: 0x2180B60 Offset: 0x217F160 VA: 0x182180B60 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x2180A20 Offset: 0x217F020 VA: 0x182180A20 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x2180AC0 Offset: 0x217F0C0 VA: 0x182180AC0 Slot: 15
	public override void Write(string s) { }

	// RVA: 0x2180A70 Offset: 0x217F070 VA: 0x182180A70 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2180B00 Offset: 0x217F100 VA: 0x182180B00
	public void .ctor() { }

}

