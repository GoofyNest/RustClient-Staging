internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 481
{	// Fields
	internal static readonly FastResourceComparer Default; // 0x13D90

	// Methods

	// RVA: 0xFE6BC0 Offset: 0xFE51C0 VA: 0x180FE6BC0 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0xFE6B20 Offset: 0xFE5120 VA: 0x180FE6B20 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0xFE6C80 Offset: 0xFE5280 VA: 0x180FE6C80
	internal static int HashFunction(string key) { }

	// RVA: 0xFE69A0 Offset: 0xFE4FA0 VA: 0x180FE69A0 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0xFE6A40 Offset: 0xFE5040 VA: 0x180FE6A40 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0xFE6B00 Offset: 0xFE5100 VA: 0x180FE6B00 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0xFE6A60 Offset: 0xFE5060 VA: 0x180FE6A60 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0xFE6700 Offset: 0xFE4D00 VA: 0x180FE6700
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0xFE6890 Offset: 0xFE4E90 VA: 0x180FE6890
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0xFE67E0 Offset: 0xFE4DE0 VA: 0x180FE67E0
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFE6CE0 Offset: 0xFE52E0 VA: 0x180FE6CE0
	private static void .cctor() { }

}

