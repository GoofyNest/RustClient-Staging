public class SoccerBall : BaseCombatEntity // TypeDefIndex: 11463
{
	[HeaderAttribute] 
	[SerializeField] 
	private Rigidbody rigidBody; 
	[SerializeField] 
	private float additionalForceMultiplier; 
	[SerializeField] 
	private float upForceMultiplier; 
	[SerializeField] 
	private DamageRenderer damageRenderer; 
	[SerializeField] 
	private float explosionForceMultiplier; 
	[SerializeField] 
	private float otherForceMultiplier; 


	public void .ctor() { }

}

