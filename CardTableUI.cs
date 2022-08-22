public class CardTableUI : UIDialog // TypeDefIndex: 10875
{	// Fields
	[HeaderAttribute] // RVA: 0x81110 Offset: 0x80510 VA: 0x180081110
	[SerializeField] // RVA: 0x81110 Offset: 0x80510 VA: 0x180081110
	private CardTableUI.InfoTextUI primaryInfo; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardTableUI.InfoTextUI secondaryInfo; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardTableUI.InfoTextUI playerLeaveInfo; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject playingUI; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject availableInputsUI; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardTableUI.PlayingCardImage[] cardImages; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardInputWidget[] inputWidgets; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustSlider dismountProgressSlider; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseLoading; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseWaitingForNextRound; // 0x78
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseNotEnoughPlayers; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseYourTurn; // 0x88
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phrasePlayerLeftGame; // 0x90
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color colourNeutralUI; // 0x98
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color colourGoodUI; // 0xA8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color colourBadUI; // 0xB8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CanvasGroup timerCanvas; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustSlider timerSlider; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UIChat chat; // 0xD8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private HudElement Hunger; // 0xE0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private HudElement Thirst; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private HudElement Health; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private HudElement PendingHealth; // 0xF8
	public Sprite cardNone; // 0x100
	public Sprite cardBackLarge; // 0x108
	public Sprite cardBackSmall; // 0x110
	private static Sprite cardBackLargeStatic; // 0x0
	private static Sprite cardBackSmallStatic; // 0x8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TexasHoldEmUI texasHoldEmUI; // 0x118
	private CardTable owner; // 0x120
	private CardTableUI.UIState uiState; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CardTableUI.ICardGameSubUI <curGameTypeUI>k__BackingField; // 0x130
	private int lastInputCount; // 0x138
	private TimeSince showInputTimer; // 0x13C
	private const float DismountTime = 1;
	private bool dismountInProgress; // 0x140
	private TimeSince dismountStart; // 0x144
	public CardTableUI.KeycodeWithAction dismountInput; // 0x148
	public List<CardTableUI.KeycodeWithAction> availableInputs; // 0x168
	private static Dictionary<int, Sprite> largeCardImageDict; // 0x10
	private static Dictionary<int, Sprite> smallCardImageDict; // 0x18
	private static Dictionary<int, Sprite> transparentCardImageDict; // 0x20

	// Properties
	public CardTableUI.ICardGameSubUI curGameTypeUI { get; set; }
	private float dismountNormalisedProgress { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701920 Offset: 0x6FFF20 VA: 0x180701920
	public CardTableUI.ICardGameSubUI get_curGameTypeUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7019B0 Offset: 0x6FFFB0 VA: 0x1807019B0
	private void set_curGameTypeUI(CardTableUI.ICardGameSubUI value) { }

	// RVA: 0x701930 Offset: 0x6FFF30 VA: 0x180701930
	private float get_dismountNormalisedProgress() { }

	// RVA: 0x6FF1A0 Offset: 0x6FD7A0 VA: 0x1806FF1A0
	protected void Awake() { }

	// RVA: 0x7010A0 Offset: 0x6FF6A0 VA: 0x1807010A0
	protected void Update() { }

	// RVA: 0x6FFB20 Offset: 0x6FE120 VA: 0x1806FFB20
	public void OnPlayerPressedEscape() { }

	// RVA: 0x6FF660 Offset: 0x6FDC60 VA: 0x1806FF660 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x6FF9D0 Offset: 0x6FDFD0 VA: 0x1806FF9D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x700660 Offset: 0x6FEC60 VA: 0x180700660
	public void SetOwner(CardTable owner) { }

	// RVA: 0x6FFC70 Offset: 0x6FE270 VA: 0x1806FFC70 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x6FF820 Offset: 0x6FDE20 VA: 0x1806FF820
	public static Sprite GetImage(int cardIndex, CardTableUI.CardType type) { }

	// RVA: 0x7002D0 Offset: 0x6FE8D0 VA: 0x1807002D0
	public void SetImage(Image image, int cardIndex, CardTableUI.CardType size) { }

	// RVA: 0x700190 Offset: 0x6FE790 VA: 0x180700190
	public void SetImage(Image image, Sprite sprite) { }

	// RVA: 0x700A30 Offset: 0x6FF030 VA: 0x180700A30
	public void ShowTimer() { }

	// RVA: 0x6FF9A0 Offset: 0x6FDFA0 VA: 0x1806FF9A0
	public void HideTimer() { }

	// RVA: 0x7000D0 Offset: 0x6FE6D0 VA: 0x1807000D0
	private void RefreshUIState(CardPlayerData localPlayerData, bool forced = False) { }

	// RVA: 0x7006E0 Offset: 0x6FECE0 VA: 0x1807006E0
	private void SetUIState(CardTableUI.UIState newState, bool forced = False) { }

	// RVA: 0x700B20 Offset: 0x6FF120 VA: 0x180700B20
	private void UpdateVitals() { }

	// RVA: 0x700590 Offset: 0x6FEB90 VA: 0x180700590
	private void SetInfoUI(CardTableUI.InfoTextUI infoTextUI, string text, CardTableUI.InfoTextUI.Attitude attitude) { }

	// RVA: 0x6FFD40 Offset: 0x6FE340 VA: 0x1806FFD40
	private void RefreshAvailableInputs(CardPlayerData localPlayerData) { }

	// RVA: 0x6FFB20 Offset: 0x6FE120 VA: 0x1806FFB20
	private void StartDismountTime() { }

	// RVA: 0x6FF5B0 Offset: 0x6FDBB0 VA: 0x1806FF5B0
	private void CheckDismount() { }

	// RVA: 0x7018B0 Offset: 0x6FFEB0 VA: 0x1807018B0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class CardTableUI.PlayingCardImage // TypeDefIndex: 10876
{	// Fields
	public Rank rank; // 0x10
	public Suit suit; // 0x14
	public Sprite image; // 0x18
	public Sprite imageSmall; // 0x20
	public Sprite imageTransparent; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class CardTableUI.InfoTextUI // TypeDefIndex: 10877
{	// Fields
	public GameObject gameObj; // 0x10
	public RustText rustText; // 0x18
	public Image background; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum CardTableUI.InfoTextUI.Attitude // TypeDefIndex: 10878
{	// Fields
	public int value__; // 0x0
	public const CardTableUI.InfoTextUI.Attitude Neutral = 0;
	public const CardTableUI.InfoTextUI.Attitude Good = 1;
	public const CardTableUI.InfoTextUI.Attitude Bad = 2;

}

public enum CardTableUI.UIState // TypeDefIndex: 10880
{	// Fields
	public int value__; // 0x0
	public const CardTableUI.UIState None = 0;
	public const CardTableUI.UIState Loading = 1;
	public const CardTableUI.UIState WaitingForNextRound = 2;
	public const CardTableUI.UIState Playing = 3;
	public const CardTableUI.UIState CannotJoin = 4;
	public const CardTableUI.UIState NotEnoughPlayers = 5;

}

public struct CardTableUI.KeycodeWithAction // TypeDefIndex: 10881
{	// Fields
	public KeyCode keyCode; // 0x0
	public Action action; // 0x8
	public Translate.Phrase display; // 0x10
	public string extraString; // 0x18

	// Methods

	// RVA: 0xF2890 Offset: 0xF1C90 VA: 0x1800F2890
	public void .ctor(KeyCode keyCode, Action action, Translate.Phrase displayPhrase, string extraString) { }

}

public enum CardTableUI.CardType // TypeDefIndex: 10882
{	// Fields
	public int value__; // 0x0
	public const CardTableUI.CardType Large = 0;
	public const CardTableUI.CardType Small = 1;
	public const CardTableUI.CardType LargeTransparent = 2;

}

