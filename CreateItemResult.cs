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

	// RVA: 0x1E52D0 Offset: 0x1E46D0 VA: 0x1801E52D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E52C0 Offset: 0x1E46C0 VA: 0x1801E52C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136F500 Offset: 0x136DB00 VA: 0x18136F500
	private static void .cctor() { }

}

