internal struct GetAuthSessionTicketResponse_t : ICallbackData // TypeDefIndex: 5302
{	// Fields
	internal uint AuthTicket; // 0x0
	internal Result Result; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9190 Offset: 0x1E8590 VA: 0x1801E9190 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9180 Offset: 0x1E8580 VA: 0x1801E9180 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371790 Offset: 0x136FD90 VA: 0x181371790
	private static void .cctor() { }

}
