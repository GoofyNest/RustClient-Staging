public class MusicClipLoader // TypeDefIndex: 9002
{	// Fields
	public List<MusicClipLoader.LoadedAudioClip> loadedClips; // 0x10
	public Dictionary<AudioClip, MusicClipLoader.LoadedAudioClip> loadedClipDict; // 0x18
	public List<AudioClip> clipsToLoad; // 0x20
	public List<AudioClip> clipsToUnload; // 0x28

	// Methods

	// RVA: 0x7BDD20 Offset: 0x7BC320 VA: 0x1807BDD20
	public void Update() { }

	// RVA: 0x7BD990 Offset: 0x7BBF90 VA: 0x1807BD990
	public void Refresh() { }

	// RVA: 0x7BD910 Offset: 0x7BBF10 VA: 0x1807BD910
	private MusicClipLoader.LoadedAudioClip FindLoadedClip(AudioClip clip) { }

	// RVA: 0x7BDE70 Offset: 0x7BC470 VA: 0x1807BDE70
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

