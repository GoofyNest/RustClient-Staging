public class MovementSounds : MonoBehaviour, IOnParentDestroying, ISoundBudgetedUpdate // TypeDefIndex: 10228
{	// Fields
	public SoundDefinition waterMovementDef; // 0x18
	public float waterMovementFadeInSpeed; // 0x20
	public float waterMovementFadeOutSpeed; // 0x24
	public SoundDefinition enterWaterSmall; // 0x28
	public SoundDefinition enterWaterMedium; // 0x30
	public SoundDefinition enterWaterLarge; // 0x38
	private Sound waterMovement; // 0x40
	private SoundModulation.Modulator waterGainMod; // 0x48
	public bool inWater; // 0x50
	public float waterLevel; // 0x54
	public bool mute; // 0x58
	private BaseEntity ent; // 0x60
	private Vector3 velocity; // 0x68
	private int velocityReadings; // 0x74
	private float movementYSmoothed; // 0x78
	private bool wasInWater; // 0x7C
	private float lastTime; // 0x80

	// Methods

	// RVA: 0x7BCFE0 Offset: 0x7BB5E0 VA: 0x1807BCFE0 Slot: 4
	public void OnParentDestroying() { }

	// RVA: 0x7BCFA0 Offset: 0x7BB5A0 VA: 0x1807BCFA0
	protected void OnEnable() { }

	// RVA: 0x7BCF30 Offset: 0x7BB530 VA: 0x1807BCF30
	protected void OnDisable() { }

	// RVA: 0x7BC940 Offset: 0x7BAF40 VA: 0x1807BC940 Slot: 5
	public void DoUpdate() { }

	// RVA: 0x7BD020 Offset: 0x7BB620 VA: 0x1807BD020
	public void UpdateVelocity(Vector3 velocity) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 6
	public bool IsSyncedToParent() { }

	// RVA: 0x693100 Offset: 0x691700 VA: 0x180693100
	public void .ctor() { }

}

