internal struct LowBatteryPower_t : ICallbackData // TypeDefIndex: 5334
{
	internal byte MinutesBatteryLeft; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

