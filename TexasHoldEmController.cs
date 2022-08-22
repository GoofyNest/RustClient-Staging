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

	// RVA: 0x8D8F20 Offset: 0x8D7520 VA: 0x1808D8F20 Slot: 6
	public override int get_MinBuyIn() { }

	// RVA: 0x8D8F10 Offset: 0x8D7510 VA: 0x1808D8F10 Slot: 7
	public override int get_MaxBuyIn() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 5
	public override int get_MinPlayers() { }

	// RVA: 0x8D8E80 Offset: 0x8D7480 VA: 0x1808D8E80
	public void .ctor(CardTable owner) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	public TexasHoldEmController.PokerInputOption get_LastAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8F40 Offset: 0x8D7540 VA: 0x1808D8F40
	private void set_LastAction(TexasHoldEmController.PokerInputOption value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public ulong get_LastActionTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8F30 Offset: 0x8D7530 VA: 0x1808D8F30
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

	// RVA: 0x8D76C0 Offset: 0x8D5CC0 VA: 0x1808D76C0
	public TexasHoldEmController.Playability GetPlayabilityStatus(CardPlayerData cpd) { }

	// RVA: 0x8D73B0 Offset: 0x8D59B0 VA: 0x1808D73B0
	public int GetCurrentBet() { }

	// RVA: 0x8D7D20 Offset: 0x8D6320 VA: 0x1808D7D20 Slot: 11
	public override bool IsAllowedToPlay(CardPlayerData cpd) { }

	// RVA: 0x8D8AB0 Offset: 0x8D70B0 VA: 0x1808D8AB0
	public bool TryGetActivePlayer(out CardPlayerData activePlayer) { }

	// RVA: 0x8D8B80 Offset: 0x8D7180 VA: 0x1808D8B80
	public bool TryGetDealer(out CardPlayerData dealer) { }

	// RVA: 0x8D8BA0 Offset: 0x8D71A0 VA: 0x1808D8BA0
	public bool TryGetSmallBlind(out CardPlayerData smallBlind) { }

	// RVA: 0x8D8AD0 Offset: 0x8D70D0 VA: 0x1808D8AD0
	public bool TryGetBigBlind(out CardPlayerData bigBlind) { }

	// RVA: 0x8D7520 Offset: 0x8D5B20 VA: 0x1808D7520
	public int GetFirstPlayerRelIndex(bool startOfRound) { }

	// RVA: 0x8D8960 Offset: 0x8D6F60 VA: 0x1808D8960
	private bool ToCardPlayerData(int relIndex, bool includeFolded, out CardPlayerData result) { }

	// RVA: 0x8D7090 Offset: 0x8D5690 VA: 0x1808D7090
	public static ushort EvaluatePokerHand(List<PlayingCard> cards) { }

	// RVA: 0x8D7480 Offset: 0x8D5A80 VA: 0x1808D7480
	public int GetCurrentMinRaise(CardPlayerData playerData) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 10
	public override List<PlayingCard> GetTableCards() { }

	// RVA: 0x8D7D40 Offset: 0x8D6340 VA: 0x1808D7D40 Slot: 12
	public override void Load(CardTable syncData) { }

	// RVA: 0x8D75C0 Offset: 0x8D5BC0 VA: 0x1808D75C0
	public TexasHoldEmController.Playability GetLocalPlayerPlayabilityStatus() { }

	// RVA: 0x8D80E0 Offset: 0x8D66E0 VA: 0x1808D80E0 Slot: 13
	protected override void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs) { }

	// RVA: 0x8D80C0 Offset: 0x8D66C0 VA: 0x1808D80C0
	private void OnInputFromUI(TexasHoldEmController.PokerInputOption input, int value = 0) { }

	// RVA: 0x8D7290 Offset: 0x8D5890 VA: 0x1808D7290
	public int GetCostOfInput(TexasHoldEmController.PokerInputOption option, CardPlayerData data) { }

	// RVA: 0x8D7A40 Offset: 0x8D6040 VA: 0x1808D7A40
	public bool IsAPrimaryWinner(ulong playerId) { }

	// RVA: 0x8D7BB0 Offset: 0x8D61B0 VA: 0x1808D7BB0
	public bool IsAWinner(ulong playerId) { }

	// RVA: 0x8D7780 Offset: 0x8D5D80 VA: 0x1808D7780
	public bool HasPrimaryWinners() { }

	// RVA: 0x8D7F90 Offset: 0x8D6590 VA: 0x1808D7F90
	public int NumPrimaryWinners() { }

	// RVA: 0x8D78E0 Offset: 0x8D5EE0 VA: 0x1808D78E0
	public bool HasSecondaryWinners() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8CE0 Offset: 0x8D72E0 VA: 0x1808D8CE0
	private void <SubGetAvailableInputs>b__46_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8C50 Offset: 0x8D7250 VA: 0x1808D8C50
	private void <SubGetAvailableInputs>b__46_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8C80 Offset: 0x8D7280 VA: 0x1808D8C80
	private void <SubGetAvailableInputs>b__46_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8D10 Offset: 0x8D7310 VA: 0x1808D8D10
	private void <SubGetAvailableInputs>b__46_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8DB0 Offset: 0x8D73B0 VA: 0x1808D8DB0
	private void <SubGetAvailableInputs>b__46_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8E50 Offset: 0x8D7450 VA: 0x1808D8E50
	private void <SubGetAvailableInputs>b__46_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8CB0 Offset: 0x8D72B0 VA: 0x1808D8CB0
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

