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

	// RVA: 0xCA41D0 Offset: 0xCA27D0 VA: 0x180CA41D0
	private void Update() { }

	// RVA: 0xCA3ED0 Offset: 0xCA24D0 VA: 0x180CA3ED0
	private void RefreshCachedData() { }

	// RVA: 0xCA3BD0 Offset: 0xCA21D0 VA: 0x180CA3BD0
	private void InitAudioClip() { }

	// RVA: 0xCA3D10 Offset: 0xCA2310 VA: 0x180CA3D10
	private void OnAudioRead(float[] data) { }

	// RVA: 0xCA3FD0 Offset: 0xCA25D0 VA: 0x180CA3FD0
	private void SpawnGrain() { }

	// RVA: 0xCA3AC0 Offset: 0xCA20C0 VA: 0x180CA3AC0
	private void CleanupFinishedGrains() { }

	// RVA: 0xCA4510 Offset: 0xCA2B10 VA: 0x180CA4510
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

	// RVA: 0xCA3AB0 Offset: 0xCA20B0 VA: 0x180CA3AB0
	public bool get_finished() { }

	// RVA: 0xCA39F0 Offset: 0xCA1FF0 VA: 0x180CA39F0
	public void Init(float[] source, int start, int attack, int sustain, int release) { }

	// RVA: 0xCA3950 Offset: 0xCA1F50 VA: 0x180CA3950
	public float GetSample() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

