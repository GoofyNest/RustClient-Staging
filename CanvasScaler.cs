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

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x7746E0 Offset: 0x772CE0 VA: 0x1807746E0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x774720 Offset: 0x772D20 VA: 0x180774720
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x774700 Offset: 0x772D00 VA: 0x180774700
	public float get_scaleFactor() { }

	// RVA: 0x10B8CE0 Offset: 0x10B72E0 VA: 0x1810B8CE0
	public void set_scaleFactor(float value) { }

	// RVA: 0x10B8B60 Offset: 0x10B7160 VA: 0x1810B8B60
	public Vector2 get_referenceResolution() { }

	// RVA: 0x10B8C00 Offset: 0x10B7200 VA: 0x1810B8C00
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x10B8D50 Offset: 0x10B7350 VA: 0x1810B8D50
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x6BB9D0 Offset: 0x6B9FD0 VA: 0x1806BB9D0
	public float get_matchWidthOrHeight() { }

	// RVA: 0x4E6370 Offset: 0x4E4970 VA: 0x1804E6370
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0xD74A80 Offset: 0xD73080 VA: 0x180D74A80
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x10B8B50 Offset: 0x10B7150 VA: 0x1810B8B50
	public float get_fallbackScreenDPI() { }

	// RVA: 0x10B8BF0 Offset: 0x10B71F0 VA: 0x1810B8BF0
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0xA22070 Offset: 0xA20670 VA: 0x180A22070
	public float get_defaultSpriteDPI() { }

	// RVA: 0x10B8B80 Offset: 0x10B7180 VA: 0x1810B8B80
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x533DF0 Offset: 0x5323F0 VA: 0x180533DF0
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x533E00 Offset: 0x532400 VA: 0x180533E00
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x10B8AC0 Offset: 0x10B70C0 VA: 0x1810B8AC0
	protected void .ctor() { }

	// RVA: 0x10B89C0 Offset: 0x10B6FC0 VA: 0x1810B89C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B8950 Offset: 0x10B6F50 VA: 0x1810B8950 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B8AA0 Offset: 0x10B70A0 VA: 0x1810B8AA0 Slot: 17
	protected virtual void Update() { }

	// RVA: 0x10B8830 Offset: 0x10B6E30 VA: 0x1810B8830 Slot: 18
	protected virtual void Handle() { }

	// RVA: 0x10B87C0 Offset: 0x10B6DC0 VA: 0x1810B87C0 Slot: 19
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x10B8440 Offset: 0x10B6A40 VA: 0x1810B8440 Slot: 20
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x10B84B0 Offset: 0x10B6AB0 VA: 0x1810B84B0 Slot: 21
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x10B8360 Offset: 0x10B6960 VA: 0x1810B8360 Slot: 22
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x10B8A60 Offset: 0x10B7060 VA: 0x1810B8A60
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x10B8A20 Offset: 0x10B7020 VA: 0x1810B8A20
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

