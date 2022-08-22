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

	// RVA: 0xEB1C20 Offset: 0xEB0220 VA: 0x180EB1C20
	public Action get_onGUIHandler() { }

	// RVA: 0xEB1A40 Offset: 0xEB0040 VA: 0x180EB1A40
	internal ObjectGUIState get_guiState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB1AF0 Offset: 0xEB00F0 VA: 0x180EB1AF0
	internal Rect get_lastWorldClip() { }

	// RVA: 0xEB19B0 Offset: 0xEAFFB0 VA: 0x180EB19B0
	private GUILayoutUtility.LayoutCache get_cache() { }

	// RVA: 0xEB1B90 Offset: 0xEB0190 VA: 0x180EB1B90
	private float get_layoutMeasuredWidth() { }

	// RVA: 0xEB1B00 Offset: 0xEB0100 VA: 0x180EB1B00
	private float get_layoutMeasuredHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB1A30 Offset: 0xEB0030 VA: 0x180EB1A30
	public ContextType get_contextType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDB3FC0 Offset: 0xDB25C0 VA: 0x180DB3FC0
	internal bool get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0xEB1760 Offset: 0xEAFD60 VA: 0x180EB1760
	private void SaveGlobals() { }

	// RVA: 0xEB1610 Offset: 0xEAFC10 VA: 0x180EB1610
	private void RestoreGlobals() { }

	// RVA: 0xEAFDA0 Offset: 0xEAE3A0 VA: 0x180EAFDA0
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = True) { }

	// RVA: 0xEB15E0 Offset: 0xEAFBE0 VA: 0x180EB15E0
	public void MarkDirtyLayout() { }

	// RVA: 0xEB1870 Offset: 0xEAFE70 VA: 0x180EB1870
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = True) { }

	// RVA: 0xEB14D0 Offset: 0xEAFAD0 VA: 0x180EB14D0
	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	// RVA: 0xEB0F80 Offset: 0xEAF580 VA: 0x180EB0F80
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0xEB1090 Offset: 0xEAF690 VA: 0x180EB1090
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0xEB0BE0 Offset: 0xEAF1E0 VA: 0x180EB0BE0
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	// RVA: 0xEB1970 Offset: 0xEAFF70 VA: 0x180EB1970
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

