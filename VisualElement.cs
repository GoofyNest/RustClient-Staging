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
	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	internal bool get_isCompositeRoot() { }

	// RVA: 0xEC1170 Offset: 0xEBF770 VA: 0x180EC1170 Slot: 12
	public override FocusController get_focusController() { }

	// RVA: 0xEC13A0 Offset: 0xEBF9A0 VA: 0x180EC13A0
	public ITransform get_transform() { }

	// RVA: 0xEC0680 Offset: 0xEBEC80 VA: 0x180EC0680 Slot: 14
	private Matrix4x4 UnityEngine.UIElements.ITransform.get_matrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC20A70 Offset: 0xC1F070 VA: 0x180C20A70
	internal bool get_isLayoutManual() { }

	// RVA: 0xEC11E0 Offset: 0xEBF7E0 VA: 0x180EC11E0
	public Rect get_layout() { }

	// RVA: 0xEC02B0 Offset: 0xEBE8B0 VA: 0x180EC02B0
	internal static Rect TransformAlignedRect(Matrix4x4 lhc, Rect rect) { }

	// RVA: 0xEC00B0 Offset: 0xEBE6B0 VA: 0x180EC00B0
	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0xEC1120 Offset: 0xEBF720 VA: 0x180EC1120
	internal Rect get_boundingBox() { }

	// RVA: 0xEC15A0 Offset: 0xEBFBA0 VA: 0x180EC15A0
	internal Rect get_worldBoundingBox() { }

	// RVA: 0xEC0790 Offset: 0xEBED90 VA: 0x180EC0790
	internal void UpdateBoundingBox() { }

	// RVA: 0xEC0B70 Offset: 0xEBF170 VA: 0x180EC0B70
	internal void UpdateWorldBoundingBox() { }

	// RVA: 0xEC1410 Offset: 0xEBFA10 VA: 0x180EC1410
	public Rect get_worldBound() { }

	// RVA: 0xEC12F0 Offset: 0xEBF8F0 VA: 0x180EC12F0
	internal Rect get_rect() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D600 Offset: 0x69BC00 VA: 0x18069D600
	internal bool get_isWorldTransformDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D610 Offset: 0x69BC10 VA: 0x18069D610
	internal void set_isWorldTransformDirty(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC11D0 Offset: 0xEBF7D0 VA: 0x180EC11D0
	internal bool get_isWorldTransformInverseDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC1870 Offset: 0xEBFE70 VA: 0x180EC1870
	internal void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0xEC1800 Offset: 0xEBFE00 VA: 0x180EC1800
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0xEC1700 Offset: 0xEBFD00 VA: 0x180EC1700
	internal Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0xEC0C80 Offset: 0xEBF280 VA: 0x180EC0C80
	private void UpdateWorldTransform() { }

	// RVA: 0xEC12E0 Offset: 0xEBF8E0 VA: 0x180EC12E0
	internal PseudoStates get_pseudoStates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC12D0 Offset: 0xEBF8D0 VA: 0x180EC12D0
	public PickingMode get_pickingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE66340 Offset: 0xE64940 VA: 0x180E66340
	internal YogaNode get_yogaNode() { }

	// RVA: 0xEC13B0 Offset: 0xEBF9B0 VA: 0x180EC13B0
	internal VisualElementStylesData get_specifiedStyle() { }

	// RVA: 0xEC11C0 Offset: 0xEBF7C0 VA: 0x180EC11C0
	internal InheritedStylesData get_inheritedStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701810 Offset: 0x6FFE10 VA: 0x180701810
	internal ComputedStyle get_computedStyle() { }

	// RVA: 0xEC01C0 Offset: 0xEBE7C0 VA: 0x180EC01C0 Slot: 6
	public sealed override void SendEvent(EventBase e) { }

	// RVA: 0xEC0080 Offset: 0xEBE680 VA: 0x180EC0080
	internal void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0xEC1160 Offset: 0xEBF760 VA: 0x180EC1160
	public bool get_enabledInHierarchy() { }

	// RVA: 0xEC13C0 Offset: 0xEBF9C0 VA: 0x180EC13C0
	public bool get_visible() { }

	// RVA: 0xEBFFB0 Offset: 0xEBE5B0 VA: 0x180EBFFB0 Slot: 17
	public virtual bool ContainsPoint(Vector2 localPoint) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD618A0 Offset: 0xD5FEA0 VA: 0x180D618A0
	public VisualElement.Hierarchy get_hierarchy() { }

	// RVA: 0xEC01E0 Offset: 0xEBE7E0 VA: 0x180EC01E0
	internal bool ShouldClip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83160 Offset: 0xC81760 VA: 0x180C83160
	internal BaseVisualElementPanel get_elementPanel() { }

	// RVA: 0xEC12C0 Offset: 0xEBF8C0 VA: 0x180EC12C0
	public IPanel get_panel() { }

	// RVA: 0xEC0120 Offset: 0xEBE720 VA: 0x180EC0120
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0xEC13A0 Offset: 0xEBF9A0 VA: 0x180EC13A0
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0xEC0580 Offset: 0xEBEB80 VA: 0x180EC0580 Slot: 15
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0xEC04B0 Offset: 0xEBEAB0 VA: 0x180EC04B0 Slot: 16
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0xEC0FE0 Offset: 0xEBF5E0 VA: 0x180EC0FE0
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

	// RVA: 0x22F5E90 Offset: 0x22F4490 VA: 0x1822F5E90
	public static bool op_Equality(VisualElement.Hierarchy x, VisualElement.Hierarchy y) { }

}

