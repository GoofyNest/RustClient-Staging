internal struct GameConnectedClanChatMsg_t : ICallbackData // TypeDefIndex: 5315
{	internal ulong SteamIDClanChat; // 0x0
	internal ulong SteamIDUser; // 0x8
	internal int MessageID; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

