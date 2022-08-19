internal struct PersonaStateChange_t : ICallbackData // TypeDefIndex: 5307
{	// Fields
	internal ulong SteamID; // 0x0
	internal int ChangeFlags; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EC600 Offset: 0x1EBA00 VA: 0x1801EC600 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EC5F0 Offset: 0x1EB9F0 VA: 0x1801EC5F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1375620 Offset: 0x1373C20 VA: 0x181375620
	private static void .cctor() { }

}

