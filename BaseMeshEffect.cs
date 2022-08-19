public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 5031
{	// Fields
	private Graphic m_Graphic; // 0x18

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x10B6C20 Offset: 0x10B5220 VA: 0x1810B6C20
	protected Graphic get_graphic() { }

	// RVA: 0x10B6B80 Offset: 0x10B5180 VA: 0x1810B6B80 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B6AE0 Offset: 0x10B50E0 VA: 0x1810B6AE0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B6A40 Offset: 0x10B5040 VA: 0x1810B6A40 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x10B6930 Offset: 0x10B4F30 VA: 0x1810B6930 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

