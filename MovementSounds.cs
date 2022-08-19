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

	// RVA: 0x7BCED0 Offset: 0x7BB4D0 VA: 0x1807BCED0 Slot: 4
	public void OnParentDestroying() { }

	// RVA: 0x7BCE90 Offset: 0x7BB490 VA: 0x1807BCE90
	protected void OnEnable() { }

	// RVA: 0x7BCE20 Offset: 0x7BB420 VA: 0x1807BCE20
	protected void OnDisable() { }

	// RVA: 0x7BC830 Offset: 0x7BAE30 VA: 0x1807BC830 Slot: 5
	public void DoUpdate() { }

	// RVA: 0x7BCF10 Offset: 0x7BB510 VA: 0x1807BCF10
	public void UpdateVelocity(Vector3 velocity) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 6
	public bool IsSyncedToParent() { }

	// RVA: 0x692FF0 Offset: 0x6915F0 VA: 0x180692FF0
	public void .ctor() { }

}

