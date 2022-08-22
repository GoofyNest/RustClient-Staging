public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 4984
{	// Fields
	private RectTransform m_RectTransform; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_ShowMaskGraphic; // 0x20
	private Graphic m_Graphic; // 0x28
	private Material m_MaskMaterial; // 0x30
	private Material m_UnmaskMaterial; // 0x38

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x170F350 Offset: 0x170D950 VA: 0x18170F350
	public RectTransform get_rectTransform() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_showMaskGraphic() { }

	// RVA: 0x170F3C0 Offset: 0x170D9C0 VA: 0x18170F3C0
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x170F2E0 Offset: 0x170D8E0 VA: 0x18170F2E0
	public Graphic get_graphic() { }

	// RVA: 0x5746E0 Offset: 0x572CE0 VA: 0x1805746E0
	protected void .ctor() { }

	// RVA: 0x170EE00 Offset: 0x170D400 VA: 0x18170EE00 Slot: 19
	public virtual bool MaskEnabled() { }

	[ObsoleteAttribute] // RVA: 0x75DD0 Offset: 0x751D0 VA: 0x180075DD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x170F140 Offset: 0x170D740 VA: 0x18170F140 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x170EED0 Offset: 0x170D4D0 VA: 0x18170EED0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x170ED00 Offset: 0x170D300 VA: 0x18170ED00 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x170E9F0 Offset: 0x170CFF0 VA: 0x18170E9F0 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

