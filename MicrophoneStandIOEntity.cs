public class MicrophoneStandIOEntity : IOEntity, IAudioConnectionSource // TypeDefIndex: 9449
{	// Fields
	public int PowerCost; // 0x288
	public TriggerBase InstrumentTrigger; // 0x290
	public bool IsStatic; // 0x298
	private List<InstrumentKeyController> nearbyInstruments; // 0x2A0
	private Dictionary<InstrumentKeyController, List<Sound>> activeSounds; // 0x2A8
	private List<ConnectedSpeaker> connectedRepeaters; // 0x2B0
	private TimeSince lastNote; // 0x2B8
	private float fakeInput; // 0x2BC
	private int lastFrameMove; // 0x2C0

	// Properties
	public float VolumeVisualisationMultiplier { get; }

	// Methods

	// RVA: 0x96ACC0 Offset: 0x9692C0 VA: 0x18096ACC0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x96ADA0 Offset: 0x9693A0 VA: 0x18096ADA0
	private void FindNearbyInstruments() { }

	// RVA: 0x96B500 Offset: 0x969B00 VA: 0x18096B500
	public void PlayNote(InstrumentKeyController key, SoundDefinition def, float velocity, NoteBindingCollection collection) { }

	// RVA: 0x96B8D0 Offset: 0x969ED0 VA: 0x18096B8D0
	public void StopNote(InstrumentKeyController key, float fadeOutTime = 0,1) { }

	// RVA: 0x96B790 Offset: 0x969D90 VA: 0x18096B790 Slot: 159
	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	// RVA: 0x96B870 Offset: 0x969E70 VA: 0x18096B870 Slot: 160
	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	// RVA: 0x96B460 Offset: 0x969A60 VA: 0x18096B460 Slot: 161
	public AudioSource GetSource() { }

	// RVA: 0x5368D0 Offset: 0x534ED0 VA: 0x1805368D0 Slot: 162
	public float get_VolumeVisualisationMultiplier() { }

	// RVA: 0x96B360 Offset: 0x969960 VA: 0x18096B360 Slot: 163
	public float GetFakeInput() { }

	// RVA: 0x96B220 Offset: 0x969820 VA: 0x18096B220
	private int GetActiveSoundsCount() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 164
	public IOEntity ToEntity() { }

	// RVA: 0x96BA90 Offset: 0x96A090 VA: 0x18096BA90
	public void .ctor() { }

}

