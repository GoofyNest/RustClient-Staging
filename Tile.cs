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

	// RVA: 0x181DCA0 Offset: 0x181C2A0 VA: 0x18181DCA0
	public Sprite get_sprite() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_sprite(Sprite value) { }

	// RVA: 0x231F5D0 Offset: 0x231DBD0 VA: 0x18231F5D0
	public Color get_color() { }

	// RVA: 0x1096870 Offset: 0x1094E70 VA: 0x181096870
	public void set_color(Color value) { }

	// RVA: 0x231F5F0 Offset: 0x231DBF0 VA: 0x18231F5F0
	public Matrix4x4 get_transform() { }

	// RVA: 0x231F620 Offset: 0x231DC20 VA: 0x18231F620
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x1A78840 Offset: 0x1A76E40 VA: 0x181A78840
	public GameObject get_gameObject() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_gameObject(GameObject value) { }

	// RVA: 0x231F5E0 Offset: 0x231DBE0 VA: 0x18231F5E0
	public TileFlags get_flags() { }

	// RVA: 0xB28F90 Offset: 0xB27590 VA: 0x180B28F90
	public void set_flags(TileFlags value) { }

	// RVA: 0x231F5C0 Offset: 0x231DBC0 VA: 0x18231F5C0
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x144A790 Offset: 0x1448D90 VA: 0x18144A790
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x231F4B0 Offset: 0x231DAB0 VA: 0x18231F4B0 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x231F520 Offset: 0x231DB20 VA: 0x18231F520
	public void .ctor() { }

}

public enum Tile.ColliderType // TypeDefIndex: 4567
{	// Fields
	public int value__; // 0x0
	public const Tile.ColliderType None = 0;
	public const Tile.ColliderType Sprite = 1;
	public const Tile.ColliderType Grid = 2;

}

