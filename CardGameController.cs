public abstract class CardGameController : IDisposable // TypeDefIndex: 12008
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardGameController.CardGameState <State>k__BackingField; // 0x10
	public const int IDLE_KICK_SECONDS = 600;
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardTable <Owner>k__BackingField; // 0x18
	protected CardPlayerData[] playerData; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardTable.WinnerBreakdown <winnerInfo>k__BackingField; // 0x28
	protected CardTable.CardList localPlayerCards; // 0x30
	private CardGameSounds _sounds; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TimeUntil <TimeUntilTurnEnds>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ClientScrapInPot>k__BackingField; // 0x44

	// Properties
	public CardGameController.CardGameState State { get; set; }
	public bool HasGameInProgress { get; }
	public bool HasRoundInProgress { get; }
	public abstract int MinPlayers { get; }
	public abstract int MinBuyIn { get; }
	public abstract int MaxBuyIn { get; }
	public virtual float MaxTurnTime { get; }
	public virtual int TimeBetweenRounds { get; }
	protected CardTable Owner { get; set; }
	protected int ScrapItemID { get; }
	protected bool IsServer { get; }
	protected bool IsClient { get; }
	public CardTable.WinnerBreakdown winnerInfo { get; set; }
	private CardGameSounds Sounds { get; }
	public bool GameWon { get; }
	public TimeUntil TimeUntilTurnEnds { get; set; }
	public int ClientScrapInPot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public CardGameController.CardGameState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_State(CardGameController.CardGameState value) { }

	// RVA: 0x8C0CD0 Offset: 0x8BF2D0 VA: 0x1808C0CD0
	public bool get_HasGameInProgress() { }

	// RVA: 0x8C0CE0 Offset: 0x8BF2E0 VA: 0x1808C0CE0
	public bool get_HasRoundInProgress() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MinPlayers();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_MinBuyIn();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_MaxBuyIn();

	// RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0 Slot: 8
	public virtual float get_MaxTurnTime() { }

	// RVA: 0x8C0E00 Offset: 0x8BF400 VA: 0x1808C0E00 Slot: 9
	public virtual int get_TimeBetweenRounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	protected CardTable get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Owner(CardTable value) { }

	// RVA: 0x8C0D00 Offset: 0x8BF300 VA: 0x1808C0D00
	protected int get_ScrapItemID() { }

	// RVA: 0x7A8B90 Offset: 0x7A7190 VA: 0x1807A8B90
	protected bool get_IsServer() { }

	// RVA: 0x7A8B70 Offset: 0x7A7170 VA: 0x1807A8B70
	protected bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public CardTable.WinnerBreakdown get_winnerInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	private void set_winnerInfo(CardTable.WinnerBreakdown value) { }

	// RVA: 0x8C09D0 Offset: 0x8BEFD0 VA: 0x1808C09D0
	public void .ctor(CardTable owner) { }

	// RVA: 0x8BF6C0 Offset: 0x8BDCC0 VA: 0x1808BF6C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x8BFF50 Offset: 0x8BE550 VA: 0x1808BFF50
	public int NumPlayersAllowedToPlay(CardPlayerData ignore) { }

	// RVA: 0x8C0470 Offset: 0x8BEA70 VA: 0x1808C0470
	public int RelToAbsIndex(int relIndex, bool includeFolded) { }

	// RVA: 0x8BF7E0 Offset: 0x8BDDE0 VA: 0x1808BF7E0
	public int GameToRoundIndex(int gameRelIndex) { }

	// RVA: 0x8C0060 Offset: 0x8BE660 VA: 0x1808C0060
	public int NumPlayersInGame() { }

	// RVA: 0x8BFFF0 Offset: 0x8BE5F0 VA: 0x1808BFFF0
	public int NumPlayersInCurrentRound() { }

	// RVA: 0x8BFF00 Offset: 0x8BE500 VA: 0x1808BFF00
	public int MaxPlayersAtTable() { }

	// RVA: 0x8C0330 Offset: 0x8BE930 VA: 0x1808C0330
	public bool PlayerIsInGame(BasePlayer player) { }

	// RVA: 0x8BFA10 Offset: 0x8BE010 VA: 0x1808BFA10
	public bool IsAtTable(BasePlayer player) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public virtual List<PlayingCard> GetTableCards() { }

	// RVA: 0x8C0650 Offset: 0x8BEC50 VA: 0x1808C0650
	public void StartTurnTimer(float turnTime) { }

	// RVA: 0x8BFAD0 Offset: 0x8BE0D0 VA: 0x1808BFAD0
	private bool IsAtTable(ulong userID) { }

	// RVA: 0x8BF9D0 Offset: 0x8BDFD0 VA: 0x1808BF9D0
	public int GetScrapInPot() { }

	// RVA: 0x8C0720 Offset: 0x8BED20 VA: 0x1808C0720
	public bool TryGetCardPlayerData(int index, out CardPlayerData cardPlayer) { }

	// RVA: 0x8C06A0 Offset: 0x8BECA0 VA: 0x1808C06A0
	public bool TryGetCardPlayerData(ulong forPlayer, out CardPlayerData cardPlayer) { }

	// RVA: 0x8C0780 Offset: 0x8BED80 VA: 0x1808C0780
	public bool TryGetCardPlayerData(BasePlayer forPlayer, out CardPlayerData cardPlayer) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool IsAllowedToPlay(CardPlayerData cpd);

	// RVA: 0x8BF220 Offset: 0x8BD820 VA: 0x1808BF220
	protected void ClearWinnerInfo() { }

	// RVA: 0x8C0D20 Offset: 0x8BF320 VA: 0x1808C0D20
	private CardGameSounds get_Sounds() { }

	// RVA: 0x8C0C80 Offset: 0x8BF280 VA: 0x1808C0C80
	public bool get_GameWon() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public TimeUntil get_TimeUntilTurnEnds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	private void set_TimeUntilTurnEnds(TimeUntil value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_ClientScrapInPot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C0E10 Offset: 0x8BF410 VA: 0x1808C0E10
	private void set_ClientScrapInPot(int value) { }

	// RVA: 0x8BFCD0 Offset: 0x8BE2D0 VA: 0x1808BFCD0 Slot: 12
	public virtual void Load(CardTable syncData) { }

	// RVA: 0x8C03E0 Offset: 0x8BE9E0 VA: 0x1808C03E0
	public void ReceiveCardsForLocalPlayer(CardTable.CardList cardList) { }

	// RVA: 0x8BF490 Offset: 0x8BDA90 VA: 0x1808BF490
	private void CopyLocalPlayerCardData(bool clearIfNotInGame) { }

	// RVA: 0x8C0810 Offset: 0x8BEE10 VA: 0x1808C0810
	public bool TryGetLocalCardPlayerData(out CardPlayerData cardPlayer) { }

	// RVA: 0x8BFB80 Offset: 0x8BE180 VA: 0x1808BFB80
	public bool IsLocalPlayer(CardPlayerData cardPlayer) { }

	// RVA: 0x8BF9A0 Offset: 0x8BDFA0 VA: 0x1808BF9A0
	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs);

	// RVA: 0x8C00D0 Offset: 0x8BE6D0 VA: 0x1808C00D0
	public void OnWinnersDeclared(CardTable.WinnerBreakdown wi) { }

	// RVA: 0x8BF380 Offset: 0x8BD980 VA: 0x1808BF380
	public void ClientPlaySound(CardGameSounds.SoundType type) { }

}

public enum CardGameController.CardGameState // TypeDefIndex: 12009
{	// Fields
	public int value__; // 0x0
	public const CardGameController.CardGameState NotPlaying = 0;
	public const CardGameController.CardGameState InGameBetweenRounds = 1;
	public const CardGameController.CardGameState InGameRound = 2;

}

private sealed class CardGameController.<>c__DisplayClass44_0 // TypeDefIndex: 12010
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D99C0 Offset: 0x8D7FC0 VA: 0x1808D99C0
	internal bool <PlayerIsInGame>b__0(CardPlayerData data) { }

}

private sealed class CardGameController.<>c__DisplayClass48_0 // TypeDefIndex: 12011
{	// Fields
	public ulong userID; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9A00 Offset: 0x8D8000 VA: 0x1808D9A00
	internal bool <IsAtTable>b__0(CardPlayerData data) { }

}

