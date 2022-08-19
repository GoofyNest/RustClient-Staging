public class ArcadeEntityController : BaseMonoBehaviour // TypeDefIndex: 8760
{	// Fields
	public BaseArcadeGame parentGame; // 0x18
	public ArcadeEntity arcadeEntity; // 0x20
	public ArcadeEntity sourceEntity; // 0x28
	private bool authorative; // 0x30

	// Properties
	public Vector3 heading { get; set; }
	public Vector3 positionLocal { get; set; }
	public Vector3 positionWorld { get; set; }

	// Methods

	// RVA: 0x82C3B0 Offset: 0x82A9B0 VA: 0x18082C3B0
	public Vector3 get_heading() { }

	// RVA: 0x82C480 Offset: 0x82AA80 VA: 0x18082C480
	public void set_heading(Vector3 value) { }

	// RVA: 0x82C3E0 Offset: 0x82A9E0 VA: 0x18082C3E0
	public Vector3 get_positionLocal() { }

	// RVA: 0x82C4B0 Offset: 0x82AAB0 VA: 0x18082C4B0
	public void set_positionLocal(Vector3 value) { }

	// RVA: 0x82C430 Offset: 0x82AA30 VA: 0x18082C430
	public Vector3 get_positionWorld() { }

	// RVA: 0x82C500 Offset: 0x82AB00 VA: 0x18082C500
	public void set_positionWorld(Vector3 value) { }

	// RVA: 0x82BE30 Offset: 0x82A430 VA: 0x18082BE30
	public void SetOwnerGame(BaseArcadeGame ownerGame) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void Initialize() { }

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	public bool IsAuthorative() { }

	// RVA: 0x82BCC0 Offset: 0x82A2C0 VA: 0x18082BCC0
	public void SetAuthorative(bool wants) { }

	// RVA: 0x82C2E0 Offset: 0x82A8E0 VA: 0x18082C2E0
	public void SetSprite(Sprite newSprite) { }

	// RVA: 0x82C330 Offset: 0x82A930 VA: 0x18082C330 Slot: 7
	public virtual void Shutdown() { }

	// RVA: 0x82C230 Offset: 0x82A830 VA: 0x18082C230
	public void SetPositionWorld(Vector3 newPos) { }

	// RVA: 0x82BCD0 Offset: 0x82A2D0 VA: 0x18082BCD0
	public void SetHeading(Vector3 heading) { }

	// RVA: 0x82C1C0 Offset: 0x82A7C0 VA: 0x18082C1C0
	public void SetPositionLocal(Vector3 newPos) { }

	// RVA: 0x82BCA0 Offset: 0x82A2A0 VA: 0x18082BCA0
	public void OnDisable() { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

