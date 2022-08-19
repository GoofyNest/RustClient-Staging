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

	// RVA: 0x8017C0 Offset: 0x7FFDC0 VA: 0x1808017C0
	private void InitializeSpeaker() { }

	// RVA: 0x801490 Offset: 0x7FFA90 VA: 0x180801490
	public void ClientUpdate() { }

	// RVA: 0x801A40 Offset: 0x800040 VA: 0x180801A40
	private void OnDisable() { }

	// RVA: 0x801FD0 Offset: 0x8005D0 VA: 0x180801FD0
	public void StopPlayback() { }

	// RVA: 0x801EF0 Offset: 0x8004F0 VA: 0x180801EF0
	private void StartPlaying() { }

	// RVA: 0x801E60 Offset: 0x800460 VA: 0x180801E60
	private bool ShouldMute() { }

	// RVA: 0x801970 Offset: 0x7FFF70 VA: 0x180801970
	private void OnAudioRead(float[] data) { }

	// RVA: 0x801BB0 Offset: 0x8001B0 VA: 0x180801BB0
	public void Receive(byte[] data) { }

	// RVA: 0x802060 Offset: 0x800660 VA: 0x180802060
	private void WriteToClip(byte[] uncompressed, int iSize) { }

	// RVA: 0x801DF0 Offset: 0x8003F0 VA: 0x180801DF0
	public void RegisterSubProcessor(VoiceProcessor processor) { }

	// RVA: 0x801750 Offset: 0x7FFD50 VA: 0x180801750
	public void DeregisterSubProcessor(VoiceProcessor processor) { }

	// RVA: 0x801B20 Offset: 0x800120 VA: 0x180801B20
	public void ReceiveDataFromOtherProcessor(byte[] data, int size, VoiceProcessor fromProcessor) { }

	// RVA: 0x8022D0 Offset: 0x8008D0 VA: 0x1808022D0
	private void WriteToClip(float f) { }

	// RVA: 0x802380 Offset: 0x800980 VA: 0x180802380
	public void .ctor() { }

	// RVA: 0x802320 Offset: 0x800920 VA: 0x180802320
	private static void .cctor() { }

}

