public class AdminExistingSellOrder : MonoBehaviour // TypeDefIndex: 8728
{	// Fields
	public VirtualItemIcon MerchandiseIcon; // 0x18
	public VirtualItemIcon CurrencyIcon; // 0x20
	private VendingPanelAdmin adminPanel; // 0x28
	private int index; // 0x30

	// Methods

	// RVA: 0xA9FCC0 Offset: 0xA9E2C0 VA: 0x180A9FCC0
	public void Setup(VendingMachine.SellOrder so, int newIndex, VendingPanelAdmin admin) { }

	// RVA: 0xA9FC40 Offset: 0xA9E240 VA: 0x180A9FC40
	public void DeleteClick() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AdminUI : MonoBehaviour // TypeDefIndex: 10825
{	// Methods

	// RVA: 0xA9FDA0 Offset: 0xA9E3A0 VA: 0x180A9FDA0
	public bool IsVisible() { }

	// RVA: 0xA9FF00 Offset: 0xA9E500 VA: 0x180A9FF00
	public void OnPanelOpened() { }

	// RVA: 0xA9FF50 Offset: 0xA9E550 VA: 0x180A9FF50
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class Admin : ConsoleSystem // TypeDefIndex: 11875
{	// Fields
	[ClientVar] // RVA: 0x80EF0 Offset: 0x802F0 VA: 0x180080EF0
	public static float admintime; // 0x0
	[ClientVar] // RVA: 0x810A0 Offset: 0x804A0 VA: 0x1800810A0
	public static float adminlight; // 0x4
	[ClientVar] // RVA: 0x81190 Offset: 0x80590 VA: 0x180081190
	public static float adminreflectionmultiplier; // 0x8
	[ClientVar] // RVA: 0x81340 Offset: 0x80740 VA: 0x180081340
	public static float adminambientmultiplier; // 0xC
	[ReplicatedVar] // RVA: 0x81460 Offset: 0x80860 VA: 0x180081460
	public static bool allowAdminUI; // 0x10
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool underwater_effect; // 0x11
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static float underwater_scatter; // 0x14
	[ClientVar] // RVA: 0x81780 Offset: 0x80B80 VA: 0x180081780
	public static bool woundedfreecam; // 0x18
	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	public static bool ddraw_netupdate; // 0x19

	// Properties
	[ClientVar] // RVA: 0x84D80 Offset: 0x84180 VA: 0x180084D80
	public static float adminclouds { get; set; }
	[ClientVar] // RVA: 0x84EF0 Offset: 0x842F0 VA: 0x180084EF0
	public static float adminfog { get; set; }
	[ClientVar] // RVA: 0x85080 Offset: 0x84480 VA: 0x180085080
	public static float adminwind { get; set; }
	[ClientVar] // RVA: 0x852E0 Offset: 0x846E0 VA: 0x1800852E0
	public static float adminrain { get; set; }

	// Methods

	[ServerVar] // RVA: 0x81950 Offset: 0x80D50 VA: 0x180081950
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void status(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void stats(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void killplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void injureplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void recoverplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void kick(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void kickall(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D30 Offset: 0x81130 VA: 0x180081D30
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void moderatorid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ownerid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void removemoderator(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void removeowner(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83370 Offset: 0x82770 VA: 0x180083370
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void banid(ConsoleSystem.Arg arg) { }

	// RVA: 0x6C9C90 Offset: 0x6C8290 VA: 0x1806C9C90
	private static bool TryGetBanExpiry(ConsoleSystem.Arg arg, int n, out long expiry, out string durationSuffix) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void unban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void skipqueue(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83680 Offset: 0x82A80 VA: 0x180083680
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void players(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83820 Offset: 0x82C20 VA: 0x180083820
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void say(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83860 Offset: 0x82C60 VA: 0x180083860
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void users(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83860 Offset: 0x82C60 VA: 0x180083860
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void sleepingusers(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83A30 Offset: 0x82E30 VA: 0x180083A30
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void sleepingusersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83B10 Offset: 0x82F10 VA: 0x180083B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void usersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83CB0 Offset: 0x830B0 VA: 0x180083CB0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void usersinrangeofplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83D70 Offset: 0x83170 VA: 0x180083D70
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void banlist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83E50 Offset: 0x83250 VA: 0x180083E50
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void banlistex(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83F40 Offset: 0x83340 VA: 0x180083F40
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void listid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void mute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x84440 Offset: 0x83840 VA: 0x180084440
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void mutelist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void clientperf(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void clientperf_frametime(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x84610 Offset: 0x83A10 VA: 0x180084610
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void carstats(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84780 Offset: 0x83B80 VA: 0x180084780
	// RVA: 0x6C9ED0 Offset: 0x6C84D0 VA: 0x1806C9ED0
	public static string ent(ConsoleSystem.Arg args) { }

	// RVA: 0x6CA150 Offset: 0x6C8750 VA: 0x1806CA150
	public static float get_adminclouds() { }

	// RVA: 0x6CAA10 Offset: 0x6C9010 VA: 0x1806CAA10
	public static void set_adminclouds(float value) { }

	// RVA: 0x6CA240 Offset: 0x6C8840 VA: 0x1806CA240
	public static float get_adminfog() { }

	// RVA: 0x6CAB00 Offset: 0x6C9100 VA: 0x1806CAB00
	public static void set_adminfog(float value) { }

	// RVA: 0x6CA420 Offset: 0x6C8A20 VA: 0x1806CA420
	public static float get_adminwind() { }

	// RVA: 0x6CACE0 Offset: 0x6C92E0 VA: 0x1806CACE0
	public static void set_adminwind(float value) { }

	// RVA: 0x6CA330 Offset: 0x6C8930 VA: 0x1806CA330
	public static float get_adminrain() { }

	// RVA: 0x6CABF0 Offset: 0x6C91F0 VA: 0x1806CABF0
	public static void set_adminrain(float value) { }

	[ClientVar] // RVA: 0x84830 Offset: 0x83C30 VA: 0x180084830
	// RVA: 0x6C9A80 Offset: 0x6C8080 VA: 0x1806C9A80
	public static void AdminUI_ReceivePlayerList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84830 Offset: 0x83C30 VA: 0x180084830
	// RVA: 0x6C9B30 Offset: 0x6C8130 VA: 0x1806C9B30
	public static void AdminUI_ReceiveServerInfo(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84830 Offset: 0x83C30 VA: 0x180084830
	// RVA: 0x6C99D0 Offset: 0x6C7FD0 VA: 0x1806C99D0
	public static void AdminUI_ReceiveCommands(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84830 Offset: 0x83C30 VA: 0x180084830
	// RVA: 0x6C9BE0 Offset: 0x6C81E0 VA: 0x1806C9BE0
	public static void AdminUI_ReceiveUGCList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84BD0 Offset: 0x83FD0 VA: 0x180084BD0
	// RVA: 0x6CA510 Offset: 0x6C8B10 VA: 0x1806CA510
	public static void hudcomponent(ConsoleSystem.Arg arg) { }

	// RVA: 0x6C9E70 Offset: 0x6C8470 VA: 0x1806C9E70
	public void .ctor() { }

	// RVA: 0x6C9DA0 Offset: 0x6C83A0 VA: 0x1806C9DA0
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

