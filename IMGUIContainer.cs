public class IMGUIContainer : VisualElement // TypeDefIndex: 4591
{	// Fields
	private Action m_OnGUIHandler; // 0x160
	private ObjectGUIState m_ObjectGUIState; // 0x168
	internal bool useOwnerObjectGUIState; // 0x170
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private Rect <lastWorldClip>k__BackingField; // 0x174
	private GUILayoutUtility.LayoutCache m_Cache; // 0x188
	private Rect m_CachedClippingRect; // 0x190
	private Matrix4x4 m_CachedTransform; // 0x1A0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private ContextType <contextType>k__BackingField; // 0x1E0
	private bool lostFocus; // 0x1E4
	private bool receivedFocus; // 0x1E5
	private FocusChangeDirection focusChangeDirection; // 0x1E8
	private bool hasFocusableControls; // 0x1F0
	private int newKeyboardFocusControlID; // 0x1F4
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; // 0x1F8
	public static readonly string ussClassName; // 0x0
	private IMGUIContainer.GUIGlobals m_GUIGlobals; // 0x1FC

	// Properties
	public Action onGUIHandler { get; }
	internal ObjectGUIState guiState { get; }
	internal Rect lastWorldClip { get; }
	private GUILayoutUtility.LayoutCache cache { get; }
	private float layoutMeasuredWidth { get; }
	private float layoutMeasuredHeight { get; }
	public ContextType contextType { get; }
	internal bool focusOnlyIfHasFocusableControls { get; }

	// Methods

	// RVA: 0xEB2990 Offset: 0xEB0F90 VA: 0x180EB2990
	public Action get_onGUIHandler() { }

	// RVA: 0xEB27B0 Offset: 0xEB0DB0 VA: 0x180EB27B0
	internal ObjectGUIState get_guiState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB2860 Offset: 0xEB0E60 VA: 0x180EB2860
	internal Rect get_lastWorldClip() { }

	// RVA: 0xEB2720 Offset: 0xEB0D20 VA: 0x180EB2720
	private GUILayoutUtility.LayoutCache get_cache() { }

	// RVA: 0xEB2900 Offset: 0xEB0F00 VA: 0x180EB2900
	private float get_layoutMeasuredWidth() { }

	// RVA: 0xEB2870 Offset: 0xEB0E70 VA: 0x180EB2870
	private float get_layoutMeasuredHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB27A0 Offset: 0xEB0DA0 VA: 0x180EB27A0
	public ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB4D30 Offset: 0xDB3330 VA: 0x180DB4D30
	internal bool get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0xEB24D0 Offset: 0xEB0AD0 VA: 0x180EB24D0
	private void SaveGlobals() { }

	// RVA: 0xEB2380 Offset: 0xEB0980 VA: 0x180EB2380
	private void RestoreGlobals() { }

	// RVA: 0xEB0B10 Offset: 0xEAF110 VA: 0x180EB0B10
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = True) { }

	// RVA: 0xEB2350 Offset: 0xEB0950 VA: 0x180EB2350
	public void MarkDirtyLayout() { }

	// RVA: 0xEB25E0 Offset: 0xEB0BE0 VA: 0x180EB25E0
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = True) { }

	// RVA: 0xEB2240 Offset: 0xEB0840 VA: 0x180EB2240
	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	// RVA: 0xEB1CF0 Offset: 0xEB02F0 VA: 0x180EB1CF0
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0xEB1E00 Offset: 0xEB0400 VA: 0x180EB1E00
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0xEB1950 Offset: 0xEAFF50 VA: 0x180EB1950
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	// RVA: 0xEB26E0 Offset: 0xEB0CE0 VA: 0x180EB26E0
	private static void .cctor() { }

}

private struct IMGUIContainer.GUIGlobals // TypeDefIndex: 4592
{	// Fields
	public Matrix4x4 matrix; // 0x0
	public Color color; // 0x40
	public Color contentColor; // 0x50
	public Color backgroundColor; // 0x60
	public bool enabled; // 0x70
	public bool changed; // 0x71
	public int displayIndex; // 0x74

}

