public class SoccerBall : BaseCombatEntity // TypeDefIndex: 11502
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

