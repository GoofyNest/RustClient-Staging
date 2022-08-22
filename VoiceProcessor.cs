public class VoiceProcessor : EntityComponentBase // TypeDefIndex: 9664
{	// Fields
	public AudioSource mouthSpeaker; // 0x18
	public PlayerVoiceSpeaker playerSpeaker; // 0x20
	public float volumeMultiplier; // 0x28
	private uint optimalRate; // 0x2C
	private uint bufferSize; // 0x30
	private float[] buffer; // 0x38
	private uint dataReceived; // 0x40
	private uint playbackBuffer; // 0x44
	private uint dataPosition; // 0x48
	private bool Initialized; // 0x4C
	public float currentVolume; // 0x50
	private List<VoiceProcessor> subProcessors; // 0x58
	private bool isPlaying; // 0x60
	private bool stopping; // 0x61
	private float[] volumeData; // 0x68
	internal float volumeVelocity; // 0x70
	private static MemoryStream decompressStream; // 0x0

	// Methods

	// RVA: 0x801E60 Offset: 0x800460 VA: 0x180801E60
	private void InitializeSpeaker() { }

	// RVA: 0x801B30 Offset: 0x800130 VA: 0x180801B30
	public void ClientUpdate() { }

	// RVA: 0x8020E0 Offset: 0x8006E0 VA: 0x1808020E0
	private void OnDisable() { }

	// RVA: 0x802670 Offset: 0x800C70 VA: 0x180802670
	public void StopPlayback() { }

	// RVA: 0x802590 Offset: 0x800B90 VA: 0x180802590
	private void StartPlaying() { }

	// RVA: 0x802500 Offset: 0x800B00 VA: 0x180802500
	private bool ShouldMute() { }

	// RVA: 0x802010 Offset: 0x800610 VA: 0x180802010
	private void OnAudioRead(float[] data) { }

	// RVA: 0x802250 Offset: 0x800850 VA: 0x180802250
	public void Receive(byte[] data) { }

	// RVA: 0x802700 Offset: 0x800D00 VA: 0x180802700
	private void WriteToClip(byte[] uncompressed, int iSize) { }

	// RVA: 0x802490 Offset: 0x800A90 VA: 0x180802490
	public void RegisterSubProcessor(VoiceProcessor processor) { }

	// RVA: 0x801DF0 Offset: 0x8003F0 VA: 0x180801DF0
	public void DeregisterSubProcessor(VoiceProcessor processor) { }

	// RVA: 0x8021C0 Offset: 0x8007C0 VA: 0x1808021C0
	public void ReceiveDataFromOtherProcessor(byte[] data, int size, VoiceProcessor fromProcessor) { }

	// RVA: 0x802970 Offset: 0x800F70 VA: 0x180802970
	private void WriteToClip(float f) { }

	// RVA: 0x802A20 Offset: 0x801020 VA: 0x180802A20
	public void .ctor() { }

	// RVA: 0x8029C0 Offset: 0x800FC0 VA: 0x1808029C0
	private static void .cctor() { }

}

