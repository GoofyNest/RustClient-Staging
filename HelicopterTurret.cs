public class HelicopterTurret : MonoBehaviour // TypeDefIndex: 9600
{	// Fields
	public PatrolHelicopterAI _heliAI; // 0x18
	public float fireRate; // 0x20
	public float burstLength; // 0x24
	public float timeBetweenBursts; // 0x28
	public float maxTargetRange; // 0x2C
	public float loseTargetAfter; // 0x30
	public Transform gun_yaw; // 0x38
	public Transform gun_pitch; // 0x40
	public Transform muzzleTransform; // 0x48
	public bool left; // 0x50
	public BaseCombatEntity _target; // 0x58

	// Methods

	// RVA: 0x739D00 Offset: 0x738300 VA: 0x180739D00
	public void .ctor() { }

}

