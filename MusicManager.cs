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

	// RVA: 0x7C1E20 Offset: 0x7C0420 VA: 0x1807C1E20
	public double get_currentThemeTime() { }

	// RVA: 0x7C1E40 Offset: 0x7C0440 VA: 0x1807C1E40
	public int get_themeBar() { }

	// RVA: 0x7BE3B0 Offset: 0x7BC9B0 VA: 0x1807BE3B0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x7C0990 Offset: 0x7BEF90 VA: 0x1807C0990
	public void StartMusic() { }

	// RVA: 0x7BF7F0 Offset: 0x7BDDF0 VA: 0x1807BF7F0
	public MusicTheme GetThemeToPlay(MusicZone currentMusicZone) { }

	// RVA: 0x7C17F0 Offset: 0x7BFDF0 VA: 0x1807C17F0
	private void Update() { }

	// RVA: 0x7C1420 Offset: 0x7BFA20 VA: 0x1807C1420
	private void UpdateCurrentBar() { }

	// RVA: 0x7BE840 Offset: 0x7BCE40 VA: 0x1807BE840
	private void DoBarJump(int offset) { }

	// RVA: 0x7BFD10 Offset: 0x7BE310 VA: 0x1807BFD10
	private void HandleMusicPlayback() { }

	// RVA: 0x7BE9A0 Offset: 0x7BCFA0 VA: 0x1807BE9A0
	private void DoClipFades() { }

	// RVA: 0x7BF3D0 Offset: 0x7BD9D0 VA: 0x1807BF3D0
	private AudioSource GetFreeAudioSource() { }

	// RVA: 0x7BF340 Offset: 0x7BD940 VA: 0x1807BF340
	public void ForceThemeChange(MusicTheme theme) { }

	// RVA: 0x7BED60 Offset: 0x7BD360 VA: 0x1807BED60
	private void DoForcedThemeChange() { }

	// RVA: 0x7C1170 Offset: 0x7BF770 VA: 0x1807C1170
	private void UpdateClips() { }

	// RVA: 0x7C0EC0 Offset: 0x7BF4C0 VA: 0x1807C0EC0
	private void UpdateActiveClips() { }

	// RVA: 0x7BE230 Offset: 0x7BC830 VA: 0x1807BE230
	private void AddActiveClipsForBar(int bar) { }

	// RVA: 0x7C12E0 Offset: 0x7BF8E0 VA: 0x1807C12E0
	private void UpdateControlClips() { }

	// RVA: 0x7C1050 Offset: 0x7BF650 VA: 0x1807C1050
	private void UpdateBarJumpClips() { }

	// RVA: 0x7C1520 Offset: 0x7BFB20 VA: 0x1807C1520
	private void UpdateMusicClips() { }

	// RVA: 0x7C06F0 Offset: 0x7BECF0 VA: 0x1807C06F0
	private void ScheduleClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BEE00 Offset: 0x7BD400 VA: 0x1807BEE00
	private void FadeInClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BF1D0 Offset: 0x7BD7D0 VA: 0x1807BF1D0
	private void FadeOutClip(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BF520 Offset: 0x7BDB20 VA: 0x1807BF520
	private MusicManager.ClipPlaybackData GetPlaybackData(MusicTheme.PositionedClip clip) { }

	// RVA: 0x7BF640 Offset: 0x7BDC40 VA: 0x1807BF640
	private MusicManager.ClipPlaybackData GetPlaybackData(AudioSource source) { }

	// RVA: 0x7C02C0 Offset: 0x7BE8C0 VA: 0x1807C02C0
	private void ResyncClips() { }

	// RVA: 0x7BE4E0 Offset: 0x7BCAE0 VA: 0x1807BE4E0
	private void CheckSyncSource() { }

	// RVA: 0x7C0870 Offset: 0x7BEE70 VA: 0x1807C0870
	public void ShuffleThemes() { }

	// RVA: 0x7BFEB0 Offset: 0x7BE4B0 VA: 0x1807BFEB0
	public void MusicZoneEntered(MusicZone zone) { }

	// RVA: 0x7BFF10 Offset: 0x7BE510 VA: 0x1807BFF10
	public void MusicZoneExited(MusicZone zone) { }

	// RVA: 0x7BE6C0 Offset: 0x7BCCC0 VA: 0x1807BE6C0
	public MusicZone CurrentMusicZone() { }

	// RVA: 0x7BFF70 Offset: 0x7BE570 VA: 0x1807BFF70
	public static void RaiseIntensityTo(float amount, int holdLengthBars = 0) { }

	// RVA: 0x7C0D60 Offset: 0x7BF360 VA: 0x1807C0D60
	public void StopMusic() { }

	// RVA: 0x7C1B40 Offset: 0x7C0140 VA: 0x1807C1B40
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

	// RVA: 0x7D0200 Offset: 0x7CE800 VA: 0x1807D0200
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7CF1C0 Offset: 0x7CD7C0 VA: 0x1807CF1C0
	internal float <ShuffleThemes>b__60_0(MusicTheme x) { }

}

