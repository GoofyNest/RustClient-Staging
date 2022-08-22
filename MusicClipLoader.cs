public class MusicClipLoader // TypeDefIndex: 9002
{	// Fields
	public List<MusicClipLoader.LoadedAudioClip> loadedClips; // 0x10
	public Dictionary<AudioClip, MusicClipLoader.LoadedAudioClip> loadedClipDict; // 0x18
	public List<AudioClip> clipsToLoad; // 0x20
	public List<AudioClip> clipsToUnload; // 0x28

	// Methods

	// RVA: 0x7DC220 Offset: 0x7DA820 VA: 0x1807DC220
	public void Update() { }

	// RVA: 0x7DBE90 Offset: 0x7DA490 VA: 0x1807DBE90
	public void Refresh() { }

	// RVA: 0x7DBE10 Offset: 0x7DA410 VA: 0x1807DBE10
	private MusicClipLoader.LoadedAudioClip FindLoadedClip(AudioClip clip) { }

	// RVA: 0x7DC370 Offset: 0x7DA970 VA: 0x1807DC370
	public void .ctor() { }

}

public class MusicClipLoader.LoadedAudioClip // TypeDefIndex: 9003
{	// Fields
	public AudioClip clip; // 0x10
	public float unloadTime; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

