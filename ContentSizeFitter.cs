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

	// RVA: 0x10BA8E0 Offset: 0x10B8EE0 VA: 0x1810BA8E0
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x10BA940 Offset: 0x10B8F40 VA: 0x1810BA940
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x10BA840 Offset: 0x10B8E40 VA: 0x1810BA840
	private RectTransform get_rectTransform() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x10BA600 Offset: 0x10B8C00 VA: 0x1810BA600 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10BA590 Offset: 0x10B8B90 VA: 0x1810BA590 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10BA600 Offset: 0x10B8C00 VA: 0x1810BA600 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x10BA4B0 Offset: 0x10B8AB0 VA: 0x1810BA4B0
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x10BA690 Offset: 0x10B8C90 VA: 0x1810BA690 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x10BA770 Offset: 0x10B8D70 VA: 0x1810BA770 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x10BA610 Offset: 0x10B8C10 VA: 0x1810BA610
	protected void SetDirty() { }

}

public enum ContentSizeFitter.FitMode // TypeDefIndex: 4964
{	// Fields
	public int value__; // 0x0
	public const ContentSizeFitter.FitMode Unconstrained = 0;
	public const ContentSizeFitter.FitMode MinSize = 1;
	public const ContentSizeFitter.FitMode PreferredSize = 2;

}

