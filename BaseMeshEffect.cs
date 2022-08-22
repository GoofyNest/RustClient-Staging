public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 5031
{	// Fields
	private Graphic m_Graphic; // 0x18

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x10B6EE0 Offset: 0x10B54E0 VA: 0x1810B6EE0
	protected Graphic get_graphic() { }

	// RVA: 0x10B6E40 Offset: 0x10B5440 VA: 0x1810B6E40 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B6DA0 Offset: 0x10B53A0 VA: 0x1810B6DA0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B6D00 Offset: 0x10B5300 VA: 0x1810B6D00 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x10B6BF0 Offset: 0x10B51F0 VA: 0x1810B6BF0 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

