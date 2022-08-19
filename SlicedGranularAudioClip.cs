public class SlicedGranularAudioClip : MonoBehaviour, IClientComponent // TypeDefIndex: 9021
{	// Fields
	public AudioClip sourceClip; // 0x18
	public AudioClip granularClip; // 0x20
	public int sampleRate; // 0x28
	public float grainAttack; // 0x2C
	public float grainSustain; // 0x30
	public float grainRelease; // 0x34
	public float grainFrequency; // 0x38
	public int grainAttackSamples; // 0x3C
	public int grainSustainSamples; // 0x40
	public int grainReleaseSamples; // 0x44
	public int grainFrequencySamples; // 0x48
	public int samplesUntilNextGrain; // 0x4C
	public List<SlicedGranularAudioClip.Grain> grains; // 0x50
	public List<int> startPositions; // 0x58
	public int lastStartPositionIdx; // 0x60
	private float[] sourceAudioData; // 0x68
	private int sourceChannels; // 0x70
	private AudioSource source; // 0x78
	private bool audioDataLoaded; // 0x80
	private Random random; // 0x88

	// Methods

	// RVA: 0x5AA160 Offset: 0x5A8760 VA: 0x1805AA160
	private void Awake() { }

	// RVA: 0x5AA950 Offset: 0x5A8F50 VA: 0x1805AA950
	private void Update() { }

	// RVA: 0x5AA6B0 Offset: 0x5A8CB0 VA: 0x1805AA6B0
	private void RefreshCachedData() { }

	// RVA: 0x5AA3B0 Offset: 0x5A89B0 VA: 0x1805AA3B0
	private void InitAudioClip() { }

	// RVA: 0x5AA4F0 Offset: 0x5A8AF0 VA: 0x1805AA4F0
	private void OnAudioRead(float[] data) { }

	// RVA: 0x5AA790 Offset: 0x5A8D90 VA: 0x1805AA790
	private void SpawnGrain() { }

	// RVA: 0x5AA2A0 Offset: 0x5A88A0 VA: 0x1805AA2A0
	private void CleanupFinishedGrains() { }

	// RVA: 0x5AACF0 Offset: 0x5A92F0 VA: 0x1805AACF0
	public void .ctor() { }

}

public class SlicedGranularAudioClip.Grain // TypeDefIndex: 9022
{	// Fields
	private float[] sourceData; // 0x10
	private int startSample; // 0x18
	private int currentSample; // 0x1C
	private int attackTimeSamples; // 0x20
	private int sustainTimeSamples; // 0x24
	private int releaseTimeSamples; // 0x28
	private float gain; // 0x2C
	private float gainPerSampleAttack; // 0x30
	private float gainPerSampleRelease; // 0x34
	private int attackEndSample; // 0x38
	private int releaseStartSample; // 0x3C
	private int endSample; // 0x40

	// Properties
	public bool finished { get; }

	// Methods

	// RVA: 0x5A4ED0 Offset: 0x5A34D0 VA: 0x1805A4ED0
	public bool get_finished() { }

	// RVA: 0x5A4E30 Offset: 0x5A3430 VA: 0x1805A4E30
	public void Init(float[] source, int start, int attack, int sustain, int release) { }

	// RVA: 0x5A4D70 Offset: 0x5A3370 VA: 0x1805A4D70
	public float GetSample() { }

	// RVA: 0x5A4D60 Offset: 0x5A3360 VA: 0x1805A4D60
	public void FadeOut() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

