public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 4957
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_AspectRatio; // 0x1C
	private RectTransform m_Rect; // 0x20
	private bool m_DelayedSetDirty; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x29

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x10B63F0 Offset: 0x10B49F0 VA: 0x1810B63F0
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x7746E0 Offset: 0x772CE0 VA: 0x1807746E0
	public float get_aspectRatio() { }

	// RVA: 0x10B6450 Offset: 0x10B4A50 VA: 0x1810B6450
	public void set_aspectRatio(float value) { }

	// RVA: 0x10B6350 Offset: 0x10B4950 VA: 0x1810B6350
	private RectTransform get_rectTransform() { }

	// RVA: 0x6F5E40 Offset: 0x6F4440 VA: 0x1806F5E40
	protected void .ctor() { }

	// RVA: 0x10B5FD0 Offset: 0x10B45D0 VA: 0x1810B5FD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B5F60 Offset: 0x10B4560 VA: 0x1810B5F60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B6330 Offset: 0x10B4930 VA: 0x1810B6330 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x10B5FD0 Offset: 0x10B45D0 VA: 0x1810B5FD0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x10B5FE0 Offset: 0x10B45E0 VA: 0x1810B5FE0
	private void UpdateRect() { }

	// RVA: 0x10B5E90 Offset: 0x10B4490 VA: 0x1810B5E90
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x10B5DA0 Offset: 0x10B43A0 VA: 0x1810B5DA0
	private Vector2 GetParentSize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x10B5FD0 Offset: 0x10B45D0 VA: 0x1810B5FD0
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

