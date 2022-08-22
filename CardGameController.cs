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
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	private void set_State(CardGameController.CardGameState value) { }

	// RVA: 0x8C11E0 Offset: 0x8BF7E0 VA: 0x1808C11E0
	public bool get_HasGameInProgress() { }

	// RVA: 0x8C11F0 Offset: 0x8BF7F0 VA: 0x1808C11F0
	public bool get_HasRoundInProgress() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MinPlayers();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_MinBuyIn();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_MaxBuyIn();

	// RVA: 0x8C1200 Offset: 0x8BF800 VA: 0x1808C1200 Slot: 8
	public virtual float get_MaxTurnTime() { }

	// RVA: 0x8C1310 Offset: 0x8BF910 VA: 0x1808C1310 Slot: 9
	public virtual int get_TimeBetweenRounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	protected CardTable get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Owner(CardTable value) { }

	// RVA: 0x8C1210 Offset: 0x8BF810 VA: 0x1808C1210
	protected int get_ScrapItemID() { }

	// RVA: 0x7C6F90 Offset: 0x7C5590 VA: 0x1807C6F90
	protected bool get_IsServer() { }

	// RVA: 0x7C6F70 Offset: 0x7C5570 VA: 0x1807C6F70
	protected bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public CardTable.WinnerBreakdown get_winnerInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	private void set_winnerInfo(CardTable.WinnerBreakdown value) { }

	// RVA: 0x8C0EE0 Offset: 0x8BF4E0 VA: 0x1808C0EE0
	public void .ctor(CardTable owner) { }

	// RVA: 0x8BFBD0 Offset: 0x8BE1D0 VA: 0x1808BFBD0 Slot: 4
	public void Dispose() { }

	// RVA: 0x8C0460 Offset: 0x8BEA60 VA: 0x1808C0460
	public int NumPlayersAllowedToPlay(CardPlayerData ignore) { }

	// RVA: 0x8C0980 Offset: 0x8BEF80 VA: 0x1808C0980
	public int RelToAbsIndex(int relIndex, bool includeFolded) { }

	// RVA: 0x8BFCF0 Offset: 0x8BE2F0 VA: 0x1808BFCF0
	public int GameToRoundIndex(int gameRelIndex) { }

	// RVA: 0x8C0570 Offset: 0x8BEB70 VA: 0x1808C0570
	public int NumPlayersInGame() { }

	// RVA: 0x8C0500 Offset: 0x8BEB00 VA: 0x1808C0500
	public int NumPlayersInCurrentRound() { }

	// RVA: 0x8C0410 Offset: 0x8BEA10 VA: 0x1808C0410
	public int MaxPlayersAtTable() { }

	// RVA: 0x8C0840 Offset: 0x8BEE40 VA: 0x1808C0840
	public bool PlayerIsInGame(BasePlayer player) { }

	// RVA: 0x8BFF20 Offset: 0x8BE520 VA: 0x1808BFF20
	public bool IsAtTable(BasePlayer player) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public virtual List<PlayingCard> GetTableCards() { }

	// RVA: 0x8C0B60 Offset: 0x8BF160 VA: 0x1808C0B60
	public void StartTurnTimer(float turnTime) { }

	// RVA: 0x8BFFE0 Offset: 0x8BE5E0 VA: 0x1808BFFE0
	private bool IsAtTable(ulong userID) { }

	// RVA: 0x8BFEE0 Offset: 0x8BE4E0 VA: 0x1808BFEE0
	public int GetScrapInPot() { }

	// RVA: 0x8C0C30 Offset: 0x8BF230 VA: 0x1808C0C30
	public bool TryGetCardPlayerData(int index, out CardPlayerData cardPlayer) { }

	// RVA: 0x8C0BB0 Offset: 0x8BF1B0 VA: 0x1808C0BB0
	public bool TryGetCardPlayerData(ulong forPlayer, out CardPlayerData cardPlayer) { }

	// RVA: 0x8C0C90 Offset: 0x8BF290 VA: 0x1808C0C90
	public bool TryGetCardPlayerData(BasePlayer forPlayer, out CardPlayerData cardPlayer) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool IsAllowedToPlay(CardPlayerData cpd);

	// RVA: 0x8BF730 Offset: 0x8BDD30 VA: 0x1808BF730
	protected void ClearWinnerInfo() { }

	// RVA: 0x8C1230 Offset: 0x8BF830 VA: 0x1808C1230
	private CardGameSounds get_Sounds() { }

	// RVA: 0x8C1190 Offset: 0x8BF790 VA: 0x1808C1190
	public bool get_GameWon() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public TimeUntil get_TimeUntilTurnEnds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6840F0 Offset: 0x6826F0 VA: 0x1806840F0
	private void set_TimeUntilTurnEnds(TimeUntil value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public int get_ClientScrapInPot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1320 Offset: 0x8BF920 VA: 0x1808C1320
	private void set_ClientScrapInPot(int value) { }

	// RVA: 0x8C01E0 Offset: 0x8BE7E0 VA: 0x1808C01E0 Slot: 12
	public virtual void Load(CardTable syncData) { }

	// RVA: 0x8C08F0 Offset: 0x8BEEF0 VA: 0x1808C08F0
	public void ReceiveCardsForLocalPlayer(CardTable.CardList cardList) { }

	// RVA: 0x8BF9A0 Offset: 0x8BDFA0 VA: 0x1808BF9A0
	private void CopyLocalPlayerCardData(bool clearIfNotInGame) { }

	// RVA: 0x8C0D20 Offset: 0x8BF320 VA: 0x1808C0D20
	public bool TryGetLocalCardPlayerData(out CardPlayerData cardPlayer) { }

	// RVA: 0x8C0090 Offset: 0x8BE690 VA: 0x1808C0090
	public bool IsLocalPlayer(CardPlayerData cardPlayer) { }

	// RVA: 0x8BFEB0 Offset: 0x8BE4B0 VA: 0x1808BFEB0
	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs);

	// RVA: 0x8C05E0 Offset: 0x8BEBE0 VA: 0x1808C05E0
	public void OnWinnersDeclared(CardTable.WinnerBreakdown wi) { }

	// RVA: 0x8BF890 Offset: 0x8BDE90 VA: 0x1808BF890
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

	// RVA: 0x8D9ED0 Offset: 0x8D84D0 VA: 0x1808D9ED0
	internal bool <PlayerIsInGame>b__0(CardPlayerData data) { }

}

private sealed class CardGameController.<>c__DisplayClass48_0 // TypeDefIndex: 12011
{	// Fields
	public ulong userID; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9F10 Offset: 0x8D8510 VA: 0x1808D9F10
	internal bool <IsAtTable>b__0(CardPlayerData data) { }

}

