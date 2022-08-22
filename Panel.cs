internal class Panel : BaseVisualElementPanel // TypeDefIndex: 4601
{	// Fields
	private VisualElement m_RootContainer; // 0x30
	private VisualTreeUpdater m_VisualTreeUpdater; // 0x38
	private uint m_Version; // 0x40
	private uint m_RepaintVersion; // 0x44
	private ProfilerMarker m_MarkerUpdate; // 0x48
	private static ProfilerMarker s_MarkerPickAll; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private EventDispatcher <dispatcher>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private ScriptableObject <ownerObject>k__BackingField; // 0x58
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private ContextType <contextType>k__BackingField; // 0x60
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private FocusController <focusController>k__BackingField; // 0x68
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private EventInterests <IMGUIEventInterests>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private int <IMGUIContainersCount>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; // 0x78
	private bool m_ValidatingLayout; // 0x80

	// Properties
	public override VisualElement visualTree { get; }
	public override EventDispatcher dispatcher { get; }
	public override ScriptableObject ownerObject { get; }
	public override ContextType contextType { get; }
	public override FocusController focusController { get; }
	public override EventInterests IMGUIEventInterests { get; }
	public override int IMGUIContainersCount { get; }
	public override IMGUIContainer rootIMGUIContainer { get; }
	internal override uint version { get; }

	// Methods

	// RVA: 0xEB5AD0 Offset: 0xEB40D0 VA: 0x180EB5AD0 Slot: 20
	public override VisualElement get_visualTree() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 21
	public override EventDispatcher get_dispatcher() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 10
	public override ScriptableObject get_ownerObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0 Slot: 22
	public override ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 13
	public override FocusController get_focusController() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB5AB0 Offset: 0xEB40B0 VA: 0x180EB5AB0 Slot: 9
	public override EventInterests get_IMGUIEventInterests() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB28BB0 Offset: 0xB271B0 VA: 0x180B28BB0 Slot: 11
	public override int get_IMGUIContainersCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520 Slot: 12
	public override IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0xEB5AC0 Offset: 0xEB40C0 VA: 0x180EB5AC0 Slot: 17
	internal override uint get_version() { }

	// RVA: 0xEB5400 Offset: 0xEB3A00 VA: 0x180EB5400
	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	// RVA: 0xEB4F30 Offset: 0xEB3530 VA: 0x180EB4F30
	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	// RVA: 0xEB5480 Offset: 0xEB3A80 VA: 0x180EB5480 Slot: 23
	public override VisualElement Pick(Vector2 point) { }

	// RVA: 0xEB59F0 Offset: 0xEB3FF0 VA: 0x180EB59F0 Slot: 16
	public override void ValidateLayout() { }

	// RVA: 0xEB5970 Offset: 0xEB3F70 VA: 0x180EB5970
	private void UpdateForRepaint() { }

	// RVA: 0xEB56B0 Offset: 0xEB3CB0 VA: 0x180EB56B0 Slot: 15
	public override void Repaint(Event e) { }

	// RVA: 0xEB4F00 Offset: 0xEB3500 VA: 0x180EB4F00 Slot: 18
	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0xEB5A60 Offset: 0xEB4060 VA: 0x180EB5A60
	private static void .cctor() { }

}

