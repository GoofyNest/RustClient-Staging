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

	// RVA: 0x22F8030 Offset: 0x22F6630 VA: 0x1822F8030
	public float get_LayoutX() { }

	// RVA: 0x22F8070 Offset: 0x22F6670 VA: 0x1822F8070
	public float get_LayoutY() { }

	// RVA: 0x22F7FF0 Offset: 0x22F65F0 VA: 0x1822F7FF0
	public float get_LayoutWidth() { }

	// RVA: 0x22F7FB0 Offset: 0x22F65B0 VA: 0x1822F7FB0
	public float get_LayoutHeight() { }

	// RVA: 0x22F7EF0 Offset: 0x22F64F0 VA: 0x1822F7EF0
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F7E50 Offset: 0x22F6450 VA: 0x1822F7E50
	public static float BaselineInternal(YogaNode node, float width, float height) { }

}

