public class CanvasScaler : UIBehaviour // TypeDefIndex: 4959
{	// Fields
	[TooltipAttribute] // RVA: 0xF0430 Offset: 0xEF830 VA: 0x1800F0430
	[SerializeField] // RVA: 0xF0430 Offset: 0xEF830 VA: 0x1800F0430
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x18
	[TooltipAttribute] // RVA: 0xF0620 Offset: 0xEFA20 VA: 0x1800F0620
	[SerializeField] // RVA: 0xF0620 Offset: 0xEFA20 VA: 0x1800F0620
	protected float m_ReferencePixelsPerUnit; // 0x1C
	[TooltipAttribute] // RVA: 0xF0740 Offset: 0xEFB40 VA: 0x1800F0740
	[SerializeField] // RVA: 0xF0740 Offset: 0xEFB40 VA: 0x1800F0740
	protected float m_ScaleFactor; // 0x20
	[TooltipAttribute] // RVA: 0xF0920 Offset: 0xEFD20 VA: 0x1800F0920
	[SerializeField] // RVA: 0xF0920 Offset: 0xEFD20 VA: 0x1800F0920
	protected Vector2 m_ReferenceResolution; // 0x24
	[TooltipAttribute] // RVA: 0xF0B50 Offset: 0xEFF50 VA: 0x1800F0B50
	[SerializeField] // RVA: 0xF0B50 Offset: 0xEFF50 VA: 0x1800F0B50
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x2C
	[TooltipAttribute] // RVA: 0xF0E00 Offset: 0xF0200 VA: 0x1800F0E00
	[RangeAttribute] // RVA: 0xF0E00 Offset: 0xF0200 VA: 0x1800F0E00
	[SerializeField] // RVA: 0xF0E00 Offset: 0xF0200 VA: 0x1800F0E00
	protected float m_MatchWidthOrHeight; // 0x30
	private const float kLogBase = 2;
	[TooltipAttribute] // RVA: 0xF0F60 Offset: 0xF0360 VA: 0x1800F0F60
	[SerializeField] // RVA: 0xF0F60 Offset: 0xF0360 VA: 0x1800F0F60
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x34
	[TooltipAttribute] // RVA: 0x6F5E0 Offset: 0x6E9E0 VA: 0x18006F5E0
	[SerializeField] // RVA: 0x6F5E0 Offset: 0x6E9E0 VA: 0x18006F5E0
	protected float m_FallbackScreenDPI; // 0x38
	[TooltipAttribute] // RVA: 0x6F850 Offset: 0x6EC50 VA: 0x18006F850
	[SerializeField] // RVA: 0x6F850 Offset: 0x6EC50 VA: 0x18006F850
	protected float m_DefaultSpriteDPI; // 0x3C
	[TooltipAttribute] // RVA: 0x6FD40 Offset: 0x6F140 VA: 0x18006FD40
	[SerializeField] // RVA: 0x6FD40 Offset: 0x6F140 VA: 0x18006FD40
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

	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x774680 Offset: 0x772C80 VA: 0x180774680
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x7746C0 Offset: 0x772CC0 VA: 0x1807746C0
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x7746A0 Offset: 0x772CA0 VA: 0x1807746A0
	public float get_scaleFactor() { }

	// RVA: 0x10B7FB0 Offset: 0x10B65B0 VA: 0x1810B7FB0
	public void set_scaleFactor(float value) { }

	// RVA: 0x10B7E30 Offset: 0x10B6430 VA: 0x1810B7E30
	public Vector2 get_referenceResolution() { }

	// RVA: 0x10B7ED0 Offset: 0x10B64D0 VA: 0x1810B7ED0
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x10B8020 Offset: 0x10B6620 VA: 0x1810B8020
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x6BB930 Offset: 0x6B9F30 VA: 0x1806BB930
	public float get_matchWidthOrHeight() { }

	// RVA: 0x4E63E0 Offset: 0x4E49E0 VA: 0x1804E63E0
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0xD73D10 Offset: 0xD72310 VA: 0x180D73D10
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x10B7E20 Offset: 0x10B6420 VA: 0x1810B7E20
	public float get_fallbackScreenDPI() { }

	// RVA: 0x10B7EC0 Offset: 0x10B64C0 VA: 0x1810B7EC0
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0xA218C0 Offset: 0xA1FEC0 VA: 0x180A218C0
	public float get_defaultSpriteDPI() { }

	// RVA: 0x10B7E50 Offset: 0x10B6450 VA: 0x1810B7E50
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x533E70 Offset: 0x532470 VA: 0x180533E70
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x10B7D90 Offset: 0x10B6390 VA: 0x1810B7D90
	protected void .ctor() { }

	// RVA: 0x10B7C90 Offset: 0x10B6290 VA: 0x1810B7C90 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B7C20 Offset: 0x10B6220 VA: 0x1810B7C20 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B7D70 Offset: 0x10B6370 VA: 0x1810B7D70 Slot: 17
	protected virtual void Update() { }

	// RVA: 0x10B7B00 Offset: 0x10B6100 VA: 0x1810B7B00 Slot: 18
	protected virtual void Handle() { }

	// RVA: 0x10B7A90 Offset: 0x10B6090 VA: 0x1810B7A90 Slot: 19
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x10B7710 Offset: 0x10B5D10 VA: 0x1810B7710 Slot: 20
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x10B7780 Offset: 0x10B5D80 VA: 0x1810B7780 Slot: 21
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x10B7630 Offset: 0x10B5C30 VA: 0x1810B7630 Slot: 22
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x10B7D30 Offset: 0x10B6330 VA: 0x1810B7D30
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x10B7CF0 Offset: 0x10B62F0 VA: 0x1810B7CF0
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

