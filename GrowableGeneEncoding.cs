public static class GrowableGeneEncoding // TypeDefIndex: 9542
{	// Methods

	// RVA: 0x7309D0 Offset: 0x72EFD0 VA: 0x1807309D0
	public static void EncodeGenesToItem(GrowableEntity sourceGrowable, Item targetItem) { }

	// RVA: 0x730950 Offset: 0x72EF50 VA: 0x180730950
	public static void EncodeGenesToItem(int genes, Item targetItem) { }

	// RVA: 0x7308C0 Offset: 0x72EEC0 VA: 0x1807308C0
	public static int EncodeGenesToInt(GrowableGenes genes) { }

	// RVA: 0x730B30 Offset: 0x72F130 VA: 0x180730B30
	public static int EncodePreviousGenesToInt(GrowableGenes genes) { }

	// RVA: 0x7307D0 Offset: 0x72EDD0 VA: 0x1807307D0
	public static void DecodeIntToGenes(int data, GrowableGenes genes) { }

	// RVA: 0x730850 Offset: 0x72EE50 VA: 0x180730850
	public static void DecodeIntToPreviousGenes(int data, GrowableGenes genes) { }

	// RVA: 0x730630 Offset: 0x72EC30 VA: 0x180730630
	public static string DecodeIntToGeneString(int data) { }

	// RVA: 0x730BE0 Offset: 0x72F1E0 VA: 0x180730BE0
	private static int Set(int storage, int slot, int value) { }

	// RVA: 0x730BC0 Offset: 0x72F1C0 VA: 0x180730BC0
	private static int Get(int storage, int slot) { }

}

