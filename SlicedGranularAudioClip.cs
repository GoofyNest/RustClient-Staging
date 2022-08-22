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

	// RVA: 0x5AA0F0 Offset: 0x5A86F0 VA: 0x1805AA0F0
	private void Awake() { }

	// RVA: 0x5AA8E0 Offset: 0x5A8EE0 VA: 0x1805AA8E0
	private void Update() { }

	// RVA: 0x5AA640 Offset: 0x5A8C40 VA: 0x1805AA640
	private void RefreshCachedData() { }

	// RVA: 0x5AA340 Offset: 0x5A8940 VA: 0x1805AA340
	private void InitAudioClip() { }

	// RVA: 0x5AA480 Offset: 0x5A8A80 VA: 0x1805AA480
	private void OnAudioRead(float[] data) { }

	// RVA: 0x5AA720 Offset: 0x5A8D20 VA: 0x1805AA720
	private void SpawnGrain() { }

	// RVA: 0x5AA230 Offset: 0x5A8830 VA: 0x1805AA230
	private void CleanupFinishedGrains() { }

	// RVA: 0x5AAC80 Offset: 0x5A9280 VA: 0x1805AAC80
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

	// RVA: 0x5A4E60 Offset: 0x5A3460 VA: 0x1805A4E60
	public bool get_finished() { }

	// RVA: 0x5A4DC0 Offset: 0x5A33C0 VA: 0x1805A4DC0
	public void Init(float[] source, int start, int attack, int sustain, int release) { }

	// RVA: 0x5A4D00 Offset: 0x5A3300 VA: 0x1805A4D00
	public float GetSample() { }

	// RVA: 0x5A4CF0 Offset: 0x5A32F0 VA: 0x1805A4CF0
	public void FadeOut() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

