public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 5015
{	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0xE8
	public Graphic graphic; // 0xF0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ToggleGroup m_Group; // 0xF8
	public Toggle.ToggleEvent onValueChanged; // 0x100
	[TooltipAttribute] // RVA: 0x7DD30 Offset: 0x7D130 VA: 0x18007DD30
	[SerializeField] // RVA: 0x7DD30 Offset: 0x7D130 VA: 0x18007DD30
	private bool m_IsOn; // 0x108

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	public ToggleGroup get_group() { }

	// RVA: 0x2248150 Offset: 0x2246750 VA: 0x182248150
	public void set_group(ToggleGroup value) { }

	// RVA: 0x22480A0 Offset: 0x22466A0 VA: 0x1822480A0
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x22479A0 Offset: 0x2245FA0 VA: 0x1822479A0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2247B70 Offset: 0x2246170 VA: 0x182247B70 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2247B40 Offset: 0x2246140 VA: 0x182247B40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2247A30 Offset: 0x2246030 VA: 0x182247A30 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2247D00 Offset: 0x2246300 VA: 0x182247D00
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0xA2A990 Offset: 0xA28F90 VA: 0x180A2A990
	public bool get_isOn() { }

	// RVA: 0x22481A0 Offset: 0x22467A0 VA: 0x1822481A0
	public void set_isOn(bool value) { }

	// RVA: 0x2247CF0 Offset: 0x22462F0 VA: 0x182247CF0
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x2247F30 Offset: 0x2246530 VA: 0x182247F30
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x2247C20 Offset: 0x2246220 VA: 0x182247C20
	private void PlayEffect(bool instant) { }

	// RVA: 0x2248090 Offset: 0x2246690 VA: 0x182248090 Slot: 6
	protected override void Start() { }

	// RVA: 0x2247940 Offset: 0x2245F40 VA: 0x182247940
	private void InternalToggle() { }

	// RVA: 0x2247BB0 Offset: 0x22461B0 VA: 0x182247BB0 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2247940 Offset: 0x2245F40 VA: 0x182247940 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum Toggle.ToggleTransition // TypeDefIndex: 5016
{	// Fields
	public int value__; // 0x0
	public const Toggle.ToggleTransition None = 0;
	public const Toggle.ToggleTransition Fade = 1;

}

public class Toggle.ToggleEvent : UnityEvent<bool> // TypeDefIndex: 5017
{	// Methods

	// RVA: 0x2247010 Offset: 0x2245610 VA: 0x182247010
	public void .ctor() { }

}

