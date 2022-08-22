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

	// RVA: 0x6A5F20 Offset: 0x6A4520 VA: 0x1806A5F20
	public LODGroup get_lodGroup() { }

	// RVA: 0x6A4CE0 Offset: 0x6A32E0 VA: 0x1806A4CE0
	public void Awake() { }

	// RVA: 0x6A5700 Offset: 0x6A3D00 VA: 0x1806A5700
	private void RagdollSetup() { }

	// RVA: 0x6A4E80 Offset: 0x6A3480 VA: 0x1806A4E80
	public void CopyBonesFrom(Model otherModel) { }

	// RVA: 0x6A53F0 Offset: 0x6A39F0 VA: 0x1806A53F0
	public void MoveRigidbodiesToRoot() { }

	// RVA: 0x6A51F0 Offset: 0x6A37F0 VA: 0x1806A51F0
	public void CreatePinJoint() { }

	// RVA: 0x6A5D20 Offset: 0x6A4320 VA: 0x1806A5D20
	private void UpdateLODBounds() { }

	// RVA: 0x6A5C90 Offset: 0x6A4290 VA: 0x1806A5C90
	public void SetRagdollSkin(int iSkin) { }

	// RVA: 0x6A54C0 Offset: 0x6A3AC0 VA: 0x1806A54C0
	public void OnGibbed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void Init() { }

	// RVA: 0x6A5600 Offset: 0x6A3C00 VA: 0x1806A5600 Slot: 6
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6A5E30 Offset: 0x6A4430 VA: 0x1806A5E30
	public void .ctor() { }

}

