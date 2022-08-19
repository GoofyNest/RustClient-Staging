public class BlendedSoundLoops : MonoBehaviour, IClientComponent // TypeDefIndex: 8985
{	// Fields
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
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

	// Methods

	// RVA: 0x513420 Offset: 0x511A20 VA: 0x180513420
	private void Update() { }

	// RVA: 0x513B80 Offset: 0x512180 VA: 0x180513B80
	public void .ctor() { }

}

public class BlendedSoundLoops.Loop // TypeDefIndex: 8986
{	// Fields
	public SoundDefinition soundDef; // 0x10
	public AnimationCurve gainCurve; // 0x18
	public AnimationCurve pitchCurve; // 0x20
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public Sound sound; // 0x28
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public SoundModulation.Modulator gainMod; // 0x30
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public SoundModulation.Modulator pitchMod; // 0x38

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

