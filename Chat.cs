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
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static bool enabled; // 0x0
	public static Chat.MuteList muted; // 0x8

	// Properties
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool muteglobal { get; set; }

	// Methods

	// RVA: 0x6CDAD0 Offset: 0x6CC0D0 VA: 0x1806CDAD0
	public static bool get_muteglobal() { }

	// RVA: 0x6CE100 Offset: 0x6CC700 VA: 0x1806CE100
	public static void set_muteglobal(bool value) { }

	// RVA: 0x6CCCD0 Offset: 0x6CB2D0 VA: 0x1806CCCD0
	public static void LoadMuteList() { }

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x6CD6F0 Offset: 0x6CBCF0 VA: 0x1806CD6F0
	public static void add(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x6CD460 Offset: 0x6CBA60 VA: 0x1806CD460
	public static void add2(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6CDB70 Offset: 0x6CC170 VA: 0x1806CDB70
	public static void mute(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6CE1A0 Offset: 0x6CC7A0 VA: 0x1806CE1A0
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6CDBF0 Offset: 0x6CC1F0 VA: 0x1806CDBF0
	public static void mutelist(ConsoleSystem.Arg arg) { }

	// RVA: 0x6CCE00 Offset: 0x6CB400 VA: 0x1806CCE00
	public static void MuteSteamID(ulong id) { }

	// RVA: 0x6CD220 Offset: 0x6CB820 VA: 0x1806CD220
	public static void UnmuteSteamID(ulong id) { }

	// RVA: 0x6CD100 Offset: 0x6CB700 VA: 0x1806CD100
	public static void UnMuteAll() { }

	// RVA: 0x6CCC20 Offset: 0x6CB220 VA: 0x1806CCC20
	public static bool IsSteamIDMuted(ulong id) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6CE320 Offset: 0x6CC920 VA: 0x1806CE320
	public static void unmuteall(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6CE040 Offset: 0x6CC640 VA: 0x1806CE040
	public static void open() { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6CD910 Offset: 0x6CBF10 VA: 0x1806CD910
	public static void clear() { }

	// RVA: 0x6CD400 Offset: 0x6CBA00 VA: 0x1806CD400
	public void .ctor() { }

	// RVA: 0x6CD340 Offset: 0x6CB940 VA: 0x1806CD340
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Chat.ChatChannel <Channel>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Message>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <UserId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Username>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Color>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <Time>k__BackingField; // 0x28

	// Properties
	public Chat.ChatChannel Channel { get; set; }
	public string Message { get; set; }
	public string UserId { get; set; }
	public string Username { get; set; }
	public string Color { get; set; }
	public int Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public Chat.ChatChannel get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_Channel(Chat.ChatChannel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF1520 Offset: 0xF0920 VA: 0x1800F1520
	public void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
	public string get_UserId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF14F0 Offset: 0xF08F0 VA: 0x1800F14F0
	public void set_UserId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
	public string get_Username() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF1500 Offset: 0xF0900 VA: 0x1800F1500
	public void set_Username(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37B0 Offset: 0xF2BB0 VA: 0x1800F37B0
	public string get_Color() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF1560 Offset: 0xF0960 VA: 0x1800F1560
	public void set_Color(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F50 Offset: 0xF3350 VA: 0x1800F3F50
	public int get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F80 Offset: 0xF3380 VA: 0x1800F3F80
	public void set_Time(int value) { }

}

public struct Chat.MuteEntry // TypeDefIndex: 11889
{	// Fields
	public ulong UserID; // 0x0
	public string UserName; // 0x8
	public string DateTime; // 0x10

	// Methods

	// RVA: 0xF4190 Offset: 0xF3590 VA: 0x1800F4190
	public void .ctor(ulong id, string name) { }

}

public class Chat.MuteList // TypeDefIndex: 11890
{	// Fields
	private Dictionary<ulong, Chat.MuteEntry> entries; // 0x10

	// Properties
	public List<Chat.MuteEntry> All { get; }
	public bool IsGlobalMuted { get; }

	// Methods

	// RVA: 0x6E73C0 Offset: 0x6E59C0 VA: 0x1806E73C0
	public List<Chat.MuteEntry> get_All() { }

	// RVA: 0x6E7290 Offset: 0x6E5890 VA: 0x1806E7290
	public void SetGlobalMuted(bool flag) { }

	// RVA: 0x6E7420 Offset: 0x6E5A20 VA: 0x1806E7420
	public bool get_IsGlobalMuted() { }

	// RVA: 0x6E6FA0 Offset: 0x6E55A0 VA: 0x1806E6FA0
	public bool IsMuted(ulong steamId) { }

	// RVA: 0x6E70D0 Offset: 0x6E56D0 VA: 0x1806E70D0
	public void Mute(ulong steamID, string steamName) { }

	// RVA: 0x6E72D0 Offset: 0x6E58D0 VA: 0x1806E72D0
	public void UnMute(ulong steamID) { }

	// RVA: 0x6E6EE0 Offset: 0x6E54E0 VA: 0x1806E6EE0
	public void Clear() { }

	// RVA: 0x6E7000 Offset: 0x6E5600 VA: 0x1806E7000
	public void Load() { }

	// RVA: 0x6E7220 Offset: 0x6E5820 VA: 0x1806E7220
	private void Save() { }

	// RVA: 0x6E7350 Offset: 0x6E5950 VA: 0x1806E7350
	public void .ctor() { }

}

private sealed class Chat.<>c // TypeDefIndex: 11891
{	// Fields
	public static readonly Chat.<>c <>9; // 0x0
	public static Action<UIChat> <>9__23_0; // 0x8

	// Methods

	// RVA: 0x6E8710 Offset: 0x6E6D10 VA: 0x1806E8710
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6E8200 Offset: 0x6E6800 VA: 0x1806E8200
	internal void <clear>b__23_0(UIChat chat) { }

}

