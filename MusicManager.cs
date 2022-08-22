public class MusicManager : SingletonComponent<MusicManager>, IClientComponent // TypeDefIndex: 9004
{	// Fields
	public AudioMixerGroup mixerGroup; // 0x18
	public List<MusicTheme> themes; // 0x20
	public MusicTheme currentTheme; // 0x28
	public List<AudioSource> sources; // 0x30
	public double nextMusic; // 0x38
	public double nextMusicFromIntensityRaise; // 0x40
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float intensity; // 0x48
	public Dictionary<MusicTheme.PositionedClip, MusicManager.ClipPlaybackData> clipPlaybackData; // 0x50
	public int holdIntensityUntilBar; // 0x58
	public bool musicPlaying; // 0x5C
	public bool loadingFirstClips; // 0x5D
	public MusicTheme nextTheme; // 0x60
	public double lastClipUpdate; // 0x68
	public float clipUpdateInterval; // 0x70
	public double themeStartTime; // 0x78
	public int lastActiveClipRefresh; // 0x80
	public int activeClipRefreshInterval; // 0x84
	public bool forceThemeChange; // 0x88
	public float randomIntensityJumpChance; // 0x8C
	public int clipScheduleBarsEarly; // 0x90
	public List<MusicTheme.PositionedClip> activeClips; // 0x98
	public List<MusicTheme.PositionedClip> activeMusicClips; // 0xA0
	public List<MusicTheme.PositionedClip> activeControlClips; // 0xA8
	public List<MusicZone> currentMusicZones; // 0xB0
	public int currentBar; // 0xB8
	public int barOffset; // 0xBC
	private AudioSource syncSource; // 0xC0
	private bool needsResync; // 0xC8
	private int fadingClipCount; // 0xCC
	private MusicClipLoader clipLoader; // 0xD0
	private List<MusicTheme> validThemes; // 0xD8

	// Properties
	public double currentThemeTime { get; }
	public int themeBar { get; }

	// Methods

	// RVA: 0x7E0210 Offset: 0x7DE810 VA: 0x1807E0210
	public double get_currentThemeTime() { }

	// RVA: 0x7E0230 Offset: 0x7DE830 VA: 0x1807E0230
	public int get_themeBar() { }

	// RVA: 0x7DC7A0 Offset: 0x7DADA0 VA: 0x1807DC7A0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x7DED80 Offset: 0x7DD380 VA: 0x1807DED80
	public void StartMusic() { }

	// RVA: 0x7DDBE0 Offset: 0x7DC1E0 VA: 0x1807DDBE0
	public MusicTheme GetThemeToPlay(MusicZone currentMusicZone) { }

	// RVA: 0x7DFBE0 Offset: 0x7DE1E0 VA: 0x1807DFBE0
	private void Update() { }

	// RVA: 0x7DF810 Offset: 0x7DDE10 VA: 0x1807DF810
	private void UpdateCurrentBar() { }

	// RVA: 0x7DCC30 Offset: 0x7DB230 VA: 0x1807DCC30
	private void DoBarJump(int offset) { }

	// RVA: 0x7DE100 Offset: 0x7DC700 VA: 0x1807DE100
	private void HandleMusicPlayback() { }

	// RVA: 0x7DCD90 Offset: 0x7DB390 VA: 0x1807DCD90
	private void DoClipFades() { }

	// RVA: 0x7DD7C0 Offset: 0x7DBDC0 VA: 0x1807DD7C0
	private AudioSource GetFreeAudioSource() { }

	// RVA: 0x7DD730 Offset: 0x7DBD30 VA: 0x1807DD730
	public void ForceThemeChange(MusicTheme theme) { }

	// RVA: 0x7DD150 Offset: 0x7DB750 VA: 0x1807DD150
	private void DoForcedThemeChange() { }

	// RVA: 0x7DF560 Offset: 0x7DDB60 VA: 0x1807DF560
	private void UpdateClips() { }

	// RVA: 0x7DF2B0 Offset: 0x7DD8B0 VA: 0x1807DF2B0
	private void UpdateActiveClips() { }

	// RVA: 0x7DC620 Offset: 0x7DAC20 VA: 0x1807DC620
	private void AddActiveClipsForBar(int bar) { }

	// RVA: 0x7DF6D0 Offset: 0x7DDCD0 VA: 0x1807DF6D0
	private void UpdateControlClips() { }

	// RVA: 0x7DF440 Offset: 0x7DDA40 VA: 0x1807DF440
	private void UpdateBarJumpClips() { }

	// RVA: 0x7DF910 Offset: 0x7DDF10 VA: 0x1807DF910
	private void UpdateMusicClips() { }

	// RVA: 0x7DEAE0 Offset: 0x7DD0E0 VA: 0x1807DEAE0
	private void ScheduleClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7DD1F0 Offset: 0x7DB7F0 VA: 0x1807DD1F0
	private void FadeInClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7DD5C0 Offset: 0x7DBBC0 VA: 0x1807DD5C0
	private void FadeOutClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7DD910 Offset: 0x7DBF10 VA: 0x1807DD910
	private MusicManager.ClipPlaybackData GetPlaybackData(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7DDA30 Offset: 0x7DC030 VA: 0x1807DDA30
	private MusicManager.ClipPlaybackData GetPlaybackData(AudioSource source) { }

	// RVA: 0x7DE6B0 Offset: 0x7DCCB0 VA: 0x1807DE6B0
	private void ResyncClips() { }

	// RVA: 0x7DC8D0 Offset: 0x7DAED0 VA: 0x1807DC8D0
	private void CheckSyncSource() { }

	// RVA: 0x7DEC60 Offset: 0x7DD260 VA: 0x1807DEC60
	public void ShuffleThemes() { }

	// RVA: 0x7DE2A0 Offset: 0x7DC8A0 VA: 0x1807DE2A0
	public void MusicZoneEntered(MusicZone zone) { }

	// RVA: 0x7DE300 Offset: 0x7DC900 VA: 0x1807DE300
	public void MusicZoneExited(MusicZone zone) { }

	// RVA: 0x7DCAB0 Offset: 0x7DB0B0 VA: 0x1807DCAB0
	public MusicZone CurrentMusicZone() { }

	// RVA: 0x7DE360 Offset: 0x7DC960 VA: 0x1807DE360
	public static void RaiseIntensityTo(float amount, int holdLengthBars = 0) { }

	// RVA: 0x7DF150 Offset: 0x7DD750 VA: 0x1807DF150
	public void StopMusic() { }

	// RVA: 0x7DFF30 Offset: 0x7DE530 VA: 0x1807DFF30
	public void .ctor() { }

}

public class MusicManager.ClipPlaybackData // TypeDefIndex: 9005
{	// Fields
	public AudioSource source; // 0x10
	public MusicTheme.PositionedClip positionedClip; // 0x18
	public bool isActive; // 0x20
	public bool fadingIn; // 0x21
	public bool fadingOut; // 0x22
	public double fadeStarted; // 0x28
	public bool needsSync; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class MusicManager.<>c // TypeDefIndex: 9006
{	// Fields
	public static readonly MusicManager.<>c <>9; // 0x0
	public static Func<MusicTheme, float> <>9__60_0; // 0x8

	// Methods

	// RVA: 0x7EE5F0 Offset: 0x7ECBF0 VA: 0x1807EE5F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7ED5B0 Offset: 0x7EBBB0 VA: 0x1807ED5B0
	internal float <ShuffleThemes>b__60_0(MusicTheme x) { }

}

