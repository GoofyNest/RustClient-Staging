public class ParticleSystemContainer : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11325
{	public bool precached; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ParticleSystemContainer.ParticleSystemGroup[] particleGroups; // 0x20


	public void Play() { }

	public void Pause() { }

	public void Stop() { }

	public void Clear() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public struct ParticleSystemContainer.ParticleSystemGroup // TypeDefIndex: 11326
{	public ParticleSystem system; // 0x0
	public LODComponentParticleSystem[] lodComponents; // 0x8

}

