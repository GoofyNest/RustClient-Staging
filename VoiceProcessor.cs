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

	// RVA: 0x8018D0 Offset: 0x7FFED0 VA: 0x1808018D0
	private void InitializeSpeaker() { }

	// RVA: 0x8015A0 Offset: 0x7FFBA0 VA: 0x1808015A0
	public void ClientUpdate() { }

	// RVA: 0x801B50 Offset: 0x800150 VA: 0x180801B50
	private void OnDisable() { }

	// RVA: 0x8020E0 Offset: 0x8006E0 VA: 0x1808020E0
	public void StopPlayback() { }

	// RVA: 0x802000 Offset: 0x800600 VA: 0x180802000
	private void StartPlaying() { }

	// RVA: 0x801F70 Offset: 0x800570 VA: 0x180801F70
	private bool ShouldMute() { }

	// RVA: 0x801A80 Offset: 0x800080 VA: 0x180801A80
	private void OnAudioRead(float[] data) { }

	// RVA: 0x801CC0 Offset: 0x8002C0 VA: 0x180801CC0
	public void Receive(byte[] data) { }

	// RVA: 0x802170 Offset: 0x800770 VA: 0x180802170
	private void WriteToClip(byte[] uncompressed, int iSize) { }

	// RVA: 0x801F00 Offset: 0x800500 VA: 0x180801F00
	public void RegisterSubProcessor(VoiceProcessor processor) { }

	// RVA: 0x801860 Offset: 0x7FFE60 VA: 0x180801860
	public void DeregisterSubProcessor(VoiceProcessor processor) { }

	// RVA: 0x801C30 Offset: 0x800230 VA: 0x180801C30
	public void ReceiveDataFromOtherProcessor(byte[] data, int size, VoiceProcessor fromProcessor) { }

	// RVA: 0x8023E0 Offset: 0x8009E0 VA: 0x1808023E0
	private void WriteToClip(float f) { }

	// RVA: 0x802490 Offset: 0x800A90 VA: 0x180802490
	public void .ctor() { }

	// RVA: 0x802430 Offset: 0x800A30 VA: 0x180802430
	private static void .cctor() { }

}

