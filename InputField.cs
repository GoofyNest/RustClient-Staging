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

	// RVA: 0x15F0CF0 Offset: 0x15EF2F0 VA: 0x1815F0CF0
	private BaseInput get_input() { }

	// RVA: 0x15F0BD0 Offset: 0x15EF1D0 VA: 0x1815F0BD0
	private string get_compositionString() { }

	// RVA: 0x15F08A0 Offset: 0x15EEEA0 VA: 0x1815F08A0
	protected void .ctor() { }

	// RVA: 0x15F0E10 Offset: 0x15EF410 VA: 0x1815F0E10
	protected Mesh get_mesh() { }

	// RVA: 0x15F0A80 Offset: 0x15EF080 VA: 0x1815F0A80
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x15F1EA0 Offset: 0x15F04A0 VA: 0x1815F1EA0
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x15F1360 Offset: 0x15EF960 VA: 0x1815F1360
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x15F1340 Offset: 0x15EF940 VA: 0x1815F1340
	private bool get_shouldActivateOnSelect() { }

	// RVA: 0x7B27D0 Offset: 0x7B0DD0 VA: 0x1807B27D0
	public string get_text() { }

	// RVA: 0x15F2150 Offset: 0x15F0750 VA: 0x1815F2150
	public void set_text(string value) { }

	// RVA: 0x15EF260 Offset: 0x15ED860 VA: 0x1815EF260
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x15EF270 Offset: 0x15ED870 VA: 0x1815EF270
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0xC835E0 Offset: 0xC81BE0 VA: 0x180C835E0
	public bool get_isFocused() { }

	// RVA: 0x15F0B00 Offset: 0x15EF100 VA: 0x1815F0B00
	public float get_caretBlinkRate() { }

	// RVA: 0x15F1400 Offset: 0x15EFA00 VA: 0x1815F1400
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x5316C0 Offset: 0x52FCC0 VA: 0x1805316C0
	public int get_caretWidth() { }

	// RVA: 0x15F1650 Offset: 0x15EFC50 VA: 0x1815F1650
	public void set_caretWidth(int value) { }

	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public Text get_textComponent() { }

	// RVA: 0x15F1EF0 Offset: 0x15F04F0 VA: 0x1815F1EF0
	public void set_textComponent(Text value) { }

	// RVA: 0xB0F550 Offset: 0xB0DB50 VA: 0x180B0F550
	public Graphic get_placeholder() { }

	// RVA: 0x15F1CE0 Offset: 0x15F02E0 VA: 0x1815F1CE0
	public void set_placeholder(Graphic value) { }

	// RVA: 0x15F0B10 Offset: 0x15EF110 VA: 0x1815F0B10
	public Color get_caretColor() { }

	// RVA: 0x15F1470 Offset: 0x15EFA70 VA: 0x1815F1470
	public void set_caretColor(Color value) { }

	// RVA: 0x11289E0 Offset: 0x1126FE0 VA: 0x1811289E0
	public bool get_customCaretColor() { }

	// RVA: 0x15F19C0 Offset: 0x15EFFC0 VA: 0x1815F19C0
	public void set_customCaretColor(bool value) { }

	// RVA: 0x15F1330 Offset: 0x15EF930 VA: 0x1815F1330
	public Color get_selectionColor() { }

	// RVA: 0x15F1DB0 Offset: 0x15F03B0 VA: 0x1815F1DB0
	public void set_selectionColor(Color value) { }

	// RVA: 0x7A9690 Offset: 0x7A7C90 VA: 0x1807A9690
	public InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x15F1BF0 Offset: 0x15F01F0 VA: 0x1815F1BF0
	public void set_onEndEdit(InputField.SubmitEvent value) { }

	// RVA: 0x4C1270 Offset: 0x4BF870 VA: 0x1804C1270
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x15F1C90 Offset: 0x15F0290 VA: 0x1815F1C90
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x4C1270 Offset: 0x4BF870 VA: 0x1804C1270
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x15F1C90 Offset: 0x15F0290 VA: 0x1815F1C90
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x701870 Offset: 0x6FFE70 VA: 0x180701870
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x15F1C40 Offset: 0x15F0240 VA: 0x1815F1C40
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x107ABF0 Offset: 0x10791F0 VA: 0x18107ABF0
	public int get_characterLimit() { }

	// RVA: 0x15F16F0 Offset: 0x15EFCF0 VA: 0x1815F16F0
	public void set_characterLimit(int value) { }

	// RVA: 0xC74210 Offset: 0xC72810 VA: 0x180C74210
	public InputField.ContentType get_contentType() { }

	// RVA: 0x15F1810 Offset: 0x15EFE10 VA: 0x1815F1810
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0xEC2040 Offset: 0xEC0640 VA: 0x180EC2040
	public InputField.LineType get_lineType() { }

	// RVA: 0x15F1B10 Offset: 0x15F0110 VA: 0x1815F1B10
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0xC74130 Offset: 0xC72730 VA: 0x180C74130
	public InputField.InputType get_inputType() { }

	// RVA: 0x15F1A30 Offset: 0x15F0030 VA: 0x1815F1A30
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0xC74140 Offset: 0xC72740 VA: 0x180C74140
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x15F1AA0 Offset: 0x15F00A0 VA: 0x1815F1AA0
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x92DF60 Offset: 0x92C560 VA: 0x18092DF60
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x15F17A0 Offset: 0x15EFDA0 VA: 0x1815F17A0
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x15F1320 Offset: 0x15EF920 VA: 0x1815F1320
	public bool get_readOnly() { }

	// RVA: 0x15F1D30 Offset: 0x15F0330 VA: 0x1815F1D30
	public void set_readOnly(bool value) { }

	// RVA: 0x15F0EB0 Offset: 0x15EF4B0 VA: 0x1815F0EB0
	public bool get_multiLine() { }

	// RVA: 0x15F0A70 Offset: 0x15EF070 VA: 0x1815F0A70
	public char get_asteriskChar() { }

	// RVA: 0x15F13A0 Offset: 0x15EF9A0 VA: 0x1815F13A0
	public void set_asteriskChar(char value) { }

	// RVA: 0x15F1390 Offset: 0x15EF990 VA: 0x1815F1390
	public bool get_wasCanceled() { }

	// RVA: 0x15E88A0 Offset: 0x15E6EA0 VA: 0x1815E88A0
	protected void ClampPos(ref int pos) { }

	// RVA: 0x15F0B70 Offset: 0x15EF170 VA: 0x1815F0B70
	protected int get_caretPositionInternal() { }

	// RVA: 0x15F14F0 Offset: 0x15EFAF0 VA: 0x1815F14F0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x15F0BA0 Offset: 0x15EF1A0 VA: 0x1815F0BA0
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x15F1600 Offset: 0x15EFC00 VA: 0x1815F1600
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x15F0C80 Offset: 0x15EF280 VA: 0x1815F0C80
	private bool get_hasSelection() { }

	// RVA: 0x15F0BA0 Offset: 0x15EF1A0 VA: 0x1815F0BA0
	public int get_caretPosition() { }

	// RVA: 0x15F1540 Offset: 0x15EFB40 VA: 0x1815F1540
	public void set_caretPosition(int value) { }

	// RVA: 0x15F0B70 Offset: 0x15EF170 VA: 0x1815F0B70
	public int get_selectionAnchorPosition() { }

	// RVA: 0x15F1D40 Offset: 0x15F0340 VA: 0x1815F1D40
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x15F0BA0 Offset: 0x15EF1A0 VA: 0x1815F0BA0
	public int get_selectionFocusPosition() { }

	// RVA: 0x15F1E30 Offset: 0x15F0430 VA: 0x1815F1E30
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x15ED880 Offset: 0x15EBE80 VA: 0x1815ED880 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15ED300 Offset: 0x15EB900 VA: 0x1815ED300 Slot: 7
	protected override void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xEE970 Offset: 0xEDD70 VA: 0x1800EE970
	// RVA: 0x15E8830 Offset: 0x15E6E30 VA: 0x1815E8830
	private IEnumerator CaretBlink() { }

	// RVA: 0x15EE890 Offset: 0x15ECE90 VA: 0x1815EE890
	private void SetCaretVisible() { }

	// RVA: 0x15EE7C0 Offset: 0x15ECDC0 VA: 0x1815EE7C0
	private void SetCaretActive() { }

	// RVA: 0x15EF760 Offset: 0x15EDD60 VA: 0x1815EF760
	private void UpdateCaretMaterial() { }

	// RVA: 0x15EDE30 Offset: 0x15EC430 VA: 0x1815EDE30
	protected void OnFocus() { }

	// RVA: 0x15EDE30 Offset: 0x15EC430 VA: 0x1815EDE30
	protected void SelectAll() { }

	// RVA: 0x15ECEE0 Offset: 0x15EB4E0 VA: 0x1815ECEE0
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x15ECFB0 Offset: 0x15EB5B0 VA: 0x1815ECFB0
	public void MoveTextStart(bool shift) { }

	// RVA: 0xC83510 Offset: 0xC81B10 VA: 0x180C83510
	private static string get_clipboard() { }

	// RVA: 0xC840F0 Offset: 0xC826F0 VA: 0x180C840F0
	private static void set_clipboard(string value) { }

	// RVA: 0x15EB210 Offset: 0x15E9810 VA: 0x1815EB210
	private bool InPlaceEditing() { }

	// RVA: 0x15EF630 Offset: 0x15EDC30 VA: 0x1815EF630
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x15EBB20 Offset: 0x15EA120 VA: 0x1815EBB20 Slot: 59
	protected virtual void LateUpdate() { }

	[ObsoleteAttribute] // RVA: 0xEEB70 Offset: 0xEDF70 VA: 0x1800EEB70
	// RVA: 0x15EE310 Offset: 0x15EC910 VA: 0x1815EE310
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x15EAFB0 Offset: 0x15E95B0 VA: 0x1815EAFB0
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x15EA9D0 Offset: 0x15E8FD0 VA: 0x1815EA9D0
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x15EC550 Offset: 0x15EAB50 VA: 0x1815EC550
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x15ED2A0 Offset: 0x15EB8A0 VA: 0x1815ED2A0 Slot: 60
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x15ED560 Offset: 0x15EBB60 VA: 0x1815ED560 Slot: 61
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xEEC90 Offset: 0xEE090 VA: 0x1800EEC90
	// RVA: 0x15EC640 Offset: 0x15EAC40 VA: 0x1815EC640
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x15EDAD0 Offset: 0x15EC0D0 VA: 0x1815EDAD0 Slot: 62
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x15EDEC0 Offset: 0x15EC4C0 VA: 0x1815EDEC0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x15EB530 Offset: 0x15E9B30 VA: 0x1815EB530
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x15EB4D0 Offset: 0x15E9AD0 VA: 0x1815EB4D0
	private bool IsValidChar(char c) { }

	// RVA: 0x15EE2F0 Offset: 0x15EC8F0 VA: 0x1815EE2F0
	public void ProcessEvent(Event e) { }

	// RVA: 0x15EE190 Offset: 0x15EC790 VA: 0x1815EE190 Slot: 63
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x15EAEB0 Offset: 0x15E94B0 VA: 0x1815EAEB0
	private string GetSelectedString() { }

	// RVA: 0x15E9340 Offset: 0x15E7940 VA: 0x1815E9340
	private int FindtNextWordBegin() { }

	// RVA: 0x15ECC00 Offset: 0x15EB200 VA: 0x1815ECC00
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x15E9450 Offset: 0x15E7A50 VA: 0x1815E9450
	private int FindtPrevWordBegin() { }

	// RVA: 0x15EC940 Offset: 0x15EAF40 VA: 0x1815EC940
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x15E8FB0 Offset: 0x15E75B0 VA: 0x1815E8FB0
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x15EC270 Offset: 0x15EA870 VA: 0x1815EC270
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x15EBFF0 Offset: 0x15EA5F0 VA: 0x1815EBFF0
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x15EC6D0 Offset: 0x15EACD0 VA: 0x1815EC6D0
	private void MoveDown(bool shift) { }

	// RVA: 0x15EC6E0 Offset: 0x15EACE0 VA: 0x1815EC6E0
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x15ED070 Offset: 0x15EB670 VA: 0x1815ED070
	private void MoveUp(bool shift) { }

	// RVA: 0x15ED080 Offset: 0x15EB680 VA: 0x1815ED080
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x15E8CA0 Offset: 0x15E72A0 VA: 0x1815E8CA0
	private void Delete() { }

	// RVA: 0x15E9550 Offset: 0x15E7B50 VA: 0x1815E9550
	private void ForwardSpace() { }

	// RVA: 0x15E8690 Offset: 0x15E6C90 VA: 0x1815E8690
	private void Backspace() { }

	// RVA: 0x15EB240 Offset: 0x15E9840 VA: 0x1815EB240
	private void Insert(char c) { }

	// RVA: 0x15F0140 Offset: 0x15EE740 VA: 0x1815F0140
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x15EE6F0 Offset: 0x15ECCF0 VA: 0x1815EE6F0
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x15EE760 Offset: 0x15ECD60 VA: 0x1815EE760
	private void SendOnValueChanged() { }

	// RVA: 0x15EE690 Offset: 0x15ECC90 VA: 0x1815EE690
	protected void SendOnSubmit() { }

	// RVA: 0x15E7CB0 Offset: 0x15E62B0 VA: 0x1815E7CB0 Slot: 64
	protected virtual void Append(string input) { }

	// RVA: 0x15E7D60 Offset: 0x15E6360 VA: 0x1815E7D60 Slot: 65
	protected virtual void Append(char input) { }

	// RVA: 0x15EFCD0 Offset: 0x15EE2D0 VA: 0x1815EFCD0
	protected void UpdateLabel() { }

	// RVA: 0x15EB400 Offset: 0x15E9A00 VA: 0x1815EB400
	private bool IsSelectionVisible() { }

	// RVA: 0x15EAD80 Offset: 0x15E9380 VA: 0x1815EAD80
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x15EAC50 Offset: 0x15E9250 VA: 0x1815EAC50
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x15EE8D0 Offset: 0x15ECED0 VA: 0x1815EE8D0
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x15E9540 Offset: 0x15E7B40 VA: 0x1815E9540
	public void ForceLabelUpdate() { }

	// RVA: 0x15EC4F0 Offset: 0x15EAAF0 VA: 0x1815EC4F0
	private void MarkGeometryAsDirty() { }

	// RVA: 0x15EE300 Offset: 0x15EC900 VA: 0x1815EE300 Slot: 66
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 67
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 68
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x15EF880 Offset: 0x15EDE80 VA: 0x1815EF880
	private void UpdateGeometry() { }

	// RVA: 0x15E7EF0 Offset: 0x15E64F0 VA: 0x1815E7EF0
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x15EDB00 Offset: 0x15EC100 VA: 0x1815EDB00
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x15E9680 Offset: 0x15E7C80 VA: 0x1815E9680
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x15E88E0 Offset: 0x15E6EE0 VA: 0x1815E88E0
	private void CreateCursorVerts() { }

	// RVA: 0x15E9FD0 Offset: 0x15E85D0 VA: 0x1815E9FD0
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x15F01A0 Offset: 0x15EE7A0 VA: 0x1815F01A0
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x15E7B60 Offset: 0x15E6160 VA: 0x1815E7B60
	public void ActivateInputField() { }

	// RVA: 0x15E7810 Offset: 0x15E5E10 VA: 0x1815E7810
	private void ActivateInputFieldInternal() { }

	// RVA: 0x15EE100 Offset: 0x15EC700 VA: 0x1815EE100 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x15EDE90 Offset: 0x15EC490 VA: 0x1815EDE90 Slot: 69
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x15E8A80 Offset: 0x15E7080 VA: 0x1815E8A80
	public void DeactivateInputField() { }

	// RVA: 0x15ED2D0 Offset: 0x15EB8D0 VA: 0x1815ED2D0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x15EE140 Offset: 0x15EC740 VA: 0x1815EE140 Slot: 70
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x15E9110 Offset: 0x15E7710 VA: 0x1815E9110
	private void EnforceContentType() { }

	// RVA: 0x15E9280 Offset: 0x15E7880 VA: 0x1815E9280
	private void EnforceTextHOverflow() { }

	// RVA: 0x15EF5A0 Offset: 0x15EDBA0 VA: 0x1815EF5A0
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x15EF610 Offset: 0x15EDC10 VA: 0x1815EF610
	private void SetToCustom() { }

	// RVA: 0x15E90E0 Offset: 0x15E76E0 VA: 0x1815E90E0 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 71
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 72
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 73
	public virtual float get_minWidth() { }

	// RVA: 0x15F1140 Offset: 0x15EF740 VA: 0x1815F1140 Slot: 74
	public virtual float get_preferredWidth() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 75
	public virtual float get_flexibleWidth() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 76
	public virtual float get_minHeight() { }

	// RVA: 0x15F0ED0 Offset: 0x15EF4D0 VA: 0x1815F0ED0 Slot: 77
	public virtual float get_preferredHeight() { }

	// RVA: 0xC835F0 Offset: 0xC81BF0 VA: 0x180C835F0 Slot: 78
	public virtual float get_flexibleHeight() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 79
	public virtual int get_layoutPriority() { }

	// RVA: 0x15F0830 Offset: 0x15EEE30 VA: 0x1815F0830
	private static void .cctor() { }

	// RVA: 0xABDAA0 Offset: 0xABC0A0 VA: 0x180ABDAA0 Slot: 46
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

	// RVA: 0xD985C0 Offset: 0xD96BC0 VA: 0x180D985C0 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x1710650 Offset: 0x170EC50 VA: 0x181710650 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0xD98590 Offset: 0xD96B90 VA: 0x180D98590 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }

}

public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 4952
{	// Methods

	// RVA: 0x1720220 Offset: 0x171E820 VA: 0x181720220
	public void .ctor() { }

}

public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 4953
{	// Methods

	// RVA: 0x1710610 Offset: 0x170EC10 VA: 0x181710610
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

	// RVA: 0x1720260 Offset: 0x171E860 VA: 0x181720260 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17203B0 Offset: 0x171E9B0 VA: 0x1817203B0 Slot: 8
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

	// RVA: 0x1720780 Offset: 0x171ED80 VA: 0x181720780 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1720A50 Offset: 0x171F050 VA: 0x181720A50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

