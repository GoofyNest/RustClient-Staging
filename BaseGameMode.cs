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

	// RVA: 0xA3DDF0 Offset: 0xA3C3F0 VA: 0x180A3DDF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA3C6F0 Offset: 0xA3ACF0 VA: 0x180A3C6F0
	public GameMode GetGameScores() { }

	// RVA: 0xA3E600 Offset: 0xA3CC00 VA: 0x180A3E600
	public int ScoreColumnIndex(string scoreName) { }

	// RVA: 0xA3D480 Offset: 0xA3BA80 VA: 0x180A3D480
	public void InitScores() { }

	// RVA: 0xA3BC70 Offset: 0xA3A270 VA: 0x180A3BC70
	public void CopyGameModeScores(GameMode from, GameMode to) { }

	// RVA: 0xA3CA60 Offset: 0xA3B060 VA: 0x180A3CA60
	public GameMode.PlayerScore GetPlayerScoreForPlayer(BasePlayer player) { }

	// RVA: 0xA3CCF0 Offset: 0xA3B2F0 VA: 0x180A3CCF0
	public int GetScoreIndexByName(string name) { }

	// RVA: 0xA3DA00 Offset: 0xA3C000 VA: 0x180A3DA00 Slot: 131
	public virtual bool IsDraw() { }

	// RVA: 0xA3CED0 Offset: 0xA3B4D0 VA: 0x180A3CED0 Slot: 132
	public virtual string GetWinnerName() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 133
	public virtual int GetPlayerTeamPosition(BasePlayer player) { }

	// RVA: 0xA3C850 Offset: 0xA3AE50 VA: 0x180A3C850 Slot: 134
	public virtual int GetPlayerRank(BasePlayer player) { }

	// RVA: 0xA3D180 Offset: 0xA3B780 VA: 0x180A3D180
	public int GetWinningTeamIndex() { }

	// RVA: 0xA3C3A0 Offset: 0xA3A9A0 VA: 0x180A3C3A0 Slot: 135
	public virtual bool DidPlayerWin(BasePlayer player) { }

	// RVA: 0xA3DCC0 Offset: 0xA3C2C0 VA: 0x180A3DCC0
	public bool IsTeamGame() { }

	// RVA: 0xA3DCF0 Offset: 0xA3C2F0 VA: 0x180A3DCF0
	public bool KeepScores() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3EC40 Offset: 0xA3D240 VA: 0x180A3EC40
	public static void add_GameModeChanged(Action<BaseGameMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3ED30 Offset: 0xA3D330 VA: 0x180A3ED30
	public static void remove_GameModeChanged(Action<BaseGameMode> value) { }

	// RVA: 0xA3D280 Offset: 0xA3B880 VA: 0x180A3D280
	public bool HasAnyGameModeTag(string[] tags) { }

	// RVA: 0xA3D350 Offset: 0xA3B950 VA: 0x180A3D350
	public bool HasGameModeTag(string tag) { }

	// RVA: 0xA3BA60 Offset: 0xA3A060 VA: 0x180A3BA60
	public bool AllowsSleeping() { }

	// RVA: 0xA3D400 Offset: 0xA3BA00 VA: 0x180A3D400
	public bool HasLoadouts() { }

	// RVA: 0xA3C820 Offset: 0xA3AE20 VA: 0x180A3C820
	public int GetNumTeams() { }

	// RVA: 0xA3CE00 Offset: 0xA3B400 VA: 0x180A3CE00
	public int GetTeamScore(int teamIndex) { }

	// RVA: 0xA3E6B0 Offset: 0xA3CCB0 VA: 0x180A3E6B0
	public static void SetActiveGameMode(BaseGameMode newActive, bool serverside) { }

	// RVA: 0xA3C690 Offset: 0xA3AC90 VA: 0x180A3C690
	public static BaseGameMode GetActiveGameMode(bool serverside) { }

	// RVA: 0xA3DD20 Offset: 0xA3C320 VA: 0x180A3DD20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60 Slot: 136
	public virtual bool InWarmup() { }

	// RVA: 0x50CC40 Offset: 0x50B240 VA: 0x18050CC40 Slot: 137
	public virtual bool IsWaitingForPlayers() { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0 Slot: 138
	public virtual bool IsMatchOver() { }

	// RVA: 0xA3DC50 Offset: 0xA3C250 VA: 0x180A3DC50 Slot: 139
	public virtual bool IsMatchActive() { }

	// RVA: 0xA3D6E0 Offset: 0xA3BCE0 VA: 0x180A3D6E0 Slot: 28
	public override void InitShared() { }

	// RVA: 0xA3C290 Offset: 0xA3A890 VA: 0x180A3C290 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xA3DD80 Offset: 0xA3C380 VA: 0x180A3DD80 Slot: 140
	protected virtual void OnCreated() { }

	// RVA: 0xA3C220 Offset: 0xA3A820 VA: 0x180A3C220
	public void DelayedRespawn() { }

	// RVA: 0xA3C580 Offset: 0xA3AB80 VA: 0x180A3C580
	public void DoRespawn() { }

	// RVA: 0xA3E310 Offset: 0xA3C910 VA: 0x180A3E310 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xA3BB80 Offset: 0xA3A180 VA: 0x180A3BB80 Slot: 141
	protected virtual void ClientWarmupStart() { }

	// RVA: 0xA3BA70 Offset: 0xA3A070 VA: 0x180A3BA70 Slot: 142
	protected virtual void ClientMatchEnd() { }

	// RVA: 0xA3BB60 Offset: 0xA3A160 VA: 0x180A3BB60 Slot: 143
	protected virtual void ClientMatchStart() { }

	// RVA: 0xA3CE70 Offset: 0xA3B470 VA: 0x180A3CE70 Slot: 144
	public virtual SoundDefinition GetWarmupMusic() { }

	// RVA: 0xA3C700 Offset: 0xA3AD00 VA: 0x180A3C700 Slot: 145
	public virtual SoundDefinition GetMatchEndMusic() { }

	// RVA: 0xA3E9D0 Offset: 0xA3CFD0 VA: 0x180A3E9D0
	public float TimeUntilWarmupEnds() { }

	// RVA: 0xA3E900 Offset: 0xA3CF00 VA: 0x180A3E900
	public float TimeUntilMatchResets() { }

	// RVA: 0xA3E830 Offset: 0xA3CE30 VA: 0x180A3E830
	public float TimeUntilMatchEnds() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3E4D0 Offset: 0xA3CAD0 VA: 0x180A3E4D0
	public void RPC_ScoreSplash(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA3EB30 Offset: 0xA3D130 VA: 0x180A3EB30
	public void .ctor() { }

	// RVA: 0xA3EAA0 Offset: 0xA3D0A0 VA: 0x180A3EAA0
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

