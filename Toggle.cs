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

	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	public ToggleGroup get_group() { }

	// RVA: 0x2247F90 Offset: 0x2246590 VA: 0x182247F90
	public void set_group(ToggleGroup value) { }

	// RVA: 0x2247EE0 Offset: 0x22464E0 VA: 0x182247EE0
	protected void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x22477E0 Offset: 0x2245DE0 VA: 0x1822477E0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x22479B0 Offset: 0x2245FB0 VA: 0x1822479B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2247980 Offset: 0x2245F80 VA: 0x182247980 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2247870 Offset: 0x2245E70 VA: 0x182247870 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2247B40 Offset: 0x2246140 VA: 0x182247B40
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0xA2A990 Offset: 0xA28F90 VA: 0x180A2A990
	public bool get_isOn() { }

	// RVA: 0x2247FE0 Offset: 0x22465E0 VA: 0x182247FE0
	public void set_isOn(bool value) { }

	// RVA: 0x2247B30 Offset: 0x2246130 VA: 0x182247B30
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x2247D70 Offset: 0x2246370 VA: 0x182247D70
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x2247A60 Offset: 0x2246060 VA: 0x182247A60
	private void PlayEffect(bool instant) { }

	// RVA: 0x2247ED0 Offset: 0x22464D0 VA: 0x182247ED0 Slot: 6
	protected override void Start() { }

	// RVA: 0x2247780 Offset: 0x2245D80 VA: 0x182247780
	private void InternalToggle() { }

	// RVA: 0x22479F0 Offset: 0x2245FF0 VA: 0x1822479F0 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2247780 Offset: 0x2245D80 VA: 0x182247780 Slot: 50
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

	// RVA: 0x2246E50 Offset: 0x2245450 VA: 0x182246E50
	public void .ctor() { }

}

