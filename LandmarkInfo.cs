public class LandmarkInfo : MonoBehaviour // TypeDefIndex: 9961
{	// Fields
	[HeaderAttribute] // RVA: 0xAA840 Offset: 0xA9C40 VA: 0x1800AA840
	public bool shouldDisplayOnMap; // 0x18
	public bool isLayerSpecific; // 0x19
	public Translate.Phrase displayPhrase; // 0x20
	public Sprite mapIcon; // 0x28

	// Properties
	public virtual MapLayer MapLayer { get; }

	// Methods

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 4
	public virtual MapLayer get_MapLayer() { }

	// RVA: 0x686920 Offset: 0x684F20 VA: 0x180686920 Slot: 5
	protected virtual void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

