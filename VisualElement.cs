public class VisualElement : Focusable, ITransform, IResolvedStyle // TypeDefIndex: 4613
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private bool <isCompositeRoot>k__BackingField; // 0x20
	private static List<string> s_EmptyClassList; // 0x0
	internal static readonly PropertyName userDataPropertyKey; // 0x8
	public static readonly string disabledUssClassName; // 0x10
	private Vector3 m_Position; // 0x24
	private Quaternion m_Rotation; // 0x30
	private Vector3 m_Scale; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <isLayoutManual>k__BackingField; // 0x4C
	private Rect m_Layout; // 0x50
	internal bool isBoundingBoxDirty; // 0x60
	private Rect m_BoundingBox; // 0x64
	internal bool isWorldBoundingBoxDirty; // 0x74
	private Rect m_WorldBoundingBox; // 0x78
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private bool <isWorldTransformDirty>k__BackingField; // 0x88
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private bool <isWorldTransformInverseDirty>k__BackingField; // 0x89
	private Matrix4x4 m_WorldTransformCache; // 0x8C
	private Matrix4x4 m_WorldTransformInverseCache; // 0xCC
	private static readonly Rect s_InfiniteRect; // 0x18
	private PseudoStates m_PseudoStates; // 0x10C
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private PickingMode <pickingMode>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private YogaNode <yogaNode>k__BackingField; // 0x118
	internal VisualElementStylesData m_Style; // 0x120
	private InheritedStylesData m_InheritedStylesData; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private ComputedStyle <computedStyle>k__BackingField; // 0x130
	internal int imguiContainerDescendantCount; // 0x138
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private VisualElement.Hierarchy <hierarchy>k__BackingField; // 0x140
	private VisualElement m_PhysicalParent; // 0x148
	private static readonly List<VisualElement> s_EmptyList; // 0x28
	private List<VisualElement> m_Children; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private BaseVisualElementPanel <elementPanel>k__BackingField; // 0x158

	// Properties
	internal bool isCompositeRoot { get; }
	public override FocusController focusController { get; }
	public ITransform transform { get; }
	private Matrix4x4 UnityEngine.UIElements.ITransform.matrix { get; }
	internal bool isLayoutManual { get; }
	public Rect layout { get; }
	internal Rect boundingBox { get; }
	internal Rect worldBoundingBox { get; }
	public Rect worldBound { get; }
	internal Rect rect { get; }
	internal bool isWorldTransformDirty { get; set; }
	internal bool isWorldTransformInverseDirty { get; set; }
	public Matrix4x4 worldTransform { get; }
	internal Matrix4x4 worldTransformInverse { get; }
	internal PseudoStates pseudoStates { get; }
	public PickingMode pickingMode { get; }
	internal YogaNode yogaNode { get; }
	internal VisualElementStylesData specifiedStyle { get; }
	internal InheritedStylesData inheritedStyle { get; }
	internal ComputedStyle computedStyle { get; }
	public bool enabledInHierarchy { get; }
	public bool visible { get; }
	public VisualElement.Hierarchy hierarchy { get; }
	internal BaseVisualElementPanel elementPanel { get; }
	public IPanel panel { get; }
	public IResolvedStyle resolvedStyle { get; }
	private Visibility UnityEngine.UIElements.IResolvedStyle.visibility { get; }
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.display { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	internal bool get_isCompositeRoot() { }

	// RVA: 0xEC1430 Offset: 0xEBFA30 VA: 0x180EC1430 Slot: 12
	public override FocusController get_focusController() { }

	// RVA: 0xEC1660 Offset: 0xEBFC60 VA: 0x180EC1660
	public ITransform get_transform() { }

	// RVA: 0xEC0940 Offset: 0xEBEF40 VA: 0x180EC0940 Slot: 14
	private Matrix4x4 UnityEngine.UIElements.ITransform.get_matrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC20D30 Offset: 0xC1F330 VA: 0x180C20D30
	internal bool get_isLayoutManual() { }

	// RVA: 0xEC14A0 Offset: 0xEBFAA0 VA: 0x180EC14A0
	public Rect get_layout() { }

	// RVA: 0xEC0570 Offset: 0xEBEB70 VA: 0x180EC0570
	internal static Rect TransformAlignedRect(Matrix4x4 lhc, Rect rect) { }

	// RVA: 0xEC0370 Offset: 0xEBE970 VA: 0x180EC0370
	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0xEC13E0 Offset: 0xEBF9E0 VA: 0x180EC13E0
	internal Rect get_boundingBox() { }

	// RVA: 0xEC1860 Offset: 0xEBFE60 VA: 0x180EC1860
	internal Rect get_worldBoundingBox() { }

	// RVA: 0xEC0A50 Offset: 0xEBF050 VA: 0x180EC0A50
	internal void UpdateBoundingBox() { }

	// RVA: 0xEC0E30 Offset: 0xEBF430 VA: 0x180EC0E30
	internal void UpdateWorldBoundingBox() { }

	// RVA: 0xEC16D0 Offset: 0xEBFCD0 VA: 0x180EC16D0
	public Rect get_worldBound() { }

	// RVA: 0xEC15B0 Offset: 0xEBFBB0 VA: 0x180EC15B0
	internal Rect get_rect() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D710 Offset: 0x69BD10 VA: 0x18069D710
	internal bool get_isWorldTransformDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D720 Offset: 0x69BD20 VA: 0x18069D720
	internal void set_isWorldTransformDirty(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC1490 Offset: 0xEBFA90 VA: 0x180EC1490
	internal bool get_isWorldTransformInverseDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC1B30 Offset: 0xEC0130 VA: 0x180EC1B30
	internal void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0xEC1AC0 Offset: 0xEC00C0 VA: 0x180EC1AC0
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0xEC19C0 Offset: 0xEBFFC0 VA: 0x180EC19C0
	internal Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0xEC0F40 Offset: 0xEBF540 VA: 0x180EC0F40
	private void UpdateWorldTransform() { }

	// RVA: 0xEC15A0 Offset: 0xEBFBA0 VA: 0x180EC15A0
	internal PseudoStates get_pseudoStates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC1590 Offset: 0xEBFB90 VA: 0x180EC1590
	public PickingMode get_pickingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE66600 Offset: 0xE64C00 VA: 0x180E66600
	internal YogaNode get_yogaNode() { }

	// RVA: 0xEC1670 Offset: 0xEBFC70 VA: 0x180EC1670
	internal VisualElementStylesData get_specifiedStyle() { }

	// RVA: 0xEC1480 Offset: 0xEBFA80 VA: 0x180EC1480
	internal InheritedStylesData get_inheritedStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701920 Offset: 0x6FFF20 VA: 0x180701920
	internal ComputedStyle get_computedStyle() { }

	// RVA: 0xEC0480 Offset: 0xEBEA80 VA: 0x180EC0480 Slot: 6
	public sealed override void SendEvent(EventBase e) { }

	// RVA: 0xEC0340 Offset: 0xEBE940 VA: 0x180EC0340
	internal void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0xEC1420 Offset: 0xEBFA20 VA: 0x180EC1420
	public bool get_enabledInHierarchy() { }

	// RVA: 0xEC1680 Offset: 0xEBFC80 VA: 0x180EC1680
	public bool get_visible() { }

	// RVA: 0xEC0270 Offset: 0xEBE870 VA: 0x180EC0270 Slot: 17
	public virtual bool ContainsPoint(Vector2 localPoint) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD61B60 Offset: 0xD60160 VA: 0x180D61B60
	public VisualElement.Hierarchy get_hierarchy() { }

	// RVA: 0xEC04A0 Offset: 0xEBEAA0 VA: 0x180EC04A0
	internal bool ShouldClip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83420 Offset: 0xC81A20 VA: 0x180C83420
	internal BaseVisualElementPanel get_elementPanel() { }

	// RVA: 0xEC1580 Offset: 0xEBFB80 VA: 0x180EC1580
	public IPanel get_panel() { }

	// RVA: 0xEC03E0 Offset: 0xEBE9E0 VA: 0x180EC03E0
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0xEC1660 Offset: 0xEBFC60 VA: 0x180EC1660
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0xEC0840 Offset: 0xEBEE40 VA: 0x180EC0840 Slot: 15
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0xEC0770 Offset: 0xEBED70 VA: 0x180EC0770 Slot: 16
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0xEC12A0 Offset: 0xEBF8A0 VA: 0x180EC12A0
	private static void .cctor() { }

}

public struct VisualElement.Hierarchy // TypeDefIndex: 4614
{	// Fields
	private readonly VisualElement m_Owner; // 0x0

	// Properties
	public VisualElement parent { get; }
	public int childCount { get; }
	public VisualElement Item { get; }

	// Methods

	// RVA: 0x23E130 Offset: 0x23D530 VA: 0x18023E130
	public VisualElement get_parent() { }

	// RVA: 0x23E0E0 Offset: 0x23D4E0 VA: 0x18023E0E0
	public int get_childCount() { }

	// RVA: 0x23E070 Offset: 0x23D470 VA: 0x18023E070
	public VisualElement get_Item(int key) { }

	// RVA: 0x23DFC0 Offset: 0x23D3C0 VA: 0x18023DFC0
	public bool Equals(VisualElement.Hierarchy other) { }

	// RVA: 0x23DFD0 Offset: 0x23D3D0 VA: 0x18023DFD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x139ED0 Offset: 0x1392D0 VA: 0x180139ED0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22F6150 Offset: 0x22F4750 VA: 0x1822F6150
	public static bool op_Equality(VisualElement.Hierarchy x, VisualElement.Hierarchy y) { }

}

