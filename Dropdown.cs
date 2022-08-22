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

	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	public RectTransform get_template() { }

	// RVA: 0x10C2E40 Offset: 0x10C1440 VA: 0x1810C2E40
	public void set_template(RectTransform value) { }

	// RVA: 0xC73E20 Offset: 0xC72420 VA: 0x180C73E20
	public Text get_captionText() { }

	// RVA: 0x10C2D70 Offset: 0x10C1370 VA: 0x1810C2D70
	public void set_captionText(Text value) { }

	// RVA: 0xB0F080 Offset: 0xB0D680 VA: 0x180B0F080
	public Image get_captionImage() { }

	// RVA: 0x10C2D40 Offset: 0x10C1340 VA: 0x1810C2D40
	public void set_captionImage(Image value) { }

	// RVA: 0xA2ABE0 Offset: 0xA291E0 VA: 0x180A2ABE0
	public Text get_itemText() { }

	// RVA: 0x10C2DD0 Offset: 0x10C13D0 VA: 0x1810C2DD0
	public void set_itemText(Text value) { }

	// RVA: 0xC83460 Offset: 0xC81A60 VA: 0x180C83460
	public Image get_itemImage() { }

	// RVA: 0x10C2DA0 Offset: 0x10C13A0 VA: 0x1810C2DA0
	public void set_itemImage(Image value) { }

	// RVA: 0x10C2D10 Offset: 0x10C1310 VA: 0x1810C2D10
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x10C2E00 Offset: 0x10C1400 VA: 0x1810C2E00
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x7DDD70 Offset: 0x7DC370 VA: 0x1807DDD70
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0xC73F30 Offset: 0xC72530 VA: 0x180C73F30
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0xC83620 Offset: 0xC81C20 VA: 0x180C83620
	public float get_alphaFadeSpeed() { }

	// RVA: 0x10C2D30 Offset: 0x10C1330 VA: 0x1810C2D30
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0xEC1590 Offset: 0xEBFB90 VA: 0x180EC1590
	public int get_value() { }

	// RVA: 0x10C2E70 Offset: 0x10C1470 VA: 0x1810C2E70
	public void set_value(int value) { }

	// RVA: 0x10C13D0 Offset: 0x10BF9D0 VA: 0x1810C13D0
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x10C13E0 Offset: 0x10BF9E0 VA: 0x1810C13E0
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x10C2C20 Offset: 0x10C1220 VA: 0x1810C2C20
	protected void .ctor() { }

	// RVA: 0x10C01B0 Offset: 0x10BE7B0 VA: 0x1810C01B0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x10C2BB0 Offset: 0x10C11B0 VA: 0x1810C2BB0 Slot: 6
	protected override void Start() { }

	// RVA: 0x10C0DA0 Offset: 0x10BF3A0 VA: 0x1810C0DA0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10C1110 Offset: 0x10BF710 VA: 0x1810C1110
	public void RefreshShownValue() { }

	// RVA: 0x10BFF70 Offset: 0x10BE570 VA: 0x1810BFF70
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x10BFD90 Offset: 0x10BE390 VA: 0x1810BFD90
	public void AddOptions(List<string> options) { }

	// RVA: 0x10BFE80 Offset: 0x10BE480 VA: 0x1810BFE80
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x10C0330 Offset: 0x10BE930 VA: 0x1810C0330
	public void ClearOptions() { }

	// RVA: 0x10C1510 Offset: 0x10BFB10 VA: 0x1810C1510
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159F0A0 Offset: 0x159D6A0 VA: 0x18159F0A0
	|-Dropdown.GetOrAddComponent<object>
	|-Dropdown.GetOrAddComponent<Canvas>
	|-Dropdown.GetOrAddComponent<CanvasGroup>
	|-Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x10C0FD0 Offset: 0x10BF5D0 VA: 0x1810C0FD0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x10C0FD0 Offset: 0x10BF5D0 VA: 0x1810C0FD0 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x10C0D90 Offset: 0x10BF390 VA: 0x1810C0D90 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x10C1BF0 Offset: 0x10C01F0 VA: 0x1810C1BF0
	public void Show() { }

	// RVA: 0x10C03A0 Offset: 0x10BE9A0 VA: 0x1810C03A0 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x10C0940 Offset: 0x10BEF40 VA: 0x1810C0940 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x10C0800 Offset: 0x10BEE00 VA: 0x1810C0800 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x10C09A0 Offset: 0x10BEFA0 VA: 0x1810C09A0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x10C0860 Offset: 0x10BEE60 VA: 0x1810C0860 Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x10BFAE0 Offset: 0x10BE0E0 VA: 0x1810BFAE0
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x10BFFE0 Offset: 0x10BE5E0 VA: 0x1810BFFE0
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x10C0070 Offset: 0x10BE670 VA: 0x1810C0070
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x10C1320 Offset: 0x10BF920 VA: 0x1810C1320
	private void SetAlpha(float alpha) { }

	// RVA: 0x10C0A00 Offset: 0x10BF000 VA: 0x1810C0A00
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0xE79A0 Offset: 0xE6DA0 VA: 0x1800E79A0
	// RVA: 0x10C08C0 Offset: 0x10BEEC0 VA: 0x1810C08C0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x10C0BF0 Offset: 0x10BF1F0 VA: 0x1810C0BF0
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x10C0FE0 Offset: 0x10BF5E0 VA: 0x1810C0FE0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x10C2BC0 Offset: 0x10C11C0 VA: 0x1810C2BC0
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

	// RVA: 0x10B5B00 Offset: 0x10B4100 VA: 0x1810B5B00
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

	// RVA: 0x1604E40 Offset: 0x1603440 VA: 0x181604E40
	public void .ctor() { }

}

public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 4925
{	// Methods

	// RVA: 0x15EA8D0 Offset: 0x15E8ED0 VA: 0x1815EA8D0
	public void .ctor() { }

}

private sealed class Dropdown.<>c__DisplayClass62_0 // TypeDefIndex: 4926
{	// Fields
	public Dropdown.DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1605000 Offset: 0x1603600 VA: 0x181605000
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

	// RVA: 0x1604EB0 Offset: 0x16034B0 VA: 0x181604EB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1604F60 Offset: 0x1603560 VA: 0x181604F60 Slot: 8
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

	// RVA: 0xFBF0C0 Offset: 0xFBD6C0 VA: 0x180FBF0C0
	public Option get_Value() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFBEFE0 Offset: 0xFBD5E0 VA: 0x180FBEFE0
	public void SetOptions(Option[] options) { }

	// RVA: 0xFBED60 Offset: 0xFBD360 VA: 0x180FBED60
	protected void SetOptionFromUser(Option option) { }

	// RVA: 0xFBEE60 Offset: 0xFBD460 VA: 0x180FBEE60
	public void SetOption(int i) { }

	// RVA: 0xFBEF30 Offset: 0xFBD530 VA: 0x180FBEF30
	public void SetOption(Option option) { }

	// RVA: 0xFBED00 Offset: 0xFBD300 VA: 0x180FBED00
	public void SetOptionDefault() { }

	// RVA: 0xFBE8D0 Offset: 0xFBCED0 VA: 0x180FBE8D0
	public void OnLeft() { }

	// RVA: 0xFBE980 Offset: 0xFBCF80 VA: 0x180FBE980
	public void OnRight() { }

	// RVA: 0xFBE6F0 Offset: 0xFBCCF0 VA: 0x180FBE6F0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFBE970 Offset: 0xFBCF70 VA: 0x180FBE970 Slot: 31
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xFBEA20 Offset: 0xFBD020 VA: 0x180FBEA20
	public void OpenMenu() { }

	// RVA: 0xFBF060 Offset: 0xFBD660 VA: 0x180FBF060
	public void .ctor() { }

}

public class Dropdown.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7006
{	// Methods

	// RVA: 0xFBE1C0 Offset: 0xFBC7C0 VA: 0x180FBE1C0
	public void .ctor() { }

}

