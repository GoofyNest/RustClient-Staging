internal enum ChatEntryType // TypeDefIndex: 5139
{	// Fields
	public int value__; // 0x0
	public const ChatEntryType Invalid = 0;
	public const ChatEntryType ChatMsg = 1;
	public const ChatEntryType Typing = 2;
	public const ChatEntryType InviteGame = 3;
	public const ChatEntryType Emote = 4;
	public const ChatEntryType LeftConversation = 6;
	public const ChatEntryType Entered = 7;
	public const ChatEntryType WasKicked = 8;
	public const ChatEntryType WasBanned = 9;
	public const ChatEntryType Disconnected = 10;
	public const ChatEntryType HistoricalChat = 11;
	public const ChatEntryType LinkBlocked = 14;

}

public class ChatEntry : MonoBehaviour // TypeDefIndex: 10829
{	// Fields
	public TextMeshProUGUI text; // 0x18
	public RawImage avatar; // 0x20
	public CanvasGroup canvasGroup; // 0x28
	public float lifeStarted; // 0x30
	public ulong steamid; // 0x38
	private Texture defaultTexture; // 0x40
	private Action<ChatEntry> clickedAction; // 0x48

	// Properties
	public float age { get; }

	// Methods

	// RVA: 0x536840 Offset: 0x534E40 VA: 0x180536840
	public float get_age() { }

	// RVA: 0x536430 Offset: 0x534A30 VA: 0x180536430
	public void Setup(Chat.ChatChannel channel, ulong steamid, string message, float volume, Action<ChatEntry> clickedAction) { }

	// RVA: 0x536390 Offset: 0x534990 VA: 0x180536390
	private void SetMessageText(Chat.ChatChannel channel, string message) { }

	// RVA: 0x5366A0 Offset: 0x534CA0 VA: 0x1805366A0
	protected void Update() { }

	// RVA: 0x536340 Offset: 0x534940 VA: 0x180536340
	public void OnClicked() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class Chat : ConsoleSystem // TypeDefIndex: 11886
{	// Fields
	private const float textRange = 50;
	private const float textVolumeBoost = 0,2;
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool enabled; // 0x0
	public static Chat.MuteList muted; // 0x8

	// Properties
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool muteglobal { get; set; }

	// Methods

	// RVA: 0x6CDBE0 Offset: 0x6CC1E0 VA: 0x1806CDBE0
	public static bool get_muteglobal() { }

	// RVA: 0x6CE210 Offset: 0x6CC810 VA: 0x1806CE210
	public static void set_muteglobal(bool value) { }

	// RVA: 0x6CCDE0 Offset: 0x6CB3E0 VA: 0x1806CCDE0
	public static void LoadMuteList() { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x6CD800 Offset: 0x6CBE00 VA: 0x1806CD800
	public static void add(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x6CD570 Offset: 0x6CBB70 VA: 0x1806CD570
	public static void add2(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CDC80 Offset: 0x6CC280 VA: 0x1806CDC80
	public static void mute(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE2B0 Offset: 0x6CC8B0 VA: 0x1806CE2B0
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CDD00 Offset: 0x6CC300 VA: 0x1806CDD00
	public static void mutelist(ConsoleSystem.Arg arg) { }

	// RVA: 0x6CCF10 Offset: 0x6CB510 VA: 0x1806CCF10
	public static void MuteSteamID(ulong id) { }

	// RVA: 0x6CD330 Offset: 0x6CB930 VA: 0x1806CD330
	public static void UnmuteSteamID(ulong id) { }

	// RVA: 0x6CD210 Offset: 0x6CB810 VA: 0x1806CD210
	public static void UnMuteAll() { }

	// RVA: 0x6CCD30 Offset: 0x6CB330 VA: 0x1806CCD30
	public static bool IsSteamIDMuted(ulong id) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE430 Offset: 0x6CCA30 VA: 0x1806CE430
	public static void unmuteall(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CE150 Offset: 0x6CC750 VA: 0x1806CE150
	public static void open() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6CDA20 Offset: 0x6CC020 VA: 0x1806CDA20
	public static void clear() { }

	// RVA: 0x6CD510 Offset: 0x6CBB10 VA: 0x1806CD510
	public void .ctor() { }

	// RVA: 0x6CD450 Offset: 0x6CBA50 VA: 0x1806CD450
	private static void .cctor() { }

}

public enum Chat.ChatChannel // TypeDefIndex: 11887
{	// Fields
	public int value__; // 0x0
	public const Chat.ChatChannel Global = 0;
	public const Chat.ChatChannel Team = 1;
	public const Chat.ChatChannel Server = 2;
	public const Chat.ChatChannel Cards = 3;

}

public struct Chat.ChatEntry // TypeDefIndex: 11888
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Chat.ChatChannel <Channel>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Message>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <UserId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Username>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Color>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Time>k__BackingField; // 0x28

	// Properties
	public Chat.ChatChannel Channel { get; set; }
	public string Message { get; set; }
	public string UserId { get; set; }
	public string Username { get; set; }
	public string Color { get; set; }
	public int Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public Chat.ChatChannel get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_Channel(Chat.ChatChannel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF14A0 Offset: 0xF08A0 VA: 0x1800F14A0
	public void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	public string get_UserId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1470 Offset: 0xF0870 VA: 0x1800F1470
	public void set_UserId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	public string get_Username() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1480 Offset: 0xF0880 VA: 0x1800F1480
	public void set_Username(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3730 Offset: 0xF2B30 VA: 0x1800F3730
	public string get_Color() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF14E0 Offset: 0xF08E0 VA: 0x1800F14E0
	public void set_Color(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3ED0 Offset: 0xF32D0 VA: 0x1800F3ED0
	public int get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3F00 Offset: 0xF3300 VA: 0x1800F3F00
	public void set_Time(int value) { }

}

public struct Chat.MuteEntry // TypeDefIndex: 11889
{	// Fields
	public ulong UserID; // 0x0
	public string UserName; // 0x8
	public string DateTime; // 0x10

	// Methods

	// RVA: 0xF4110 Offset: 0xF3510 VA: 0x1800F4110
	public void .ctor(ulong id, string name) { }

}

public class Chat.MuteList // TypeDefIndex: 11890
{	// Fields
	private Dictionary<ulong, Chat.MuteEntry> entries; // 0x10

	// Properties
	public List<Chat.MuteEntry> All { get; }
	public bool IsGlobalMuted { get; }

	// Methods

	// RVA: 0x6E74D0 Offset: 0x6E5AD0 VA: 0x1806E74D0
	public List<Chat.MuteEntry> get_All() { }

	// RVA: 0x6E73A0 Offset: 0x6E59A0 VA: 0x1806E73A0
	public void SetGlobalMuted(bool flag) { }

	// RVA: 0x6E7530 Offset: 0x6E5B30 VA: 0x1806E7530
	public bool get_IsGlobalMuted() { }

	// RVA: 0x6E70B0 Offset: 0x6E56B0 VA: 0x1806E70B0
	public bool IsMuted(ulong steamId) { }

	// RVA: 0x6E71E0 Offset: 0x6E57E0 VA: 0x1806E71E0
	public void Mute(ulong steamID, string steamName) { }

	// RVA: 0x6E73E0 Offset: 0x6E59E0 VA: 0x1806E73E0
	public void UnMute(ulong steamID) { }

	// RVA: 0x6E6FF0 Offset: 0x6E55F0 VA: 0x1806E6FF0
	public void Clear() { }

	// RVA: 0x6E7110 Offset: 0x6E5710 VA: 0x1806E7110
	public void Load() { }

	// RVA: 0x6E7330 Offset: 0x6E5930 VA: 0x1806E7330
	private void Save() { }

	// RVA: 0x6E7460 Offset: 0x6E5A60 VA: 0x1806E7460
	public void .ctor() { }

}

private sealed class Chat.<>c // TypeDefIndex: 11891
{	// Fields
	public static readonly Chat.<>c <>9; // 0x0
	public static Action<UIChat> <>9__23_0; // 0x8

	// Methods

	// RVA: 0x6E8820 Offset: 0x6E6E20 VA: 0x1806E8820
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8310 Offset: 0x6E6910 VA: 0x1806E8310
	internal void <clear>b__23_0(UIChat chat) { }

}

