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
	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	internal bool get_isCompositeRoot() { }

	// RVA: 0xEC1EE0 Offset: 0xEC04E0 VA: 0x180EC1EE0 Slot: 12
	public override FocusController get_focusController() { }

	// RVA: 0xEC2110 Offset: 0xEC0710 VA: 0x180EC2110
	public ITransform get_transform() { }

	// RVA: 0xEC13F0 Offset: 0xEBF9F0 VA: 0x180EC13F0 Slot: 14
	private Matrix4x4 UnityEngine.UIElements.ITransform.get_matrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC21200 Offset: 0xC1F800 VA: 0x180C21200
	internal bool get_isLayoutManual() { }

	// RVA: 0xEC1F50 Offset: 0xEC0550 VA: 0x180EC1F50
	public Rect get_layout() { }

	// RVA: 0xEC1020 Offset: 0xEBF620 VA: 0x180EC1020
	internal static Rect TransformAlignedRect(Matrix4x4 lhc, Rect rect) { }

	// RVA: 0xEC0E20 Offset: 0xEBF420 VA: 0x180EC0E20
	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0xEC1E90 Offset: 0xEC0490 VA: 0x180EC1E90
	internal Rect get_boundingBox() { }

	// RVA: 0xEC2310 Offset: 0xEC0910 VA: 0x180EC2310
	internal Rect get_worldBoundingBox() { }

	// RVA: 0xEC1500 Offset: 0xEBFB00 VA: 0x180EC1500
	internal void UpdateBoundingBox() { }

	// RVA: 0xEC18E0 Offset: 0xEBFEE0 VA: 0x180EC18E0
	internal void UpdateWorldBoundingBox() { }

	// RVA: 0xEC2180 Offset: 0xEC0780 VA: 0x180EC2180
	public Rect get_worldBound() { }

	// RVA: 0xEC2060 Offset: 0xEC0660 VA: 0x180EC2060
	internal Rect get_rect() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6A0 Offset: 0x69BCA0 VA: 0x18069D6A0
	internal bool get_isWorldTransformDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6B0 Offset: 0x69BCB0 VA: 0x18069D6B0
	internal void set_isWorldTransformDirty(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC1F40 Offset: 0xEC0540 VA: 0x180EC1F40
	internal bool get_isWorldTransformInverseDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC25E0 Offset: 0xEC0BE0 VA: 0x180EC25E0
	internal void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0xEC2570 Offset: 0xEC0B70 VA: 0x180EC2570
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0xEC2470 Offset: 0xEC0A70 VA: 0x180EC2470
	internal Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0xEC19F0 Offset: 0xEBFFF0 VA: 0x180EC19F0
	private void UpdateWorldTransform() { }

	// RVA: 0xEC2050 Offset: 0xEC0650 VA: 0x180EC2050
	internal PseudoStates get_pseudoStates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC2040 Offset: 0xEC0640 VA: 0x180EC2040
	public PickingMode get_pickingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE670B0 Offset: 0xE656B0 VA: 0x180E670B0
	internal YogaNode get_yogaNode() { }

	// RVA: 0xEC2120 Offset: 0xEC0720 VA: 0x180EC2120
	internal VisualElementStylesData get_specifiedStyle() { }

	// RVA: 0xEC1F30 Offset: 0xEC0530 VA: 0x180EC1F30
	internal InheritedStylesData get_inheritedStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701870 Offset: 0x6FFE70 VA: 0x180701870
	internal ComputedStyle get_computedStyle() { }

	// RVA: 0xEC0F30 Offset: 0xEBF530 VA: 0x180EC0F30 Slot: 6
	public sealed override void SendEvent(EventBase e) { }

	// RVA: 0xEC0DF0 Offset: 0xEBF3F0 VA: 0x180EC0DF0
	internal void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0xEC1ED0 Offset: 0xEC04D0 VA: 0x180EC1ED0
	public bool get_enabledInHierarchy() { }

	// RVA: 0xEC2130 Offset: 0xEC0730 VA: 0x180EC2130
	public bool get_visible() { }

	// RVA: 0xEC0D20 Offset: 0xEBF320 VA: 0x180EC0D20 Slot: 17
	public virtual bool ContainsPoint(Vector2 localPoint) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD62610 Offset: 0xD60C10 VA: 0x180D62610
	public VisualElement.Hierarchy get_hierarchy() { }

	// RVA: 0xEC0F50 Offset: 0xEBF550 VA: 0x180EC0F50
	internal bool ShouldClip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC838C0 Offset: 0xC81EC0 VA: 0x180C838C0
	internal BaseVisualElementPanel get_elementPanel() { }

	// RVA: 0xEC2030 Offset: 0xEC0630 VA: 0x180EC2030
	public IPanel get_panel() { }

	// RVA: 0xEC0E90 Offset: 0xEBF490 VA: 0x180EC0E90
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0xEC2110 Offset: 0xEC0710 VA: 0x180EC2110
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0xEC12F0 Offset: 0xEBF8F0 VA: 0x180EC12F0 Slot: 15
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0xEC1220 Offset: 0xEBF820 VA: 0x180EC1220 Slot: 16
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0xEC1D50 Offset: 0xEC0350 VA: 0x180EC1D50
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

	// RVA: 0x139CF0 Offset: 0x1390F0 VA: 0x180139CF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22F6970 Offset: 0x22F4F70 VA: 0x1822F6970
	public static bool op_Equality(VisualElement.Hierarchy x, VisualElement.Hierarchy y) { }

}

