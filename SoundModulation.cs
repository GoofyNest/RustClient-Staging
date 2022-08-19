public class SoundModulation : MonoBehaviour, IClientComponent // TypeDefIndex: 9035
{	// Fields
	private const int parameterCount = 4;
	private Sound sound; // 0x18
	public List<List<SoundModulation.Modulator>> modulators; // 0x20
	private List<float> modulationValues; // 0x28

	// Methods

	// RVA: 0xA797F0 Offset: 0xA77DF0 VA: 0x180A797F0
	protected void Awake() { }

	// RVA: 0xA79BD0 Offset: 0xA781D0 VA: 0x180A79BD0
	public void Init() { }

	// RVA: 0xA798D0 Offset: 0xA77ED0 VA: 0x180A798D0
	public void CalculateValues() { }

	// RVA: 0xA795F0 Offset: 0xA77BF0 VA: 0x180A795F0
	public void ApplyModulations(AudioSource source) { }

	// RVA: 0xA79AD0 Offset: 0xA780D0 VA: 0x180A79AD0
	public SoundModulation.Modulator CreateModulator(SoundModulation.Parameter param) { }

	// RVA: 0xA79520 Offset: 0xA77B20 VA: 0x180A79520
	public void AddModulator(SoundModulation.Modulator mod) { }

	// RVA: 0xA79D50 Offset: 0xA78350 VA: 0x180A79D50
	public void RemoveModulator(SoundModulation.Modulator mod) { }

	// RVA: 0xA79C90 Offset: 0xA78290 VA: 0x180A79C90
	public float ModulationValue(SoundModulation.Parameter param) { }

	// RVA: 0xA79E00 Offset: 0xA78400 VA: 0x180A79E00
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

	// RVA: 0xA744C0 Offset: 0xA72AC0 VA: 0x180A744C0
	public void .ctor() { }

}

