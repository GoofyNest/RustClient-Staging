internal struct PersonaStateChange_t : ICallbackData // TypeDefIndex: 5307
{	// Fields
	internal ulong SteamID; // 0x0
	internal int ChangeFlags; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EC580 Offset: 0x1EB980 VA: 0x1801EC580 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EC570 Offset: 0x1EB970 VA: 0x1801EC570 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13758E0 Offset: 0x1373EE0 VA: 0x1813758E0
	private static void .cctor() { }

}

