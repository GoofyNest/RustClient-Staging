public class AdminExistingSellOrder : MonoBehaviour // TypeDefIndex: 8728
{	// Fields
	public VirtualItemIcon MerchandiseIcon; // 0x18
	public VirtualItemIcon CurrencyIcon; // 0x20
	private VendingPanelAdmin adminPanel; // 0x28
	private int index; // 0x30

	// Methods

	// RVA: 0xA9FA00 Offset: 0xA9E000 VA: 0x180A9FA00
	public void Setup(VendingMachine.SellOrder so, int newIndex, VendingPanelAdmin admin) { }

	// RVA: 0xA9F980 Offset: 0xA9DF80 VA: 0x180A9F980
	public void DeleteClick() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AdminUI : MonoBehaviour // TypeDefIndex: 10825
{	// Methods

	// RVA: 0xA9FAE0 Offset: 0xA9E0E0 VA: 0x180A9FAE0
	public bool IsVisible() { }

	// RVA: 0xA9FC40 Offset: 0xA9E240 VA: 0x180A9FC40
	public void OnPanelOpened() { }

	// RVA: 0xA9FC90 Offset: 0xA9E290 VA: 0x180A9FC90
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class Admin : ConsoleSystem // TypeDefIndex: 11875
{	// Fields
	[ClientVar] // RVA: 0x80D20 Offset: 0x80120 VA: 0x180080D20
	public static float admintime; // 0x0
	[ClientVar] // RVA: 0x80F30 Offset: 0x80330 VA: 0x180080F30
	public static float adminlight; // 0x4
	[ClientVar] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	public static float adminreflectionmultiplier; // 0x8
	[ClientVar] // RVA: 0x81250 Offset: 0x80650 VA: 0x180081250
	public static float adminambientmultiplier; // 0xC
	[ReplicatedVar] // RVA: 0x81320 Offset: 0x80720 VA: 0x180081320
	public static bool allowAdminUI; // 0x10
	[ClientVar] // RVA: 0x81410 Offset: 0x80810 VA: 0x180081410
	public static bool underwater_effect; // 0x11
	[ClientVar] // RVA: 0x81410 Offset: 0x80810 VA: 0x180081410
	public static float underwater_scatter; // 0x14
	[ClientVar] // RVA: 0x81690 Offset: 0x80A90 VA: 0x180081690
	public static bool woundedfreecam; // 0x18
	[ClientVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	public static bool ddraw_netupdate; // 0x19

	// Properties
	[ClientVar] // RVA: 0x84C70 Offset: 0x84070 VA: 0x180084C70
	public static float adminclouds { get; set; }
	[ClientVar] // RVA: 0x84E50 Offset: 0x84250 VA: 0x180084E50
	public static float adminfog { get; set; }
	[ClientVar] // RVA: 0x84F70 Offset: 0x84370 VA: 0x180084F70
	public static float adminwind { get; set; }
	[ClientVar] // RVA: 0x85220 Offset: 0x84620 VA: 0x180085220
	public static float adminrain { get; set; }

	// Methods

	[ServerVar] // RVA: 0x817F0 Offset: 0x80BF0 VA: 0x1800817F0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void status(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void stats(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void killplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void injureplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void recoverplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void kick(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void kickall(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81CC0 Offset: 0x810C0 VA: 0x180081CC0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void moderatorid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ownerid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void removemoderator(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void removeowner(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x831F0 Offset: 0x825F0 VA: 0x1800831F0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void banid(ConsoleSystem.Arg arg) { }

	// RVA: 0x6C9B80 Offset: 0x6C8180 VA: 0x1806C9B80
	private static bool TryGetBanExpiry(ConsoleSystem.Arg arg, int n, out long expiry, out string durationSuffix) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void unban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void skipqueue(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83500 Offset: 0x82900 VA: 0x180083500
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void players(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83760 Offset: 0x82B60 VA: 0x180083760
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void say(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x837F0 Offset: 0x82BF0 VA: 0x1800837F0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void users(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x837F0 Offset: 0x82BF0 VA: 0x1800837F0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void sleepingusers(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x839C0 Offset: 0x82DC0 VA: 0x1800839C0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void sleepingusersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83A30 Offset: 0x82E30 VA: 0x180083A30
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void usersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83BD0 Offset: 0x82FD0 VA: 0x180083BD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void usersinrangeofplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83D00 Offset: 0x83100 VA: 0x180083D00
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void banlist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83DE0 Offset: 0x831E0 VA: 0x180083DE0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void banlistex(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83E50 Offset: 0x83250 VA: 0x180083E50
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void listid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void mute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x84380 Offset: 0x83780 VA: 0x180084380
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void mutelist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void clientperf(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void clientperf_frametime(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x84500 Offset: 0x83900 VA: 0x180084500
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void carstats(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x846B0 Offset: 0x83AB0 VA: 0x1800846B0
	// RVA: 0x6C9DC0 Offset: 0x6C83C0 VA: 0x1806C9DC0
	public static string ent(ConsoleSystem.Arg args) { }

	// RVA: 0x6CA040 Offset: 0x6C8640 VA: 0x1806CA040
	public static float get_adminclouds() { }

	// RVA: 0x6CA900 Offset: 0x6C8F00 VA: 0x1806CA900
	public static void set_adminclouds(float value) { }

	// RVA: 0x6CA130 Offset: 0x6C8730 VA: 0x1806CA130
	public static float get_adminfog() { }

	// RVA: 0x6CA9F0 Offset: 0x6C8FF0 VA: 0x1806CA9F0
	public static void set_adminfog(float value) { }

	// RVA: 0x6CA310 Offset: 0x6C8910 VA: 0x1806CA310
	public static float get_adminwind() { }

	// RVA: 0x6CABD0 Offset: 0x6C91D0 VA: 0x1806CABD0
	public static void set_adminwind(float value) { }

	// RVA: 0x6CA220 Offset: 0x6C8820 VA: 0x1806CA220
	public static float get_adminrain() { }

	// RVA: 0x6CAAE0 Offset: 0x6C90E0 VA: 0x1806CAAE0
	public static void set_adminrain(float value) { }

	[ClientVar] // RVA: 0x84790 Offset: 0x83B90 VA: 0x180084790
	// RVA: 0x6C9970 Offset: 0x6C7F70 VA: 0x1806C9970
	public static void AdminUI_ReceivePlayerList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84790 Offset: 0x83B90 VA: 0x180084790
	// RVA: 0x6C9A20 Offset: 0x6C8020 VA: 0x1806C9A20
	public static void AdminUI_ReceiveServerInfo(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84790 Offset: 0x83B90 VA: 0x180084790
	// RVA: 0x6C98C0 Offset: 0x6C7EC0 VA: 0x1806C98C0
	public static void AdminUI_ReceiveCommands(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84790 Offset: 0x83B90 VA: 0x180084790
	// RVA: 0x6C9AD0 Offset: 0x6C80D0 VA: 0x1806C9AD0
	public static void AdminUI_ReceiveUGCList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84AC0 Offset: 0x83EC0 VA: 0x180084AC0
	// RVA: 0x6CA400 Offset: 0x6C8A00 VA: 0x1806CA400
	public static void hudcomponent(ConsoleSystem.Arg arg) { }

	// RVA: 0x6C9D60 Offset: 0x6C8360 VA: 0x1806C9D60
	public void .ctor() { }

	// RVA: 0x6C9C90 Offset: 0x6C8290 VA: 0x1806C9C90
	private static void .cctor() { }

}

public struct Admin.PlayerInfo // TypeDefIndex: 11876
{	// Fields
	public string SteamID; // 0x0
	public string OwnerSteamID; // 0x8
	public string DisplayName; // 0x10
	public int Ping; // 0x18
	public string Address; // 0x20
	public int ConnectedSeconds; // 0x28
	public float VoiationLevel; // 0x2C
	public float CurrentLevel; // 0x30
	public float UnspentXp; // 0x34
	public float Health; // 0x38

}

public struct Admin.ServerInfoOutput // TypeDefIndex: 11877
{	// Fields
	public string Hostname; // 0x0
	public int MaxPlayers; // 0x8
	public int Players; // 0xC
	public int Queued; // 0x10
	public int Joining; // 0x14
	public int EntityCount; // 0x18
	public string GameTime; // 0x20
	public int Uptime; // 0x28
	public string Map; // 0x30
	public float Framerate; // 0x38
	public int Memory; // 0x3C
	public int Collections; // 0x40
	public int NetworkIn; // 0x44
	public int NetworkOut; // 0x48
	public bool Restarting; // 0x4C
	public string SaveCreatedTime; // 0x50
	public int Version; // 0x58
	public string Protocol; // 0x60

}

public struct Admin.ServerConvarInfo // TypeDefIndex: 11878
{	// Fields
	public string FullName; // 0x0
	public string Value; // 0x8
	public string Help; // 0x10

}

public struct Admin.ServerUGCInfo // TypeDefIndex: 11879
{	// Fields
	public uint entityId; // 0x0
	public uint[] crcs; // 0x8
	public UGCType contentType; // 0x10
	public uint entityPrefabID; // 0x14
	public string shortPrefabName; // 0x18
	public ulong[] playerIds; // 0x20

}

