internal class UnityLogWriter : TextWriter // TypeDefIndex: 3459
{	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2180BA0 Offset: 0x217F1A0 VA: 0x182180BA0
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunctionAttribute] // RVA: 0x85580 Offset: 0x84980 VA: 0x180085580
	// RVA: 0x2180B60 Offset: 0x217F160 VA: 0x182180B60
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x2180AC0 Offset: 0x217F0C0 VA: 0x182180AC0
	public static void Init() { }

	// RVA: 0x2180D20 Offset: 0x217F320 VA: 0x182180D20 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x2180BE0 Offset: 0x217F1E0 VA: 0x182180BE0 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x2180C80 Offset: 0x217F280 VA: 0x182180C80 Slot: 15
	public override void Write(string s) { }

	// RVA: 0x2180C30 Offset: 0x217F230 VA: 0x182180C30 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x2180CC0 Offset: 0x217F2C0 VA: 0x182180CC0
	public void .ctor() { }

}

