public class GranularAudioClip : MonoBehaviour // TypeDefIndex: 8994
{	// Fields
	public AudioClip sourceClip; // 0x18
	private float[] sourceAudioData; // 0x20
	private int sourceChannels; // 0x28
	public AudioClip granularClip; // 0x30
	public int sampleRate; // 0x38
	public float sourceTime; // 0x3C
	public float sourceTimeVariation; // 0x40
	public float grainAttack; // 0x44
	public float grainSustain; // 0x48
	public float grainRelease; // 0x4C
	public float grainFrequency; // 0x50
	public int grainAttackSamples; // 0x54
	public int grainSustainSamples; // 0x58
	public int grainReleaseSamples; // 0x5C
	public int grainFrequencySamples; // 0x60
	public int samplesUntilNextGrain; // 0x64
	public List<GranularAudioClip.Grain> grains; // 0x68
	private Random random; // 0x70
	private bool inited; // 0x78

	// Methods

	// RVA: 0xCA4670 Offset: 0xCA2C70 VA: 0x180CA4670
	private void Update() { }

	// RVA: 0xCA4370 Offset: 0xCA2970 VA: 0x180CA4370
	private void RefreshCachedData() { }

	// RVA: 0xCA4070 Offset: 0xCA2670 VA: 0x180CA4070
	private void InitAudioClip() { }

	// RVA: 0xCA41B0 Offset: 0xCA27B0 VA: 0x180CA41B0
	private void OnAudioRead(float[] data) { }

	// RVA: 0xCA4470 Offset: 0xCA2A70 VA: 0x180CA4470
	private void SpawnGrain() { }

	// RVA: 0xCA3F60 Offset: 0xCA2560 VA: 0x180CA3F60
	private void CleanupFinishedGrains() { }

	// RVA: 0xCA49B0 Offset: 0xCA2FB0 VA: 0x180CA49B0
	public void .ctor() { }

}

public class GranularAudioClip.Grain // TypeDefIndex: 8995
{	// Fields
	private float[] sourceData; // 0x10
	private int sourceDataLength; // 0x18
	private int startSample; // 0x1C
	private int currentSample; // 0x20
	private int attackTimeSamples; // 0x24
	private int sustainTimeSamples; // 0x28
	private int releaseTimeSamples; // 0x2C
	private float gain; // 0x30
	private float gainPerSampleAttack; // 0x34
	private float gainPerSampleRelease; // 0x38
	private int attackEndSample; // 0x3C
	private int releaseStartSample; // 0x40
	private int endSample; // 0x44

	// Properties
	public bool finished { get; }

	// Methods

	// RVA: 0xCA3F50 Offset: 0xCA2550 VA: 0x180CA3F50
	public bool get_finished() { }

	// RVA: 0xCA3E90 Offset: 0xCA2490 VA: 0x180CA3E90
	public void Init(float[] source, int start, int attack, int sustain, int release) { }

	// RVA: 0xCA3DF0 Offset: 0xCA23F0 VA: 0x180CA3DF0
	public float GetSample() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

