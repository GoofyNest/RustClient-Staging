public class ParticleSystemContainer : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11325
{	// Fields
	public bool precached; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ParticleSystemContainer.ParticleSystemGroup[] particleGroups; // 0x20

	// Methods

	// RVA: 0x879AC0 Offset: 0x8780C0 VA: 0x180879AC0
	public void Play() { }

	// RVA: 0x8799B0 Offset: 0x877FB0 VA: 0x1808799B0
	public void Pause() { }

	// RVA: 0x879F30 Offset: 0x878530 VA: 0x180879F30
	public void Stop() { }

	// RVA: 0x8798A0 Offset: 0x877EA0 VA: 0x1808798A0
	public void Clear() { }

	// RVA: 0x879DA0 Offset: 0x8783A0 VA: 0x180879DA0 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public struct ParticleSystemContainer.ParticleSystemGroup // TypeDefIndex: 11326
{	// Fields
	public ParticleSystem system; // 0x0
	public LODComponentParticleSystem[] lodComponents; // 0x8

}

