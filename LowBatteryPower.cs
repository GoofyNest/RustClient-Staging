internal struct LowBatteryPower_t : ICallbackData // TypeDefIndex: 5328
{	// Fields
	internal byte MinutesBatteryLeft; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB7C0 Offset: 0x1EABC0 VA: 0x1801EB7C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB7B0 Offset: 0x1EABB0 VA: 0x1801EB7B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1374040 Offset: 0x1372640 VA: 0x181374040
	private static void .cctor() { }

}

