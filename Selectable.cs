public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 5003
{	// Fields
	private static Selectable[] s_Selectables; // 0x0
	private static int s_SelectableCount; // 0x8
	private static bool s_IsDirty; // 0xC
	[FormerlySerializedAsAttribute] // RVA: 0x7B210 Offset: 0x7A610 VA: 0x18007B210
	[SerializeField] // RVA: 0x7B210 Offset: 0x7A610 VA: 0x18007B210
	private Navigation m_Navigation; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x7B490 Offset: 0x7A890 VA: 0x18007B490
	[SerializeField] // RVA: 0x7B490 Offset: 0x7A890 VA: 0x18007B490
	private Selectable.Transition m_Transition; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0x7B580 Offset: 0x7A980 VA: 0x18007B580
	[SerializeField] // RVA: 0x7B580 Offset: 0x7A980 VA: 0x18007B580
	private ColorBlock m_Colors; // 0x44
	[FormerlySerializedAsAttribute] // RVA: 0x7B790 Offset: 0x7AB90 VA: 0x18007B790
	[SerializeField] // RVA: 0x7B790 Offset: 0x7AB90 VA: 0x18007B790
	private SpriteState m_SpriteState; // 0xA0
	[FormerlySerializedAsAttribute] // RVA: 0x7B8C0 Offset: 0x7ACC0 VA: 0x18007B8C0
	[SerializeField] // RVA: 0x7B8C0 Offset: 0x7ACC0 VA: 0x18007B8C0
	private AnimationTriggers m_AnimationTriggers; // 0xC0
	[TooltipAttribute] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	[SerializeField] // RVA: 0x7BAD0 Offset: 0x7AED0 VA: 0x18007BAD0
	private bool m_Interactable; // 0xC8
	[FormerlySerializedAsAttribute] // RVA: 0x7BBA0 Offset: 0x7AFA0 VA: 0x18007BBA0
	[FormerlySerializedAsAttribute] // RVA: 0x7BBA0 Offset: 0x7AFA0 VA: 0x18007BBA0
	[SerializeField] // RVA: 0x7BBA0 Offset: 0x7AFA0 VA: 0x18007BBA0
	private Graphic m_TargetGraphic; // 0xD0
	private bool m_GroupsAllowInteraction; // 0xD8
	private bool m_WillRemove; // 0xD9
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <isPointerInside>k__BackingField; // 0xDA
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <isPointerDown>k__BackingField; // 0xDB
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <hasSelection>k__BackingField; // 0xDC
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xE0

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[ObsoleteAttribute] // RVA: 0x7C670 Offset: 0x7BA70 VA: 0x18007C670
	public static List<Selectable> allSelectables { get; }
	public Navigation navigation { get; set; }
	public Selectable.Transition transition { get; set; }
	public ColorBlock colors { get; set; }
	public SpriteState spriteState { get; set; }
	public AnimationTriggers animationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool interactable { get; set; }
	private bool isPointerInside { get; set; }
	private bool isPointerDown { get; set; }
	private bool hasSelection { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	protected Selectable.SelectionState currentSelectionState { get; }

	// Methods

	// RVA: 0x171D690 Offset: 0x171BC90 VA: 0x18171D690
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x171D630 Offset: 0x171BC30 VA: 0x18171D630
	public static int get_allSelectableCount() { }

	// RVA: 0x171D770 Offset: 0x171BD70 VA: 0x18171D770
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x171AF30 Offset: 0x1719530 VA: 0x18171AF30
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x1650250 Offset: 0x164E850 VA: 0x181650250
	public Navigation get_navigation() { }

	// RVA: 0x171DD20 Offset: 0x171C320 VA: 0x18171DD20
	public void set_navigation(Navigation value) { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public Selectable.Transition get_transition() { }

	// RVA: 0x171DE70 Offset: 0x171C470 VA: 0x18171DE70
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x171D900 Offset: 0x171BF00 VA: 0x18171D900
	public ColorBlock get_colors() { }

	// RVA: 0x171DAD0 Offset: 0x171C0D0 VA: 0x18171DAD0
	public void set_colors(ColorBlock value) { }

	// RVA: 0x171DA50 Offset: 0x171C050 VA: 0x18171DA50
	public SpriteState get_spriteState() { }

	// RVA: 0x171DDA0 Offset: 0x171C3A0 VA: 0x18171DDA0
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x171DA70 Offset: 0x171C070 VA: 0x18171DA70
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	public Graphic get_targetGraphic() { }

	// RVA: 0x171DE10 Offset: 0x171C410 VA: 0x18171DE10
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x79BE00 Offset: 0x79A400 VA: 0x18079BE00
	public bool get_interactable() { }

	// RVA: 0x171DB80 Offset: 0x171C180 VA: 0x18171DB80
	public void set_interactable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x171DA40 Offset: 0x171C040 VA: 0x18171DA40
	private bool get_isPointerInside() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x171DD10 Offset: 0x171C310 VA: 0x18171DD10
	private void set_isPointerInside(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x171DA30 Offset: 0x171C030 VA: 0x18171DA30
	private bool get_isPointerDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x171DD00 Offset: 0x171C300 VA: 0x18171DD00
	private void set_isPointerDown(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15E7030 Offset: 0x15E5630 VA: 0x1815E7030
	private bool get_hasSelection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x171DB70 Offset: 0x171C170 VA: 0x18171DB70
	private void set_hasSelection(bool value) { }

	// RVA: 0x171D4F0 Offset: 0x171BAF0 VA: 0x18171D4F0
	protected void .ctor() { }

	// RVA: 0x171D9B0 Offset: 0x171BFB0 VA: 0x18171D9B0
	public Image get_image() { }

	// RVA: 0x79BE70 Offset: 0x79A470 VA: 0x18079BE70
	public void set_image(Image value) { }

	// RVA: 0x171D8C0 Offset: 0x171BEC0 VA: 0x18171D8C0
	public Animator get_animator() { }

	// RVA: 0x171B060 Offset: 0x1719660 VA: 0x18171B060 Slot: 4
	protected override void Awake() { }

	// RVA: 0x171C3D0 Offset: 0x171A9D0 VA: 0x18171C3D0 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x171C2B0 Offset: 0x171A8B0 VA: 0x18171C2B0 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x171C5C0 Offset: 0x171ABC0 VA: 0x18171C5C0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x171C6B0 Offset: 0x171ACB0 VA: 0x18171C6B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x171CDA0 Offset: 0x171B3A0 VA: 0x18171CDA0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x171C5C0 Offset: 0x171ABC0 VA: 0x18171C5C0
	private void OnSetProperty() { }

	// RVA: 0x171C630 Offset: 0x171AC30 VA: 0x18171C630 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x171CDD0 Offset: 0x171B3D0 VA: 0x18171CDD0
	private static void RemoveInvalidSelectables() { }

	// RVA: 0x171D940 Offset: 0x171BF40 VA: 0x18171D940
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x171C120 Offset: 0x171A720 VA: 0x18171C120 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x171B1A0 Offset: 0x17197A0 VA: 0x18171B1A0 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x171B8F0 Offset: 0x1719EF0 VA: 0x18171B8F0
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x171BE70 Offset: 0x171A470 VA: 0x18171BE70
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x171C320 Offset: 0x171A920 VA: 0x18171C320
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x171B530 Offset: 0x1719B30 VA: 0x18171B530 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x171B670 Offset: 0x1719C70 VA: 0x18171B670 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x171B7B0 Offset: 0x1719DB0 VA: 0x18171B7B0 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x171B3F0 Offset: 0x17199F0 VA: 0x18171B3F0 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x171C920 Offset: 0x171AF20 VA: 0x18171C920 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x171D130 Offset: 0x171B730 VA: 0x18171D130
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x171B100 Offset: 0x1719700 VA: 0x18171B100
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x171D210 Offset: 0x171B810 VA: 0x18171D210
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x171C250 Offset: 0x171A850 VA: 0x18171C250
	protected bool IsHighlighted() { }

	// RVA: 0x171C2D0 Offset: 0x171A8D0 VA: 0x18171C2D0
	protected bool IsPressed() { }

	// RVA: 0x171B380 Offset: 0x1719980 VA: 0x18171B380
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x171CA50 Offset: 0x171B050 VA: 0x18171CA50 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x171CCB0 Offset: 0x171B2B0 VA: 0x18171CCB0 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x171CBD0 Offset: 0x171B1D0 VA: 0x18171CBD0 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x171CC40 Offset: 0x171B240 VA: 0x18171CC40 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x171CD30 Offset: 0x171B330 VA: 0x18171CD30 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x171C550 Offset: 0x171AB50 VA: 0x18171C550 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x171D020 Offset: 0x171B620 VA: 0x18171D020 Slot: 38
	public virtual void Select() { }

	// RVA: 0x171D470 Offset: 0x171BA70 VA: 0x18171D470
	private static void .cctor() { }

}

public enum Selectable.Transition // TypeDefIndex: 5004
{	// Fields
	public int value__; // 0x0
	public const Selectable.Transition None = 0;
	public const Selectable.Transition ColorTint = 1;
	public const Selectable.Transition SpriteSwap = 2;
	public const Selectable.Transition Animation = 3;

}

