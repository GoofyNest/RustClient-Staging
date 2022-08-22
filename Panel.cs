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

	// RVA: 0xEB6840 Offset: 0xEB4E40 VA: 0x180EB6840 Slot: 20
	public override VisualElement get_visualTree() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 21
	public override EventDispatcher get_dispatcher() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 10
	public override ScriptableObject get_ownerObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340 Slot: 22
	public override ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0 Slot: 13
	public override FocusController get_focusController() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB6820 Offset: 0xEB4E20 VA: 0x180EB6820 Slot: 9
	public override EventInterests get_IMGUIEventInterests() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB29340 Offset: 0xB27940 VA: 0x180B29340 Slot: 11
	public override int get_IMGUIContainersCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0 Slot: 12
	public override IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0xEB6830 Offset: 0xEB4E30 VA: 0x180EB6830 Slot: 17
	internal override uint get_version() { }

	// RVA: 0xEB6170 Offset: 0xEB4770 VA: 0x180EB6170
	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	// RVA: 0xEB5CA0 Offset: 0xEB42A0 VA: 0x180EB5CA0
	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	// RVA: 0xEB61F0 Offset: 0xEB47F0 VA: 0x180EB61F0 Slot: 23
	public override VisualElement Pick(Vector2 point) { }

	// RVA: 0xEB6760 Offset: 0xEB4D60 VA: 0x180EB6760 Slot: 16
	public override void ValidateLayout() { }

	// RVA: 0xEB66E0 Offset: 0xEB4CE0 VA: 0x180EB66E0
	private void UpdateForRepaint() { }

	// RVA: 0xEB6420 Offset: 0xEB4A20 VA: 0x180EB6420 Slot: 15
	public override void Repaint(Event e) { }

	// RVA: 0xEB5C70 Offset: 0xEB4270 VA: 0x180EB5C70 Slot: 18
	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0xEB67D0 Offset: 0xEB4DD0 VA: 0x180EB67D0
	private static void .cctor() { }

}

