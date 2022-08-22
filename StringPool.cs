public class StringPool // TypeDefIndex: 10773
{	// Fields
	private static Dictionary<uint, string> toString; // 0x0
	private static Dictionary<string, uint> toNumber; // 0x8
	private static bool initialized; // 0x10
	public static uint closest; // 0x14

	// Methods

	// RVA: 0x79EA60 Offset: 0x79D060 VA: 0x18079EA60
	private static void Init() { }

	// RVA: 0x79E850 Offset: 0x79CE50 VA: 0x18079E850
	public static string Get(uint i) { }

	// RVA: 0x79E970 Offset: 0x79CF70 VA: 0x18079E970
	public static uint Get(string str) { }

	// RVA: 0x79E710 Offset: 0x79CD10 VA: 0x18079E710
	public static uint Add(string str) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

