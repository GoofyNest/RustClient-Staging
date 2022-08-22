public sealed class GUISkin : ScriptableObject // TypeDefIndex: 4044
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Font m_Font; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_box; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_button; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_toggle; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_label; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_textField; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_textArea; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_window; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_horizontalScrollbar; // 0x88
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_horizontalScrollbarThumb; // 0x90
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_horizontalScrollbarLeftButton; // 0x98
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_verticalScrollbar; // 0xA8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_verticalScrollbarThumb; // 0xB0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_verticalScrollbarUpButton; // 0xB8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_verticalScrollbarDownButton; // 0xC0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUIStyle m_ScrollView; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal GUIStyle[] m_CustomStyles; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GUISettings m_Settings; // 0xD8
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE0
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x1A64A80 Offset: 0x1A63080 VA: 0x181A64A80
	public void .ctor() { }

	// RVA: 0x1A63180 Offset: 0x1A61780 VA: 0x181A63180
	internal void OnEnable() { }

	// RVA: 0x1A64400 Offset: 0x1A62A00 VA: 0x181A64400
	internal static void CleanupRoots() { }

	// RVA: 0x180B0E0 Offset: 0x18096E0 VA: 0x18180B0E0
	public Font get_font() { }

	// RVA: 0x1A64F20 Offset: 0x1A63520 VA: 0x181A64F20
	public void set_font(Font value) { }

	// RVA: 0x1A58ED0 Offset: 0x1A574D0 VA: 0x181A58ED0
	public GUIStyle get_box() { }

	// RVA: 0x1A64D90 Offset: 0x1A63390 VA: 0x181A64D90
	public void set_box(GUIStyle value) { }

	// RVA: 0x1A64CE0 Offset: 0x1A632E0 VA: 0x181A64CE0
	public GUIStyle get_label() { }

	// RVA: 0x1A653E0 Offset: 0x1A639E0 VA: 0x181A653E0
	public void set_label(GUIStyle value) { }

	// RVA: 0x1A5A180 Offset: 0x1A58780 VA: 0x181A5A180
	public GUIStyle get_textField() { }

	// RVA: 0x1A65560 Offset: 0x1A63B60 VA: 0x181A65560
	public void set_textField(GUIStyle value) { }

	// RVA: 0xEACF40 Offset: 0xEAB540 VA: 0x180EACF40
	public GUIStyle get_textArea() { }

	// RVA: 0x1A654E0 Offset: 0x1A63AE0 VA: 0x181A654E0
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x180B0D0 Offset: 0x18096D0 VA: 0x18180B0D0
	public GUIStyle get_button() { }

	// RVA: 0x1A64E10 Offset: 0x1A63410 VA: 0x181A64E10
	public void set_button(GUIStyle value) { }

	// RVA: 0xEB6840 Offset: 0xEB4E40 VA: 0x180EB6840
	public GUIStyle get_toggle() { }

	// RVA: 0x1A655E0 Offset: 0x1A63BE0 VA: 0x181A655E0
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x1A64D80 Offset: 0x1A63380 VA: 0x181A64D80
	public GUIStyle get_window() { }

	// RVA: 0x1A659E0 Offset: 0x1A63FE0 VA: 0x181A659E0
	public void set_window(GUIStyle value) { }

	// RVA: 0x1A64CD0 Offset: 0x1A632D0 VA: 0x181A64CD0
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x1A65360 Offset: 0x1A63960 VA: 0x181A65360
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0xEACD60 Offset: 0xEAB360 VA: 0x180EACD60
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x1A652E0 Offset: 0x1A638E0 VA: 0x181A652E0
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A64CC0 Offset: 0x1A632C0 VA: 0x181A64CC0
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x1A65260 Offset: 0x1A63860 VA: 0x181A65260
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A64D70 Offset: 0x1A63370 VA: 0x181A64D70
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x1A65960 Offset: 0x1A63F60 VA: 0x181A65960
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x1A64D60 Offset: 0x1A63360 VA: 0x181A64D60
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x1A658E0 Offset: 0x1A63EE0 VA: 0x181A658E0
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A64D50 Offset: 0x1A63350 VA: 0x181A64D50
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x1A65860 Offset: 0x1A63E60 VA: 0x181A65860
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A64CB0 Offset: 0x1A632B0 VA: 0x181A64CB0
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x1A651E0 Offset: 0x1A637E0 VA: 0x181A651E0
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x1A64CA0 Offset: 0x1A632A0 VA: 0x181A64CA0
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x1A65160 Offset: 0x1A63760 VA: 0x181A65160
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A64C80 Offset: 0x1A63280 VA: 0x181A64C80
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x1A65060 Offset: 0x1A63660 VA: 0x181A65060
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x1A64C90 Offset: 0x1A63290 VA: 0x181A64C90
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x1A650E0 Offset: 0x1A636E0 VA: 0x181A650E0
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x1A64D40 Offset: 0x1A63340 VA: 0x181A64D40
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x1A657E0 Offset: 0x1A63DE0 VA: 0x181A657E0
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x1A64D20 Offset: 0x1A63320 VA: 0x181A64D20
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x1A656E0 Offset: 0x1A63CE0 VA: 0x181A656E0
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A64D30 Offset: 0x1A63330 VA: 0x181A64D30
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x1A65760 Offset: 0x1A63D60 VA: 0x181A65760
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x1A64D10 Offset: 0x1A63310 VA: 0x181A64D10
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x1A65660 Offset: 0x1A63C60 VA: 0x181A65660
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x1A64CF0 Offset: 0x1A632F0 VA: 0x181A64CF0
	public GUIStyle get_scrollView() { }

	// RVA: 0x1A65460 Offset: 0x1A63A60 VA: 0x181A65460
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x1A64B80 Offset: 0x1A63180 VA: 0x181A64B80
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x1A64E90 Offset: 0x1A63490 VA: 0x181A64E90
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x1A64D00 Offset: 0x1A63300 VA: 0x181A64D00
	public GUISettings get_settings() { }

	// RVA: 0x1A64B90 Offset: 0x1A63190 VA: 0x181A64B90
	internal static GUIStyle get_error() { }

	// RVA: 0x1A63180 Offset: 0x1A61780 VA: 0x181A63180
	internal void Apply() { }

	// RVA: 0x1A631F0 Offset: 0x1A617F0 VA: 0x181A631F0
	private void BuildStyleCache() { }

	// RVA: 0x1A645A0 Offset: 0x1A62BA0 VA: 0x181A645A0
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x1A64460 Offset: 0x1A62A60 VA: 0x181A64460
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x1A649D0 Offset: 0x1A62FD0 VA: 0x181A649D0
	internal void MakeCurrent() { }

	// RVA: 0x1A64500 Offset: 0x1A62B00 VA: 0x181A64500
	public IEnumerator GetEnumerator() { }

}

internal sealed class GUISkin.SkinChangedDelegate : MulticastDelegate // TypeDefIndex: 4045
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A722B0 Offset: 0x1A708B0 VA: 0x181A722B0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

