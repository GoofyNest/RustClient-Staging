public class WaterInteraction : MonoBehaviour // TypeDefIndex: 10620
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Texture2D texture; // 0x18
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float Displacement; // 0x20
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float Disturbance; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private WaterDynamics.Image <Image>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Vector2 <Position>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Vector2 <Scale>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <Rotation>k__BackingField; // 0x40
	private Transform cachedTransform; // 0x48

	public Texture2D Texture { get; set; }
	public WaterDynamics.Image Image { get; set; }
	public Vector2 Position { get; set; }
	public Vector2 Scale { get; set; }
	public float Rotation { get; set; }


	public Texture2D get_Texture() { }

	public void set_Texture(Texture2D value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public WaterDynamics.Image get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Image(WaterDynamics.Image value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Vector2 get_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Vector2 get_Scale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Scale(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Rotation(float value) { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void CheckRegister() { }

	private void UpdateImage() { }

	private void Register() { }

	private void Unregister() { }

	public void UpdateTransform() { }

	public void .ctor() { }

}

