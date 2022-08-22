internal class YogaNode // TypeDefIndex: 4579
{	// Fields
	internal IntPtr _ygNode; // 0x10
	private MeasureFunction _measureFunction; // 0x18
	private BaselineFunction _baselineFunction; // 0x20

	// Properties
	public float LayoutX { get; }
	public float LayoutY { get; }
	public float LayoutWidth { get; }
	public float LayoutHeight { get; }

	// Methods

	// RVA: 0x22F8950 Offset: 0x22F6F50 VA: 0x1822F8950
	public float get_LayoutX() { }

	// RVA: 0x22F8990 Offset: 0x22F6F90 VA: 0x1822F8990
	public float get_LayoutY() { }

	// RVA: 0x22F8910 Offset: 0x22F6F10 VA: 0x1822F8910
	public float get_LayoutWidth() { }

	// RVA: 0x22F88D0 Offset: 0x22F6ED0 VA: 0x1822F88D0
	public float get_LayoutHeight() { }

	// RVA: 0x22F8810 Offset: 0x22F6E10 VA: 0x1822F8810
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F8770 Offset: 0x22F6D70 VA: 0x1822F8770
	public static float BaselineInternal(YogaNode node, float width, float height) { }

}

