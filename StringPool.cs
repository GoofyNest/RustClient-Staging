public class StringPool // TypeDefIndex: 10773
{	// Fields
	private static Dictionary<uint, string> toString; // 0x0
	private static Dictionary<string, uint> toNumber; // 0x8
	private static bool initialized; // 0x10
	public static uint closest; // 0x14

	// Methods

	// RVA: 0x79E950 Offset: 0x79CF50 VA: 0x18079E950
	private static void Init() { }

	// RVA: 0x79E740 Offset: 0x79CD40 VA: 0x18079E740
	public static string Get(uint i) { }

	// RVA: 0x79E860 Offset: 0x79CE60 VA: 0x18079E860
	public static uint Get(string str) { }

	// RVA: 0x79E600 Offset: 0x79CC00 VA: 0x18079E600
	public static uint Add(string str) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

