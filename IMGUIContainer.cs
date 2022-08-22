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

	// RVA: 0xEB1EE0 Offset: 0xEB04E0 VA: 0x180EB1EE0
	public Action get_onGUIHandler() { }

	// RVA: 0xEB1D00 Offset: 0xEB0300 VA: 0x180EB1D00
	internal ObjectGUIState get_guiState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB1DB0 Offset: 0xEB03B0 VA: 0x180EB1DB0
	internal Rect get_lastWorldClip() { }

	// RVA: 0xEB1C70 Offset: 0xEB0270 VA: 0x180EB1C70
	private GUILayoutUtility.LayoutCache get_cache() { }

	// RVA: 0xEB1E50 Offset: 0xEB0450 VA: 0x180EB1E50
	private float get_layoutMeasuredWidth() { }

	// RVA: 0xEB1DC0 Offset: 0xEB03C0 VA: 0x180EB1DC0
	private float get_layoutMeasuredHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB1CF0 Offset: 0xEB02F0 VA: 0x180EB1CF0
	public ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB4280 Offset: 0xDB2880 VA: 0x180DB4280
	internal bool get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0xEB1A20 Offset: 0xEB0020 VA: 0x180EB1A20
	private void SaveGlobals() { }

	// RVA: 0xEB18D0 Offset: 0xEAFED0 VA: 0x180EB18D0
	private void RestoreGlobals() { }

	// RVA: 0xEB0060 Offset: 0xEAE660 VA: 0x180EB0060
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = True) { }

	// RVA: 0xEB18A0 Offset: 0xEAFEA0 VA: 0x180EB18A0
	public void MarkDirtyLayout() { }

	// RVA: 0xEB1B30 Offset: 0xEB0130 VA: 0x180EB1B30
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = True) { }

	// RVA: 0xEB1790 Offset: 0xEAFD90 VA: 0x180EB1790
	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	// RVA: 0xEB1240 Offset: 0xEAF840 VA: 0x180EB1240
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0xEB1350 Offset: 0xEAF950 VA: 0x180EB1350
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0xEB0EA0 Offset: 0xEAF4A0 VA: 0x180EB0EA0
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	// RVA: 0xEB1C30 Offset: 0xEB0230 VA: 0x180EB1C30
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

