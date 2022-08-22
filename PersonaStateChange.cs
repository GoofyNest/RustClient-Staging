internal struct PersonaStateChange_t : ICallbackData // TypeDefIndex: 5307
{	// Fields
	internal ulong SteamID; // 0x0
	internal int ChangeFlags; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EC9A0 Offset: 0x1EBDA0 VA: 0x1801EC9A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EC990 Offset: 0x1EBD90 VA: 0x1801EC990 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13749E0 Offset: 0x1372FE0 VA: 0x1813749E0
	private static void .cctor() { }

}

