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

	// RVA: 0x8D9540 Offset: 0x8D7B40 VA: 0x1808D9540 Slot: 6
	public override int get_MinBuyIn() { }

	// RVA: 0x8D9530 Offset: 0x8D7B30 VA: 0x1808D9530 Slot: 7
	public override int get_MaxBuyIn() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 5
	public override int get_MinPlayers() { }

	// RVA: 0x8D94A0 Offset: 0x8D7AA0 VA: 0x1808D94A0
	public void .ctor(CardTable owner) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	public TexasHoldEmController.PokerInputOption get_LastAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9560 Offset: 0x8D7B60 VA: 0x1808D9560
	private void set_LastAction(TexasHoldEmController.PokerInputOption value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public ulong get_LastActionTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9550 Offset: 0x8D7B50 VA: 0x1808D9550
	private void set_LastActionTarget(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	public int get_LastActionValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	private void set_LastActionValue(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574320 Offset: 0x572920 VA: 0x180574320
	public int get_BiggestRaiseThisTurn() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	private void set_BiggestRaiseThisTurn(int value) { }

	// RVA: 0x8D7CE0 Offset: 0x8D62E0 VA: 0x1808D7CE0
	public TexasHoldEmController.Playability GetPlayabilityStatus(CardPlayerData cpd) { }

	// RVA: 0x8D79D0 Offset: 0x8D5FD0 VA: 0x1808D79D0
	public int GetCurrentBet() { }

	// RVA: 0x8D8340 Offset: 0x8D6940 VA: 0x1808D8340 Slot: 11
	public override bool IsAllowedToPlay(CardPlayerData cpd) { }

	// RVA: 0x8D90D0 Offset: 0x8D76D0 VA: 0x1808D90D0
	public bool TryGetActivePlayer(out CardPlayerData activePlayer) { }

	// RVA: 0x8D91A0 Offset: 0x8D77A0 VA: 0x1808D91A0
	public bool TryGetDealer(out CardPlayerData dealer) { }

	// RVA: 0x8D91C0 Offset: 0x8D77C0 VA: 0x1808D91C0
	public bool TryGetSmallBlind(out CardPlayerData smallBlind) { }

	// RVA: 0x8D90F0 Offset: 0x8D76F0 VA: 0x1808D90F0
	public bool TryGetBigBlind(out CardPlayerData bigBlind) { }

	// RVA: 0x8D7B40 Offset: 0x8D6140 VA: 0x1808D7B40
	public int GetFirstPlayerRelIndex(bool startOfRound) { }

	// RVA: 0x8D8F80 Offset: 0x8D7580 VA: 0x1808D8F80
	private bool ToCardPlayerData(int relIndex, bool includeFolded, out CardPlayerData result) { }

	// RVA: 0x8D76B0 Offset: 0x8D5CB0 VA: 0x1808D76B0
	public static ushort EvaluatePokerHand(List<PlayingCard> cards) { }

	// RVA: 0x8D7AA0 Offset: 0x8D60A0 VA: 0x1808D7AA0
	public int GetCurrentMinRaise(CardPlayerData playerData) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 10
	public override List<PlayingCard> GetTableCards() { }

	// RVA: 0x8D8360 Offset: 0x8D6960 VA: 0x1808D8360 Slot: 12
	public override void Load(CardTable syncData) { }

	// RVA: 0x8D7BE0 Offset: 0x8D61E0 VA: 0x1808D7BE0
	public TexasHoldEmController.Playability GetLocalPlayerPlayabilityStatus() { }

	// RVA: 0x8D8700 Offset: 0x8D6D00 VA: 0x1808D8700 Slot: 13
	protected override void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs) { }

	// RVA: 0x8D86E0 Offset: 0x8D6CE0 VA: 0x1808D86E0
	private void OnInputFromUI(TexasHoldEmController.PokerInputOption input, int value = 0) { }

	// RVA: 0x8D78B0 Offset: 0x8D5EB0 VA: 0x1808D78B0
	public int GetCostOfInput(TexasHoldEmController.PokerInputOption option, CardPlayerData data) { }

	// RVA: 0x8D8060 Offset: 0x8D6660 VA: 0x1808D8060
	public bool IsAPrimaryWinner(ulong playerId) { }

	// RVA: 0x8D81D0 Offset: 0x8D67D0 VA: 0x1808D81D0
	public bool IsAWinner(ulong playerId) { }

	// RVA: 0x8D7DA0 Offset: 0x8D63A0 VA: 0x1808D7DA0
	public bool HasPrimaryWinners() { }

	// RVA: 0x8D85B0 Offset: 0x8D6BB0 VA: 0x1808D85B0
	public int NumPrimaryWinners() { }

	// RVA: 0x8D7F00 Offset: 0x8D6500 VA: 0x1808D7F00
	public bool HasSecondaryWinners() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9300 Offset: 0x8D7900 VA: 0x1808D9300
	private void <SubGetAvailableInputs>b__46_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9270 Offset: 0x8D7870 VA: 0x1808D9270
	private void <SubGetAvailableInputs>b__46_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D92A0 Offset: 0x8D78A0 VA: 0x1808D92A0
	private void <SubGetAvailableInputs>b__46_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9330 Offset: 0x8D7930 VA: 0x1808D9330
	private void <SubGetAvailableInputs>b__46_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D93D0 Offset: 0x8D79D0 VA: 0x1808D93D0
	private void <SubGetAvailableInputs>b__46_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9470 Offset: 0x8D7A70 VA: 0x1808D9470
	private void <SubGetAvailableInputs>b__46_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D92D0 Offset: 0x8D78D0 VA: 0x1808D92D0
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

