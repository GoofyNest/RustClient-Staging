internal struct GameRichPresenceJoinRequested_t : ICallbackData // TypeDefIndex: 5318
{
	internal ulong SteamIDFriend; 
	internal byte[] Connect; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	internal string ConnectUTF8() { }

	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

