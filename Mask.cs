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

	// RVA: 0x1715F00 Offset: 0x1714500 VA: 0x181715F00
	public RectTransform get_rectTransform() { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_showMaskGraphic() { }

	// RVA: 0x1715F70 Offset: 0x1714570 VA: 0x181715F70
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x1715E90 Offset: 0x1714490 VA: 0x181715E90
	public Graphic get_graphic() { }

	// RVA: 0x574750 Offset: 0x572D50 VA: 0x180574750
	protected void .ctor() { }

	// RVA: 0x17159B0 Offset: 0x1713FB0 VA: 0x1817159B0 Slot: 19
	public virtual bool MaskEnabled() { }

	[ObsoleteAttribute] // RVA: 0x75DD0 Offset: 0x751D0 VA: 0x180075DD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x1715CF0 Offset: 0x17142F0 VA: 0x181715CF0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1715A80 Offset: 0x1714080 VA: 0x181715A80 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x17158B0 Offset: 0x1713EB0 VA: 0x1817158B0 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x17155A0 Offset: 0x1713BA0 VA: 0x1817155A0 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

