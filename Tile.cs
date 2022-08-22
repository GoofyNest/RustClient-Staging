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

	// RVA: 0x180B0E0 Offset: 0x18096E0 VA: 0x18180B0E0
	public Sprite get_sprite() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_sprite(Sprite value) { }

	// RVA: 0x231FDF0 Offset: 0x231E3F0 VA: 0x18231FDF0
	public Color get_color() { }

	// RVA: 0x10972E0 Offset: 0x10958E0 VA: 0x1810972E0
	public void set_color(Color value) { }

	// RVA: 0x231FE10 Offset: 0x231E410 VA: 0x18231FE10
	public Matrix4x4 get_transform() { }

	// RVA: 0x231FE40 Offset: 0x231E440 VA: 0x18231FE40
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x1A64D70 Offset: 0x1A63370 VA: 0x181A64D70
	public GameObject get_gameObject() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_gameObject(GameObject value) { }

	// RVA: 0x231FE00 Offset: 0x231E400 VA: 0x18231FE00
	public TileFlags get_flags() { }

	// RVA: 0xB29460 Offset: 0xB27A60 VA: 0x180B29460
	public void set_flags(TileFlags value) { }

	// RVA: 0x231FDE0 Offset: 0x231E3E0 VA: 0x18231FDE0
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x1449860 Offset: 0x1447E60 VA: 0x181449860
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x231FCD0 Offset: 0x231E2D0 VA: 0x18231FCD0 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x231FD40 Offset: 0x231E340 VA: 0x18231FD40
	public void .ctor() { }

}

public enum Tile.ColliderType // TypeDefIndex: 4567
{	// Fields
	public int value__; // 0x0
	public const Tile.ColliderType None = 0;
	public const Tile.ColliderType Sprite = 1;
	public const Tile.ColliderType Grid = 2;

}

