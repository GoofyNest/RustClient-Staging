public class LandmarkInfo : MonoBehaviour // TypeDefIndex: 9961
{	[HeaderAttribute] // RVA: 0xAA3D0 Offset: 0xA97D0 VA: 0x1800AA3D0
	public bool shouldDisplayOnMap; // 0x18
	public bool isLayerSpecific; // 0x19
	public Translate.Phrase displayPhrase; // 0x20
	public Sprite mapIcon; // 0x28

	public virtual MapLayer MapLayer { get; }


	public virtual MapLayer get_MapLayer() { }

	protected virtual void Awake() { }

	public void .ctor() { }

}

