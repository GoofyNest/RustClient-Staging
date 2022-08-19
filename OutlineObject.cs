public class OutlineObject : MonoBehaviour, IClientComponent // TypeDefIndex: 10094
{	// Fields
	public Mesh[] meshes; // 0x18
	public Transform[] meshTransforms; // 0x20
	private Collider _col; // 0x28

	// Methods

	// RVA: 0x9E9D20 Offset: 0x9E8320 VA: 0x1809E9D20 Slot: 4
	public virtual float SampleVisibility() { }

	// RVA: 0x9E9C00 Offset: 0x9E8200 VA: 0x1809E9C00
	public Collider GetCollider() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void BecomeVisible() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void BecomeInvisible() { }

	// RVA: 0x9E9CF0 Offset: 0x9E82F0 VA: 0x1809E9CF0 Slot: 7
	public virtual Color GetColor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void Registered() { }

	// RVA: 0x9E9FE0 Offset: 0x9E85E0 VA: 0x1809E9FE0 Slot: 9
	public virtual bool ShouldDisplay() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

