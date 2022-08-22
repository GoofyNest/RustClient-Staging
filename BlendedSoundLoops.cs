public class BlendedSoundLoops : MonoBehaviour, IClientComponent // TypeDefIndex: 8985
{	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float blend; // 0x18
	public float blendSmoothing; // 0x1C
	public float loopFadeOutTime; // 0x20
	public float loopFadeInTime; // 0x24
	public float gainModSmoothing; // 0x28
	public float pitchModSmoothing; // 0x2C
	public bool shouldPlay; // 0x30
	public float gain; // 0x34
	public List<BlendedSoundLoops.Loop> loops; // 0x38
	public float maxDistance; // 0x40
	private float smoothedBlend; // 0x44


	private void Update() { }

	public void .ctor() { }

}

public class BlendedSoundLoops.Loop // TypeDefIndex: 8986
{	public SoundDefinition soundDef; // 0x10
	public AnimationCurve gainCurve; // 0x18
	public AnimationCurve pitchCurve; // 0x20
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Sound sound; // 0x28
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public SoundModulation.Modulator gainMod; // 0x30
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public SoundModulation.Modulator pitchMod; // 0x38


	public void .ctor() { }

}

