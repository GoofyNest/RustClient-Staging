public class Ragdoll : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9226
{	// Fields
	public Transform eyeTransform; // 0x18
	public Transform centerBone; // 0x20
	public Rigidbody primaryBody; // 0x28
	public PhysicMaterial physicMaterial; // 0x30
	public SpringJoint corpseJoint; // 0x38
	public Skeleton skeleton; // 0x40
	public Model model; // 0x48
	public List<Joint> joints; // 0x50
	public List<CharacterJoint> characterJoints; // 0x58
	public List<ConfigurableJoint> configurableJoints; // 0x60
	public List<Rigidbody> rigidbodies; // 0x68
	public GameObject GibEffect; // 0x70
	public Rigidbody pinTo; // 0x78
	private LODGroup _lodGroup; // 0x80
	private ArticulatedOccludee occludee; // 0x88
	protected bool IsSetup; // 0x90

	// Properties
	public LODGroup lodGroup { get; }

	// Methods

	// RVA: 0x6A5EB0 Offset: 0x6A44B0 VA: 0x1806A5EB0
	public LODGroup get_lodGroup() { }

	// RVA: 0x6A4C70 Offset: 0x6A3270 VA: 0x1806A4C70
	public void Awake() { }

	// RVA: 0x6A5690 Offset: 0x6A3C90 VA: 0x1806A5690
	private void RagdollSetup() { }

	// RVA: 0x6A4E10 Offset: 0x6A3410 VA: 0x1806A4E10
	public void CopyBonesFrom(Model otherModel) { }

	// RVA: 0x6A5380 Offset: 0x6A3980 VA: 0x1806A5380
	public void MoveRigidbodiesToRoot() { }

	// RVA: 0x6A5180 Offset: 0x6A3780 VA: 0x1806A5180
	public void CreatePinJoint() { }

	// RVA: 0x6A5CB0 Offset: 0x6A42B0 VA: 0x1806A5CB0
	private void UpdateLODBounds() { }

	// RVA: 0x6A5C20 Offset: 0x6A4220 VA: 0x1806A5C20
	public void SetRagdollSkin(int iSkin) { }

	// RVA: 0x6A5450 Offset: 0x6A3A50 VA: 0x1806A5450
	public void OnGibbed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void Init() { }

	// RVA: 0x6A5590 Offset: 0x6A3B90 VA: 0x1806A5590 Slot: 6
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6A5DC0 Offset: 0x6A43C0 VA: 0x1806A5DC0
	public void .ctor() { }

}

