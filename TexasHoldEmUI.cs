public class TexasHoldEmUI : MonoBehaviour, CardTableUI.ICardGameSubUI // TypeDefIndex: 10886
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Image[] holeCardImages; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x852D0 Offset: 0x846D0 VA: 0x1800852D0
	[SerializeField] // RVA: 0x852D0 Offset: 0x846D0 VA: 0x1800852D0
	private Image[] communityCardImages; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RustText potText; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TexasHoldEmPlayerWidget[] playerWidgets; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject raiseRoot; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseNotEnoughBuyIn; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseTooMuchBuyIn; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseYouWinTheRound; // 0x50
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseRoundWinner; // 0x58
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseRoundWinners; // 0x60
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseScrapWon; // 0x68
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseScrapReturned; // 0x70
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseWinningHand; // 0x78
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseRoyalFlush; // 0x80
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseStraightFlush; // 0x88
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseFourOfAKind; // 0x90
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseFullHouse; // 0x98
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseFlush; // 0xA0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseStraight; // 0xA8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseThreeOfAKind; // 0xB0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseTwoPair; // 0xB8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phrasePair; // 0xC0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseHighCard; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <DynamicBetAmount>k__BackingField; // 0xD0
	private ulong lastActionId; // 0xD8
	private int lastPotUpdate; // 0xE0
	private List<PlayingCard> localPlayerCards; // 0xE8

	// Properties
	public int DynamicBetAmount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x887950 Offset: 0x885F50 VA: 0x180887950 Slot: 4
	public int get_DynamicBetAmount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7425E0 Offset: 0x740BE0 VA: 0x1807425E0
	private void set_DynamicBetAmount(int value) { }

	// RVA: 0x886D30 Offset: 0x885330 VA: 0x180886D30 Slot: 5
	public void UpdateInGameUI(CardTableUI ui, CardGameController game) { }

	// RVA: 0x885F90 Offset: 0x884590 VA: 0x180885F90 Slot: 6
	public string GetSecondaryInfo(CardTableUI ui, CardGameController game, out CardTableUI.InfoTextUI.Attitude attitude) { }

	// RVA: 0x886CF0 Offset: 0x8852F0 VA: 0x180886CF0 Slot: 7
	public void UpdateInGameUI_NoPlayer(CardTableUI ui) { }

	// RVA: 0x886A40 Offset: 0x885040 VA: 0x180886A40
	private string GetWinnerNameFromID(ulong playerID) { }

	// RVA: 0x886BC0 Offset: 0x8851C0 VA: 0x180886BC0
	private void PopulateCards(List<PlayingCard> cards, Image[] slots, CardTableUI ui) { }

	// RVA: 0x886B20 Offset: 0x885120 VA: 0x180886B20
	public Translate.Phrase PokerResultToPhrase(PokerLib.PokerResult result) { }

	// RVA: 0x8878E0 Offset: 0x885EE0 VA: 0x1808878E0
	public void .ctor() { }

}

private sealed class TexasHoldEmUI.<>c // TypeDefIndex: 10887
{	// Fields
	public static readonly TexasHoldEmUI.<>c <>9; // 0x0
	public static Predicate<CardTableUI.KeycodeWithAction> <>9__30_0; // 0x8

	// Methods

	// RVA: 0x8904C0 Offset: 0x88EAC0 VA: 0x1808904C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x88F350 Offset: 0x88D950 VA: 0x18088F350
	internal bool <UpdateInGameUI>b__30_0(CardTableUI.KeycodeWithAction p) { }

}

