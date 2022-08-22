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

	// RVA: 0x96B2D0 Offset: 0x9698D0 VA: 0x18096B2D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x96B3B0 Offset: 0x9699B0 VA: 0x18096B3B0
	private void FindNearbyInstruments() { }

	// RVA: 0x96BB10 Offset: 0x96A110 VA: 0x18096BB10
	public void PlayNote(InstrumentKeyController key, SoundDefinition def, float velocity, NoteBindingCollection collection) { }

	// RVA: 0x96BEE0 Offset: 0x96A4E0 VA: 0x18096BEE0
	public void StopNote(InstrumentKeyController key, float fadeOutTime = 0,1) { }

	// RVA: 0x96BDA0 Offset: 0x96A3A0 VA: 0x18096BDA0 Slot: 159
	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	// RVA: 0x96BE80 Offset: 0x96A480 VA: 0x18096BE80 Slot: 160
	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	// RVA: 0x96BA70 Offset: 0x96A070 VA: 0x18096BA70 Slot: 161
	public AudioSource GetSource() { }

	// RVA: 0x536860 Offset: 0x534E60 VA: 0x180536860 Slot: 162
	public float get_VolumeVisualisationMultiplier() { }

	// RVA: 0x96B970 Offset: 0x969F70 VA: 0x18096B970 Slot: 163
	public float GetFakeInput() { }

	// RVA: 0x96B830 Offset: 0x969E30 VA: 0x18096B830
	private int GetActiveSoundsCount() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 164
	public IOEntity ToEntity() { }

	// RVA: 0x96C0A0 Offset: 0x96A6A0 VA: 0x18096C0A0
	public void .ctor() { }

}

