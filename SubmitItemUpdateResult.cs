internal struct SubmitItemUpdateResult_t : ICallbackData // TypeDefIndex: 5433
{	// Fields
	internal Result Result; // 0x0
	internal bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x4
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DB060 Offset: 0x1DA460 VA: 0x1801DB060 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DB050 Offset: 0x1DA450 VA: 0x1801DB050 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291330 Offset: 0x128F930 VA: 0x181291330
	private static void .cctor() { }

}

