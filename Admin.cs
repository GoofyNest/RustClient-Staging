public class AdminExistingSellOrder : MonoBehaviour // TypeDefIndex: 8728
{	public VirtualItemIcon MerchandiseIcon; // 0x18
	public VirtualItemIcon CurrencyIcon; // 0x20
	private VendingPanelAdmin adminPanel; // 0x28
	private int index; // 0x30


	public void Setup(VendingMachine.SellOrder so, int newIndex, VendingPanelAdmin admin) { }

	public void DeleteClick() { }

	public void .ctor() { }

}

public class AdminUI : MonoBehaviour // TypeDefIndex: 10825
{
	public bool IsVisible() { }

	public void OnPanelOpened() { }

	public void Update() { }

	public void .ctor() { }

}

public class Admin : ConsoleSystem // TypeDefIndex: 11875
{	[ClientVar] // RVA: 0x80EF0 Offset: 0x802F0 VA: 0x180080EF0
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

	[ClientVar] // RVA: 0x84D80 Offset: 0x84180 VA: 0x180084D80
	public static float adminclouds { get; set; }
	[ClientVar] // RVA: 0x84EF0 Offset: 0x842F0 VA: 0x180084EF0
	public static float adminfog { get; set; }
	[ClientVar] // RVA: 0x85080 Offset: 0x84480 VA: 0x180085080
	public static float adminwind { get; set; }
	[ClientVar] // RVA: 0x852E0 Offset: 0x846E0 VA: 0x1800852E0
	public static float adminrain { get; set; }


	[ServerVar] // RVA: 0x81950 Offset: 0x80D50 VA: 0x180081950
	public static void status(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static void stats(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void killplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void injureplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void recoverplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void kick(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void kickall(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D30 Offset: 0x81130 VA: 0x180081D30
	public static void ban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void moderatorid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void ownerid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void removemoderator(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void removeowner(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83370 Offset: 0x82770 VA: 0x180083370
	public static void banid(ConsoleSystem.Arg arg) { }

	private static bool TryGetBanExpiry(ConsoleSystem.Arg arg, int n, out long expiry, out string durationSuffix) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void unban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void skipqueue(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83680 Offset: 0x82A80 VA: 0x180083680
	public static void players(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83820 Offset: 0x82C20 VA: 0x180083820
	public static void say(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83860 Offset: 0x82C60 VA: 0x180083860
	public static void users(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83860 Offset: 0x82C60 VA: 0x180083860
	public static void sleepingusers(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83A30 Offset: 0x82E30 VA: 0x180083A30
	public static void sleepingusersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83B10 Offset: 0x82F10 VA: 0x180083B10
	public static void usersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83CB0 Offset: 0x830B0 VA: 0x180083CB0
	public static void usersinrangeofplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83D70 Offset: 0x83170 VA: 0x180083D70
	public static void banlist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83E50 Offset: 0x83250 VA: 0x180083E50
	public static void banlistex(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83F40 Offset: 0x83340 VA: 0x180083F40
	public static void listid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void mute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x84440 Offset: 0x83840 VA: 0x180084440
	public static void mutelist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void clientperf(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static void clientperf_frametime(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x84610 Offset: 0x83A10 VA: 0x180084610
	public static void carstats(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84780 Offset: 0x83B80 VA: 0x180084780
	public static string ent(ConsoleSystem.Arg args) { }

	public static float get_adminclouds() { }

	public static void set_adminclouds(float value) { }

	public static float get_adminfog() { }

	public static void set_adminfog(float value) { }

	public static float get_adminwind() { }

	public static void set_adminwind(float value) { }

	public static float get_adminrain() { }

	public static void set_adminrain(float value) { }

	[ClientVar] // RVA: 0x84830 Offset: 0x83C30 VA: 0x180084830
	public static void AdminUI_ReceivePlayerList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84830 Offset: 0x83C30 VA: 0x180084830
	public static void AdminUI_ReceiveServerInfo(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84830 Offset: 0x83C30 VA: 0x180084830
	public static void AdminUI_ReceiveCommands(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84830 Offset: 0x83C30 VA: 0x180084830
	public static void AdminUI_ReceiveUGCList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84BD0 Offset: 0x83FD0 VA: 0x180084BD0
	public static void hudcomponent(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Admin.PlayerInfo // TypeDefIndex: 11876
{	public string SteamID; // 0x0
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
{	public string Hostname; // 0x0
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
{	public string FullName; // 0x0
	public string Value; // 0x8
	public string Help; // 0x10

}

public struct Admin.ServerUGCInfo // TypeDefIndex: 11879
{	public uint entityId; // 0x0
	public uint[] crcs; // 0x8
	public UGCType contentType; // 0x10
	public uint entityPrefabID; // 0x14
	public string shortPrefabName; // 0x18
	public ulong[] playerIds; // 0x20

}

