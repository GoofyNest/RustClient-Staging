public class MusicTheme : ScriptableObject // TypeDefIndex: 9007
{	// Fields
	[HeaderAttribute] // RVA: 0xCA650 Offset: 0xC9A50 VA: 0x1800CA650
	public float tempo; // 0x18
	public int intensityHoldBars; // 0x1C
	public int lengthInBars; // 0x20
	[HeaderAttribute] // RVA: 0xCA6B0 Offset: 0xC9AB0 VA: 0x1800CA6B0
	public bool canPlayInMenus; // 0x24
	[HorizontalAttribute] // RVA: 0xC8F30 Offset: 0xC8330 VA: 0x1800C8F30
	public MusicTheme.ValueRange rain; // 0x28
	[HorizontalAttribute] // RVA: 0xC8F30 Offset: 0xC8330 VA: 0x1800C8F30
	public MusicTheme.ValueRange wind; // 0x30
	[HorizontalAttribute] // RVA: 0xC8F30 Offset: 0xC8330 VA: 0x1800C8F30
	public MusicTheme.ValueRange snow; // 0x38
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public TerrainBiome.Enum biomes; // 0x40
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public TerrainTopology.Enum topologies; // 0x44
	public AnimationCurve time; // 0x48
	[HeaderAttribute] // RVA: 0xCAA50 Offset: 0xC9E50 VA: 0x1800CAA50
	public List<MusicTheme.PositionedClip> clips; // 0x50
	public List<MusicTheme.Layer> layers; // 0x58
	private Dictionary<int, List<MusicTheme.PositionedClip>> activeClips; // 0x60
	private List<AudioClip> firstAudioClips; // 0x68
	private Dictionary<AudioClip, bool> audioClipDict; // 0x70

	// Properties
	public int layerCount { get; }
	public int samplesPerBar { get; }

	// Methods

	// RVA: 0x7C2B10 Offset: 0x7C1110 VA: 0x1807C2B10
	public int get_layerCount() { }

	// RVA: 0x7C2B50 Offset: 0x7C1150 VA: 0x1807C2B50
	public int get_samplesPerBar() { }

	// RVA: 0x7C22D0 Offset: 0x7C08D0 VA: 0x1807C22D0
	private void OnValidate() { }

	// RVA: 0x7C2180 Offset: 0x7C0780 VA: 0x1807C2180
	public List<MusicTheme.PositionedClip> GetActiveClipsForBar(int bar) { }

	// RVA: 0x7C1D40 Offset: 0x7C0340 VA: 0x1807C1D40
	private int ActiveClipCollectionID(int bar) { }

	// RVA: 0x7C2260 Offset: 0x7C0860 VA: 0x1807C2260
	public MusicTheme.Layer LayerById(int id) { }

	// RVA: 0x7C1DB0 Offset: 0x7C03B0 VA: 0x1807C1DB0
	public void AddLayer() { }

	// RVA: 0x7C2800 Offset: 0x7C0E00 VA: 0x1807C2800
	private void UpdateLengthInBars() { }

	// RVA: 0x7C1EA0 Offset: 0x7C04A0 VA: 0x1807C1EA0
	public bool CanPlayInEnvironment(int currentBiome, int currentTopology, float currentRain, float currentSnow, float currentWind) { }

	// RVA: 0x7C20D0 Offset: 0x7C06D0 VA: 0x1807C20D0
	public bool FirstClipsLoaded() { }

	// RVA: 0x7C2070 Offset: 0x7C0670 VA: 0x1807C2070
	public bool ContainsAudioClip(AudioClip clip) { }

	// RVA: 0x7C2900 Offset: 0x7C0F00 VA: 0x1807C2900
	public void .ctor() { }

}

public class MusicTheme.Layer // TypeDefIndex: 9008
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x7B5720 Offset: 0x7B3D20 VA: 0x1807B5720
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

	// RVA: 0x7CEC50 Offset: 0x7CD250 VA: 0x1807CEC50
	public int get_endingBar() { }

	// RVA: 0x7CEAE0 Offset: 0x7CD0E0 VA: 0x1807CEAE0
	public bool CanPlay(float intensity) { }

	// RVA: 0x7CECE0 Offset: 0x7CD2E0 VA: 0x1807CECE0
	public bool get_isControlClip() { }

	// RVA: 0x7CEB10 Offset: 0x7CD110 VA: 0x1807CEB10
	public void CopySettingsFrom(MusicTheme.PositionedClip otherClip) { }

	// RVA: 0x7CEC20 Offset: 0x7CD220 VA: 0x1807CEC20
	public void .ctor() { }

}

public class MusicTheme.ValueRange // TypeDefIndex: 9010
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x7D0150 Offset: 0x7CE750 VA: 0x1807D0150
	public void .ctor(float min, float max) { }

}

