public class ParticleSystemIK : MonoBehaviour, IClientComponent // TypeDefIndex: 11331
{	private ParticleSystem system; // 0x18
	private ParticleSystemIK.ParticleSystemIKJob job; // 0x20


	private void Awake() { }

	private void Update() { }

	private void OnParticleUpdateJobScheduled() { }

	public void .ctor() { }

}

public struct ParticleSystemIK.ParticleSystemIKJob : IJobParticleSystem // TypeDefIndex: 11332
{	[ReadOnlyAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public Vector3 position; // 0x0
	[ReadOnlyAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public Vector3 forward; // 0xC
	[ReadOnlyAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public float deltaTime; // 0x18


	public void Execute(ParticleSystemJobData particles) { }

}

