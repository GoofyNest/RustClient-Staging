public class Tile : TileBase // TypeDefIndex: 4566
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite m_Sprite; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_Color; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Matrix4x4 m_Transform; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject m_InstancedGameObject; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TileFlags m_Flags; // 0x78
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Tile.ColliderType m_ColliderType; // 0x7C

	// Properties
	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public Tile.ColliderType colliderType { get; set; }

	// Methods

	// RVA: 0x181D9E0 Offset: 0x181BFE0 VA: 0x18181D9E0
	public Sprite get_sprite() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_sprite(Sprite value) { }

	// RVA: 0x231F310 Offset: 0x231D910 VA: 0x18231F310
	public Color get_color() { }

	// RVA: 0x10965B0 Offset: 0x1094BB0 VA: 0x1810965B0
	public void set_color(Color value) { }

	// RVA: 0x231F330 Offset: 0x231D930 VA: 0x18231F330
	public Matrix4x4 get_transform() { }

	// RVA: 0x231F360 Offset: 0x231D960 VA: 0x18231F360
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x1A78580 Offset: 0x1A76B80 VA: 0x181A78580
	public GameObject get_gameObject() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_gameObject(GameObject value) { }

	// RVA: 0x231F320 Offset: 0x231D920 VA: 0x18231F320
	public TileFlags get_flags() { }

	// RVA: 0xB28CD0 Offset: 0xB272D0 VA: 0x180B28CD0
	public void set_flags(TileFlags value) { }

	// RVA: 0x231F300 Offset: 0x231D900 VA: 0x18231F300
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x144A4D0 Offset: 0x1448AD0 VA: 0x18144A4D0
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x231F1F0 Offset: 0x231D7F0 VA: 0x18231F1F0 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x231F260 Offset: 0x231D860 VA: 0x18231F260
	public void .ctor() { }

}

public enum Tile.ColliderType // TypeDefIndex: 4567
{	// Fields
	public int value__; // 0x0
	public const Tile.ColliderType None = 0;
	public const Tile.ColliderType Sprite = 1;
	public const Tile.ColliderType Grid = 2;

}

