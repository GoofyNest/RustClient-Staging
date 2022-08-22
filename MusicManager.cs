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

	// RVA: 0x7C1D10 Offset: 0x7C0310 VA: 0x1807C1D10
	public double get_currentThemeTime() { }

	// RVA: 0x7C1D30 Offset: 0x7C0330 VA: 0x1807C1D30
	public int get_themeBar() { }

	// RVA: 0x7BE2A0 Offset: 0x7BC8A0 VA: 0x1807BE2A0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x7C0880 Offset: 0x7BEE80 VA: 0x1807C0880
	public void StartMusic() { }

	// RVA: 0x7BF6E0 Offset: 0x7BDCE0 VA: 0x1807BF6E0
	public MusicTheme GetThemeToPlay(MusicZone currentMusicZone) { }

	// RVA: 0x7C16E0 Offset: 0x7BFCE0 VA: 0x1807C16E0
	private void Update() { }

	// RVA: 0x7C1310 Offset: 0x7BF910 VA: 0x1807C1310
	private void UpdateCurrentBar() { }

	// RVA: 0x7BE730 Offset: 0x7BCD30 VA: 0x1807BE730
	private void DoBarJump(int offset) { }

	// RVA: 0x7BFC00 Offset: 0x7BE200 VA: 0x1807BFC00
	private void HandleMusicPlayback() { }

	// RVA: 0x7BE890 Offset: 0x7BCE90 VA: 0x1807BE890
	private void DoClipFades() { }

	// RVA: 0x7BF2C0 Offset: 0x7BD8C0 VA: 0x1807BF2C0
	private AudioSource GetFreeAudioSource() { }

	// RVA: 0x7BF230 Offset: 0x7BD830 VA: 0x1807BF230
	public void ForceThemeChange(MusicTheme theme) { }

	// RVA: 0x7BEC50 Offset: 0x7BD250 VA: 0x1807BEC50
	private void DoForcedThemeChange() { }

	// RVA: 0x7C1060 Offset: 0x7BF660 VA: 0x1807C1060
	private void UpdateClips() { }

	// RVA: 0x7C0DB0 Offset: 0x7BF3B0 VA: 0x1807C0DB0
	private void UpdateActiveClips() { }

	// RVA: 0x7BE120 Offset: 0x7BC720 VA: 0x1807BE120
	private void AddActiveClipsForBar(int bar) { }

	// RVA: 0x7C11D0 Offset: 0x7BF7D0 VA: 0x1807C11D0
	private void UpdateControlClips() { }

	// RVA: 0x7C0F40 Offset: 0x7BF540 VA: 0x1807C0F40
	private void UpdateBarJumpClips() { }

	// RVA: 0x7C1410 Offset: 0x7BFA10 VA: 0x1807C1410
	private void UpdateMusicClips() { }

	// RVA: 0x7C05E0 Offset: 0x7BEBE0 VA: 0x1807C05E0
	private void ScheduleClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BECF0 Offset: 0x7BD2F0 VA: 0x1807BECF0
	private void FadeInClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BF0C0 Offset: 0x7BD6C0 VA: 0x1807BF0C0
	private void FadeOutClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BF410 Offset: 0x7BDA10 VA: 0x1807BF410
	private MusicManager.ClipPlaybackData GetPlaybackData(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BF530 Offset: 0x7BDB30 VA: 0x1807BF530
	private MusicManager.ClipPlaybackData GetPlaybackData(AudioSource source) { }

	// RVA: 0x7C01B0 Offset: 0x7BE7B0 VA: 0x1807C01B0
	private void ResyncClips() { }

	// RVA: 0x7BE3D0 Offset: 0x7BC9D0 VA: 0x1807BE3D0
	private void CheckSyncSource() { }

	// RVA: 0x7C0760 Offset: 0x7BED60 VA: 0x1807C0760
	public void ShuffleThemes() { }

	// RVA: 0x7BFDA0 Offset: 0x7BE3A0 VA: 0x1807BFDA0
	public void MusicZoneEntered(MusicZone zone) { }

	// RVA: 0x7BFE00 Offset: 0x7BE400 VA: 0x1807BFE00
	public void MusicZoneExited(MusicZone zone) { }

	// RVA: 0x7BE5B0 Offset: 0x7BCBB0 VA: 0x1807BE5B0
	public MusicZone CurrentMusicZone() { }

	// RVA: 0x7BFE60 Offset: 0x7BE460 VA: 0x1807BFE60
	public static void RaiseIntensityTo(float amount, int holdLengthBars = 0) { }

	// RVA: 0x7C0C50 Offset: 0x7BF250 VA: 0x1807C0C50
	public void StopMusic() { }

	// RVA: 0x7C1A30 Offset: 0x7C0030 VA: 0x1807C1A30
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

	// RVA: 0x7D00F0 Offset: 0x7CE6F0 VA: 0x1807D00F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7CF0B0 Offset: 0x7CD6B0 VA: 0x1807CF0B0
	internal float <ShuffleThemes>b__60_0(MusicTheme x) { }

}

