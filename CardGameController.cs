public abstract class CardGameController : IDisposable // TypeDefIndex: 12008
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardGameController.CardGameState <State>k__BackingField; // 0x10
	public const int IDLE_KICK_SECONDS = 600;
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardTable <Owner>k__BackingField; // 0x18
	protected CardPlayerData[] playerData; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardTable.WinnerBreakdown <winnerInfo>k__BackingField; // 0x28
	protected CardTable.CardList localPlayerCards; // 0x30
	private CardGameSounds _sounds; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TimeUntil <TimeUntilTurnEnds>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public CardGameController.CardGameState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_State(CardGameController.CardGameState value) { }

	// RVA: 0x8C0BC0 Offset: 0x8BF1C0 VA: 0x1808C0BC0
	public bool get_HasGameInProgress() { }

	// RVA: 0x8C0BD0 Offset: 0x8BF1D0 VA: 0x1808C0BD0
	public bool get_HasRoundInProgress() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MinPlayers();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_MinBuyIn();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_MaxBuyIn();

	// RVA: 0x8C0BE0 Offset: 0x8BF1E0 VA: 0x1808C0BE0 Slot: 8
	public virtual float get_MaxTurnTime() { }

	// RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0 Slot: 9
	public virtual int get_TimeBetweenRounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	protected CardTable get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Owner(CardTable value) { }

	// RVA: 0x8C0BF0 Offset: 0x8BF1F0 VA: 0x1808C0BF0
	protected int get_ScrapItemID() { }

	// RVA: 0x7A8A80 Offset: 0x7A7080 VA: 0x1807A8A80
	protected bool get_IsServer() { }

	// RVA: 0x7A8A60 Offset: 0x7A7060 VA: 0x1807A8A60
	protected bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public CardTable.WinnerBreakdown get_winnerInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	private void set_winnerInfo(CardTable.WinnerBreakdown value) { }

	// RVA: 0x8C08C0 Offset: 0x8BEEC0 VA: 0x1808C08C0
	public void .ctor(CardTable owner) { }

	// RVA: 0x8BF5B0 Offset: 0x8BDBB0 VA: 0x1808BF5B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x8BFE40 Offset: 0x8BE440 VA: 0x1808BFE40
	public int NumPlayersAllowedToPlay(CardPlayerData ignore) { }

	// RVA: 0x8C0360 Offset: 0x8BE960 VA: 0x1808C0360
	public int RelToAbsIndex(int relIndex, bool includeFolded) { }

	// RVA: 0x8BF6D0 Offset: 0x8BDCD0 VA: 0x1808BF6D0
	public int GameToRoundIndex(int gameRelIndex) { }

	// RVA: 0x8BFF50 Offset: 0x8BE550 VA: 0x1808BFF50
	public int NumPlayersInGame() { }

	// RVA: 0x8BFEE0 Offset: 0x8BE4E0 VA: 0x1808BFEE0
	public int NumPlayersInCurrentRound() { }

	// RVA: 0x8BFDF0 Offset: 0x8BE3F0 VA: 0x1808BFDF0
	public int MaxPlayersAtTable() { }

	// RVA: 0x8C0220 Offset: 0x8BE820 VA: 0x1808C0220
	public bool PlayerIsInGame(BasePlayer player) { }

	// RVA: 0x8BF900 Offset: 0x8BDF00 VA: 0x1808BF900
	public bool IsAtTable(BasePlayer player) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public virtual List<PlayingCard> GetTableCards() { }

	// RVA: 0x8C0540 Offset: 0x8BEB40 VA: 0x1808C0540
	public void StartTurnTimer(float turnTime) { }

	// RVA: 0x8BF9C0 Offset: 0x8BDFC0 VA: 0x1808BF9C0
	private bool IsAtTable(ulong userID) { }

	// RVA: 0x8BF8C0 Offset: 0x8BDEC0 VA: 0x1808BF8C0
	public int GetScrapInPot() { }

	// RVA: 0x8C0610 Offset: 0x8BEC10 VA: 0x1808C0610
	public bool TryGetCardPlayerData(int index, out CardPlayerData cardPlayer) { }

	// RVA: 0x8C0590 Offset: 0x8BEB90 VA: 0x1808C0590
	public bool TryGetCardPlayerData(ulong forPlayer, out CardPlayerData cardPlayer) { }

	// RVA: 0x8C0670 Offset: 0x8BEC70 VA: 0x1808C0670
	public bool TryGetCardPlayerData(BasePlayer forPlayer, out CardPlayerData cardPlayer) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool IsAllowedToPlay(CardPlayerData cpd);

	// RVA: 0x8BF110 Offset: 0x8BD710 VA: 0x1808BF110
	protected void ClearWinnerInfo() { }

	// RVA: 0x8C0C10 Offset: 0x8BF210 VA: 0x1808C0C10
	private CardGameSounds get_Sounds() { }

	// RVA: 0x8C0B70 Offset: 0x8BF170 VA: 0x1808C0B70
	public bool get_GameWon() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public TimeUntil get_TimeUntilTurnEnds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	private void set_TimeUntilTurnEnds(TimeUntil value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_ClientScrapInPot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8C0D00 Offset: 0x8BF300 VA: 0x1808C0D00
	private void set_ClientScrapInPot(int value) { }

	// RVA: 0x8BFBC0 Offset: 0x8BE1C0 VA: 0x1808BFBC0 Slot: 12
	public virtual void Load(CardTable syncData) { }

	// RVA: 0x8C02D0 Offset: 0x8BE8D0 VA: 0x1808C02D0
	public void ReceiveCardsForLocalPlayer(CardTable.CardList cardList) { }

	// RVA: 0x8BF380 Offset: 0x8BD980 VA: 0x1808BF380
	private void CopyLocalPlayerCardData(bool clearIfNotInGame) { }

	// RVA: 0x8C0700 Offset: 0x8BED00 VA: 0x1808C0700
	public bool TryGetLocalCardPlayerData(out CardPlayerData cardPlayer) { }

	// RVA: 0x8BFA70 Offset: 0x8BE070 VA: 0x1808BFA70
	public bool IsLocalPlayer(CardPlayerData cardPlayer) { }

	// RVA: 0x8BF890 Offset: 0x8BDE90 VA: 0x1808BF890
	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs);

	// RVA: 0x8BFFC0 Offset: 0x8BE5C0 VA: 0x1808BFFC0
	public void OnWinnersDeclared(CardTable.WinnerBreakdown wi) { }

	// RVA: 0x8BF270 Offset: 0x8BD870 VA: 0x1808BF270
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

	// RVA: 0x8D98B0 Offset: 0x8D7EB0 VA: 0x1808D98B0
	internal bool <PlayerIsInGame>b__0(CardPlayerData data) { }

}

private sealed class CardGameController.<>c__DisplayClass48_0 // TypeDefIndex: 12011
{	// Fields
	public ulong userID; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D98F0 Offset: 0x8D7EF0 VA: 0x1808D98F0
	internal bool <IsAtTable>b__0(CardPlayerData data) { }

}

