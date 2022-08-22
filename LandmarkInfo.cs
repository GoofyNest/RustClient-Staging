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

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 4
	public virtual MapLayer get_MapLayer() { }

	// RVA: 0x6868B0 Offset: 0x684EB0 VA: 0x1806868B0 Slot: 5
	protected virtual void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

