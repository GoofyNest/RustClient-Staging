public class MusicClipLoader // TypeDefIndex: 9002
{	// Fields
	public List<MusicClipLoader.LoadedAudioClip> loadedClips; // 0x10
	public Dictionary<AudioClip, MusicClipLoader.LoadedAudioClip> loadedClipDict; // 0x18
	public List<AudioClip> clipsToLoad; // 0x20
	public List<AudioClip> clipsToUnload; // 0x28

	// Methods

	// RVA: 0x7BDE30 Offset: 0x7BC430 VA: 0x1807BDE30
	public void Update() { }

	// RVA: 0x7BDAA0 Offset: 0x7BC0A0 VA: 0x1807BDAA0
	public void Refresh() { }

	// RVA: 0x7BDA20 Offset: 0x7BC020 VA: 0x1807BDA20
	private MusicClipLoader.LoadedAudioClip FindLoadedClip(AudioClip clip) { }

	// RVA: 0x7BDF80 Offset: 0x7BC580 VA: 0x1807BDF80
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

