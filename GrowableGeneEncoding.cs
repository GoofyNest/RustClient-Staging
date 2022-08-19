public static class GrowableGeneEncoding // TypeDefIndex: 9542
{	// Methods

	// RVA: 0x7308C0 Offset: 0x72EEC0 VA: 0x1807308C0
	public static void EncodeGenesToItem(GrowableEntity sourceGrowable, Item targetItem) { }

	// RVA: 0x730840 Offset: 0x72EE40 VA: 0x180730840
	public static void EncodeGenesToItem(int genes, Item targetItem) { }

	// RVA: 0x7307B0 Offset: 0x72EDB0 VA: 0x1807307B0
	public static int EncodeGenesToInt(GrowableGenes genes) { }

	// RVA: 0x730A20 Offset: 0x72F020 VA: 0x180730A20
	public static int EncodePreviousGenesToInt(GrowableGenes genes) { }

	// RVA: 0x7306C0 Offset: 0x72ECC0 VA: 0x1807306C0
	public static void DecodeIntToGenes(int data, GrowableGenes genes) { }

	// RVA: 0x730740 Offset: 0x72ED40 VA: 0x180730740
	public static void DecodeIntToPreviousGenes(int data, GrowableGenes genes) { }

	// RVA: 0x730520 Offset: 0x72EB20 VA: 0x180730520
	public static string DecodeIntToGeneString(int data) { }

	// RVA: 0x730AD0 Offset: 0x72F0D0 VA: 0x180730AD0
	private static int Set(int storage, int slot, int value) { }

	// RVA: 0x730AB0 Offset: 0x72F0B0 VA: 0x180730AB0
	private static int Get(int storage, int slot) { }

}

