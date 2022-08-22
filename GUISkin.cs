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

	// RVA: 0x1A78290 Offset: 0x1A76890 VA: 0x181A78290
	public void .ctor() { }

	// RVA: 0x1A76990 Offset: 0x1A74F90 VA: 0x181A76990
	internal void OnEnable() { }

	// RVA: 0x1A77C10 Offset: 0x1A76210 VA: 0x181A77C10
	internal static void CleanupRoots() { }

	// RVA: 0x181D9E0 Offset: 0x181BFE0 VA: 0x18181D9E0
	public Font get_font() { }

	// RVA: 0x1A78730 Offset: 0x1A76D30 VA: 0x181A78730
	public void set_font(Font value) { }

	// RVA: 0x1A6C6E0 Offset: 0x1A6ACE0 VA: 0x181A6C6E0
	public GUIStyle get_box() { }

	// RVA: 0x1A785A0 Offset: 0x1A76BA0 VA: 0x181A785A0
	public void set_box(GUIStyle value) { }

	// RVA: 0x1A784F0 Offset: 0x1A76AF0 VA: 0x181A784F0
	public GUIStyle get_label() { }

	// RVA: 0x1A78BF0 Offset: 0x1A771F0 VA: 0x181A78BF0
	public void set_label(GUIStyle value) { }

	// RVA: 0x1A6D990 Offset: 0x1A6BF90 VA: 0x181A6D990
	public GUIStyle get_textField() { }

	// RVA: 0x1A78D70 Offset: 0x1A77370 VA: 0x181A78D70
	public void set_textField(GUIStyle value) { }

	// RVA: 0xEAC1D0 Offset: 0xEAA7D0 VA: 0x180EAC1D0
	public GUIStyle get_textArea() { }

	// RVA: 0x1A78CF0 Offset: 0x1A772F0 VA: 0x181A78CF0
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x181D9D0 Offset: 0x181BFD0 VA: 0x18181D9D0
	public GUIStyle get_button() { }

	// RVA: 0x1A78620 Offset: 0x1A76C20 VA: 0x181A78620
	public void set_button(GUIStyle value) { }

	// RVA: 0xEB5AD0 Offset: 0xEB40D0 VA: 0x180EB5AD0
	public GUIStyle get_toggle() { }

	// RVA: 0x1A78DF0 Offset: 0x1A773F0 VA: 0x181A78DF0
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x1A78590 Offset: 0x1A76B90 VA: 0x181A78590
	public GUIStyle get_window() { }

	// RVA: 0x1A791F0 Offset: 0x1A777F0 VA: 0x181A791F0
	public void set_window(GUIStyle value) { }

	// RVA: 0x1A784E0 Offset: 0x1A76AE0 VA: 0x181A784E0
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x1A78B70 Offset: 0x1A77170 VA: 0x181A78B70
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0xEABFF0 Offset: 0xEAA5F0 VA: 0x180EABFF0
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x1A78AF0 Offset: 0x1A770F0 VA: 0x181A78AF0
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A784D0 Offset: 0x1A76AD0 VA: 0x181A784D0
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x1A78A70 Offset: 0x1A77070 VA: 0x181A78A70
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A78580 Offset: 0x1A76B80 VA: 0x181A78580
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x1A79170 Offset: 0x1A77770 VA: 0x181A79170
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x1A78570 Offset: 0x1A76B70 VA: 0x181A78570
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x1A790F0 Offset: 0x1A776F0 VA: 0x181A790F0
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A78560 Offset: 0x1A76B60 VA: 0x181A78560
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x1A79070 Offset: 0x1A77670 VA: 0x181A79070
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A784C0 Offset: 0x1A76AC0 VA: 0x181A784C0
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x1A789F0 Offset: 0x1A76FF0 VA: 0x181A789F0
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x1A784B0 Offset: 0x1A76AB0 VA: 0x181A784B0
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x1A78970 Offset: 0x1A76F70 VA: 0x181A78970
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A78490 Offset: 0x1A76A90 VA: 0x181A78490
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x1A78870 Offset: 0x1A76E70 VA: 0x181A78870
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x1A784A0 Offset: 0x1A76AA0 VA: 0x181A784A0
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x1A788F0 Offset: 0x1A76EF0 VA: 0x181A788F0
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x1A78550 Offset: 0x1A76B50 VA: 0x181A78550
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x1A78FF0 Offset: 0x1A775F0 VA: 0x181A78FF0
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x1A78530 Offset: 0x1A76B30 VA: 0x181A78530
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x1A78EF0 Offset: 0x1A774F0 VA: 0x181A78EF0
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A78540 Offset: 0x1A76B40 VA: 0x181A78540
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x1A78F70 Offset: 0x1A77570 VA: 0x181A78F70
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x1A78520 Offset: 0x1A76B20 VA: 0x181A78520
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x1A78E70 Offset: 0x1A77470 VA: 0x181A78E70
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x1A78500 Offset: 0x1A76B00 VA: 0x181A78500
	public GUIStyle get_scrollView() { }

	// RVA: 0x1A78C70 Offset: 0x1A77270 VA: 0x181A78C70
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x1A78390 Offset: 0x1A76990 VA: 0x181A78390
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x1A786A0 Offset: 0x1A76CA0 VA: 0x181A786A0
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x1A78510 Offset: 0x1A76B10 VA: 0x181A78510
	public GUISettings get_settings() { }

	// RVA: 0x1A783A0 Offset: 0x1A769A0 VA: 0x181A783A0
	internal static GUIStyle get_error() { }

	// RVA: 0x1A76990 Offset: 0x1A74F90 VA: 0x181A76990
	internal void Apply() { }

	// RVA: 0x1A76A00 Offset: 0x1A75000 VA: 0x181A76A00
	private void BuildStyleCache() { }

	// RVA: 0x1A77DB0 Offset: 0x1A763B0 VA: 0x181A77DB0
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x1A77C70 Offset: 0x1A76270 VA: 0x181A77C70
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x1A781E0 Offset: 0x1A767E0 VA: 0x181A781E0
	internal void MakeCurrent() { }

	// RVA: 0x1A77D10 Offset: 0x1A76310 VA: 0x181A77D10
	public IEnumerator GetEnumerator() { }

}

internal sealed class GUISkin.SkinChangedDelegate : MulticastDelegate // TypeDefIndex: 4045
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85AC0 Offset: 0x1A840C0 VA: 0x181A85AC0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

