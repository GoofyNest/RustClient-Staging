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

	// RVA: 0xB0F080 Offset: 0xB0D680 VA: 0x180B0F080
	public ToggleGroup get_group() { }

	// RVA: 0x2248250 Offset: 0x2246850 VA: 0x182248250
	public void set_group(ToggleGroup value) { }

	// RVA: 0x22481A0 Offset: 0x22467A0 VA: 0x1822481A0
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2247AA0 Offset: 0x22460A0 VA: 0x182247AA0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2247C70 Offset: 0x2246270 VA: 0x182247C70 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2247C40 Offset: 0x2246240 VA: 0x182247C40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2247B30 Offset: 0x2246130 VA: 0x182247B30 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2247E00 Offset: 0x2246400 VA: 0x182247E00
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0xA2AC50 Offset: 0xA29250 VA: 0x180A2AC50
	public bool get_isOn() { }

	// RVA: 0x22482A0 Offset: 0x22468A0 VA: 0x1822482A0
	public void set_isOn(bool value) { }

	// RVA: 0x2247DF0 Offset: 0x22463F0 VA: 0x182247DF0
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x2248030 Offset: 0x2246630 VA: 0x182248030
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x2247D20 Offset: 0x2246320 VA: 0x182247D20
	private void PlayEffect(bool instant) { }

	// RVA: 0x2248190 Offset: 0x2246790 VA: 0x182248190 Slot: 6
	protected override void Start() { }

	// RVA: 0x2247A40 Offset: 0x2246040 VA: 0x182247A40
	private void InternalToggle() { }

	// RVA: 0x2247CB0 Offset: 0x22462B0 VA: 0x182247CB0 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2247A40 Offset: 0x2246040 VA: 0x182247A40 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0xABD5D0 Offset: 0xABBBD0 VA: 0x180ABD5D0 Slot: 42
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

	// RVA: 0x2247110 Offset: 0x2245710 VA: 0x182247110
	public void .ctor() { }

}

