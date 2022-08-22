internal struct CreateItemResult_t : ICallbackData // TypeDefIndex: 5432
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E5250 Offset: 0x1E4650 VA: 0x1801E5250 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5240 Offset: 0x1E4640 VA: 0x1801E5240 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136F500 Offset: 0x136DB00 VA: 0x18136F500
	private static void .cctor() { }

}

