public class Tile : TileBase // TypeDefIndex: 4566
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public Tile.ColliderType colliderType { get; set; }


	public Sprite get_sprite() { }

	public void set_sprite(Sprite value) { }

	public Color get_color() { }

	public void set_color(Color value) { }

	public Matrix4x4 get_transform() { }

	public void set_transform(Matrix4x4 value) { }

	public GameObject get_gameObject() { }

	public void set_gameObject(GameObject value) { }

	public TileFlags get_flags() { }

	public void set_flags(TileFlags value) { }

	public Tile.ColliderType get_colliderType() { }

	public void set_colliderType(Tile.ColliderType value) { }

	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	public void .ctor() { }

}

public enum Tile.ColliderType // TypeDefIndex: 4567
{	public int value__; // 0x0
	public const Tile.ColliderType None = 0;
	public const Tile.ColliderType Sprite = 1;
	public const Tile.ColliderType Grid = 2;

}

