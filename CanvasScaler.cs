public class CanvasScaler : UIBehaviour // TypeDefIndex: 4959
{	// Fields
	[TooltipAttribute] // RVA: 0xF04C0 Offset: 0xEF8C0 VA: 0x1800F04C0
	[SerializeField] // RVA: 0xF04C0 Offset: 0xEF8C0 VA: 0x1800F04C0
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x18
	[TooltipAttribute] // RVA: 0xF0620 Offset: 0xEFA20 VA: 0x1800F0620
	[SerializeField] // RVA: 0xF0620 Offset: 0xEFA20 VA: 0x1800F0620
	protected float m_ReferencePixelsPerUnit; // 0x1C
	[TooltipAttribute] // RVA: 0xF07D0 Offset: 0xEFBD0 VA: 0x1800F07D0
	[SerializeField] // RVA: 0xF07D0 Offset: 0xEFBD0 VA: 0x1800F07D0
	protected float m_ScaleFactor; // 0x20
	[TooltipAttribute] // RVA: 0xF09B0 Offset: 0xEFDB0 VA: 0x1800F09B0
	[SerializeField] // RVA: 0xF09B0 Offset: 0xEFDB0 VA: 0x1800F09B0
	protected Vector2 m_ReferenceResolution; // 0x24
	[TooltipAttribute] // RVA: 0xF0BF0 Offset: 0xEFFF0 VA: 0x1800F0BF0
	[SerializeField] // RVA: 0xF0BF0 Offset: 0xEFFF0 VA: 0x1800F0BF0
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x2C
	[TooltipAttribute] // RVA: 0xF0E20 Offset: 0xF0220 VA: 0x1800F0E20
	[RangeAttribute] // RVA: 0xF0E20 Offset: 0xF0220 VA: 0x1800F0E20
	[SerializeField] // RVA: 0xF0E20 Offset: 0xF0220 VA: 0x1800F0E20
	protected float m_MatchWidthOrHeight; // 0x30
	private const float kLogBase = 2;
	[TooltipAttribute] // RVA: 0x6F450 Offset: 0x6E850 VA: 0x18006F450
	[SerializeField] // RVA: 0x6F450 Offset: 0x6E850 VA: 0x18006F450
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x34
	[TooltipAttribute] // RVA: 0x6F6B0 Offset: 0x6EAB0 VA: 0x18006F6B0
	[SerializeField] // RVA: 0x6F6B0 Offset: 0x6EAB0 VA: 0x18006F6B0
	protected float m_FallbackScreenDPI; // 0x38
	[TooltipAttribute] // RVA: 0x6FB50 Offset: 0x6EF50 VA: 0x18006FB50
	[SerializeField] // RVA: 0x6FB50 Offset: 0x6EF50 VA: 0x18006FB50
	protected float m_DefaultSpriteDPI; // 0x3C
	[TooltipAttribute] // RVA: 0x6FDC0 Offset: 0x6F1C0 VA: 0x18006FDC0
	[SerializeField] // RVA: 0x6FDC0 Offset: 0x6F1C0 VA: 0x18006FDC0
	protected float m_DynamicPixelsPerUnit; // 0x40
	private Canvas m_Canvas; // 0x48
	private float m_PrevScaleFactor; // 0x50
	private float m_PrevReferencePixelsPerUnit; // 0x54

	// Properties
	public CanvasScaler.ScaleMode uiScaleMode { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public float scaleFactor { get; set; }
	public Vector2 referenceResolution { get; set; }
	public CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
	public float matchWidthOrHeight { get; set; }
	public CanvasScaler.Unit physicalUnit { get; set; }
	public float fallbackScreenDPI { get; set; }
	public float defaultSpriteDPI { get; set; }
	public float dynamicPixelsPerUnit { get; set; }

	// Methods

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x774790 Offset: 0x772D90 VA: 0x180774790
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x7747D0 Offset: 0x772DD0 VA: 0x1807747D0
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x7747B0 Offset: 0x772DB0 VA: 0x1807747B0
	public float get_scaleFactor() { }

	// RVA: 0x10B8270 Offset: 0x10B6870 VA: 0x1810B8270
	public void set_scaleFactor(float value) { }

	// RVA: 0x10B80F0 Offset: 0x10B66F0 VA: 0x1810B80F0
	public Vector2 get_referenceResolution() { }

	// RVA: 0x10B8190 Offset: 0x10B6790 VA: 0x1810B8190
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x10B82E0 Offset: 0x10B68E0 VA: 0x1810B82E0
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x6BBA40 Offset: 0x6BA040 VA: 0x1806BBA40
	public float get_matchWidthOrHeight() { }

	// RVA: 0x4E63E0 Offset: 0x4E49E0 VA: 0x1804E63E0
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0xD73FD0 Offset: 0xD725D0 VA: 0x180D73FD0
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x10B80E0 Offset: 0x10B66E0 VA: 0x1810B80E0
	public float get_fallbackScreenDPI() { }

	// RVA: 0x10B8180 Offset: 0x10B6780 VA: 0x1810B8180
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0xA21B80 Offset: 0xA20180 VA: 0x180A21B80
	public float get_defaultSpriteDPI() { }

	// RVA: 0x10B8110 Offset: 0x10B6710 VA: 0x1810B8110
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x533E70 Offset: 0x532470 VA: 0x180533E70
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x10B8050 Offset: 0x10B6650 VA: 0x1810B8050
	protected void .ctor() { }

	// RVA: 0x10B7F50 Offset: 0x10B6550 VA: 0x1810B7F50 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B7EE0 Offset: 0x10B64E0 VA: 0x1810B7EE0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B8030 Offset: 0x10B6630 VA: 0x1810B8030 Slot: 17
	protected virtual void Update() { }

	// RVA: 0x10B7DC0 Offset: 0x10B63C0 VA: 0x1810B7DC0 Slot: 18
	protected virtual void Handle() { }

	// RVA: 0x10B7D50 Offset: 0x10B6350 VA: 0x1810B7D50 Slot: 19
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x10B79D0 Offset: 0x10B5FD0 VA: 0x1810B79D0 Slot: 20
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x10B7A40 Offset: 0x10B6040 VA: 0x1810B7A40 Slot: 21
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x10B78F0 Offset: 0x10B5EF0 VA: 0x1810B78F0 Slot: 22
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x10B7FF0 Offset: 0x10B65F0 VA: 0x1810B7FF0
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x10B7FB0 Offset: 0x10B65B0 VA: 0x1810B7FB0
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

}

public enum CanvasScaler.ScaleMode // TypeDefIndex: 4960
{	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScaleMode ConstantPixelSize = 0;
	public const CanvasScaler.ScaleMode ScaleWithScreenSize = 1;
	public const CanvasScaler.ScaleMode ConstantPhysicalSize = 2;

}

public enum CanvasScaler.ScreenMatchMode // TypeDefIndex: 4961
{	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScreenMatchMode MatchWidthOrHeight = 0;
	public const CanvasScaler.ScreenMatchMode Expand = 1;
	public const CanvasScaler.ScreenMatchMode Shrink = 2;

}

public enum CanvasScaler.Unit // TypeDefIndex: 4962
{	// Fields
	public int value__; // 0x0
	public const CanvasScaler.Unit Centimeters = 0;
	public const CanvasScaler.Unit Millimeters = 1;
	public const CanvasScaler.Unit Inches = 2;
	public const CanvasScaler.Unit Points = 3;
	public const CanvasScaler.Unit Picas = 4;

}

