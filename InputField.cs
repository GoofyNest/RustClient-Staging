public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 4946
{	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0xE8
	private static readonly char[] kSeparators; // 0x0
	[SerializeField] // RVA: 0xECCB0 Offset: 0xEC0B0 VA: 0x1800ECCB0
	[FormerlySerializedAsAttribute] // RVA: 0xECCB0 Offset: 0xEC0B0 VA: 0x1800ECCB0
	protected Text m_TextComponent; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Graphic m_Placeholder; // 0xF8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private InputField.ContentType m_ContentType; // 0x100
	[FormerlySerializedAsAttribute] // RVA: 0xECF00 Offset: 0xEC300 VA: 0x1800ECF00
	[SerializeField] // RVA: 0xECF00 Offset: 0xEC300 VA: 0x1800ECF00
	private InputField.InputType m_InputType; // 0x104
	[FormerlySerializedAsAttribute] // RVA: 0xED190 Offset: 0xEC590 VA: 0x1800ED190
	[SerializeField] // RVA: 0xED190 Offset: 0xEC590 VA: 0x1800ED190
	private char m_AsteriskChar; // 0x108
	[FormerlySerializedAsAttribute] // RVA: 0xED350 Offset: 0xEC750 VA: 0x1800ED350
	[SerializeField] // RVA: 0xED350 Offset: 0xEC750 VA: 0x1800ED350
	private TouchScreenKeyboardType m_KeyboardType; // 0x10C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private InputField.LineType m_LineType; // 0x110
	[FormerlySerializedAsAttribute] // RVA: 0xED4B0 Offset: 0xEC8B0 VA: 0x1800ED4B0
	[SerializeField] // RVA: 0xED4B0 Offset: 0xEC8B0 VA: 0x1800ED4B0
	private bool m_HideMobileInput; // 0x114
	[FormerlySerializedAsAttribute] // RVA: 0xED660 Offset: 0xECA60 VA: 0x1800ED660
	[SerializeField] // RVA: 0xED660 Offset: 0xECA60 VA: 0x1800ED660
	private InputField.CharacterValidation m_CharacterValidation; // 0x118
	[FormerlySerializedAsAttribute] // RVA: 0xED8C0 Offset: 0xECCC0 VA: 0x1800ED8C0
	[SerializeField] // RVA: 0xED8C0 Offset: 0xECCC0 VA: 0x1800ED8C0
	private int m_CharacterLimit; // 0x11C
	[FormerlySerializedAsAttribute] // RVA: 0xED950 Offset: 0xECD50 VA: 0x1800ED950
	[FormerlySerializedAsAttribute] // RVA: 0xED950 Offset: 0xECD50 VA: 0x1800ED950
	[FormerlySerializedAsAttribute] // RVA: 0xED950 Offset: 0xECD50 VA: 0x1800ED950
	[SerializeField] // RVA: 0xED950 Offset: 0xECD50 VA: 0x1800ED950
	private InputField.SubmitEvent m_OnEndEdit; // 0x120
	[FormerlySerializedAsAttribute] // RVA: 0xEDC50 Offset: 0xED050 VA: 0x1800EDC50
	[FormerlySerializedAsAttribute] // RVA: 0xEDC50 Offset: 0xED050 VA: 0x1800EDC50
	[SerializeField] // RVA: 0xEDC50 Offset: 0xED050 VA: 0x1800EDC50
	private InputField.OnChangeEvent m_OnValueChanged; // 0x128
	[FormerlySerializedAsAttribute] // RVA: 0xEDDE0 Offset: 0xED1E0 VA: 0x1800EDDE0
	[SerializeField] // RVA: 0xEDDE0 Offset: 0xED1E0 VA: 0x1800EDDE0
	private InputField.OnValidateInput m_OnValidateInput; // 0x130
	[FormerlySerializedAsAttribute] // RVA: 0xEDE60 Offset: 0xED260 VA: 0x1800EDE60
	[SerializeField] // RVA: 0xEDE60 Offset: 0xED260 VA: 0x1800EDE60
	private Color m_CaretColor; // 0x138
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_CustomCaretColor; // 0x148
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_SelectionColor; // 0x14C
	[SerializeField] // RVA: 0xEE420 Offset: 0xED820 VA: 0x1800EE420
	[FormerlySerializedAsAttribute] // RVA: 0xEE420 Offset: 0xED820 VA: 0x1800EE420
	protected string m_Text; // 0x160
	[SerializeField] // RVA: 0xD08E0 Offset: 0xCFCE0 VA: 0x1800D08E0
	[RangeAttribute] // RVA: 0xD08E0 Offset: 0xCFCE0 VA: 0x1800D08E0
	private float m_CaretBlinkRate; // 0x168
	[SerializeField] // RVA: 0xD09B0 Offset: 0xCFDB0 VA: 0x1800D09B0
	[RangeAttribute] // RVA: 0xD09B0 Offset: 0xCFDB0 VA: 0x1800D09B0
	private int m_CaretWidth; // 0x16C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[ObsoleteAttribute] // RVA: 0xEF120 Offset: 0xEE520 VA: 0x1800EF120
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

	// RVA: 0x16039D0 Offset: 0x1601FD0 VA: 0x1816039D0
	private BaseInput get_input() { }

	// RVA: 0x16038B0 Offset: 0x1601EB0 VA: 0x1816038B0
	private string get_compositionString() { }

	// RVA: 0x1603580 Offset: 0x1601B80 VA: 0x181603580
	protected void .ctor() { }

	// RVA: 0x1603AF0 Offset: 0x16020F0 VA: 0x181603AF0
	protected Mesh get_mesh() { }

	// RVA: 0x1603760 Offset: 0x1601D60 VA: 0x181603760
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x1604B80 Offset: 0x1603180 VA: 0x181604B80
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x1604040 Offset: 0x1602640 VA: 0x181604040
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1604020 Offset: 0x1602620 VA: 0x181604020
	private bool get_shouldActivateOnSelect() { }

	// RVA: 0x7E6EB0 Offset: 0x7E54B0 VA: 0x1807E6EB0
	public string get_text() { }

	// RVA: 0x1604E30 Offset: 0x1603430 VA: 0x181604E30
	public void set_text(string value) { }

	// RVA: 0x1601F40 Offset: 0x1600540 VA: 0x181601F40
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x1601F50 Offset: 0x1600550 VA: 0x181601F50
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0xC83140 Offset: 0xC81740 VA: 0x180C83140
	public bool get_isFocused() { }

	// RVA: 0x16037E0 Offset: 0x1601DE0 VA: 0x1816037E0
	public float get_caretBlinkRate() { }

	// RVA: 0x16040E0 Offset: 0x16026E0 VA: 0x1816040E0
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x531730 Offset: 0x52FD30 VA: 0x180531730
	public int get_caretWidth() { }

	// RVA: 0x1604330 Offset: 0x1602930 VA: 0x181604330
	public void set_caretWidth(int value) { }

	// RVA: 0xC73E20 Offset: 0xC72420 VA: 0x180C73E20
	public Text get_textComponent() { }

	// RVA: 0x1604BD0 Offset: 0x16031D0 VA: 0x181604BD0
	public void set_textComponent(Text value) { }

	// RVA: 0xB0F080 Offset: 0xB0D680 VA: 0x180B0F080
	public Graphic get_placeholder() { }

	// RVA: 0x16049C0 Offset: 0x1602FC0 VA: 0x1816049C0
	public void set_placeholder(Graphic value) { }

	// RVA: 0x16037F0 Offset: 0x1601DF0 VA: 0x1816037F0
	public Color get_caretColor() { }

	// RVA: 0x1604150 Offset: 0x1602750 VA: 0x181604150
	public void set_caretColor(Color value) { }

	// RVA: 0x1127F70 Offset: 0x1126570 VA: 0x181127F70
	public bool get_customCaretColor() { }

	// RVA: 0x16046A0 Offset: 0x1602CA0 VA: 0x1816046A0
	public void set_customCaretColor(bool value) { }

	// RVA: 0x1604010 Offset: 0x1602610 VA: 0x181604010
	public Color get_selectionColor() { }

	// RVA: 0x1604A90 Offset: 0x1603090 VA: 0x181604A90
	public void set_selectionColor(Color value) { }

	// RVA: 0x7DDD70 Offset: 0x7DC370 VA: 0x1807DDD70
	public InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x16048D0 Offset: 0x1602ED0 VA: 0x1816048D0
	public void set_onEndEdit(InputField.SubmitEvent value) { }

	// RVA: 0x4C12E0 Offset: 0x4BF8E0 VA: 0x1804C12E0
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x1604970 Offset: 0x1602F70 VA: 0x181604970
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x4C12E0 Offset: 0x4BF8E0 VA: 0x1804C12E0
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x1604970 Offset: 0x1602F70 VA: 0x181604970
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x701920 Offset: 0x6FFF20 VA: 0x180701920
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x1604920 Offset: 0x1602F20 VA: 0x181604920
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x107A180 Offset: 0x1078780 VA: 0x18107A180
	public int get_characterLimit() { }

	// RVA: 0x16043D0 Offset: 0x16029D0 VA: 0x1816043D0
	public void set_characterLimit(int value) { }

	// RVA: 0xC73D50 Offset: 0xC72350 VA: 0x180C73D50
	public InputField.ContentType get_contentType() { }

	// RVA: 0x16044F0 Offset: 0x1602AF0 VA: 0x1816044F0
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0xEC1590 Offset: 0xEBFB90 VA: 0x180EC1590
	public InputField.LineType get_lineType() { }

	// RVA: 0x16047F0 Offset: 0x1602DF0 VA: 0x1816047F0
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0xC73C60 Offset: 0xC72260 VA: 0x180C73C60
	public InputField.InputType get_inputType() { }

	// RVA: 0x1604710 Offset: 0x1602D10 VA: 0x181604710
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0xC73C70 Offset: 0xC72270 VA: 0x180C73C70
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1604780 Offset: 0x1602D80 VA: 0x181604780
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x92DA50 Offset: 0x92C050 VA: 0x18092DA50
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x1604480 Offset: 0x1602A80 VA: 0x181604480
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x1604000 Offset: 0x1602600 VA: 0x181604000
	public bool get_readOnly() { }

	// RVA: 0x1604A10 Offset: 0x1603010 VA: 0x181604A10
	public void set_readOnly(bool value) { }

	// RVA: 0x1603B90 Offset: 0x1602190 VA: 0x181603B90
	public bool get_multiLine() { }

	// RVA: 0x1603750 Offset: 0x1601D50 VA: 0x181603750
	public char get_asteriskChar() { }

	// RVA: 0x1604080 Offset: 0x1602680 VA: 0x181604080
	public void set_asteriskChar(char value) { }

	// RVA: 0x1604070 Offset: 0x1602670 VA: 0x181604070
	public bool get_wasCanceled() { }

	// RVA: 0x15FB580 Offset: 0x15F9B80 VA: 0x1815FB580
	protected void ClampPos(ref int pos) { }

	// RVA: 0x1603850 Offset: 0x1601E50 VA: 0x181603850
	protected int get_caretPositionInternal() { }

	// RVA: 0x16041D0 Offset: 0x16027D0 VA: 0x1816041D0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1603880 Offset: 0x1601E80 VA: 0x181603880
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x16042E0 Offset: 0x16028E0 VA: 0x1816042E0
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x1603960 Offset: 0x1601F60 VA: 0x181603960
	private bool get_hasSelection() { }

	// RVA: 0x1603880 Offset: 0x1601E80 VA: 0x181603880
	public int get_caretPosition() { }

	// RVA: 0x1604220 Offset: 0x1602820 VA: 0x181604220
	public void set_caretPosition(int value) { }

	// RVA: 0x1603850 Offset: 0x1601E50 VA: 0x181603850
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1604A20 Offset: 0x1603020 VA: 0x181604A20
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x1603880 Offset: 0x1601E80 VA: 0x181603880
	public int get_selectionFocusPosition() { }

	// RVA: 0x1604B10 Offset: 0x1603110 VA: 0x181604B10
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x1600560 Offset: 0x15FEB60 VA: 0x181600560 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15FFFE0 Offset: 0x15FE5E0 VA: 0x1815FFFE0 Slot: 7
	protected override void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xEE970 Offset: 0xEDD70 VA: 0x1800EE970
	// RVA: 0x15FB510 Offset: 0x15F9B10 VA: 0x1815FB510
	private IEnumerator CaretBlink() { }

	// RVA: 0x1601570 Offset: 0x15FFB70 VA: 0x181601570
	private void SetCaretVisible() { }

	// RVA: 0x16014A0 Offset: 0x15FFAA0 VA: 0x1816014A0
	private void SetCaretActive() { }

	// RVA: 0x1602440 Offset: 0x1600A40 VA: 0x181602440
	private void UpdateCaretMaterial() { }

	// RVA: 0x1600B10 Offset: 0x15FF110 VA: 0x181600B10
	protected void OnFocus() { }

	// RVA: 0x1600B10 Offset: 0x15FF110 VA: 0x181600B10
	protected void SelectAll() { }

	// RVA: 0x15FFBC0 Offset: 0x15FE1C0 VA: 0x1815FFBC0
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x15FFC90 Offset: 0x15FE290 VA: 0x1815FFC90
	public void MoveTextStart(bool shift) { }

	// RVA: 0xC83070 Offset: 0xC81670 VA: 0x180C83070
	private static string get_clipboard() { }

	// RVA: 0xC83C50 Offset: 0xC82250 VA: 0x180C83C50
	private static void set_clipboard(string value) { }

	// RVA: 0x15FDEF0 Offset: 0x15FC4F0 VA: 0x1815FDEF0
	private bool InPlaceEditing() { }

	// RVA: 0x1602310 Offset: 0x1600910 VA: 0x181602310
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x15FE800 Offset: 0x15FCE00 VA: 0x1815FE800 Slot: 59
	protected virtual void LateUpdate() { }

	[ObsoleteAttribute] // RVA: 0xEEB70 Offset: 0xEDF70 VA: 0x1800EEB70
	// RVA: 0x1600FF0 Offset: 0x15FF5F0 VA: 0x181600FF0
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x15FDC90 Offset: 0x15FC290 VA: 0x1815FDC90
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x15FD6B0 Offset: 0x15FBCB0 VA: 0x1815FD6B0
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x15FF230 Offset: 0x15FD830 VA: 0x1815FF230
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x15FFF80 Offset: 0x15FE580 VA: 0x1815FFF80 Slot: 60
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1600240 Offset: 0x15FE840 VA: 0x181600240 Slot: 61
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xEEC90 Offset: 0xEE090 VA: 0x1800EEC90
	// RVA: 0x15FF320 Offset: 0x15FD920 VA: 0x1815FF320
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x16007B0 Offset: 0x15FEDB0 VA: 0x1816007B0 Slot: 62
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1600BA0 Offset: 0x15FF1A0 VA: 0x181600BA0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x15FE210 Offset: 0x15FC810 VA: 0x1815FE210
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x15FE1B0 Offset: 0x15FC7B0 VA: 0x1815FE1B0
	private bool IsValidChar(char c) { }

	// RVA: 0x1600FD0 Offset: 0x15FF5D0 VA: 0x181600FD0
	public void ProcessEvent(Event e) { }

	// RVA: 0x1600E70 Offset: 0x15FF470 VA: 0x181600E70 Slot: 63
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x15FDB90 Offset: 0x15FC190 VA: 0x1815FDB90
	private string GetSelectedString() { }

	// RVA: 0x15FC020 Offset: 0x15FA620 VA: 0x1815FC020
	private int FindtNextWordBegin() { }

	// RVA: 0x15FF8E0 Offset: 0x15FDEE0 VA: 0x1815FF8E0
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x15FC130 Offset: 0x15FA730 VA: 0x1815FC130
	private int FindtPrevWordBegin() { }

	// RVA: 0x15FF620 Offset: 0x15FDC20 VA: 0x1815FF620
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x15FBC90 Offset: 0x15FA290 VA: 0x1815FBC90
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x15FEF50 Offset: 0x15FD550 VA: 0x1815FEF50
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x15FECD0 Offset: 0x15FD2D0 VA: 0x1815FECD0
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x15FF3B0 Offset: 0x15FD9B0 VA: 0x1815FF3B0
	private void MoveDown(bool shift) { }

	// RVA: 0x15FF3C0 Offset: 0x15FD9C0 VA: 0x1815FF3C0
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x15FFD50 Offset: 0x15FE350 VA: 0x1815FFD50
	private void MoveUp(bool shift) { }

	// RVA: 0x15FFD60 Offset: 0x15FE360 VA: 0x1815FFD60
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x15FB980 Offset: 0x15F9F80 VA: 0x1815FB980
	private void Delete() { }

	// RVA: 0x15FC230 Offset: 0x15FA830 VA: 0x1815FC230
	private void ForwardSpace() { }

	// RVA: 0x15FB370 Offset: 0x15F9970 VA: 0x1815FB370
	private void Backspace() { }

	// RVA: 0x15FDF20 Offset: 0x15FC520 VA: 0x1815FDF20
	private void Insert(char c) { }

	// RVA: 0x1602E20 Offset: 0x1601420 VA: 0x181602E20
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x16013D0 Offset: 0x15FF9D0 VA: 0x1816013D0
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1601440 Offset: 0x15FFA40 VA: 0x181601440
	private void SendOnValueChanged() { }

	// RVA: 0x1601370 Offset: 0x15FF970 VA: 0x181601370
	protected void SendOnSubmit() { }

	// RVA: 0x15FA990 Offset: 0x15F8F90 VA: 0x1815FA990 Slot: 64
	protected virtual void Append(string input) { }

	// RVA: 0x15FAA40 Offset: 0x15F9040 VA: 0x1815FAA40 Slot: 65
	protected virtual void Append(char input) { }

	// RVA: 0x16029B0 Offset: 0x1600FB0 VA: 0x1816029B0
	protected void UpdateLabel() { }

	// RVA: 0x15FE0E0 Offset: 0x15FC6E0 VA: 0x1815FE0E0
	private bool IsSelectionVisible() { }

	// RVA: 0x15FDA60 Offset: 0x15FC060 VA: 0x1815FDA60
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x15FD930 Offset: 0x15FBF30 VA: 0x1815FD930
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x16015B0 Offset: 0x15FFBB0 VA: 0x1816015B0
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x15FC220 Offset: 0x15FA820 VA: 0x1815FC220
	public void ForceLabelUpdate() { }

	// RVA: 0x15FF1D0 Offset: 0x15FD7D0 VA: 0x1815FF1D0
	private void MarkGeometryAsDirty() { }

	// RVA: 0x1600FE0 Offset: 0x15FF5E0 VA: 0x181600FE0 Slot: 66
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 67
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 68
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1602560 Offset: 0x1600B60 VA: 0x181602560
	private void UpdateGeometry() { }

	// RVA: 0x15FABD0 Offset: 0x15F91D0 VA: 0x1815FABD0
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x16007E0 Offset: 0x15FEDE0 VA: 0x1816007E0
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x15FC360 Offset: 0x15FA960 VA: 0x1815FC360
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x15FB5C0 Offset: 0x15F9BC0 VA: 0x1815FB5C0
	private void CreateCursorVerts() { }

	// RVA: 0x15FCCB0 Offset: 0x15FB2B0 VA: 0x1815FCCB0
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1602E80 Offset: 0x1601480 VA: 0x181602E80
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x15FA840 Offset: 0x15F8E40 VA: 0x1815FA840
	public void ActivateInputField() { }

	// RVA: 0x15FA4F0 Offset: 0x15F8AF0 VA: 0x1815FA4F0
	private void ActivateInputFieldInternal() { }

	// RVA: 0x1600DE0 Offset: 0x15FF3E0 VA: 0x181600DE0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1600B70 Offset: 0x15FF170 VA: 0x181600B70 Slot: 69
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x15FB760 Offset: 0x15F9D60 VA: 0x1815FB760
	public void DeactivateInputField() { }

	// RVA: 0x15FFFB0 Offset: 0x15FE5B0 VA: 0x1815FFFB0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1600E20 Offset: 0x15FF420 VA: 0x181600E20 Slot: 70
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x15FBDF0 Offset: 0x15FA3F0 VA: 0x1815FBDF0
	private void EnforceContentType() { }

	// RVA: 0x15FBF60 Offset: 0x15FA560 VA: 0x1815FBF60
	private void EnforceTextHOverflow() { }

	// RVA: 0x1602280 Offset: 0x1600880 VA: 0x181602280
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x16022F0 Offset: 0x16008F0 VA: 0x1816022F0
	private void SetToCustom() { }

	// RVA: 0x15FBDC0 Offset: 0x15FA3C0 VA: 0x1815FBDC0 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 71
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 72
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 73
	public virtual float get_minWidth() { }

	// RVA: 0x1603E20 Offset: 0x1602420 VA: 0x181603E20 Slot: 74
	public virtual float get_preferredWidth() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 75
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 76
	public virtual float get_minHeight() { }

	// RVA: 0x1603BB0 Offset: 0x16021B0 VA: 0x181603BB0 Slot: 77
	public virtual float get_preferredHeight() { }

	// RVA: 0xC83150 Offset: 0xC81750 VA: 0x180C83150 Slot: 78
	public virtual float get_flexibleHeight() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 79
	public virtual int get_layoutPriority() { }

	// RVA: 0x1603510 Offset: 0x1601B10 VA: 0x181603510
	private static void .cctor() { }

	// RVA: 0xABD5D0 Offset: 0xABBBD0 VA: 0x180ABD5D0 Slot: 46
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

	// RVA: 0xD97B10 Offset: 0xD96110 VA: 0x180D97B10 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x1717200 Offset: 0x1715800 VA: 0x181717200 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0xD97AE0 Offset: 0xD960E0 VA: 0x180D97AE0 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }

}

public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 4952
{	// Methods

	// RVA: 0x1726E00 Offset: 0x1725400 VA: 0x181726E00
	public void .ctor() { }

}

public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 4953
{	// Methods

	// RVA: 0x17171C0 Offset: 0x17157C0 VA: 0x1817171C0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1726E40 Offset: 0x1725440 VA: 0x181726E40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1726F90 Offset: 0x1725590 VA: 0x181726F90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1727360 Offset: 0x1725960 VA: 0x181727360 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1727630 Offset: 0x1725C30 VA: 0x181727630 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

