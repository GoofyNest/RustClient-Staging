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

	// RVA: 0x7C2C20 Offset: 0x7C1220 VA: 0x1807C2C20
	public int get_layerCount() { }

	// RVA: 0x7C2C60 Offset: 0x7C1260 VA: 0x1807C2C60
	public int get_samplesPerBar() { }

	// RVA: 0x7C23E0 Offset: 0x7C09E0 VA: 0x1807C23E0
	private void OnValidate() { }

	// RVA: 0x7C2290 Offset: 0x7C0890 VA: 0x1807C2290
	public List<MusicTheme.PositionedClip> GetActiveClipsForBar(int bar) { }

	// RVA: 0x7C1E50 Offset: 0x7C0450 VA: 0x1807C1E50
	private int ActiveClipCollectionID(int bar) { }

	// RVA: 0x7C2370 Offset: 0x7C0970 VA: 0x1807C2370
	public MusicTheme.Layer LayerById(int id) { }

	// RVA: 0x7C1EC0 Offset: 0x7C04C0 VA: 0x1807C1EC0
	public void AddLayer() { }

	// RVA: 0x7C2910 Offset: 0x7C0F10 VA: 0x1807C2910
	private void UpdateLengthInBars() { }

	// RVA: 0x7C1FB0 Offset: 0x7C05B0 VA: 0x1807C1FB0
	public bool CanPlayInEnvironment(int currentBiome, int currentTopology, float currentRain, float currentSnow, float currentWind) { }

	// RVA: 0x7C21E0 Offset: 0x7C07E0 VA: 0x1807C21E0
	public bool FirstClipsLoaded() { }

	// RVA: 0x7C2180 Offset: 0x7C0780 VA: 0x1807C2180
	public bool ContainsAudioClip(AudioClip clip) { }

	// RVA: 0x7C2A10 Offset: 0x7C1010 VA: 0x1807C2A10
	public void .ctor() { }

}

public class MusicTheme.Layer // TypeDefIndex: 9008
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x7B5830 Offset: 0x7B3E30 VA: 0x1807B5830
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

	// RVA: 0x7CED60 Offset: 0x7CD360 VA: 0x1807CED60
	public int get_endingBar() { }

	// RVA: 0x7CEBF0 Offset: 0x7CD1F0 VA: 0x1807CEBF0
	public bool CanPlay(float intensity) { }

	// RVA: 0x7CEDF0 Offset: 0x7CD3F0 VA: 0x1807CEDF0
	public bool get_isControlClip() { }

	// RVA: 0x7CEC20 Offset: 0x7CD220 VA: 0x1807CEC20
	public void CopySettingsFrom(MusicTheme.PositionedClip otherClip) { }

	// RVA: 0x7CED30 Offset: 0x7CD330 VA: 0x1807CED30
	public void .ctor() { }

}

public class MusicTheme.ValueRange // TypeDefIndex: 9010
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x7D0260 Offset: 0x7CE860 VA: 0x1807D0260
	public void .ctor(float min, float max) { }

}

