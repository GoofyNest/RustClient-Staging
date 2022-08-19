public class Tile : TileBase // TypeDefIndex: 4566
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Sprite m_Sprite; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color m_Color; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Matrix4x4 m_Transform; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject m_InstancedGameObject; // 0x70
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TileFlags m_Flags; // 0x78
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x231F4D0 Offset: 0x231DAD0 VA: 0x18231F4D0
	public Color get_color() { }

	// RVA: 0x10965B0 Offset: 0x1094BB0 VA: 0x1810965B0
	public void set_color(Color value) { }

	// RVA: 0x231F4F0 Offset: 0x231DAF0 VA: 0x18231F4F0
	public Matrix4x4 get_transform() { }

	// RVA: 0x231F520 Offset: 0x231DB20 VA: 0x18231F520
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x1A785C0 Offset: 0x1A76BC0 VA: 0x181A785C0
	public GameObject get_gameObject() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_gameObject(GameObject value) { }

	// RVA: 0x231F4E0 Offset: 0x231DAE0 VA: 0x18231F4E0
	public TileFlags get_flags() { }

	// RVA: 0xB28CD0 Offset: 0xB272D0 VA: 0x180B28CD0
	public void set_flags(TileFlags value) { }

	// RVA: 0x231F4C0 Offset: 0x231DAC0 VA: 0x18231F4C0
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x144A4D0 Offset: 0x1448AD0 VA: 0x18144A4D0
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x231F3B0 Offset: 0x231D9B0 VA: 0x18231F3B0 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x231F420 Offset: 0x231DA20 VA: 0x18231F420
	public void .ctor() { }

}

public enum Tile.ColliderType // TypeDefIndex: 4567
{	// Fields
	public int value__; // 0x0
	public const Tile.ColliderType None = 0;
	public const Tile.ColliderType Sprite = 1;
	public const Tile.ColliderType Grid = 2;

}

