public class ParticleSystemContainer : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11325
{	// Fields
	public bool precached; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ParticleSystemContainer.ParticleSystemGroup[] particleGroups; // 0x20

	// Methods

	// RVA: 0x85E360 Offset: 0x85C960 VA: 0x18085E360
	public void Play() { }

	// RVA: 0x85E250 Offset: 0x85C850 VA: 0x18085E250
	public void Pause() { }

	// RVA: 0x85E7D0 Offset: 0x85CDD0 VA: 0x18085E7D0
	public void Stop() { }

	// RVA: 0x85E140 Offset: 0x85C740 VA: 0x18085E140
	public void Clear() { }

	// RVA: 0x85E640 Offset: 0x85CC40 VA: 0x18085E640 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public struct ParticleSystemContainer.ParticleSystemGroup // TypeDefIndex: 11326
{	// Fields
	public ParticleSystem system; // 0x0
	public LODComponentParticleSystem[] lodComponents; // 0x8

}

