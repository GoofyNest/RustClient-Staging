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

	// RVA: 0x22F7E70 Offset: 0x22F6470 VA: 0x1822F7E70
	public float get_LayoutX() { }

	// RVA: 0x22F7EB0 Offset: 0x22F64B0 VA: 0x1822F7EB0
	public float get_LayoutY() { }

	// RVA: 0x22F7E30 Offset: 0x22F6430 VA: 0x1822F7E30
	public float get_LayoutWidth() { }

	// RVA: 0x22F7DF0 Offset: 0x22F63F0 VA: 0x1822F7DF0
	public float get_LayoutHeight() { }

	// RVA: 0x22F7D30 Offset: 0x22F6330 VA: 0x1822F7D30
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F7C90 Offset: 0x22F6290 VA: 0x1822F7C90
	public static float BaselineInternal(YogaNode node, float width, float height) { }

}

