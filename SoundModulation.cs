public class SoundModulation : MonoBehaviour, IClientComponent // TypeDefIndex: 9035
{	// Fields
	private const int parameterCount = 4;
	private Sound sound; // 0x18
	public List<List<SoundModulation.Modulator>> modulators; // 0x20
	private List<float> modulationValues; // 0x28

	// Methods

	// RVA: 0xA79F80 Offset: 0xA78580 VA: 0x180A79F80
	protected void Awake() { }

	// RVA: 0xA7A360 Offset: 0xA78960 VA: 0x180A7A360
	public void Init() { }

	// RVA: 0xA7A060 Offset: 0xA78660 VA: 0x180A7A060
	public void CalculateValues() { }

	// RVA: 0xA79D80 Offset: 0xA78380 VA: 0x180A79D80
	public void ApplyModulations(AudioSource source) { }

	// RVA: 0xA7A260 Offset: 0xA78860 VA: 0x180A7A260
	public SoundModulation.Modulator CreateModulator(SoundModulation.Parameter param) { }

	// RVA: 0xA79CB0 Offset: 0xA782B0 VA: 0x180A79CB0
	public void AddModulator(SoundModulation.Modulator mod) { }

	// RVA: 0xA7A4E0 Offset: 0xA78AE0 VA: 0x180A7A4E0
	public void RemoveModulator(SoundModulation.Modulator mod) { }

	// RVA: 0xA7A420 Offset: 0xA78A20 VA: 0x180A7A420
	public float ModulationValue(SoundModulation.Parameter param) { }

	// RVA: 0xA7A590 Offset: 0xA78B90 VA: 0x180A7A590
	public void .ctor() { }

}

public enum SoundModulation.Parameter // TypeDefIndex: 9036
{	// Fields
	public int value__; // 0x0
	public const SoundModulation.Parameter Gain = 0;
	public const SoundModulation.Parameter Pitch = 1;
	public const SoundModulation.Parameter Spread = 2;
	public const SoundModulation.Parameter MaxDistance = 3;

}

public class SoundModulation.Modulator // TypeDefIndex: 9037
{	// Fields
	public SoundModulation.Parameter param; // 0x10
	public float value; // 0x14

	// Methods

	// RVA: 0xA74C50 Offset: 0xA73250 VA: 0x180A74C50
	public void .ctor() { }

}

