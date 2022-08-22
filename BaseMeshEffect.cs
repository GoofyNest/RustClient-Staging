public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 5031
{	// Fields
	private Graphic m_Graphic; // 0x18

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x10B7950 Offset: 0x10B5F50 VA: 0x1810B7950
	protected Graphic get_graphic() { }

	// RVA: 0x10B78B0 Offset: 0x10B5EB0 VA: 0x1810B78B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B7810 Offset: 0x10B5E10 VA: 0x1810B7810 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B7770 Offset: 0x10B5D70 VA: 0x1810B7770 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x10B7660 Offset: 0x10B5C60 VA: 0x1810B7660 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

