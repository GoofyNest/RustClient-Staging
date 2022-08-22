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

	// RVA: 0x82C4C0 Offset: 0x82AAC0 VA: 0x18082C4C0
	public Vector3 get_heading() { }

	// RVA: 0x82C590 Offset: 0x82AB90 VA: 0x18082C590
	public void set_heading(Vector3 value) { }

	// RVA: 0x82C4F0 Offset: 0x82AAF0 VA: 0x18082C4F0
	public Vector3 get_positionLocal() { }

	// RVA: 0x82C5C0 Offset: 0x82ABC0 VA: 0x18082C5C0
	public void set_positionLocal(Vector3 value) { }

	// RVA: 0x82C540 Offset: 0x82AB40 VA: 0x18082C540
	public Vector3 get_positionWorld() { }

	// RVA: 0x82C610 Offset: 0x82AC10 VA: 0x18082C610
	public void set_positionWorld(Vector3 value) { }

	// RVA: 0x82BF40 Offset: 0x82A540 VA: 0x18082BF40
	public void SetOwnerGame(BaseArcadeGame ownerGame) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void Initialize() { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public bool IsAuthorative() { }

	// RVA: 0x82BDD0 Offset: 0x82A3D0 VA: 0x18082BDD0
	public void SetAuthorative(bool wants) { }

	// RVA: 0x82C3F0 Offset: 0x82A9F0 VA: 0x18082C3F0
	public void SetSprite(Sprite newSprite) { }

	// RVA: 0x82C440 Offset: 0x82AA40 VA: 0x18082C440 Slot: 7
	public virtual void Shutdown() { }

	// RVA: 0x82C340 Offset: 0x82A940 VA: 0x18082C340
	public void SetPositionWorld(Vector3 newPos) { }

	// RVA: 0x82BDE0 Offset: 0x82A3E0 VA: 0x18082BDE0
	public void SetHeading(Vector3 heading) { }

	// RVA: 0x82C2D0 Offset: 0x82A8D0 VA: 0x18082C2D0
	public void SetPositionLocal(Vector3 newPos) { }

	// RVA: 0x82BDB0 Offset: 0x82A3B0 VA: 0x18082BDB0
	public void OnDisable() { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

