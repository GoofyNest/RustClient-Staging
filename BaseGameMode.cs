public class BaseGameMode : BaseEntity // TypeDefIndex: 8517
{	// Fields
	private GameMode gameModeScores; // 0x168
	public string[] scoreColumns; // 0x170
	public const BaseEntity.Flags Flag_Warmup = 128;
	public const BaseEntity.Flags Flag_GameOver = 256;
	public const BaseEntity.Flags Flag_WaitingForPlayers = 512;
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<BaseGameMode> GameModeChanged; // 0x0
	public string shortname; // 0x178
	public float matchDuration; // 0x180
	public float warmupDuration; // 0x184
	public float timeBetweenMatches; // 0x188
	public int minPlayersToStart; // 0x18C
	public bool useCustomSpawns; // 0x190
	public string victoryScoreName; // 0x198
	public string teamScoreName; // 0x1A0
	public int numScoreForVictory; // 0x1A8
	public string gamemodeTitle; // 0x1B0
	public SoundDefinition[] warmupMusics; // 0x1B8
	public SoundDefinition[] lossMusics; // 0x1C0
	public SoundDefinition[] winMusics; // 0x1C8
	private float warmupStartTime; // 0x1D0
	private float matchStartTime; // 0x1D4
	private float matchEndTime; // 0x1D8
	public string[] gameModeTags; // 0x1E0
	public BasePlayer.CameraMode deathCameraMode; // 0x1E8
	public bool permanent; // 0x1EC
	public bool limitTeamAuths; // 0x1ED
	public bool allowSleeping; // 0x1EE
	public bool allowWounding; // 0x1EF
	public bool allowBleeding; // 0x1F0
	public bool allowTemperature; // 0x1F1
	public bool quickRespawn; // 0x1F2
	public float respawnDelayOverride; // 0x1F4
	public float startHealthOverride; // 0x1F8
	public float autoHealDelay; // 0x1FC
	public float autoHealDuration; // 0x200
	public bool hasKillFeed; // 0x204
	public static BaseGameMode clActiveGameMode; // 0x8
	public static List<BaseGameMode> clGameModeManifest; // 0x10
	public PlayerInventoryProperties[] loadouts; // 0x208
	[TooltipAttribute] // RVA: 0xA2750 Offset: 0xA1B50 VA: 0x1800A2750
	public bool useStaticLoadoutPerPlayer; // 0x210
	public bool topUpMagazines; // 0x211
	public bool sendKillNotifications; // 0x212
	public BaseGameMode.GameModeTeam[] teams; // 0x218
	private bool wasInWarmup; // 0x220
	private bool wasMatchOver; // 0x221
	private bool wasMatchActive; // 0x222

	// Methods

	// RVA: 0xA3E0B0 Offset: 0xA3C6B0 VA: 0x180A3E0B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA3C9B0 Offset: 0xA3AFB0 VA: 0x180A3C9B0
	public GameMode GetGameScores() { }

	// RVA: 0xA3E8C0 Offset: 0xA3CEC0 VA: 0x180A3E8C0
	public int ScoreColumnIndex(string scoreName) { }

	// RVA: 0xA3D740 Offset: 0xA3BD40 VA: 0x180A3D740
	public void InitScores() { }

	// RVA: 0xA3BF30 Offset: 0xA3A530 VA: 0x180A3BF30
	public void CopyGameModeScores(GameMode from, GameMode to) { }

	// RVA: 0xA3CD20 Offset: 0xA3B320 VA: 0x180A3CD20
	public GameMode.PlayerScore GetPlayerScoreForPlayer(BasePlayer player) { }

	// RVA: 0xA3CFB0 Offset: 0xA3B5B0 VA: 0x180A3CFB0
	public int GetScoreIndexByName(string name) { }

	// RVA: 0xA3DCC0 Offset: 0xA3C2C0 VA: 0x180A3DCC0 Slot: 131
	public virtual bool IsDraw() { }

	// RVA: 0xA3D190 Offset: 0xA3B790 VA: 0x180A3D190 Slot: 132
	public virtual string GetWinnerName() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 133
	public virtual int GetPlayerTeamPosition(BasePlayer player) { }

	// RVA: 0xA3CB10 Offset: 0xA3B110 VA: 0x180A3CB10 Slot: 134
	public virtual int GetPlayerRank(BasePlayer player) { }

	// RVA: 0xA3D440 Offset: 0xA3BA40 VA: 0x180A3D440
	public int GetWinningTeamIndex() { }

	// RVA: 0xA3C660 Offset: 0xA3AC60 VA: 0x180A3C660 Slot: 135
	public virtual bool DidPlayerWin(BasePlayer player) { }

	// RVA: 0xA3DF80 Offset: 0xA3C580 VA: 0x180A3DF80
	public bool IsTeamGame() { }

	// RVA: 0xA3DFB0 Offset: 0xA3C5B0 VA: 0x180A3DFB0
	public bool KeepScores() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3EF00 Offset: 0xA3D500 VA: 0x180A3EF00
	public static void add_GameModeChanged(Action<BaseGameMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3EFF0 Offset: 0xA3D5F0 VA: 0x180A3EFF0
	public static void remove_GameModeChanged(Action<BaseGameMode> value) { }

	// RVA: 0xA3D540 Offset: 0xA3BB40 VA: 0x180A3D540
	public bool HasAnyGameModeTag(string[] tags) { }

	// RVA: 0xA3D610 Offset: 0xA3BC10 VA: 0x180A3D610
	public bool HasGameModeTag(string tag) { }

	// RVA: 0xA3BD20 Offset: 0xA3A320 VA: 0x180A3BD20
	public bool AllowsSleeping() { }

	// RVA: 0xA3D6C0 Offset: 0xA3BCC0 VA: 0x180A3D6C0
	public bool HasLoadouts() { }

	// RVA: 0xA3CAE0 Offset: 0xA3B0E0 VA: 0x180A3CAE0
	public int GetNumTeams() { }

	// RVA: 0xA3D0C0 Offset: 0xA3B6C0 VA: 0x180A3D0C0
	public int GetTeamScore(int teamIndex) { }

	// RVA: 0xA3E970 Offset: 0xA3CF70 VA: 0x180A3E970
	public static void SetActiveGameMode(BaseGameMode newActive, bool serverside) { }

	// RVA: 0xA3C950 Offset: 0xA3AF50 VA: 0x180A3C950
	public static BaseGameMode GetActiveGameMode(bool serverside) { }

	// RVA: 0xA3DFE0 Offset: 0xA3C5E0 VA: 0x180A3DFE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60 Slot: 136
	public virtual bool InWarmup() { }

	// RVA: 0x50CC40 Offset: 0x50B240 VA: 0x18050CC40 Slot: 137
	public virtual bool IsWaitingForPlayers() { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0 Slot: 138
	public virtual bool IsMatchOver() { }

	// RVA: 0xA3DF10 Offset: 0xA3C510 VA: 0x180A3DF10 Slot: 139
	public virtual bool IsMatchActive() { }

	// RVA: 0xA3D9A0 Offset: 0xA3BFA0 VA: 0x180A3D9A0 Slot: 28
	public override void InitShared() { }

	// RVA: 0xA3C550 Offset: 0xA3AB50 VA: 0x180A3C550 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xA3E040 Offset: 0xA3C640 VA: 0x180A3E040 Slot: 140
	protected virtual void OnCreated() { }

	// RVA: 0xA3C4E0 Offset: 0xA3AAE0 VA: 0x180A3C4E0
	public void DelayedRespawn() { }

	// RVA: 0xA3C840 Offset: 0xA3AE40 VA: 0x180A3C840
	public void DoRespawn() { }

	// RVA: 0xA3E5D0 Offset: 0xA3CBD0 VA: 0x180A3E5D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xA3BE40 Offset: 0xA3A440 VA: 0x180A3BE40 Slot: 141
	protected virtual void ClientWarmupStart() { }

	// RVA: 0xA3BD30 Offset: 0xA3A330 VA: 0x180A3BD30 Slot: 142
	protected virtual void ClientMatchEnd() { }

	// RVA: 0xA3BE20 Offset: 0xA3A420 VA: 0x180A3BE20 Slot: 143
	protected virtual void ClientMatchStart() { }

	// RVA: 0xA3D130 Offset: 0xA3B730 VA: 0x180A3D130 Slot: 144
	public virtual SoundDefinition GetWarmupMusic() { }

	// RVA: 0xA3C9C0 Offset: 0xA3AFC0 VA: 0x180A3C9C0 Slot: 145
	public virtual SoundDefinition GetMatchEndMusic() { }

	// RVA: 0xA3EC90 Offset: 0xA3D290 VA: 0x180A3EC90
	public float TimeUntilWarmupEnds() { }

	// RVA: 0xA3EBC0 Offset: 0xA3D1C0 VA: 0x180A3EBC0
	public float TimeUntilMatchResets() { }

	// RVA: 0xA3EAF0 Offset: 0xA3D0F0 VA: 0x180A3EAF0
	public float TimeUntilMatchEnds() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3E790 Offset: 0xA3CD90 VA: 0x180A3E790
	public void RPC_ScoreSplash(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA3EDF0 Offset: 0xA3D3F0 VA: 0x180A3EDF0
	public void .ctor() { }

	// RVA: 0xA3ED60 Offset: 0xA3D360 VA: 0x180A3ED60
	private static void .cctor() { }

}

public class BaseGameMode.GameModeTeam // TypeDefIndex: 8518
{	// Fields
	public string name; // 0x10
	public PlayerInventoryProperties[] teamloadouts; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

