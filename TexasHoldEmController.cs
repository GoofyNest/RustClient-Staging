public class TexasHoldEmController : CardGameController // TypeDefIndex: 12017
{	// Fields
	public List<PlayingCard> communityCards; // 0x48
	public const int SMALL_BLIND = 5;
	public const int BIG_BLIND = 10;
	public const string WON_HAND_STAT = "won_hand_texas_holdem";
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TexasHoldEmController.PokerInputOption <LastAction>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <LastActionTarget>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <LastActionValue>k__BackingField; // 0x60
	public const int RAISE_INCREMENTS = 5;
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <BiggestRaiseThisTurn>k__BackingField; // 0x64
	private int dealerIndex; // 0x68
	private int activePlayerIndex; // 0x6C

	// Properties
	public override int MinBuyIn { get; }
	public override int MaxBuyIn { get; }
	public override int MinPlayers { get; }
	public TexasHoldEmController.PokerInputOption LastAction { get; set; }
	public ulong LastActionTarget { get; set; }
	public int LastActionValue { get; set; }
	public int BiggestRaiseThisTurn { get; set; }

	// Methods

	// RVA: 0x8D9030 Offset: 0x8D7630 VA: 0x1808D9030 Slot: 6
	public override int get_MinBuyIn() { }

	// RVA: 0x8D9020 Offset: 0x8D7620 VA: 0x1808D9020 Slot: 7
	public override int get_MaxBuyIn() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 5
	public override int get_MinPlayers() { }

	// RVA: 0x8D8F90 Offset: 0x8D7590 VA: 0x1808D8F90
	public void .ctor(CardTable owner) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	public TexasHoldEmController.PokerInputOption get_LastAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9050 Offset: 0x8D7650 VA: 0x1808D9050
	private void set_LastAction(TexasHoldEmController.PokerInputOption value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public ulong get_LastActionTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9040 Offset: 0x8D7640 VA: 0x1808D9040
	private void set_LastActionTarget(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_LastActionValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
	private void set_LastActionValue(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public int get_BiggestRaiseThisTurn() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574420 Offset: 0x572A20 VA: 0x180574420
	private void set_BiggestRaiseThisTurn(int value) { }

	// RVA: 0x8D77D0 Offset: 0x8D5DD0 VA: 0x1808D77D0
	public TexasHoldEmController.Playability GetPlayabilityStatus(CardPlayerData cpd) { }

	// RVA: 0x8D74C0 Offset: 0x8D5AC0 VA: 0x1808D74C0
	public int GetCurrentBet() { }

	// RVA: 0x8D7E30 Offset: 0x8D6430 VA: 0x1808D7E30 Slot: 11
	public override bool IsAllowedToPlay(CardPlayerData cpd) { }

	// RVA: 0x8D8BC0 Offset: 0x8D71C0 VA: 0x1808D8BC0
	public bool TryGetActivePlayer(out CardPlayerData activePlayer) { }

	// RVA: 0x8D8C90 Offset: 0x8D7290 VA: 0x1808D8C90
	public bool TryGetDealer(out CardPlayerData dealer) { }

	// RVA: 0x8D8CB0 Offset: 0x8D72B0 VA: 0x1808D8CB0
	public bool TryGetSmallBlind(out CardPlayerData smallBlind) { }

	// RVA: 0x8D8BE0 Offset: 0x8D71E0 VA: 0x1808D8BE0
	public bool TryGetBigBlind(out CardPlayerData bigBlind) { }

	// RVA: 0x8D7630 Offset: 0x8D5C30 VA: 0x1808D7630
	public int GetFirstPlayerRelIndex(bool startOfRound) { }

	// RVA: 0x8D8A70 Offset: 0x8D7070 VA: 0x1808D8A70
	private bool ToCardPlayerData(int relIndex, bool includeFolded, out CardPlayerData result) { }

	// RVA: 0x8D71A0 Offset: 0x8D57A0 VA: 0x1808D71A0
	public static ushort EvaluatePokerHand(List<PlayingCard> cards) { }

	// RVA: 0x8D7590 Offset: 0x8D5B90 VA: 0x1808D7590
	public int GetCurrentMinRaise(CardPlayerData playerData) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 10
	public override List<PlayingCard> GetTableCards() { }

	// RVA: 0x8D7E50 Offset: 0x8D6450 VA: 0x1808D7E50 Slot: 12
	public override void Load(CardTable syncData) { }

	// RVA: 0x8D76D0 Offset: 0x8D5CD0 VA: 0x1808D76D0
	public TexasHoldEmController.Playability GetLocalPlayerPlayabilityStatus() { }

	// RVA: 0x8D81F0 Offset: 0x8D67F0 VA: 0x1808D81F0 Slot: 13
	protected override void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs) { }

	// RVA: 0x8D81D0 Offset: 0x8D67D0 VA: 0x1808D81D0
	private void OnInputFromUI(TexasHoldEmController.PokerInputOption input, int value = 0) { }

	// RVA: 0x8D73A0 Offset: 0x8D59A0 VA: 0x1808D73A0
	public int GetCostOfInput(TexasHoldEmController.PokerInputOption option, CardPlayerData data) { }

	// RVA: 0x8D7B50 Offset: 0x8D6150 VA: 0x1808D7B50
	public bool IsAPrimaryWinner(ulong playerId) { }

	// RVA: 0x8D7CC0 Offset: 0x8D62C0 VA: 0x1808D7CC0
	public bool IsAWinner(ulong playerId) { }

	// RVA: 0x8D7890 Offset: 0x8D5E90 VA: 0x1808D7890
	public bool HasPrimaryWinners() { }

	// RVA: 0x8D80A0 Offset: 0x8D66A0 VA: 0x1808D80A0
	public int NumPrimaryWinners() { }

	// RVA: 0x8D79F0 Offset: 0x8D5FF0 VA: 0x1808D79F0
	public bool HasSecondaryWinners() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8DF0 Offset: 0x8D73F0 VA: 0x1808D8DF0
	private void <SubGetAvailableInputs>b__46_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8D60 Offset: 0x8D7360 VA: 0x1808D8D60
	private void <SubGetAvailableInputs>b__46_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8D90 Offset: 0x8D7390 VA: 0x1808D8D90
	private void <SubGetAvailableInputs>b__46_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8E20 Offset: 0x8D7420 VA: 0x1808D8E20
	private void <SubGetAvailableInputs>b__46_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8EC0 Offset: 0x8D74C0 VA: 0x1808D8EC0
	private void <SubGetAvailableInputs>b__46_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8F60 Offset: 0x8D7560 VA: 0x1808D8F60
	private void <SubGetAvailableInputs>b__46_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8DC0 Offset: 0x8D73C0 VA: 0x1808D8DC0
	private void <SubGetAvailableInputs>b__46_2() { }

}

public enum TexasHoldEmController.PokerInputOption // TypeDefIndex: 12018
{	// Fields
	public int value__; // 0x0
	public const TexasHoldEmController.PokerInputOption None = 0;
	public const TexasHoldEmController.PokerInputOption Fold = 1;
	public const TexasHoldEmController.PokerInputOption Call = 2;
	public const TexasHoldEmController.PokerInputOption AllIn = 4;
	public const TexasHoldEmController.PokerInputOption Check = 8;
	public const TexasHoldEmController.PokerInputOption Raise = 16;
	public const TexasHoldEmController.PokerInputOption Bet = 32;
	public const TexasHoldEmController.PokerInputOption RevealHand = 64;

}

public enum TexasHoldEmController.Playability // TypeDefIndex: 12019
{	// Fields
	public int value__; // 0x0
	public const TexasHoldEmController.Playability OK = 0;
	public const TexasHoldEmController.Playability NoPlayer = 1;
	public const TexasHoldEmController.Playability NotEnoughBuyIn = 2;
	public const TexasHoldEmController.Playability TooMuchBuyIn = 3;
	public const TexasHoldEmController.Playability RanOutOfScrap = 4;
	public const TexasHoldEmController.Playability Idle = 5;

}

