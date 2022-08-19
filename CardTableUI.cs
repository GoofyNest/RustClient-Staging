public class CardTableUI : UIDialog // TypeDefIndex: 10875
{	// Fields
	[HeaderAttribute] // RVA: 0x80FD0 Offset: 0x803D0 VA: 0x180080FD0
	[SerializeField] // RVA: 0x80FD0 Offset: 0x803D0 VA: 0x180080FD0
	private CardTableUI.InfoTextUI primaryInfo; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardTableUI.InfoTextUI secondaryInfo; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardTableUI.InfoTextUI playerLeaveInfo; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject playingUI; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject availableInputsUI; // 0x50
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardTableUI.PlayingCardImage[] cardImages; // 0x58
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CardInputWidget[] inputWidgets; // 0x60
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RustSlider dismountProgressSlider; // 0x68
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseLoading; // 0x70
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseWaitingForNextRound; // 0x78
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseNotEnoughPlayers; // 0x80
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phraseYourTurn; // 0x88
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Translate.Phrase phrasePlayerLeftGame; // 0x90
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color colourNeutralUI; // 0x98
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color colourGoodUI; // 0xA8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color colourBadUI; // 0xB8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CanvasGroup timerCanvas; // 0xC8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RustSlider timerSlider; // 0xD0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private UIChat chat; // 0xD8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private HudElement Hunger; // 0xE0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private HudElement Thirst; // 0xE8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private HudElement Health; // 0xF0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private HudElement PendingHealth; // 0xF8
	public Sprite cardNone; // 0x100
	public Sprite cardBackLarge; // 0x108
	public Sprite cardBackSmall; // 0x110
	private static Sprite cardBackLargeStatic; // 0x0
	private static Sprite cardBackSmallStatic; // 0x8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TexasHoldEmUI texasHoldEmUI; // 0x118
	private CardTable owner; // 0x120
	private CardTableUI.UIState uiState; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x701810 Offset: 0x6FFE10 VA: 0x180701810
	public CardTableUI.ICardGameSubUI get_curGameTypeUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7018A0 Offset: 0x6FFEA0 VA: 0x1807018A0
	private void set_curGameTypeUI(CardTableUI.ICardGameSubUI value) { }

	// RVA: 0x701820 Offset: 0x6FFE20 VA: 0x180701820
	private float get_dismountNormalisedProgress() { }

	// RVA: 0x6FF090 Offset: 0x6FD690 VA: 0x1806FF090
	protected void Awake() { }

	// RVA: 0x700F90 Offset: 0x6FF590 VA: 0x180700F90
	protected void Update() { }

	// RVA: 0x6FFA10 Offset: 0x6FE010 VA: 0x1806FFA10
	public void OnPlayerPressedEscape() { }

	// RVA: 0x6FF550 Offset: 0x6FDB50 VA: 0x1806FF550 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x6FF8C0 Offset: 0x6FDEC0 VA: 0x1806FF8C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x700550 Offset: 0x6FEB50 VA: 0x180700550
	public void SetOwner(CardTable owner) { }

	// RVA: 0x6FFB60 Offset: 0x6FE160 VA: 0x1806FFB60 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x6FF710 Offset: 0x6FDD10 VA: 0x1806FF710
	public static Sprite GetImage(int cardIndex, CardTableUI.CardType type) { }

	// RVA: 0x7001C0 Offset: 0x6FE7C0 VA: 0x1807001C0
	public void SetImage(Image image, int cardIndex, CardTableUI.CardType size) { }

	// RVA: 0x700080 Offset: 0x6FE680 VA: 0x180700080
	public void SetImage(Image image, Sprite sprite) { }

	// RVA: 0x700920 Offset: 0x6FEF20 VA: 0x180700920
	public void ShowTimer() { }

	// RVA: 0x6FF890 Offset: 0x6FDE90 VA: 0x1806FF890
	public void HideTimer() { }

	// RVA: 0x6FFFC0 Offset: 0x6FE5C0 VA: 0x1806FFFC0
	private void RefreshUIState(CardPlayerData localPlayerData, bool forced = False) { }

	// RVA: 0x7005D0 Offset: 0x6FEBD0 VA: 0x1807005D0
	private void SetUIState(CardTableUI.UIState newState, bool forced = False) { }

	// RVA: 0x700A10 Offset: 0x6FF010 VA: 0x180700A10
	private void UpdateVitals() { }

	// RVA: 0x700480 Offset: 0x6FEA80 VA: 0x180700480
	private void SetInfoUI(CardTableUI.InfoTextUI infoTextUI, string text, CardTableUI.InfoTextUI.Attitude attitude) { }

	// RVA: 0x6FFC30 Offset: 0x6FE230 VA: 0x1806FFC30
	private void RefreshAvailableInputs(CardPlayerData localPlayerData) { }

	// RVA: 0x6FFA10 Offset: 0x6FE010 VA: 0x1806FFA10
	private void StartDismountTime() { }

	// RVA: 0x6FF4A0 Offset: 0x6FDAA0 VA: 0x1806FF4A0
	private void CheckDismount() { }

	// RVA: 0x7017A0 Offset: 0x6FFDA0 VA: 0x1807017A0
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

	// RVA: 0xF2910 Offset: 0xF1D10 VA: 0x1800F2910
	public void .ctor(KeyCode keyCode, Action action, Translate.Phrase displayPhrase, string extraString) { }

}

public enum CardTableUI.CardType // TypeDefIndex: 10882
{	// Fields
	public int value__; // 0x0
	public const CardTableUI.CardType Large = 0;
	public const CardTableUI.CardType Small = 1;
	public const CardTableUI.CardType LargeTransparent = 2;

}

