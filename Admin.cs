public class AdminExistingSellOrder : MonoBehaviour // TypeDefIndex: 8728
{	public VirtualItemIcon MerchandiseIcon; // 0x18
	public VirtualItemIcon CurrencyIcon; // 0x20
	private VendingPanelAdmin adminPanel; // 0x28
	private int index; // 0x30


	public void Setup(VendingMachine.SellOrder so, int newIndex, VendingPanelAdmin admin) { }

	public void DeleteClick() { }

	public void .ctor() { }

}

public class AdminUI : MonoBehaviour // TypeDefIndex: 10829
{
	public bool IsVisible() { }

	public void OnPanelOpened() { }

	public void Update() { }

	public void .ctor() { }

}

public class Admin : ConsoleSystem // TypeDefIndex: 11879
{	[ClientVar] // RVA: 0x81180 Offset: 0x80580 VA: 0x180081180
	public static float admintime; // 0x0
	[ClientVar] // RVA: 0x81360 Offset: 0x80760 VA: 0x180081360
	public static float adminlight; // 0x4
	[ClientVar] // RVA: 0x81480 Offset: 0x80880 VA: 0x180081480
	public static float adminreflectionmultiplier; // 0x8
	[ClientVar] // RVA: 0x81580 Offset: 0x80980 VA: 0x180081580
	public static float adminambientmultiplier; // 0xC
	[ReplicatedVar] // RVA: 0x81790 Offset: 0x80B90 VA: 0x180081790
	public static bool allowAdminUI; // 0x10
	[ClientVar] // RVA: 0x81830 Offset: 0x80C30 VA: 0x180081830
	public static bool underwater_effect; // 0x11
	[ClientVar] // RVA: 0x81830 Offset: 0x80C30 VA: 0x180081830
	public static float underwater_scatter; // 0x14
	[ClientVar] // RVA: 0x81970 Offset: 0x80D70 VA: 0x180081970
	public static bool woundedfreecam; // 0x18
	[ClientVar] // RVA: 0x81AE0 Offset: 0x80EE0 VA: 0x180081AE0
	public static bool ddraw_netupdate; // 0x19

	[ClientVar] // RVA: 0x85070 Offset: 0x84470 VA: 0x180085070
	public static float adminclouds { get; set; }
	[ClientVar] // RVA: 0x85320 Offset: 0x84720 VA: 0x180085320
	public static float adminfog { get; set; }
	[ClientVar] // RVA: 0x85480 Offset: 0x84880 VA: 0x180085480
	public static float adminwind { get; set; }
	[ClientVar] // RVA: 0x85580 Offset: 0x84980 VA: 0x180085580
	public static float adminrain { get; set; }


	[ServerVar] // RVA: 0x81B80 Offset: 0x80F80 VA: 0x180081B80
	public static void status(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81C40 Offset: 0x81040 VA: 0x180081C40
	public static void stats(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void killplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void injureplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void recoverplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void kick(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void kickall(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x831D0 Offset: 0x825D0 VA: 0x1800831D0
	public static void ban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void moderatorid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void ownerid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void removemoderator(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void removeowner(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83650 Offset: 0x82A50 VA: 0x180083650
	public static void banid(ConsoleSystem.Arg arg) { }

	private static bool TryGetBanExpiry(ConsoleSystem.Arg arg, int n, out long expiry, out string durationSuffix) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void unban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void skipqueue(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83930 Offset: 0x82D30 VA: 0x180083930
	public static void players(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83A70 Offset: 0x82E70 VA: 0x180083A70
	public static void say(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83B40 Offset: 0x82F40 VA: 0x180083B40
	public static void users(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83B40 Offset: 0x82F40 VA: 0x180083B40
	public static void sleepingusers(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83D80 Offset: 0x83180 VA: 0x180083D80
	public static void sleepingusersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83E40 Offset: 0x83240 VA: 0x180083E40
	public static void usersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83F20 Offset: 0x83320 VA: 0x180083F20
	public static void usersinrangeofplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83F90 Offset: 0x83390 VA: 0x180083F90
	public static void banlist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x840B0 Offset: 0x834B0 VA: 0x1800840B0
	public static void banlistex(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x843E0 Offset: 0x837E0 VA: 0x1800843E0
	public static void listid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void mute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x84630 Offset: 0x83A30 VA: 0x180084630
	public static void mutelist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void clientperf(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static void clientperf_frametime(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x848D0 Offset: 0x83CD0 VA: 0x1800848D0
	public static void carstats(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x849C0 Offset: 0x83DC0 VA: 0x1800849C0
	public static string ent(ConsoleSystem.Arg args) { }

	public static float get_adminclouds() { }

	public static void set_adminclouds(float value) { }

	public static float get_adminfog() { }

	public static void set_adminfog(float value) { }

	public static float get_adminwind() { }

	public static void set_adminwind(float value) { }

	public static float get_adminrain() { }

	public static void set_adminrain(float value) { }

	[ClientVar] // RVA: 0x84B70 Offset: 0x83F70 VA: 0x180084B70
	public static void AdminUI_ReceivePlayerList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84B70 Offset: 0x83F70 VA: 0x180084B70
	public static void AdminUI_ReceiveServerInfo(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84B70 Offset: 0x83F70 VA: 0x180084B70
	public static void AdminUI_ReceiveCommands(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84B70 Offset: 0x83F70 VA: 0x180084B70
	public static void AdminUI_ReceiveUGCList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84FB0 Offset: 0x843B0 VA: 0x180084FB0
	public static void hudcomponent(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Admin.PlayerInfo // TypeDefIndex: 11880
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

public struct Admin.ServerInfoOutput // TypeDefIndex: 11881
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

public struct Admin.ServerConvarInfo // TypeDefIndex: 11882
{	public string FullName; // 0x0
	public string Value; // 0x8
	public string Help; // 0x10

}

public struct Admin.ServerUGCInfo // TypeDefIndex: 11883
{	public uint entityId; // 0x0
	public uint[] crcs; // 0x8
	public UGCType contentType; // 0x10
	public uint entityPrefabID; // 0x14
	public string shortPrefabName; // 0x18
	public ulong[] playerIds; // 0x20

}

