internal class HeaderInfoTable // TypeDefIndex: 2916
{	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x1338E10 Offset: 0x1337410 VA: 0x181338E10
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x1338C20 Offset: 0x1337220 VA: 0x181338C20
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x1338EC0 Offset: 0x13374C0 VA: 0x181338EC0
	private static void .cctor() { }

	// RVA: 0x133B460 Offset: 0x1339A60 VA: 0x18133B460
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

