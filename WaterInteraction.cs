public class WaterInteraction : MonoBehaviour // TypeDefIndex: 10616
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Texture2D texture; // 0x18
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Displacement; // 0x20
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Disturbance; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WaterDynamics.Image <Image>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <Position>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 <Scale>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Rotation>k__BackingField; // 0x40
	private Transform cachedTransform; // 0x48

	// Properties
	public Texture2D Texture { get; set; }
	public WaterDynamics.Image Image { get; set; }
	public Vector2 Position { get; set; }
	public Vector2 Scale { get; set; }
	public float Rotation { get; set; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Texture2D get_Texture() { }

	// RVA: 0xC15310 Offset: 0xC13910 VA: 0x180C15310
	public void set_Texture(Texture2D value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public WaterDynamics.Image get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	private void set_Image(WaterDynamics.Image value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC152B0 Offset: 0xC138B0 VA: 0x180C152B0
	public Vector2 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC152F0 Offset: 0xC138F0 VA: 0x180C152F0
	private void set_Position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC152D0 Offset: 0xC138D0 VA: 0x180C152D0
	public Vector2 get_Scale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC15300 Offset: 0xC13900 VA: 0x180C15300
	private void set_Scale(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60
	public float get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E70 Offset: 0x532470 VA: 0x180533E70
	private void set_Rotation(float value) { }

	// RVA: 0xC14CC0 Offset: 0xC132C0 VA: 0x180C14CC0
	protected void OnEnable() { }

	// RVA: 0xC14CB0 Offset: 0xC132B0 VA: 0x180C14CB0
	protected void OnDisable() { }

	// RVA: 0xC14B30 Offset: 0xC13130 VA: 0x180C14B30
	public void CheckRegister() { }

	// RVA: 0xC14FC0 Offset: 0xC135C0 VA: 0x180C14FC0
	private void UpdateImage() { }

	// RVA: 0xC14E90 Offset: 0xC13490 VA: 0x180C14E90
	private void Register() { }

	// RVA: 0xC14F40 Offset: 0xC13540 VA: 0x180C14F40
	private void Unregister() { }

	// RVA: 0xC15030 Offset: 0xC13630 VA: 0x180C15030
	public void UpdateTransform() { }

	// RVA: 0xC15200 Offset: 0xC13800 VA: 0x180C15200
	public void .ctor() { }

}

