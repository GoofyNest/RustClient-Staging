public static class GrowableGeneEncoding // TypeDefIndex: 9542
{	// Methods

	// RVA: 0x730920 Offset: 0x72EF20 VA: 0x180730920
	public static void EncodeGenesToItem(GrowableEntity sourceGrowable, Item targetItem) { }

	// RVA: 0x7308A0 Offset: 0x72EEA0 VA: 0x1807308A0
	public static void EncodeGenesToItem(int genes, Item targetItem) { }

	// RVA: 0x730810 Offset: 0x72EE10 VA: 0x180730810
	public static int EncodeGenesToInt(GrowableGenes genes) { }

	// RVA: 0x730A80 Offset: 0x72F080 VA: 0x180730A80
	public static int EncodePreviousGenesToInt(GrowableGenes genes) { }

	// RVA: 0x730720 Offset: 0x72ED20 VA: 0x180730720
	public static void DecodeIntToGenes(int data, GrowableGenes genes) { }

	// RVA: 0x7307A0 Offset: 0x72EDA0 VA: 0x1807307A0
	public static void DecodeIntToPreviousGenes(int data, GrowableGenes genes) { }

	// RVA: 0x730580 Offset: 0x72EB80 VA: 0x180730580
	public static string DecodeIntToGeneString(int data) { }

	// RVA: 0x730B30 Offset: 0x72F130 VA: 0x180730B30
	private static int Set(int storage, int slot, int value) { }

	// RVA: 0x730B10 Offset: 0x72F110 VA: 0x180730B10
	private static int Get(int storage, int slot) { }

}

