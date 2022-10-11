public class CargoShipSounds : MonoBehaviour, IClientComponent // TypeDefIndex: 9994
{
	public SoundDefinition waveSoundDef; 
	public AnimationCurve waveSoundYGainCurve; 
	public AnimationCurve waveSoundEdgeDistanceGainCurve; 
	private Sound waveSoundL; 
	private Sound waveSoundR; 
	private SoundModulation.Modulator waveSoundLGainMod; 
	private SoundModulation.Modulator waveSoundRGainMod; 
	public SoundDefinition sternWakeSoundDef; 
	private Sound sternWakeSound; 
	private SoundModulation.Modulator sternWakeSoundGainMod; 
	public SoundDefinition engineHumSoundDef; 
	private Sound engineHumSound; 
	public GameObject engineHumTarget; 
	public SoundDefinition hugeRumbleSoundDef; 
	public AnimationCurve hugeRumbleYDiffCurve; 
	public AnimationCurve hugeRumbleRelativeSpeedCurve; 
	private Sound hugeRumbleSound; 
	private SoundModulation.Modulator hugeRumbleGainMod; 
	private Vector3 lastCameraPos; 
	private Vector3 lastRumblePos; 
	private Vector3 lastRumbleLocalPos; 
	public Collider soundFollowCollider; 
	public Collider soundFollowColliderL; 
	public Collider soundFollowColliderR; 
	public Collider sternSoundFollowCollider; 
	private HashSet<CargoShipInteriorSoundTrigger> interiorSoundTriggers; 


	public void UpdateSounds() { }

	public void InitSounds() { }

	public void InteriorTriggerEntered(CargoShipInteriorSoundTrigger trigger) { }

	public void InteriorTriggerExited(CargoShipInteriorSoundTrigger trigger) { }

	public void .ctor() { }

}

