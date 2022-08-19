public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 5003
{	// Fields
	private static Selectable[] s_Selectables; // 0x0
	private static int s_SelectableCount; // 0x8
	private static bool s_IsDirty; // 0xC
	[FormerlySerializedAsAttribute] // RVA: 0x7B110 Offset: 0x7A510 VA: 0x18007B110
	[SerializeField] // RVA: 0x7B110 Offset: 0x7A510 VA: 0x18007B110
	private Navigation m_Navigation; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x7B390 Offset: 0x7A790 VA: 0x18007B390
	[SerializeField] // RVA: 0x7B390 Offset: 0x7A790 VA: 0x18007B390
	private Selectable.Transition m_Transition; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0x7B4B0 Offset: 0x7A8B0 VA: 0x18007B4B0
	[SerializeField] // RVA: 0x7B4B0 Offset: 0x7A8B0 VA: 0x18007B4B0
	private ColorBlock m_Colors; // 0x44
	[FormerlySerializedAsAttribute] // RVA: 0x7B6B0 Offset: 0x7AAB0 VA: 0x18007B6B0
	[SerializeField] // RVA: 0x7B6B0 Offset: 0x7AAB0 VA: 0x18007B6B0
	private SpriteState m_SpriteState; // 0xA0
	[FormerlySerializedAsAttribute] // RVA: 0x7B830 Offset: 0x7AC30 VA: 0x18007B830
	[SerializeField] // RVA: 0x7B830 Offset: 0x7AC30 VA: 0x18007B830
	private AnimationTriggers m_AnimationTriggers; // 0xC0
	[TooltipAttribute] // RVA: 0x7BA00 Offset: 0x7AE00 VA: 0x18007BA00
	[SerializeField] // RVA: 0x7BA00 Offset: 0x7AE00 VA: 0x18007BA00
	private bool m_Interactable; // 0xC8
	[FormerlySerializedAsAttribute] // RVA: 0x7BA80 Offset: 0x7AE80 VA: 0x18007BA80
	[FormerlySerializedAsAttribute] // RVA: 0x7BA80 Offset: 0x7AE80 VA: 0x18007BA80
	[SerializeField] // RVA: 0x7BA80 Offset: 0x7AE80 VA: 0x18007BA80
	private Graphic m_TargetGraphic; // 0xD0
	private bool m_GroupsAllowInteraction; // 0xD8
	private bool m_WillRemove; // 0xD9
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <isPointerInside>k__BackingField; // 0xDA
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <isPointerDown>k__BackingField; // 0xDB
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <hasSelection>k__BackingField; // 0xDC
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xE0

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[ObsoleteAttribute] // RVA: 0x7C5A0 Offset: 0x7B9A0 VA: 0x18007C5A0
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

	// RVA: 0x1723F90 Offset: 0x1722590 VA: 0x181723F90
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x1723F30 Offset: 0x1722530 VA: 0x181723F30
	public static int get_allSelectableCount() { }

	// RVA: 0x1724070 Offset: 0x1722670 VA: 0x181724070
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x1721830 Offset: 0x171FE30 VA: 0x181721830
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x1724350 Offset: 0x1722950 VA: 0x181724350
	public Navigation get_navigation() { }

	// RVA: 0x1724640 Offset: 0x1722C40 VA: 0x181724640
	public void set_navigation(Navigation value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public Selectable.Transition get_transition() { }

	// RVA: 0x1724790 Offset: 0x1722D90 VA: 0x181724790
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x1724200 Offset: 0x1722800 VA: 0x181724200
	public ColorBlock get_colors() { }

	// RVA: 0x17243F0 Offset: 0x17229F0 VA: 0x1817243F0
	public void set_colors(ColorBlock value) { }

	// RVA: 0x1724370 Offset: 0x1722970 VA: 0x181724370
	public SpriteState get_spriteState() { }

	// RVA: 0x17246C0 Offset: 0x1722CC0 VA: 0x1817246C0
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x104F1B0 Offset: 0x104D7B0 VA: 0x18104F1B0
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x1724390 Offset: 0x1722990 VA: 0x181724390
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	public Graphic get_targetGraphic() { }

	// RVA: 0x1724730 Offset: 0x1722D30 VA: 0x181724730
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x13F1960 Offset: 0x13EFF60 VA: 0x1813F1960
	public bool get_interactable() { }

	// RVA: 0x17244A0 Offset: 0x1722AA0 VA: 0x1817244A0
	public void set_interactable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1724340 Offset: 0x1722940 VA: 0x181724340
	private bool get_isPointerInside() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1724630 Offset: 0x1722C30 VA: 0x181724630
	private void set_isPointerInside(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1724330 Offset: 0x1722930 VA: 0x181724330
	private bool get_isPointerDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1724620 Offset: 0x1722C20 VA: 0x181724620
	private void set_isPointerDown(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x15F9A50 Offset: 0x15F8050 VA: 0x1815F9A50
	private bool get_hasSelection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1724490 Offset: 0x1722A90 VA: 0x181724490
	private void set_hasSelection(bool value) { }

	// RVA: 0x1723DF0 Offset: 0x17223F0 VA: 0x181723DF0
	protected void .ctor() { }

	// RVA: 0x17242B0 Offset: 0x17228B0 VA: 0x1817242B0
	public Image get_image() { }

	// RVA: 0xC73BD0 Offset: 0xC721D0 VA: 0x180C73BD0
	public void set_image(Image value) { }

	// RVA: 0x17241C0 Offset: 0x17227C0 VA: 0x1817241C0
	public Animator get_animator() { }

	// RVA: 0x1721960 Offset: 0x171FF60 VA: 0x181721960 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1722CD0 Offset: 0x17212D0 VA: 0x181722CD0 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x1722BB0 Offset: 0x17211B0 VA: 0x181722BB0 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x1722EC0 Offset: 0x17214C0 VA: 0x181722EC0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1722FB0 Offset: 0x17215B0 VA: 0x181722FB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x17236A0 Offset: 0x1721CA0 VA: 0x1817236A0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1722EC0 Offset: 0x17214C0 VA: 0x181722EC0
	private void OnSetProperty() { }

	// RVA: 0x1722F30 Offset: 0x1721530 VA: 0x181722F30 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x17236D0 Offset: 0x1721CD0 VA: 0x1817236D0
	private static void RemoveInvalidSelectables() { }

	// RVA: 0x1724240 Offset: 0x1722840 VA: 0x181724240
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x1722A20 Offset: 0x1721020 VA: 0x181722A20 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x1721AA0 Offset: 0x17200A0 VA: 0x181721AA0 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x17221F0 Offset: 0x17207F0 VA: 0x1817221F0
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x1722770 Offset: 0x1720D70 VA: 0x181722770
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x1722C20 Offset: 0x1721220 VA: 0x181722C20
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x1721E30 Offset: 0x1720430 VA: 0x181721E30 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x1721F70 Offset: 0x1720570 VA: 0x181721F70 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x17220B0 Offset: 0x17206B0 VA: 0x1817220B0 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x1721CF0 Offset: 0x17202F0 VA: 0x181721CF0 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x1723220 Offset: 0x1721820 VA: 0x181723220 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x1723A30 Offset: 0x1722030 VA: 0x181723A30
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x1721A00 Offset: 0x1720000 VA: 0x181721A00
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x1723B10 Offset: 0x1722110 VA: 0x181723B10
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x1722B50 Offset: 0x1721150 VA: 0x181722B50
	protected bool IsHighlighted() { }

	// RVA: 0x1722BD0 Offset: 0x17211D0 VA: 0x181722BD0
	protected bool IsPressed() { }

	// RVA: 0x1721C80 Offset: 0x1720280 VA: 0x181721C80
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x1723350 Offset: 0x1721950 VA: 0x181723350 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x17235B0 Offset: 0x1721BB0 VA: 0x1817235B0 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x17234D0 Offset: 0x1721AD0 VA: 0x1817234D0 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1723540 Offset: 0x1721B40 VA: 0x181723540 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1723630 Offset: 0x1721C30 VA: 0x181723630 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1722E50 Offset: 0x1721450 VA: 0x181722E50 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1723920 Offset: 0x1721F20 VA: 0x181723920 Slot: 38
	public virtual void Select() { }

	// RVA: 0x1723D70 Offset: 0x1722370 VA: 0x181723D70
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

