public class ERSideObjectLog : MonoBehaviour // TypeDefIndex: 7226
{	// Fields
	public List<SideObjectLog> QOQDQOOQDDQOOQ; // 0x18
	public List<int> ints; // 0x20
	public List<QDQDOOQQDQODD> roadPresets; // 0x28
	public List<CrossingCornerClass> crossingCornerPresets; // 0x30
	public List<ERSideWalk> sidewalkPresets; // 0x38
	public List<ERTexture> textureData; // 0x40
	public List<string> presetAssets; // 0x48
	public int logIndex; // 0x50
	public int updateInt; // 0x54

	// Methods

	// RVA: 0xA5B1E0 Offset: 0xA597E0 VA: 0x180A5B1E0
	public void AddRoadPreset(List<SideObject> sceneSideObjects, List<SideObjectLog> projectSideObjects, QDQDOOQQDQODD sourcePreset) { }

	// RVA: 0xA5B2B0 Offset: 0xA598B0 VA: 0x180A5B2B0
	public void UpdateRoadPreset(QDQDOOQQDQODD sourcePreset, int element, List<SideObject> sceneSideObjects, List<SideObjectLog> projectSideObjects, bool copyShapeData) { }

	// RVA: 0xA5CCD0 Offset: 0xA5B2D0 VA: 0x180A5CCD0
	public void UpdateTextureList(int element, Texture2D _texture, float _roadWidth, float _leftOffset, float _rightOffset, float _leftInnerOffset, float _rightInnerOffset) { }

	// RVA: 0xA5CE70 Offset: 0xA5B470 VA: 0x180A5CE70
	public void .ctor() { }

}

