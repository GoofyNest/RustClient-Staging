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

	// RVA: 0x998A90 Offset: 0x997090 VA: 0x180998A90
	public int get_ClientCount() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public int get_ServerCount() { }

	// RVA: 0x997DF0 Offset: 0x9963F0 VA: 0x180997DF0 Slot: 4
	public void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x9979A0 Offset: 0x995FA0 VA: 0x1809979A0
	public void Initialize(uint id) { }

	// RVA: 0x997820 Offset: 0x995E20 VA: 0x180997820
	public void EnterPool() { }

	// RVA: 0x997D80 Offset: 0x996380 VA: 0x180997D80
	public void LeavePool() { }

	// RVA: 0x997E70 Offset: 0x996470 VA: 0x180997E70
	public void SetBehaviourEnabled(bool state) { }

	// RVA: 0x998330 Offset: 0x996930 VA: 0x180998330
	public void SetComponentEnabled(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

