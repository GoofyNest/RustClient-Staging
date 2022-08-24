internal class Panel : BaseVisualElementPanel // TypeDefIndex: 4601
{	private VisualElement m_RootContainer; // 0x30
	private VisualTreeUpdater m_VisualTreeUpdater; // 0x38
	private uint m_Version; // 0x40
	private uint m_RepaintVersion; // 0x44
	private ProfilerMarker m_MarkerUpdate; // 0x48
	private static ProfilerMarker s_MarkerPickAll; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private EventDispatcher <dispatcher>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private ScriptableObject <ownerObject>k__BackingField; // 0x58
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private ContextType <contextType>k__BackingField; // 0x60
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private FocusController <focusController>k__BackingField; // 0x68
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private EventInterests <IMGUIEventInterests>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private int <IMGUIContainersCount>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; // 0x78
	private bool m_ValidatingLayout; // 0x80

	public override VisualElement visualTree { get; }
	public override EventDispatcher dispatcher { get; }
	public override ScriptableObject ownerObject { get; }
	public override ContextType contextType { get; }
	public override FocusController focusController { get; }
	public override EventInterests IMGUIEventInterests { get; }
	public override int IMGUIContainersCount { get; }
	public override IMGUIContainer rootIMGUIContainer { get; }
	internal override uint version { get; }


	public override VisualElement get_visualTree() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public override EventDispatcher get_dispatcher() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public override ScriptableObject get_ownerObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public override ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public override FocusController get_focusController() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public override EventInterests get_IMGUIEventInterests() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public override int get_IMGUIContainersCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public override IMGUIContainer get_rootIMGUIContainer() { }

	internal override uint get_version() { }

	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked) { }

	public override VisualElement Pick(Vector2 point) { }

	public override void ValidateLayout() { }

	private void UpdateForRepaint() { }

	public override void Repaint(Event e) { }

	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private static void .cctor() { }

}

