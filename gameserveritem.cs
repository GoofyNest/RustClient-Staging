internal struct gameserveritem_t // TypeDefIndex: 5504
{	// Fields
	internal servernetadr_t NetAdr; // 0x0
	internal int Ping; // 0x8
	internal bool HadSuccessfulResponse; // 0xC
	internal bool DoNotRefresh; // 0xD
	internal byte[] GameDir; // 0x10
	internal byte[] Map; // 0x18
	internal byte[] GameDescription; // 0x20
	internal uint AppID; // 0x28
	internal int Players; // 0x2C
	internal int MaxPlayers; // 0x30
	internal int BotPlayers; // 0x34
	internal bool Password; // 0x38
	internal bool Secure; // 0x39
	internal uint TimeLastPlayed; // 0x3C
	internal int ServerVersion; // 0x40
	internal byte[] ServerName; // 0x48
	internal byte[] GameTags; // 0x50
	internal ulong SteamID; // 0x58

	// Methods

	// RVA: 0x1DCAE0 Offset: 0x1DBEE0 VA: 0x1801DCAE0
	internal string GameDirUTF8() { }

	// RVA: 0x1DCB00 Offset: 0x1DBF00 VA: 0x1801DCB00
	internal string MapUTF8() { }

	// RVA: 0x1DCAD0 Offset: 0x1DBED0 VA: 0x1801DCAD0
	internal string GameDescriptionUTF8() { }

	// RVA: 0x1DCB10 Offset: 0x1DBF10 VA: 0x1801DCB10
	internal string ServerNameUTF8() { }

	// RVA: 0x1DCAF0 Offset: 0x1DBEF0 VA: 0x1801DCAF0
	internal string GameTagsUTF8() { }

}

