public class SoundModulation : MonoBehaviour, IClientComponent // TypeDefIndex: 9035
{	// Fields
	private const int parameterCount = 4;
	private Sound sound; // 0x18
	public List<List<SoundModulation.Modulator>> modulators; // 0x20
	private List<float> modulationValues; // 0x28

	// Methods

	// RVA: 0xA79AB0 Offset: 0xA780B0 VA: 0x180A79AB0
	protected void Awake() { }

	// RVA: 0xA79E90 Offset: 0xA78490 VA: 0x180A79E90
	public void Init() { }

	// RVA: 0xA79B90 Offset: 0xA78190 VA: 0x180A79B90
	public void CalculateValues() { }

	// RVA: 0xA798B0 Offset: 0xA77EB0 VA: 0x180A798B0
	public void ApplyModulations(AudioSource source) { }

	// RVA: 0xA79D90 Offset: 0xA78390 VA: 0x180A79D90
	public SoundModulation.Modulator CreateModulator(SoundModulation.Parameter param) { }

	// RVA: 0xA797E0 Offset: 0xA77DE0 VA: 0x180A797E0
	public void AddModulator(SoundModulation.Modulator mod) { }

	// RVA: 0xA7A010 Offset: 0xA78610 VA: 0x180A7A010
	public void RemoveModulator(SoundModulation.Modulator mod) { }

	// RVA: 0xA79F50 Offset: 0xA78550 VA: 0x180A79F50
	public float ModulationValue(SoundModulation.Parameter param) { }

	// RVA: 0xA7A0C0 Offset: 0xA786C0 VA: 0x180A7A0C0
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

	// RVA: 0xA74780 Offset: 0xA72D80 VA: 0x180A74780
	public void .ctor() { }

}

