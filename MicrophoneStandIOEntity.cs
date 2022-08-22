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

	// RVA: 0x96ADD0 Offset: 0x9693D0 VA: 0x18096ADD0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x96AEB0 Offset: 0x9694B0 VA: 0x18096AEB0
	private void FindNearbyInstruments() { }

	// RVA: 0x96B610 Offset: 0x969C10 VA: 0x18096B610
	public void PlayNote(InstrumentKeyController key, SoundDefinition def, float velocity, NoteBindingCollection collection) { }

	// RVA: 0x96B9E0 Offset: 0x969FE0 VA: 0x18096B9E0
	public void StopNote(InstrumentKeyController key, float fadeOutTime = 0,1) { }

	// RVA: 0x96B8A0 Offset: 0x969EA0 VA: 0x18096B8A0 Slot: 159
	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	// RVA: 0x96B980 Offset: 0x969F80 VA: 0x18096B980 Slot: 160
	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	// RVA: 0x96B570 Offset: 0x969B70 VA: 0x18096B570 Slot: 161
	public AudioSource GetSource() { }

	// RVA: 0x5368D0 Offset: 0x534ED0 VA: 0x1805368D0 Slot: 162
	public float get_VolumeVisualisationMultiplier() { }

	// RVA: 0x96B470 Offset: 0x969A70 VA: 0x18096B470 Slot: 163
	public float GetFakeInput() { }

	// RVA: 0x96B330 Offset: 0x969930 VA: 0x18096B330
	private int GetActiveSoundsCount() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 164
	public IOEntity ToEntity() { }

	// RVA: 0x96BBA0 Offset: 0x96A1A0 VA: 0x18096BBA0
	public void .ctor() { }

}

