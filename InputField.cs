public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 4946
{	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0xE8
	private static readonly char[] kSeparators; // 0x0
	[SerializeField] // RVA: 0xECCC0 Offset: 0xEC0C0 VA: 0x1800ECCC0
	[FormerlySerializedAsAttribute] // RVA: 0xECCC0 Offset: 0xEC0C0 VA: 0x1800ECCC0
	protected Text m_TextComponent; // 0xF0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Graphic m_Placeholder; // 0xF8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private InputField.ContentType m_ContentType; // 0x100
	[FormerlySerializedAsAttribute] // RVA: 0xECE80 Offset: 0xEC280 VA: 0x1800ECE80
	[SerializeField] // RVA: 0xECE80 Offset: 0xEC280 VA: 0x1800ECE80
	private InputField.InputType m_InputType; // 0x104
	[FormerlySerializedAsAttribute] // RVA: 0xED140 Offset: 0xEC540 VA: 0x1800ED140
	[SerializeField] // RVA: 0xED140 Offset: 0xEC540 VA: 0x1800ED140
	private char m_AsteriskChar; // 0x108
	[FormerlySerializedAsAttribute] // RVA: 0xED2A0 Offset: 0xEC6A0 VA: 0x1800ED2A0
	[SerializeField] // RVA: 0xED2A0 Offset: 0xEC6A0 VA: 0x1800ED2A0
	private TouchScreenKeyboardType m_KeyboardType; // 0x10C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private InputField.LineType m_LineType; // 0x110
	[FormerlySerializedAsAttribute] // RVA: 0xED460 Offset: 0xEC860 VA: 0x1800ED460
	[SerializeField] // RVA: 0xED460 Offset: 0xEC860 VA: 0x1800ED460
	private bool m_HideMobileInput; // 0x114
	[FormerlySerializedAsAttribute] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	[SerializeField] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	private InputField.CharacterValidation m_CharacterValidation; // 0x118
	[FormerlySerializedAsAttribute] // RVA: 0xED840 Offset: 0xECC40 VA: 0x1800ED840
	[SerializeField] // RVA: 0xED840 Offset: 0xECC40 VA: 0x1800ED840
	private int m_CharacterLimit; // 0x11C
	[FormerlySerializedAsAttribute] // RVA: 0xED980 Offset: 0xECD80 VA: 0x1800ED980
	[FormerlySerializedAsAttribute] // RVA: 0xED980 Offset: 0xECD80 VA: 0x1800ED980
	[FormerlySerializedAsAttribute] // RVA: 0xED980 Offset: 0xECD80 VA: 0x1800ED980
	[SerializeField] // RVA: 0xED980 Offset: 0xECD80 VA: 0x1800ED980
	private InputField.SubmitEvent m_OnEndEdit; // 0x120
	[FormerlySerializedAsAttribute] // RVA: 0xEDBA0 Offset: 0xECFA0 VA: 0x1800EDBA0
	[FormerlySerializedAsAttribute] // RVA: 0xEDBA0 Offset: 0xECFA0 VA: 0x1800EDBA0
	[SerializeField] // RVA: 0xEDBA0 Offset: 0xECFA0 VA: 0x1800EDBA0
	private InputField.OnChangeEvent m_OnValueChanged; // 0x128
	[FormerlySerializedAsAttribute] // RVA: 0xEDD30 Offset: 0xED130 VA: 0x1800EDD30
	[SerializeField] // RVA: 0xEDD30 Offset: 0xED130 VA: 0x1800EDD30
	private InputField.OnValidateInput m_OnValidateInput; // 0x130
	[FormerlySerializedAsAttribute] // RVA: 0xEDE90 Offset: 0xED290 VA: 0x1800EDE90
	[SerializeField] // RVA: 0xEDE90 Offset: 0xED290 VA: 0x1800EDE90
	private Color m_CaretColor; // 0x138
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_CustomCaretColor; // 0x148
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color m_SelectionColor; // 0x14C
	[SerializeField] // RVA: 0xEE3E0 Offset: 0xED7E0 VA: 0x1800EE3E0
	[FormerlySerializedAsAttribute] // RVA: 0xEE3E0 Offset: 0xED7E0 VA: 0x1800EE3E0
	protected string m_Text; // 0x160
	[SerializeField] // RVA: 0xD0850 Offset: 0xCFC50 VA: 0x1800D0850
	[RangeAttribute] // RVA: 0xD0850 Offset: 0xCFC50 VA: 0x1800D0850
	private float m_CaretBlinkRate; // 0x168
	[SerializeField] // RVA: 0xD0920 Offset: 0xCFD20 VA: 0x1800D0920
	[RangeAttribute] // RVA: 0xD0920 Offset: 0xCFD20 VA: 0x1800D0920
	private int m_CaretWidth; // 0x16C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_ReadOnly; // 0x170
	protected int m_CaretPosition; // 0x174
	protected int m_CaretSelectPosition; // 0x178
	private RectTransform caretRectTrans; // 0x180
	protected UIVertex[] m_CursorVerts; // 0x188
	private TextGenerator m_InputTextCache; // 0x190
	private CanvasRenderer m_CachedInputRenderer; // 0x198
	private bool m_PreventFontCallback; // 0x1A0
	protected Mesh m_Mesh; // 0x1A8
	private bool m_AllowInput; // 0x1B0
	private bool m_ShouldActivateNextUpdate; // 0x1B1
	private bool m_UpdateDrag; // 0x1B2
	private bool m_DragPositionOutOfBounds; // 0x1B3
	private const float kHScrollSpeed = 0,05;
	private const float kVScrollSpeed = 0,1;
	protected bool m_CaretVisible; // 0x1B4
	private Coroutine m_BlinkCoroutine; // 0x1B8
	private float m_BlinkStartTime; // 0x1C0
	protected int m_DrawStart; // 0x1C4
	protected int m_DrawEnd; // 0x1C8
	private Coroutine m_DragCoroutine; // 0x1D0
	private string m_OriginalText; // 0x1D8
	private bool m_WasCanceled; // 0x1E0
	private bool m_HasDoneFocusTransition; // 0x1E1
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x1E8
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x1F0
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private Event m_ProcessingEvent; // 0x1F8
	private const int k_MaxTextLength = 16382;

	// Properties
	private BaseInput input { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	protected TextGenerator cachedInputTextGenerator { get; }
	public bool shouldHideMobileInput { get; set; }
	private bool shouldActivateOnSelect { get; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public InputField.SubmitEvent onEndEdit { get; set; }
	[ObsoleteAttribute] // RVA: 0xEF060 Offset: 0xEE460 VA: 0x1800EF060
	public InputField.OnChangeEvent onValueChange { get; set; }
	public InputField.OnChangeEvent onValueChanged { get; set; }
	public InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public InputField.ContentType contentType { get; set; }
	public InputField.LineType lineType { get; set; }
	public InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public InputField.CharacterValidation characterValidation { get; set; }
	public bool readOnly { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1603710 Offset: 0x1601D10 VA: 0x181603710
	private BaseInput get_input() { }

	// RVA: 0x16035F0 Offset: 0x1601BF0 VA: 0x1816035F0
	private string get_compositionString() { }

	// RVA: 0x16032C0 Offset: 0x16018C0 VA: 0x1816032C0
	protected void .ctor() { }

	// RVA: 0x1603830 Offset: 0x1601E30 VA: 0x181603830
	protected Mesh get_mesh() { }

	// RVA: 0x16034A0 Offset: 0x1601AA0 VA: 0x1816034A0
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x16048C0 Offset: 0x1602EC0 VA: 0x1816048C0
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x1603D80 Offset: 0x1602380 VA: 0x181603D80
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1603D60 Offset: 0x1602360 VA: 0x181603D60
	private bool get_shouldActivateOnSelect() { }

	// RVA: 0x7E6DA0 Offset: 0x7E53A0 VA: 0x1807E6DA0
	public string get_text() { }

	// RVA: 0x1604B70 Offset: 0x1603170 VA: 0x181604B70
	public void set_text(string value) { }

	// RVA: 0x1601C80 Offset: 0x1600280 VA: 0x181601C80
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x1601C90 Offset: 0x1600290 VA: 0x181601C90
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0xC82E80 Offset: 0xC81480 VA: 0x180C82E80
	public bool get_isFocused() { }

	// RVA: 0x1603520 Offset: 0x1601B20 VA: 0x181603520
	public float get_caretBlinkRate() { }

	// RVA: 0x1603E20 Offset: 0x1602420 VA: 0x181603E20
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x531730 Offset: 0x52FD30 VA: 0x180531730
	public int get_caretWidth() { }

	// RVA: 0x1604070 Offset: 0x1602670 VA: 0x181604070
	public void set_caretWidth(int value) { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public Text get_textComponent() { }

	// RVA: 0x1604910 Offset: 0x1602F10 VA: 0x181604910
	public void set_textComponent(Text value) { }

	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	public Graphic get_placeholder() { }

	// RVA: 0x1604700 Offset: 0x1602D00 VA: 0x181604700
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1603530 Offset: 0x1601B30 VA: 0x181603530
	public Color get_caretColor() { }

	// RVA: 0x1603E90 Offset: 0x1602490 VA: 0x181603E90
	public void set_caretColor(Color value) { }

	// RVA: 0x1127CB0 Offset: 0x11262B0 VA: 0x181127CB0
	public bool get_customCaretColor() { }

	// RVA: 0x16043E0 Offset: 0x16029E0 VA: 0x1816043E0
	public void set_customCaretColor(bool value) { }

	// RVA: 0x1603D50 Offset: 0x1602350 VA: 0x181603D50
	public Color get_selectionColor() { }

	// RVA: 0x16047D0 Offset: 0x1602DD0 VA: 0x1816047D0
	public void set_selectionColor(Color value) { }

	// RVA: 0x7DDC60 Offset: 0x7DC260 VA: 0x1807DDC60
	public InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x1604610 Offset: 0x1602C10 VA: 0x181604610
	public void set_onEndEdit(InputField.SubmitEvent value) { }

	// RVA: 0x4C12E0 Offset: 0x4BF8E0 VA: 0x1804C12E0
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x16046B0 Offset: 0x1602CB0 VA: 0x1816046B0
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x4C12E0 Offset: 0x4BF8E0 VA: 0x1804C12E0
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x16046B0 Offset: 0x1602CB0 VA: 0x1816046B0
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x701810 Offset: 0x6FFE10 VA: 0x180701810
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x1604660 Offset: 0x1602C60 VA: 0x181604660
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x1079EC0 Offset: 0x10784C0 VA: 0x181079EC0
	public int get_characterLimit() { }

	// RVA: 0x1604110 Offset: 0x1602710 VA: 0x181604110
	public void set_characterLimit(int value) { }

	// RVA: 0xC73A90 Offset: 0xC72090 VA: 0x180C73A90
	public InputField.ContentType get_contentType() { }

	// RVA: 0x1604230 Offset: 0x1602830 VA: 0x181604230
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0xEC12D0 Offset: 0xEBF8D0 VA: 0x180EC12D0
	public InputField.LineType get_lineType() { }

	// RVA: 0x1604530 Offset: 0x1602B30 VA: 0x181604530
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0xC739A0 Offset: 0xC71FA0 VA: 0x180C739A0
	public InputField.InputType get_inputType() { }

	// RVA: 0x1604450 Offset: 0x1602A50 VA: 0x181604450
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0xC739B0 Offset: 0xC71FB0 VA: 0x180C739B0
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x16044C0 Offset: 0x1602AC0 VA: 0x1816044C0
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x92D940 Offset: 0x92BF40 VA: 0x18092D940
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x16041C0 Offset: 0x16027C0 VA: 0x1816041C0
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x1603D40 Offset: 0x1602340 VA: 0x181603D40
	public bool get_readOnly() { }

	// RVA: 0x1604750 Offset: 0x1602D50 VA: 0x181604750
	public void set_readOnly(bool value) { }

	// RVA: 0x16038D0 Offset: 0x1601ED0 VA: 0x1816038D0
	public bool get_multiLine() { }

	// RVA: 0x1603490 Offset: 0x1601A90 VA: 0x181603490
	public char get_asteriskChar() { }

	// RVA: 0x1603DC0 Offset: 0x16023C0 VA: 0x181603DC0
	public void set_asteriskChar(char value) { }

	// RVA: 0x1603DB0 Offset: 0x16023B0 VA: 0x181603DB0
	public bool get_wasCanceled() { }

	// RVA: 0x15FB2C0 Offset: 0x15F98C0 VA: 0x1815FB2C0
	protected void ClampPos(ref int pos) { }

	// RVA: 0x1603590 Offset: 0x1601B90 VA: 0x181603590
	protected int get_caretPositionInternal() { }

	// RVA: 0x1603F10 Offset: 0x1602510 VA: 0x181603F10
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x16035C0 Offset: 0x1601BC0 VA: 0x1816035C0
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x1604020 Offset: 0x1602620 VA: 0x181604020
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x16036A0 Offset: 0x1601CA0 VA: 0x1816036A0
	private bool get_hasSelection() { }

	// RVA: 0x16035C0 Offset: 0x1601BC0 VA: 0x1816035C0
	public int get_caretPosition() { }

	// RVA: 0x1603F60 Offset: 0x1602560 VA: 0x181603F60
	public void set_caretPosition(int value) { }

	// RVA: 0x1603590 Offset: 0x1601B90 VA: 0x181603590
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1604760 Offset: 0x1602D60 VA: 0x181604760
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x16035C0 Offset: 0x1601BC0 VA: 0x1816035C0
	public int get_selectionFocusPosition() { }

	// RVA: 0x1604850 Offset: 0x1602E50 VA: 0x181604850
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x16002A0 Offset: 0x15FE8A0 VA: 0x1816002A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15FFD20 Offset: 0x15FE320 VA: 0x1815FFD20 Slot: 7
	protected override void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xEE8D0 Offset: 0xEDCD0 VA: 0x1800EE8D0
	// RVA: 0x15FB250 Offset: 0x15F9850 VA: 0x1815FB250
	private IEnumerator CaretBlink() { }

	// RVA: 0x16012B0 Offset: 0x15FF8B0 VA: 0x1816012B0
	private void SetCaretVisible() { }

	// RVA: 0x16011E0 Offset: 0x15FF7E0 VA: 0x1816011E0
	private void SetCaretActive() { }

	// RVA: 0x1602180 Offset: 0x1600780 VA: 0x181602180
	private void UpdateCaretMaterial() { }

	// RVA: 0x1600850 Offset: 0x15FEE50 VA: 0x181600850
	protected void OnFocus() { }

	// RVA: 0x1600850 Offset: 0x15FEE50 VA: 0x181600850
	protected void SelectAll() { }

	// RVA: 0x15FF900 Offset: 0x15FDF00 VA: 0x1815FF900
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x15FF9D0 Offset: 0x15FDFD0 VA: 0x1815FF9D0
	public void MoveTextStart(bool shift) { }

	// RVA: 0xC82DB0 Offset: 0xC813B0 VA: 0x180C82DB0
	private static string get_clipboard() { }

	// RVA: 0xC83990 Offset: 0xC81F90 VA: 0x180C83990
	private static void set_clipboard(string value) { }

	// RVA: 0x15FDC30 Offset: 0x15FC230 VA: 0x1815FDC30
	private bool InPlaceEditing() { }

	// RVA: 0x1602050 Offset: 0x1600650 VA: 0x181602050
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x15FE540 Offset: 0x15FCB40 VA: 0x1815FE540 Slot: 59
	protected virtual void LateUpdate() { }

	[ObsoleteAttribute] // RVA: 0xEEAF0 Offset: 0xEDEF0 VA: 0x1800EEAF0
	// RVA: 0x1600D30 Offset: 0x15FF330 VA: 0x181600D30
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x15FD9D0 Offset: 0x15FBFD0 VA: 0x1815FD9D0
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x15FD3F0 Offset: 0x15FB9F0 VA: 0x1815FD3F0
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x15FEF70 Offset: 0x15FD570 VA: 0x1815FEF70
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x15FFCC0 Offset: 0x15FE2C0 VA: 0x1815FFCC0 Slot: 60
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x15FFF80 Offset: 0x15FE580 VA: 0x1815FFF80 Slot: 61
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xEEC10 Offset: 0xEE010 VA: 0x1800EEC10
	// RVA: 0x15FF060 Offset: 0x15FD660 VA: 0x1815FF060
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x16004F0 Offset: 0x15FEAF0 VA: 0x1816004F0 Slot: 62
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x16008E0 Offset: 0x15FEEE0 VA: 0x1816008E0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x15FDF50 Offset: 0x15FC550 VA: 0x1815FDF50
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x15FDEF0 Offset: 0x15FC4F0 VA: 0x1815FDEF0
	private bool IsValidChar(char c) { }

	// RVA: 0x1600D10 Offset: 0x15FF310 VA: 0x181600D10
	public void ProcessEvent(Event e) { }

	// RVA: 0x1600BB0 Offset: 0x15FF1B0 VA: 0x181600BB0 Slot: 63
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x15FD8D0 Offset: 0x15FBED0 VA: 0x1815FD8D0
	private string GetSelectedString() { }

	// RVA: 0x15FBD60 Offset: 0x15FA360 VA: 0x1815FBD60
	private int FindtNextWordBegin() { }

	// RVA: 0x15FF620 Offset: 0x15FDC20 VA: 0x1815FF620
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x15FBE70 Offset: 0x15FA470 VA: 0x1815FBE70
	private int FindtPrevWordBegin() { }

	// RVA: 0x15FF360 Offset: 0x15FD960 VA: 0x1815FF360
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x15FB9D0 Offset: 0x15F9FD0 VA: 0x1815FB9D0
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x15FEC90 Offset: 0x15FD290 VA: 0x1815FEC90
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x15FEA10 Offset: 0x15FD010 VA: 0x1815FEA10
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x15FF0F0 Offset: 0x15FD6F0 VA: 0x1815FF0F0
	private void MoveDown(bool shift) { }

	// RVA: 0x15FF100 Offset: 0x15FD700 VA: 0x1815FF100
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x15FFA90 Offset: 0x15FE090 VA: 0x1815FFA90
	private void MoveUp(bool shift) { }

	// RVA: 0x15FFAA0 Offset: 0x15FE0A0 VA: 0x1815FFAA0
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x15FB6C0 Offset: 0x15F9CC0 VA: 0x1815FB6C0
	private void Delete() { }

	// RVA: 0x15FBF70 Offset: 0x15FA570 VA: 0x1815FBF70
	private void ForwardSpace() { }

	// RVA: 0x15FB0B0 Offset: 0x15F96B0 VA: 0x1815FB0B0
	private void Backspace() { }

	// RVA: 0x15FDC60 Offset: 0x15FC260 VA: 0x1815FDC60
	private void Insert(char c) { }

	// RVA: 0x1602B60 Offset: 0x1601160 VA: 0x181602B60
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x1601110 Offset: 0x15FF710 VA: 0x181601110
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1601180 Offset: 0x15FF780 VA: 0x181601180
	private void SendOnValueChanged() { }

	// RVA: 0x16010B0 Offset: 0x15FF6B0 VA: 0x1816010B0
	protected void SendOnSubmit() { }

	// RVA: 0x15FA6D0 Offset: 0x15F8CD0 VA: 0x1815FA6D0 Slot: 64
	protected virtual void Append(string input) { }

	// RVA: 0x15FA780 Offset: 0x15F8D80 VA: 0x1815FA780 Slot: 65
	protected virtual void Append(char input) { }

	// RVA: 0x16026F0 Offset: 0x1600CF0 VA: 0x1816026F0
	protected void UpdateLabel() { }

	// RVA: 0x15FDE20 Offset: 0x15FC420 VA: 0x1815FDE20
	private bool IsSelectionVisible() { }

	// RVA: 0x15FD7A0 Offset: 0x15FBDA0 VA: 0x1815FD7A0
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x15FD670 Offset: 0x15FBC70 VA: 0x1815FD670
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x16012F0 Offset: 0x15FF8F0 VA: 0x1816012F0
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x15FBF60 Offset: 0x15FA560 VA: 0x1815FBF60
	public void ForceLabelUpdate() { }

	// RVA: 0x15FEF10 Offset: 0x15FD510 VA: 0x1815FEF10
	private void MarkGeometryAsDirty() { }

	// RVA: 0x1600D20 Offset: 0x15FF320 VA: 0x181600D20 Slot: 66
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 67
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 68
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x16022A0 Offset: 0x16008A0 VA: 0x1816022A0
	private void UpdateGeometry() { }

	// RVA: 0x15FA910 Offset: 0x15F8F10 VA: 0x1815FA910
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x1600520 Offset: 0x15FEB20 VA: 0x181600520
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x15FC0A0 Offset: 0x15FA6A0 VA: 0x1815FC0A0
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x15FB300 Offset: 0x15F9900 VA: 0x1815FB300
	private void CreateCursorVerts() { }

	// RVA: 0x15FC9F0 Offset: 0x15FAFF0 VA: 0x1815FC9F0
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1602BC0 Offset: 0x16011C0 VA: 0x181602BC0
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x15FA580 Offset: 0x15F8B80 VA: 0x1815FA580
	public void ActivateInputField() { }

	// RVA: 0x15FA230 Offset: 0x15F8830 VA: 0x1815FA230
	private void ActivateInputFieldInternal() { }

	// RVA: 0x1600B20 Offset: 0x15FF120 VA: 0x181600B20 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x16008B0 Offset: 0x15FEEB0 VA: 0x1816008B0 Slot: 69
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x15FB4A0 Offset: 0x15F9AA0 VA: 0x1815FB4A0
	public void DeactivateInputField() { }

	// RVA: 0x15FFCF0 Offset: 0x15FE2F0 VA: 0x1815FFCF0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1600B60 Offset: 0x15FF160 VA: 0x181600B60 Slot: 70
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x15FBB30 Offset: 0x15FA130 VA: 0x1815FBB30
	private void EnforceContentType() { }

	// RVA: 0x15FBCA0 Offset: 0x15FA2A0 VA: 0x1815FBCA0
	private void EnforceTextHOverflow() { }

	// RVA: 0x1601FC0 Offset: 0x16005C0 VA: 0x181601FC0
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x1602030 Offset: 0x1600630 VA: 0x181602030
	private void SetToCustom() { }

	// RVA: 0x15FBB00 Offset: 0x15FA100 VA: 0x1815FBB00 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 71
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 72
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 73
	public virtual float get_minWidth() { }

	// RVA: 0x1603B60 Offset: 0x1602160 VA: 0x181603B60 Slot: 74
	public virtual float get_preferredWidth() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 75
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 76
	public virtual float get_minHeight() { }

	// RVA: 0x16038F0 Offset: 0x1601EF0 VA: 0x1816038F0 Slot: 77
	public virtual float get_preferredHeight() { }

	// RVA: 0xC82E90 Offset: 0xC81490 VA: 0x180C82E90 Slot: 78
	public virtual float get_flexibleHeight() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 79
	public virtual int get_layoutPriority() { }

	// RVA: 0x1603250 Offset: 0x1601850 VA: 0x181603250
	private static void .cctor() { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum InputField.ContentType // TypeDefIndex: 4947
{	// Fields
	public int value__; // 0x0
	public const InputField.ContentType Standard = 0;
	public const InputField.ContentType Autocorrected = 1;
	public const InputField.ContentType IntegerNumber = 2;
	public const InputField.ContentType DecimalNumber = 3;
	public const InputField.ContentType Alphanumeric = 4;
	public const InputField.ContentType Name = 5;
	public const InputField.ContentType EmailAddress = 6;
	public const InputField.ContentType Password = 7;
	public const InputField.ContentType Pin = 8;
	public const InputField.ContentType Custom = 9;

}

public enum InputField.InputType // TypeDefIndex: 4948
{	// Fields
	public int value__; // 0x0
	public const InputField.InputType Standard = 0;
	public const InputField.InputType AutoCorrect = 1;
	public const InputField.InputType Password = 2;

}

public enum InputField.CharacterValidation // TypeDefIndex: 4949
{	// Fields
	public int value__; // 0x0
	public const InputField.CharacterValidation None = 0;
	public const InputField.CharacterValidation Integer = 1;
	public const InputField.CharacterValidation Decimal = 2;
	public const InputField.CharacterValidation Alphanumeric = 3;
	public const InputField.CharacterValidation Name = 4;
	public const InputField.CharacterValidation EmailAddress = 5;

}

public enum InputField.LineType // TypeDefIndex: 4950
{	// Fields
	public int value__; // 0x0
	public const InputField.LineType SingleLine = 0;
	public const InputField.LineType MultiLineSubmit = 1;
	public const InputField.LineType MultiLineNewline = 2;

}

public sealed class InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 4951
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD97850 Offset: 0xD95E50 VA: 0x180D97850 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x1716F40 Offset: 0x1715540 VA: 0x181716F40 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0xD97820 Offset: 0xD95E20 VA: 0x180D97820 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }

}

public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 4952
{	// Methods

	// RVA: 0x1726B40 Offset: 0x1725140 VA: 0x181726B40
	public void .ctor() { }

}

public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 4953
{	// Methods

	// RVA: 0x1716F00 Offset: 0x1715500 VA: 0x181716F00
	public void .ctor() { }

}

private sealed class InputField.<CaretBlink>d__159 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4955
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1726B80 Offset: 0x1725180 VA: 0x181726B80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1726CD0 Offset: 0x17252D0 VA: 0x181726CD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class InputField.<MouseDragOutsideRect>d__179 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4956
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x17270A0 Offset: 0x17256A0 VA: 0x1817270A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1727370 Offset: 0x1725970 VA: 0x181727370 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

