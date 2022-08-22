public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 4963
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected ContentSizeFitter.FitMode m_HorizontalFit; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected ContentSizeFitter.FitMode m_VerticalFit; // 0x1C
	private RectTransform m_Rect; // 0x20
	private DrivenRectTransformTracker m_Tracker; // 0x28

	// Properties
	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x10BA620 Offset: 0x10B8C20 VA: 0x1810BA620
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x10BA680 Offset: 0x10B8C80 VA: 0x1810BA680
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x10BA580 Offset: 0x10B8B80 VA: 0x1810BA580
	private RectTransform get_rectTransform() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x10BA340 Offset: 0x10B8940 VA: 0x1810BA340 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10BA2D0 Offset: 0x10B88D0 VA: 0x1810BA2D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10BA340 Offset: 0x10B8940 VA: 0x1810BA340 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x10BA1F0 Offset: 0x10B87F0 VA: 0x1810BA1F0
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x10BA3D0 Offset: 0x10B89D0 VA: 0x1810BA3D0 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x10BA4B0 Offset: 0x10B8AB0 VA: 0x1810BA4B0 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x10BA350 Offset: 0x10B8950 VA: 0x1810BA350
	protected void SetDirty() { }

}

public enum ContentSizeFitter.FitMode // TypeDefIndex: 4964
{	// Fields
	public int value__; // 0x0
	public const ContentSizeFitter.FitMode Unconstrained = 0;
	public const ContentSizeFitter.FitMode MinSize = 1;
	public const ContentSizeFitter.FitMode PreferredSize = 2;

}

