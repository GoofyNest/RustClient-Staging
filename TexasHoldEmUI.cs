public class TexasHoldEmUI : MonoBehaviour, CardTableUI.ICardGameSubUI // TypeDefIndex: 10886
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image[] holeCardImages; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x853F0 Offset: 0x847F0 VA: 0x1800853F0
	[SerializeField] // RVA: 0x853F0 Offset: 0x847F0 VA: 0x1800853F0
	private Image[] communityCardImages; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText potText; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TexasHoldEmPlayerWidget[] playerWidgets; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject raiseRoot; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseNotEnoughBuyIn; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseTooMuchBuyIn; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseYouWinTheRound; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseRoundWinner; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseRoundWinners; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseScrapWon; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseScrapReturned; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseWinningHand; // 0x78
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseRoyalFlush; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseStraightFlush; // 0x88
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseFourOfAKind; // 0x90
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseFullHouse; // 0x98
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseFlush; // 0xA0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseStraight; // 0xA8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseThreeOfAKind; // 0xB0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseTwoPair; // 0xB8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phrasePair; // 0xC0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseHighCard; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <DynamicBetAmount>k__BackingField; // 0xD0
	private ulong lastActionId; // 0xD8
	private int lastPotUpdate; // 0xE0
	private List<PlayingCard> localPlayerCards; // 0xE8

	// Properties
	public int DynamicBetAmount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x86ADA0 Offset: 0x8693A0 VA: 0x18086ADA0 Slot: 4
	public int get_DynamicBetAmount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x742640 Offset: 0x740C40 VA: 0x180742640
	private void set_DynamicBetAmount(int value) { }

	// RVA: 0x86A180 Offset: 0x868780 VA: 0x18086A180 Slot: 5
	public void UpdateInGameUI(CardTableUI ui, CardGameController game) { }

	// RVA: 0x8693E0 Offset: 0x8679E0 VA: 0x1808693E0 Slot: 6
	public string GetSecondaryInfo(CardTableUI ui, CardGameController game, out CardTableUI.InfoTextUI.Attitude attitude) { }

	// RVA: 0x86A140 Offset: 0x868740 VA: 0x18086A140 Slot: 7
	public void UpdateInGameUI_NoPlayer(CardTableUI ui) { }

	// RVA: 0x869E90 Offset: 0x868490 VA: 0x180869E90
	private string GetWinnerNameFromID(ulong playerID) { }

	// RVA: 0x86A010 Offset: 0x868610 VA: 0x18086A010
	private void PopulateCards(List<PlayingCard> cards, Image[] slots, CardTableUI ui) { }

	// RVA: 0x869F70 Offset: 0x868570 VA: 0x180869F70
	public Translate.Phrase PokerResultToPhrase(PokerLib.PokerResult result) { }

	// RVA: 0x86AD30 Offset: 0x869330 VA: 0x18086AD30
	public void .ctor() { }

}

private sealed class TexasHoldEmUI.<>c // TypeDefIndex: 10887
{	// Fields
	public static readonly TexasHoldEmUI.<>c <>9; // 0x0
	public static Predicate<CardTableUI.KeycodeWithAction> <>9__30_0; // 0x8

	// Methods

	// RVA: 0x873910 Offset: 0x871F10 VA: 0x180873910
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8727A0 Offset: 0x870DA0 VA: 0x1808727A0
	internal bool <UpdateInGameUI>b__30_0(CardTableUI.KeycodeWithAction p) { }

}

