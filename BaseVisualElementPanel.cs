internal abstract class BaseVisualElementPanel : IPanel // TypeDefIndex: 4600
{	// Fields
	private float m_PixelsPerPoint; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private bool <duringLayoutPhase>k__BackingField; // 0x14
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private RepaintData <repaintData>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <disposed>k__BackingField; // 0x20
	internal ElementUnderPointer m_TopElementUnderPointers; // 0x28

	// Properties
	public abstract EventInterests IMGUIEventInterests { get; }
	public abstract ScriptableObject ownerObject { get; }
	public abstract int IMGUIContainersCount { get; }
	public abstract IMGUIContainer rootIMGUIContainer { get; }
	public abstract FocusController focusController { get; }
	internal float pixelsPerPoint { set; }
	internal bool duringLayoutPhase { get; }
	internal abstract uint version { get; }
	internal virtual RepaintData repaintData { get; }
	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; }
	public abstract ContextType contextType { get; }
	internal bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public abstract EventInterests get_IMGUIEventInterests();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ScriptableObject get_ownerObject();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_IMGUIContainersCount();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IMGUIContainer get_rootIMGUIContainer();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract FocusController get_focusController();

	// RVA: 0xEA8FB0 Offset: 0xEA75B0 VA: 0x180EA8FB0 Slot: 8
	public void Dispose() { }

	// RVA: 0xEA8E60 Offset: 0xEA7460 VA: 0x180EA8E60 Slot: 14
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void Repaint(Event e);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ValidateLayout();

	// RVA: 0xEA9150 Offset: 0xEA7750 VA: 0x180EA9150
	internal void set_pixelsPerPoint(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA10E00 Offset: 0xA0F400 VA: 0x180A10E00
	internal bool get_duringLayoutPhase() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract uint get_version();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 19
	internal virtual RepaintData get_repaintData() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract VisualElement get_visualTree();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract EventDispatcher get_dispatcher();

	// RVA: 0xEA9060 Offset: 0xEA7660 VA: 0x180EA9060
	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract ContextType get_contextType();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract VisualElement Pick(Vector2 point);

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	internal bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	private void set_disposed(bool value) { }

	// RVA: 0xEA9020 Offset: 0xEA7620 VA: 0x180EA9020
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0xEA9120 Offset: 0xEA7720 VA: 0x180EA9120
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0xEA8DF0 Offset: 0xEA73F0 VA: 0x180EA8DF0
	internal void ClearCachedElementUnderPointer(EventBase triggerEvent) { }

	// RVA: 0xEA8E20 Offset: 0xEA7420 VA: 0x180EA8E20
	internal void CommitElementUnderPointers() { }

}

