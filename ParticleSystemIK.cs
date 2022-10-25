public class ParticleSystemIK : MonoBehaviour, IClientComponent // TypeDefIndex: 13098
{
	private ParticleSystem system; 
	private ParticleSystemIK.ParticleSystemIKJob job; 


	private void Awake() { }

	private void Update() { }

	private void OnParticleUpdateJobScheduled() { }

	public void .ctor() { }

}

public struct ParticleSystemIK.ParticleSystemIKJob : IJobParticleSystem // TypeDefIndex: 13099
{
	[ReadOnlyAttribute] 
	public Vector3 position; 
	[ReadOnlyAttribute] 
	public Vector3 forward; 
	[ReadOnlyAttribute] 
	public float deltaTime; 


	public void Execute(ParticleSystemJobData particles) { }

}

