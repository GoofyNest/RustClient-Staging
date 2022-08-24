public class ParticleSystemContainer : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11329
{	public bool precached; // 0x18
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ParticleSystemContainer.ParticleSystemGroup[] particleGroups; // 0x20


	public void Play() { }

	public void Pause() { }

	public void Stop() { }

	public void Clear() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public struct ParticleSystemContainer.ParticleSystemGroup // TypeDefIndex: 11330
{	public ParticleSystem system; // 0x0
	public LODComponentParticleSystem[] lodComponents; // 0x8

}

