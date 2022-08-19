public sealed class GUISkin : ScriptableObject // TypeDefIndex: 4044
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Font m_Font; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_box; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_button; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_toggle; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_label; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_textField; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_textArea; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_window; // 0x50
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_horizontalScrollbar; // 0x88
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_horizontalScrollbarThumb; // 0x90
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_horizontalScrollbarLeftButton; // 0x98
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_verticalScrollbar; // 0xA8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_verticalScrollbarThumb; // 0xB0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_verticalScrollbarUpButton; // 0xB8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_verticalScrollbarDownButton; // 0xC0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GUIStyle m_ScrollView; // 0xC8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal GUIStyle[] m_CustomStyles; // 0xD0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x1A782D0 Offset: 0x1A768D0 VA: 0x181A782D0
	public void .ctor() { }

	// RVA: 0x1A769D0 Offset: 0x1A74FD0 VA: 0x181A769D0
	internal void OnEnable() { }

	// RVA: 0x1A77C50 Offset: 0x1A76250 VA: 0x181A77C50
	internal static void CleanupRoots() { }

	// RVA: 0x181D9E0 Offset: 0x181BFE0 VA: 0x18181D9E0
	public Font get_font() { }

	// RVA: 0x1A78770 Offset: 0x1A76D70 VA: 0x181A78770
	public void set_font(Font value) { }

	// RVA: 0x1A6C720 Offset: 0x1A6AD20 VA: 0x181A6C720
	public GUIStyle get_box() { }

	// RVA: 0x1A785E0 Offset: 0x1A76BE0 VA: 0x181A785E0
	public void set_box(GUIStyle value) { }

	// RVA: 0x1A78530 Offset: 0x1A76B30 VA: 0x181A78530
	public GUIStyle get_label() { }

	// RVA: 0x1A78C30 Offset: 0x1A77230 VA: 0x181A78C30
	public void set_label(GUIStyle value) { }

	// RVA: 0x1A6D9D0 Offset: 0x1A6BFD0 VA: 0x181A6D9D0
	public GUIStyle get_textField() { }

	// RVA: 0x1A78DB0 Offset: 0x1A773B0 VA: 0x181A78DB0
	public void set_textField(GUIStyle value) { }

	// RVA: 0xEAC1D0 Offset: 0xEAA7D0 VA: 0x180EAC1D0
	public GUIStyle get_textArea() { }

	// RVA: 0x1A78D30 Offset: 0x1A77330 VA: 0x181A78D30
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x181D9D0 Offset: 0x181BFD0 VA: 0x18181D9D0
	public GUIStyle get_button() { }

	// RVA: 0x1A78660 Offset: 0x1A76C60 VA: 0x181A78660
	public void set_button(GUIStyle value) { }

	// RVA: 0xEB5AD0 Offset: 0xEB40D0 VA: 0x180EB5AD0
	public GUIStyle get_toggle() { }

	// RVA: 0x1A78E30 Offset: 0x1A77430 VA: 0x181A78E30
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x1A785D0 Offset: 0x1A76BD0 VA: 0x181A785D0
	public GUIStyle get_window() { }

	// RVA: 0x1A79230 Offset: 0x1A77830 VA: 0x181A79230
	public void set_window(GUIStyle value) { }

	// RVA: 0x1A78520 Offset: 0x1A76B20 VA: 0x181A78520
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x1A78BB0 Offset: 0x1A771B0 VA: 0x181A78BB0
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0xEABFF0 Offset: 0xEAA5F0 VA: 0x180EABFF0
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x1A78B30 Offset: 0x1A77130 VA: 0x181A78B30
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A78510 Offset: 0x1A76B10 VA: 0x181A78510
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x1A78AB0 Offset: 0x1A770B0 VA: 0x181A78AB0
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A785C0 Offset: 0x1A76BC0 VA: 0x181A785C0
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x1A791B0 Offset: 0x1A777B0 VA: 0x181A791B0
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x1A785B0 Offset: 0x1A76BB0 VA: 0x181A785B0
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x1A79130 Offset: 0x1A77730 VA: 0x181A79130
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A785A0 Offset: 0x1A76BA0 VA: 0x181A785A0
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x1A790B0 Offset: 0x1A776B0 VA: 0x181A790B0
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A78500 Offset: 0x1A76B00 VA: 0x181A78500
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x1A78A30 Offset: 0x1A77030 VA: 0x181A78A30
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x1A784F0 Offset: 0x1A76AF0 VA: 0x181A784F0
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x1A789B0 Offset: 0x1A76FB0 VA: 0x181A789B0
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A784D0 Offset: 0x1A76AD0 VA: 0x181A784D0
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x1A788B0 Offset: 0x1A76EB0 VA: 0x181A788B0
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x1A784E0 Offset: 0x1A76AE0 VA: 0x181A784E0
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x1A78930 Offset: 0x1A76F30 VA: 0x181A78930
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x1A78590 Offset: 0x1A76B90 VA: 0x181A78590
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x1A79030 Offset: 0x1A77630 VA: 0x181A79030
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x1A78570 Offset: 0x1A76B70 VA: 0x181A78570
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x1A78F30 Offset: 0x1A77530 VA: 0x181A78F30
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A78580 Offset: 0x1A76B80 VA: 0x181A78580
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x1A78FB0 Offset: 0x1A775B0 VA: 0x181A78FB0
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x1A78560 Offset: 0x1A76B60 VA: 0x181A78560
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x1A78EB0 Offset: 0x1A774B0 VA: 0x181A78EB0
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x1A78540 Offset: 0x1A76B40 VA: 0x181A78540
	public GUIStyle get_scrollView() { }

	// RVA: 0x1A78CB0 Offset: 0x1A772B0 VA: 0x181A78CB0
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x1A783D0 Offset: 0x1A769D0 VA: 0x181A783D0
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x1A786E0 Offset: 0x1A76CE0 VA: 0x181A786E0
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x1A78550 Offset: 0x1A76B50 VA: 0x181A78550
	public GUISettings get_settings() { }

	// RVA: 0x1A783E0 Offset: 0x1A769E0 VA: 0x181A783E0
	internal static GUIStyle get_error() { }

	// RVA: 0x1A769D0 Offset: 0x1A74FD0 VA: 0x181A769D0
	internal void Apply() { }

	// RVA: 0x1A76A40 Offset: 0x1A75040 VA: 0x181A76A40
	private void BuildStyleCache() { }

	// RVA: 0x1A77DF0 Offset: 0x1A763F0 VA: 0x181A77DF0
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x1A77CB0 Offset: 0x1A762B0 VA: 0x181A77CB0
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x1A78220 Offset: 0x1A76820 VA: 0x181A78220
	internal void MakeCurrent() { }

	// RVA: 0x1A77D50 Offset: 0x1A76350 VA: 0x181A77D50
	public IEnumerator GetEnumerator() { }

}

internal sealed class GUISkin.SkinChangedDelegate : MulticastDelegate // TypeDefIndex: 4045
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85B00 Offset: 0x1A84100 VA: 0x181A85B00 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

