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

	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	public RectTransform get_template() { }

	// RVA: 0x10C38B0 Offset: 0x10C1EB0 VA: 0x1810C38B0
	public void set_template(RectTransform value) { }

	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public Text get_captionText() { }

	// RVA: 0x10C37E0 Offset: 0x10C1DE0 VA: 0x1810C37E0
	public void set_captionText(Text value) { }

	// RVA: 0xB0F550 Offset: 0xB0DB50 VA: 0x180B0F550
	public Image get_captionImage() { }

	// RVA: 0x10C37B0 Offset: 0x10C1DB0 VA: 0x1810C37B0
	public void set_captionImage(Image value) { }

	// RVA: 0xA2B0D0 Offset: 0xA296D0 VA: 0x180A2B0D0
	public Text get_itemText() { }

	// RVA: 0x10C3840 Offset: 0x10C1E40 VA: 0x1810C3840
	public void set_itemText(Text value) { }

	// RVA: 0xC83900 Offset: 0xC81F00 VA: 0x180C83900
	public Image get_itemImage() { }

	// RVA: 0x10C3810 Offset: 0x10C1E10 VA: 0x1810C3810
	public void set_itemImage(Image value) { }

	// RVA: 0x10C3780 Offset: 0x10C1D80 VA: 0x1810C3780
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x10C3870 Offset: 0x10C1E70 VA: 0x1810C3870
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x7A9690 Offset: 0x7A7C90 VA: 0x1807A9690
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0xC743E0 Offset: 0xC729E0 VA: 0x180C743E0
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0xC83AC0 Offset: 0xC820C0 VA: 0x180C83AC0
	public float get_alphaFadeSpeed() { }

	// RVA: 0x10C37A0 Offset: 0x10C1DA0 VA: 0x1810C37A0
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0xEC2040 Offset: 0xEC0640 VA: 0x180EC2040
	public int get_value() { }

	// RVA: 0x10C38E0 Offset: 0x10C1EE0 VA: 0x1810C38E0
	public void set_value(int value) { }

	// RVA: 0x10C1E40 Offset: 0x10C0440 VA: 0x1810C1E40
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x10C1E50 Offset: 0x10C0450 VA: 0x1810C1E50
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x10C3690 Offset: 0x10C1C90 VA: 0x1810C3690
	protected void .ctor() { }

	// RVA: 0x10C0C20 Offset: 0x10BF220 VA: 0x1810C0C20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x10C3620 Offset: 0x10C1C20 VA: 0x1810C3620 Slot: 6
	protected override void Start() { }

	// RVA: 0x10C1810 Offset: 0x10BFE10 VA: 0x1810C1810 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10C1B80 Offset: 0x10C0180 VA: 0x1810C1B80
	public void RefreshShownValue() { }

	// RVA: 0x10C09E0 Offset: 0x10BEFE0 VA: 0x1810C09E0
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x10C0800 Offset: 0x10BEE00 VA: 0x1810C0800
	public void AddOptions(List<string> options) { }

	// RVA: 0x10C08F0 Offset: 0x10BEEF0 VA: 0x1810C08F0
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x10C0DA0 Offset: 0x10BF3A0 VA: 0x1810C0DA0
	public void ClearOptions() { }

	// RVA: 0x10C1F80 Offset: 0x10C0580 VA: 0x1810C1F80
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E170 Offset: 0x159C770 VA: 0x18159E170
	|-Dropdown.GetOrAddComponent<object>
	|-Dropdown.GetOrAddComponent<Canvas>
	|-Dropdown.GetOrAddComponent<CanvasGroup>
	|-Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x10C1A40 Offset: 0x10C0040 VA: 0x1810C1A40 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10C1A40 Offset: 0x10C0040 VA: 0x1810C1A40 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x10C1800 Offset: 0x10BFE00 VA: 0x1810C1800 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x10C2660 Offset: 0x10C0C60 VA: 0x1810C2660
	public void Show() { }

	// RVA: 0x10C0E10 Offset: 0x10BF410 VA: 0x1810C0E10 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x10C13B0 Offset: 0x10BF9B0 VA: 0x1810C13B0 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x10C1270 Offset: 0x10BF870 VA: 0x1810C1270 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x10C1410 Offset: 0x10BFA10 VA: 0x1810C1410 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x10C12D0 Offset: 0x10BF8D0 VA: 0x1810C12D0 Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x10C0550 Offset: 0x10BEB50 VA: 0x1810C0550
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x10C0A50 Offset: 0x10BF050 VA: 0x1810C0A50
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x10C0AE0 Offset: 0x10BF0E0 VA: 0x1810C0AE0
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x10C1D90 Offset: 0x10C0390 VA: 0x1810C1D90
	private void SetAlpha(float alpha) { }

	// RVA: 0x10C1470 Offset: 0x10BFA70 VA: 0x1810C1470
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0xE79A0 Offset: 0xE6DA0 VA: 0x1800E79A0
	// RVA: 0x10C1330 Offset: 0x10BF930 VA: 0x1810C1330
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x10C1660 Offset: 0x10BFC60 VA: 0x1810C1660
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x10C1A50 Offset: 0x10C0050 VA: 0x1810C1A50
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x10C3630 Offset: 0x10C1C30 VA: 0x1810C3630
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

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_text() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_text(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Sprite get_image() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_image(Sprite value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(string text) { }

	// RVA: 0x10B6570 Offset: 0x10B4B70 VA: 0x1810B6570
	public void .ctor(Sprite image) { }

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(string text, Sprite image) { }

}

public class Dropdown.OptionDataList // TypeDefIndex: 4924
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x15F2160 Offset: 0x15F0760 VA: 0x1815F2160
	public void .ctor() { }

}

public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 4925
{	// Methods

	// RVA: 0x15D7BF0 Offset: 0x15D61F0 VA: 0x1815D7BF0
	public void .ctor() { }

}

private sealed class Dropdown.<>c__DisplayClass62_0 // TypeDefIndex: 4926
{	// Fields
	public Dropdown.DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x15F2320 Offset: 0x15F0920 VA: 0x1815F2320
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

	// RVA: 0x15F21D0 Offset: 0x15F07D0 VA: 0x1815F21D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15F2280 Offset: 0x15F0880 VA: 0x1815F2280 Slot: 8
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

	// RVA: 0xFBFB60 Offset: 0xFBE160 VA: 0x180FBFB60
	public Option get_Value() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFBFA80 Offset: 0xFBE080 VA: 0x180FBFA80
	public void SetOptions(Option[] options) { }

	// RVA: 0xFBF800 Offset: 0xFBDE00 VA: 0x180FBF800
	protected void SetOptionFromUser(Option option) { }

	// RVA: 0xFBF900 Offset: 0xFBDF00 VA: 0x180FBF900
	public void SetOption(int i) { }

	// RVA: 0xFBF9D0 Offset: 0xFBDFD0 VA: 0x180FBF9D0
	public void SetOption(Option option) { }

	// RVA: 0xFBF7A0 Offset: 0xFBDDA0 VA: 0x180FBF7A0
	public void SetOptionDefault() { }

	// RVA: 0xFBF370 Offset: 0xFBD970 VA: 0x180FBF370
	public void OnLeft() { }

	// RVA: 0xFBF420 Offset: 0xFBDA20 VA: 0x180FBF420
	public void OnRight() { }

	// RVA: 0xFBF190 Offset: 0xFBD790 VA: 0x180FBF190 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFBF410 Offset: 0xFBDA10 VA: 0x180FBF410 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFBF4C0 Offset: 0xFBDAC0 VA: 0x180FBF4C0
	public void OpenMenu() { }

	// RVA: 0xFBFB00 Offset: 0xFBE100 VA: 0x180FBFB00
	public void .ctor() { }

}

public class Dropdown.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7006
{	// Methods

	// RVA: 0xFBEC60 Offset: 0xFBD260 VA: 0x180FBEC60
	public void .ctor() { }

}

