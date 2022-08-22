public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 5003
{	private static Selectable[] s_Selectables; // 0x0
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


	public static Selectable[] get_allSelectablesArray() { }

	public static int get_allSelectableCount() { }

	public static List<Selectable> get_allSelectables() { }

	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	public Navigation get_navigation() { }

	public void set_navigation(Navigation value) { }

	public Selectable.Transition get_transition() { }

	public void set_transition(Selectable.Transition value) { }

	public ColorBlock get_colors() { }

	public void set_colors(ColorBlock value) { }

	public SpriteState get_spriteState() { }

	public void set_spriteState(SpriteState value) { }

	public AnimationTriggers get_animationTriggers() { }

	public void set_animationTriggers(AnimationTriggers value) { }

	public Graphic get_targetGraphic() { }

	public void set_targetGraphic(Graphic value) { }

	public bool get_interactable() { }

	public void set_interactable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool get_isPointerInside() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_isPointerInside(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool get_isPointerDown() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_isPointerDown(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool get_hasSelection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_hasSelection(bool value) { }

	protected void .ctor() { }

	public Image get_image() { }

	public void set_image(Image value) { }

	public Animator get_animator() { }

	protected override void Awake() { }

	protected override void OnCanvasGroupChanged() { }

	public virtual bool IsInteractable() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnEnable() { }

	protected override void OnTransformParentChanged() { }

	private void OnSetProperty() { }

	protected override void OnDisable() { }

	private static void RemoveInvalidSelectables() { }

	protected Selectable.SelectionState get_currentSelectionState() { }

	protected virtual void InstantClearState() { }

	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	public Selectable FindSelectable(Vector3 dir) { }

	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	private void Navigate(AxisEventData eventData, Selectable sel) { }

	public virtual Selectable FindSelectableOnLeft() { }

	public virtual Selectable FindSelectableOnRight() { }

	public virtual Selectable FindSelectableOnUp() { }

	public virtual Selectable FindSelectableOnDown() { }

	public virtual void OnMove(AxisEventData eventData) { }

	private void StartColorTween(Color targetColor, bool instant) { }

	private void DoSpriteSwap(Sprite newSprite) { }

	private void TriggerAnimation(string triggername) { }

	protected bool IsHighlighted() { }

	protected bool IsPressed() { }

	private void EvaluateAndTransitionToSelectionState() { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	public virtual void Select() { }

	private static void .cctor() { }

}

public enum Selectable.Transition // TypeDefIndex: 5004
{	public int value__; // 0x0
	public const Selectable.Transition None = 0;
	public const Selectable.Transition ColorTint = 1;
	public const Selectable.Transition SpriteSwap = 2;
	public const Selectable.Transition Animation = 3;

}

