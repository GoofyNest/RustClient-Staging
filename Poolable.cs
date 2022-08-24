public class Poolable : MonoBehaviour, IClientComponent, IPrefabPostProcess // TypeDefIndex: 11426
{	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public uint prefabID; // 0x18
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Behaviour[] behaviours; // 0x20
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Rigidbody[] rigidbodies; // 0x28
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Collider[] colliders; // 0x30
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public LODGroup[] lodgroups; // 0x38
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Renderer[] renderers; // 0x40
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ParticleSystem[] particles; // 0x48
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool[] behaviourStates; // 0x50
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool[] rigidbodyStates; // 0x58
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool[] colliderStates; // 0x60
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool[] lodgroupStates; // 0x68
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool[] rendererStates; // 0x70

	public int ClientCount { get; }
	public int ServerCount { get; }


	public int get_ClientCount() { }

	public int get_ServerCount() { }

	public void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void Initialize(uint id) { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void SetBehaviourEnabled(bool state) { }

	public void SetComponentEnabled(bool state) { }

	public void .ctor() { }

}

