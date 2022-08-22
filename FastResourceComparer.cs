internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 481
{	// Fields
	internal static readonly FastResourceComparer Default; // 0x13D90

	// Methods

	// RVA: 0xFE6E80 Offset: 0xFE5480 VA: 0x180FE6E80 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0xFE6DE0 Offset: 0xFE53E0 VA: 0x180FE6DE0 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0xFE6F40 Offset: 0xFE5540 VA: 0x180FE6F40
	internal static int HashFunction(string key) { }

	// RVA: 0xFE6C60 Offset: 0xFE5260 VA: 0x180FE6C60 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0xFE6D00 Offset: 0xFE5300 VA: 0x180FE6D00 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0xFE6DC0 Offset: 0xFE53C0 VA: 0x180FE6DC0 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0xFE6D20 Offset: 0xFE5320 VA: 0x180FE6D20 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0xFE69C0 Offset: 0xFE4FC0 VA: 0x180FE69C0
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0xFE6B50 Offset: 0xFE5150 VA: 0x180FE6B50
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0xFE6AA0 Offset: 0xFE50A0 VA: 0x180FE6AA0
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFE6FA0 Offset: 0xFE55A0 VA: 0x180FE6FA0
	private static void .cctor() { }

}

