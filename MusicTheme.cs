public class MusicTheme : ScriptableObject // TypeDefIndex: 9007
{	// Fields
	[HeaderAttribute] // RVA: 0xCA690 Offset: 0xC9A90 VA: 0x1800CA690
	public float tempo; // 0x18
	public int intensityHoldBars; // 0x1C
	public int lengthInBars; // 0x20
	[HeaderAttribute] // RVA: 0xCA740 Offset: 0xC9B40 VA: 0x1800CA740
	public bool canPlayInMenus; // 0x24
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public MusicTheme.ValueRange rain; // 0x28
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public MusicTheme.ValueRange wind; // 0x30
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public MusicTheme.ValueRange snow; // 0x38
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainBiome.Enum biomes; // 0x40
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum topologies; // 0x44
	public AnimationCurve time; // 0x48
	[HeaderAttribute] // RVA: 0xCAAE0 Offset: 0xC9EE0 VA: 0x1800CAAE0
	public List<MusicTheme.PositionedClip> clips; // 0x50
	public List<MusicTheme.Layer> layers; // 0x58
	private Dictionary<int, List<MusicTheme.PositionedClip>> activeClips; // 0x60
	private List<AudioClip> firstAudioClips; // 0x68
	private Dictionary<AudioClip, bool> audioClipDict; // 0x70

	// Properties
	public int layerCount { get; }
	public int samplesPerBar { get; }

	// Methods

	// RVA: 0x7E1010 Offset: 0x7DF610 VA: 0x1807E1010
	public int get_layerCount() { }

	// RVA: 0x7E1050 Offset: 0x7DF650 VA: 0x1807E1050
	public int get_samplesPerBar() { }

	// RVA: 0x7E07D0 Offset: 0x7DEDD0 VA: 0x1807E07D0
	private void OnValidate() { }

	// RVA: 0x7E0680 Offset: 0x7DEC80 VA: 0x1807E0680
	public List<MusicTheme.PositionedClip> GetActiveClipsForBar(int bar) { }

	// RVA: 0x7E0240 Offset: 0x7DE840 VA: 0x1807E0240
	private int ActiveClipCollectionID(int bar) { }

	// RVA: 0x7E0760 Offset: 0x7DED60 VA: 0x1807E0760
	public MusicTheme.Layer LayerById(int id) { }

	// RVA: 0x7E02B0 Offset: 0x7DE8B0 VA: 0x1807E02B0
	public void AddLayer() { }

	// RVA: 0x7E0D00 Offset: 0x7DF300 VA: 0x1807E0D00
	private void UpdateLengthInBars() { }

	// RVA: 0x7E03A0 Offset: 0x7DE9A0 VA: 0x1807E03A0
	public bool CanPlayInEnvironment(int currentBiome, int currentTopology, float currentRain, float currentSnow, float currentWind) { }

	// RVA: 0x7E05D0 Offset: 0x7DEBD0 VA: 0x1807E05D0
	public bool FirstClipsLoaded() { }

	// RVA: 0x7E0570 Offset: 0x7DEB70 VA: 0x1807E0570
	public bool ContainsAudioClip(AudioClip clip) { }

	// RVA: 0x7E0E00 Offset: 0x7DF400 VA: 0x1807E0E00
	public void .ctor() { }

}

public class MusicTheme.Layer // TypeDefIndex: 9008
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x7D3C20 Offset: 0x7D2220 VA: 0x1807D3C20
	public void .ctor() { }

}

public class MusicTheme.PositionedClip // TypeDefIndex: 9009
{	// Fields
	public MusicTheme theme; // 0x10
	public MusicClip musicClip; // 0x18
	public int startingBar; // 0x20
	public int layerId; // 0x24
	public float minIntensity; // 0x28
	public float maxIntensity; // 0x2C
	public bool allowFadeIn; // 0x30
	public bool allowFadeOut; // 0x31
	public float fadeInTime; // 0x34
	public float fadeOutTime; // 0x38
	public float intensityReduction; // 0x3C
	public int jumpBarCount; // 0x40
	public float jumpMinimumIntensity; // 0x44
	public float jumpMaximumIntensity; // 0x48

	// Properties
	public int endingBar { get; }
	public bool isControlClip { get; }

	// Methods

	// RVA: 0x7ED150 Offset: 0x7EB750 VA: 0x1807ED150
	public int get_endingBar() { }

	// RVA: 0x7ECFE0 Offset: 0x7EB5E0 VA: 0x1807ECFE0
	public bool CanPlay(float intensity) { }

	// RVA: 0x7ED1E0 Offset: 0x7EB7E0 VA: 0x1807ED1E0
	public bool get_isControlClip() { }

	// RVA: 0x7ED010 Offset: 0x7EB610 VA: 0x1807ED010
	public void CopySettingsFrom(MusicTheme.PositionedClip otherClip) { }

	// RVA: 0x7ED120 Offset: 0x7EB720 VA: 0x1807ED120
	public void .ctor() { }

}

public class MusicTheme.ValueRange // TypeDefIndex: 9010
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x7EE650 Offset: 0x7ECC50 VA: 0x1807EE650
	public void .ctor(float min, float max) { }

}

