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

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x10BB350 Offset: 0x10B9950 VA: 0x1810BB350
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x10BB3B0 Offset: 0x10B99B0 VA: 0x1810BB3B0
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x10BB2B0 Offset: 0x10B98B0 VA: 0x1810BB2B0
	private RectTransform get_rectTransform() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x10BB070 Offset: 0x10B9670 VA: 0x1810BB070 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10BB000 Offset: 0x10B9600 VA: 0x1810BB000 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10BB070 Offset: 0x10B9670 VA: 0x1810BB070 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x10BAF20 Offset: 0x10B9520 VA: 0x1810BAF20
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x10BB100 Offset: 0x10B9700 VA: 0x1810BB100 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x10BB1E0 Offset: 0x10B97E0 VA: 0x1810BB1E0 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x10BB080 Offset: 0x10B9680 VA: 0x1810BB080
	protected void SetDirty() { }

}

public enum ContentSizeFitter.FitMode // TypeDefIndex: 4964
{	// Fields
	public int value__; // 0x0
	public const ContentSizeFitter.FitMode Unconstrained = 0;
	public const ContentSizeFitter.FitMode MinSize = 1;
	public const ContentSizeFitter.FitMode PreferredSize = 2;

}

