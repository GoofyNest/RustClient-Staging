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

	// RVA: 0x1724250 Offset: 0x1722850 VA: 0x181724250
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x17241F0 Offset: 0x17227F0 VA: 0x1817241F0
	public static int get_allSelectableCount() { }

	// RVA: 0x1724330 Offset: 0x1722930 VA: 0x181724330
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x1721AF0 Offset: 0x17200F0 VA: 0x181721AF0
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x1724610 Offset: 0x1722C10 VA: 0x181724610
	public Navigation get_navigation() { }

	// RVA: 0x1724900 Offset: 0x1722F00 VA: 0x181724900
	public void set_navigation(Navigation value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public Selectable.Transition get_transition() { }

	// RVA: 0x1724A50 Offset: 0x1723050 VA: 0x181724A50
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x17244C0 Offset: 0x1722AC0 VA: 0x1817244C0
	public ColorBlock get_colors() { }

	// RVA: 0x17246B0 Offset: 0x1722CB0 VA: 0x1817246B0
	public void set_colors(ColorBlock value) { }

	// RVA: 0x1724630 Offset: 0x1722C30 VA: 0x181724630
	public SpriteState get_spriteState() { }

	// RVA: 0x1724980 Offset: 0x1722F80 VA: 0x181724980
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x104F470 Offset: 0x104DA70 VA: 0x18104F470
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x1724650 Offset: 0x1722C50 VA: 0x181724650
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0xC73D40 Offset: 0xC72340 VA: 0x180C73D40
	public Graphic get_targetGraphic() { }

	// RVA: 0x17249F0 Offset: 0x1722FF0 VA: 0x1817249F0
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x13F1C20 Offset: 0x13F0220 VA: 0x1813F1C20
	public bool get_interactable() { }

	// RVA: 0x1724760 Offset: 0x1722D60 VA: 0x181724760
	public void set_interactable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1724600 Offset: 0x1722C00 VA: 0x181724600
	private bool get_isPointerInside() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17248F0 Offset: 0x1722EF0 VA: 0x1817248F0
	private void set_isPointerInside(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17245F0 Offset: 0x1722BF0 VA: 0x1817245F0
	private bool get_isPointerDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17248E0 Offset: 0x1722EE0 VA: 0x1817248E0
	private void set_isPointerDown(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x15F9D10 Offset: 0x15F8310 VA: 0x1815F9D10
	private bool get_hasSelection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1724750 Offset: 0x1722D50 VA: 0x181724750
	private void set_hasSelection(bool value) { }

	// RVA: 0x17240B0 Offset: 0x17226B0 VA: 0x1817240B0
	protected void .ctor() { }

	// RVA: 0x1724570 Offset: 0x1722B70 VA: 0x181724570
	public Image get_image() { }

	// RVA: 0xC73E90 Offset: 0xC72490 VA: 0x180C73E90
	public void set_image(Image value) { }

	// RVA: 0x1724480 Offset: 0x1722A80 VA: 0x181724480
	public Animator get_animator() { }

	// RVA: 0x1721C20 Offset: 0x1720220 VA: 0x181721C20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1722F90 Offset: 0x1721590 VA: 0x181722F90 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x1722E70 Offset: 0x1721470 VA: 0x181722E70 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x1723180 Offset: 0x1721780 VA: 0x181723180 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1723270 Offset: 0x1721870 VA: 0x181723270 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1723960 Offset: 0x1721F60 VA: 0x181723960 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1723180 Offset: 0x1721780 VA: 0x181723180
	private void OnSetProperty() { }

	// RVA: 0x17231F0 Offset: 0x17217F0 VA: 0x1817231F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1723990 Offset: 0x1721F90 VA: 0x181723990
	private static void RemoveInvalidSelectables() { }

	// RVA: 0x1724500 Offset: 0x1722B00 VA: 0x181724500
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x1722CE0 Offset: 0x17212E0 VA: 0x181722CE0 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x1721D60 Offset: 0x1720360 VA: 0x181721D60 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x17224B0 Offset: 0x1720AB0 VA: 0x1817224B0
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x1722A30 Offset: 0x1721030 VA: 0x181722A30
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x1722EE0 Offset: 0x17214E0 VA: 0x181722EE0
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x17220F0 Offset: 0x17206F0 VA: 0x1817220F0 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x1722230 Offset: 0x1720830 VA: 0x181722230 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x1722370 Offset: 0x1720970 VA: 0x181722370 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x1721FB0 Offset: 0x17205B0 VA: 0x181721FB0 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x17234E0 Offset: 0x1721AE0 VA: 0x1817234E0 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x1723CF0 Offset: 0x17222F0 VA: 0x181723CF0
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x1721CC0 Offset: 0x17202C0 VA: 0x181721CC0
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x1723DD0 Offset: 0x17223D0 VA: 0x181723DD0
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x1722E10 Offset: 0x1721410 VA: 0x181722E10
	protected bool IsHighlighted() { }

	// RVA: 0x1722E90 Offset: 0x1721490 VA: 0x181722E90
	protected bool IsPressed() { }

	// RVA: 0x1721F40 Offset: 0x1720540 VA: 0x181721F40
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x1723610 Offset: 0x1721C10 VA: 0x181723610 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1723870 Offset: 0x1721E70 VA: 0x181723870 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1723790 Offset: 0x1721D90 VA: 0x181723790 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1723800 Offset: 0x1721E00 VA: 0x181723800 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x17238F0 Offset: 0x1721EF0 VA: 0x1817238F0 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1723110 Offset: 0x1721710 VA: 0x181723110 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1723BE0 Offset: 0x17221E0 VA: 0x181723BE0 Slot: 38
	public virtual void Select() { }

	// RVA: 0x1724030 Offset: 0x1722630 VA: 0x181724030
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

