internal struct LobbyChatUpdate_t : ICallbackData // TypeDefIndex: 5347
{
	internal ulong SteamIDLobby;
	internal ulong SteamIDUserChanged;
	internal ulong SteamIDMakingChange;
	internal uint GfChatMemberStateChange;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

