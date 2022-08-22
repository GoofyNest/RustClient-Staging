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

	// RVA: 0x22F8130 Offset: 0x22F6730 VA: 0x1822F8130
	public float get_LayoutX() { }

	// RVA: 0x22F8170 Offset: 0x22F6770 VA: 0x1822F8170
	public float get_LayoutY() { }

	// RVA: 0x22F80F0 Offset: 0x22F66F0 VA: 0x1822F80F0
	public float get_LayoutWidth() { }

	// RVA: 0x22F80B0 Offset: 0x22F66B0 VA: 0x1822F80B0
	public float get_LayoutHeight() { }

	// RVA: 0x22F7FF0 Offset: 0x22F65F0 VA: 0x1822F7FF0
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F7F50 Offset: 0x22F6550 VA: 0x1822F7F50
	public static float BaselineInternal(YogaNode node, float width, float height) { }

}

