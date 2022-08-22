internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 481
{	// Fields
	internal static readonly FastResourceComparer Default; // 0x2B10360

	// Methods

	// RVA: 0xFE7920 Offset: 0xFE5F20 VA: 0x180FE7920 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0xFE7880 Offset: 0xFE5E80 VA: 0x180FE7880 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0xFE79E0 Offset: 0xFE5FE0 VA: 0x180FE79E0
	internal static int HashFunction(string key) { }

	// RVA: 0xFE7700 Offset: 0xFE5D00 VA: 0x180FE7700 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0xFE77A0 Offset: 0xFE5DA0 VA: 0x180FE77A0 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0xFE7860 Offset: 0xFE5E60 VA: 0x180FE7860 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0xFE77C0 Offset: 0xFE5DC0 VA: 0x180FE77C0 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0xFE7460 Offset: 0xFE5A60 VA: 0x180FE7460
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0xFE75F0 Offset: 0xFE5BF0 VA: 0x180FE75F0
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0xFE7540 Offset: 0xFE5B40 VA: 0x180FE7540
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFE7A40 Offset: 0xFE6040 VA: 0x180FE7A40
	private static void .cctor() { }

}

