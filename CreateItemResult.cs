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

	// RVA: 0x1E5670 Offset: 0x1E4A70 VA: 0x1801E5670 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5660 Offset: 0x1E4A60 VA: 0x1801E5660 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E8C0 Offset: 0x136CEC0 VA: 0x18136E8C0
	private static void .cctor() { }

}

