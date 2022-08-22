internal struct LowBatteryPower_t : ICallbackData // TypeDefIndex: 5328
{	// Fields
	internal byte MinutesBatteryLeft; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EBBE0 Offset: 0x1EAFE0 VA: 0x1801EBBE0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EBBD0 Offset: 0x1EAFD0 VA: 0x1801EBBD0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373140 Offset: 0x1371740 VA: 0x181373140
	private static void .cctor() { }

}

