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

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x10B5980 Offset: 0x10B3F80 VA: 0x1810B5980
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x774790 Offset: 0x772D90 VA: 0x180774790
	public float get_aspectRatio() { }

	// RVA: 0x10B59E0 Offset: 0x10B3FE0 VA: 0x1810B59E0
	public void set_aspectRatio(float value) { }

	// RVA: 0x10B58E0 Offset: 0x10B3EE0 VA: 0x1810B58E0
	private RectTransform get_rectTransform() { }

	// RVA: 0x6F5EF0 Offset: 0x6F44F0 VA: 0x1806F5EF0
	protected void .ctor() { }

	// RVA: 0x10B5560 Offset: 0x10B3B60 VA: 0x1810B5560 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B54F0 Offset: 0x10B3AF0 VA: 0x1810B54F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B58C0 Offset: 0x10B3EC0 VA: 0x1810B58C0 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x10B5560 Offset: 0x10B3B60 VA: 0x1810B5560 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x10B5570 Offset: 0x10B3B70 VA: 0x1810B5570
	private void UpdateRect() { }

	// RVA: 0x10B5420 Offset: 0x10B3A20 VA: 0x1810B5420
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x10B5330 Offset: 0x10B3930 VA: 0x1810B5330
	private Vector2 GetParentSize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x10B5560 Offset: 0x10B3B60 VA: 0x1810B5560
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

