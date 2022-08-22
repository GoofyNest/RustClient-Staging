public class Poolable : MonoBehaviour, IClientComponent, IPrefabPostProcess // TypeDefIndex: 11422
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public uint prefabID; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Behaviour[] behaviours; // 0x20
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Rigidbody[] rigidbodies; // 0x28
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Collider[] colliders; // 0x30
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public LODGroup[] lodgroups; // 0x38
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer[] renderers; // 0x40
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ParticleSystem[] particles; // 0x48
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool[] behaviourStates; // 0x50
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool[] rigidbodyStates; // 0x58
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool[] colliderStates; // 0x60
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool[] lodgroupStates; // 0x68
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool[] rendererStates; // 0x70

	// Properties
	public int ClientCount { get; }
	public int ServerCount { get; }

	// Methods

	// RVA: 0x998F80 Offset: 0x997580 VA: 0x180998F80
	public int get_ClientCount() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	public int get_ServerCount() { }

	// RVA: 0x9982E0 Offset: 0x9968E0 VA: 0x1809982E0 Slot: 4
	public void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x997E90 Offset: 0x996490 VA: 0x180997E90
	public void Initialize(uint id) { }

	// RVA: 0x997D10 Offset: 0x996310 VA: 0x180997D10
	public void EnterPool() { }

	// RVA: 0x998270 Offset: 0x996870 VA: 0x180998270
	public void LeavePool() { }

	// RVA: 0x998360 Offset: 0x996960 VA: 0x180998360
	public void SetBehaviourEnabled(bool state) { }

	// RVA: 0x998820 Offset: 0x996E20 VA: 0x180998820
	public void SetComponentEnabled(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

