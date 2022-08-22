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

	// RVA: 0x1A78550 Offset: 0x1A76B50 VA: 0x181A78550
	public void .ctor() { }

	// RVA: 0x1A76C50 Offset: 0x1A75250 VA: 0x181A76C50
	internal void OnEnable() { }

	// RVA: 0x1A77ED0 Offset: 0x1A764D0 VA: 0x181A77ED0
	internal static void CleanupRoots() { }

	// RVA: 0x181DCA0 Offset: 0x181C2A0 VA: 0x18181DCA0
	public Font get_font() { }

	// RVA: 0x1A789F0 Offset: 0x1A76FF0 VA: 0x181A789F0
	public void set_font(Font value) { }

	// RVA: 0x1A6C9A0 Offset: 0x1A6AFA0 VA: 0x181A6C9A0
	public GUIStyle get_box() { }

	// RVA: 0x1A78860 Offset: 0x1A76E60 VA: 0x181A78860
	public void set_box(GUIStyle value) { }

	// RVA: 0x1A787B0 Offset: 0x1A76DB0 VA: 0x181A787B0
	public GUIStyle get_label() { }

	// RVA: 0x1A78EB0 Offset: 0x1A774B0 VA: 0x181A78EB0
	public void set_label(GUIStyle value) { }

	// RVA: 0x1A6DC50 Offset: 0x1A6C250 VA: 0x181A6DC50
	public GUIStyle get_textField() { }

	// RVA: 0x1A79030 Offset: 0x1A77630 VA: 0x181A79030
	public void set_textField(GUIStyle value) { }

	// RVA: 0xEAC490 Offset: 0xEAAA90 VA: 0x180EAC490
	public GUIStyle get_textArea() { }

	// RVA: 0x1A78FB0 Offset: 0x1A775B0 VA: 0x181A78FB0
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x181DC90 Offset: 0x181C290 VA: 0x18181DC90
	public GUIStyle get_button() { }

	// RVA: 0x1A788E0 Offset: 0x1A76EE0 VA: 0x181A788E0
	public void set_button(GUIStyle value) { }

	// RVA: 0xEB5D90 Offset: 0xEB4390 VA: 0x180EB5D90
	public GUIStyle get_toggle() { }

	// RVA: 0x1A790B0 Offset: 0x1A776B0 VA: 0x181A790B0
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x1A78850 Offset: 0x1A76E50 VA: 0x181A78850
	public GUIStyle get_window() { }

	// RVA: 0x1A794B0 Offset: 0x1A77AB0 VA: 0x181A794B0
	public void set_window(GUIStyle value) { }

	// RVA: 0x1A787A0 Offset: 0x1A76DA0 VA: 0x181A787A0
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x1A78E30 Offset: 0x1A77430 VA: 0x181A78E30
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0xEAC2B0 Offset: 0xEAA8B0 VA: 0x180EAC2B0
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x1A78DB0 Offset: 0x1A773B0 VA: 0x181A78DB0
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A78790 Offset: 0x1A76D90 VA: 0x181A78790
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x1A78D30 Offset: 0x1A77330 VA: 0x181A78D30
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A78840 Offset: 0x1A76E40 VA: 0x181A78840
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x1A79430 Offset: 0x1A77A30 VA: 0x181A79430
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x1A78830 Offset: 0x1A76E30 VA: 0x181A78830
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x1A793B0 Offset: 0x1A779B0 VA: 0x181A793B0
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A78820 Offset: 0x1A76E20 VA: 0x181A78820
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x1A79330 Offset: 0x1A77930 VA: 0x181A79330
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A78780 Offset: 0x1A76D80 VA: 0x181A78780
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x1A78CB0 Offset: 0x1A772B0 VA: 0x181A78CB0
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x1A78770 Offset: 0x1A76D70 VA: 0x181A78770
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x1A78C30 Offset: 0x1A77230 VA: 0x181A78C30
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A78750 Offset: 0x1A76D50 VA: 0x181A78750
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x1A78B30 Offset: 0x1A77130 VA: 0x181A78B30
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x1A78760 Offset: 0x1A76D60 VA: 0x181A78760
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x1A78BB0 Offset: 0x1A771B0 VA: 0x181A78BB0
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x1A78810 Offset: 0x1A76E10 VA: 0x181A78810
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x1A792B0 Offset: 0x1A778B0 VA: 0x181A792B0
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x1A787F0 Offset: 0x1A76DF0 VA: 0x181A787F0
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x1A791B0 Offset: 0x1A777B0 VA: 0x181A791B0
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A78800 Offset: 0x1A76E00 VA: 0x181A78800
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x1A79230 Offset: 0x1A77830 VA: 0x181A79230
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x1A787E0 Offset: 0x1A76DE0 VA: 0x181A787E0
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x1A79130 Offset: 0x1A77730 VA: 0x181A79130
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x1A787C0 Offset: 0x1A76DC0 VA: 0x181A787C0
	public GUIStyle get_scrollView() { }

	// RVA: 0x1A78F30 Offset: 0x1A77530 VA: 0x181A78F30
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x1A78650 Offset: 0x1A76C50 VA: 0x181A78650
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x1A78960 Offset: 0x1A76F60 VA: 0x181A78960
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x1A787D0 Offset: 0x1A76DD0 VA: 0x181A787D0
	public GUISettings get_settings() { }

	// RVA: 0x1A78660 Offset: 0x1A76C60 VA: 0x181A78660
	internal static GUIStyle get_error() { }

	// RVA: 0x1A76C50 Offset: 0x1A75250 VA: 0x181A76C50
	internal void Apply() { }

	// RVA: 0x1A76CC0 Offset: 0x1A752C0 VA: 0x181A76CC0
	private void BuildStyleCache() { }

	// RVA: 0x1A78070 Offset: 0x1A76670 VA: 0x181A78070
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x1A77F30 Offset: 0x1A76530 VA: 0x181A77F30
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x1A784A0 Offset: 0x1A76AA0 VA: 0x181A784A0
	internal void MakeCurrent() { }

	// RVA: 0x1A77FD0 Offset: 0x1A765D0 VA: 0x181A77FD0
	public IEnumerator GetEnumerator() { }

}

internal sealed class GUISkin.SkinChangedDelegate : MulticastDelegate // TypeDefIndex: 4045
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85D80 Offset: 0x1A84380 VA: 0x181A85D80 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

