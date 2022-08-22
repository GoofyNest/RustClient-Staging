public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 4921
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform m_Template; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text m_CaptionText; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image m_CaptionImage; // 0xF8
	[SpaceAttribute] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	[SerializeField] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	private Text m_ItemText; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image m_ItemImage; // 0x108
	[SpaceAttribute] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	[SerializeField] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	private int m_Value; // 0x110
	[SpaceAttribute] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	[SerializeField] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	private Dropdown.OptionDataList m_Options; // 0x118
	[SpaceAttribute] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	[SerializeField] // RVA: 0x7CD40 Offset: 0x7C140 VA: 0x18007CD40
	private Dropdown.DropdownEvent m_OnValueChanged; // 0x120
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_AlphaFadeSpeed; // 0x128
	private GameObject m_Dropdown; // 0x130
	private GameObject m_Blocker; // 0x138
	private List<Dropdown.DropdownItem> m_Items; // 0x140
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x148
	private bool validTemplate; // 0x150
	private static Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }

	// Methods

	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	public RectTransform get_template() { }

	// RVA: 0x10C2B80 Offset: 0x10C1180 VA: 0x1810C2B80
	public void set_template(RectTransform value) { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public Text get_captionText() { }

	// RVA: 0x10C2AB0 Offset: 0x10C10B0 VA: 0x1810C2AB0
	public void set_captionText(Text value) { }

	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	public Image get_captionImage() { }

	// RVA: 0x10C2A80 Offset: 0x10C1080 VA: 0x1810C2A80
	public void set_captionImage(Image value) { }

	// RVA: 0xA2A920 Offset: 0xA28F20 VA: 0x180A2A920
	public Text get_itemText() { }

	// RVA: 0x10C2B10 Offset: 0x10C1110 VA: 0x1810C2B10
	public void set_itemText(Text value) { }

	// RVA: 0xC831A0 Offset: 0xC817A0 VA: 0x180C831A0
	public Image get_itemImage() { }

	// RVA: 0x10C2AE0 Offset: 0x10C10E0 VA: 0x1810C2AE0
	public void set_itemImage(Image value) { }

	// RVA: 0x10C2A50 Offset: 0x10C1050 VA: 0x1810C2A50
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x10C2B40 Offset: 0x10C1140 VA: 0x1810C2B40
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x7DDC60 Offset: 0x7DC260 VA: 0x1807DDC60
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0xC73C70 Offset: 0xC72270 VA: 0x180C73C70
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0xC83360 Offset: 0xC81960 VA: 0x180C83360
	public float get_alphaFadeSpeed() { }

	// RVA: 0x10C2A70 Offset: 0x10C1070 VA: 0x1810C2A70
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0xEC12D0 Offset: 0xEBF8D0 VA: 0x180EC12D0
	public int get_value() { }

	// RVA: 0x10C2BB0 Offset: 0x10C11B0 VA: 0x1810C2BB0
	public void set_value(int value) { }

	// RVA: 0x10C1110 Offset: 0x10BF710 VA: 0x1810C1110
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x10C1120 Offset: 0x10BF720 VA: 0x1810C1120
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x10C2960 Offset: 0x10C0F60 VA: 0x1810C2960
	protected void .ctor() { }

	// RVA: 0x10BFEF0 Offset: 0x10BE4F0 VA: 0x1810BFEF0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x10C28F0 Offset: 0x10C0EF0 VA: 0x1810C28F0 Slot: 6
	protected override void Start() { }

	// RVA: 0x10C0AE0 Offset: 0x10BF0E0 VA: 0x1810C0AE0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10C0E50 Offset: 0x10BF450 VA: 0x1810C0E50
	public void RefreshShownValue() { }

	// RVA: 0x10BFCB0 Offset: 0x10BE2B0 VA: 0x1810BFCB0
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x10BFAD0 Offset: 0x10BE0D0 VA: 0x1810BFAD0
	public void AddOptions(List<string> options) { }

	// RVA: 0x10BFBC0 Offset: 0x10BE1C0 VA: 0x1810BFBC0
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x10C0070 Offset: 0x10BE670 VA: 0x1810C0070
	public void ClearOptions() { }

	// RVA: 0x10C1250 Offset: 0x10BF850 VA: 0x1810C1250
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159EDE0 Offset: 0x159D3E0 VA: 0x18159EDE0
	|-Dropdown.GetOrAddComponent<object>
	|-Dropdown.GetOrAddComponent<Canvas>
	|-Dropdown.GetOrAddComponent<CanvasGroup>
	|-Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x10C0D10 Offset: 0x10BF310 VA: 0x1810C0D10 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10C0D10 Offset: 0x10BF310 VA: 0x1810C0D10 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x10C0AD0 Offset: 0x10BF0D0 VA: 0x1810C0AD0 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x10C1930 Offset: 0x10BFF30 VA: 0x1810C1930
	public void Show() { }

	// RVA: 0x10C00E0 Offset: 0x10BE6E0 VA: 0x1810C00E0 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x10C0680 Offset: 0x10BEC80 VA: 0x1810C0680 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x10C0540 Offset: 0x10BEB40 VA: 0x1810C0540 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x10C06E0 Offset: 0x10BECE0 VA: 0x1810C06E0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x10C05A0 Offset: 0x10BEBA0 VA: 0x1810C05A0 Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x10BF820 Offset: 0x10BDE20 VA: 0x1810BF820
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x10BFD20 Offset: 0x10BE320 VA: 0x1810BFD20
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x10BFDB0 Offset: 0x10BE3B0 VA: 0x1810BFDB0
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x10C1060 Offset: 0x10BF660 VA: 0x1810C1060
	private void SetAlpha(float alpha) { }

	// RVA: 0x10C0740 Offset: 0x10BED40 VA: 0x1810C0740
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0xE79A0 Offset: 0xE6DA0 VA: 0x1800E79A0
	// RVA: 0x10C0600 Offset: 0x10BEC00 VA: 0x1810C0600
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x10C0930 Offset: 0x10BEF30 VA: 0x1810C0930
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x10C0D20 Offset: 0x10BF320 VA: 0x1810C0D20
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x10C2900 Offset: 0x10C0F00 VA: 0x1810C2900
	private static void .cctor() { }

}

public class Dropdown.OptionData // TypeDefIndex: 4923
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite m_Image; // 0x18

	// Properties
	public string text { get; set; }
	public Sprite image { get; set; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_text() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_text(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Sprite get_image() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_image(Sprite value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(string text) { }

	// RVA: 0x10B5840 Offset: 0x10B3E40 VA: 0x1810B5840
	public void .ctor(Sprite image) { }

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string text, Sprite image) { }

}

public class Dropdown.OptionDataList // TypeDefIndex: 4924
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x1604B80 Offset: 0x1603180 VA: 0x181604B80
	public void .ctor() { }

}

public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 4925
{	// Methods

	// RVA: 0x15EA610 Offset: 0x15E8C10 VA: 0x1815EA610
	public void .ctor() { }

}

private sealed class Dropdown.<>c__DisplayClass62_0 // TypeDefIndex: 4926
{	// Fields
	public Dropdown.DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1604D40 Offset: 0x1603340 VA: 0x181604D40
	internal void <Show>b__0(bool x) { }

}

private sealed class Dropdown.<DelayedDestroyDropdownList>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4927
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public Dropdown <>4__this; // 0x28

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

	// RVA: 0x1604BF0 Offset: 0x16031F0 VA: 0x181604BF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1604CA0 Offset: 0x16032A0 VA: 0x181604CA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class Dropdown : RustControl, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 7005
{	// Fields
	public RustIcon Icon; // 0x30
	public RustText Text; // 0x38
	public RustIcon OptionIcon; // 0x40
	public Option[] Options; // 0x48
	private int CurrentOption; // 0x50
	public Dropdown.ChangedEvent OnChanged; // 0x58

	// Properties
	public Option Value { get; }

	// Methods

	// RVA: 0xFBEE00 Offset: 0xFBD400 VA: 0x180FBEE00
	public Option get_Value() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFBED20 Offset: 0xFBD320 VA: 0x180FBED20
	public void SetOptions(Option[] options) { }

	// RVA: 0xFBEAA0 Offset: 0xFBD0A0 VA: 0x180FBEAA0
	protected void SetOptionFromUser(Option option) { }

	// RVA: 0xFBEBA0 Offset: 0xFBD1A0 VA: 0x180FBEBA0
	public void SetOption(int i) { }

	// RVA: 0xFBEC70 Offset: 0xFBD270 VA: 0x180FBEC70
	public void SetOption(Option option) { }

	// RVA: 0xFBEA40 Offset: 0xFBD040 VA: 0x180FBEA40
	public void SetOptionDefault() { }

	// RVA: 0xFBE610 Offset: 0xFBCC10 VA: 0x180FBE610
	public void OnLeft() { }

	// RVA: 0xFBE6C0 Offset: 0xFBCCC0 VA: 0x180FBE6C0
	public void OnRight() { }

	// RVA: 0xFBE430 Offset: 0xFBCA30 VA: 0x180FBE430 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFBE6B0 Offset: 0xFBCCB0 VA: 0x180FBE6B0 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFBE760 Offset: 0xFBCD60 VA: 0x180FBE760
	public void OpenMenu() { }

	// RVA: 0xFBEDA0 Offset: 0xFBD3A0 VA: 0x180FBEDA0
	public void .ctor() { }

}

public class Dropdown.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7006
{	// Methods

	// RVA: 0xFBDF00 Offset: 0xFBC500 VA: 0x180FBDF00
	public void .ctor() { }

}

