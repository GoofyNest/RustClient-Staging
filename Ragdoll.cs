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

	// RVA: 0x6A5E10 Offset: 0x6A4410 VA: 0x1806A5E10
	public LODGroup get_lodGroup() { }

	// RVA: 0x6A4BD0 Offset: 0x6A31D0 VA: 0x1806A4BD0
	public void Awake() { }

	// RVA: 0x6A55F0 Offset: 0x6A3BF0 VA: 0x1806A55F0
	private void RagdollSetup() { }

	// RVA: 0x6A4D70 Offset: 0x6A3370 VA: 0x1806A4D70
	public void CopyBonesFrom(Model otherModel) { }

	// RVA: 0x6A52E0 Offset: 0x6A38E0 VA: 0x1806A52E0
	public void MoveRigidbodiesToRoot() { }

	// RVA: 0x6A50E0 Offset: 0x6A36E0 VA: 0x1806A50E0
	public void CreatePinJoint() { }

	// RVA: 0x6A5C10 Offset: 0x6A4210 VA: 0x1806A5C10
	private void UpdateLODBounds() { }

	// RVA: 0x6A5B80 Offset: 0x6A4180 VA: 0x1806A5B80
	public void SetRagdollSkin(int iSkin) { }

	// RVA: 0x6A53B0 Offset: 0x6A39B0 VA: 0x1806A53B0
	public void OnGibbed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void Init() { }

	// RVA: 0x6A54F0 Offset: 0x6A3AF0 VA: 0x1806A54F0 Slot: 6
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6A5D20 Offset: 0x6A4320 VA: 0x1806A5D20
	public void .ctor() { }

}

