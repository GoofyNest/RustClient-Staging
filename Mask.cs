public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 4984
{	// Fields
	private RectTransform m_RectTransform; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_ShowMaskGraphic; // 0x20
	private Graphic m_Graphic; // 0x28
	private Material m_MaskMaterial; // 0x30
	private Material m_UnmaskMaterial; // 0x38

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x1715C40 Offset: 0x1714240 VA: 0x181715C40
	public RectTransform get_rectTransform() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_showMaskGraphic() { }

	// RVA: 0x1715CB0 Offset: 0x17142B0 VA: 0x181715CB0
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x1715BD0 Offset: 0x17141D0 VA: 0x181715BD0
	public Graphic get_graphic() { }

	// RVA: 0x574750 Offset: 0x572D50 VA: 0x180574750
	protected void .ctor() { }

	// RVA: 0x17156F0 Offset: 0x1713CF0 VA: 0x1817156F0 Slot: 19
	public virtual bool MaskEnabled() { }

	[ObsoleteAttribute] // RVA: 0x75CE0 Offset: 0x750E0 VA: 0x180075CE0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x1715A30 Offset: 0x1714030 VA: 0x181715A30 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x17157C0 Offset: 0x1713DC0 VA: 0x1817157C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x17155F0 Offset: 0x1713BF0 VA: 0x1817155F0 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x17152E0 Offset: 0x17138E0 VA: 0x1817152E0 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

