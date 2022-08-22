public class StringPool // TypeDefIndex: 10773
{	// Fields
	private static Dictionary<uint, string> toString; // 0x0
	private static Dictionary<string, uint> toNumber; // 0x8
	private static bool initialized; // 0x10
	public static uint closest; // 0x14

	// Methods

	// RVA: 0x7BCE60 Offset: 0x7BB460 VA: 0x1807BCE60
	private static void Init() { }

	// RVA: 0x7BCC50 Offset: 0x7BB250 VA: 0x1807BCC50
	public static string Get(uint i) { }

	// RVA: 0x7BCD70 Offset: 0x7BB370 VA: 0x1807BCD70
	public static uint Get(string str) { }

	// RVA: 0x7BCB10 Offset: 0x7BB110 VA: 0x1807BCB10
	public static uint Add(string str) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

