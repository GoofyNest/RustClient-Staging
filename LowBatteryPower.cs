internal struct LowBatteryPower_t : ICallbackData // TypeDefIndex: 5328
{	// Fields
	internal byte MinutesBatteryLeft; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB840 Offset: 0x1EAC40 VA: 0x1801EB840 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB830 Offset: 0x1EAC30 VA: 0x1801EB830 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373D80 Offset: 0x1372380 VA: 0x181373D80
	private static void .cctor() { }

}
