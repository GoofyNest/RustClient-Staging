public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 5015
{	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0xE8
	public Graphic graphic; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ToggleGroup m_Group; // 0xF8
	public Toggle.ToggleEvent onValueChanged; // 0x100
	[TooltipAttribute] // RVA: 0x7DE00 Offset: 0x7D200 VA: 0x18007DE00
	[SerializeField] // RVA: 0x7DE00 Offset: 0x7D200 VA: 0x18007DE00
	private bool m_IsOn; // 0x108

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0xB0F550 Offset: 0xB0DB50 VA: 0x180B0F550
	public ToggleGroup get_group() { }

	// RVA: 0x2248A70 Offset: 0x2247070 VA: 0x182248A70
	public void set_group(ToggleGroup value) { }

	// RVA: 0x22489C0 Offset: 0x2246FC0 VA: 0x1822489C0
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x22482C0 Offset: 0x22468C0 VA: 0x1822482C0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2248490 Offset: 0x2246A90 VA: 0x182248490 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2248460 Offset: 0x2246A60 VA: 0x182248460 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2248350 Offset: 0x2246950 VA: 0x182248350 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2248620 Offset: 0x2246C20 VA: 0x182248620
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0xA2B140 Offset: 0xA29740 VA: 0x180A2B140
	public bool get_isOn() { }

	// RVA: 0x2248AC0 Offset: 0x22470C0 VA: 0x182248AC0
	public void set_isOn(bool value) { }

	// RVA: 0x2248610 Offset: 0x2246C10 VA: 0x182248610
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x2248850 Offset: 0x2246E50 VA: 0x182248850
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x2248540 Offset: 0x2246B40 VA: 0x182248540
	private void PlayEffect(bool instant) { }

	// RVA: 0x22489B0 Offset: 0x2246FB0 VA: 0x1822489B0 Slot: 6
	protected override void Start() { }

	// RVA: 0x2248260 Offset: 0x2246860 VA: 0x182248260
	private void InternalToggle() { }

	// RVA: 0x22484D0 Offset: 0x2246AD0 VA: 0x1822484D0 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2248260 Offset: 0x2246860 VA: 0x182248260 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0xABDAA0 Offset: 0xABC0A0 VA: 0x180ABDAA0 Slot: 42
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

	// RVA: 0x2247930 Offset: 0x2245F30 VA: 0x182247930
	public void .ctor() { }

}

