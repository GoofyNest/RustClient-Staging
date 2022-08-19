public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 4957
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_AspectRatio; // 0x1C
	private RectTransform m_Rect; // 0x20
	private bool m_DelayedSetDirty; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x29

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x10B56C0 Offset: 0x10B3CC0 VA: 0x1810B56C0
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x774680 Offset: 0x772C80 VA: 0x180774680
	public float get_aspectRatio() { }

	// RVA: 0x10B5720 Offset: 0x10B3D20 VA: 0x1810B5720
	public void set_aspectRatio(float value) { }

	// RVA: 0x10B5620 Offset: 0x10B3C20 VA: 0x1810B5620
	private RectTransform get_rectTransform() { }

	// RVA: 0x6F5DE0 Offset: 0x6F43E0 VA: 0x1806F5DE0
	protected void .ctor() { }

	// RVA: 0x10B52A0 Offset: 0x10B38A0 VA: 0x1810B52A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B5230 Offset: 0x10B3830 VA: 0x1810B5230 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B5600 Offset: 0x10B3C00 VA: 0x1810B5600 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x10B52A0 Offset: 0x10B38A0 VA: 0x1810B52A0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x10B52B0 Offset: 0x10B38B0 VA: 0x1810B52B0
	private void UpdateRect() { }

	// RVA: 0x10B5160 Offset: 0x10B3760 VA: 0x1810B5160
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x10B5070 Offset: 0x10B3670 VA: 0x1810B5070
	private Vector2 GetParentSize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x10B52A0 Offset: 0x10B38A0 VA: 0x1810B52A0
	protected void SetDirty() { }

}

public enum AspectRatioFitter.AspectMode // TypeDefIndex: 4958
{	// Fields
	public int value__; // 0x0
	public const AspectRatioFitter.AspectMode None = 0;
	public const AspectRatioFitter.AspectMode WidthControlsHeight = 1;
	public const AspectRatioFitter.AspectMode HeightControlsWidth = 2;
	public const AspectRatioFitter.AspectMode FitInParent = 3;
	public const AspectRatioFitter.AspectMode EnvelopeParent = 4;

}

