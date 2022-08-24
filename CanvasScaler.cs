public class CanvasScaler : UIBehaviour // TypeDefIndex: 4959
{	[TooltipAttribute] // RVA: 0xF0660 Offset: 0xEFA60 VA: 0x1800F0660
	[SerializeField] // RVA: 0xF0660 Offset: 0xEFA60 VA: 0x1800F0660
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x18
	[TooltipAttribute] // RVA: 0xF07C0 Offset: 0xEFBC0 VA: 0x1800F07C0
	[SerializeField] // RVA: 0xF07C0 Offset: 0xEFBC0 VA: 0x1800F07C0
	protected float m_ReferencePixelsPerUnit; // 0x1C
	[TooltipAttribute] // RVA: 0xF0950 Offset: 0xEFD50 VA: 0x1800F0950
	[SerializeField] // RVA: 0xF0950 Offset: 0xEFD50 VA: 0x1800F0950
	protected float m_ScaleFactor; // 0x20
	[TooltipAttribute] // RVA: 0xF0A90 Offset: 0xEFE90 VA: 0x1800F0A90
	[SerializeField] // RVA: 0xF0A90 Offset: 0xEFE90 VA: 0x1800F0A90
	protected Vector2 m_ReferenceResolution; // 0x24
	[TooltipAttribute] // RVA: 0xF0CD0 Offset: 0xF00D0 VA: 0x1800F0CD0
	[SerializeField] // RVA: 0xF0CD0 Offset: 0xF00D0 VA: 0x1800F0CD0
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x2C
	[TooltipAttribute] // RVA: 0xF0F50 Offset: 0xF0350 VA: 0x1800F0F50
	[RangeAttribute] // RVA: 0xF0F50 Offset: 0xF0350 VA: 0x1800F0F50
	[SerializeField] // RVA: 0xF0F50 Offset: 0xF0350 VA: 0x1800F0F50
	protected float m_MatchWidthOrHeight; // 0x30
	private const float kLogBase = 2;
	[TooltipAttribute] // RVA: 0x6F500 Offset: 0x6E900 VA: 0x18006F500
	[SerializeField] // RVA: 0x6F500 Offset: 0x6E900 VA: 0x18006F500
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x34
	[TooltipAttribute] // RVA: 0x6F740 Offset: 0x6EB40 VA: 0x18006F740
	[SerializeField] // RVA: 0x6F740 Offset: 0x6EB40 VA: 0x18006F740
	protected float m_FallbackScreenDPI; // 0x38
	[TooltipAttribute] // RVA: 0x6FC40 Offset: 0x6F040 VA: 0x18006FC40
	[SerializeField] // RVA: 0x6FC40 Offset: 0x6F040 VA: 0x18006FC40
	protected float m_DefaultSpriteDPI; // 0x3C
	[TooltipAttribute] // RVA: 0x6FE60 Offset: 0x6F260 VA: 0x18006FE60
	[SerializeField] // RVA: 0x6FE60 Offset: 0x6F260 VA: 0x18006FE60
	protected float m_DynamicPixelsPerUnit; // 0x40
	private Canvas m_Canvas; // 0x48
	private float m_PrevScaleFactor; // 0x50
	private float m_PrevReferencePixelsPerUnit; // 0x54

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


	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	public float get_referencePixelsPerUnit() { }

	public void set_referencePixelsPerUnit(float value) { }

	public float get_scaleFactor() { }

	public void set_scaleFactor(float value) { }

	public Vector2 get_referenceResolution() { }

	public void set_referenceResolution(Vector2 value) { }

	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	public float get_matchWidthOrHeight() { }

	public void set_matchWidthOrHeight(float value) { }

	public CanvasScaler.Unit get_physicalUnit() { }

	public void set_physicalUnit(CanvasScaler.Unit value) { }

	public float get_fallbackScreenDPI() { }

	public void set_fallbackScreenDPI(float value) { }

	public float get_defaultSpriteDPI() { }

	public void set_defaultSpriteDPI(float value) { }

	public float get_dynamicPixelsPerUnit() { }

	public void set_dynamicPixelsPerUnit(float value) { }

	protected void .ctor() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected virtual void Update() { }

	protected virtual void Handle() { }

	protected virtual void HandleWorldCanvas() { }

	protected virtual void HandleConstantPixelSize() { }

	protected virtual void HandleScaleWithScreenSize() { }

	protected virtual void HandleConstantPhysicalSize() { }

	protected void SetScaleFactor(float scaleFactor) { }

	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

}

public enum CanvasScaler.ScaleMode // TypeDefIndex: 4960
{	public int value__; // 0x0
	public const CanvasScaler.ScaleMode ConstantPixelSize = 0;
	public const CanvasScaler.ScaleMode ScaleWithScreenSize = 1;
	public const CanvasScaler.ScaleMode ConstantPhysicalSize = 2;

}

public enum CanvasScaler.ScreenMatchMode // TypeDefIndex: 4961
{	public int value__; // 0x0
	public const CanvasScaler.ScreenMatchMode MatchWidthOrHeight = 0;
	public const CanvasScaler.ScreenMatchMode Expand = 1;
	public const CanvasScaler.ScreenMatchMode Shrink = 2;

}

public enum CanvasScaler.Unit // TypeDefIndex: 4962
{	public int value__; // 0x0
	public const CanvasScaler.Unit Centimeters = 0;
	public const CanvasScaler.Unit Millimeters = 1;
	public const CanvasScaler.Unit Inches = 2;
	public const CanvasScaler.Unit Points = 3;
	public const CanvasScaler.Unit Picas = 4;

}

