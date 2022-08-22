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

	// RVA: 0x1DCA60 Offset: 0x1DBE60 VA: 0x1801DCA60
	internal string GameDirUTF8() { }

	// RVA: 0x1DCA80 Offset: 0x1DBE80 VA: 0x1801DCA80
	internal string MapUTF8() { }

	// RVA: 0x1DCA50 Offset: 0x1DBE50 VA: 0x1801DCA50
	internal string GameDescriptionUTF8() { }

	// RVA: 0x1DCA90 Offset: 0x1DBE90 VA: 0x1801DCA90
	internal string ServerNameUTF8() { }

	// RVA: 0x1DCA70 Offset: 0x1DBE70 VA: 0x1801DCA70
	internal string GameTagsUTF8() { }

}

